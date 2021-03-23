namespace _Healthy_Recipes
{
    partial class ReceptSastojci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptSastojci));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.sastojciRecepta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaspolozivi = new System.Windows.Forms.DataGridView();
            this.raspoloziviSastojci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.Location = new System.Drawing.Point(247, 173);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 35);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.Location = new System.Drawing.Point(247, 117);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(30);
            this.btnDodaj.Size = new System.Drawing.Size(75, 35);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "button1";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sastojci recepta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Raspoloživi sastojci:";
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sastojciRecepta});
            this.dgvSastojci.Location = new System.Drawing.Point(338, 42);
            this.dgvSastojci.Name = "dgvSastojci";
            this.dgvSastojci.Size = new System.Drawing.Size(210, 230);
            this.dgvSastojci.TabIndex = 7;
            // 
            // sastojciRecepta
            // 
            this.sastojciRecepta.HeaderText = "Sastojci";
            this.sastojciRecepta.Name = "sastojciRecepta";
            // 
            // dgvRaspolozivi
            // 
            this.dgvRaspolozivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaspolozivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspolozivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raspoloziviSastojci});
            this.dgvRaspolozivi.Location = new System.Drawing.Point(21, 42);
            this.dgvRaspolozivi.Name = "dgvRaspolozivi";
            this.dgvRaspolozivi.Size = new System.Drawing.Size(210, 230);
            this.dgvRaspolozivi.TabIndex = 6;
            // 
            // raspoloziviSastojci
            // 
            this.raspoloziviSastojci.HeaderText = "Sastojci";
            this.raspoloziviSastojci.Name = "raspoloziviSastojci";
            // 
            // ReceptSastojci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 295);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.dgvRaspolozivi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceptSastojci";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.ReceptSastojci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.DataGridView dgvRaspolozivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastojciRecepta;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspoloziviSastojci;
    }
}