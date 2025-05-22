namespace Internet_Kafe_Proje.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelDashboard;
        private Label labelTitle;
        private Button buttonUsers;
        private Button buttonItems;
        private Button buttonOrders;

        private void InitializeComponent()
        {
            panelDashboard = new Panel();
            labelTitle = new Label();
            buttonUsers = new Button();
            buttonItems = new Button();
            buttonOrders = new Button();

            // 
            // panelDashboard
            // 
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.BackColor = Color.FromArgb(245, 245, 245);
            panelDashboard.Controls.Add(labelTitle);
            panelDashboard.Controls.Add(buttonUsers);
            panelDashboard.Controls.Add(buttonItems);
            panelDashboard.Controls.Add(buttonOrders);
            Controls.Add(panelDashboard);

            // 
            // labelTitle
            // 
            labelTitle.Text = "Yönetici Paneli";
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateGray;
            labelTitle.AutoSize = false;
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Height = 80;

            // 
            // buttonUsers
            // 
            buttonUsers.Text = "Kullanıcıları Yönet";
            buttonUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonUsers.BackColor = Color.Teal;
            buttonUsers.ForeColor = Color.White;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.Size = new Size(220, 55);
            buttonUsers.Location = new Point((800 - 220) / 2, 120);
            buttonUsers.Cursor = Cursors.Hand;
            buttonUsers.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonUsers.Width, buttonUsers.Height, 10, 10));
            buttonUsers.MouseEnter += (s, e) => buttonUsers.BackColor = Color.DarkCyan;
            buttonUsers.MouseLeave += (s, e) => buttonUsers.BackColor = Color.Teal;

            // 
            // buttonItems
            // 
            buttonItems.Text = "Ürünleri Yönet";
            buttonItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonItems.BackColor = Color.Teal;
            buttonItems.ForeColor = Color.White;
            buttonItems.FlatStyle = FlatStyle.Flat;
            buttonItems.FlatAppearance.BorderSize = 0;
            buttonItems.Size = new Size(220, 55);
            buttonItems.Location = new Point((800 - 220) / 2, 200);
            buttonItems.Cursor = Cursors.Hand;
            buttonItems.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonItems.Width, buttonItems.Height, 10, 10));
            buttonItems.MouseEnter += (s, e) => buttonItems.BackColor = Color.DarkCyan;
            buttonItems.MouseLeave += (s, e) => buttonItems.BackColor = Color.Teal;

            // 
            // buttonOrders
            // 
            buttonOrders.Text = "Siparişleri Yönet";
            buttonOrders.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOrders.BackColor = Color.Teal;
            buttonOrders.ForeColor = Color.White;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.Size = new Size(220, 55);
            buttonOrders.Location = new Point((800 - 220) / 2, 280);
            buttonOrders.Cursor = Cursors.Hand;
            buttonOrders.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOrders.Width, buttonOrders.Height, 10, 10));
            buttonOrders.MouseEnter += (s, e) => buttonOrders.BackColor = Color.DarkCyan;
            buttonOrders.MouseLeave += (s, e) => buttonOrders.BackColor = Color.Teal;

            // 
            // AdminDashboard
            // 
            ClientSize = new Size(800, 450);
            Text = "Yönetici Paneli";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

    }
}