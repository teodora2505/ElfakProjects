namespace eDnevnik
{
    partial class FormaDrziCas
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
            this.dataGridDrziCas = new System.Windows.Forms.DataGridView();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDodajNastavnikId = new System.Windows.Forms.ComboBox();
            this.btnDodajPredstavnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDodajOdeljenjeId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDodajPredmetId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrziCas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDrziCas
            // 
            this.dataGridDrziCas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDrziCas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDrziCas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDrziCas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrziCas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column7,
            this.Column4});
            this.dataGridDrziCas.EnableHeadersVisualStyles = false;
            this.dataGridDrziCas.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridDrziCas.Location = new System.Drawing.Point(26, 24);
            this.dataGridDrziCas.Name = "dataGridDrziCas";
            this.dataGridDrziCas.ReadOnly = true;
            this.dataGridDrziCas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridDrziCas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDrziCas.RowTemplate.Height = 24;
            this.dataGridDrziCas.Size = new System.Drawing.Size(994, 226);
            this.dataGridDrziCas.TabIndex = 31;
            this.dataGridDrziCas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDrziCas_CellClick);
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloni.Location = new System.Drawing.Point(587, 387);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(224, 89);
            this.btnUkloni.TabIndex = 32;
            this.btnUkloni.Text = "Ukloni selektovanu vezu";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDodajPredmetId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxDodajOdeljenjeId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxDodajNastavnikId);
            this.groupBox1.Controls.Add(this.btnDodajPredstavnika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(86, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 315);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje ";
            // 
            // cbxDodajNastavnikId
            // 
            this.cbxDodajNastavnikId.FormattingEnabled = true;
            this.cbxDodajNastavnikId.Location = new System.Drawing.Point(156, 57);
            this.cbxDodajNastavnikId.Name = "cbxDodajNastavnikId";
            this.cbxDodajNastavnikId.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajNastavnikId.TabIndex = 34;
            this.cbxDodajNastavnikId.SelectedIndexChanged += new System.EventHandler(this.cbxDodajNastavnikId_SelectedIndexChanged);
            // 
            // btnDodajPredstavnika
            // 
            this.btnDodajPredstavnika.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajPredstavnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredstavnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajPredstavnika.Location = new System.Drawing.Point(70, 270);
            this.btnDodajPredstavnika.Name = "btnDodajPredstavnika";
            this.btnDodajPredstavnika.Size = new System.Drawing.Size(163, 29);
            this.btnDodajPredstavnika.TabIndex = 32;
            this.btnDodajPredstavnika.Text = "Dodaj ";
            this.btnDodajPredstavnika.UseVisualStyleBackColor = false;
            this.btnDodajPredstavnika.Click += new System.EventHandler(this.btnDodajPredstavnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id nastavnika:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Nastavnika";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nastavnik";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID Odeljenja";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Odeljenje";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID Predmeta";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Drži predmet";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Id odeljenja:";
            // 
            // cbxDodajOdeljenjeId
            // 
            this.cbxDodajOdeljenjeId.FormattingEnabled = true;
            this.cbxDodajOdeljenjeId.Location = new System.Drawing.Point(156, 109);
            this.cbxDodajOdeljenjeId.Name = "cbxDodajOdeljenjeId";
            this.cbxDodajOdeljenjeId.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajOdeljenjeId.TabIndex = 36;
            this.cbxDodajOdeljenjeId.SelectedIndexChanged += new System.EventHandler(this.cbxDodajOdeljenjeId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(67, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 34);
            this.label5.TabIndex = 37;
            this.label5.Text = "Predmeti koje nastavnik\r\n ne predaje odeljenju:";
            // 
            // cbxDodajPredmetId
            // 
            this.cbxDodajPredmetId.Enabled = false;
            this.cbxDodajPredmetId.FormattingEnabled = true;
            this.cbxDodajPredmetId.Location = new System.Drawing.Point(94, 219);
            this.cbxDodajPredmetId.Name = "cbxDodajPredmetId";
            this.cbxDodajPredmetId.Size = new System.Drawing.Size(127, 24);
            this.cbxDodajPredmetId.TabIndex = 38;
            // 
            // FormaDrziCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridDrziCas);
            this.Name = "FormaDrziCas";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaDrziCas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrziCas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDrziCas;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDodajNastavnikId;
        private System.Windows.Forms.Button btnDodajPredstavnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbxDodajPredmetId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDodajOdeljenjeId;
        private System.Windows.Forms.Label label4;
    }
}