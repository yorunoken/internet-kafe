using Internet_Kafe_Proje.Utils;
using Internet_Kafe_Proje.Database;

namespace Internet_Kafe_Proje.Forms.Admin
{
    public partial class KullaniciYonet : Form
    {
        public KullaniciYonet()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = Users.GetAllUsers();
            dataGridViewUsers.DataSource = users;
        }

        private void SelectedDataGrid(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                textBoxUsername.Text = row.Cells["Username"].Value.ToString();
                textBoxPassword.Text = String.Empty;
                textBoxBalance.Text = Convert.ToDecimal(row.Cells["Balance"].Value).ToString();
                checkBoxIsAdmin.Checked = Convert.ToBoolean(row.Cells["IsAdmin"].Value);
            }
        }

        private void CreateUser(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            decimal? balance = textBoxBalance.Text != "" ? Convert.ToDecimal(textBoxBalance.Text) : null;
            bool isAdmin = checkBoxIsAdmin.Checked;

            try
            {
                Users.UserSignup(username, password, balance, isAdmin);
                MessageBoxes.Success("Kullanıcı oluşturuldu.");
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                MessageBoxes.Error(ex.Message);
            }
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                int userId = Convert.ToInt32(row.Cells["Id"].Value);

                Users.DeleteUserById(userId);
                LoadUsers();
                MessageBoxes.Success("Kullanıcı silindi.");
            }
            else
            {
                MessageBoxes.Error("Silmek için bir kullanıcı seçin.");
            }
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                int userId = Convert.ToInt32(row.Cells["Id"].Value);

                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                bool isAdmin = checkBoxIsAdmin.Checked;
                decimal balance = Convert.ToDecimal(textBoxBalance.Text);

                Users.UpdateUser(userId, username, balance, password, isAdmin);
                LoadUsers();
                MessageBoxes.Success("Kullanıcı güncellendi.");
            }
            else
            {
                MessageBoxes.Error("Güncellemek için bir kullanıcı seçin.");
            }
        }

        private void ClearSelection(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxBalance.Text = string.Empty;
            checkBoxIsAdmin.Checked = false;
            dataGridViewUsers.ClearSelection();
        }

        private void ButtonAddTime_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBoxes.Error("Lütfen süre eklemek için bir kullanıcı seçin.");
                return;
            }

            if (!int.TryParse(textBoxExtraTime.Text, out int extraMinutes) || extraMinutes <= 0)
            {
                MessageBoxes.Error("Lütfen geçerli bir ekstra süre (dakika) girin.");
                return;
            }

            var selectedRow = dataGridViewUsers.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            try
            {
                // Assuming you have a method in your Users class to add time, like this:
                Users.AddSessionTime(userId, TimeSpan.FromMinutes(extraMinutes));
                MessageBoxes.Success($"Kullanıcının süresine {extraMinutes} dakika eklendi.");

                // Optionally refresh user list or selected data
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBoxes.Error("Süre eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminDashboard().Show();
        }
    }
}
