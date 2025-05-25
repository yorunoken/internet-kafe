using System.Data;
using Internet_Kafe_Proje.Session;
using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms
{
    public partial class MarketForm : Form
    {
        private readonly Kullanici? user;

        public MarketForm()
        {
            InitializeComponent();

            user = Oturum.AktifKullanici;
            if (user == null)
            {
                MessageBoxes.Error("Aktif bir oturum bulunmamaktadır. Lütfen giriş yapın.");
                return;
            }

            labelWelcome.Text = $"Hoşgeldin, {user.Username}";

            LoadItems();
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            labelBalance.Text = $"Bakiyen: {user!.Balance}₺";
        }

        private void LoadItems()
        {
            var items = new List<(string name, decimal price, int id)>();

            foreach (DataRow row in Items.GetAllItems().Rows)
            {
                string name = Convert.ToString(row["name"]) ?? "";
                decimal price = Convert.ToDecimal(row["price"]);
                int id = Convert.ToInt32(row["id"]);
                items.Add((name, price, id));
            }

            foreach (var (name, price, id) in items)
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
                    try
                    {
                        Users.OrderItem(user!, id);
                        UpdateBalanceLabel();
                        MessageBoxes.Success($"{name} satın alındı!");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxes.Error(ex.Message);
                    }
                };

                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(buyButton);
                panelItems.Controls.Add(itemPanel);
            }
        }

        private void MoneyBuyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BakiyeYuklemeForm().Show();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AnaSayfa().Show();
        }
    }
}
