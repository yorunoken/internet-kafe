namespace Internet_Kafe_Proje.GirisFormlari
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new Panel();
            labelWelcome = new Label();
            ButtonLogin = new Button();
            ButtonRegister = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(labelWelcome);
            panelMain.Controls.Add(ButtonLogin);
            panelMain.Controls.Add(ButtonRegister);
            panelMain.Location = new Point(200, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(400, 250);
            panelMain.TabIndex = 0;
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.Teal;
            labelWelcome.Location = new Point(0, 20);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(400, 40);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "İnternet Kafeye Hoş Geldiniz!";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.Teal;
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(75, 90);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(250, 40);
            ButtonLogin.TabIndex = 1;
            ButtonLogin.Text = "Giriş Yap";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // ButtonRegister
            // 
            ButtonRegister.BackColor = Color.SeaGreen;
            ButtonRegister.Cursor = Cursors.Hand;
            ButtonRegister.FlatStyle = FlatStyle.Flat;
            ButtonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ButtonRegister.ForeColor = Color.White;
            ButtonRegister.Location = new Point(75, 150);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(250, 40);
            ButtonRegister.TabIndex = 2;
            ButtonRegister.Text = "Kayıt Ol";
            ButtonRegister.UseVisualStyleBackColor = false;
            ButtonRegister.Click += ButtonRegister_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}