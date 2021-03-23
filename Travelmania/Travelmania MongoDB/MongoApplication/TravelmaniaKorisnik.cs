
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Mongo_DataLayer.Entities;
using Mongo_DataLayer;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using Bunifu;

namespace MongoApplication
{
    public partial class TravelmaniaKorisnik : Form
    {
        #region pomocne_promenljive

        public string logovanIme;
        public string logovanPrezime;
        public Korisnik logovanKorisnik;
        public string trenutnaOpcija = "ponude";
        public bool slideMenuExpanded = true;
        int secCount = 0;
        List<Ponuda> listaPonuda;
        List<string> slikeDetaljnijiPrikaz;
        int indeksDetaljnijeSlike = 0;
        List<Ponuda> listaOmiljenihPonuda= new List<Ponuda>();
        int indeksOmiljenePonude = 0;
        List<string> slikeOmiljenePonude= new List<string>();
        int indeksSlikeOmiljenePonude = 0;
        public string slajdPonude = "prosiren";
        public string slajdPretraga = "prosiren";
        public string slajdOmiljenePonude = "prosiren";
        public string slajdRezervacije = "prosiren";
        public string slajdRecenzije = "prosiren";
        public bool detaljiRecenzije = false;
        public bool detaljiRezervacije = false;

        #endregion

        #region funkcije_za_korisnik_formu

