using Microsoft.AspNetCore.Identity;

namespace Internet_Kafe_Proje.Utils.PasswordHelper
{
    class PasswordHelper
    {
        private static readonly PasswordHasher<object> hasher = new();

        public static string HashPassword(string plainPassword)
        {
            return hasher.HashPassword(new object(), plainPassword);
        }

        public static bool VerifyPassword(string hashedPassword, string plainPassword)
        {
            var result = hasher.VerifyHashedPassword(new object(), hashedPassword, plainPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
