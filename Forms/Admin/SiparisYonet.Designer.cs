namespace Internet_Kafe_Proje.Forms.Admin
{
    partial class SiparisYonet
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.CheckBox checkBoxDelivered;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelDelivered;
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
            dataGridViewOrders = new DataGridView();
            textBoxUserId = new TextBox();
            textBoxItemId = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxTotalPrice = new TextBox();
            checkBoxDelivered = new CheckBox();
            labelUserId = new Label();
            labelItemId = new Label();
            labelQuantity = new Label();
            labelTotalPrice = new Label();
            labelDelivered = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.Location = new Point(35, 35);
            dataGridViewOrders.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(537, 427);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.SelectionChanged += SelectedDataGrid;
            // 
            // textBoxUserId
            // 
            textBoxUserId.Font = new Font("Segoe UI", 10F);
            textBoxUserId.Location = new Point(607, 58);
            textBoxUserId.Margin = new Padding(4, 3, 4, 3);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(279, 25);
            textBoxUserId.TabIndex = 1;
            // 
            // textBoxItemId
            // 
            textBoxItemId.Font = new Font("Segoe UI", 10F);
            textBoxItemId.Location = new Point(607, 127);
            textBoxItemId.Margin = new Padding(4, 3, 4, 3);
            textBoxItemId.Name = "textBoxItemId";
            textBoxItemId.Size = new Size(279, 25);
            textBoxItemId.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Segoe UI", 10F);
            textBoxQuantity.Location = new Point(607, 196);
            textBoxQuantity.Margin = new Padding(4, 3, 4, 3);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(279, 25);
            textBoxQuantity.TabIndex = 3;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Font = new Font("Segoe UI", 10F);
            textBoxTotalPrice.Location = new Point(607, 265);
            textBoxTotalPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(279, 25);
            textBoxTotalPrice.TabIndex = 4;
            // 
            // checkBoxDelivered
            // 
            checkBoxDelivered.Location = new Point(700, 314);
            checkBoxDelivered.Margin = new Padding(4, 3, 4, 3);
            checkBoxDelivered.Name = "checkBoxDelivered";
            checkBoxDelivered.Size = new Size(23, 23);
            checkBoxDelivered.TabIndex = 10;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Segoe UI", 10F);
            labelUserId.Location = new Point(607, 35);
            labelUserId.Margin = new Padding(4, 0, 4, 0);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(77, 19);
            labelUserId.TabIndex = 5;
            labelUserId.Text = "Kullanıcı Id:";
            // 
            // labelItemId
            // 
            labelItemId.AutoSize = true;
            labelItemId.Font = new Font("Segoe UI", 10F);
            labelItemId.Location = new Point(607, 104);
            labelItemId.Margin = new Padding(4, 0, 4, 0);
            labelItemId.Name = "labelItemId";
            labelItemId.Size = new Size(59, 19);
            labelItemId.TabIndex = 6;
            labelItemId.Text = "Ürün Id:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 10F);
            labelQuantity.Location = new Point(607, 173);
            labelQuantity.Margin = new Padding(4, 0, 4, 0);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(41, 19);
            labelQuantity.TabIndex = 7;
            labelQuantity.Text = "Adet:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 10F);
            labelTotalPrice.Location = new Point(607, 242);
            labelTotalPrice.Margin = new Padding(4, 0, 4, 0);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(89, 19);
            labelTotalPrice.TabIndex = 8;
            labelTotalPrice.Text = "Toplam Fiyat:";
            // 
            // labelDelivered
            // 
            labelDelivered.AutoSize = true;
            labelDelivered.Font = new Font("Segoe UI", 10F);
            labelDelivered.Location = new Point(607, 312);
            labelDelivered.Margin = new Padding(4, 0, 4, 0);
            labelDelivered.Name = "labelDelivered";
            labelDelivered.Size = new Size(85, 19);
            labelDelivered.TabIndex = 9;
            labelDelivered.Text = "Teslim Edildi:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(758, 358);
            buttonDelete.Margin = new Padding(4, 3, 4, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 46);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += DeleteOrder;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(607, 358);
            buttonUpdate.Margin = new Padding(4, 3, 4, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(128, 46);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += UpdateOrder;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Gray;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(607, 427);
            buttonClear.Margin = new Padding(4, 3, 4, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(280, 46);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Temizle";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ClearFields;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.DarkOliveGreen;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(35, 473);
            buttonRefresh.Margin = new Padding(4, 3, 4, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 35);
            buttonRefresh.TabIndex = 12;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += Refresh_Click;
            // 
            // SiparisYonet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(933, 519);
            Controls.Add(dataGridViewOrders);
            Controls.Add(labelUserId);
            Controls.Add(textBoxUserId);
            Controls.Add(labelItemId);
            Controls.Add(textBoxItemId);
            Controls.Add(labelQuantity);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelTotalPrice);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(labelDelivered);
            Controls.Add(checkBoxDelivered);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClear);
            Controls.Add(buttonRefresh);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SiparisYonet";
            //StartPosition = FormStartPosition.CenterScreen;
            Text = "Siparişleri Yönet";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
