using MySql.Data.MySqlClient;
using Internet_Kafe_Proje.Utils.PasswordHelper;
using Internet_Kafe_Proje.Session;

namespace Internet_Kafe_Proje.VeriTabani
{
    public class Kullanicilar
    {
        internal static Kullanici KullaniciKayit(string username, string plainPassword)
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

            return new Kullanici { Id = id, Username = username };
        }

        internal static Kullanici? KullaniciGiris(string username, string plainPassword)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT id, password FROM users WHERE username = @username";
            var parameters = new MySqlParameter[]
            {
                new("@username", username)
            };

            var result = databaseManager.ExecuteQuery(sql, parameters).Rows[0];
            if (result == null)
            {
                return null;
            }

            int id = Convert.ToInt32(result["id"]);
            string? hashedPassword = Convert.ToString(result["password"]);
            if (hashedPassword == null)
            {
                return null;
            }

            bool passwordCorrect = PasswordHelper.VerifyPassword(hashedPassword, plainPassword);

            return passwordCorrect ? new Kullanici { Id = id, Username = username } : null;
        }
    }
}
