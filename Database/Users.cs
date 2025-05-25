using MySql.Data.MySqlClient;
using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Session;

namespace Internet_Kafe_Proje.Database
{
    internal class Users
    {
        private const decimal DEFAULT_BALANCE = 0.0M;

        internal static List<Kullanici> GetAllUsers()
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, username, balance, is_admin FROM users";
            var resultTable = databaseManager.ExecuteQuery(sql);

            var users = new List<Kullanici>();

            foreach (System.Data.DataRow row in resultTable.Rows)
            {
                var user = new Kullanici
                {
                    Id = Convert.ToInt32(row["id"]),
                    Username = Convert.ToString(row["username"]) ?? "",
                    Balance = Convert.ToDecimal(row["balance"]),
                    IsAdmin = Convert.ToBoolean(row["is_admin"])
                };

                users.Add(user);
            }

            return users;
        }

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

            // Check if username exits
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

        internal static Kullanici? UserLogin(string username, string plainPassword, bool isAdminLogin)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, password, balance, is_admin FROM users WHERE username = @username";
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

            bool passwordCorrect = PasswordHelper.VerifyPassword(hashedPassword, plainPassword);

            return passwordCorrect ? new Kullanici { Id = id, Username = username, Balance = balance, IsAdmin = isAdminFromDb && isAdminLogin } : null;
        }

        internal static void DeleteUserById(int id)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "DELETE FROM users WHERE id = @userId";
            var parameter = new MySqlParameter("@userId", id);
            databaseManager.ExecuteNonQuery(sql, parameter);
        }

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

            if (!string.IsNullOrEmpty(plainPassword))
            {
                string hashedPassword = PasswordHelper.HashPassword(plainPassword);
                sql = @"UPDATE users SET username = @username, password = @password, is_admin = @isAdmin WHERE id = @id";
                parameters.Add(new MySqlParameter("@password", hashedPassword));
            }

            databaseManager.ExecuteNonQuery(sql, [.. parameters]);
        }

        internal static void OrderItem(Kullanici user, int itemId)
        {
            using var databaseManager = new DatabaseManager();

            // Eşyanın fiyatını al
            string getItemSql = "SELECT price FROM items WHERE id = @itemId";
            var priceObj = databaseManager.GetSingle(getItemSql, new MySqlParameter("@itemId", itemId));
            if (priceObj == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }
            decimal price = Convert.ToDecimal(priceObj);

            // Kullanıcının güncel parasını al
            string getBalanceSql = "SELECT balance FROM users WHERE id = @userId";
            var balanceObj = databaseManager.GetSingle(getBalanceSql, new MySqlParameter("@userId", user.Id));
            if (balanceObj == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
            int userBalance = Convert.ToInt32(balanceObj);

            // Eğer kullanıcının güncel parası eşyanın parasından az ise, hata ver
            if (userBalance < price)
            {
                throw new Exception("Yetersiz bakiye.");
            }

            string updateBalanceSql = "UPDATE users SET balance = balance - @price WHERE id = @userId";
            databaseManager.ExecuteNonQuery(updateBalanceSql,
                new MySqlParameter("@price", price),
                new MySqlParameter("@userId", user.Id)
            );

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
    }
}
