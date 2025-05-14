using Internet_Kafe_Proje.Session;
using Internet_Kafe_Proje.VeriTabani;

namespace Internet_Kafe_Proje
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelError.Text = string.Empty;

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Lütfen bütün alanları doldurun.");
                return;
            }

            try
            {
                var kullanici = Kullanicilar.KullaniciGiris(username, password);
                if (kullanici == null)
                {
                    ShowError("Giriş yapılırken bir hata ile karşılaşıldı. Lütfen tekrar deneyiniz.");
                    return;
                }

                Oturum.AktifKullanici = kullanici;
                Console.WriteLine($"Logging in as: {kullanici.Username}");
            }
            catch
            {
                ShowError("Giriş yapılırken bir hata ile karşılaşıldı.Lütfen tekrar deneyiniz..");
                return;
            }
        }
    
        private void ShowError(string message)
        {
            labelError.Text = message;
            labelError.Visible = true;
            return;
        } 
    }
}
