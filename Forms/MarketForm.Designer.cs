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
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelWelcome.Location = new Point(20, 20);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(300, 30);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Hoşgeldin, kullanıcı";
            // 
            // labelBalance
            // 
            labelBalance.Font = new Font("Segoe UI", 12F);
            labelBalance.Location = new Point(20, 60);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(300, 25);
            labelBalance.TabIndex = 1;
            labelBalance.Text = "Bakiyen: 0₺";
            // 
            // panelItems
            // 
            panelItems.AutoScroll = true;
            panelItems.Location = new Point(20, 100);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(740, 300);
            panelItems.TabIndex = 2;
            // 
            // MoneyBuyButton
            // 
            MoneyBuyButton.Location = new Point(662, 12);
            MoneyBuyButton.Name = "MoneyBuyButton";
            MoneyBuyButton.Size = new Size(98, 23);
            MoneyBuyButton.TabIndex = 3;
            MoneyBuyButton.Text = "Para Satın Al";
            MoneyBuyButton.UseVisualStyleBackColor = true;
            MoneyBuyButton.Click += MoneyBuyButton_Click;
            // 
            // MarketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MoneyBuyButton);
            Controls.Add(labelWelcome);
            Controls.Add(labelBalance);
            Controls.Add(panelItems);
            Name = "MarketForm";
            Text = "Market";
            ResumeLayout(false);
        }
        private Button MoneyBuyButton;
    }
}
