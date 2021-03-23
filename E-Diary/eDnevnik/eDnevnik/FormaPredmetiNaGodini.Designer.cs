namespace eDnevnik
{
    partial class FormaPredmetiNaGodini
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtImePrezimeAdministratora = new System.Windows.Forms.Label();
            this.cbxGodina = new System.Windows.Forms.ComboBox();
            this.datagridPredmeti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDodajPredmeti = new System.Windows.Forms.ComboBox();
            this.cbxDodajGodina = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxUkloniPredet = new System.Windows.Forms.ComboBox();
            this.cbxUkloniGodina = new System.Windows.Forms.ComboBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPredmeti)).BeginInit();
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
            this.txtImePrezimeAdministratora.Location = new System.Drawing.Point(37, 53);
            this.txtImePrezimeAdministratora.Name = "txtImePrezimeAdministratora";
            this.txtImePrezimeAdministratora.Size = new System.Drawing.Size(149, 20);
            this.txtImePrezimeAdministratora.TabIndex = 4;
            this.txtImePrezimeAdministratora.Text = "Izaberite godinu:";
            // 
            // cbxGodina
            // 
            this.cbxGodina.FormattingEnabled = true;
            this.cbxGodina.Location = new System.Drawing.Point(75, 102);
            this.cbxGodina.Name = "cbxGodina";
            this.cbxGodina.Size = new System.Drawing.Size(66, 24);
            this.cbxGodina.TabIndex = 5;
            this.cbxGodina.SelectedIndexChanged += new System.EventHandler(this.cbxGodina_SelectedIndexChanged);
            // 
            // datagridPredmeti
            // 
            this.datagridPredmeti.BackgroundColor = System.Drawing.Color.White;
            this.datagridPredmeti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPredmeti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.datagridPredmeti.EnableHeadersVisualStyles = false;
            this.datagridPredmeti.GridColor = System.Drawing.Color.MediumBlue;
            this.datagridPredmeti.Location = new System.Drawing.Point(247, 12);
            this.datagridPredmeti.Name = "datagridPredmeti";
            this.datagridPredmeti.ReadOnly = true;
            this.datagridPredmeti.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.datagridPredmeti.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridPredmeti.RowTemplate.Height = 24;
            this.datagridPredmeti.Size = new System.Drawing.Size(502, 211);
            this.datagridPredmeti.TabIndex = 41;
            this.datagridPredmeti.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID predmeta";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDodajPredmeti);
            this.groupBox1.Controls.Add(this.cbxDodajGodina);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(41, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 287);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje predmeta na godini";
            // 
            // cbxDodajPredmeti
            // 
            this.cbxDodajPredmeti.Enabled = false;
            this.cbxDodajPredmeti.FormattingEnabled = true;
            this.cbxDodajPredmeti.Items.AddRange(new object[] {
            "predsednik",
            "zamenik predsednika"});
            this.cbxDodajPredmeti.Location = new System.Drawing.Point(79, 174);
            this.cbxDodajPredmeti.Name = "cbxDodajPredmeti";
            this.cbxDodajPredmeti.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajPredmeti.TabIndex = 35;
            // 
            // cbxDodajGodina
            // 
            this.cbxDodajGodina.FormattingEnabled = true;
            this.cbxDodajGodina.Location = new System.Drawing.Point(79, 82);
            this.cbxDodajGodina.Name = "cbxDodajGodina";
            this.cbxDodajGodina.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajGodina.TabIndex = 34;
            this.cbxDodajGodina.SelectedIndexChanged += new System.EventHandler(this.cbxDodajGodina_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(60, 239);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(163, 29);
            this.btnDodaj.TabIndex = 32;
            this.btnDodaj.Text = "Dodaj predmet";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(112, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Godina:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(22, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Predmeti koji se ne drže na godini:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUkloniPredet);
            this.groupBox2.Controls.Add(this.cbxUkloniGodina);
            this.groupBox2.Controls.Add(this.btnUkloni);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(406, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 287);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uklanjanje predmeta na godini";
            // 
            // cbxUkloniPredet
            // 
            this.cbxUkloniPredet.Enabled = false;
            this.cbxUkloniPredet.FormattingEnabled = true;
            this.cbxUkloniPredet.Items.AddRange(new object[] {
            "predsednik",
            "zamenik predsednika"});
            this.cbxUkloniPredet.Location = new System.Drawing.Point(79, 174);
            this.cbxUkloniPredet.Name = "cbxUkloniPredet";
            this.cbxUkloniPredet.Size = new System.Drawing.Size(127, 24);
            this.cbxUkloniPredet.TabIndex = 35;
            // 
            // cbxUkloniGodina
            // 
            this.cbxUkloniGodina.FormattingEnabled = true;
            this.cbxUkloniGodina.Location = new System.Drawing.Point(79, 82);
            this.cbxUkloniGodina.Name = "cbxUkloniGodina";
            this.cbxUkloniGodina.Size = new System.Drawing.Size(127, 24);
            this.cbxUkloniGodina.TabIndex = 34;
            this.cbxUkloniGodina.SelectedIndexChanged += new System.EventHandler(this.cbxUkloniGodina_SelectedIndexChanged);
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloni.Location = new System.Drawing.Point(64, 239);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(163, 29);
            this.btnUkloni.TabIndex = 32;
            this.btnUkloni.Text = "Ukloni predmet";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(112, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Godina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(52, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Predmeti koji se uklanja:";
            // 
            // FormaPredmetiNaGodini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridPredmeti);
            this.Controls.Add(this.cbxGodina);
            this.Controls.Add(this.txtImePrezimeAdministratora);
            this.Name = "FormaPredmetiNaGodini";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaPredmetiNaGodini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPredmeti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtImePrezimeAdministratora;
        private System.Windows.Forms.ComboBox cbxGodina;
        private System.Windows.Forms.DataGridView datagridPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDodajPredmeti;
        private System.Windows.Forms.ComboBox cbxDodajGodina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxUkloniPredet;
        private System.Windows.Forms.ComboBox cbxUkloniGodina;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}