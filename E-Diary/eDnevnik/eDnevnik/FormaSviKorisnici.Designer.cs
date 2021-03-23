namespace eDnevnik
{
    partial class FormaSviKorisnici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridKorisnici = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.buttonIzmeniKorisnika = new System.Windows.Forms.Button();
            this.buttonUkloniKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKorisnici
            // 
            this.dataGridKorisnici.BackgroundColor = System.Drawing.Color.White;
            this.dataGridKorisnici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column10,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridKorisnici.EnableHeadersVisualStyles = false;
            this.dataGridKorisnici.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridKorisnici.Location = new System.Drawing.Point(24, 33);
            this.dataGridKorisnici.Name = "dataGridKorisnici";
            this.dataGridKorisnici.ReadOnly = true;
            this.dataGridKorisnici.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridKorisnici.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridKorisnici.RowTemplate.Height = 24;
            this.dataGridKorisnici.Size = new System.Drawing.Size(1078, 361);
            this.dataGridKorisnici.TabIndex = 31;
            this.dataGridKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKorisnici_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Korisnika";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ime";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prezime";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "JMBG";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Datum rodjenja";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pol";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Admin";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ucenik";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nastavnik";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Roditelj";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(123, 432);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(175, 55);
            this.btnDodajKorisnika.TabIndex = 33;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // buttonIzmeniKorisnika
            // 
            this.buttonIzmeniKorisnika.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonIzmeniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeniKorisnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonIzmeniKorisnika.Location = new System.Drawing.Point(449, 432);
            this.buttonIzmeniKorisnika.Name = "buttonIzmeniKorisnika";
            this.buttonIzmeniKorisnika.Size = new System.Drawing.Size(175, 55);
            this.buttonIzmeniKorisnika.TabIndex = 34;
            this.buttonIzmeniKorisnika.Text = "Izmeni korisnika";
            this.buttonIzmeniKorisnika.UseVisualStyleBackColor = false;
            this.buttonIzmeniKorisnika.Click += new System.EventHandler(this.buttonIzmeniKorisnika_Click);
            // 
            // buttonUkloniKorisnika
            // 
            this.buttonUkloniKorisnika.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUkloniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUkloniKorisnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUkloniKorisnika.Location = new System.Drawing.Point(800, 432);
            this.buttonUkloniKorisnika.Name = "buttonUkloniKorisnika";
            this.buttonUkloniKorisnika.Size = new System.Drawing.Size(175, 55);
            this.buttonUkloniKorisnika.TabIndex = 35;
            this.buttonUkloniKorisnika.Text = "Ukloni korisnika";
            this.buttonUkloniKorisnika.UseVisualStyleBackColor = false;
            this.buttonUkloniKorisnika.Click += new System.EventHandler(this.buttonUkloniKorisnika_Click);
            // 
            // FormaSviKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 534);
            this.Controls.Add(this.buttonUkloniKorisnika);
            this.Controls.Add(this.buttonIzmeniKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.dataGridKorisnici);
            this.Name = "FormaSviKorisnici";
            this.Text = "FormaSviKorisnici";
            this.Load += new System.EventHandler(this.FormaSviKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKorisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button buttonIzmeniKorisnika;
        private System.Windows.Forms.Button buttonUkloniKorisnika;
    }
}