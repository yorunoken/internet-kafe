namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class AdminDashboard: Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }


        // Button animations

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.DarkCyan;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.Teal;
        }

    }
}
