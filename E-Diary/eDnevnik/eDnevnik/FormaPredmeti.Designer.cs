namespace eDnevnik
{
    partial class FormaPredmeti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPredmeti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.btnUkloniPredmet = new System.Windows.Forms.Button();
            this.btnIzmeniPredmet = new System.Windows.Forms.Button();
            this.btnSpisakPredavaca = new System.Windows.Forms.Button();
            this.groupBoxSpisakPredavaca = new System.Windows.Forms.GroupBox();
            this.dataGridPredavaci = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImePrezimeAdministratora = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxDodajPredavaca = new System.Windows.Forms.ComboBox();
            this.btnDodajPredavaca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUkloniPredavaca = new System.Windows.Forms.ComboBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredmeti)).BeginInit();
            this.groupBoxSpisakPredavaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredavaci)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPredmeti
            // 
            this.dataGridPredmeti.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPredmeti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPredmeti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridPredmeti.EnableHeadersVisualStyles = false;
            this.dataGridPredmeti.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridPredmeti.Location = new System.Drawing.Point(12, 12);
            this.dataGridPredmeti.Name = "dataGridPredmeti";
            this.dataGridPredmeti.ReadOnly = true;
            this.dataGridPredmeti.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridPredmeti.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridPredmeti.RowTemplate.Height = 24;
            this.dataGridPredmeti.Size = new System.Drawing.Size(1095, 211);
            this.dataGridPredmeti.TabIndex = 32;
            this.dataGridPredmeti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPredmeti_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Predmeta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Opis";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Broj časova";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tip";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Min učenika";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Blok nastava";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Specijalni kabinet";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 170;
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredmet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajPredmet.Location = new System.Drawing.Point(114, 257);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(154, 38);
            this.btnDodajPredmet.TabIndex = 33;
            this.btnDodajPredmet.Text = "Dodaj predmet";
            this.btnDodajPredmet.UseVisualStyleBackColor = false;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // btnUkloniPredmet
            // 
            this.btnUkloniPredmet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniPredmet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniPredmet.Location = new System.Drawing.Point(395, 257);
            this.btnUkloniPredmet.Name = "btnUkloniPredmet";
            this.btnUkloniPredmet.Size = new System.Drawing.Size(154, 38);
            this.btnUkloniPredmet.TabIndex = 34;
            this.btnUkloniPredmet.Text = "Ukloni predmet";
            this.btnUkloniPredmet.UseVisualStyleBackColor = false;
            this.btnUkloniPredmet.Click += new System.EventHandler(this.btnUkloniPredmet_Click);
            // 
            // btnIzmeniPredmet
            // 
            this.btnIzmeniPredmet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPredmet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeniPredmet.Location = new System.Drawing.Point(676, 250);
            this.btnIzmeniPredmet.Name = "btnIzmeniPredmet";
            this.btnIzmeniPredmet.Size = new System.Drawing.Size(154, 38);
            this.btnIzmeniPredmet.TabIndex = 35;
            this.btnIzmeniPredmet.Text = "Izmeni predmet";
            this.btnIzmeniPredmet.UseVisualStyleBackColor = false;
            this.btnIzmeniPredmet.Click += new System.EventHandler(this.btnIzmeniPredmet_Click);
            // 
            // btnSpisakPredavaca
            // 
            this.btnSpisakPredavaca.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSpisakPredavaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpisakPredavaca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSpisakPredavaca.Location = new System.Drawing.Point(953, 250);
            this.btnSpisakPredavaca.Name = "btnSpisakPredavaca";
            this.btnSpisakPredavaca.Size = new System.Drawing.Size(154, 53);
            this.btnSpisakPredavaca.TabIndex = 36;
            this.btnSpisakPredavaca.Text = "Spisak predavača predmeta";
            this.btnSpisakPredavaca.UseVisualStyleBackColor = false;
            this.btnSpisakPredavaca.Click += new System.EventHandler(this.btnSpisakPredavaca_Click);
            // 
            // groupBoxSpisakPredavaca
            // 
            this.groupBoxSpisakPredavaca.Controls.Add(this.groupBox1);
            this.groupBoxSpisakPredavaca.Controls.Add(this.groupBox2);
            this.groupBoxSpisakPredavaca.Controls.Add(this.labelPredmet);
            this.groupBoxSpisakPredavaca.Controls.Add(this.txtImePrezimeAdministratora);
            this.groupBoxSpisakPredavaca.Controls.Add(this.dataGridPredavaci);
            this.groupBoxSpisakPredavaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpisakPredavaca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSpisakPredavaca.Location = new System.Drawing.Point(12, 328);
            this.groupBoxSpisakPredavaca.Name = "groupBoxSpisakPredavaca";
            this.groupBoxSpisakPredavaca.Size = new System.Drawing.Size(1111, 240);
            this.groupBoxSpisakPredavaca.TabIndex = 37;
            this.groupBoxSpisakPredavaca.TabStop = false;
            this.groupBoxSpisakPredavaca.Text = "Spisak predavača predmeta";
            this.groupBoxSpisakPredavaca.Visible = false;
            // 
            // dataGridPredavaci
            // 
            this.dataGridPredavaci.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPredavaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPredavaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridPredavaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPredavaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridPredavaci.EnableHeadersVisualStyles = false;
            this.dataGridPredavaci.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridPredavaci.Location = new System.Drawing.Point(6, 84);
            this.dataGridPredavaci.Name = "dataGridPredavaci";
            this.dataGridPredavaci.ReadOnly = true;
            this.dataGridPredavaci.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridPredavaci.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridPredavaci.RowTemplate.Height = 24;
            this.dataGridPredavaci.Size = new System.Drawing.Size(494, 133);
            this.dataGridPredavaci.TabIndex = 38;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID Nastavnika";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ime";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Prezime";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // txtImePrezimeAdministratora
            // 
            this.txtImePrezimeAdministratora.AutoSize = true;
            this.txtImePrezimeAdministratora.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeAdministratora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeAdministratora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtImePrezimeAdministratora.Location = new System.Drawing.Point(44, 41);
            this.txtImePrezimeAdministratora.Name = "txtImePrezimeAdministratora";
            this.txtImePrezimeAdministratora.Size = new System.Drawing.Size(85, 20);
            this.txtImePrezimeAdministratora.TabIndex = 39;
            this.txtImePrezimeAdministratora.Text = "Predmet:";
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.BackColor = System.Drawing.Color.Transparent;
            this.labelPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPredmet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPredmet.Location = new System.Drawing.Point(153, 41);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(53, 20);
            this.labelPredmet.TabIndex = 40;
            this.labelPredmet.Text = "naziv";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDodajPredavaca);
            this.groupBox2.Controls.Add(this.btnDodajPredavaca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(518, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 176);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje predavača";
            // 
            // cbxDodajPredavaca
            // 
            this.cbxDodajPredavaca.FormattingEnabled = true;
            this.cbxDodajPredavaca.Location = new System.Drawing.Point(46, 82);
            this.cbxDodajPredavaca.Name = "cbxDodajPredavaca";
            this.cbxDodajPredavaca.Size = new System.Drawing.Size(189, 24);
            this.cbxDodajPredavaca.TabIndex = 35;
            // 
            // btnDodajPredavaca
            // 
            this.btnDodajPredavaca.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajPredavaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredavaca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajPredavaca.Location = new System.Drawing.Point(60, 130);
            this.btnDodajPredavaca.Name = "btnDodajPredavaca";
            this.btnDodajPredavaca.Size = new System.Drawing.Size(163, 29);
            this.btnDodajPredavaca.TabIndex = 32;
            this.btnDodajPredavaca.Text = "Dodaj predavača";
            this.btnDodajPredavaca.UseVisualStyleBackColor = false;
            this.btnDodajPredavaca.Click += new System.EventHandler(this.btnDodajPredavaca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(67, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dodaj predavača:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUkloniPredavaca);
            this.groupBox1.Controls.Add(this.btnUkloni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(820, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 176);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uklanjanje predavača";
            // 
            // cbxUkloniPredavaca
            // 
            this.cbxUkloniPredavaca.FormattingEnabled = true;
            this.cbxUkloniPredavaca.Location = new System.Drawing.Point(36, 82);
            this.cbxUkloniPredavaca.Name = "cbxUkloniPredavaca";
            this.cbxUkloniPredavaca.Size = new System.Drawing.Size(192, 24);
            this.cbxUkloniPredavaca.TabIndex = 35;
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloni.Location = new System.Drawing.Point(60, 130);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(163, 29);
            this.btnUkloni.TabIndex = 32;
            this.btnUkloni.Text = "Ukloni predavača";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ukloni predavača:";
            // 
            // FormaPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 580);
            this.Controls.Add(this.groupBoxSpisakPredavaca);
            this.Controls.Add(this.btnSpisakPredavaca);
            this.Controls.Add(this.btnIzmeniPredmet);
            this.Controls.Add(this.btnUkloniPredmet);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.dataGridPredmeti);
            this.Name = "FormaPredmeti";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredmeti)).EndInit();
            this.groupBoxSpisakPredavaca.ResumeLayout(false);
            this.groupBoxSpisakPredavaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredavaci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.Button btnUkloniPredmet;
        private System.Windows.Forms.Button btnIzmeniPredmet;
        private System.Windows.Forms.Button btnSpisakPredavaca;
        private System.Windows.Forms.GroupBox groupBoxSpisakPredavaca;
        private System.Windows.Forms.DataGridView dataGridPredavaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label txtImePrezimeAdministratora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxUkloniPredavaca;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxDodajPredavaca;
        private System.Windows.Forms.Button btnDodajPredavaca;
        private System.Windows.Forms.Label label3;
    }
}