namespace _Healthy_Recipes
{
    partial class OpisRecepta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpisRecepta));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajOpis = new System.Windows.Forms.Button();
            this.btnIzmeniOpis = new System.Windows.Forms.Button();
            this.btnObrisiOpis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(391, 247);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(5);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(126, 29);
            this.btnZatvori.TabIndex = 21;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(12, 12);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(350, 266);
            this.txtOpis.TabIndex = 22;
            // 
            // btnDodajOpis
            // 
            this.btnDodajOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOpis.Location = new System.Drawing.Point(389, 14);
            this.btnDodajOpis.Margin = new System.Windows.Forms.Padding(5);
            this.btnDodajOpis.Name = "btnDodajOpis";
            this.btnDodajOpis.Size = new System.Drawing.Size(126, 29);
            this.btnDodajOpis.TabIndex = 23;
            this.btnDodajOpis.Text = "Dodaj opis";
            this.btnDodajOpis.UseVisualStyleBackColor = true;
            this.btnDodajOpis.Click += new System.EventHandler(this.btnDodajOpis_Click);
            // 
            // btnIzmeniOpis
            // 
            this.btnIzmeniOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniOpis.Location = new System.Drawing.Point(389, 53);
            this.btnIzmeniOpis.Margin = new System.Windows.Forms.Padding(5);
            this.btnIzmeniOpis.Name = "btnIzmeniOpis";
            this.btnIzmeniOpis.Size = new System.Drawing.Size(126, 29);
            this.btnIzmeniOpis.TabIndex = 24;
            this.btnIzmeniOpis.Text = "Izmeni opis";
            this.btnIzmeniOpis.UseVisualStyleBackColor = true;
            this.btnIzmeniOpis.Click += new System.EventHandler(this.btnIzmeniOpis_Click);
            // 
            // btnObrisiOpis
            // 
            this.btnObrisiOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOpis.Location = new System.Drawing.Point(389, 92);
            this.btnObrisiOpis.Margin = new System.Windows.Forms.Padding(5);
            this.btnObrisiOpis.Name = "btnObrisiOpis";
            this.btnObrisiOpis.Size = new System.Drawing.Size(126, 29);
            this.btnObrisiOpis.TabIndex = 25;
            this.btnObrisiOpis.Text = "Obriši opis";
            this.btnObrisiOpis.UseVisualStyleBackColor = true;
            this.btnObrisiOpis.Click += new System.EventHandler(this.btnObrisiOpis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(391, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 110);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // OpisRecepta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 290);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnObrisiOpis);
            this.Controls.Add(this.btnIzmeniOpis);
            this.Controls.Add(this.btnDodajOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpisRecepta";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.OpisRecepta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajOpis;
        private System.Windows.Forms.Button btnIzmeniOpis;
        private System.Windows.Forms.Button btnObrisiOpis;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}