        public TravelmaniaKorisnik()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)// Dugme X za zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Dugme za minimizaciju forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideMenuExpanded = !slideMenuExpanded;
            if (SlideMenu.Width == 50)//kad je slideMenu uvucen
            {
                    
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 200;
                    PanelAnimator.ShowSync(SlideMenu);
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

                if (trenutnaOpcija == "ponude")
                {
                   
                    slajdPonude = "prosiren";
                    panelPonude.Show();
                    panelPretraga.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X + 100, this.panelPonude.Location.Y);
                    PanelAnimator2.ShowSync(panelPonude);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
                }
                else if (trenutnaOpcija == "pretraga")
                {
                    
                    slajdPretraga = "prosiren";
                    panelPretraga.Show();
                    panelPonude.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPretraga.Location = new Point(this.panelPretraga.Location.X + 100, this.panelPretraga.Location.Y);
                    PanelAnimator2.ShowSync(panelPretraga);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPretraga.Location.Y);
                }
                else if (trenutnaOpcija == "omiljenePonude")
                {
                   
                    slajdOmiljenePonude = "prosiren";
                    panelOmiljenePonude.Show();
                    panelPonude.Hide();
                    panelPretraga.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelOmiljenePonude.Location = new Point(this.panelOmiljenePonude.Location.X + 100, this.panelOmiljenePonude.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljenePonude);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);
                }
                else if (trenutnaOpcija == "rezervacije")
                {
                   
                    slajdRezervacije = "prosiren";
                    panelRezervisanje.Show();
                    panelPonude.Hide();
                    panelPretraga.Hide();
                    panelOmiljenePonude.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRezervisanje.Location = new Point(this.panelRezervisanje.Location.X + 100, this.panelRezervisanje.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervisanje);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacija.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                
                    slajdRecenzije = "prosiren";
                    panelRecenzije.Show();
                    panelPonude.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelPretraga.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

                }

                    LogoAnimator.ShowSync(Logo);
            }
            else//kad je slideMenu prosiren
            {

                    LogoAnimator.Hide(Logo);
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 50;
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

                if (trenutnaOpcija == "ponude")
                {
                    
                    slajdPonude = "uvucen";
                    panelPonude.Show();
                    panelPretraga.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X - 100, this.panelPonude.Location.Y);
                    PanelAnimator2.ShowSync(panelPonude);

                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
                }
                else if (trenutnaOpcija == "pretraga")
                {
                   
                    slajdPretraga = "uvucen";
                    panelPretraga.Show();
                    panelPonude.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPretraga.Location = new Point(this.panelPretraga.Location.X - 100, this.panelPretraga.Location.Y);
                    PanelAnimator2.ShowSync(panelPretraga);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPretraga.Location.Y);
                }
                else if (trenutnaOpcija == "omiljenePonude")
                {
               
                    slajdOmiljenePonude = "uvucen";
                    panelOmiljenePonude.Show();
                    panelPretraga.Hide();
                    panelPonude.Hide();
                    panelRezervisanje.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelOmiljenePonude.Location = new Point(this.panelOmiljenePonude.Location.X - 100, this.panelOmiljenePonude.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljenePonude);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);
                }
                else if (trenutnaOpcija == "rezervacije")
                {
                  
                    slajdRezervacije = "uvucen";
                    panelRezervisanje.Show();
                    panelPretraga.Hide();
                    panelPonude.Hide();
                    panelOmiljenePonude.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRezervisanje.Location = new Point(this.panelRezervisanje.Location.X - 100, this.panelRezervisanje.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervisanje);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacija.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                   
                    slajdRecenzije = "uvucen";
                    panelRecenzije.Show();
                    panelPonude.Hide();
                    panelOmiljenePonude.Hide();
                    panelRezervisanje.Hide();
                    panelPretraga.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);
                }
                   PanelAnimator.ShowSync(SlideMenu);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelPonude.Visible = true;
            this.panelPretraga.Visible = false;
            this.panelRezervisanje.Visible = false;
            this.panelOmiljenePonude.Visible = false;
            this.panelRecenzije.Visible = false;
            this.panelRezervacijeProduzavanja.Visible = false;
            this.labelKorisnik.Text = logovanIme + " " + logovanPrezime;

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
            this.buttonPonude_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secCount == 3)
            {
                labelWarning.Visible = false;
                secCount = 0;
                timer1.Stop();
            }
            else
            {
                labelWarning.Visible = true;
                secCount++;
            }
        }

        #endregion

        #region Ponude
        private void buttonPonude_Click(object sender, EventArgs e)
        {
            if (SlideMenu.Width == 50)
            {
                if (slajdPonude == "prosiren")
                {
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X - 100, this.panelPonude.Location.Y);
                    slajdPonude = "uvucen";
                }
            }
            else
            {
                if (slajdPonude == "uvucen")
                {
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X + 100, this.panelPonude.Location.Y);
                    slajdPonude = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
  
            trenutnaOpcija = "ponude";
            panelPretraga.Hide();
            panelOmiljenePonude.Hide();
            panelRezervisanje.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelPonude.Show();

            if(listaPonuda==null) //u suprotnom su unutra filtrirane ponude koje treba da prikaze
                listaPonuda = MongoProvider.vratiSvePonude();

            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.BringToFront();
            panelDetaljnijiPrikaz.Visible = false;
            popuniFlowPanelPonudama(listaPonuda);

        }

        public void popuniFlowPanelPonudama(List<Ponuda> listaPonuda)
        {
            flowLayoutPanel1.Controls.Clear();
            Label labelaPonisti = new Label();
            labelaPonisti.Font = new Font("Arial", 10, FontStyle.Underline);
            labelaPonisti.Click += new EventHandler(labelaPonisti_Click);
            labelaPonisti.Text = "Poništi filtere pretrage";
            labelaPonisti.ForeColor = Color.FromArgb(26, 32, 40);
            flowLayoutPanel1.Controls.Add(labelaPonisti);

            foreach (Ponuda p in listaPonuda)
            {
                ControlPonuda controlPonuda = new ControlPonuda();
                controlPonuda.setPicture(p.Slike[0]);
                controlPonuda.setDestinacija(p.Destinacija);
                controlPonuda.setPolazak(p.DatumPolaska);
                controlPonuda.setDani(p.BrojDana.ToString());
                controlPonuda.setNoci(p.BrojNoci.ToString());
                controlPonuda.setCena(p.CenaPoOsobi.ToString());
                controlPonuda.setTipPonude("(" + p.TipPonude + ")");
                controlPonuda.getButtonDetaljnije().Click += new EventHandler(buttonDetaljnije_Click);
                controlPonuda.setButtonDetaljnijeTag(p);
                flowLayoutPanel1.Controls.Add(controlPonuda);
            }
        }

        protected void labelaPonisti_Click(object sender, EventArgs e)
        {
            listaPonuda = null;
            buttonPonude_Click(sender, e);
        }

        protected void buttonDetaljnije_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton buttonDetaljnije = sender as Bunifu.Framework.UI.BunifuFlatButton;
            Ponuda p = (Ponuda)buttonDetaljnije.Tag;
            panelDetaljnijiPrikaz.Visible = true;
            panelDetaljnijiPrikaz.BringToFront();
            flowLayoutPanel1.Visible = false;
            btnPrikaziRecenzijePonude.Tag = p;
            slikeDetaljnijiPrikaz = new List<string>();
            slikeDetaljnijiPrikaz = p.Slike;
            indeksDetaljnijeSlike = 0;
            pictureBoxDetaljnije1.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + p.Slike[0]);
            pictureBoxDetaljnije2.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + p.Slike[1]);
            pictureBoxDetaljnije1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDetaljnije2.SizeMode = PictureBoxSizeMode.StretchImage;
            labelDetaljnijeDestinacija.Text = p.Destinacija;
            labelDetaljnijePolazak.Text = p.DatumPolaska;
            labelDetaljnijeNoci.Text = p.BrojNoci.ToString();
            labelDetaljnijeDani.Text = p.BrojDana.ToString();
            labelDetaljnijePrevoz.Text = p.Prevoz;
            labelDetaljnijeKategorija.Text = p.Kategorija;
            labelDetaljnijeHotel.Text = p.Hotel.NazivHotela;
            labelDetaljnijeCena.Text = p.CenaPoOsobi.ToString();
            labelDetaljnijeTipPonude.Text = p.TipPonude;
            switch(p.Hotel.BrojZvezdica)
            {
                case 1: labelDetaljnijeZvezdice.Text = "★";
                    break;
                case 2: labelDetaljnijeZvezdice.Text = "★★";
                    break;
                case 3: labelDetaljnijeZvezdice.Text = "★★★";
                    break;
                case 4: labelDetaljnijeZvezdice.Text = "★★★★";
                    break;
                case 5: labelDetaljnijeZvezdice.Text = "★★★★★";
                    break;
                default: labelDetaljnijeZvezdice.Text = string.Empty; 
                    break;
            }

            if(MongoProvider.vratiOmiljenuPonudu(logovanKorisnik._id,p._id)!=null)
            {
                btnOmiljenaPonuda.Text = "♥";
                labelOmiljenaPonuda.Text = "Omiljena ponuda";
                btnOmiljenaPonuda.Font = new Font(btnOmiljenaPonuda.Font.FontFamily, 26);
            }
            else
            {
                btnOmiljenaPonuda.Text = "♡";
                labelOmiljenaPonuda.Text = "Dodaj u omiljeno";
                btnOmiljenaPonuda.Font = new Font(btnOmiljenaPonuda.Font.FontFamily, 36);
            }

            btnOmiljenaPonuda.Tag = p;

        }

        private void labelNazad_Click(object sender, EventArgs e)
        {
            buttonPonude_Click(sender, e);
        }

        private void btnLeftPic_Click(object sender, EventArgs e)
        {
            if(indeksDetaljnijeSlike>0)
            {
                indeksDetaljnijeSlike--;
                pictureBoxDetaljnije2.Image = pictureBoxDetaljnije1.Image;
                pictureBoxDetaljnije1.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeDetaljnijiPrikaz[indeksDetaljnijeSlike]);
            }
        }

        private void btnRightPic_Click(object sender, EventArgs e)
        {
            if (indeksDetaljnijeSlike < slikeDetaljnijiPrikaz.Count-2)
            {
                indeksDetaljnijeSlike++;
                pictureBoxDetaljnije1.Image = pictureBoxDetaljnije2.Image;
                pictureBoxDetaljnije2.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeDetaljnijiPrikaz[indeksDetaljnijeSlike+1]);
            }
        }

        #endregion

        #region Pretraga

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "pretraga";
            panelPonude.Hide();
            panelOmiljenePonude.Hide();
            panelRezervisanje.Hide();
            this.panelRecenzije.Hide();
            this.panelRezervacijeProduzavanja.Hide();
            panelPretraga.Show();


            if (SlideMenu.Width == 50)
            {
                if (slajdPretraga == "prosiren")
                {
                    this.panelPretraga.Location = new Point(this.panelPretraga.Location.X - 100, this.panelPretraga.Location.Y);
                    slajdPretraga = "uvucen";
                }
            }
            else
            {
                if (slajdPretraga == "uvucen")
                {
                    this.panelPretraga.Location = new Point(this.panelPretraga.Location.X + 100, this.panelPretraga.Location.Y);
                    slajdPretraga = "prosiren";
                }
            }
            listaPonuda = null;

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPretraga.Location.Y);

            bunifuRangeCena_RangeChanged(sender, e);
            ocistiPretragu();
        }

        public void ocistiPretragu()
        {
            txtFilterDestinacija.Text = string.Empty;
            numFilterDaniOd.Value = 0;
            numFilterDaniDo.Value = 30;
            bunifuRangeCena.RangeMin = 0;
            bunifuRangeCena.RangeMax = 85;
            labFilterMinCena.Text = (bunifuRangeCena.RangeMin * 15).ToString();
            labFilterMaxCena.Text = (bunifuRangeCena.RangeMax * 15).ToString();
            dtpFilterDatumDo.Value = new DateTime(2020, 12, 31);
            dtpFilterDatumOd.Value = DateTime.Now; 
            cbxFilterKategorija.SelectedIndex = -1;
            cbxFilterKategorija.SelectedItem = string.Empty;
            cbxFilterPrevoz.SelectedIndex = -1;
            cbxFilterPrevoz.SelectedItem = string.Empty;
            cbxFilterTipPonude.SelectedIndex = -1;
            cbxFilterTipPonude.SelectedItem = string.Empty;
        }

        private void bunifuRangeCena_RangeChanged(object sender, EventArgs e)
        {
            labFilterMinCena.Text = (bunifuRangeCena.RangeMin * 15).ToString();
            labFilterMaxCena.Text = (bunifuRangeCena.RangeMax * 15).ToString();
        }

        private void btnPrimeniFiltere_Click(object sender, EventArgs e)
        {
            string destinacija = null ;
            string kategorija=null;
            string prevoz=null;
            string tipPonude=null;
            int minCena; int maxCena;
            int minDani; int maxDani;

            if (!string.IsNullOrEmpty(txtFilterDestinacija.Text))
                destinacija = txtFilterDestinacija.Text;
            if (cbxFilterKategorija.SelectedIndex>-1)
                kategorija = cbxFilterKategorija.SelectedItem.ToString();
            if (cbxFilterPrevoz.SelectedIndex> -1)
                prevoz = cbxFilterPrevoz.SelectedItem.ToString();
            if (cbxFilterTipPonude.SelectedIndex> -1)
                tipPonude = cbxFilterTipPonude.SelectedItem.ToString();
            minCena = Convert.ToInt32(labFilterMinCena.Text);
            maxCena = Convert.ToInt32(labFilterMaxCena.Text);
            minDani = Convert.ToInt32(numFilterDaniOd.Value);
            maxDani = Convert.ToInt32(numFilterDaniDo.Value);

            List<Ponuda> filtriranePonude = new List<Ponuda>();
            filtriranePonude = MongoProvider.pretraziPonude(destinacija, prevoz, kategorija, minDani, maxDani, minCena, maxCena, tipPonude);
            listaPonuda = filtriranePonude;

            listaPonuda.RemoveAll(p => DateTime.ParseExact(p.DatumPolaska, "dd-MM-yyyy", CultureInfo.InvariantCulture) < dtpFilterDatumOd.Value
                                            || DateTime.ParseExact(p.DatumPolaska, "dd-MM-yyyy", CultureInfo.InvariantCulture) > dtpFilterDatumDo.Value);
            
            buttonPonude_Click(sender, e);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ocistiPretragu();
        }

        #endregion

        #region Omiljene_Ponude

        private void buttonOmiljenePonude_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "omiljenePonude";
            panelPonude.Hide();
            panelPretraga.Hide();
            panelRezervisanje.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelOmiljenePonude.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOmiljenePonude == "prosiren")
                {
                    this.panelOmiljenePonude.Location = new Point(this.panelOmiljenePonude.Location.X - 150, this.panelOmiljenePonude.Location.Y);
                    slajdOmiljenePonude = "uvucen";
                }
            }
            else
            {
                if (slajdOmiljenePonude == "uvucen")
                {
                    this.panelOmiljenePonude.Location = new Point(this.panelOmiljenePonude.Location.X + 150, this.panelOmiljenePonude.Location.Y);
                    slajdOmiljenePonude = "prosiren";
                }
            }
            listaPonuda = null;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

            
            listaOmiljenihPonuda = MongoProvider.vratiSveKorisnikoveOmiljenePonude(logovanKorisnik._id);
            indeksOmiljenePonude = 0;
            if(listaOmiljenihPonuda.Count>0)
            slikeOmiljenePonude = listaOmiljenihPonuda[0].Slike;
            indeksSlikeOmiljenePonude = 0;

            prikaziOmiljenuPonudu();
     
        }

        public void prikaziOmiljenuPonudu()
        {
            if (listaOmiljenihPonuda.Count > 0)
            {
                pictureBoxOmiljena1.Visible = true;
                pictureBoxOmiljena2.Visible = true;
                btnOmiljenoSledecaPonuda.Visible = true;
                btnOmiljenoPrethodnaPonuda.Visible = true;
                btnOmiljenoUkloni.Visible = true;
                label49.Visible = true;
                label50.Visible = true;
                tableLayoutPanel2.Visible = true;
                btnOmiljenoLeftPic.Visible = true;
                btnOmiljenoRightPic.Visible = true;
                labelica.Visible = false;
                labelica.SendToBack();

                pictureBoxOmiljena1.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeOmiljenePonude[indeksSlikeOmiljenePonude]);
                pictureBoxOmiljena2.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeOmiljenePonude[indeksSlikeOmiljenePonude + 1]);
                Ponuda p = new Ponuda();
                p = listaOmiljenihPonuda[indeksOmiljenePonude];
                labOmiljenoDestinacija.Text = p.Destinacija;
                labOmiljenoKategorija.Text = p.Kategorija;
                labOmiljenoDatumPolaska.Text = p.DatumPolaska;
                labOmiljenoBrojDana.Text = p.BrojDana.ToString();
                labOmiljenoBrojNoci.Text = p.BrojNoci.ToString();
                labOmiljenoTipPonude.Text = p.TipPonude;
                labOmiljenoHotel.Text = p.Hotel.NazivHotela;
                switch (p.Hotel.BrojZvezdica)
                {
                    case 1:
                        labOmiljenoZvezdice.Text = "★";
                        break;
                    case 2:
                        labOmiljenoZvezdice.Text = "★★";
                        break;
                    case 3:
                        labOmiljenoZvezdice.Text = "★★★";
                        break;
                    case 4:
                        labOmiljenoZvezdice.Text = "★★★★";
                        break;
                    case 5:
                        labOmiljenoZvezdice.Text = "★★★★★";
                        break;
                    default:
                        labOmiljenoZvezdice.Text = string.Empty;
                        break;
                }
                labOmiljenoPrevoz.Text = p.Prevoz;
                labOmiljenoCena.Text = p.CenaPoOsobi.ToString();
                btnOmiljenoUkloni.Tag = p;
            }
            else
            {
                pictureBoxOmiljena1.Visible = false;
                pictureBoxOmiljena2.Visible = false;
                btnOmiljenoSledecaPonuda.Visible = false;
                btnOmiljenoPrethodnaPonuda.Visible =false;
                btnOmiljenoUkloni.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                tableLayoutPanel2.Visible = false;
                btnOmiljenoLeftPic.Visible = false;
                btnOmiljenoRightPic.Visible = false;
                labelica.Visible = true;
                labelica.BringToFront();
            }
        }

        private void btnOmiljenoLeftPic_Click(object sender, EventArgs e)
        {
            if (indeksSlikeOmiljenePonude > 0 && listaOmiljenihPonuda.Count>0)
            {
                indeksSlikeOmiljenePonude--;
                pictureBoxOmiljena2.Image = pictureBoxOmiljena1.Image;
                pictureBoxOmiljena1.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeOmiljenePonude[indeksSlikeOmiljenePonude]);
            }
        }

        private void btnOmiljenoRightPic_Click(object sender, EventArgs e)
        {
            if (indeksSlikeOmiljenePonude < slikeOmiljenePonude.Count - 2 && listaOmiljenihPonuda.Count>0)
            {
                indeksSlikeOmiljenePonude++;
                pictureBoxOmiljena1.Image = pictureBoxOmiljena2.Image;
                pictureBoxOmiljena2.Image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slikeOmiljenePonude[indeksSlikeOmiljenePonude+1]);
            }
        }

        private void btnOmiljenoPrethodnaPonuda_Click(object sender, EventArgs e)
        {
            if (indeksOmiljenePonude > 0 && listaOmiljenihPonuda.Count > 0)
            {
                indeksOmiljenePonude--;
                listaOmiljenihPonuda = MongoProvider.vratiSveKorisnikoveOmiljenePonude(logovanKorisnik._id);
                slikeOmiljenePonude = listaOmiljenihPonuda[indeksOmiljenePonude].Slike;
                indeksSlikeOmiljenePonude = 0;
                prikaziOmiljenuPonudu();
            }
        }

        private void btnOmiljenoSledecaPonuda_Click(object sender, EventArgs e)
        {
            if (indeksOmiljenePonude < listaOmiljenihPonuda.Count-1 && listaOmiljenihPonuda.Count > 0)
            {
                indeksOmiljenePonude++;
                listaOmiljenihPonuda = MongoProvider.vratiSveKorisnikoveOmiljenePonude(logovanKorisnik._id);
                slikeOmiljenePonude = listaOmiljenihPonuda[indeksOmiljenePonude].Slike;
                indeksSlikeOmiljenePonude = 0;
                prikaziOmiljenuPonudu();
            }
        }

        private void btnOmiljenoUkloni_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)btnOmiljenoUkloni.Tag;
            MongoProvider.obrisiOmiljenuPonudu(MongoProvider.vratiOmiljenuPonudu(logovanKorisnik._id,p._id));
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uklonjeno iz omiljenog";
            secCount = 0;
            timer1.Start();
            buttonOmiljenePonude_Click(sender, e);
        }

        private void btnOmiljenaPonuda_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)btnOmiljenaPonuda.Tag;
            if (labelOmiljenaPonuda.Text == "Dodaj u omiljeno")
            {
                btnOmiljenaPonuda.Text = "♥";
                labelOmiljenaPonuda.Text = "Omiljena ponuda";
                btnOmiljenaPonuda.Font = new Font(btnOmiljenaPonuda.Font.FontFamily, 26);
                Omiljeno o = new Omiljeno();
                o.Korisnik = new MongoDBRef("Korisnici", logovanKorisnik._id);
                o.Ponuda = new MongoDBRef("Ponude", p._id);
                MongoProvider.dodajOmiljenuPonudu(o);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Dodato u omiljeno";
                secCount = 0;
                timer1.Start();
            }
            else if (labelOmiljenaPonuda.Text == "Omiljena ponuda")
            {
                btnOmiljenaPonuda.Text = "♡";
                btnOmiljenaPonuda.Font = new Font(btnOmiljenaPonuda.Font.FontFamily, 36);
                labelOmiljenaPonuda.Text = "Dodaj u omiljeno";
                Omiljeno o = new Omiljeno();
                o = MongoProvider.vratiOmiljenuPonudu(logovanKorisnik._id, p._id);
                MongoProvider.obrisiOmiljenuPonudu(o);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uklonjeno iz omiljenog";
                secCount = 0;
                timer1.Start();
            }
        }

        #endregion

        #region Recenzije

        private void buttonRecenzije_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "recenzije";
            panelPonude.Hide();
            panelOmiljenePonude.Hide();
            panelRezervisanje.Hide();
            panelPretraga.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelRecenzije.Show();


            if (SlideMenu.Width == 50)
            {
                if (slajdRecenzije == "prosiren")
                {
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    slajdRecenzije = "uvucen";
                }
            }
            else
            {
                if (slajdRecenzije == "uvucen")
                {
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    slajdRecenzije = "prosiren";
                }
            }

            listaPonuda = null;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

            if(detaljiRecenzije==false)
                panelDataGridRecenzije.Visible = true;
            else
                panelDataGridRecenzije.Visible = false;

            panelDataGridRecenzije.BringToFront();
            panelSveRecenzije.Visible = false;
            panelNapisiRecenziju.Visible = false;
            dataGridRecenzije.Rows.Clear();

            foreach (Ponuda k in MongoProvider.vratiSvePonude())
            {
                dataGridRecenzije.Rows.Add(k.Destinacija, k.Kategorija, k.DatumPolaska, k.Hotel.NazivHotela,k.CenaPoOsobi, k.Prevoz);
            }

            dataGridRecenzije.Refresh();
        }

        private void dataGridRecenzije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ponuda p = MongoProvider.vratiPonudu(dataGridRecenzije.CurrentRow.Cells[0].Value.ToString(), dataGridRecenzije.CurrentRow.Cells[3].Value.ToString(), dataGridRecenzije.CurrentRow.Cells[2].Value.ToString());
            prikaziSveRecenzijeZaPonudu(p);
        }

        public void prikaziSveRecenzijeZaPonudu(Ponuda p)
        {
            panelSveRecenzije.Visible = true;
            panelSveRecenzije.BringToFront();
            panelDataGridRecenzije.Visible = false;
            panelNapisiRecenziju.Visible = false;
            flowLayoutPanelRecenzije.Controls.Clear();
            List<Recenzija> listaRecenzija = MongoProvider.vratiSveRecenzijeZaPonudu(p._id);
            foreach (Recenzija r in listaRecenzija)
            {
                ControlRecenzija controlRecenzija = new ControlRecenzija();
                Korisnik k = MongoProvider.vratiAutoraRecenzije(r._id);
                controlRecenzija.setAutor(k.Ime + " " + k.Prezime);
                controlRecenzija.setDatum(r.Datum.ToString("dd-MM-yyyy"));
                controlRecenzija.setRecenzija(r.TekstRecenzije);
                flowLayoutPanelRecenzije.Controls.Add(controlRecenzija);
            }
            flowLayoutPanelRecenzije.Refresh();
            btnNapisiRecenziju.Tag = p;
        }

        private void btnNapisiRecenziju_Click(object sender, EventArgs e)
        {
            panelNapisiRecenziju.Visible = true;
            panelNapisiRecenziju.BringToFront();
            panelDataGridRecenzije.Visible = false;
            panelSveRecenzije.Visible = true;
            flowLayoutPanelRecenzije.Visible = false;
            labelAutor.Text = logovanIme + " " + logovanPrezime;
            labelDatum.Text = DateTime.Now.ToString("dd-MM-yyyy");
            richTextBox.Text = string.Empty;
        }

        private void btnDodajRecenziju_Click(object sender, EventArgs e)
        {
            Recenzija rec = new Recenzija();
            rec.TekstRecenzije = richTextBox.Text;
            rec.Datum = DateTime.Now;
            rec.Korisnik = new MongoDBRef("Korisnici", logovanKorisnik._id);
            rec.Ponuda = new MongoDBRef("Ponude", ((Ponuda)btnNapisiRecenziju.Tag)._id);
            if(!string.IsNullOrEmpty(rec.TekstRecenzije))
            {
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Recenzija dodata";
                secCount = 0;
                MongoProvider.dodajRecenziju(rec);
                panelNapisiRecenziju.Visible = false;
                panelSveRecenzije.Visible = true;
                flowLayoutPanelRecenzije.Visible = true;
                panelDataGridRecenzije.Visible = false;
                prikaziSveRecenzijeZaPonudu((Ponuda)btnNapisiRecenziju.Tag);
                timer1.Start();
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokusajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void btnPrikaziRecenzijePonude_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)btnPrikaziRecenzijePonude.Tag;
            detaljiRecenzije = true;
            buttonRecenzije_Click(sender, e);
            detaljiRecenzije = false;
            prikaziSveRecenzijeZaPonudu(p);
            btnNapisiRecenziju.Tag = p;
        }

        #endregion

        #region Rezervacije

        private void buttonRezervacija_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "rezervacije";
            panelPonude.Hide();
            panelPretraga.Hide();
            panelOmiljenePonude.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelRezervisanje.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdRezervacije == "prosiren")
                {
                    this.panelRezervisanje.Location = new Point(this.panelRezervisanje.Location.X - 100, this.panelRezervisanje.Location.Y);
                    slajdRezervacije = "uvucen";
                }
            }
            else
            {
                if (slajdRezervacije == "uvucen")
                {
                    this.panelRezervisanje.Location = new Point(this.panelRezervisanje.Location.X + 100, this.panelRezervisanje.Location.Y);
                    slajdRezervacije = "prosiren";
                }
            }

            listaPonuda = null;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacija.Location.Y);

            if (detaljiRezervacije== false)
                panelDataGridRezervacije.Visible = true;
            else
                panelDataGridRezervacije.Visible = false;

            panelDataGridRezervacije.BringToFront();
            panelRezervisiPonudu.Visible = false;
            dataGridViewPonudeRezervacije.Rows.Clear();

            foreach (Ponuda k in MongoProvider.vratiSvePonude())
            {
                dataGridViewPonudeRezervacije.Rows.Add(k.Destinacija, k.Kategorija, k.DatumPolaska, k.Hotel.NazivHotela, k.CenaPoOsobi, k.Prevoz);
            }

            dataGridViewPonudeRezervacije.Refresh();
        }

        private void dataGridViewPonudeRezervacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ponuda p = MongoProvider.vratiPonudu(dataGridViewPonudeRezervacije.CurrentRow.Cells[0].Value.ToString(), dataGridViewPonudeRezervacije.CurrentRow.Cells[3].Value.ToString(), dataGridViewPonudeRezervacije.CurrentRow.Cells[2].Value.ToString());
            prikaziPonuduKojaSeRezervise(p);
        }

        public void prikaziPonuduKojaSeRezervise(Ponuda p)
        {
            panelDataGridRezervacije.Visible = false;
            panelRezervisiPonudu.Visible = true;
            panelRezervisiPonudu.BringToFront();

            labelRezervisiDestinacija.Text = p.Destinacija;
            labelRezervisiKategorija.Text = p.Kategorija;
            labelRezervisiDatumPolaska.Text = p.DatumPolaska;
            labelRezervisiBrojDana.Text = p.BrojDana.ToString();
            labelRezervisiBrojNoci.Text = p.BrojNoci.ToString();
            labelRezervisiTipPonude.Text = p.TipPonude;
            labelRezervisiHotel.Text = p.Hotel.NazivHotela;
            switch (p.Hotel.BrojZvezdica)
            {
                case 1: labelRezervisiZvezdice.Text = "★";
                    break;
                case 2: labelRezervisiZvezdice.Text = "★★";
                    break;
                case 3: labelRezervisiZvezdice.Text = "★★★";
                    break;
                case 4: labelRezervisiZvezdice.Text = "★★★★";
                    break;
                case 5: labelRezervisiZvezdice.Text = "★★★★★";
                    break;
                default: labelRezervisiZvezdice.Text = string.Empty;
                    break;
            }
            labelRezervisiPrevoz.Text = p.Prevoz;
            labelRezervisiCenaPoOsobi.Text = p.CenaPoOsobi.ToString();
            labelRezervisiUkupnaCena.Text = p.CenaPoOsobi.ToString();
            panelRezervisiPonudu.Tag = p;

            Rezervacija r=MongoProvider.vratiRezervaciju(logovanKorisnik._id,p._id);
            if(r!=null)
            {
                if(r.Soba=="jednokrevetna")
                {
                    rdbJednokrevetna.Checked = true;
                    labelRezervisiUkupnaCena.Text = p.CenaPoOsobi.ToString();
                }
                else if(r.Soba=="dvokrevetna")
                {
                    rdbDvokrevetna.Checked = true;
                    labelRezervisiUkupnaCena.Text = (p.CenaPoOsobi*2).ToString();
                }
                else if(r.Soba=="trokrevetna")
                {
                    rdbTrokrevetna.Checked = true;
                    labelRezervisiUkupnaCena.Text = (p.CenaPoOsobi*3).ToString();
                }
                else if(r.Soba=="cetvorokrevetna")
                {
                    rdbCetvorokrevetna.Checked = true;
                    labelRezervisiUkupnaCena.Text = (p.CenaPoOsobi*4).ToString();
                }

                btnIzvrsiRezervaciju.Text = "Otkaži rezervaciju";
                btnIzvrsiRezervaciju.BackColor = Color.Maroon;
                btnIzvrsiRezervaciju.OnHovercolor = Color.Red;
                btnIzvrsiRezervaciju.Normalcolor = Color.Maroon;
                btnIzvrsiRezervaciju.Activecolor = Color.Maroon;
            }
            else
            {
                rdbJednokrevetna.Checked = true;
                labelRezervisiUkupnaCena.Text = p.CenaPoOsobi.ToString();
                btnIzvrsiRezervaciju.Text = "Izvrši rezervaciju";
                btnIzvrsiRezervaciju.BackColor = Color.FromArgb(46, 139, 87);
                btnIzvrsiRezervaciju.OnHovercolor = Color.FromArgb(36,129, 87);
                btnIzvrsiRezervaciju.Normalcolor = Color.FromArgb(46, 139, 87);
                btnIzvrsiRezervaciju.Activecolor = Color.FromArgb(46, 139, 87);
            }
        }

        private void rdbJednokrevetna_CheckedChanged(object sender, EventArgs e)
        {
            int cenaPoOsobi = ((Ponuda)panelRezervisiPonudu.Tag).CenaPoOsobi;
            if (rdbJednokrevetna.Checked)
                labelRezervisiUkupnaCena.Text = cenaPoOsobi.ToString();
            else if (rdbDvokrevetna.Checked)
                labelRezervisiUkupnaCena.Text = (cenaPoOsobi * 2).ToString();
            else if (rdbTrokrevetna.Checked)
                labelRezervisiUkupnaCena.Text = (cenaPoOsobi * 3).ToString();
            else if (rdbCetvorokrevetna.Checked)
                labelRezervisiUkupnaCena.Text = (cenaPoOsobi * 4).ToString();
        }

        private void btnIzvrsiRezervaciju_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)panelRezervisiPonudu.Tag;

            if(btnIzvrsiRezervaciju.Text=="Otkaži rezervaciju")
            {
                Rezervacija r= MongoProvider.vratiRezervaciju(logovanKorisnik._id,p._id);
                Ponuda stara = MongoProvider.vratiRezervisanuPonudu(r._id);
                Ponuda nova = stara;
                if (r.Soba == "jednokrevetna")
                {
                    nova.Hotel.BrojJednokrevetnih = stara.Hotel.BrojJednokrevetnih + 1;
                }
                else if (r.Soba == "dvokrevetna")
                {
                    nova.Hotel.BrojDvokrevetnih = stara.Hotel.BrojDvokrevetnih + 1;
                }
                else if(r.Soba=="trokrevetna")
                {
                    nova.Hotel.BrojTrokrevetnih = stara.Hotel.BrojTrokrevetnih + 1;
                }
                else if(r.Soba=="cetvorokrevetna")
                {
                    nova.Hotel.BrojCetvorokrevetnih = stara.Hotel.BrojCetvorokrevetnih + 1;
                }
                MongoProvider.obrisiRezervaciju(r);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Rezervacija otkazana";
                secCount = 0;
                timer1.Start();
                MongoProvider.azurirajPonudu(stara, nova);
            }
            else if(btnIzvrsiRezervaciju.Text=="Izvrši rezervaciju")
            {
                Rezervacija r = new Rezervacija();
                r.Korisnik = new MongoDBRef("Korisnici", logovanKorisnik._id);
                r.Ponuda = new MongoDBRef("Ponude", p._id);
                r.DatumRezervisanja = DateTime.Now;
                Ponuda novaPonuda=p;
                if (rdbJednokrevetna.Checked) 
                { 
                    r.Soba = "jednokrevetna"; 
                    novaPonuda.Hotel.BrojJednokrevetnih=p.Hotel.BrojJednokrevetnih-1;
                }
                else if (rdbDvokrevetna.Checked) 
                {
                    r.Soba = "dvokrevetna";
                    novaPonuda.Hotel.BrojDvokrevetnih = p.Hotel.BrojDvokrevetnih - 1;
                }
                else if (rdbTrokrevetna.Checked) 
                { 
                    r.Soba = "trokrevetna";
                    novaPonuda.Hotel.BrojTrokrevetnih = p.Hotel.BrojTrokrevetnih - 1;
                }
                else if (rdbCetvorokrevetna.Checked) 
                { 
                    r.Soba = "cetvorokrevetna"; 
                    novaPonuda.Hotel.BrojCetvorokrevetnih = p.Hotel.BrojCetvorokrevetnih - 1;
                }
                else
                {
                    r.Soba = "jednokrevetna";
                    novaPonuda.Hotel.BrojJednokrevetnih = p.Hotel.BrojJednokrevetnih - 1;
                }

                if((r.Soba=="jednokrevetna" && p.Hotel.BrojJednokrevetnih<=0)
                    || (r.Soba == "dvokrevetna" && p.Hotel.BrojDvokrevetnih <= 0)
                    || (r.Soba == "trokrevetna" && p.Hotel.BrojTrokrevetnih <= 0)
                    || (r.Soba == "cetvorokrevetna" && p.Hotel.BrojCetvorokrevetnih <= 0))
                {
                    MongoProvider.dodajRezervaciju(r);
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Nema tražene sobe.";
                    secCount = 0;
                    timer1.Start();
                }
                else
                {
                    MongoProvider.dodajRezervaciju(r);
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Uspešna rezervacija";
                    secCount = 0;
                    timer1.Start();

                    MongoProvider.azurirajPonudu(p, novaPonuda);
                }
            }

            prikaziPonuduKojaSeRezervise(p);
        }

        private void btnDetaljnijeRezervacija_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)btnPrikaziRecenzijePonude.Tag;
            detaljiRezervacije = true;
            buttonRezervacija_Click(sender, e);
            detaljiRezervacije = false;
            prikaziPonuduKojaSeRezervise(p);
        }

        #endregion

    }
}
