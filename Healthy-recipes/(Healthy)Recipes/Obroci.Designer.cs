namespace _Healthy_Recipes
{
    partial class Obroci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obroci));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnObrisiObrok = new System.Windows.Forms.Button();
            this.dgvObroci = new System.Windows.Forms.DataGridView();
            this.nazivObroka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIzmeniSastojak = new System.Windows.Forms.Panel();
            this.txtIzmeniObrok = new System.Windows.Forms.TextBox();
            this.btnIzmeniObrok = new System.Windows.Forms.Button();
            this.panelDodajSastojak = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDodajObrok = new System.Windows.Forms.TextBox();
            this.btnDodajObrok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIzmeniVreme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVremeDo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVremeOd1 = new System.Windows.Forms.TextBox();
            this.btnPostaviVreme = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVremeDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVremeOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObroci)).BeginInit();
            this.panelIzmeniSastojak.SuspendLayout();
            this.panelDodajSastojak.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(637, 373);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(5);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(126, 38);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnObrisiObrok
            // 
            this.btnObrisiObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiObrok.Location = new System.Drawing.Point(19, 373);
            this.btnObrisiObrok.Name = "btnObrisiObrok";
            this.btnObrisiObrok.Size = new System.Drawing.Size(128, 37);
            this.btnObrisiObrok.TabIndex = 10;
            this.btnObrisiObrok.Text = "Obriši obrok";
            this.btnObrisiObrok.UseVisualStyleBackColor = true;
            this.btnObrisiObrok.Click += new System.EventHandler(this.btnObrisiObrok_Click);
            // 
            // dgvObroci
            // 
            this.dgvObroci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObroci.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvObroci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvObroci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObroci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivObroka,
            this.vreme});
            this.dgvObroci.Location = new System.Drawing.Point(19, 50);
            this.dgvObroci.Margin = new System.Windows.Forms.Padding(5);
            this.dgvObroci.Name = "dgvObroci";
            this.dgvObroci.RowTemplate.Height = 25;
            this.dgvObroci.Size = new System.Drawing.Size(356, 315);
            this.dgvObroci.TabIndex = 9;
            this.dgvObroci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObroci_CellClick);
            // 
            // nazivObroka
            // 
            this.nazivObroka.HeaderText = "Naziv obroka";
            this.nazivObroka.Name = "nazivObroka";
            // 
            // vreme
            // 
            this.vreme.HeaderText = "Vreme";
            this.vreme.Name = "vreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pregled obroka:";
            // 
            // panelIzmeniSastojak
            // 
            this.panelIzmeniSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelIzmeniSastojak.Controls.Add(this.txtIzmeniObrok);
            this.panelIzmeniSastojak.Controls.Add(this.btnIzmeniObrok);
            this.panelIzmeniSastojak.Location = new System.Drawing.Point(386, 125);
            this.panelIzmeniSastojak.Name = "panelIzmeniSastojak";
            this.panelIzmeniSastojak.Size = new System.Drawing.Size(377, 64);
            this.panelIzmeniSastojak.TabIndex = 12;
            // 
            // txtIzmeniObrok
            // 
            this.txtIzmeniObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzmeniObrok.Location = new System.Drawing.Point(20, 22);
            this.txtIzmeniObrok.Margin = new System.Windows.Forms.Padding(4);
            this.txtIzmeniObrok.Name = "txtIzmeniObrok";
            this.txtIzmeniObrok.Size = new System.Drawing.Size(214, 22);
            this.txtIzmeniObrok.TabIndex = 2;
            // 
            // btnIzmeniObrok
            // 
            this.btnIzmeniObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniObrok.Location = new System.Drawing.Point(243, 16);
            this.btnIzmeniObrok.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniObrok.Name = "btnIzmeniObrok";
            this.btnIzmeniObrok.Size = new System.Drawing.Size(124, 32);
            this.btnIzmeniObrok.TabIndex = 1;
            this.btnIzmeniObrok.Text = "Izmeni obrok";
            this.btnIzmeniObrok.UseVisualStyleBackColor = true;
            this.btnIzmeniObrok.Click += new System.EventHandler(this.btnIzmeniObrok_Click);
            // 
            // panelDodajSastojak
            // 
            this.panelDodajSastojak.BackColor = System.Drawing.Color.Transparent;
            this.panelDodajSastojak.Controls.Add(this.label2);
            this.panelDodajSastojak.Controls.Add(this.txtDodajObrok);
            this.panelDodajSastojak.Controls.Add(this.btnDodajObrok);
            this.panelDodajSastojak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDodajSastojak.Location = new System.Drawing.Point(386, 50);
            this.panelDodajSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.panelDodajSastojak.Name = "panelDodajSastojak";
            this.panelDodajSastojak.Size = new System.Drawing.Size(377, 68);
            this.panelDodajSastojak.TabIndex = 11;
            this.panelDodajSastojak.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite naziv novog obroka";
            this.label2.Visible = false;
            // 
            // txtDodajObrok
            // 
            this.txtDodajObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDodajObrok.Location = new System.Drawing.Point(20, 18);
            this.txtDodajObrok.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodajObrok.Name = "txtDodajObrok";
            this.txtDodajObrok.Size = new System.Drawing.Size(214, 22);
            this.txtDodajObrok.TabIndex = 1;
            // 
            // btnDodajObrok
            // 
            this.btnDodajObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajObrok.Location = new System.Drawing.Point(243, 12);
            this.btnDodajObrok.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajObrok.Name = "btnDodajObrok";
            this.btnDodajObrok.Size = new System.Drawing.Size(124, 32);
            this.btnDodajObrok.TabIndex = 0;
            this.btnDodajObrok.Text = "Dodaj obrok";
            this.btnDodajObrok.UseVisualStyleBackColor = true;
            this.btnDodajObrok.Click += new System.EventHandler(this.btnDodajObrok_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnIzmeniVreme);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtVremeDo1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtVremeOd1);
            this.panel1.Controls.Add(this.btnPostaviVreme);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVremeDo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtVremeOd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(386, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 170);
            this.panel1.TabIndex = 13;
            // 
            // btnIzmeniVreme
            // 
            this.btnIzmeniVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniVreme.Location = new System.Drawing.Point(243, 103);
            this.btnIzmeniVreme.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniVreme.Name = "btnIzmeniVreme";
            this.btnIzmeniVreme.Size = new System.Drawing.Size(124, 32);
            this.btnIzmeniVreme.TabIndex = 11;
            this.btnIzmeniVreme.Text = "Izmeni vreme";
            this.btnIzmeniVreme.UseVisualStyleBackColor = true;
            this.btnIzmeniVreme.Click += new System.EventHandler(this.btnIzmeniVreme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Do:";
            // 
            // txtVremeDo1
            // 
            this.txtVremeDo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeDo1.Location = new System.Drawing.Point(176, 109);
            this.txtVremeDo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtVremeDo1.Name = "txtVremeDo1";
            this.txtVremeDo1.Size = new System.Drawing.Size(58, 22);
            this.txtVremeDo1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Od:";
            // 
            // txtVremeOd1
            // 
            this.txtVremeOd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeOd1.Location = new System.Drawing.Point(47, 109);
            this.txtVremeOd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtVremeOd1.Name = "txtVremeOd1";
            this.txtVremeOd1.Size = new System.Drawing.Size(58, 22);
            this.txtVremeOd1.TabIndex = 7;
            // 
            // btnPostaviVreme
            // 
            this.btnPostaviVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostaviVreme.Location = new System.Drawing.Point(243, 46);
            this.btnPostaviVreme.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostaviVreme.Name = "btnPostaviVreme";
            this.btnPostaviVreme.Size = new System.Drawing.Size(124, 32);
            this.btnPostaviVreme.TabIndex = 6;
            this.btnPostaviVreme.Text = "Postavi vreme";
            this.btnPostaviVreme.UseVisualStyleBackColor = true;
            this.btnPostaviVreme.Click += new System.EventHandler(this.btnPostaviVreme_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Do:";
            // 
            // txtVremeDo
            // 
            this.txtVremeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeDo.Location = new System.Drawing.Point(176, 52);
            this.txtVremeDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVremeDo.Name = "txtVremeDo";
            this.txtVremeDo.Size = new System.Drawing.Size(58, 22);
            this.txtVremeDo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Od:";
            // 
            // txtVremeOd
            // 
            this.txtVremeOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeOd.Location = new System.Drawing.Point(47, 52);
            this.txtVremeOd.Margin = new System.Windows.Forms.Padding(4);
            this.txtVremeOd.Name = "txtVremeOd";
            this.txtVremeOd.Size = new System.Drawing.Size(58, 22);
            this.txtVremeOd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vreme služenja obroka:";
            // 
            // Obroci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelIzmeniSastojak);
            this.Controls.Add(this.panelDodajSastojak);
            this.Controls.Add(this.btnObrisiObrok);
            this.Controls.Add(this.dgvObroci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Obroci";
            this.Text = "(Healthy)Recipes";
            this.Load += new System.EventHandler(this.Obroci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObroci)).EndInit();
            this.panelIzmeniSastojak.ResumeLayout(false);
            this.panelIzmeniSastojak.PerformLayout();
            this.panelDodajSastojak.ResumeLayout(false);
            this.panelDodajSastojak.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnObrisiObrok;
        private System.Windows.Forms.DataGridView dgvObroci;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivObroka;
        private System.Windows.Forms.DataGridViewTextBoxColumn vreme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIzmeniSastojak;
        private System.Windows.Forms.TextBox txtIzmeniObrok;
        private System.Windows.Forms.Button btnIzmeniObrok;
        private System.Windows.Forms.Panel panelDodajSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDodajObrok;
        private System.Windows.Forms.Button btnDodajObrok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVremeDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVremeOd;
        private System.Windows.Forms.Button btnIzmeniVreme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVremeDo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVremeOd1;
        private System.Windows.Forms.Button btnPostaviVreme;
    }
}