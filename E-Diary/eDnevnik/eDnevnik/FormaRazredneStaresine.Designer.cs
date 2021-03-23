namespace eDnevnik
{
    partial class FormaRazredneStaresine
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
            this.dataGridRazredni = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajStaresinstvo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDodajOdeljenje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxRazredniDodaj = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxUkloniStaresinstvo = new System.Windows.Forms.ComboBox();
            this.btnUkloniStaresinstvo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxKraj = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPocetak = new System.Windows.Forms.CheckBox();
            this.cbxIzmeni = new System.Windows.Forms.ComboBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRazredni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRazredni
            // 
            this.dataGridRazredni.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRazredni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRazredni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRazredni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRazredni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridRazredni.EnableHeadersVisualStyles = false;
            this.dataGridRazredni.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridRazredni.Location = new System.Drawing.Point(12, 12);
            this.dataGridRazredni.Name = "dataGridRazredni";
            this.dataGridRazredni.ReadOnly = true;
            this.dataGridRazredni.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridRazredni.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRazredni.RowTemplate.Height = 24;
            this.dataGridRazredni.Size = new System.Drawing.Size(991, 260);
            this.dataGridRazredni.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id starešinstva";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Razredni starešina";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Odeljenje";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Datum od";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Datum do";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnDodajStaresinstvo
            // 
            this.btnDodajStaresinstvo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajStaresinstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStaresinstvo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajStaresinstvo.Location = new System.Drawing.Point(79, 267);
            this.btnDodajStaresinstvo.Name = "btnDodajStaresinstvo";
            this.btnDodajStaresinstvo.Size = new System.Drawing.Size(163, 29);
            this.btnDodajStaresinstvo.TabIndex = 32;
            this.btnDodajStaresinstvo.Text = "Dodaj starešinstvo";
            this.btnDodajStaresinstvo.UseVisualStyleBackColor = false;
            this.btnDodajStaresinstvo.Click += new System.EventHandler(this.btnDodajStaresinstvo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDodajOdeljenje);
            this.groupBox1.Controls.Add(this.btnDodajStaresinstvo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbxRazredniDodaj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(40, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 322);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje starešinstva";
            // 
            // cbxDodajOdeljenje
            // 
            this.cbxDodajOdeljenje.FormattingEnabled = true;
            this.cbxDodajOdeljenje.Location = new System.Drawing.Point(96, 192);
            this.cbxDodajOdeljenje.Name = "cbxDodajOdeljenje";
            this.cbxDodajOdeljenje.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajOdeljenje.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(67, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Odeljenja bez starešine:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Nastavnici koji nisu razredne starešine:";
            // 
            // cbxRazredniDodaj
            // 
            this.cbxRazredniDodaj.FormattingEnabled = true;
            this.cbxRazredniDodaj.Location = new System.Drawing.Point(56, 90);
            this.cbxRazredniDodaj.Name = "cbxRazredniDodaj";
            this.cbxRazredniDodaj.Size = new System.Drawing.Size(216, 24);
            this.cbxRazredniDodaj.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUkloniStaresinstvo);
            this.groupBox2.Controls.Add(this.btnUkloniStaresinstvo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(385, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 217);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uklanjanje starešinstva";
            // 
            // cbxUkloniStaresinstvo
            // 
            this.cbxUkloniStaresinstvo.FormattingEnabled = true;
            this.cbxUkloniStaresinstvo.Location = new System.Drawing.Point(79, 96);
            this.cbxUkloniStaresinstvo.Name = "cbxUkloniStaresinstvo";
            this.cbxUkloniStaresinstvo.Size = new System.Drawing.Size(127, 24);
            this.cbxUkloniStaresinstvo.TabIndex = 35;
            // 
            // btnUkloniStaresinstvo
            // 
            this.btnUkloniStaresinstvo.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniStaresinstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniStaresinstvo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniStaresinstvo.Location = new System.Drawing.Point(60, 154);
            this.btnUkloniStaresinstvo.Name = "btnUkloniStaresinstvo";
            this.btnUkloniStaresinstvo.Size = new System.Drawing.Size(163, 29);
            this.btnUkloniStaresinstvo.TabIndex = 32;
            this.btnUkloniStaresinstvo.Text = "Ukloni starešinstvo";
            this.btnUkloniStaresinstvo.UseVisualStyleBackColor = false;
            this.btnUkloniStaresinstvo.Click += new System.EventHandler(this.btnUkloniStaresinstvo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(57, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id trenutog starešinstva:";
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
            this.groupBox3.Location = new System.Drawing.Point(687, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 322);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izmena starešinstva";
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
            this.buttonIzmeni.Size = new System.Drawing.Size(163, 29);
            this.buttonIzmeni.TabIndex = 32;
            this.buttonIzmeni.Text = "Izmeni starešinstvo";
            this.buttonIzmeni.UseVisualStyleBackColor = false;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(67, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id trenutog starešinstva:";
            // 
            // FormaRazredneStaresine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridRazredni);
            this.Name = "FormaRazredneStaresine";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaRazredneStaresine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRazredni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRazredni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDodajStaresinstvo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRazredniDodaj;
        private System.Windows.Forms.ComboBox cbxDodajOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUkloniStaresinstvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUkloniStaresinstvo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxKraj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxPocetak;
        private System.Windows.Forms.ComboBox cbxIzmeni;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Label label2;
    }
}