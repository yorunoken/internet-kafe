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
        private System.Windows.Forms.Button buttonBack;

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
            buttonBack = new Button();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            //
            // panelDashboard
            //
            panelDashboard.BackColor = Color.FromArgb(245, 245, 245);
            panelDashboard.Controls.Add(labelTitle);
            panelDashboard.Controls.Add(buttonUsers);
            panelDashboard.Controls.Add(buttonItems);
            panelDashboard.Controls.Add(buttonOrders);
            panelDashboard.Controls.Add(buttonBack);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(788, 375);
            panelDashboard.TabIndex = 0;
            //
            // labelTitle
            //
            labelTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(30, 30, 30);
            labelTitle.Location = new Point(0, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(788, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Yönetici Paneli";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // buttonUsers
            //
            buttonUsers.BackColor = Color.FromArgb(55, 90, 120);
            buttonUsers.Cursor = Cursors.Hand;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            buttonUsers.ForeColor = Color.White;
            buttonUsers.Location = new Point(280, 90);
            buttonUsers.Margin = new Padding(3, 2, 3, 2);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(228, 52);
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "Kullanıcıları Yönet";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += GoToUsers;
            //
            // buttonItems
            //
            buttonItems.BackColor = Color.FromArgb(55, 90, 120);
            buttonItems.Cursor = Cursors.Hand;
            buttonItems.FlatAppearance.BorderSize = 0;
            buttonItems.FlatStyle = FlatStyle.Flat;
            buttonItems.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            buttonItems.ForeColor = Color.White;
            buttonItems.Location = new Point(280, 158);
            buttonItems.Margin = new Padding(3, 2, 3, 2);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(228, 52);
            buttonItems.TabIndex = 2;
            buttonItems.Text = "Ürünleri Yönet";
            buttonItems.UseVisualStyleBackColor = false;
            buttonItems.Click += GoToItems;
            //
            // buttonOrders
            //
            buttonOrders.BackColor = Color.FromArgb(55, 90, 120);
            buttonOrders.Cursor = Cursors.Hand;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            buttonOrders.ForeColor = Color.White;
            buttonOrders.Location = new Point(280, 225);
            buttonOrders.Margin = new Padding(3, 2, 3, 2);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(228, 52);
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "Siparişleri Yönet";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += GoToOrders;
            //
            // buttonBack
            //
            buttonBack.BackColor = Color.IndianRed;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(280, 292);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(228, 44);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Çıkış Yap";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += GoBack;
            //
            // AdminDashboard
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 375);
            Controls.Add(panelDashboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            panelDashboard.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
