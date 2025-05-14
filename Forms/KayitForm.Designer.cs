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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button ButtonRegister;

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
            labelError = new Label();
            ButtonRegister = new Button();

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
            panelRegister.Controls.Add(labelError);
            panelRegister.Controls.Add(ButtonRegister);
            panelRegister.Location = new Point(250, 60);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(300, 380);
            panelRegister.TabIndex = 0;

            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateGray;
            labelTitle.Location = new Point(0, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Kayıt Ol";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(20, 75);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(260, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullanıcı Adı";

            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(20, 95);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(260, 25);
            textBoxUsername.TabIndex = 1;

            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(20, 135);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(260, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Şifre";

            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(20, 155);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(260, 25);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;

            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.Font = new Font("Segoe UI", 10F);
            labelConfirmPassword.Location = new Point(20, 195);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(260, 20);
            labelConfirmPassword.TabIndex = 3;
            labelConfirmPassword.Text = "Şifre (Tekrar)";

            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 10F);
            textBoxConfirmPassword.Location = new Point(20, 215);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(260, 25);
            textBoxConfirmPassword.TabIndex = 3;
            textBoxConfirmPassword.UseSystemPasswordChar = true;

            // 
            // labelError
            // 
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(20, 245);
            labelError.Name = "labelError";
            labelError.Size = new Size(260, 20);
            labelError.TabIndex = 4;
            labelError.Text = "Hata mesajı buraya gelecek.";
            labelError.Visible = false;

            // 
            // ButtonRegister
            // 
            ButtonRegister.BackColor = Color.SeaGreen;
            ButtonRegister.FlatStyle = FlatStyle.Flat;
            ButtonRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonRegister.ForeColor = Color.White;
            ButtonRegister.Location = new Point(20, 270);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(260, 35);
            ButtonRegister.TabIndex = 5;
            ButtonRegister.Text = "Kayıt Ol";
            ButtonRegister.UseVisualStyleBackColor = false;
            ButtonRegister.Click += ButtonRegister_Click;

            // 
            // KayitForm
            // 
            AcceptButton = ButtonRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegister);
            MaximizeBox = false;
            Name = "KayitForm";
            Text = "Kayıt";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }
    }
}