namespace Internet_Kafe_Proje.Forms
{
    partial class GirisForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label labelError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelLogin = new Panel();
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            checkBoxAdmin = new CheckBox();
            ButtonLogin = new Button();
            ButtonBack = new Button();
            labelError = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(labelTitle);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(checkBoxAdmin);
            panelLogin.Controls.Add(ButtonLogin);
            panelLogin.Controls.Add(ButtonBack);
            panelLogin.Controls.Add(labelError);
            panelLogin.Location = new Point(303, 49);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(343, 479);
            panelLogin.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateGray;
            labelTitle.Location = new Point(0, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(343, 53);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Hoş Geldiniz";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(23, 87);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(297, 27);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullanıcı Adı";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(23, 113);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(297, 30);
            textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(23, 160);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(297, 27);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Şifre";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(23, 187);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(297, 30);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.Font = new Font("Segoe UI", 9F);
            checkBoxAdmin.Location = new Point(23, 227);
            checkBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(297, 27);
            checkBoxAdmin.TabIndex = 5;
            checkBoxAdmin.Text = "Yönetici olarak giriş yap";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.Teal;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(23, 267);
            ButtonLogin.Margin = new Padding(3, 4, 3, 4);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(297, 47);
            ButtonLogin.TabIndex = 6;
            ButtonLogin.Text = "Giriş Yap";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.IndianRed;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Location = new Point(23, 320);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(297, 40);
            ButtonBack.TabIndex = 7;
            ButtonBack.Text = "Geri Dön";
            ButtonBack.UseVisualStyleBackColor = false;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(23, 373);
            labelError.Name = "labelError";
            labelError.Size = new Size(297, 64);
            labelError.TabIndex = 8;
            labelError.Text = "Hata mesajı buraya gelecek.";
            labelError.Visible = false;
            // 
            // GirisForm
            // 
            AcceptButton = ButtonLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(914, 600);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}
