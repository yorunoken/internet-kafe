using System.Data;
using Internet_Kafe_Proje.Session;
using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.VeriTabani;

namespace Internet_Kafe_Proje.Forms
{
    public partial class MarketForm: Form
    {
        private readonly Kullanici? user;
        private decimal balance;

        public MarketForm()
        {
            InitializeComponent();

            user = Oturum.AktifKullanici;
            if (user == null)
            {
                MessageBoxes.ErrorBox("Aktif bir oturum bulunmamaktadır. Lütfen giriş yapın.");
                return;
            } 

            labelWelcome.Text = $"Hoşgeldin, {user.Username}";

            LoadItems();
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            labelBalance.Text = $"Bakiyen: {balance}₺";
        }

        private void LoadItems()
        {
            var items = new List<(string name, decimal price)>();

            foreach (DataRow row in Itemler.GetAllItems().Rows)
            {
                string name = Convert.ToString(row["name"]) ?? "";
                decimal price = Convert.ToDecimal(row["price"]);
                items.Add((name, price));   
            }

            foreach (var (name, price) in items)
            {
                var itemPanel = new Panel
                {
                    Width = 140,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                var nameLabel = new Label
                {
                    Text = name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                var priceLabel = new Label
                {
                    Text = $"Fiyat: {price}₺",
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                var buyButton = new Button
                {
                    Text = "Satın Al",
                    Location = new Point(10, 60),
                    Width = 100,
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.White
                };

                buyButton.Click += (s, e) =>
                {
                    if (balance >= price)
                    {
                        balance -= price;
                        UpdateBalanceLabel();
                        MessageBox.Show($"{name} satın alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(buyButton);
                panelItems.Controls.Add(itemPanel);
            }
        }
    }
}
