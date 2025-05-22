namespace Internet_Kafe_Proje.Forms
{
    partial class GirisForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxAdmin;

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
            panelLogin = new Panel();
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelError = new Label();
            ButtonLogin = new Button();
            checkBoxAdmin = new CheckBox();
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
            panelLogin.Controls.Add(labelError);
            panelLogin.Controls.Add(ButtonLogin);
            panelLogin.Controls.Add(checkBoxAdmin);
            panelLogin.Location = new Point(250, 100);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(300, 280);
            panelLogin.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateGray;
            labelTitle.Location = new Point(0, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Hoş Geldiniz";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(20, 65);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(260, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullancı Adı";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(20, 85);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(260, 25);
            textBoxUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(20, 120);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(260, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Şifre";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(20, 140);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(260, 25);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(20, 280);
            labelError.Name = "labelError";
            labelError.Size = new Size(260, 20);
            labelError.TabIndex = 6;
            labelError.Text = "Hata mesajı buraya gelecek.";
            labelError.Visible = false;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.Teal;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(20, 190);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(260, 35);
            ButtonLogin.TabIndex = 3;
            ButtonLogin.Text = "Giriş Yap";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            //
            // checkBoxAdmin
            //
            checkBoxAdmin.Font = new Font("Segoe UI", 9F);
            checkBoxAdmin.Location = new Point(20, 170);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(260, 20);
            checkBoxAdmin.TabIndex = 4;
            checkBoxAdmin.Text = "Yönetici olarak giriş yap";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // GirisForm
            // 
            AcceptButton = ButtonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            MaximizeBox = false;
            Name = "GirisForm";
            Text = "Giriş";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}