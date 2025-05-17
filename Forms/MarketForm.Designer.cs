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
            this.labelWelcome = new Label();
            this.labelBalance = new Label();
            this.panelItems = new FlowLayoutPanel();

            this.SuspendLayout();

            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelWelcome.Location = new Point(20, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new Size(300, 30);
            this.labelWelcome.Text = "Hoşgeldin, kullanıcı";

            // 
            // labelBalance
            // 
            this.labelBalance.Font = new Font("Segoe UI", 12F);
            this.labelBalance.Location = new Point(20, 60);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new Size(300, 25);
            this.labelBalance.Text = "Bakiyen: 0₺";

            // 
            // panelItems
            // 
            this.panelItems.Location = new Point(20, 100);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new Size(740, 300);
            this.panelItems.AutoScroll = true;
            this.panelItems.WrapContents = true;
            this.panelItems.FlowDirection = FlowDirection.LeftToRight;

            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.panelItems);
            this.Name = "MarketForm";
            this.Text = "Market";
            this.ResumeLayout(false);
        }
    }
}
