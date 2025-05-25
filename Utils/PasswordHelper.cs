using Microsoft.AspNetCore.Identity;

namespace Internet_Kafe_Proje.Utils
{
    class PasswordHelper
    {
        private static readonly PasswordHasher<object> hasher = new();

        // Hash'li şifre yarat
        public static string HashPassword(string plainPassword)
        {
            return hasher.HashPassword(new object(), plainPassword);
        }

        // Hash'li şifreyi hash'lenmemiş şifre ile karşılaştır
        public static bool VerifyPassword(string hashedPassword, string plainPassword)
        {
            var result = hasher.VerifyHashedPassword(new object(), hashedPassword, plainPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
