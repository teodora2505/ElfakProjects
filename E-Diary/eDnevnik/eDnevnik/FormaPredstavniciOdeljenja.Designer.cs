namespace eDnevnik
{
    partial class FormaPredstavniciOdeljenja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPredstavniciOdeljenja = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajPredstavnika = new System.Windows.Forms.Button();
            this.cbxDodajOdeljenje = new System.Windows.Forms.ComboBox();
            this.txtDodajPredstavnika = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUkloniPredstavljanje = new System.Windows.Forms.Button();
            this.cbxUkloni = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.cbxIzmeni = new System.Windows.Forms.ComboBox();
            this.checkBoxPocetak = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxKraj = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredstavniciOdeljenja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPredstavniciOdeljenja
            // 
            this.dataGridPredstavniciOdeljenja.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPredstavniciOdeljenja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPredstavniciOdeljenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPredstavniciOdeljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPredstavniciOdeljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridPredstavniciOdeljenja.EnableHeadersVisualStyles = false;
            this.dataGridPredstavniciOdeljenja.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridPredstavniciOdeljenja.Location = new System.Drawing.Point(69, 26);
            this.dataGridPredstavniciOdeljenja.Name = "dataGridPredstavniciOdeljenja";
            this.dataGridPredstavniciOdeljenja.ReadOnly = true;
            this.dataGridPredstavniciOdeljenja.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridPredstavniciOdeljenja.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPredstavniciOdeljenja.RowTemplate.Height = 24;
            this.dataGridPredstavniciOdeljenja.Size = new System.Drawing.Size(932, 211);
            this.dataGridPredstavniciOdeljenja.TabIndex = 33;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID predstavljanja";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Odeljenje";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Smer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID predstavnika";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Predstavnik(roditelj)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Datum od";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Datum do";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(67, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "ID predstavnika(roditelja):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Odeljenja bez predstavnika:";
            // 
            // btnDodajPredstavnika
            // 
            this.btnDodajPredstavnika.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajPredstavnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredstavnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajPredstavnika.Location = new System.Drawing.Point(79, 267);
            this.btnDodajPredstavnika.Name = "btnDodajPredstavnika";
            this.btnDodajPredstavnika.Size = new System.Drawing.Size(163, 29);
            this.btnDodajPredstavnika.TabIndex = 32;
            this.btnDodajPredstavnika.Text = "Dodaj predstavnika";
            this.btnDodajPredstavnika.UseVisualStyleBackColor = false;
            this.btnDodajPredstavnika.Click += new System.EventHandler(this.btnDodajPredstavnika_Click);
            // 
            // cbxDodajOdeljenje
            // 
            this.cbxDodajOdeljenje.FormattingEnabled = true;
            this.cbxDodajOdeljenje.Location = new System.Drawing.Point(91, 96);
            this.cbxDodajOdeljenje.Name = "cbxDodajOdeljenje";
            this.cbxDodajOdeljenje.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajOdeljenje.TabIndex = 34;
            // 
            // txtDodajPredstavnika
            // 
            this.txtDodajPredstavnika.Location = new System.Drawing.Point(91, 206);
            this.txtDodajPredstavnika.Name = "txtDodajPredstavnika";
            this.txtDodajPredstavnika.Size = new System.Drawing.Size(127, 22);
            this.txtDodajPredstavnika.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDodajPredstavnika);
            this.groupBox1.Controls.Add(this.cbxDodajOdeljenje);
            this.groupBox1.Controls.Add(this.btnDodajPredstavnika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(80, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 322);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje odeljenskog predstavnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(71, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID predstavljanja:";
            // 
            // btnUkloniPredstavljanje
            // 
            this.btnUkloniPredstavljanje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniPredstavljanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniPredstavljanje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniPredstavljanje.Location = new System.Drawing.Point(60, 154);
            this.btnUkloniPredstavljanje.Name = "btnUkloniPredstavljanje";
            this.btnUkloniPredstavljanje.Size = new System.Drawing.Size(163, 48);
            this.btnUkloniPredstavljanje.TabIndex = 32;
            this.btnUkloniPredstavljanje.Text = "Ukloni predstavnika";
            this.btnUkloniPredstavljanje.UseVisualStyleBackColor = false;
            this.btnUkloniPredstavljanje.Click += new System.EventHandler(this.btnUkloniPredstavljanje_Click);
            // 
            // cbxUkloni
            // 
            this.cbxUkloni.FormattingEnabled = true;
            this.cbxUkloni.Location = new System.Drawing.Point(79, 93);
            this.cbxUkloni.Name = "cbxUkloni";
            this.cbxUkloni.Size = new System.Drawing.Size(127, 24);
            this.cbxUkloni.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUkloni);
            this.groupBox2.Controls.Add(this.btnUkloniPredstavljanje);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(461, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 226);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uklanjanje predstavnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Predstavljanje koje se menja:";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonIzmeni.Location = new System.Drawing.Point(89, 287);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(163, 53);
            this.buttonIzmeni.TabIndex = 32;
            this.buttonIzmeni.Text = "Izmeni predstavljanje";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Visible = false;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker2.TabIndex = 39;
            this.dateTimePicker2.Visible = false;
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
            this.groupBox3.Location = new System.Drawing.Point(836, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 346);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izmeni predstavanje";
            // 
            // FormaPredstavniciOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 673);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridPredstavniciOdeljenja);
            this.Name = "FormaPredstavniciOdeljenja";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaPredstavniciOdeljenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredstavniciOdeljenja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPredstavniciOdeljenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPredstavnika;
        private System.Windows.Forms.ComboBox cbxDodajOdeljenje;
        private System.Windows.Forms.TextBox txtDodajPredstavnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUkloniPredstavljanje;
        private System.Windows.Forms.ComboBox cbxUkloni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.ComboBox cbxIzmeni;
        private System.Windows.Forms.CheckBox checkBoxPocetak;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxKraj;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}