using System.Data;
using MySql.Data.MySqlClient;

using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Session;

namespace Internet_Kafe_Proje.Database
{
    internal class Users
    {
        private const decimal DEFAULT_BALANCE = 0.0M;

        // Tüm kullanıcıları veritabanından çeker ve Kullanici listesi olarak döndürür
        internal static List<Kullanici> GetAllUsers()
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, username, balance, is_admin, session_end_time FROM users";
            var resultTable = databaseManager.ExecuteQuery(sql);

            var users = new List<Kullanici>();

            foreach (DataRow row in resultTable.Rows)
            {
                var user = new Kullanici
                {
                    Id = Convert.ToInt32(row["id"]),
                    Username = Convert.ToString(row["username"]) ?? "",
                    Balance = Convert.ToDecimal(row["balance"]),
                    IsAdmin = Convert.ToBoolean(row["is_admin"]),
                    SessionEndTime = row["session_end_time"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(row["session_end_time"])
                };

                users.Add(user);
            }

            return users;
        }

        // Yeni kullanıcı kaydı oluşturur, şifreyi hashler ve benzersiz kullanıcı adı kontrolü yapar
        internal static Kullanici UserSignup(string username, string plainPassword, decimal? startingBalance = null, bool? isAdmin = null)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Boş olamaz: ", nameof(username));
            }

            if (string.IsNullOrEmpty(plainPassword))
            {
                throw new ArgumentException("Boş olamaz: ", nameof(plainPassword));
            }

            using var databaseManager = new DatabaseManager();

            // Kullanıcı adı daha önce alınmış mı kontrolü
            object usrnm = databaseManager.GetSingle("SELECT username FROM users WHERE username = @u", new MySqlParameter("@u", username));
            if (usrnm != null)
            {
                throw new Exception($"Kullanıcı adı zaten kayıtlı: {username}");
            }

            string hashedPassword = PasswordHelper.HashPassword(plainPassword);

            string sql = @"
                INSERT INTO users (username, password, balance, is_admin)
                VALUES (@username, @hashed_password, @startingBalance, @isAdmin);
                SELECT LAST_INSERT_ID() AS id;
            ";

            var parameters = new MySqlParameter[]
            {
                new("@username", username),
                new("@hashed_password", hashedPassword),
                new("@startingBalance", startingBalance ?? DEFAULT_BALANCE),
                new("@isAdmin", isAdmin ?? false),
            };

            var resultTable = databaseManager.ExecuteQuery(sql, parameters);

            int id = Convert.ToInt32(resultTable.Rows[0]["id"]);

