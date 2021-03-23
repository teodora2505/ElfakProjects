namespace _Healthy_Recipes
{
    partial class Ocene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocene));
            this.panelIzmeniSastojak = new System.Windows.Forms.Panel();
            this.txtIzmeniOcenu = new System.Windows.Forms.TextBox();
            this.btnIzmeniOcenu = new System.Windows.Forms.Button();
            this.panelDodajSastojak = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDodajOcenu = new System.Windows.Forms.TextBox();
            this.btnDodajOcenu = new System.Windows.Forms.Button();
            this.btnObrisiOcenu = new System.Windows.Forms.Button();
            this.dgvOcene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelIzmeniSastojak.SuspendLayout();
            this.panelDodajSastojak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcene)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzmeniSastojak
            // 
            this.panelIzmeniSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelIzmeniSastojak.Controls.Add(this.txtIzmeniOcenu);
            this.panelIzmeniSastojak.Controls.Add(this.btnIzmeniOcenu);
            this.panelIzmeniSastojak.Location = new System.Drawing.Point(240, 105);
            this.panelIzmeniSastojak.Name = "panelIzmeniSastojak";
            this.panelIzmeniSastojak.Size = new System.Drawing.Size(221, 64);
            this.panelIzmeniSastojak.TabIndex = 38;
            // 
            // txtIzmeniOcenu
            // 
            this.txtIzmeniOcenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmeniOcenu.Location = new System.Drawing.Point(20, 22);
            this.txtIzmeniOcenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIzmeniOcenu.Name = "txtIzmeniOcenu";
            this.txtIzmeniOcenu.Size = new System.Drawing.Size(70, 22);
            this.txtIzmeniOcenu.TabIndex = 2;
            // 
            // btnIzmeniOcenu
            // 
            this.btnIzmeniOcenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniOcenu.Location = new System.Drawing.Point(104, 17);
            this.btnIzmeniOcenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniOcenu.Name = "btnIzmeniOcenu";
            this.btnIzmeniOcenu.Size = new System.Drawing.Size(100, 32);
            this.btnIzmeniOcenu.TabIndex = 1;
            this.btnIzmeniOcenu.Text = "Izmeni ocenu";
            this.btnIzmeniOcenu.UseVisualStyleBackColor = true;
            this.btnIzmeniOcenu.Click += new System.EventHandler(this.btnIzmeniOcenu_Click);
            // 
            // panelDodajSastojak
            // 
            this.panelDodajSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelDodajSastojak.Controls.Add(this.label2);
            this.panelDodajSastojak.Controls.Add(this.txtDodajOcenu);
            this.panelDodajSastojak.Controls.Add(this.btnDodajOcenu);
            this.panelDodajSastojak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDodajSastojak.Location = new System.Drawing.Point(240, 30);
            this.panelDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.panelDodajSastojak.Name = "panelDodajSastojak";
            this.panelDodajSastojak.Size = new System.Drawing.Size(221, 68);
            this.panelDodajSastojak.TabIndex = 37;
            this.panelDodajSastojak.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite brojčanu ocenu";
            this.label2.Visible = false;
            // 
            // txtDodajOcenu
            // 
            this.txtDodajOcenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajOcenu.Location = new System.Drawing.Point(20, 18);
            this.txtDodajOcenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodajOcenu.Name = "txtDodajOcenu";
            this.txtDodajOcenu.Size = new System.Drawing.Size(70, 22);
            this.txtDodajOcenu.TabIndex = 1;
            // 
            // btnDodajOcenu
            // 
            this.btnDodajOcenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOcenu.Location = new System.Drawing.Point(104, 12);
            this.btnDodajOcenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajOcenu.Name = "btnDodajOcenu";
            this.btnDodajOcenu.Size = new System.Drawing.Size(100, 32);
            this.btnDodajOcenu.TabIndex = 0;
            this.btnDodajOcenu.Text = "Dodaj ocenu";
            this.btnDodajOcenu.UseVisualStyleBackColor = true;
            this.btnDodajOcenu.Click += new System.EventHandler(this.btnDodajOcenu_Click);
            // 
            // btnObrisiOcenu
            // 
            this.btnObrisiOcenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOcenu.Location = new System.Drawing.Point(14, 249);
            this.btnObrisiOcenu.Name = "btnObrisiOcenu";
            this.btnObrisiOcenu.Size = new System.Drawing.Size(114, 29);
            this.btnObrisiOcenu.TabIndex = 36;
            this.btnObrisiOcenu.Text = "Obriši ocenu";
            this.btnObrisiOcenu.UseVisualStyleBackColor = true;
            this.btnObrisiOcenu.Click += new System.EventHandler(this.btnObrisiOcenu_Click);
            // 
            // dgvOcene
            // 
            this.dgvOcene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcene.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOcene.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOcene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ocena});
            this.dgvOcene.Location = new System.Drawing.Point(17, 30);
            this.dgvOcene.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOcene.Name = "dgvOcene";
            this.dgvOcene.RowTemplate.Height = 25;
            this.dgvOcene.Size = new System.Drawing.Size(201, 211);
            this.dgvOcene.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pregled ocena:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(350, 249);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(5);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(111, 29);
            this.btnZatvori.TabIndex = 33;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ocena
            // 
            this.ocena.HeaderText = "Ocena";
            this.ocena.Name = "ocena";
            // 
            // Ocene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 291);
            this.Controls.Add(this.panelIzmeniSastojak);
            this.Controls.Add(this.panelDodajSastojak);
            this.Controls.Add(this.btnObrisiOcenu);
            this.Controls.Add(this.dgvOcene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ocene";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.Ocene_Load);
            this.panelIzmeniSastojak.ResumeLayout(false);
            this.panelIzmeniSastojak.PerformLayout();
            this.panelDodajSastojak.ResumeLayout(false);
            this.panelDodajSastojak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelIzmeniSastojak;
        private System.Windows.Forms.TextBox txtIzmeniOcenu;
        private System.Windows.Forms.Button btnIzmeniOcenu;
        private System.Windows.Forms.Panel panelDodajSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDodajOcenu;
        private System.Windows.Forms.Button btnDodajOcenu;
        private System.Windows.Forms.Button btnObrisiOcenu;
        private System.Windows.Forms.DataGridView dgvOcene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocena;
    }
}