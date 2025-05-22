namespace Internet_Kafe_Proje.Session
{
    internal class Kullanici
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required decimal Balance { get; set; }
        public required bool IsAdmin { get; set; }
    }

    internal class Oturum
    {
        internal static Kullanici? AktifKullanici { get; set; }
    }
}
