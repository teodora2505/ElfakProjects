namespace _Healthy_Recipes
{
    partial class Sastojci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sastojci));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.nazivSastojka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAlternativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDodajSastojak = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDodajSastojak = new System.Windows.Forms.TextBox();
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.panelIzmeniSastojak = new System.Windows.Forms.Panel();
            this.txtIzmeniSastojak = new System.Windows.Forms.TextBox();
            this.btnIzmeniSastojak = new System.Windows.Forms.Button();
            this.btnObrisiSastojak = new System.Windows.Forms.Button();
            this.panelAlternativaSastojka = new System.Windows.Forms.Panel();
            this.btnIzmeniAlternativu = new System.Windows.Forms.Button();
            this.txtIzmeniAlternativu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDodajAlternativu = new System.Windows.Forms.TextBox();
            this.btnDodajAlternativu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObrisiAlternativu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            this.panelDodajSastojak.SuspendLayout();
            this.panelIzmeniSastojak.SuspendLayout();
            this.panelAlternativaSastojka.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(710, 410);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(108, 33);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled sastojaka:";
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastojci.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSastojci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivSastojka,
            this.zAlternativa});
            this.dgvSastojci.Location = new System.Drawing.Point(31, 54);
            this.dgvSastojci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSastojci.Name = "dgvSastojci";
            this.dgvSastojci.RowTemplate.Height = 25;
            this.dgvSastojci.Size = new System.Drawing.Size(372, 350);
            this.dgvSastojci.TabIndex = 2;
            this.dgvSastojci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSastojci_CellClick);
            // 
            // nazivSastojka
            // 
            this.nazivSastojka.HeaderText = "Naziv sastojka";
            this.nazivSastojka.Name = "nazivSastojka";
            // 
            // zAlternativa
            // 
            this.zAlternativa.HeaderText = "Zdrava alternativa";
            this.zAlternativa.Name = "zAlternativa";
            // 
            // panelDodajSastojak
            // 
            this.panelDodajSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelDodajSastojak.Controls.Add(this.label2);
            this.panelDodajSastojak.Controls.Add(this.txtDodajSastojak);
            this.panelDodajSastojak.Controls.Add(this.btnDodajSastojak);
            this.panelDodajSastojak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDodajSastojak.Location = new System.Drawing.Point(441, 54);
            this.panelDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.panelDodajSastojak.Name = "panelDodajSastojak";
            this.panelDodajSastojak.Size = new System.Drawing.Size(377, 68);
            this.panelDodajSastojak.TabIndex = 3;
            this.panelDodajSastojak.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite naziv novog sastojka";
            this.label2.Visible = false;
            // 
            // txtDodajSastojak
            // 
            this.txtDodajSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajSastojak.Location = new System.Drawing.Point(20, 18);
            this.txtDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodajSastojak.Name = "txtDodajSastojak";
            this.txtDodajSastojak.Size = new System.Drawing.Size(214, 22);
            this.txtDodajSastojak.TabIndex = 1;
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSastojak.Location = new System.Drawing.Point(243, 12);
            this.btnDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(124, 32);
            this.btnDodajSastojak.TabIndex = 0;
            this.btnDodajSastojak.Text = "Dodaj sastojak";
            this.btnDodajSastojak.UseVisualStyleBackColor = true;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // panelIzmeniSastojak
            // 
            this.panelIzmeniSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelIzmeniSastojak.Controls.Add(this.txtIzmeniSastojak);
            this.panelIzmeniSastojak.Controls.Add(this.btnIzmeniSastojak);
            this.panelIzmeniSastojak.Location = new System.Drawing.Point(441, 129);
            this.panelIzmeniSastojak.Name = "panelIzmeniSastojak";
            this.panelIzmeniSastojak.Size = new System.Drawing.Size(377, 64);
            this.panelIzmeniSastojak.TabIndex = 4;
            // 
            // txtIzmeniSastojak
            // 
            this.txtIzmeniSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmeniSastojak.Location = new System.Drawing.Point(20, 22);
            this.txtIzmeniSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.txtIzmeniSastojak.Name = "txtIzmeniSastojak";
            this.txtIzmeniSastojak.Size = new System.Drawing.Size(214, 22);
            this.txtIzmeniSastojak.TabIndex = 2;
            // 
            // btnIzmeniSastojak
            // 
            this.btnIzmeniSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniSastojak.Location = new System.Drawing.Point(243, 16);
            this.btnIzmeniSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniSastojak.Name = "btnIzmeniSastojak";
            this.btnIzmeniSastojak.Size = new System.Drawing.Size(124, 32);
            this.btnIzmeniSastojak.TabIndex = 1;
            this.btnIzmeniSastojak.Text = "Izmeni sastojak";
            this.btnIzmeniSastojak.UseVisualStyleBackColor = true;
            this.btnIzmeniSastojak.Click += new System.EventHandler(this.btnIzmeniSastojak_Click);
            // 
            // btnObrisiSastojak
            // 
            this.btnObrisiSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSastojak.Location = new System.Drawing.Point(31, 411);
            this.btnObrisiSastojak.Name = "btnObrisiSastojak";
            this.btnObrisiSastojak.Size = new System.Drawing.Size(110, 32);
            this.btnObrisiSastojak.TabIndex = 5;
            this.btnObrisiSastojak.Text = "Obriši sastojak";
            this.btnObrisiSastojak.UseVisualStyleBackColor = true;
            this.btnObrisiSastojak.Click += new System.EventHandler(this.btnObrisiSastojak_Click);
            // 
            // panelAlternativaSastojka
            // 
            this.panelAlternativaSastojka.BackColor = System.Drawing.Color.Transparent;
            this.panelAlternativaSastojka.Controls.Add(this.btnIzmeniAlternativu);
            this.panelAlternativaSastojka.Controls.Add(this.txtIzmeniAlternativu);
            this.panelAlternativaSastojka.Controls.Add(this.label4);
            this.panelAlternativaSastojka.Controls.Add(this.txtDodajAlternativu);
            this.panelAlternativaSastojka.Controls.Add(this.btnDodajAlternativu);
            this.panelAlternativaSastojka.Controls.Add(this.label3);
            this.panelAlternativaSastojka.Location = new System.Drawing.Point(442, 199);
            this.panelAlternativaSastojka.Name = "panelAlternativaSastojka";
            this.panelAlternativaSastojka.Size = new System.Drawing.Size(376, 161);
            this.panelAlternativaSastojka.TabIndex = 6;
            this.panelAlternativaSastojka.Visible = false;
            // 
            // btnIzmeniAlternativu
            // 
            this.btnIzmeniAlternativu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniAlternativu.Location = new System.Drawing.Point(242, 101);
            this.btnIzmeniAlternativu.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniAlternativu.Name = "btnIzmeniAlternativu";
            this.btnIzmeniAlternativu.Size = new System.Drawing.Size(124, 32);
            this.btnIzmeniAlternativu.TabIndex = 7;
            this.btnIzmeniAlternativu.Text = "Izmeni alternativu";
            this.btnIzmeniAlternativu.UseVisualStyleBackColor = true;
            this.btnIzmeniAlternativu.Click += new System.EventHandler(this.btnIzmeniAlternativu_Click);
            // 
            // txtIzmeniAlternativu
            // 
            this.txtIzmeniAlternativu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmeniAlternativu.Location = new System.Drawing.Point(20, 107);
            this.txtIzmeniAlternativu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIzmeniAlternativu.Name = "txtIzmeniAlternativu";
            this.txtIzmeniAlternativu.Size = new System.Drawing.Size(214, 22);
            this.txtIzmeniAlternativu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(43, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unesite naziv zdrave alternative";
            this.label4.Visible = false;
            // 
            // txtDodajAlternativu
            // 
            this.txtDodajAlternativu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajAlternativu.Location = new System.Drawing.Point(20, 43);
            this.txtDodajAlternativu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodajAlternativu.Name = "txtDodajAlternativu";
            this.txtDodajAlternativu.Size = new System.Drawing.Size(214, 22);
            this.txtDodajAlternativu.TabIndex = 4;
            // 
            // btnDodajAlternativu
            // 
            this.btnDodajAlternativu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAlternativu.Location = new System.Drawing.Point(242, 37);
            this.btnDodajAlternativu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajAlternativu.Name = "btnDodajAlternativu";
            this.btnDodajAlternativu.Size = new System.Drawing.Size(124, 32);
            this.btnDodajAlternativu.TabIndex = 3;
            this.btnDodajAlternativu.Text = "Dodaj alternativu";
            this.btnDodajAlternativu.UseVisualStyleBackColor = true;
            this.btnDodajAlternativu.Click += new System.EventHandler(this.btnDodajAlternativu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zdrava alternativa";
            // 
            // btnObrisiAlternativu
            // 
            this.btnObrisiAlternativu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAlternativu.Location = new System.Drawing.Point(287, 411);
            this.btnObrisiAlternativu.Name = "btnObrisiAlternativu";
            this.btnObrisiAlternativu.Size = new System.Drawing.Size(116, 32);
            this.btnObrisiAlternativu.TabIndex = 7;
            this.btnObrisiAlternativu.Text = "Obriši alternativu";
            this.btnObrisiAlternativu.UseVisualStyleBackColor = true;
            this.btnObrisiAlternativu.Click += new System.EventHandler(this.btnObrisiAlternativu_Click);
            // 
            // Sastojci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 465);
            this.Controls.Add(this.btnObrisiAlternativu);
            this.Controls.Add(this.panelAlternativaSastojka);
            this.Controls.Add(this.btnObrisiSastojak);
            this.Controls.Add(this.panelIzmeniSastojak);
            this.Controls.Add(this.panelDodajSastojak);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sastojci";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.Sastojci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            this.panelDodajSastojak.ResumeLayout(false);
            this.panelDodajSastojak.PerformLayout();
            this.panelIzmeniSastojak.ResumeLayout(false);
            this.panelIzmeniSastojak.PerformLayout();
            this.panelAlternativaSastojka.ResumeLayout(false);
            this.panelAlternativaSastojka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.Panel panelDodajSastojak;
        private System.Windows.Forms.TextBox txtDodajSastojak;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.Panel panelIzmeniSastojak;
        private System.Windows.Forms.TextBox txtIzmeniSastojak;
        private System.Windows.Forms.Button btnIzmeniSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiSastojak;
        private System.Windows.Forms.Panel panelAlternativaSastojka;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivSastojka;
        private System.Windows.Forms.DataGridViewTextBoxColumn zAlternativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDodajAlternativu;
        private System.Windows.Forms.Button btnDodajAlternativu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzmeniAlternativu;
        private System.Windows.Forms.TextBox txtIzmeniAlternativu;
        private System.Windows.Forms.Button btnObrisiAlternativu;
    }
}