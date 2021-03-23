namespace eDnevnik
{
    partial class FormaOdeljenja
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
            this.dataGridOdeljenja = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajOdeljenje = new System.Windows.Forms.Button();
            this.btnIzmeniOdeljenje = new System.Windows.Forms.Button();
            this.btnUkloniOdeljenje = new System.Windows.Forms.Button();
            this.panelOdeljenja = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivOdeljenja = new System.Windows.Forms.TextBox();
            this.txtSmer = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOdeljenja)).BeginInit();
            this.panelOdeljenja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridOdeljenja
            // 
            this.dataGridOdeljenja.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOdeljenja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOdeljenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridOdeljenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOdeljenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridOdeljenja.EnableHeadersVisualStyles = false;
            this.dataGridOdeljenja.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridOdeljenja.Location = new System.Drawing.Point(12, 12);
            this.dataGridOdeljenja.Name = "dataGridOdeljenja";
            this.dataGridOdeljenja.ReadOnly = true;
            this.dataGridOdeljenja.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridOdeljenja.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridOdeljenja.RowTemplate.Height = 24;
            this.dataGridOdeljenja.Size = new System.Drawing.Size(465, 228);
            this.dataGridOdeljenja.TabIndex = 33;
            this.dataGridOdeljenja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOdeljenja_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Odeljenja";
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
            this.Column3.HeaderText = "Smer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnDodajOdeljenje
            // 
            this.btnDodajOdeljenje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOdeljenje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajOdeljenje.Location = new System.Drawing.Point(12, 246);
            this.btnDodajOdeljenje.Name = "btnDodajOdeljenje";
            this.btnDodajOdeljenje.Size = new System.Drawing.Size(114, 34);
            this.btnDodajOdeljenje.TabIndex = 34;
            this.btnDodajOdeljenje.Text = "Dodaj";
            this.btnDodajOdeljenje.UseVisualStyleBackColor = false;
            this.btnDodajOdeljenje.Click += new System.EventHandler(this.btnDodajOdeljenje_Click);
            // 
            // btnIzmeniOdeljenje
            // 
            this.btnIzmeniOdeljenje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniOdeljenje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeniOdeljenje.Location = new System.Drawing.Point(189, 246);
            this.btnIzmeniOdeljenje.Name = "btnIzmeniOdeljenje";
            this.btnIzmeniOdeljenje.Size = new System.Drawing.Size(114, 34);
            this.btnIzmeniOdeljenje.TabIndex = 35;
            this.btnIzmeniOdeljenje.Text = "Izmeni";
            this.btnIzmeniOdeljenje.UseVisualStyleBackColor = false;
            this.btnIzmeniOdeljenje.Click += new System.EventHandler(this.btnIzmeniOdeljenje_Click);
            // 
            // btnUkloniOdeljenje
            // 
            this.btnUkloniOdeljenje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniOdeljenje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniOdeljenje.Location = new System.Drawing.Point(363, 246);
            this.btnUkloniOdeljenje.Name = "btnUkloniOdeljenje";
            this.btnUkloniOdeljenje.Size = new System.Drawing.Size(114, 34);
            this.btnUkloniOdeljenje.TabIndex = 36;
            this.btnUkloniOdeljenje.Text = "Ukloni";
            this.btnUkloniOdeljenje.UseVisualStyleBackColor = false;
            this.btnUkloniOdeljenje.Click += new System.EventHandler(this.btnUkloniOdeljenje_Click);
            // 
            // panelOdeljenja
            // 
            this.panelOdeljenja.Controls.Add(this.btnDodaj);
            this.panelOdeljenja.Controls.Add(this.txtSmer);
            this.panelOdeljenja.Controls.Add(this.txtNazivOdeljenja);
            this.panelOdeljenja.Controls.Add(this.label2);
            this.panelOdeljenja.Controls.Add(this.label1);
            this.panelOdeljenja.Location = new System.Drawing.Point(36, 286);
            this.panelOdeljenja.Name = "panelOdeljenja";
            this.panelOdeljenja.Size = new System.Drawing.Size(415, 161);
            this.panelOdeljenja.TabIndex = 37;
            this.panelOdeljenja.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(76, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Smer:";
            // 
            // txtNazivOdeljenja
            // 
            this.txtNazivOdeljenja.Location = new System.Drawing.Point(188, 21);
            this.txtNazivOdeljenja.Name = "txtNazivOdeljenja";
            this.txtNazivOdeljenja.Size = new System.Drawing.Size(119, 22);
            this.txtNazivOdeljenja.TabIndex = 39;
            // 
            // txtSmer
            // 
            this.txtSmer.Location = new System.Drawing.Point(188, 68);
            this.txtSmer.Name = "txtSmer";
            this.txtSmer.Size = new System.Drawing.Size(119, 22);
            this.txtSmer.TabIndex = 40;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(122, 115);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(174, 34);
            this.btnDodaj.TabIndex = 41;
            this.btnDodaj.Text = "Dodaj odeljenje";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormaOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 463);
            this.Controls.Add(this.panelOdeljenja);
            this.Controls.Add(this.btnUkloniOdeljenje);
            this.Controls.Add(this.btnIzmeniOdeljenje);
            this.Controls.Add(this.btnDodajOdeljenje);
            this.Controls.Add(this.dataGridOdeljenja);
            this.Name = "FormaOdeljenja";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaOdeljenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOdeljenja)).EndInit();
            this.panelOdeljenja.ResumeLayout(false);
            this.panelOdeljenja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOdeljenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnDodajOdeljenje;
        private System.Windows.Forms.Button btnIzmeniOdeljenje;
        private System.Windows.Forms.Button btnUkloniOdeljenje;
        private System.Windows.Forms.Panel panelOdeljenja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSmer;
        private System.Windows.Forms.TextBox txtNazivOdeljenja;
        private System.Windows.Forms.Button btnDodaj;
    }
}