using Internet_Kafe_Proje.Session;
using Internet_Kafe_Proje.Utils;
using Microsoft.VisualBasic.ApplicationServices;

namespace Internet_Kafe_Proje.Forms
{
    public partial class AnaSayfa : Form
    {
        private System.Windows.Forms.Timer countdownTimer = null!;
        private DateTime? sessionEndTime;

        public AnaSayfa()
        {
            InitializeComponent();

            var user = Oturum.AktifKullanici;
            if (user == null)
            {
                this.Close();
                return;
            }

            sessionEndTime = user.SessionEndTime;

            countdownTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            UpdateBalanceLabel(user.Balance);
            UpdateTimeLeftLabel();
        }

        private void UpdateBalanceLabel(decimal balance)
        {

            LabelBalance.Text = $"Bakiye: ₺{balance:F2}";
            Console.WriteLine($"Balance inside UpdateBalanceLabel: {balance:F2}"); // 10098.00
        }

        private void UpdateTimeLeftLabel()
        {
            if (sessionEndTime == null)
            {
                LabelTimeLeft.Text = "Kalan Süre: 00:00:00";
                return;
            }

            TimeSpan timeLeft = sessionEndTime.Value - DateTime.Now;
            if (timeLeft <= TimeSpan.Zero)
            {
                LabelTimeLeft.Text = "Süre doldu!";
                countdownTimer.Stop();
            }
            else
            {
                LabelTimeLeft.Text = "Kalan Süre: " + timeLeft.ToString(@"hh\:mm\:ss");
            }
        }

        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            UpdateTimeLeftLabel();
        }

        private static void OnTimeUp()
        {
            MessageBoxes.Error("Süreniz bitmiştir.");
        }

        private void ButtonMarket_Click(object sender, EventArgs e)
        {
            new MarketForm().Show();
            this.Hide();
        }

        private void ButtonAddBalance_Click(object sender, EventArgs e)
        {
            new BakiyeYuklemeForm().Show();
            this.Hide();
        }

        private void ButtonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
