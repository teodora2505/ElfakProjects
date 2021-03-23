namespace eDnevnik
{
    partial class FormaBrojeviTelefona
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
            this.txtImePrezimeAdministratora = new System.Windows.Forms.Label();
            this.txtKorisnikId = new System.Windows.Forms.TextBox();
            this.datagridTelefon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDodajKorisnikId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.txtDodajTel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIzmenii = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzmeniKontakt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTelefon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImePrezimeAdministratora
            // 
            this.txtImePrezimeAdministratora.AutoSize = true;
            this.txtImePrezimeAdministratora.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeAdministratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeAdministratora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtImePrezimeAdministratora.Location = new System.Drawing.Point(48, 59);
            this.txtImePrezimeAdministratora.Name = "txtImePrezimeAdministratora";
            this.txtImePrezimeAdministratora.Size = new System.Drawing.Size(181, 20);
            this.txtImePrezimeAdministratora.TabIndex = 5;
            this.txtImePrezimeAdministratora.Text = "Unesite id korisnika:";
            // 
            // txtKorisnikId
            // 
            this.txtKorisnikId.Location = new System.Drawing.Point(93, 104);
            this.txtKorisnikId.Name = "txtKorisnikId";
            this.txtKorisnikId.Size = new System.Drawing.Size(100, 22);
            this.txtKorisnikId.TabIndex = 6;
            // 
            // datagridTelefon
            // 
            this.datagridTelefon.BackgroundColor = System.Drawing.Color.White;
            this.datagridTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTelefon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridTelefon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTelefon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.datagridTelefon.EnableHeadersVisualStyles = false;
            this.datagridTelefon.GridColor = System.Drawing.Color.MediumBlue;
            this.datagridTelefon.Location = new System.Drawing.Point(326, 30);
            this.datagridTelefon.Name = "datagridTelefon";
            this.datagridTelefon.ReadOnly = true;
            this.datagridTelefon.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.datagridTelefon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridTelefon.RowTemplate.Height = 24;
            this.datagridTelefon.Size = new System.Drawing.Size(431, 211);
            this.datagridTelefon.TabIndex = 42;
            this.datagridTelefon.Visible = false;
            this.datagridTelefon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTelefon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID kontakta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Broj telefona";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrikazi.Location = new System.Drawing.Point(66, 156);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(163, 59);
            this.btnPrikazi.TabIndex = 43;
            this.btnPrikazi.Text = "Prikaži kontakt telefon";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDodajTel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDodajKorisnikId);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(52, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 287);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog kontakta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(59, 234);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(163, 29);
            this.btnDodaj.TabIndex = 32;
            this.btnDodaj.Text = "Dodaj kontakt";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id korisnika:";
            // 
            // txtDodajKorisnikId
            // 
            this.txtDodajKorisnikId.Location = new System.Drawing.Point(96, 78);
            this.txtDodajKorisnikId.Name = "txtDodajKorisnikId";
            this.txtDodajKorisnikId.Size = new System.Drawing.Size(100, 22);
            this.txtDodajKorisnikId.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(100, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Broj telefona:";
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUkloni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUkloni.Location = new System.Drawing.Point(389, 274);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(183, 77);
            this.buttonUkloni.TabIndex = 45;
            this.buttonUkloni.Text = "Ukloni selektovani kontakt";
            this.buttonUkloni.UseVisualStyleBackColor = false;
            this.buttonUkloni.Click += new System.EventHandler(this.buttonUkloni_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonIzmeni.Location = new System.Drawing.Point(599, 274);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(178, 77);
            this.buttonIzmeni.TabIndex = 46;
            this.buttonIzmeni.Text = "Izmeni selektovani kontakt";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // txtDodajTel
            // 
            this.txtDodajTel.Location = new System.Drawing.Point(81, 162);
            this.txtDodajTel.Name = "txtDodajTel";
            this.txtDodajTel.Size = new System.Drawing.Size(141, 22);
            this.txtDodajTel.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIzmenii);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnIzmeniKontakt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(440, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 193);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izmeni kontakt";
            this.groupBox2.Visible = false;
            // 
            // txtIzmenii
            // 
            this.txtIzmenii.Location = new System.Drawing.Point(79, 86);
            this.txtIzmenii.Name = "txtIzmenii";
            this.txtIzmenii.Size = new System.Drawing.Size(135, 22);
            this.txtIzmenii.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(93, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Broj telefona:";
            // 
            // btnIzmeniKontakt
            // 
            this.btnIzmeniKontakt.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKontakt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeniKontakt.Location = new System.Drawing.Point(64, 140);
            this.btnIzmeniKontakt.Name = "btnIzmeniKontakt";
            this.btnIzmeniKontakt.Size = new System.Drawing.Size(163, 29);
            this.btnIzmeniKontakt.TabIndex = 32;
            this.btnIzmeniKontakt.Text = "Izmeni kontakt";
            this.btnIzmeniKontakt.UseVisualStyleBackColor = false;
            this.btnIzmeniKontakt.Click += new System.EventHandler(this.btnIzmeniKontakt_Click);
            // 
            // FormaBrojeviTelefona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonUkloni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.datagridTelefon);
            this.Controls.Add(this.txtKorisnikId);
            this.Controls.Add(this.txtImePrezimeAdministratora);
            this.Name = "FormaBrojeviTelefona";
            this.Text = "e-Dnevnik";
            ((System.ComponentModel.ISupportInitialize)(this.datagridTelefon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtImePrezimeAdministratora;
        private System.Windows.Forms.TextBox txtKorisnikId;
        private System.Windows.Forms.DataGridView datagridTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDodajKorisnikId;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.TextBox txtDodajTel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIzmenii;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzmeniKontakt;
    }
}