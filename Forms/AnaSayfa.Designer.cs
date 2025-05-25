namespace Internet_Kafe_Proje.Forms
{
    partial class AnaSayfa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Button ButtonMarket;
        private System.Windows.Forms.Button ButtonAddBalance;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.Button ButtonSignOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LabelTimeLeft = new Label();
            ButtonMarket = new Button();
            ButtonAddBalance = new Button();
            LabelBalance = new Label();
            ButtonSignOut = new Button();
            SuspendLayout();
            // 
            // LabelTimeLeft
            // 
            LabelTimeLeft.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            LabelTimeLeft.ForeColor = Color.DarkBlue;
            LabelTimeLeft.Location = new Point(50, 40);
            LabelTimeLeft.Name = "LabelTimeLeft";
            LabelTimeLeft.Size = new Size(400, 60);
            LabelTimeLeft.TabIndex = 0;
            LabelTimeLeft.Text = "Kalan Süre: 00:00:00";
            LabelTimeLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonMarket
            // 
            ButtonMarket.BackColor = Color.LightSkyBlue;
            ButtonMarket.FlatStyle = FlatStyle.Flat;
            ButtonMarket.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ButtonMarket.Location = new Point(120, 120);
            ButtonMarket.Name = "ButtonMarket";
            ButtonMarket.Size = new Size(260, 45);
            ButtonMarket.TabIndex = 1;
            ButtonMarket.Text = "Markete Git";
            ButtonMarket.UseVisualStyleBackColor = false;
            ButtonMarket.Click += ButtonMarket_Click;
            // 
            // ButtonAddBalance
            // 
            ButtonAddBalance.BackColor = Color.LightGreen;
            ButtonAddBalance.FlatStyle = FlatStyle.Flat;
            ButtonAddBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ButtonAddBalance.Location = new Point(120, 180);
            ButtonAddBalance.Name = "ButtonAddBalance";
            ButtonAddBalance.Size = new Size(260, 45);
            ButtonAddBalance.TabIndex = 2;
            ButtonAddBalance.Text = "Para Yükle";
            ButtonAddBalance.UseVisualStyleBackColor = false;
            ButtonAddBalance.Click += ButtonAddBalance_Click;
            // 
            // LabelBalance
            // 
            LabelBalance.AutoSize = true;
            LabelBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LabelBalance.ForeColor = Color.DarkGreen;
            LabelBalance.Location = new Point(356, 9);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(109, 21);
            LabelBalance.TabIndex = 3;
            LabelBalance.Text = "Bakiye: ₺0.00";
            LabelBalance.TextAlign = ContentAlignment.TopRight;
            // 
            // ButtonSignOut
            // 
            ButtonSignOut.BackColor = Color.IndianRed;
            ButtonSignOut.FlatStyle = FlatStyle.Flat;
            ButtonSignOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonSignOut.ForeColor = Color.White;
            ButtonSignOut.Location = new Point(10, 10);
            ButtonSignOut.Name = "ButtonSignOut";
            ButtonSignOut.Size = new Size(90, 30);
            ButtonSignOut.TabIndex = 4;
            ButtonSignOut.Text = "Çıkış Yap";
            ButtonSignOut.UseVisualStyleBackColor = false;
            ButtonSignOut.Click += ButtonSignOut_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 300);
            Controls.Add(ButtonSignOut);
            Controls.Add(LabelBalance);
            Controls.Add(ButtonAddBalance);
            Controls.Add(ButtonMarket);
            Controls.Add(LabelTimeLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
