namespace Internet_Kafe_Proje.Utils
{
    public class UsernameAlreadyExistsException(string username) : Exception($"Kullanıcı adı zaten kayıtlı: {username}")
    {
    }
}
