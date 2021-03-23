namespace eDnevnik
{
    partial class FormaVrsiociFunkcija
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxKraj = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPocetak = new System.Windows.Forms.CheckBox();
            this.cbxIzmeni = new System.Windows.Forms.ComboBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxUkloni = new System.Windows.Forms.ComboBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDodajRoditeljId = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datagridFunkcije = new System.Windows.Forms.DataGridView();
            this.cbxDodajFunkcija = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFunkcije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.checkBoxKraj);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.checkBoxPocetak);
            this.groupBox3.Controls.Add(this.cbxIzmeni);
            this.groupBox3.Controls.Add(this.buttonIzmeni);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(833, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 346);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izmeni funckiju";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker2.TabIndex = 39;
            this.dateTimePicker2.Visible = false;
            // 
            // checkBoxKraj
            // 
            this.checkBoxKraj.AutoSize = true;
            this.checkBoxKraj.Location = new System.Drawing.Point(22, 206);
            this.checkBoxKraj.Name = "checkBoxKraj";
            this.checkBoxKraj.Size = new System.Drawing.Size(200, 21);
            this.checkBoxKraj.TabIndex = 38;
            this.checkBoxKraj.Text = "Izemni datum završetka";
            this.checkBoxKraj.UseVisualStyleBackColor = true;
            this.checkBoxKraj.CheckedChanged += new System.EventHandler(this.checkBoxKraj_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Visible = false;
            // 
            // checkBoxPocetak
            // 
            this.checkBoxPocetak.AutoSize = true;
            this.checkBoxPocetak.Location = new System.Drawing.Point(22, 147);
            this.checkBoxPocetak.Name = "checkBoxPocetak";
            this.checkBoxPocetak.Size = new System.Drawing.Size(187, 21);
            this.checkBoxPocetak.TabIndex = 36;
            this.checkBoxPocetak.Text = "Izemni datum pocetka";
            this.checkBoxPocetak.UseVisualStyleBackColor = true;
            this.checkBoxPocetak.CheckedChanged += new System.EventHandler(this.checkBoxPocetak_CheckedChanged);
            // 
            // cbxIzmeni
            // 
            this.cbxIzmeni.FormattingEnabled = true;
            this.cbxIzmeni.Location = new System.Drawing.Point(95, 96);
            this.cbxIzmeni.Name = "cbxIzmeni";
            this.cbxIzmeni.Size = new System.Drawing.Size(127, 24);
            this.cbxIzmeni.TabIndex = 35;
            this.cbxIzmeni.SelectedIndexChanged += new System.EventHandler(this.cbxIzmeni_SelectedIndexChanged);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonIzmeni.Location = new System.Drawing.Point(89, 287);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(163, 35);
            this.buttonIzmeni.TabIndex = 32;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(61, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID funkcije koja se menja:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUkloni);
            this.groupBox2.Controls.Add(this.btnUkloni);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(458, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 226);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uklanjanje izvršioca funkcije";
            // 
            // cbxUkloni
            // 
            this.cbxUkloni.FormattingEnabled = true;
            this.cbxUkloni.Location = new System.Drawing.Point(81, 106);
            this.cbxUkloni.Name = "cbxUkloni";
            this.cbxUkloni.Size = new System.Drawing.Size(127, 24);
            this.cbxUkloni.TabIndex = 40;
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloni.Location = new System.Drawing.Point(60, 172);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(163, 31);
            this.btnUkloni.TabIndex = 32;
            this.btnUkloni.Text = "Ukloni ";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(68, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID trenutne funkcije:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDodajFunkcija);
            this.groupBox1.Controls.Add(this.cbxDodajRoditeljId);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(77, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 322);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje izvršioca funkcije";
            // 
            // cbxDodajRoditeljId
            // 
            this.cbxDodajRoditeljId.FormattingEnabled = true;
            this.cbxDodajRoditeljId.Location = new System.Drawing.Point(90, 96);
            this.cbxDodajRoditeljId.Name = "cbxDodajRoditeljId";
            this.cbxDodajRoditeljId.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajRoditeljId.TabIndex = 34;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(79, 267);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(163, 29);
            this.btnDodaj.TabIndex = 32;
            this.btnDodaj.Text = "Dodaj ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id roditelja bez funkcije:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(112, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Funkcija:";
            // 
            // datagridFunkcije
            // 
            this.datagridFunkcije.BackgroundColor = System.Drawing.Color.White;
            this.datagridFunkcije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridFunkcije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datagridFunkcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFunkcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.datagridFunkcije.EnableHeadersVisualStyles = false;
            this.datagridFunkcije.GridColor = System.Drawing.Color.MediumBlue;
            this.datagridFunkcije.Location = new System.Drawing.Point(66, 48);
            this.datagridFunkcije.Name = "datagridFunkcije";
            this.datagridFunkcije.ReadOnly = true;
            this.datagridFunkcije.RowHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.datagridFunkcije.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.datagridFunkcije.RowTemplate.Height = 24;
            this.datagridFunkcije.Size = new System.Drawing.Size(932, 211);
            this.datagridFunkcije.TabIndex = 40;
            // 
            // cbxDodajFunkcija
            // 
            this.cbxDodajFunkcija.FormattingEnabled = true;
            this.cbxDodajFunkcija.Items.AddRange(new object[] {
            "predsednik",
            "zamenik predsednika"});
            this.cbxDodajFunkcija.Location = new System.Drawing.Point(90, 188);
            this.cbxDodajFunkcija.Name = "cbxDodajFunkcija";
            this.cbxDodajFunkcija.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajFunkcija.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID funkcije";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Roditelja";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Roditelj";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Funkcija";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Datum od";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Datum do";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // FormaVrsiociFunkcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 706);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridFunkcije);
            this.Name = "FormaVrsiociFunkcija";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaVrsiociFunkcija_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFunkcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxKraj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxPocetak;
        private System.Windows.Forms.ComboBox cbxIzmeni;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxUkloni;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDodajRoditeljId;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView datagridFunkcije;
        private System.Windows.Forms.ComboBox cbxDodajFunkcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}