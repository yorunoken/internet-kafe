namespace Internet_Kafe_Proje.Forms
{
    partial class KayitForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button ButtonBack;

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
            panelRegister = new Panel();
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            checkBoxIsAdmin = new CheckBox();
            labelError = new Label();
            ButtonRegister = new Button();
            ButtonBack = new Button();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegister
            // 
            panelRegister.Anchor = AnchorStyles.None;
            panelRegister.BackColor = Color.White;
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(labelTitle);
            panelRegister.Controls.Add(labelUsername);
            panelRegister.Controls.Add(textBoxUsername);
            panelRegister.Controls.Add(labelPassword);
            panelRegister.Controls.Add(textBoxPassword);
            panelRegister.Controls.Add(labelConfirmPassword);
            panelRegister.Controls.Add(textBoxConfirmPassword);
            panelRegister.Controls.Add(checkBoxIsAdmin);
            panelRegister.Controls.Add(labelError);
            panelRegister.Controls.Add(ButtonRegister);
            panelRegister.Controls.Add(ButtonBack);
            panelRegister.Location = new Point(288, 45);
            panelRegister.Margin = new Padding(3, 4, 3, 4);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(343, 515);
            panelRegister.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateGray;
            labelTitle.Location = new Point(0, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(343, 53);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Kayıt Ol";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(23, 90);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(297, 27);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullanıcı Adı";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(23, 117);
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
            // labelConfirmPassword
            // 
            labelConfirmPassword.Font = new Font("Segoe UI", 10F);
            labelConfirmPassword.Location = new Point(23, 230);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(297, 27);
            labelConfirmPassword.TabIndex = 5;
            labelConfirmPassword.Text = "Şifre (Tekrar)";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10F);
            textBoxConfirmPassword.Location = new Point(23, 257);
            textBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(297, 30);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.Font = new Font("Segoe UI", 10F);
            checkBoxIsAdmin.Location = new Point(23, 300);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(297, 30);
            checkBoxIsAdmin.TabIndex = 7;
            checkBoxIsAdmin.Text = "Admin Kayıt";
            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(23, 340);
            labelError.Name = "labelError";
            labelError.Size = new Size(297, 45);
            labelError.TabIndex = 8;
            labelError.Text = "Hata mesajı buraya gelecek.";
            labelError.Visible = false;
            // 
            // ButtonRegister
            // 
            ButtonRegister.BackColor = Color.SeaGreen;
            ButtonRegister.FlatStyle = FlatStyle.Flat;
            ButtonRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonRegister.ForeColor = Color.White;
            ButtonRegister.Location = new Point(23, 390);
            ButtonRegister.Margin = new Padding(3, 4, 3, 4);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(297, 47);
            ButtonRegister.TabIndex = 9;
            ButtonRegister.Text = "Kayıt Ol";
            ButtonRegister.UseVisualStyleBackColor = false;
            ButtonRegister.Click += ButtonRegister_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.IndianRed;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Location = new Point(23, 445);
            ButtonBack.Margin = new Padding(3, 4, 3, 4);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(297, 40);
            ButtonBack.TabIndex = 10;
            ButtonBack.Text = "Geri Dön";
            ButtonBack.UseVisualStyleBackColor = false;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // KayitForm
            // 
            AcceptButton = ButtonRegister;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(914, 600);
            Controls.Add(panelRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "KayitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }
    }
}
