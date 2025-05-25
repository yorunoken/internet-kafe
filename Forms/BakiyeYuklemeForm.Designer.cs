namespace Internet_Kafe_Proje.Forms
{
    partial class BakiyeYuklemeForm
    {
        private System.ComponentModel.IContainer components = null;

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
            panel1 = new Panel();
            ButtonBuy200 = new Button();
            ButtonBuy150 = new Button();
            ButtonBuy100 = new Button();
            ButtonBuy50 = new Button();
            label1 = new Label();
            ButtonBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ButtonBuy200);
            panel1.Controls.Add(ButtonBuy150);
            panel1.Controls.Add(ButtonBuy100);
            panel1.Controls.Add(ButtonBuy50);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(140, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 370);
            panel1.TabIndex = 0;
            // 
            // ButtonBuy200
            // 
            ButtonBuy200.Font = new Font("Segoe UI", 15.75F);
            ButtonBuy200.Location = new Point(388, 289);
            ButtonBuy200.Name = "ButtonBuy200";
            ButtonBuy200.Size = new Size(97, 43);
            ButtonBuy200.TabIndex = 4;
            ButtonBuy200.Text = "200₺";
            ButtonBuy200.UseVisualStyleBackColor = true;
            ButtonBuy200.Click += ButtonBuy200_Click;
            // 
            // ButtonBuy150
            // 
            ButtonBuy150.Font = new Font("Segoe UI", 15.75F);
            ButtonBuy150.Location = new Point(274, 289);
            ButtonBuy150.Name = "ButtonBuy150";
            ButtonBuy150.Size = new Size(97, 43);
            ButtonBuy150.TabIndex = 3;
            ButtonBuy150.Text = "150₺";
            ButtonBuy150.UseVisualStyleBackColor = true;
            ButtonBuy150.Click += ButtonBuy150_Click;
            // 
            // ButtonBuy100
            // 
            ButtonBuy100.Font = new Font("Segoe UI", 15.75F);
            ButtonBuy100.Location = new Point(168, 289);
            ButtonBuy100.Name = "ButtonBuy100";
            ButtonBuy100.Size = new Size(88, 43);
            ButtonBuy100.TabIndex = 2;
            ButtonBuy100.Text = "100₺";
            ButtonBuy100.UseVisualStyleBackColor = true;
            ButtonBuy100.Click += ButtonBuy100_Click;
            // 
            // ButtonBuy50
            // 
            ButtonBuy50.AutoSize = true;
            ButtonBuy50.Font = new Font("Segoe UI", 15.75F);
            ButtonBuy50.Location = new Point(59, 289);
            ButtonBuy50.Name = "ButtonBuy50";
            ButtonBuy50.Size = new Size(89, 43);
            ButtonBuy50.TabIndex = 1;
            ButtonBuy50.Text = "50₺";
            ButtonBuy50.UseVisualStyleBackColor = true;
            ButtonBuy50.Click += ButtonBuy50_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(346, 65);
            label1.TabIndex = 0;
            label1.Text = "Güncel Bakiye";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.IndianRed;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Location = new Point(10, 10);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(90, 30);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Geri Çık";
            ButtonBack.UseVisualStyleBackColor = false;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // BakiyeYuklemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BakiyeYuklemeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bakiye Yükleme";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Button ButtonBuy200;
        private Button ButtonBuy150;
        private Button ButtonBuy100;
        private Button ButtonBuy50;
        private Button ButtonBack;
    }
}
