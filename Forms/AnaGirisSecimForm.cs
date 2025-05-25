using Internet_Kafe_Proje.Session;

namespace Internet_Kafe_Proje.Forms
{
    public partial class AnaGirisSecimForm: Form
    {
        public AnaGirisSecimForm()
        {
            InitializeComponent();

            var kullanici = Oturum.AktifKullanici;
            if (kullanici == null)
            {
                Console.WriteLine("No session initialized.");
                return;
            }

            Console.WriteLine($"Logged in as {kullanici.Username}");

            // Logic to automatically open the dashboard

            // DashboardForm dashboardForm = new();
            // dashboardForm.Show();
            // this.Hide();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new();
            girisForm.Show();
            this.Hide();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new();
            kayitForm.Show();
            this.Hide();
        }
    }
}
