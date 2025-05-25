using Internet_Kafe_Proje.Session;
using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms
{
    public partial class BakiyeYuklemeForm : Form
    {
        private readonly Kullanici? user;

        public BakiyeYuklemeForm()
        {
            InitializeComponent();

            user = Oturum.AktifKullanici;
            if (user == null)
            {
                MessageBoxes.Error("Kullanıcı giriş yapmamıştır.");
                return;
            }

            UpdateMoneyLabel();
        }

        private void UpdateMoneyLabel()
        {
            label1.Text = $"Güncel Bakiye: \n{user!.Balance}₺";
        }

        private void ButtonBuy50_Click(object sender, EventArgs e)
        {
            user!.Balance += 50;
            UpdateMoneyLabel();
            Users.UpdateBalance(user);
        }

        private void ButtonBuy100_Click(object sender, EventArgs e)
        {
            user!.Balance += 100;
            UpdateMoneyLabel();
            Users.UpdateBalance(user);
        }

        private void ButtonBuy150_Click(object sender, EventArgs e)
        {
            user!.Balance += 150;
            UpdateMoneyLabel();
            Users.UpdateBalance(user);
        }

        private void ButtonBuy200_Click(object sender, EventArgs e)
        {
            user!.Balance += 200;
            UpdateMoneyLabel();
            Users.UpdateBalance(user);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new AnaSayfa().Show();
        }
    }
}
