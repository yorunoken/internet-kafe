using System.Drawing;
using System.Windows.Forms;

namespace Internet_Kafe_Proje.Forms
{
    partial class MarketForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelWelcome;
        private Label labelBalance;
        private FlowLayoutPanel panelItems;
        private Button MoneyBuyButton;
        private Button ButtonBack;

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
            labelWelcome = new Label();
            labelBalance = new Label();
            panelItems = new FlowLayoutPanel();
            MoneyBuyButton = new Button();
            ButtonBack = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelWelcome.Location = new Point(110, 20);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(400, 35);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Hoşgeldin, kullanıcı";
            // 
            // labelBalance
            // 
            labelBalance.Font = new Font("Segoe UI", 13F);
            labelBalance.Location = new Point(110, 60);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(300, 30);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Bakiyen: 0₺";
            // 
            // panelItems
            // 
            panelItems.AutoScroll = true;
            panelItems.BackColor = Color.WhiteSmoke;
            panelItems.Location = new Point(30, 110);
            panelItems.Name = "panelItems";
            panelItems.Padding = new Padding(10);
            panelItems.Size = new Size(740, 300);
            panelItems.TabIndex = 2;
            // 
            // MoneyBuyButton
            // 
            MoneyBuyButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            MoneyBuyButton.Location = new Point(650, 20);
            MoneyBuyButton.Name = "MoneyBuyButton";
            MoneyBuyButton.Size = new Size(120, 35);
            MoneyBuyButton.TabIndex = 3;
            MoneyBuyButton.Text = "Para Satın Al";
            MoneyBuyButton.UseVisualStyleBackColor = true;
            MoneyBuyButton.Click += MoneyBuyButton_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.BackColor = Color.IndianRed;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Location = new Point(10, 10);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(80, 28);
            ButtonBack.TabIndex = 4;
            ButtonBack.Text = "Geri Çık";
            ButtonBack.UseVisualStyleBackColor = false;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // MarketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonBack);
            Controls.Add(MoneyBuyButton);
            Controls.Add(labelWelcome);
            Controls.Add(labelBalance);
            Controls.Add(panelItems);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MarketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market";
            ResumeLayout(false);
        }
    }
}
