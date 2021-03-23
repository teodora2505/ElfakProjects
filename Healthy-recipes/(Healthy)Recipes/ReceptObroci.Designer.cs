namespace _Healthy_Recipes
{
    partial class ReceptObroci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptObroci));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvObroci = new System.Windows.Forms.DataGridView();
            this.obrokRecepta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaspolozivi = new System.Windows.Forms.DataGridView();
            this.raspoloziviObroci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObroci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.Location = new System.Drawing.Point(216, 180);
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
            this.btnDodaj.Location = new System.Drawing.Point(216, 124);
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
            this.label2.Location = new System.Drawing.Point(311, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Obrok služenja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Raspoloživi obroci:";
            // 
            // dgvObroci
            // 
            this.dgvObroci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObroci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObroci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obrokRecepta});
            this.dgvObroci.Location = new System.Drawing.Point(314, 51);
            this.dgvObroci.Name = "dgvObroci";
            this.dgvObroci.Size = new System.Drawing.Size(170, 230);
            this.dgvObroci.TabIndex = 7;
            // 
            // obrokRecepta
            // 
            this.obrokRecepta.HeaderText = "Obrok";
            this.obrokRecepta.Name = "obrokRecepta";
            // 
            // dgvRaspolozivi
            // 
            this.dgvRaspolozivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaspolozivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspolozivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raspoloziviObroci});
            this.dgvRaspolozivi.Location = new System.Drawing.Point(21, 51);
            this.dgvRaspolozivi.Name = "dgvRaspolozivi";
            this.dgvRaspolozivi.Size = new System.Drawing.Size(170, 230);
            this.dgvRaspolozivi.TabIndex = 6;
            // 
            // raspoloziviObroci
            // 
            this.raspoloziviObroci.HeaderText = "Obrok";
            this.raspoloziviObroci.Name = "raspoloziviObroci";
            // 
            // ReceptObroci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 297);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObroci);
            this.Controls.Add(this.dgvRaspolozivi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceptObroci";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.ReceptObroci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObroci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvObroci;
        private System.Windows.Forms.DataGridView dgvRaspolozivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrokRecepta;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspoloziviObroci;
    }
}