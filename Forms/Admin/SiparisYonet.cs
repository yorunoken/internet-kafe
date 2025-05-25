using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class SiparisYonet : Form
    {
        public SiparisYonet()
        {
            InitializeComponent();
            LoadOrders(); // Form açılırken siparişleri yükle
        }

        // Siparişleri tabloya yükler
        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = Orders.GetAllOrders();
            dataGridViewOrders.DataSource = orders;
            dataGridViewOrders.ClearSelection();
        }

        // Tablo satırı seçilince textbox'lara aktarır
        private void SelectedDataGrid(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var row = dataGridViewOrders.SelectedRows[0];
                textBoxUserId.Text = row.Cells["UserId"].Value.ToString();
                textBoxItemId.Text = row.Cells["ItemId"].Value.ToString();
                textBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                checkBoxDelivered.Checked = Convert.ToBoolean(row.Cells["Delivered"].Value);
            }
        }

        // Seçili siparişi günceller
        private void UpdateOrder(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBoxes.Error("Güncellemek için bir sipariş seçin.");
                return;
            }

            var row = dataGridViewOrders.SelectedRows[0];
            int orderId = Convert.ToInt32(row.Cells["Id"].Value);

            try
            {
                int userId = int.Parse(textBoxUserId.Text);
                int itemId = int.Parse(textBoxItemId.Text);
                int quantity = int.Parse(textBoxQuantity.Text);
                bool isDelivered = checkBoxDelivered.Checked;

                Orders.UpdateOrder(new OrderUpdateArgs
                {
                    Id = orderId,
                    UserId = userId,
                    ItemId = itemId,
                    Quantity = quantity,
                    Delivered = isDelivered
                });

                LoadOrders();
                MessageBoxes.Success("Sipariş güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBoxes.Error("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }

        // Seçili siparişi siler
        private void DeleteOrder(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBoxes.Error("Silmek için bir sipariş seçin.");
                return;
            }

            var row = dataGridViewOrders.SelectedRows[0];
            int orderId = Convert.ToInt32(row.Cells["Id"].Value);

            try
            {
                Orders.DeleteOrderById(orderId);
                LoadOrders();
                MessageBoxes.Success("Sipariş silindi.");
            }
            catch (Exception ex)
            {
                MessageBoxes.Error("Silme sırasında hata oluştu: " + ex.Message);
            }
        }

        // Alanları temizler
        private void ClearFields(object sender, EventArgs e)
        {
            textBoxUserId.Text = string.Empty;
            textBoxItemId.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            checkBoxDelivered.Checked = false;
            dataGridViewOrders.ClearSelection();
        }
    }
}
