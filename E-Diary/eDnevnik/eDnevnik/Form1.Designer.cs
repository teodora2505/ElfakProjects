namespace eDnevnik
{
    partial class Form1
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
            this.btnUcitavanjeKorisnika = new System.Windows.Forms.Button();
            this.btnDodavanjeKorisnika = new System.Windows.Forms.Button();
            this.btnOdeljenjeUcenik = new System.Windows.Forms.Button();
            this.btnUcenikOdeljenje = new System.Windows.Forms.Button();
            this.btnDodavanjeOdeljenja = new System.Windows.Forms.Button();
            this.btnRoditeljUcenik = new System.Windows.Forms.Button();
            this.btnJeRazredni = new System.Windows.Forms.Button();
            this.btnUcitajRazrednog = new System.Windows.Forms.Button();
            this.btnUcitajPredmet = new System.Windows.Forms.Button();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.btnNastavnikPredmet = new System.Windows.Forms.Button();
            this.btnDodavanjePredaje = new System.Windows.Forms.Button();
            this.btnUcenikPredmet = new System.Windows.Forms.Button();
            this.btnDodavanjeImaOcenu = new System.Windows.Forms.Button();
            this.btnUcitavanjeOdeljenja = new System.Windows.Forms.Button();
            this.btnJeRoditelj = new System.Windows.Forms.Button();
            this.btnUcitajPredstavnika = new System.Windows.Forms.Button();
            this.btnPredstavlja = new System.Windows.Forms.Button();
            this.btnUcitajRaspored = new System.Windows.Forms.Button();
            this.btnRaspored = new System.Windows.Forms.Button();
            this.btnBrojTelefona = new System.Windows.Forms.Button();
            this.btnGodina = new System.Windows.Forms.Button();
            this.btnFunkcija = new System.Windows.Forms.Button();
            this.btnDrziCas = new System.Windows.Forms.Button();
            this.btnKreiranjeUcenika = new System.Windows.Forms.Button();
            this.btnInheritance = new System.Windows.Forms.Button();
            this.btnTPC = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitavanjeKorisnika
            // 
            this.btnUcitavanjeKorisnika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitavanjeKorisnika.Location = new System.Drawing.Point(46, 12);
            this.btnUcitavanjeKorisnika.Name = "btnUcitavanjeKorisnika";
            this.btnUcitavanjeKorisnika.Size = new System.Drawing.Size(165, 33);
            this.btnUcitavanjeKorisnika.TabIndex = 0;
            this.btnUcitavanjeKorisnika.Text = "Učitavanje Korisnika";
            this.btnUcitavanjeKorisnika.UseVisualStyleBackColor = false;
            this.btnUcitavanjeKorisnika.Click += new System.EventHandler(this.btnUcitavanjeKorisnika_Click);
            // 
            // btnDodavanjeKorisnika
            // 
            this.btnDodavanjeKorisnika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodavanjeKorisnika.Location = new System.Drawing.Point(46, 51);
            this.btnDodavanjeKorisnika.Name = "btnDodavanjeKorisnika";
            this.btnDodavanjeKorisnika.Size = new System.Drawing.Size(165, 33);
            this.btnDodavanjeKorisnika.TabIndex = 1;
            this.btnDodavanjeKorisnika.Text = "Dodavanje Korisnika";
            this.btnDodavanjeKorisnika.UseVisualStyleBackColor = false;
            this.btnDodavanjeKorisnika.Click += new System.EventHandler(this.btnDodavanjeKorisnika_Click);
            // 
            // btnOdeljenjeUcenik
            // 
            this.btnOdeljenjeUcenik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOdeljenjeUcenik.Location = new System.Drawing.Point(46, 140);
            this.btnOdeljenjeUcenik.Name = "btnOdeljenjeUcenik";
            this.btnOdeljenjeUcenik.Size = new System.Drawing.Size(165, 44);
            this.btnOdeljenjeUcenik.TabIndex = 2;
            this.btnOdeljenjeUcenik.Text = "Veza One-To-Many Odeljenje-Ucenik";
            this.btnOdeljenjeUcenik.UseVisualStyleBackColor = false;
            this.btnOdeljenjeUcenik.Click += new System.EventHandler(this.btnOdeljenjeUcenik_Click);
            // 
            // btnUcenikOdeljenje
            // 
            this.btnUcenikOdeljenje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcenikOdeljenje.Location = new System.Drawing.Point(46, 90);
            this.btnUcenikOdeljenje.Name = "btnUcenikOdeljenje";
            this.btnUcenikOdeljenje.Size = new System.Drawing.Size(165, 44);
            this.btnUcenikOdeljenje.TabIndex = 3;
            this.btnUcenikOdeljenje.Text = "Veza Many-To-One Ucenik-Odeljenje";
            this.btnUcenikOdeljenje.UseVisualStyleBackColor = false;
            this.btnUcenikOdeljenje.Click += new System.EventHandler(this.btnUcenikOdeljenje_Click);
            // 
            // btnDodavanjeOdeljenja
            // 
            this.btnDodavanjeOdeljenja.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodavanjeOdeljenja.Location = new System.Drawing.Point(46, 229);
            this.btnDodavanjeOdeljenja.Name = "btnDodavanjeOdeljenja";
            this.btnDodavanjeOdeljenja.Size = new System.Drawing.Size(165, 33);
            this.btnDodavanjeOdeljenja.TabIndex = 4;
            this.btnDodavanjeOdeljenja.Text = "Dodavanje Odeljenja";
            this.btnDodavanjeOdeljenja.UseVisualStyleBackColor = false;
            this.btnDodavanjeOdeljenja.Click += new System.EventHandler(this.btnDodavanjeOdeljenja_Click);
            // 
            // btnRoditeljUcenik
            // 
            this.btnRoditeljUcenik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRoditeljUcenik.Location = new System.Drawing.Point(46, 268);
            this.btnRoditeljUcenik.Name = "btnRoditeljUcenik";
            this.btnRoditeljUcenik.Size = new System.Drawing.Size(165, 44);
            this.btnRoditeljUcenik.TabIndex = 5;
            this.btnRoditeljUcenik.Text = "HasManyToMany Roditelj-Ucenik";
            this.btnRoditeljUcenik.UseVisualStyleBackColor = false;
            this.btnRoditeljUcenik.Click += new System.EventHandler(this.btnRoditeljUcenik_Click);
            // 
            // btnJeRazredni
            // 
            this.btnJeRazredni.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnJeRazredni.Location = new System.Drawing.Point(46, 407);
            this.btnJeRazredni.Name = "btnJeRazredni";
            this.btnJeRazredni.Size = new System.Drawing.Size(165, 35);
            this.btnJeRazredni.TabIndex = 6;
            this.btnJeRazredni.Text = "Dodavanje JeRazredni";
            this.btnJeRazredni.UseVisualStyleBackColor = false;
            this.btnJeRazredni.Click += new System.EventHandler(this.btnJeRazredni_Click);
            // 
            // btnUcitajRazrednog
            // 
            this.btnUcitajRazrednog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitajRazrednog.Location = new System.Drawing.Point(46, 357);
            this.btnUcitajRazrednog.Name = "btnUcitajRazrednog";
            this.btnUcitajRazrednog.Size = new System.Drawing.Size(165, 44);
            this.btnUcitajRazrednog.TabIndex = 7;
            this.btnUcitajRazrednog.Text = "HasManyToMany Razredni-Odeljenje";
            this.btnUcitajRazrednog.UseVisualStyleBackColor = false;
            this.btnUcitajRazrednog.Click += new System.EventHandler(this.btnUcitajRazrednog_Click);
            // 
            // btnUcitajPredmet
            // 
            this.btnUcitajPredmet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitajPredmet.Location = new System.Drawing.Point(294, 12);
            this.btnUcitajPredmet.Name = "btnUcitajPredmet";
            this.btnUcitajPredmet.Size = new System.Drawing.Size(165, 33);
            this.btnUcitajPredmet.TabIndex = 8;
            this.btnUcitajPredmet.Text = "Učitavanje Predmeta";
            this.btnUcitajPredmet.UseVisualStyleBackColor = false;
            this.btnUcitajPredmet.Click += new System.EventHandler(this.btnUcitajPredmet_Click);
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodajPredmet.Location = new System.Drawing.Point(294, 51);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(165, 33);
            this.btnDodajPredmet.TabIndex = 9;
            this.btnDodajPredmet.Text = "Dodavanje Predmeta";
            this.btnDodajPredmet.UseVisualStyleBackColor = false;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // btnNastavnikPredmet
            // 
            this.btnNastavnikPredmet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNastavnikPredmet.Location = new System.Drawing.Point(294, 90);
            this.btnNastavnikPredmet.Name = "btnNastavnikPredmet";
            this.btnNastavnikPredmet.Size = new System.Drawing.Size(165, 44);
            this.btnNastavnikPredmet.TabIndex = 10;
            this.btnNastavnikPredmet.Text = "HasManyToMany Nastavnik-Predmet";
            this.btnNastavnikPredmet.UseVisualStyleBackColor = false;
            this.btnNastavnikPredmet.Click += new System.EventHandler(this.btnNastavnikPredmet_Click);
            // 
            // btnDodavanjePredaje
            // 
            this.btnDodavanjePredaje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodavanjePredaje.Location = new System.Drawing.Point(294, 140);
            this.btnDodavanjePredaje.Name = "btnDodavanjePredaje";
            this.btnDodavanjePredaje.Size = new System.Drawing.Size(165, 35);
            this.btnDodavanjePredaje.TabIndex = 11;
            this.btnDodavanjePredaje.Text = "Dodavanje Predaje";
            this.btnDodavanjePredaje.UseVisualStyleBackColor = false;
            this.btnDodavanjePredaje.Click += new System.EventHandler(this.btnDodavanjePredaje_Click);
            // 
            // btnUcenikPredmet
            // 
            this.btnUcenikPredmet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcenikPredmet.Location = new System.Drawing.Point(294, 181);
            this.btnUcenikPredmet.Name = "btnUcenikPredmet";
            this.btnUcenikPredmet.Size = new System.Drawing.Size(165, 44);
            this.btnUcenikPredmet.TabIndex = 12;
            this.btnUcenikPredmet.Text = "HasManyToMany Ucenik-Predmet";
            this.btnUcenikPredmet.UseVisualStyleBackColor = false;
            this.btnUcenikPredmet.Click += new System.EventHandler(this.btnUcenikPredmet_Click);
            // 
            // btnDodavanjeImaOcenu
            // 
            this.btnDodavanjeImaOcenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodavanjeImaOcenu.Location = new System.Drawing.Point(294, 229);
            this.btnDodavanjeImaOcenu.Name = "btnDodavanjeImaOcenu";
            this.btnDodavanjeImaOcenu.Size = new System.Drawing.Size(165, 33);
            this.btnDodavanjeImaOcenu.TabIndex = 13;
            this.btnDodavanjeImaOcenu.Text = "Dodavanje ImaOcenu";
            this.btnDodavanjeImaOcenu.UseVisualStyleBackColor = false;
            this.btnDodavanjeImaOcenu.Click += new System.EventHandler(this.btnDodavanjeImaOcenu_Click);
            // 
            // btnUcitavanjeOdeljenja
            // 
            this.btnUcitavanjeOdeljenja.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitavanjeOdeljenja.Location = new System.Drawing.Point(46, 190);
            this.btnUcitavanjeOdeljenja.Name = "btnUcitavanjeOdeljenja";
            this.btnUcitavanjeOdeljenja.Size = new System.Drawing.Size(165, 33);
            this.btnUcitavanjeOdeljenja.TabIndex = 14;
            this.btnUcitavanjeOdeljenja.Text = "Učitavanje Odeljenja";
            this.btnUcitavanjeOdeljenja.UseVisualStyleBackColor = false;
            this.btnUcitavanjeOdeljenja.Click += new System.EventHandler(this.btnUcitavanjeOdeljenja_Click);
            // 
            // btnJeRoditelj
            // 
            this.btnJeRoditelj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnJeRoditelj.Location = new System.Drawing.Point(46, 318);
            this.btnJeRoditelj.Name = "btnJeRoditelj";
            this.btnJeRoditelj.Size = new System.Drawing.Size(165, 33);
            this.btnJeRoditelj.TabIndex = 15;
            this.btnJeRoditelj.Text = "Dodavanje JeRoditelj";
            this.btnJeRoditelj.UseVisualStyleBackColor = false;
            this.btnJeRoditelj.Click += new System.EventHandler(this.btnJeRoditelj_Click);
            // 
            // btnUcitajPredstavnika
            // 
            this.btnUcitajPredstavnika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitajPredstavnika.Location = new System.Drawing.Point(294, 268);
            this.btnUcitajPredstavnika.Name = "btnUcitajPredstavnika";
            this.btnUcitajPredstavnika.Size = new System.Drawing.Size(165, 44);
            this.btnUcitajPredstavnika.TabIndex = 16;
            this.btnUcitajPredstavnika.Text = "HasManyToMany Predstavnik-Odeljenje";
            this.btnUcitajPredstavnika.UseVisualStyleBackColor = false;
            this.btnUcitajPredstavnika.Click += new System.EventHandler(this.btnUcitajPredstavnika_Click);
            // 
            // btnPredstavlja
            // 
            this.btnPredstavlja.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPredstavlja.Location = new System.Drawing.Point(294, 318);
            this.btnPredstavlja.Name = "btnPredstavlja";
            this.btnPredstavlja.Size = new System.Drawing.Size(165, 33);
            this.btnPredstavlja.TabIndex = 17;
            this.btnPredstavlja.Text = "Dodavanje Predstavlja";
            this.btnPredstavlja.UseVisualStyleBackColor = false;
            this.btnPredstavlja.Click += new System.EventHandler(this.btnPredstavlja_Click);
            // 
            // btnUcitajRaspored
            // 
            this.btnUcitajRaspored.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUcitajRaspored.Location = new System.Drawing.Point(294, 357);
            this.btnUcitajRaspored.Name = "btnUcitajRaspored";
            this.btnUcitajRaspored.Size = new System.Drawing.Size(165, 44);
            this.btnUcitajRaspored.TabIndex = 18;
            this.btnUcitajRaspored.Text = "HasManyToMany Predmet-Odeljenje";
            this.btnUcitajRaspored.UseVisualStyleBackColor = false;
            this.btnUcitajRaspored.Click += new System.EventHandler(this.btnUcitajRaspored_Click);
            // 
            // btnRaspored
            // 
            this.btnRaspored.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRaspored.Location = new System.Drawing.Point(294, 407);
            this.btnRaspored.Name = "btnRaspored";
            this.btnRaspored.Size = new System.Drawing.Size(165, 35);
            this.btnRaspored.TabIndex = 19;
            this.btnRaspored.Text = "Dodavanje Rasporeda";
            this.btnRaspored.UseVisualStyleBackColor = false;
            this.btnRaspored.Click += new System.EventHandler(this.btnRaspored_Click);
            // 
            // btnBrojTelefona
            // 
            this.btnBrojTelefona.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBrojTelefona.Location = new System.Drawing.Point(548, 12);
            this.btnBrojTelefona.Name = "btnBrojTelefona";
            this.btnBrojTelefona.Size = new System.Drawing.Size(165, 44);
            this.btnBrojTelefona.TabIndex = 20;
            this.btnBrojTelefona.Text = "Viševrednosni atribut Broj_telefona";
            this.btnBrojTelefona.UseVisualStyleBackColor = false;
            this.btnBrojTelefona.Click += new System.EventHandler(this.btnBrojTelefona_Click);
            // 
            // btnGodina
            // 
            this.btnGodina.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGodina.Location = new System.Drawing.Point(548, 62);
            this.btnGodina.Name = "btnGodina";
            this.btnGodina.Size = new System.Drawing.Size(165, 33);
            this.btnGodina.TabIndex = 21;
            this.btnGodina.Text = "Viševrednosni atribut Godina";
            this.btnGodina.UseVisualStyleBackColor = false;
            this.btnGodina.Click += new System.EventHandler(this.btnGodina_Click);
            // 
            // btnFunkcija
            // 
            this.btnFunkcija.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFunkcija.Location = new System.Drawing.Point(548, 101);
            this.btnFunkcija.Name = "btnFunkcija";
            this.btnFunkcija.Size = new System.Drawing.Size(165, 44);
            this.btnFunkcija.TabIndex = 22;
            this.btnFunkcija.Text = "Veza One-to-Many Roditelj-Funkcija";
            this.btnFunkcija.UseVisualStyleBackColor = false;
            this.btnFunkcija.Click += new System.EventHandler(this.btnFunkcija_Click);
            // 
            // btnDrziCas
            // 
            this.btnDrziCas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDrziCas.Location = new System.Drawing.Point(548, 151);
            this.btnDrziCas.Name = "btnDrziCas";
            this.btnDrziCas.Size = new System.Drawing.Size(165, 44);
            this.btnDrziCas.TabIndex = 23;
            this.btnDrziCas.Text = "Ternarna veza Drzi_cas Nastavnik-Predmet-Odeljenje";
            this.btnDrziCas.UseVisualStyleBackColor = false;
            this.btnDrziCas.Click += new System.EventHandler(this.btnDrziCas_Click);
            // 
            // btnKreiranjeUcenika
            // 
            this.btnKreiranjeUcenika.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKreiranjeUcenika.Location = new System.Drawing.Point(548, 201);
            this.btnKreiranjeUcenika.Name = "btnKreiranjeUcenika";
            this.btnKreiranjeUcenika.Size = new System.Drawing.Size(165, 33);
            this.btnKreiranjeUcenika.TabIndex = 24;
            this.btnKreiranjeUcenika.Text = "Kreiranje podklase Korisnika";
            this.btnKreiranjeUcenika.UseVisualStyleBackColor = false;
            this.btnKreiranjeUcenika.Click += new System.EventHandler(this.btnKreiranjeUcenika_Click);
            // 
            // btnInheritance
            // 
            this.btnInheritance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInheritance.Location = new System.Drawing.Point(548, 240);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(165, 33);
            this.btnInheritance.TabIndex = 25;
            this.btnInheritance.Text = "Table-per-Class Inheritance";
            this.btnInheritance.UseVisualStyleBackColor = false;
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // btnTPC
            // 
            this.btnTPC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTPC.Location = new System.Drawing.Point(548, 279);
            this.btnTPC.Name = "btnTPC";
            this.btnTPC.Size = new System.Drawing.Size(165, 44);
            this.btnTPC.TabIndex = 26;
            this.btnTPC.Text = "Table-per-Class-Hierarchy inheritance";
            this.btnTPC.UseVisualStyleBackColor = false;
            this.btnTPC.Click += new System.EventHandler(this.btnTPC_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGet.Location = new System.Drawing.Point(548, 329);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(165, 33);
            this.btnGet.TabIndex = 27;
            this.btnGet.Text = "Koriscenje metode Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRefresh.Location = new System.Drawing.Point(548, 368);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(165, 33);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Koriscenje metode Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnQuery.Location = new System.Drawing.Point(548, 407);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(165, 35);
            this.btnQuery.TabIndex = 29;
            this.btnQuery.Text = "Krieranje upita";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 456);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnTPC);
            this.Controls.Add(this.btnInheritance);
            this.Controls.Add(this.btnKreiranjeUcenika);
            this.Controls.Add(this.btnDrziCas);
            this.Controls.Add(this.btnFunkcija);
            this.Controls.Add(this.btnGodina);
            this.Controls.Add(this.btnBrojTelefona);
            this.Controls.Add(this.btnRaspored);
            this.Controls.Add(this.btnUcitajRaspored);
            this.Controls.Add(this.btnPredstavlja);
            this.Controls.Add(this.btnUcitajPredstavnika);
            this.Controls.Add(this.btnJeRoditelj);
            this.Controls.Add(this.btnUcitavanjeOdeljenja);
            this.Controls.Add(this.btnDodavanjeImaOcenu);
            this.Controls.Add(this.btnUcenikPredmet);
            this.Controls.Add(this.btnDodavanjePredaje);
            this.Controls.Add(this.btnNastavnikPredmet);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.btnUcitajPredmet);
            this.Controls.Add(this.btnUcitajRazrednog);
            this.Controls.Add(this.btnJeRazredni);
            this.Controls.Add(this.btnRoditeljUcenik);
            this.Controls.Add(this.btnDodavanjeOdeljenja);
            this.Controls.Add(this.btnUcenikOdeljenje);
            this.Controls.Add(this.btnOdeljenjeUcenik);
            this.Controls.Add(this.btnDodavanjeKorisnika);
            this.Controls.Add(this.btnUcitavanjeKorisnika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitavanjeKorisnika;
        private System.Windows.Forms.Button btnDodavanjeKorisnika;
        private System.Windows.Forms.Button btnOdeljenjeUcenik;
        private System.Windows.Forms.Button btnUcenikOdeljenje;
        private System.Windows.Forms.Button btnDodavanjeOdeljenja;
        private System.Windows.Forms.Button btnRoditeljUcenik;
        private System.Windows.Forms.Button btnJeRazredni;
        private System.Windows.Forms.Button btnUcitajRazrednog;
        private System.Windows.Forms.Button btnUcitajPredmet;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.Button btnNastavnikPredmet;
        private System.Windows.Forms.Button btnDodavanjePredaje;
        private System.Windows.Forms.Button btnUcenikPredmet;
        private System.Windows.Forms.Button btnDodavanjeImaOcenu;
        private System.Windows.Forms.Button btnUcitavanjeOdeljenja;
        private System.Windows.Forms.Button btnJeRoditelj;
        private System.Windows.Forms.Button btnUcitajPredstavnika;
        private System.Windows.Forms.Button btnPredstavlja;
        private System.Windows.Forms.Button btnUcitajRaspored;
        private System.Windows.Forms.Button btnRaspored;
        private System.Windows.Forms.Button btnBrojTelefona;
        private System.Windows.Forms.Button btnGodina;
        private System.Windows.Forms.Button btnFunkcija;
        private System.Windows.Forms.Button btnDrziCas;
        private System.Windows.Forms.Button btnKreiranjeUcenika;
        private System.Windows.Forms.Button btnInheritance;
        private System.Windows.Forms.Button btnTPC;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuery;
    }
}

