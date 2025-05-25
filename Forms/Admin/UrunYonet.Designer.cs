namespace Internet_Kafe_Proje.Forms.Admin
{
    partial class UrunYonet
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;  // Added back button

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewItems = new DataGridView();
            textBoxItemName = new TextBox();
            textBoxPrice = new TextBox();
            labelProductName = new Label();
            labelPrice = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonRefresh = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.Location = new Point(30, 30);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(460, 370);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.SelectionChanged += SelectedDataGrid;
            // 
            // textBoxItemName
            // 
            textBoxItemName.Font = new Font("Segoe UI", 10F);
            textBoxItemName.Location = new Point(520, 75);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(240, 25);
            textBoxItemName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 10F);
            textBoxPrice.Location = new Point(520, 140);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(240, 25);
            textBoxPrice.TabIndex = 3;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 10F);
            labelProductName.Location = new Point(520, 50);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(67, 19);
            labelProductName.TabIndex = 1;
            labelProductName.Text = "Ürün Adı:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F);
            labelPrice.Location = new Point(520, 115);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 19);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Fiyat:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Teal;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(520, 190);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 40);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += CreateItem;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(650, 190);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(110, 40);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += DeleteItem;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(520, 250);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(240, 40);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += UpdateItem;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Gray;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(520, 310);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(240, 40);
            buttonClear.TabIndex = 8;
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
            buttonRefresh.Location = new Point(30, 410);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(120, 30);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += Refresh_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.DimGray;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(160, 410);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 30);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Geri";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // UrunYonet
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewItems);
            Controls.Add(labelProductName);
            Controls.Add(textBoxItemName);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClear);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UrunYonet";
            Text = "Ürünleri Yönet";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
