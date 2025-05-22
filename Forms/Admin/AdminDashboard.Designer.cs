namespace Internet_Kafe_Proje.Forms.Admin
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
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.panelDashboard.SuspendLayout();

            // 
            // AdminDashboard (Form)
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "Admin Panel";

            // 
            // panelDashboard
            // 
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDashboard.Controls.Add(this.labelTitle);
            this.panelDashboard.Controls.Add(this.buttonUsers);
            this.panelDashboard.Controls.Add(this.buttonItems);
            this.panelDashboard.Controls.Add(this.buttonOrders);

            // 
            // labelTitle
            // 
            this.labelTitle.Text = "Yönetici Paneli";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Height = 70;

            // 
            // buttonUsers
            // 
            this.buttonUsers.Text = "Kullanıcıları Yönet";
            this.buttonUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonUsers.BackColor = System.Drawing.Color.Teal;
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.Size = new System.Drawing.Size(220, 55);
            this.buttonUsers.Location = new System.Drawing.Point((800 - 220) / 2, 100);
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 220, 55, 10, 10));
            buttonUsers.MouseEnter += Button_MouseEnter;
            buttonUsers.MouseLeave += Button_MouseLeave;

            // 
            // buttonItems
            // 
            this.buttonItems.Text = "Ürünleri Yönet";
            this.buttonItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonItems.BackColor = System.Drawing.Color.Teal;
            this.buttonItems.ForeColor = System.Drawing.Color.White;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.Size = new System.Drawing.Size(220, 55);
            this.buttonItems.Location = new System.Drawing.Point((800 - 220) / 2, 180);
            this.buttonItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonItems.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 220, 55, 10, 10));
            buttonItems.MouseEnter += Button_MouseEnter;
            buttonItems.MouseLeave += Button_MouseLeave;

            // 
            // buttonOrders
            // 
            this.buttonOrders.Text = "Siparişleri Yönet";
            this.buttonOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonOrders.BackColor = System.Drawing.Color.Teal;
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.Size = new System.Drawing.Size(220, 55);
            this.buttonOrders.Location = new System.Drawing.Point((800 - 220) / 2, 260);
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 220, 55, 10, 10));
            buttonOrders.MouseEnter += Button_MouseEnter;
            buttonOrders.MouseLeave += Button_MouseLeave;

            // 
            // Add panel to form
            // 
            this.Controls.Add(this.panelDashboard);

            this.panelDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );
    }
}
