using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class UrunYonet : Form
    {
        public UrunYonet()
        {
            InitializeComponent();
            LoadItems(); // Form açılırken ürünleri yükle
        }

        // Ürünleri DataGridView'e yükler
        private void LoadItems()
        {
            var items = Items.GetAllItems();
            dataGridViewItems.DataSource = items;
        }

        // Tablo satırı seçildiğinde textbox'lara verileri aktarır
        private void SelectedDataGrid(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                var row = dataGridViewItems.SelectedRows[0];
                textBoxItemName.Text = row.Cells["Name"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        // Yeni ürün ekler
        private void CreateItem(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPrice.Text) || string.IsNullOrEmpty(textBoxItemName.Text)) {
                MessageBoxes.Error("Lütfen bütün kutucukları doldurun");
                return;
            }
            string name = textBoxItemName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            Items.InsertItem(name, price);
            LoadItems();
            MessageBoxes.Success("Ürün eklendi.");
        }

        // Seçili ürünü günceller
        private void UpdateItem(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                var row = dataGridViewItems.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                string name = textBoxItemName.Text;
                decimal price = Convert.ToDecimal(textBoxPrice.Text);

                Items.UpdateItem(new ItemUpdateArgs
                {
                    Id = id,
                    Name = name,
                    Price = price,
                });
                LoadItems();

                MessageBoxes.Success("Ürün güncellendi.");
            }
        }

        // Seçili ürünü siler
        private void DeleteItem(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewItems.SelectedRows[0].Cells["Id"].Value);
                Items.DeleteItemById(id);
                LoadItems();
                MessageBoxes.Success("Ürün silindi.");
            }
        }

        // Formdaki alanları temizler
        private void ClearFields(object sender, EventArgs e)
        {
            textBoxItemName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            dataGridViewItems.ClearSelection();
        }

        // Yenile butonu için
        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminDashboard().Show();
        }
    }
}
