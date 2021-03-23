namespace eDnevnik
{
    partial class FormaUceniciOdeljenja
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
            this.cbxOdeljenje = new System.Windows.Forms.ComboBox();
            this.txtImePrezimeRoditelja = new System.Windows.Forms.Label();
            this.dataGridUcenici = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPremestiUcenika = new System.Windows.Forms.Button();
            this.panelPremestanje = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNovoOdeljenje = new System.Windows.Forms.ComboBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.btnPremesti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUcenici)).BeginInit();
            this.panelPremestanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxOdeljenje
            // 
            this.cbxOdeljenje.FormattingEnabled = true;
            this.cbxOdeljenje.Location = new System.Drawing.Point(177, 55);
            this.cbxOdeljenje.Name = "cbxOdeljenje";
            this.cbxOdeljenje.Size = new System.Drawing.Size(121, 24);
            this.cbxOdeljenje.TabIndex = 0;
            this.cbxOdeljenje.SelectedIndexChanged += new System.EventHandler(this.cbxOdeljenje_SelectedIndexChanged);
            // 
            // txtImePrezimeRoditelja
            // 
            this.txtImePrezimeRoditelja.AutoSize = true;
            this.txtImePrezimeRoditelja.BackColor = System.Drawing.Color.Transparent;
            this.txtImePrezimeRoditelja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeRoditelja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtImePrezimeRoditelja.Location = new System.Drawing.Point(190, 20);
            this.txtImePrezimeRoditelja.Name = "txtImePrezimeRoditelja";
            this.txtImePrezimeRoditelja.Size = new System.Drawing.Size(94, 20);
            this.txtImePrezimeRoditelja.TabIndex = 4;
            this.txtImePrezimeRoditelja.Text = "Odeljenje:";
            // 
            // dataGridUcenici
            // 
            this.dataGridUcenici.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUcenici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUcenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUcenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridUcenici.EnableHeadersVisualStyles = false;
            this.dataGridUcenici.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridUcenici.Location = new System.Drawing.Point(12, 95);
            this.dataGridUcenici.Name = "dataGridUcenici";
            this.dataGridUcenici.ReadOnly = true;
            this.dataGridUcenici.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridUcenici.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUcenici.RowTemplate.Height = 24;
            this.dataGridUcenici.Size = new System.Drawing.Size(445, 195);
            this.dataGridUcenici.TabIndex = 32;
            this.dataGridUcenici.Visible = false;
            this.dataGridUcenici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUcenici_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Ucenika";
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
            // btnPremestiUcenika
            // 
            this.btnPremestiUcenika.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPremestiUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremestiUcenika.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPremestiUcenika.Location = new System.Drawing.Point(150, 320);
            this.btnPremestiUcenika.Name = "btnPremestiUcenika";
            this.btnPremestiUcenika.Size = new System.Drawing.Size(153, 32);
            this.btnPremestiUcenika.TabIndex = 34;
            this.btnPremestiUcenika.Text = "Premesti učenika";
            this.btnPremestiUcenika.UseVisualStyleBackColor = false;
            this.btnPremestiUcenika.Visible = false;
            this.btnPremestiUcenika.Click += new System.EventHandler(this.btnPremestiUcenika_Click);
            // 
            // panelPremestanje
            // 
            this.panelPremestanje.Controls.Add(this.btnPremesti);
            this.panelPremestanje.Controls.Add(this.labelPrezime);
            this.panelPremestanje.Controls.Add(this.labelIme);
            this.panelPremestanje.Controls.Add(this.cbxNovoOdeljenje);
            this.panelPremestanje.Controls.Add(this.label3);
            this.panelPremestanje.Controls.Add(this.label2);
            this.panelPremestanje.Controls.Add(this.label1);
            this.panelPremestanje.Location = new System.Drawing.Point(12, 315);
            this.panelPremestanje.Name = "panelPremestanje";
            this.panelPremestanje.Size = new System.Drawing.Size(429, 134);
            this.panelPremestanje.TabIndex = 35;
            this.panelPremestanje.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(264, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Novo odeljenje:";
            // 
            // cbxNovoOdeljenje
            // 
            this.cbxNovoOdeljenje.FormattingEnabled = true;
            this.cbxNovoOdeljenje.Location = new System.Drawing.Point(288, 59);
            this.cbxNovoOdeljenje.Name = "cbxNovoOdeljenje";
            this.cbxNovoOdeljenje.Size = new System.Drawing.Size(83, 24);
            this.cbxNovoOdeljenje.TabIndex = 36;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.BackColor = System.Drawing.Color.Transparent;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelIme.Location = new System.Drawing.Point(105, 25);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(39, 20);
            this.labelIme.TabIndex = 36;
            this.labelIme.Text = "ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.BackColor = System.Drawing.Color.Transparent;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrezime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPrezime.Location = new System.Drawing.Point(105, 63);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(76, 20);
            this.labelPrezime.TabIndex = 38;
            this.labelPrezime.Text = "prezime";
            // 
            // btnPremesti
            // 
            this.btnPremesti.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPremesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremesti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPremesti.Location = new System.Drawing.Point(138, 102);
            this.btnPremesti.Name = "btnPremesti";
            this.btnPremesti.Size = new System.Drawing.Size(142, 29);
            this.btnPremesti.TabIndex = 39;
            this.btnPremesti.Text = "Premesti";
            this.btnPremesti.UseVisualStyleBackColor = false;
            this.btnPremesti.Click += new System.EventHandler(this.btnPremesti_Click);
            // 
            // FormaUceniciOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 463);
            this.Controls.Add(this.btnPremestiUcenika);
            this.Controls.Add(this.dataGridUcenici);
            this.Controls.Add(this.txtImePrezimeRoditelja);
            this.Controls.Add(this.cbxOdeljenje);
            this.Controls.Add(this.panelPremestanje);
            this.Name = "FormaUceniciOdeljenja";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaUceniciOdeljenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUcenici)).EndInit();
            this.panelPremestanje.ResumeLayout(false);
            this.panelPremestanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOdeljenje;
        private System.Windows.Forms.Label txtImePrezimeRoditelja;
        private System.Windows.Forms.DataGridView dataGridUcenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnPremestiUcenika;
        private System.Windows.Forms.Panel panelPremestanje;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.ComboBox cbxNovoOdeljenje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPremesti;
    }
}