namespace eDnevnik
{
    partial class FormaNastavnikPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaNastavnikPocetna));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt1 = new System.Windows.Forms.Label();
            this.panelPrijavljeniNastavnik = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImePrezimeNastavnika = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMojiPredmeti = new System.Windows.Forms.Button();
            this.btnMojaOdeljenja = new System.Windows.Forms.Button();
            this.dataGridMojaOdeljenja = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPredmeti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrijavljeniNastavnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMojaOdeljenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.BackColor = System.Drawing.Color.Transparent;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt1.Location = new System.Drawing.Point(3, 17);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(97, 20);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "Nastavnik:";
            // 
            // panelPrijavljeniNastavnik
            // 
            this.panelPrijavljeniNastavnik.Controls.Add(this.button1);
            this.panelPrijavljeniNastavnik.Controls.Add(this.txtImePrezimeNastavnika);
            this.panelPrijavljeniNastavnik.Controls.Add(this.txt1);
            this.panelPrijavljeniNastavnik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrijavljeniNastavnik.Location = new System.Drawing.Point(0, 0);
            this.panelPrijavljeniNastavnik.Name = "panelPrijavljeniNastavnik";
            this.panelPrijavljeniNastavnik.Size = new System.Drawing.Size(1100, 61);
            this.panelPrijavljeniNastavnik.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(919, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Odjava";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImePrezimeNastavnika
            // 
            this.txtImePrezimeNastavnika.AutoSize = true;
            this.txtImePrezimeNastavnika.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeNastavnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeNastavnika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtImePrezimeNastavnika.Location = new System.Drawing.Point(106, 17);
            this.txtImePrezimeNastavnika.Name = "txtImePrezimeNastavnika";
            this.txtImePrezimeNastavnika.Size = new System.Drawing.Size(108, 20);
            this.txtImePrezimeNastavnika.TabIndex = 3;
            this.txtImePrezimeNastavnika.Text = "ImePrezime";
            // 
            // btnMojiPredmeti
            // 
            this.btnMojiPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojiPredmeti.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMojiPredmeti.Image = ((System.Drawing.Image)(resources.GetObject("btnMojiPredmeti.Image")));
            this.btnMojiPredmeti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMojiPredmeti.Location = new System.Drawing.Point(35, 92);
            this.btnMojiPredmeti.Name = "btnMojiPredmeti";
            this.btnMojiPredmeti.Size = new System.Drawing.Size(232, 115);
            this.btnMojiPredmeti.TabIndex = 6;
            this.btnMojiPredmeti.Text = "Moji predmeti";
            this.btnMojiPredmeti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMojiPredmeti.UseVisualStyleBackColor = true;
            this.btnMojiPredmeti.Click += new System.EventHandler(this.btnMojiPredmeti_Click);
            // 
            // btnMojaOdeljenja
            // 
            this.btnMojaOdeljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojaOdeljenja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMojaOdeljenja.Image = ((System.Drawing.Image)(resources.GetObject("btnMojaOdeljenja.Image")));
            this.btnMojaOdeljenja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMojaOdeljenja.Location = new System.Drawing.Point(35, 232);
            this.btnMojaOdeljenja.Name = "btnMojaOdeljenja";
            this.btnMojaOdeljenja.Size = new System.Drawing.Size(232, 115);
            this.btnMojaOdeljenja.TabIndex = 7;
            this.btnMojaOdeljenja.Text = "Moja odeljenja";
            this.btnMojaOdeljenja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMojaOdeljenja.UseVisualStyleBackColor = true;
            this.btnMojaOdeljenja.Click += new System.EventHandler(this.btnMojaOdeljenja_Click);
            // 
            // dataGridMojaOdeljenja
            // 
            this.dataGridMojaOdeljenja.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMojaOdeljenja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMojaOdeljenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMojaOdeljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMojaOdeljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridMojaOdeljenja.EnableHeadersVisualStyles = false;
            this.dataGridMojaOdeljenja.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridMojaOdeljenja.Location = new System.Drawing.Point(416, 92);
            this.dataGridMojaOdeljenja.Name = "dataGridMojaOdeljenja";
            this.dataGridMojaOdeljenja.ReadOnly = true;
            this.dataGridMojaOdeljenja.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridMojaOdeljenja.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMojaOdeljenja.RowTemplate.Height = 24;
            this.dataGridMojaOdeljenja.Size = new System.Drawing.Size(599, 348);
            this.dataGridMojaOdeljenja.TabIndex = 8;
            this.dataGridMojaOdeljenja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMojaOdeljenja_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID Odeljenja";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Naziv";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Smer";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // dataGridPredmeti
            // 
            this.dataGridPredmeti.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPredmeti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPredmeti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridPredmeti.Location = new System.Drawing.Point(342, 92);
            this.dataGridPredmeti.Name = "dataGridPredmeti";
            this.dataGridPredmeti.ReadOnly = true;
            this.dataGridPredmeti.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridPredmeti.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPredmeti.RowTemplate.Height = 24;
            this.dataGridPredmeti.Size = new System.Drawing.Size(731, 372);
            this.dataGridPredmeti.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.HeaderText = "Broj časova";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tip predmeta";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
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
            this.Column8.Width = 150;
            // 
            // FormaNastavnikPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 646);
            this.Controls.Add(this.dataGridMojaOdeljenja);
            this.Controls.Add(this.btnMojaOdeljenja);
            this.Controls.Add(this.btnMojiPredmeti);
            this.Controls.Add(this.panelPrijavljeniNastavnik);
            this.Controls.Add(this.dataGridPredmeti);
            this.Name = "FormaNastavnikPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaNastavnikPocetna_Load);
            this.panelPrijavljeniNastavnik.ResumeLayout(false);
            this.panelPrijavljeniNastavnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMojaOdeljenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPredmeti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Panel panelPrijavljeniNastavnik;
        private System.Windows.Forms.Label txtImePrezimeNastavnika;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnMojiPredmeti;
        private System.Windows.Forms.Button btnMojaOdeljenja;
        private System.Windows.Forms.DataGridView dataGridMojaOdeljenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridView dataGridPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}