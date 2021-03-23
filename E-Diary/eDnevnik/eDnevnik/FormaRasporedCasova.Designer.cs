namespace eDnevnik
{
    partial class FormaRasporedCasova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxRaspored = new System.Windows.Forms.GroupBox();
            this.labelRasporedSmer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelRasporedOdeljenje = new System.Windows.Forms.Label();
            this.dataGridRaspored = new System.Windows.Forms.DataGridView();
            this.btnDodajCasOpcija = new System.Windows.Forms.Button();
            this.btnIzmeniCasOpcija = new System.Windows.Forms.Button();
            this.btnUkloniCasOpcija = new System.Windows.Forms.Button();
            this.groupBoxDodavanjeCasa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPredmeti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDani = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBrojCasa = new System.Windows.Forms.ComboBox();
            this.btnDodajCas = new System.Windows.Forms.Button();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaspored)).BeginInit();
            this.groupBoxDodavanjeCasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRaspored
            // 
            this.groupBoxRaspored.Controls.Add(this.btnUkloniCasOpcija);
            this.groupBoxRaspored.Controls.Add(this.labelRasporedSmer);
            this.groupBoxRaspored.Controls.Add(this.btnIzmeniCasOpcija);
            this.groupBoxRaspored.Controls.Add(this.label8);
            this.groupBoxRaspored.Controls.Add(this.btnDodajCasOpcija);
            this.groupBoxRaspored.Controls.Add(this.label9);
            this.groupBoxRaspored.Controls.Add(this.labelRasporedOdeljenje);
            this.groupBoxRaspored.Controls.Add(this.dataGridRaspored);
            this.groupBoxRaspored.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRaspored.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxRaspored.Location = new System.Drawing.Point(20, 12);
            this.groupBoxRaspored.Name = "groupBoxRaspored";
            this.groupBoxRaspored.Size = new System.Drawing.Size(1057, 451);
            this.groupBoxRaspored.TabIndex = 35;
            this.groupBoxRaspored.TabStop = false;
            this.groupBoxRaspored.Text = "Raspored časova";
            // 
            // labelRasporedSmer
            // 
            this.labelRasporedSmer.AutoSize = true;
            this.labelRasporedSmer.BackColor = System.Drawing.Color.Transparent;
            this.labelRasporedSmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRasporedSmer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRasporedSmer.Location = new System.Drawing.Point(339, 36);
            this.labelRasporedSmer.Name = "labelRasporedSmer";
            this.labelRasporedSmer.Size = new System.Drawing.Size(76, 20);
            this.labelRasporedSmer.TabIndex = 32;
            this.labelRasporedSmer.Text = "prezime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(274, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Smer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(63, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Odeljenje:";
            // 
            // labelRasporedOdeljenje
            // 
            this.labelRasporedOdeljenje.AutoSize = true;
            this.labelRasporedOdeljenje.BackColor = System.Drawing.Color.Transparent;
            this.labelRasporedOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRasporedOdeljenje.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRasporedOdeljenje.Location = new System.Drawing.Point(188, 36);
            this.labelRasporedOdeljenje.Name = "labelRasporedOdeljenje";
            this.labelRasporedOdeljenje.Size = new System.Drawing.Size(39, 20);
            this.labelRasporedOdeljenje.TabIndex = 10;
            this.labelRasporedOdeljenje.Text = "ime";
            // 
            // dataGridRaspored
            // 
            this.dataGridRaspored.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRaspored.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRaspored.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRaspored.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridRaspored.EnableHeadersVisualStyles = false;
            this.dataGridRaspored.GridColor = System.Drawing.Color.MediumBlue;
            this.dataGridRaspored.Location = new System.Drawing.Point(0, 76);
            this.dataGridRaspored.Name = "dataGridRaspored";
            this.dataGridRaspored.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRaspored.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGridRaspored.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridRaspored.RowTemplate.Height = 24;
            this.dataGridRaspored.Size = new System.Drawing.Size(1045, 306);
            this.dataGridRaspored.TabIndex = 30;
            // 
            // btnDodajCasOpcija
            // 
            this.btnDodajCasOpcija.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajCasOpcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajCasOpcija.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajCasOpcija.Location = new System.Drawing.Point(52, 404);
            this.btnDodajCasOpcija.Name = "btnDodajCasOpcija";
            this.btnDodajCasOpcija.Size = new System.Drawing.Size(175, 41);
            this.btnDodajCasOpcija.TabIndex = 36;
            this.btnDodajCasOpcija.Text = "Dodaj čas";
            this.btnDodajCasOpcija.UseVisualStyleBackColor = false;
            this.btnDodajCasOpcija.Click += new System.EventHandler(this.btnDodajCasOpcija_Click);
            // 
            // btnIzmeniCasOpcija
            // 
            this.btnIzmeniCasOpcija.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniCasOpcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniCasOpcija.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIzmeniCasOpcija.Location = new System.Drawing.Point(269, 404);
            this.btnIzmeniCasOpcija.Name = "btnIzmeniCasOpcija";
            this.btnIzmeniCasOpcija.Size = new System.Drawing.Size(175, 41);
            this.btnIzmeniCasOpcija.TabIndex = 37;
            this.btnIzmeniCasOpcija.Text = "Izmeni čas";
            this.btnIzmeniCasOpcija.UseVisualStyleBackColor = false;
            this.btnIzmeniCasOpcija.Click += new System.EventHandler(this.btnIzmeniCasOpcija_Click);
            // 
            // btnUkloniCasOpcija
            // 
            this.btnUkloniCasOpcija.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniCasOpcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniCasOpcija.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUkloniCasOpcija.Location = new System.Drawing.Point(480, 404);
            this.btnUkloniCasOpcija.Name = "btnUkloniCasOpcija";
            this.btnUkloniCasOpcija.Size = new System.Drawing.Size(175, 41);
            this.btnUkloniCasOpcija.TabIndex = 38;
            this.btnUkloniCasOpcija.Text = "Ukloni čas";
            this.btnUkloniCasOpcija.UseVisualStyleBackColor = false;
            this.btnUkloniCasOpcija.Click += new System.EventHandler(this.btnUkloniCasOpcija_Click);
            // 
            // groupBoxDodavanjeCasa
            // 
            this.groupBoxDodavanjeCasa.Controls.Add(this.btnDodajCas);
            this.groupBoxDodavanjeCasa.Controls.Add(this.cbxBrojCasa);
            this.groupBoxDodavanjeCasa.Controls.Add(this.label3);
            this.groupBoxDodavanjeCasa.Controls.Add(this.cbxDani);
            this.groupBoxDodavanjeCasa.Controls.Add(this.label2);
            this.groupBoxDodavanjeCasa.Controls.Add(this.cbxPredmeti);
            this.groupBoxDodavanjeCasa.Controls.Add(this.label1);
            this.groupBoxDodavanjeCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDodavanjeCasa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxDodavanjeCasa.Location = new System.Drawing.Point(1110, 29);
            this.groupBoxDodavanjeCasa.Name = "groupBoxDodavanjeCasa";
            this.groupBoxDodavanjeCasa.Size = new System.Drawing.Size(287, 434);
            this.groupBoxDodavanjeCasa.TabIndex = 36;
            this.groupBoxDodavanjeCasa.TabStop = false;
            this.groupBoxDodavanjeCasa.Text = "Dodavanje časa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odeljenski predmeti:";
            // 
            // cbxPredmeti
            // 
            this.cbxPredmeti.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxPredmeti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxPredmeti.FormattingEnabled = true;
            this.cbxPredmeti.Location = new System.Drawing.Point(31, 91);
            this.cbxPredmeti.Name = "cbxPredmeti";
            this.cbxPredmeti.Size = new System.Drawing.Size(218, 24);
            this.cbxPredmeti.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(76, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Izaberite dan:";
            // 
            // cbxDani
            // 
            this.cbxDani.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxDani.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxDani.FormattingEnabled = true;
            this.cbxDani.Items.AddRange(new object[] {
            "ponedeljak",
            "utorak",
            "sreda",
            "cetvrtak",
            "petak"});
            this.cbxDani.Location = new System.Drawing.Point(30, 188);
            this.cbxDani.Name = "cbxDani";
            this.cbxDani.Size = new System.Drawing.Size(218, 24);
            this.cbxDani.TabIndex = 14;
            this.cbxDani.SelectedIndexChanged += new System.EventHandler(this.cbxDani_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(58, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Izaberite broj časa:";
            // 
            // cbxBrojCasa
            // 
            this.cbxBrojCasa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxBrojCasa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxBrojCasa.FormattingEnabled = true;
            this.cbxBrojCasa.Location = new System.Drawing.Point(31, 298);
            this.cbxBrojCasa.Name = "cbxBrojCasa";
            this.cbxBrojCasa.Size = new System.Drawing.Size(218, 24);
            this.cbxBrojCasa.TabIndex = 16;
            // 
            // btnDodajCas
            // 
            this.btnDodajCas.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajCas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodajCas.Location = new System.Drawing.Point(62, 369);
            this.btnDodajCas.Name = "btnDodajCas";
            this.btnDodajCas.Size = new System.Drawing.Size(175, 41);
            this.btnDodajCas.TabIndex = 39;
            this.btnDodajCas.Text = "Dodaj čas";
            this.btnDodajCas.UseVisualStyleBackColor = false;
            this.btnDodajCas.Click += new System.EventHandler(this.btnDodajCas_Click);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ponedeljak";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Utorak";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Sreda";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Četvrtak";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Petak";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 150;
            // 
            // FormaRasporedCasova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 482);
            this.Controls.Add(this.groupBoxDodavanjeCasa);
            this.Controls.Add(this.groupBoxRaspored);
            this.Name = "FormaRasporedCasova";
            this.Text = "e-Dnevnik";
            this.Load += new System.EventHandler(this.FormaRasporedCasova_Load);
            this.groupBoxRaspored.ResumeLayout(false);
            this.groupBoxRaspored.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRaspored)).EndInit();
            this.groupBoxDodavanjeCasa.ResumeLayout(false);
            this.groupBoxDodavanjeCasa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRaspored;
        private System.Windows.Forms.Label labelRasporedSmer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelRasporedOdeljenje;
        private System.Windows.Forms.DataGridView dataGridRaspored;
        private System.Windows.Forms.Button btnUkloniCasOpcija;
        private System.Windows.Forms.Button btnIzmeniCasOpcija;
        private System.Windows.Forms.Button btnDodajCasOpcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.GroupBox groupBoxDodavanjeCasa;
        private System.Windows.Forms.Button btnDodajCas;
        private System.Windows.Forms.ComboBox cbxBrojCasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPredmeti;
        private System.Windows.Forms.Label label1;
    }
}