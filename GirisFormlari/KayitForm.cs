using Internet_Kafe_Proje.VeriTabani;

namespace Internet_Kafe_Proje.GirisFormlari
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelError.Text = string.Empty;

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string passwordConfirm = textBoxConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConfirm))
            {
                ShowError("Lütfen bütün alanları doldurun.");
                return;
            }

            if (password != passwordConfirm)
            {
                ShowError("Lütfen şifrelerin eşleştiğinden emin olun.");
                return;
            }

            try
            {
                Kullanicilar.KullaniciKayit(username, password);
            } catch {
                ShowError("Kayıt oluşturulurken bir hata ile karşılaşıldı. Lütfen tekrar deneyiniz.");
                return;
            }
        }

        private void ShowError(string message)
        {
            labelError.Text = message;
            labelError.Visible = true;
        }
    }
}
