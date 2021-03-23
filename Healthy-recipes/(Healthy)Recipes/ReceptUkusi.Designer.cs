namespace _Healthy_Recipes
{
    partial class ReceptUkusi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptUkusi));
            this.dgvRaspolozivi = new System.Windows.Forms.DataGridView();
            this.raspoloziviUkusi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUkusi = new System.Windows.Forms.DataGridView();
            this.ukusRecepta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkusi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaspolozivi
            // 
            this.dgvRaspolozivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaspolozivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspolozivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raspoloziviUkusi});
            this.dgvRaspolozivi.Location = new System.Drawing.Point(19, 52);
            this.dgvRaspolozivi.Name = "dgvRaspolozivi";
            this.dgvRaspolozivi.Size = new System.Drawing.Size(170, 230);
            this.dgvRaspolozivi.TabIndex = 0;
            // 
            // raspoloziviUkusi
            // 
            this.raspoloziviUkusi.HeaderText = "Ukus";
            this.raspoloziviUkusi.Name = "raspoloziviUkusi";
            // 
            // dgvUkusi
            // 
            this.dgvUkusi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUkusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkusi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ukusRecepta});
            this.dgvUkusi.Location = new System.Drawing.Point(312, 52);
            this.dgvUkusi.Name = "dgvUkusi";
            this.dgvUkusi.Size = new System.Drawing.Size(170, 230);
            this.dgvUkusi.TabIndex = 1;
            // 
            // ukusRecepta
            // 
            this.ukusRecepta.HeaderText = "Ukus";
            this.ukusRecepta.Name = "ukusRecepta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raspoloživi ukusi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukusi recepta:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.Location = new System.Drawing.Point(214, 125);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(30);
            this.btnDodaj.Size = new System.Drawing.Size(75, 35);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "button1";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.Location = new System.Drawing.Point(214, 181);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 35);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // ReceptUkusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 304);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUkusi);
            this.Controls.Add(this.dgvRaspolozivi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceptUkusi";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.ReceptUkusi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspolozivi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaspolozivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspoloziviUkusi;
        private System.Windows.Forms.DataGridView dgvUkusi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukusRecepta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
    }
}