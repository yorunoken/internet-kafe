using MySql.Data.MySqlClient;
using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Session;

namespace Internet_Kafe_Proje.VeriTabani
{
    internal class Kullanicilar
    {
        private const decimal DefaultBalance = 0.0M;

        internal static Kullanici UserSignup(string username, string plainPassword)
        {
            using var databaseManager = new DatabaseManager();

            string hashedPassword = PasswordHelper.HashPassword(plainPassword);

            string sql = @"
                INSERT INTO users (username, password)
                VALUES (@username, @hashed_password);
                SELECT LAST_INSERT_ID() AS id;
            ";

            var parameters = new MySqlParameter[]
            {
                new("@username", username),
                new("@hashed_password", hashedPassword)
            };

            var resultTable = databaseManager.ExecuteQuery(sql, parameters);

            int id = Convert.ToInt32(resultTable.Rows[0]["id"]);

            return new Kullanici { Id = id, Username = username, Balance = DefaultBalance, IsAdmin = false };
        }

        internal static Kullanici? UserLogin(string username, string plainPassword, bool isAdminLogin)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, password, balance, is_admin FROM users WHERE username = @username";
            var parameters = new MySqlParameter[]
            {
                new("@username", username)
            };

            var resultTable = databaseManager.ExecuteQuery(sql, parameters);
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
    }
}
