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

            return new Kullanici { Id = id, Username = username, Balance = DefaultBalance };
        }

        internal static Kullanici? UserLogin(string username, string plainPassword)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, password, balance FROM users WHERE username = @username";
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
            string? hashedPassword = Convert.ToString(result["password"]);
            if (hashedPassword == null)
            {
                return null;
            }

            bool passwordCorrect = PasswordHelper.VerifyPassword(hashedPassword, plainPassword);

            return passwordCorrect ? new Kullanici { Id = id, Username = username, Balance = balance } : null;
        }

        internal static void PurchaseItem(Kullanici user, int itemId)
        {
            using var databaseManager = new DatabaseManager();

            string getItemSql = "SELECT price FROM items WHERE id = @itemId";
            var priceObj = databaseManager.GetSingle(getItemSql, new MySqlParameter("@itemId", itemId));
            if (priceObj == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }

            decimal price = Convert.ToDecimal(priceObj);

            if (user.Balance < price)
            {
                throw new Exception("Yetersiz bakiye.");
            }

            string updateBalanceSql = "UPDATE users SET balance = balance - @price WHERE id = @userId";
            databaseManager.ExecuteNonQuery(updateBalanceSql,
                new MySqlParameter("@price", price),
                new MySqlParameter("@userId", user.Id)
            );

            string checkInventorySql = "SELECT id, quantity FROM user_items WHERE user_id = @userId AND item_id = @itemId";
            var inventoryTable = databaseManager.ExecuteQuery(checkInventorySql,
                new MySqlParameter("@userId", user.Id),
                new MySqlParameter("@itemId", itemId)
            );

            if (inventoryTable.Rows.Count > 0)
            {
                int currentQty = Convert.ToInt32(inventoryTable.Rows[0]["quantity"]);
                int inventoryId = Convert.ToInt32(inventoryTable.Rows[0]["id"]);

                string updateQtySql = "UPDATE user_items SET quantity = @qty WHERE id = @id";
                databaseManager.ExecuteNonQuery(updateQtySql,
                    new MySqlParameter("@qty", currentQty + 1),
                    new MySqlParameter("@id", inventoryId)
                );
            }
            else
            {
                string insertItemSql = "INSERT INTO user_items (user_id, item_id, quantity) VALUES (@userId, @itemId, 1)";
                databaseManager.ExecuteNonQuery(insertItemSql,
                    new MySqlParameter("@userId", user.Id),
                    new MySqlParameter("@itemId", itemId)
                );
            }

            user.Balance -= price;
        }
    }
}
