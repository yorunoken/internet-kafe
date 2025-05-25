namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Butonların üstüne gelince renk değiştirir
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.FromArgb(65, 110, 140);
        }

        // Butondan ayrılınca eski rengine döner
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.FromArgb(55, 90, 120);
        }

        // Kullanıcı yönetim ekranına geçiş
        private void GoToUsers(object sender, EventArgs e)
        {
            new KullaniciYonet().Show();
            this.Hide();
        }

        // Ürün yönetim ekranına geçiş
        private void GoToItems(object sender, EventArgs e)
        {
            new UrunYonet().Show();
            this.Hide();
        }

        // Sipariş yönetim ekranına geçiş
        private void GoToOrders(object sender, EventArgs e)
        {
            new SiparisYonet().Show();
            this.Hide();
        }

        // Çıkış yapar
        private void GoBack(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
