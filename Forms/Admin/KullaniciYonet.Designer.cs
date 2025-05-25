namespace Internet_Kafe_Proje.Forms.Admin
{
    partial class KullaniciYonet
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRefresh;

        private System.Windows.Forms.Label labelExtraTime;
        private System.Windows.Forms.TextBox textBoxExtraTime;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            checkBoxIsAdmin = new CheckBox();
            labelBalance = new Label();
            textBoxBalance = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonRefresh = new Button();
            labelExtraTime = new Label();
            textBoxExtraTime = new TextBox();
            buttonAddTime = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Location = new Point(20, 20);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(460, 390);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += SelectedDataGrid;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(510, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 19);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Kullanıcı Adı:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(510, 45);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 25);
            textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(510, 85);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(38, 19);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Şifre:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(510, 110);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 25);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Font = new Font("Segoe UI", 10F);
            checkBoxIsAdmin.Location = new Point(510, 150);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(100, 23);
            checkBoxIsAdmin.TabIndex = 5;
            checkBoxIsAdmin.Text = "Yönetici mi?";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 10F);
            labelBalance.Location = new Point(510, 190);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(51, 19);
            labelBalance.TabIndex = 6;
            labelBalance.Text = "Bakiye:";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Font = new Font("Segoe UI", 10F);
            textBoxBalance.Location = new Point(510, 215);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(250, 25);
            textBoxBalance.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(510, 255);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 40);
            buttonAdd.TabIndex = 8;
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
            buttonDelete.Location = new Point(640, 255);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 40);
            buttonDelete.TabIndex = 9;
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
            buttonUpdate.Location = new Point(510, 305);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(250, 40);
            buttonUpdate.TabIndex = 10;
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
            buttonClear.Location = new Point(510, 355);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(250, 40);
            buttonClear.TabIndex = 11;
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
            buttonRefresh.Location = new Point(20, 420);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(120, 30);
            buttonRefresh.TabIndex = 12;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += Refresh_Click;
            // 
            // labelExtraTime
            // 
            labelExtraTime.AutoSize = true;
            labelExtraTime.Font = new Font("Segoe UI", 10F);
            labelExtraTime.Location = new Point(510, 405);
            labelExtraTime.Name = "labelExtraTime";
            labelExtraTime.Size = new Size(107, 19);
            labelExtraTime.TabIndex = 13;
            labelExtraTime.Text = "Ekstra Süre (dk):";
            // 
            // textBoxExtraTime
            // 
            textBoxExtraTime.Font = new Font("Segoe UI", 10F);
            textBoxExtraTime.Location = new Point(510, 430);
            textBoxExtraTime.Name = "textBoxExtraTime";
            textBoxExtraTime.Size = new Size(120, 25);
            textBoxExtraTime.TabIndex = 14;
            // 
            // buttonAddTime
            // 
            buttonAddTime.BackColor = Color.MediumPurple;
            buttonAddTime.FlatStyle = FlatStyle.Flat;
            buttonAddTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAddTime.ForeColor = Color.White;
            buttonAddTime.Location = new Point(640, 425);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new Size(120, 35);
            buttonAddTime.TabIndex = 15;
            buttonAddTime.Text = "Süre Ekle";
            buttonAddTime.UseVisualStyleBackColor = false;
            buttonAddTime.Click += ButtonAddTime_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightSlateGray;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(146, 420);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 30);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "Geri";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // KullaniciYonet
            // 
            ClientSize = new Size(800, 468);
            Controls.Add(dataGridViewUsers);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(checkBoxIsAdmin);
            Controls.Add(labelBalance);
            Controls.Add(textBoxBalance);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClear);
            Controls.Add(buttonRefresh);
            Controls.Add(labelExtraTime);
            Controls.Add(textBoxExtraTime);
            Controls.Add(buttonAddTime);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KullaniciYonet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcıları Yönet";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
