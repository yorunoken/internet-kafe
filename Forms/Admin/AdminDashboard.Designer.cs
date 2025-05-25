namespace Internet_Kafe_Proje.Forms.Admin
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonOrders;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelDashboard = new Panel();
            labelTitle = new Label();
            buttonUsers = new Button();
            buttonItems = new Button();
            buttonOrders = new Button();

            panelDashboard.SuspendLayout();
            SuspendLayout();

            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.White;
            panelDashboard.Controls.Add(labelTitle);
            panelDashboard.Controls.Add(buttonUsers);
            panelDashboard.Controls.Add(buttonItems);
            panelDashboard.Controls.Add(buttonOrders);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(800, 450);
            panelDashboard.TabIndex = 0;

            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(30, 30, 30);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 80);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Yönetici Paneli";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Style template for buttons
            Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            Size buttonSize = new Size(240, 60);
            Color buttonBackColor = Color.FromArgb(47, 79, 79); // DarkSlateGray
            Color buttonForeColor = Color.White;

            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = buttonBackColor;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.Font = buttonFont;
            buttonUsers.ForeColor = buttonForeColor;
            buttonUsers.Location = new Point(280, 110);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = buttonSize;
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "Kullanıcıları Yönet";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += GoToUsers;
            buttonUsers.MouseEnter += Button_MouseEnter;
            buttonUsers.MouseLeave += Button_MouseLeave;

            // 
            // buttonItems
            // 
            buttonItems.BackColor = buttonBackColor;
            buttonItems.FlatStyle = FlatStyle.Flat;
            buttonItems.FlatAppearance.BorderSize = 0;
            buttonItems.Font = buttonFont;
            buttonItems.ForeColor = buttonForeColor;
            buttonItems.Location = new Point(280, 190);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = buttonSize;
            buttonItems.TabIndex = 2;
            buttonItems.Text = "Ürünleri Yönet";
            buttonItems.UseVisualStyleBackColor = false;
            buttonItems.Click += GoToItems;
            buttonItems.MouseEnter += Button_MouseEnter;
            buttonItems.MouseLeave += Button_MouseLeave;

            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = buttonBackColor;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.Font = buttonFont;
            buttonOrders.ForeColor = buttonForeColor;
            buttonOrders.Location = new Point(280, 270);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = buttonSize;
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "Siparişleri Yönet";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += GoToOrders;
            buttonOrders.MouseEnter += Button_MouseEnter;
            buttonOrders.MouseLeave += Button_MouseLeave;

            // 
            // AdminDashboard
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDashboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            panelDashboard.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
