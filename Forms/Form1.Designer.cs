using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(30, 30, 30);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 0;

            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            this.richTextBox1.ForeColor = Color.White;
            this.richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextBox1.Text = "OYUN SEÇİMİ";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Location = new Point(200, 30);
            this.richTextBox1.Size = new Size(800, 120);
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


            // 
            // button1 - League of Legends
            // 
            SetupGameButton(this.button1, "League of Legends", 200, 200);
            this.button1.Click += new EventHandler(this.button1_Click);

            // 
            // button2 - CS2
            // 
            SetupGameButton(this.button2, "Counter Strike 2", 600, 200);

            // 
            // button5 - Call of Duty
            // 
            SetupGameButton(this.button5, "Call Of Duty", 200, 280);

            // 
            // button4 - FIFA
            // 
            SetupGameButton(this.button4, "FIFA", 600, 280);

            // 
            // button3 - Valorant
            // 
            SetupGameButton(this.button3, "Valorant", 200, 360);

            // 
            // button7 - Fortnite
            // 
            SetupGameButton(this.button7, "Fortnite", 600, 360);

            // 
            // button6 - Help
            // 
            this.button6.Text = "?";
            this.button6.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.button6.ForeColor = Color.White;
            this.button6.BackColor = Color.Transparent;
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Size = new Size(40, 40);
            this.button6.Location = new Point(10, 10);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Oyun Seçimi";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public void SetupGameButton(Button button, string text, int x, int y)
        {
            button.Text = text;
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(45, 45, 48);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(250, 60);
            button.Location = new Point(x, y);
        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

