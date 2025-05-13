using MySql.Data.MySqlClient;
using Internet_Kafe_Proje.Utils.PasswordHelper;

namespace Internet_Kafe_Proje.VeriTabani
{
    public class Kullanicilar
    {
        public static void KullaniciKayit(string username, string plainPassword)
        {
            using var databaseManager = new DatabaseManager();

            string hashedPassword = PasswordHelper.HashPassword(plainPassword);

            string sql = "INSERT INTO users (username, password) VALUES (@username, @hashed_password)";
            var parameters = new MySqlParameter[]
            {
                new("@username", username),
                new("@hashed_password", hashedPassword)
            };

            databaseManager.ExecuteNonQuery(sql, parameters);
        }

        public static bool KullaniciGiris(string username, string plainPassword)
        {
            using var databaseManager = new DatabaseManager();

            string sql = "SELECT password FROM users WHERE username = @username";
            var parameters = new MySqlParameter[]
            {
                new("@username", username)
            };

            var result = databaseManager.GetSingle(sql, parameters);
            if (result == null)
            {
                return false;
            }


            string? hashedPassword = Convert.ToString(result);
            if (hashedPassword == null)
            {
                return false;
            }

            return PasswordHelper.VerifyPassword(hashedPassword, plainPassword);
        }
    }
}
