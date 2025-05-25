using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class UrunYonet : Form
    {
        public UrunYonet()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            var items = Items.GetAllItems(); // You need to implement Items class
            dataGridViewItems.DataSource = items;
        }

        private void SelectedDataGrid(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                var row = dataGridViewItems.SelectedRows[0];
                textBoxItemName.Text = row.Cells["Name"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void CreateItem(object sender, EventArgs e)
        {
            string name = textBoxItemName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
 
            Items.InsertItem(name, price);
            LoadItems();
            MessageBoxes.Success("Ürün eklendi.");
        }

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

        private void ClearFields(object sender, EventArgs e)
        {
            textBoxItemName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            dataGridViewItems.ClearSelection();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadItems();
        }
    }
}
