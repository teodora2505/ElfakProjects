namespace eDnevnik
{
    partial class FormaOdeljenjeRaspored
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxOdeljenje = new System.Windows.Forms.ComboBox();
            this.txtImePrezimeAdministratora = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxOdeljenje
            // 
            this.cbxOdeljenje.FormattingEnabled = true;
            this.cbxOdeljenje.Location = new System.Drawing.Point(142, 100);
            this.cbxOdeljenje.Name = "cbxOdeljenje";
            this.cbxOdeljenje.Size = new System.Drawing.Size(96, 24);
            this.cbxOdeljenje.TabIndex = 7;
            // 
            // txtImePrezimeAdministratora
            // 
            this.txtImePrezimeAdministratora.AutoSize = true;
            this.txtImePrezimeAdministratora.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeAdministratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeAdministratora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtImePrezimeAdministratora.Location = new System.Drawing.Point(69, 36);
            this.txtImePrezimeAdministratora.Name = "txtImePrezimeAdministratora";
            this.txtImePrezimeAdministratora.Size = new System.Drawing.Size(238, 29);
            this.txtImePrezimeAdministratora.TabIndex = 6;
            this.txtImePrezimeAdministratora.Text = "Izaberite odeljenje:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrikazi.Location = new System.Drawing.Point(86, 175);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(194, 74);
            this.btnPrikazi.TabIndex = 33;
            this.btnPrikazi.Text = "Prikazi raspored časova";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // FormaOdeljenjeRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cbxOdeljenje);
            this.Controls.Add(this.txtImePrezimeAdministratora);
            this.Name = "FormaOdeljenjeRaspored";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaOdeljenjeRaspored_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOdeljenje;
        private System.Windows.Forms.Label txtImePrezimeAdministratora;
        private System.Windows.Forms.Button btnPrikazi;
    }
}