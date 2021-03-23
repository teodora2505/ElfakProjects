namespace _Healthy_Recipes
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.btnSastojci = new System.Windows.Forms.Button();
            this.btnObroci = new System.Windows.Forms.Button();
            this.btnUkusi = new System.Windows.Forms.Button();
            this.btnRecepti = new System.Windows.Forms.Button();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.nazivRecepta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxSastojci = new System.Windows.Forms.ListBox();
            this.listBoxUkusi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxObroci = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFilteri = new System.Windows.Forms.GroupBox();
            this.btnFltriraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxVremePripreme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTezinaPripreme = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOcene = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxOcene = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.gbFilteri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSastojci
            // 
            this.btnSastojci.Location = new System.Drawing.Point(7, 22);
            this.btnSastojci.Name = "btnSastojci";
            this.btnSastojci.Size = new System.Drawing.Size(144, 35);
            this.btnSastojci.TabIndex = 0;
            this.btnSastojci.Text = "Sastojci";
            this.btnSastojci.UseVisualStyleBackColor = true;
            this.btnSastojci.Click += new System.EventHandler(this.btnSastojci_Click);
            // 
            // btnObroci
            // 
            this.btnObroci.Location = new System.Drawing.Point(7, 72);
            this.btnObroci.Name = "btnObroci";
            this.btnObroci.Size = new System.Drawing.Size(144, 35);
            this.btnObroci.TabIndex = 1;
            this.btnObroci.Text = "Obroci";
            this.btnObroci.UseVisualStyleBackColor = true;
            this.btnObroci.Click += new System.EventHandler(this.btnObroci_Click);
            // 
            // btnUkusi
            // 
            this.btnUkusi.Location = new System.Drawing.Point(7, 121);
            this.btnUkusi.Name = "btnUkusi";
            this.btnUkusi.Size = new System.Drawing.Size(144, 35);
            this.btnUkusi.TabIndex = 2;
            this.btnUkusi.Text = "Ukusi";
            this.btnUkusi.UseVisualStyleBackColor = true;
            this.btnUkusi.Click += new System.EventHandler(this.btnUkusi_Click);
            // 
            // btnRecepti
            // 
            this.btnRecepti.Location = new System.Drawing.Point(7, 220);
            this.btnRecepti.Name = "btnRecepti";
            this.btnRecepti.Size = new System.Drawing.Size(144, 45);
            this.btnRecepti.TabIndex = 3;
            this.btnRecepti.Text = "Recepti";
            this.btnRecepti.UseVisualStyleBackColor = true;
            this.btnRecepti.Click += new System.EventHandler(this.btnRecepti_Click);
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepti.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRecepti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivRecepta});
            this.dgvRecepti.Location = new System.Drawing.Point(228, 14);
            this.dgvRecepti.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowTemplate.Height = 25;
            this.dgvRecepti.Size = new System.Drawing.Size(325, 456);
            this.dgvRecepti.TabIndex = 17;
            this.dgvRecepti.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecepti_CellMouseDoubleClick);
            // 
            // nazivRecepta
            // 
            this.nazivRecepta.HeaderText = "Recept";
            this.nazivRecepta.Name = "nazivRecepta";
            // 
            // listBoxSastojci
            // 
            this.listBoxSastojci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSastojci.FormattingEnabled = true;
            this.listBoxSastojci.ItemHeight = 15;
            this.listBoxSastojci.Location = new System.Drawing.Point(28, 35);
            this.listBoxSastojci.Name = "listBoxSastojci";
            this.listBoxSastojci.ScrollAlwaysVisible = true;
            this.listBoxSastojci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSastojci.Size = new System.Drawing.Size(135, 79);
            this.listBoxSastojci.TabIndex = 18;
            // 
            // listBoxUkusi
            // 
            this.listBoxUkusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUkusi.FormattingEnabled = true;
            this.listBoxUkusi.ItemHeight = 15;
            this.listBoxUkusi.Location = new System.Drawing.Point(28, 144);
            this.listBoxUkusi.Name = "listBoxUkusi";
            this.listBoxUkusi.ScrollAlwaysVisible = true;
            this.listBoxUkusi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxUkusi.Size = new System.Drawing.Size(135, 64);
            this.listBoxUkusi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sastojci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ukusi:";
            // 
            // listBoxObroci
            // 
            this.listBoxObroci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxObroci.FormattingEnabled = true;
            this.listBoxObroci.ItemHeight = 15;
            this.listBoxObroci.Location = new System.Drawing.Point(28, 239);
            this.listBoxObroci.Name = "listBoxObroci";
            this.listBoxObroci.ScrollAlwaysVisible = true;
            this.listBoxObroci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxObroci.Size = new System.Drawing.Size(135, 64);
            this.listBoxObroci.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Obroci:";
            // 
            // gbFilteri
            // 
            this.gbFilteri.BackColor = System.Drawing.Color.Transparent;
            this.gbFilteri.Controls.Add(this.label7);
            this.gbFilteri.Controls.Add(this.cbxOcene);
            this.gbFilteri.Controls.Add(this.btnFltriraj);
            this.gbFilteri.Controls.Add(this.label5);
            this.gbFilteri.Controls.Add(this.cbxVremePripreme);
            this.gbFilteri.Controls.Add(this.label4);
            this.gbFilteri.Controls.Add(this.cbxTezinaPripreme);
            this.gbFilteri.Controls.Add(this.label1);
            this.gbFilteri.Controls.Add(this.label3);
            this.gbFilteri.Controls.Add(this.listBoxSastojci);
            this.gbFilteri.Controls.Add(this.listBoxObroci);
            this.gbFilteri.Controls.Add(this.listBoxUkusi);
            this.gbFilteri.Controls.Add(this.label2);
            this.gbFilteri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbFilteri.Location = new System.Drawing.Point(14, 12);
            this.gbFilteri.Name = "gbFilteri";
            this.gbFilteri.Size = new System.Drawing.Size(193, 508);
            this.gbFilteri.TabIndex = 24;
            this.gbFilteri.TabStop = false;
            this.gbFilteri.Text = "Filteri";
            // 
            // btnFltriraj
            // 
            this.btnFltriraj.Location = new System.Drawing.Point(25, 462);
            this.btnFltriraj.Name = "btnFltriraj";
            this.btnFltriraj.Size = new System.Drawing.Size(138, 35);
            this.btnFltriraj.TabIndex = 28;
            this.btnFltriraj.Text = "Primeni filtere";
            this.btnFltriraj.UseVisualStyleBackColor = true;
            this.btnFltriraj.Click += new System.EventHandler(this.btnFltriraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vreme pripreme:";
            // 
            // cbxVremePripreme
            // 
            this.cbxVremePripreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVremePripreme.FormattingEnabled = true;
            this.cbxVremePripreme.Items.AddRange(new object[] {
            "0,5 sat",
            "1 sat",
            "2 sata",
            "3 sata",
            ">3 sata"});
            this.cbxVremePripreme.Location = new System.Drawing.Point(27, 379);
            this.cbxVremePripreme.Name = "cbxVremePripreme";
            this.cbxVremePripreme.Size = new System.Drawing.Size(136, 23);
            this.cbxVremePripreme.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Težina pripreme:";
            // 
            // cbxTezinaPripreme
            // 
            this.cbxTezinaPripreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTezinaPripreme.FormattingEnabled = true;
            this.cbxTezinaPripreme.Items.AddRange(new object[] {
            "lako",
            "srednje",
            "teško"});
            this.cbxTezinaPripreme.Location = new System.Drawing.Point(28, 330);
            this.cbxTezinaPripreme.Name = "cbxTezinaPripreme";
            this.cbxTezinaPripreme.Size = new System.Drawing.Size(136, 23);
            this.cbxTezinaPripreme.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOcene);
            this.groupBox1.Controls.Add(this.btnSastojci);
            this.groupBox1.Controls.Add(this.btnObroci);
            this.groupBox1.Controls.Add(this.btnUkusi);
            this.groupBox1.Controls.Add(this.btnRecepti);
            this.groupBox1.Location = new System.Drawing.Point(582, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 279);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forme za upravljanje";
            // 
            // btnOcene
            // 
            this.btnOcene.Location = new System.Drawing.Point(6, 168);
            this.btnOcene.Name = "btnOcene";
            this.btnOcene.Size = new System.Drawing.Size(144, 35);
            this.btnOcene.TabIndex = 4;
            this.btnOcene.Text = "Ocene";
            this.btnOcene.UseVisualStyleBackColor = true;
            this.btnOcene.Click += new System.EventHandler(this.btnOcene_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 45);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kliknite 2 puta na željeni recept za detalje o receptu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(562, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 194);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ocena recepta:";
            // 
            // cbxOcene
            // 
            this.cbxOcene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOcene.FormattingEnabled = true;
            this.cbxOcene.Location = new System.Drawing.Point(28, 427);
            this.cbxOcene.Name = "cbxOcene";
            this.cbxOcene.Size = new System.Drawing.Size(135, 23);
            this.cbxOcene.TabIndex = 29;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFilteri);
            this.Controls.Add(this.dgvRecepti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForma";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.gbFilteri.ResumeLayout(false);
            this.gbFilteri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSastojci;
        private System.Windows.Forms.Button btnObroci;
        private System.Windows.Forms.Button btnUkusi;
        private System.Windows.Forms.Button btnRecepti;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.ListBox listBoxSastojci;
        private System.Windows.Forms.ListBox listBoxUkusi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxObroci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFilteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxVremePripreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTezinaPripreme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFltriraj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRecepta;
        private System.Windows.Forms.Button btnOcene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxOcene;
    }
}

