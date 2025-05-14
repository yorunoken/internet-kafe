namespace Internet_Kafe_Proje.Forms
{
    partial class OyunSecimForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Button btnCS2;
        private System.Windows.Forms.Button btnCOD;
        private System.Windows.Forms.Button btnFIFA;
        private System.Windows.Forms.Button btnValorant;
        private System.Windows.Forms.Button btnFortnite;
        private System.Windows.Forms.Label lblTitle;

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
            this.btnLeague = new System.Windows.Forms.Button();
            this.btnCS2 = new System.Windows.Forms.Button();
            this.btnCOD = new System.Windows.Forms.Button();
            this.btnFIFA = new System.Windows.Forms.Button();
            this.btnValorant = new System.Windows.Forms.Button();
            this.btnFortnite = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 40);
            this.lblTitle.Text = "Oyun Seçiniz";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Shared button styles
            System.Drawing.Font buttonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color buttonBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            System.Drawing.Color buttonForeColor = System.Drawing.Color.White;

            // 
            // btnLeague
            // 
            this.btnLeague.Font = buttonFont;
            this.btnLeague.BackColor = buttonBackColor;
            this.btnLeague.ForeColor = buttonForeColor;
            this.btnLeague.Location = new System.Drawing.Point(30, 70);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(180, 50);
            this.btnLeague.TabIndex = 0;
            this.btnLeague.Text = "League of Legends";
            this.btnLeague.UseVisualStyleBackColor = false;

            // 
            // btnCS2
            // 
            this.btnCS2.Font = buttonFont;
            this.btnCS2.BackColor = buttonBackColor;
            this.btnCS2.ForeColor = buttonForeColor;
            this.btnCS2.Location = new System.Drawing.Point(230, 70);
            this.btnCS2.Name = "btnCS2";
            this.btnCS2.Size = new System.Drawing.Size(180, 50);
            this.btnCS2.TabIndex = 1;
            this.btnCS2.Text = "CS2";
            this.btnCS2.UseVisualStyleBackColor = false;

            // 
            // btnCOD
            // 
            this.btnCOD.Font = buttonFont;
            this.btnCOD.BackColor = buttonBackColor;
            this.btnCOD.ForeColor = buttonForeColor;
            this.btnCOD.Location = new System.Drawing.Point(430, 70);
            this.btnCOD.Name = "btnCOD";
            this.btnCOD.Size = new System.Drawing.Size(180, 50);
            this.btnCOD.TabIndex = 2;
            this.btnCOD.Text = "Call of Duty";
            this.btnCOD.UseVisualStyleBackColor = false;

            // 
            // btnFIFA
            // 
            this.btnFIFA.Font = buttonFont;
            this.btnFIFA.BackColor = buttonBackColor;
            this.btnFIFA.ForeColor = buttonForeColor;
            this.btnFIFA.Location = new System.Drawing.Point(30, 140);
            this.btnFIFA.Name = "btnFIFA";
            this.btnFIFA.Size = new System.Drawing.Size(180, 50);
            this.btnFIFA.TabIndex = 3;
            this.btnFIFA.Text = "FIFA";
            this.btnFIFA.UseVisualStyleBackColor = false;

            // 
            // btnValorant
            // 
            this.btnValorant.Font = buttonFont;
            this.btnValorant.BackColor = buttonBackColor;
            this.btnValorant.ForeColor = buttonForeColor;
            this.btnValorant.Location = new System.Drawing.Point(230, 140);
            this.btnValorant.Name = "btnValorant";
            this.btnValorant.Size = new System.Drawing.Size(180, 50);
            this.btnValorant.TabIndex = 4;
            this.btnValorant.Text = "Valorant";
            this.btnValorant.UseVisualStyleBackColor = false;

            // 
            // btnFortnite
            // 
            this.btnFortnite.Font = buttonFont;
            this.btnFortnite.BackColor = buttonBackColor;
            this.btnFortnite.ForeColor = buttonForeColor;
            this.btnFortnite.Location = new System.Drawing.Point(430, 140);
            this.btnFortnite.Name = "btnFortnite";
            this.btnFortnite.Size = new System.Drawing.Size(180, 50);
            this.btnFortnite.TabIndex = 5;
            this.btnFortnite.Text = "Fortnite";
            this.btnFortnite.UseVisualStyleBackColor = false;

            // 
            // GameSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(640, 220);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnFortnite);
            this.Controls.Add(this.btnValorant);
            this.Controls.Add(this.btnFIFA);
            this.Controls.Add(this.btnCOD);
            this.Controls.Add(this.btnCS2);
            this.Controls.Add(this.btnLeague);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Seçimi";
            this.ResumeLayout(false);
        }
    }
}