            return new Kullanici { Id = id, Username = username, Balance = startingBalance ?? DEFAULT_BALANCE, IsAdmin = false };
        }

        // Kullanıcı girişi yapar, şifreyi doğrular ve admin girişi ise kontrol eder
        internal static Kullanici? UserLogin(string username, string plainPassword, bool isAdminLogin)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, password, balance, is_admin, session_end_time FROM users WHERE username = @username";
            var parameter = new MySqlParameter("@username", username);

            var resultTable = databaseManager.ExecuteQuery(sql, parameter);
            if (resultTable.Rows.Count == 0)
            {
                return null;
            }

            var result = resultTable.Rows[0];

            int id = Convert.ToInt32(result["id"]);
            decimal balance = Convert.ToDecimal(result["balance"]);
            bool isAdminFromDb = Convert.ToBoolean(result["is_admin"]);
            string? hashedPassword = Convert.ToString(result["password"]);

            if (hashedPassword == null)
            {
                return null;
            }

            // Şifreyi kontrol et
            bool passwordCorrect = PasswordHelper.VerifyPassword(hashedPassword, plainPassword);

            if (!passwordCorrect)
            {
                return null;
            }

            DateTime? sessionEndTime = result["session_end_time"] == DBNull.Value
                ? (DateTime?)null
                : Convert.ToDateTime(result["session_end_time"]);

            // Admin girişi ise ve kullanıcı admin değilse giriş başarısız olur
            return new Kullanici
            {
                Id = id,
                Username = username,
                Balance = balance,
                IsAdmin = isAdminFromDb && isAdminLogin,
                SessionEndTime = sessionEndTime
            };
        }

        // Kullanıcıyı id ile siler
        internal static void DeleteUserById(int id)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "DELETE FROM users WHERE id = @userId";
            var parameter = new MySqlParameter("@userId", id);
            databaseManager.ExecuteNonQuery(sql, parameter);
        }

        // Kullanıcı bilgilerini günceller, şifre değişikliği varsa hashler
        internal static void UpdateUser(int id, string username, decimal balance, string? plainPassword = null, bool? isAdmin = false)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"UPDATE users SET username = @username, is_admin = @isAdmin, balance = @balance WHERE id = @id";
            var parameters = new List<MySqlParameter>
            {
                new("@username", username),
                new("@isAdmin", isAdmin),
                new("@balance", balance),
                new("@id", id),
            };

            // Şifre güncellenecekse hashlenir ve sorguya eklenir
            if (!string.IsNullOrEmpty(plainPassword))
            {
                string hashedPassword = PasswordHelper.HashPassword(plainPassword);
                sql = @"UPDATE users SET username = @username, password = @password, is_admin = @isAdmin WHERE id = @id";
                parameters.Add(new MySqlParameter("@password", hashedPassword));
            }

            databaseManager.ExecuteNonQuery(sql, [.. parameters]);
        }

        // Kullanıcıya ürün siparişi verir, bakiyesini kontrol eder ve günceller
        internal static void OrderItem(Kullanici user, int itemId)
        {
            using var databaseManager = new DatabaseManager();

            // Ürünün fiyatını al
            string getItemSql = "SELECT price FROM items WHERE id = @itemId";
            var priceObj = databaseManager.GetSingle(getItemSql, new MySqlParameter("@itemId", itemId));
            if (priceObj == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }
            decimal price = Convert.ToDecimal(priceObj);

            // Kullanıcının güncel bakiyesini al
            string getBalanceSql = "SELECT balance FROM users WHERE id = @userId";
            var balanceObj = databaseManager.GetSingle(getBalanceSql, new MySqlParameter("@userId", user.Id));
            if (balanceObj == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
            int userBalance = Convert.ToInt32(balanceObj);

            // Yetersiz bakiye kontrolü
            if (userBalance < price)
            {
                throw new Exception("Yetersiz bakiye.");
            }

            // Bakiyeden düş
            string updateBalanceSql = "UPDATE users SET balance = balance - @price WHERE id = @userId";
            databaseManager.ExecuteNonQuery(updateBalanceSql,
                new MySqlParameter("@price", price),
                new MySqlParameter("@userId", user.Id)
            );

            // Siparişi kaydet
            string insertOrderSql = @"
                INSERT INTO orders (user_id, item_id)
                VALUES (@userId, @itemId);
            ";

            databaseManager.ExecuteNonQuery(insertOrderSql,
                new MySqlParameter("@userId", user.Id),
                new MySqlParameter("@itemId", itemId)
            );

            user.Balance -= price;
        }

        // Kullanıcının bakiyesini günceller
        internal static void UpdateBalance(Kullanici user)
        {
            using var databaseManager = new DatabaseManager();

            string sql = @"
                UPDATE users SET balance = @newBalance WHERE id = @userId;
            "
            ;

            var parameters = new MySqlParameter[]
            {
                new("@newBalance", user.Balance),
                new("@userId", user.Id)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        // Kullanıcıya oturum süresi ekler, mevcut süresi bitmemişse üzerine ekler
        internal static void AddSessionTime(int userId, TimeSpan duration)
        {
            using var databaseManager = new DatabaseManager();

            // Mevcut session_end_time değerini al
            string selectSql = "SELECT session_end_time FROM users WHERE id = @userId";
            var result = databaseManager.GetSingle(selectSql, new MySqlParameter("@userId", userId));

            DateTime currentEndTime;

            // Eğer mevcut süre varsa ve bitmemişse, ona ekle; yoksa şimdiki zamandan başlat
            if (result != null && DateTime.TryParse(result.ToString(), out DateTime dbEndTime) && dbEndTime > DateTime.Now)
            {
                currentEndTime = dbEndTime;
            }
            else
            {
                currentEndTime = DateTime.Now;
            }

            DateTime newEndTime = currentEndTime.Add(duration);

            string updateSql = "UPDATE users SET session_end_time = @newTime WHERE id = @userId";

            databaseManager.ExecuteNonQuery(updateSql,
                new MySqlParameter("@newTime", newEndTime),
                new MySqlParameter("@userId", userId)
            );
        }

    }
}
