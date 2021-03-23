namespace _Healthy_Recipes
{
    partial class Recepti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recepti));
            this.panelDodajSastojak = new System.Windows.Forms.Panel();
            this.cbxDodajVreme = new System.Windows.Forms.ComboBox();
            this.cbxDodajTezinu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDodajRecept = new System.Windows.Forms.TextBox();
            this.btnDodajRecept = new System.Windows.Forms.Button();
            this.btnObrisiRecept = new System.Windows.Forms.Button();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.nazivRecepta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaPripreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremePripreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxIzmeniVreme = new System.Windows.Forms.ComboBox();
            this.cbxIzmeniTezinu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIzmeniRecept = new System.Windows.Forms.TextBox();
            this.btnIzmeniRecept = new System.Windows.Forms.Button();
            this.btnOpisRecepta = new System.Windows.Forms.Button();
            this.btnSastojci = new System.Windows.Forms.Button();
            this.btnUkus = new System.Windows.Forms.Button();
            this.btnObrok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOcena = new System.Windows.Forms.Button();
            this.panelDodajSastojak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDodajSastojak
            // 
            this.panelDodajSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelDodajSastojak.Controls.Add(this.cbxDodajVreme);
            this.panelDodajSastojak.Controls.Add(this.cbxDodajTezinu);
            this.panelDodajSastojak.Controls.Add(this.label5);
            this.panelDodajSastojak.Controls.Add(this.label4);
            this.panelDodajSastojak.Controls.Add(this.label3);
            this.panelDodajSastojak.Controls.Add(this.label2);
            this.panelDodajSastojak.Controls.Add(this.txtDodajRecept);
            this.panelDodajSastojak.Controls.Add(this.btnDodajRecept);
            this.panelDodajSastojak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDodajSastojak.Location = new System.Drawing.Point(470, 41);
            this.panelDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.panelDodajSastojak.Name = "panelDodajSastojak";
            this.panelDodajSastojak.Size = new System.Drawing.Size(474, 109);
            this.panelDodajSastojak.TabIndex = 24;
            this.panelDodajSastojak.Tag = "";
            // 
            // cbxDodajVreme
            // 
            this.cbxDodajVreme.FormattingEnabled = true;
            this.cbxDodajVreme.Items.AddRange(new object[] {
            "0,5 sat",
            "1 sat",
            "2 sata",
            "3 sata",
            ">3 sata"});
            this.cbxDodajVreme.Location = new System.Drawing.Point(366, 58);
            this.cbxDodajVreme.Name = "cbxDodajVreme";
            this.cbxDodajVreme.Size = new System.Drawing.Size(104, 23);
            this.cbxDodajVreme.TabIndex = 9;
            // 
            // cbxDodajTezinu
            // 
            this.cbxDodajTezinu.FormattingEnabled = true;
            this.cbxDodajTezinu.Items.AddRange(new object[] {
            "lako",
            "srednje",
            "teško"});
            this.cbxDodajTezinu.Location = new System.Drawing.Point(125, 58);
            this.cbxDodajTezinu.Name = "cbxDodajTezinu";
            this.cbxDodajTezinu.Size = new System.Drawing.Size(115, 23);
            this.cbxDodajTezinu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vreme pripreme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Težina pripreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv recepta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(118, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Popunite sva neophodna polja";
            this.label2.Visible = false;
            // 
            // txtDodajRecept
            // 
            this.txtDodajRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajRecept.Location = new System.Drawing.Point(109, 18);
            this.txtDodajRecept.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodajRecept.Name = "txtDodajRecept";
            this.txtDodajRecept.Size = new System.Drawing.Size(210, 22);
            this.txtDodajRecept.TabIndex = 1;
            // 
            // btnDodajRecept
            // 
            this.btnDodajRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRecept.Location = new System.Drawing.Point(354, 12);
            this.btnDodajRecept.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajRecept.Name = "btnDodajRecept";
            this.btnDodajRecept.Size = new System.Drawing.Size(116, 32);
            this.btnDodajRecept.TabIndex = 0;
            this.btnDodajRecept.Text = "Dodaj recept";
            this.btnDodajRecept.UseVisualStyleBackColor = true;
            this.btnDodajRecept.Click += new System.EventHandler(this.btnDodajRecept_Click);
            // 
            // btnObrisiRecept
            // 
            this.btnObrisiRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRecept.Location = new System.Drawing.Point(17, 383);
            this.btnObrisiRecept.Name = "btnObrisiRecept";
            this.btnObrisiRecept.Size = new System.Drawing.Size(128, 29);
            this.btnObrisiRecept.TabIndex = 23;
            this.btnObrisiRecept.Text = "Obriši recept";
            this.btnObrisiRecept.UseVisualStyleBackColor = true;
            this.btnObrisiRecept.Click += new System.EventHandler(this.btnObrisiRecept_Click);
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepti.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRecepti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivRecepta,
            this.tezinaPripreme,
            this.vremePripreme});
            this.dgvRecepti.Location = new System.Drawing.Point(17, 41);
            this.dgvRecepti.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowTemplate.Height = 25;
            this.dgvRecepti.Size = new System.Drawing.Size(444, 332);
            this.dgvRecepti.TabIndex = 22;
            this.dgvRecepti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecepti_CellClick);
            // 
            // nazivRecepta
            // 
            this.nazivRecepta.HeaderText = "Recept";
            this.nazivRecepta.Name = "nazivRecepta";
            // 
            // tezinaPripreme
            // 
            this.tezinaPripreme.HeaderText = "Težina pripreme";
            this.tezinaPripreme.Name = "tezinaPripreme";
            // 
            // vremePripreme
            // 
            this.vremePripreme.HeaderText = "Vreme pripreme";
            this.vremePripreme.Name = "vremePripreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pregled recepata:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(828, 381);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(5);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(116, 29);
            this.btnZatvori.TabIndex = 20;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbxIzmeniVreme);
            this.panel1.Controls.Add(this.cbxIzmeniTezinu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtIzmeniRecept);
            this.panel1.Controls.Add(this.btnIzmeniRecept);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(470, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 95);
            this.panel1.TabIndex = 26;
            this.panel1.Tag = "";
            // 
            // cbxIzmeniVreme
            // 
            this.cbxIzmeniVreme.FormattingEnabled = true;
            this.cbxIzmeniVreme.Items.AddRange(new object[] {
            "0,5 sat",
            "1 sat",
            "2 sata",
            "3 sata",
            ">3 sata"});
            this.cbxIzmeniVreme.Location = new System.Drawing.Point(366, 58);
            this.cbxIzmeniVreme.Name = "cbxIzmeniVreme";
            this.cbxIzmeniVreme.Size = new System.Drawing.Size(104, 23);
            this.cbxIzmeniVreme.TabIndex = 10;
            // 
            // cbxIzmeniTezinu
            // 
            this.cbxIzmeniTezinu.FormattingEnabled = true;
            this.cbxIzmeniTezinu.Items.AddRange(new object[] {
            "lako",
            "srednje",
            "teško"});
            this.cbxIzmeniTezinu.Location = new System.Drawing.Point(125, 58);
            this.cbxIzmeniTezinu.Name = "cbxIzmeniTezinu";
            this.cbxIzmeniTezinu.Size = new System.Drawing.Size(115, 23);
            this.cbxIzmeniTezinu.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vreme pripreme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Težina pripreme:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Naziv recepta:";
            // 
            // txtIzmeniRecept
            // 
            this.txtIzmeniRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmeniRecept.Location = new System.Drawing.Point(109, 18);
            this.txtIzmeniRecept.Margin = new System.Windows.Forms.Padding(4);
            this.txtIzmeniRecept.Name = "txtIzmeniRecept";
            this.txtIzmeniRecept.Size = new System.Drawing.Size(210, 22);
            this.txtIzmeniRecept.TabIndex = 1;
            // 
            // btnIzmeniRecept
            // 
            this.btnIzmeniRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniRecept.Location = new System.Drawing.Point(354, 12);
            this.btnIzmeniRecept.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniRecept.Name = "btnIzmeniRecept";
            this.btnIzmeniRecept.Size = new System.Drawing.Size(116, 32);
            this.btnIzmeniRecept.TabIndex = 0;
            this.btnIzmeniRecept.Text = "Izmeni recept";
            this.btnIzmeniRecept.UseVisualStyleBackColor = true;
            this.btnIzmeniRecept.Click += new System.EventHandler(this.btnIzmeniRecept_Click);
            // 
            // btnOpisRecepta
            // 
            this.btnOpisRecepta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpisRecepta.Location = new System.Drawing.Point(345, 382);
            this.btnOpisRecepta.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpisRecepta.Name = "btnOpisRecepta";
            this.btnOpisRecepta.Size = new System.Drawing.Size(116, 29);
            this.btnOpisRecepta.TabIndex = 27;
            this.btnOpisRecepta.Text = "Opis recepta";
            this.btnOpisRecepta.UseVisualStyleBackColor = true;
            this.btnOpisRecepta.Click += new System.EventHandler(this.btnOpisRecepta_Click);
            // 
            // btnSastojci
            // 
            this.btnSastojci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSastojci.Location = new System.Drawing.Point(470, 270);
            this.btnSastojci.Margin = new System.Windows.Forms.Padding(4);
            this.btnSastojci.Name = "btnSastojci";
            this.btnSastojci.Size = new System.Drawing.Size(110, 29);
            this.btnSastojci.TabIndex = 28;
            this.btnSastojci.Text = "Sastojci";
            this.btnSastojci.UseVisualStyleBackColor = true;
            this.btnSastojci.Click += new System.EventHandler(this.btnSastojci_Click);
            // 
            // btnUkus
            // 
            this.btnUkus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkus.Location = new System.Drawing.Point(716, 270);
            this.btnUkus.Margin = new System.Windows.Forms.Padding(4);
            this.btnUkus.Name = "btnUkus";
            this.btnUkus.Size = new System.Drawing.Size(110, 29);
            this.btnUkus.TabIndex = 29;
            this.btnUkus.Text = "Ukus";
            this.btnUkus.UseVisualStyleBackColor = true;
            this.btnUkus.Click += new System.EventHandler(this.btnUkus_Click);
            // 
            // btnObrok
            // 
            this.btnObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrok.Location = new System.Drawing.Point(591, 270);
            this.btnObrok.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrok.Name = "btnObrok";
            this.btnObrok.Size = new System.Drawing.Size(110, 29);
            this.btnObrok.TabIndex = 30;
            this.btnObrok.Text = "Obrok";
            this.btnObrok.UseVisualStyleBackColor = true;
            this.btnObrok.Click += new System.EventHandler(this.btnObrok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(513, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 106);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnOcena
            // 
            this.btnOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcena.Location = new System.Drawing.Point(834, 270);
            this.btnOcena.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcena.Name = "btnOcena";
            this.btnOcena.Size = new System.Drawing.Size(110, 29);
            this.btnOcena.TabIndex = 32;
            this.btnOcena.Text = "Ocena";
            this.btnOcena.UseVisualStyleBackColor = true;
            this.btnOcena.Click += new System.EventHandler(this.btnOcena_Click);
            // 
            // Recepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 424);
            this.Controls.Add(this.btnOcena);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnObrok);
            this.Controls.Add(this.btnUkus);
            this.Controls.Add(this.btnSastojci);
            this.Controls.Add(this.btnOpisRecepta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDodajSastojak);
            this.Controls.Add(this.btnObrisiRecept);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recepti";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.Recepti_Load);
            this.panelDodajSastojak.ResumeLayout(false);
            this.panelDodajSastojak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDodajSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDodajRecept;
        private System.Windows.Forms.Button btnDodajRecept;
        private System.Windows.Forms.Button btnObrisiRecept;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRecepta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaPripreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremePripreme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIzmeniRecept;
        private System.Windows.Forms.Button btnIzmeniRecept;
        private System.Windows.Forms.Button btnOpisRecepta;
        private System.Windows.Forms.Button btnSastojci;
        private System.Windows.Forms.Button btnUkus;
        private System.Windows.Forms.Button btnObrok;
        private System.Windows.Forms.ComboBox cbxDodajVreme;
        private System.Windows.Forms.ComboBox cbxDodajTezinu;
        private System.Windows.Forms.ComboBox cbxIzmeniVreme;
        private System.Windows.Forms.ComboBox cbxIzmeniTezinu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOcena;
    }
}