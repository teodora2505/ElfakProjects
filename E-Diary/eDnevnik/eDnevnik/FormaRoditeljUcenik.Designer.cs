namespace eDnevnik
{
    partial class FormaRoditeljUcenik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridRoditelji = new System.Windows.Forms.DataGridView();
            this.dataGridDeca = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRoditelj = new System.Windows.Forms.Label();
            this.labelDeca = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajRoditeljDete = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.labelDodaj = new System.Windows.Forms.Label();
            this.btnUkloniDete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoditelji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRoditelji
            // 
            this.dataGridRoditelji.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRoditelji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRoditelji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridRoditelji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoditelji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridRoditelji.EnableHeadersVisualStyles = false;
            this.dataGridRoditelji.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridRoditelji.Location = new System.Drawing.Point(25, 67);
            this.dataGridRoditelji.Name = "dataGridRoditelji";
            this.dataGridRoditelji.ReadOnly = true;
            this.dataGridRoditelji.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridRoditelji.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridRoditelji.RowTemplate.Height = 24;
            this.dataGridRoditelji.Size = new System.Drawing.Size(457, 195);
            this.dataGridRoditelji.TabIndex = 33;
            this.dataGridRoditelji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoditelji_CellClick);
            // 
            // dataGridDeca
            // 
            this.dataGridDeca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDeca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridDeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridDeca.EnableHeadersVisualStyles = false;
            this.dataGridDeca.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridDeca.Location = new System.Drawing.Point(488, 67);
            this.dataGridDeca.Name = "dataGridDeca";
            this.dataGridDeca.ReadOnly = true;
            this.dataGridDeca.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridDeca.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDeca.RowTemplate.Height = 24;
            this.dataGridDeca.Size = new System.Drawing.Size(459, 195);
            this.dataGridDeca.TabIndex = 34;
            this.dataGridDeca.Visible = false;
            this.dataGridDeca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeca_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Ucenika";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // labelRoditelj
            // 
            this.labelRoditelj.AutoSize = true;
            this.labelRoditelj.BackColor = System.Drawing.Color.Transparent;
            this.labelRoditelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoditelj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRoditelj.Location = new System.Drawing.Point(21, 34);
            this.labelRoditelj.Name = "labelRoditelj";
            this.labelRoditelj.Size = new System.Drawing.Size(78, 20);
            this.labelRoditelj.TabIndex = 35;
            this.labelRoditelj.Text = "Roditelji";
            // 
            // labelDeca
            // 
            this.labelDeca.AutoSize = true;
            this.labelDeca.BackColor = System.Drawing.Color.Transparent;
            this.labelDeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelDeca.Location = new System.Drawing.Point(484, 34);
            this.labelDeca.Name = "labelDeca";
            this.labelDeca.Size = new System.Drawing.Size(53, 20);
            this.labelDeca.TabIndex = 36;
            this.labelDeca.Text = "Deca";
            this.labelDeca.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Roditelja";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
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
            // btnDodajRoditeljDete
            // 
            this.btnDodajRoditeljDete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajRoditeljDete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRoditeljDete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajRoditeljDete.Location = new System.Drawing.Point(41, 283);
            this.btnDodajRoditeljDete.Name = "btnDodajRoditeljDete";
            this.btnDodajRoditeljDete.Size = new System.Drawing.Size(173, 34);
            this.btnDodajRoditeljDete.TabIndex = 37;
            this.btnDodajRoditeljDete.Text = "Dodaj dete roditelju";
            this.btnDodajRoditeljDete.UseVisualStyleBackColor = false;
            this.btnDodajRoditeljDete.Click += new System.EventHandler(this.btnDodajRoditeljDete_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(423, 283);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 34);
            this.btnDodaj.TabIndex = 38;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // labelDodaj
            // 
            this.labelDodaj.AutoSize = true;
            this.labelDodaj.BackColor = System.Drawing.Color.Transparent;
            this.labelDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodaj.ForeColor = System.Drawing.Color.Red;
            this.labelDodaj.Location = new System.Drawing.Point(667, 34);
            this.labelDodaj.Name = "labelDodaj";
            this.labelDodaj.Size = new System.Drawing.Size(239, 20);
            this.labelDodaj.TabIndex = 39;
            this.labelDodaj.Text = "Potrebno je da selektujete dete";
            this.labelDodaj.Visible = false;
            // 
            // btnUkloniDete
            // 
            this.btnUkloniDete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniDete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniDete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniDete.Location = new System.Drawing.Point(750, 283);
            this.btnUkloniDete.Name = "btnUkloniDete";
            this.btnUkloniDete.Size = new System.Drawing.Size(173, 34);
            this.btnUkloniDete.TabIndex = 40;
            this.btnUkloniDete.Text = "Ukloni dete";
            this.btnUkloniDete.UseVisualStyleBackColor = false;
            this.btnUkloniDete.Click += new System.EventHandler(this.btnUkloniDete_Click);
            // 
            // FormaRoditeljUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 339);
            this.Controls.Add(this.btnUkloniDete);
            this.Controls.Add(this.labelDodaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnDodajRoditeljDete);
            this.Controls.Add(this.labelDeca);
            this.Controls.Add(this.labelRoditelj);
            this.Controls.Add(this.dataGridDeca);
            this.Controls.Add(this.dataGridRoditelji);
            this.Name = "FormaRoditeljUcenik";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaRoditeljUcenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoditelji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRoditelji;
        private System.Windows.Forms.DataGridView dataGridDeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label labelRoditelj;
        private System.Windows.Forms.Label labelDeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnDodajRoditeljDete;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label labelDodaj;
        private System.Windows.Forms.Button btnUkloniDete;
    }
}