namespace eDnevnik
{
    partial class FormaNastaviKao
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbNastavnik = new System.Windows.Forms.RadioButton();
            this.rdbRazredni = new System.Windows.Forms.RadioButton();
            this.rdbRoditelj = new System.Windows.Forms.RadioButton();
            this.rdbAdministrator = new System.Windows.Forms.RadioButton();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbNastavnik
            // 
            this.rdbNastavnik.AutoSize = true;
            this.rdbNastavnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNastavnik.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbNastavnik.Location = new System.Drawing.Point(67, 55);
            this.rdbNastavnik.Name = "rdbNastavnik";
            this.rdbNastavnik.Size = new System.Drawing.Size(100, 21);
            this.rdbNastavnik.TabIndex = 0;
            this.rdbNastavnik.TabStop = true;
            this.rdbNastavnik.Text = "Nastavnik";
            this.rdbNastavnik.UseVisualStyleBackColor = true;
            // 
            // rdbRazredni
            // 
            this.rdbRazredni.AutoSize = true;
            this.rdbRazredni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRazredni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbRazredni.Location = new System.Drawing.Point(67, 100);
            this.rdbRazredni.Name = "rdbRazredni";
            this.rdbRazredni.Size = new System.Drawing.Size(166, 21);
            this.rdbRazredni.TabIndex = 1;
            this.rdbRazredni.TabStop = true;
            this.rdbRazredni.Text = "Razredni starešina";
            this.rdbRazredni.UseVisualStyleBackColor = true;
            // 
            // rdbRoditelj
            // 
            this.rdbRoditelj.AutoSize = true;
            this.rdbRoditelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRoditelj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbRoditelj.Location = new System.Drawing.Point(67, 142);
            this.rdbRoditelj.Name = "rdbRoditelj";
            this.rdbRoditelj.Size = new System.Drawing.Size(84, 21);
            this.rdbRoditelj.TabIndex = 2;
            this.rdbRoditelj.TabStop = true;
            this.rdbRoditelj.Text = "Roditelj";
            this.rdbRoditelj.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrator
            // 
            this.rdbAdministrator.AutoSize = true;
            this.rdbAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdministrator.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbAdministrator.Location = new System.Drawing.Point(67, 187);
            this.rdbAdministrator.Name = "rdbAdministrator";
            this.rdbAdministrator.Size = new System.Drawing.Size(125, 21);
            this.rdbAdministrator.TabIndex = 3;
            this.rdbAdministrator.TabStop = true;
            this.rdbAdministrator.Text = "Administrator";
            this.rdbAdministrator.UseVisualStyleBackColor = true;
            // 
            // btnNastavi
            // 
            this.btnNastavi.BackColor = System.Drawing.Color.LightCyan;
            this.btnNastavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNastavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNastavi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNastavi.Location = new System.Drawing.Point(50, 239);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(161, 41);
            this.btnNastavi.TabIndex = 6;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = false;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.LightCyan;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNazad.Location = new System.Drawing.Point(3, 2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(85, 33);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAdministrator);
            this.groupBox1.Controls.Add(this.btnNastavi);
            this.groupBox1.Controls.Add(this.rdbRoditelj);
            this.groupBox1.Controls.Add(this.rdbRazredni);
            this.groupBox1.Controls.Add(this.rdbNastavnik);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(44, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 296);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nastavi dalje kao:";
            // 
            // FormaNastaviKao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 365);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormaNastaviKao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaNastaviKao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbAdministrator;
        private System.Windows.Forms.RadioButton rdbRoditelj;
        private System.Windows.Forms.RadioButton rdbRazredni;
        private System.Windows.Forms.RadioButton rdbNastavnik;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}