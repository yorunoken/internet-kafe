namespace Internet_Kafe_Proje.Forms.Admin
{
    partial class KullaniciYonet
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxBalance = new TextBox();
            checkBoxIsAdmin = new CheckBox();
            labelUsername = new Label();
            labelPassword = new Label();
            labelBalance = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Location = new Point(30, 30);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(460, 370);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += SelectedDataGrid;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(520, 75);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(240, 25);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(520, 140);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(240, 25);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxBalance
            // 
            textBoxBalance.Font = new Font("Segoe UI", 10F);
            textBoxBalance.Location = new Point(520, 240);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(240, 25);
            textBoxBalance.TabIndex = 12;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Font = new Font("Segoe UI", 10F);
            checkBoxIsAdmin.Location = new Point(520, 180);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(100, 23);
            checkBoxIsAdmin.TabIndex = 5;
            checkBoxIsAdmin.Text = "Yönetici mi?";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(520, 50);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 19);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullanıcı Adı:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(520, 115);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(38, 19);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Şifre:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 10F);
            labelBalance.Location = new Point(520, 215);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(51, 19);
            labelBalance.TabIndex = 11;
            labelBalance.Text = "Bakiye:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(520, 280);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 40);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += CreateUser;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(650, 280);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 40);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += DeleteUser;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(520, 340);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(240, 40);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += UpdateUser;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Gray;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(520, 400);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(240, 40);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Temizle";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ClearSelection;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.DarkOliveGreen;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(30, 410);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(120, 30);
            buttonRefresh.TabIndex = 10;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += Refresh_Click;
            // 
            // KullaniciYonet
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUsers);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelBalance);
            Controls.Add(textBoxBalance);
            Controls.Add(checkBoxIsAdmin);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClear);
            Controls.Add(buttonRefresh);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KullaniciYonet";
            //StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcıları Yönet";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
