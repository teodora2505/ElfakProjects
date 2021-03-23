using Elektronski_Parking_Sistem.Podaci;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Elektronski_Parking_Sistem
{
    public partial class Form1 : Form
    {
        public bool logovan = false;
        public string zaposlenLog;
        public string zaposlenIme;
        public string trenutnaOpcija = "logovanje";//"logovanje","garaze"
        public bool slideMenuExpanded = true;

        List<PictureBox> listaPicBox = new List<PictureBox>();
        int index;//pokazivac trenutnog picBoxa u panelu
        int indexTrenutneGaraze = 1;
        Baza baza = new Baza();

        Garaza1 garaza1 = new Garaza1();//forma za Garazu1
        Garaza2 garaza2 = new Garaza2();//forma za Garazu2
        Garaza3 garaza3 = new Garaza3();//forma za Garazu3

        ParkingServis parkingServis = new ParkingServis();

        public List<Image> AutomobiliSlike = new List<Image>();
        public List<Image> AutobusiSlike = new List<Image>();
        public List<Image> KamioniSlike = new List<Image>();

        public int brSekundi = 0;
        public string trenutniKorisnik;
        public string AddChangeDelete = null;

        public string IzmeniRadnikStaroIme;
        public string IzmeniRadnikStaraSifra;
        public Random rnd = new Random();

        public string slajdLogovanje = "prosiren";
        public string slajdGaraze = "prosiren";
        public string slajdIstorijaParkiranja = "prosiren";
        public string slajdUsluge = "prosiren";
        public string slajdStatistika = "prosiren";
        public string slajdRezervacijeProduzavanje = "prosiren";
        public string slajdPreostaloVreme = "prosiren";
        //cuvaju info o vozilu koje je izabrano za izmenu, informacije pre izmene
        public DateTime izmenaPocetakParkiranja = DateTime.Now;
        public DateTime izmenaKrajParkiranja = DateTime.Now;
        public int izmenaUsluga = 0;
        public int izmenaRacun = 0;
        public string izmenaTip = "";
        public bool izmenaInvalid = false;
        public string izmenaRegistracija = "";
        // to je sve za izmenu sto pamtimo
        public string brisanjeGaraza;
        public string brisanjeMesto;
        //ako je pri izmeni menjana pozicija vozila da znamo sa koje da ga uklonimo

        bool istorijaParkiranjaDatumOdKliknut = false;
        bool istorijaParkiranjaDatumDoKliknut = false;
        bool istorijaPocetakPreskoci = false;
        bool istorijaKrajPreskoci = false;
        


        public Form1()
        {
            InitializeComponent();
            this.ucitajSlike();

        }

       /* protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }*/

        private void bunifuImageButton2_Click(object sender, EventArgs e)// Dugme X za zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Dugme za minimizaciju forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void ucitajSlike()
        {
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto1);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto2);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto3);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto4);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto5);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto6);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto7);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto8);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto9);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto10);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto11);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto12);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto13);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto14);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto15);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto16);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto17);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto18);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto19);
            AutomobiliSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.auto20);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus1);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus2);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus3);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus4);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus5);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus6);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus7);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus8);
            AutobusiSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.bus9);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion1);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion2);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion3);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion4);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion5);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion6);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion7);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion8);
            KamioniSlike.Add(Elektronski_Parking_Sistem.Properties.Resources.kamion9);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideMenuExpanded = !slideMenuExpanded;
            if (SlideMenu.Width == 50)//kad je slideMenu uvucen
            {
                if(trenutnaOpcija!= "istorijaParkiranja") //UVEK SE IZVRSAVA SEM NA ISTORIJUPARKIRANJA KAD JE SVE UVUCENO I NEMA UVLACENJA-IZVLACENJA SLIDEMENUJA
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonIstorijaParkiranja.Location.Y);
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 200;
                    PanelAnimator.ShowSync(SlideMenu);
                }
                
                if (trenutnaOpcija == "logovanje")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonLogovanje.Location.Y);
                    slajdLogovanje = "prosiren";
                    panelLogovanje.Show();
                    panelGaraze.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelLogovanje.Location = new Point(this.panelLogovanje.Location.X + 100, this.panelLogovanje.Location.Y);
                    PanelAnimator2.ShowSync(panelLogovanje);

                }
                else if (trenutnaOpcija == "garaze")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonGaraze.Location.Y);
                    slajdGaraze = "prosiren";
                    panelGaraze.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelGaraze.Location = new Point(this.panelGaraze.Location.X + 100, this.panelGaraze.Location.Y);
                    PanelAnimator2.ShowSync(panelGaraze);

                }
                /*else if(trenutnaOpcija=="istorijaParkiranja")
                {
                    slajdIstorijaParkiranja = "prosiren";
                    panelIstorijaParkiranja.Show();
                    panelLogovanje.Hide();
                    panelGaraze.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelIstorijaParkiranja.Location = new Point(this.panelIstorijaParkiranja.Location.X + 100, this.panelIstorijaParkiranja.Location.Y);
                    PanelAnimator2.ShowSync(panelIstorijaParkiranja);
                }*/
                else if (trenutnaOpcija=="usluge")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUsluge.Location.Y);
                    slajdUsluge = "prosiren";
                    panelUsluge.Show();
                    panelLogovanje.Hide();
                    panelGaraze.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelUsluge.Location = new Point(this.panelUsluge.Location.X + 100, this.panelUsluge.Location.Y);
                    PanelAnimator2.ShowSync(panelUsluge);
                }
                else if (trenutnaOpcija == "statistika")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonStatistika.Location.Y);
                    slajdStatistika = "prosiren";
                    panelStatistika.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelStatistika.Location = new Point(this.panelStatistika.Location.X + 100, this.panelStatistika.Location.Y);
                    PanelAnimator2.ShowSync(panelStatistika);

                }
                else if(trenutnaOpcija=="rezervacijeproduzavanje")
                {
                    if(buttonRezervacije.selected==true)
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacije.Location.Y);
                    else
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonProduzavanje.Location.Y);
                    slajdRezervacijeProduzavanje = "prosiren";
                    panelRezervacijeProduzavanja.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelStatistika.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X + 100, this.panelRezervacijeProduzavanja.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervacijeProduzavanja);
                }
                else if (trenutnaOpcija == "preostalovreme")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreostaloVreme.Location.Y);
                    slajdPreostaloVreme = "prosiren";
                    panelPreostaloVreme.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelStatistika.Hide();
                    this.panelPreostaloVreme.Location = new Point(this.panelPreostaloVreme.Location.X + 100, this.panelPreostaloVreme.Location.Y);
                    PanelAnimator2.ShowSync(panelPreostaloVreme);
                }

                if (trenutnaOpcija != "istorijaParkiranja")
                    LogoAnimator.ShowSync(Logo);
            }
            else//kad je slideMenu prosiren
            {
                if(trenutnaOpcija!="istorijaParkiranja")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonIstorijaParkiranja.Location.Y);
                    LogoAnimator.Hide(Logo);
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 50;
                }
              
                if (trenutnaOpcija == "logovanje")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonLogovanje.Location.Y);
                    slajdLogovanje = "uvucen";
                    panelLogovanje.Show();
                    panelGaraze.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelLogovanje.Location = new Point(this.panelLogovanje.Location.X - 100, this.panelLogovanje.Location.Y);
                    PanelAnimator2.ShowSync(panelLogovanje);


                }
                else if (trenutnaOpcija == "garaze")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonGaraze.Location.Y);
                    slajdGaraze = "uvucen";
                    panelGaraze.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelGaraze.Location = new Point(this.panelGaraze.Location.X - 100, this.panelGaraze.Location.Y);
                    PanelAnimator2.ShowSync(panelGaraze);

                }/*
                else if (trenutnaOpcija == "istorijaParkiranja")
                {
                    slajdIstorijaParkiranja = "uvucen";
                    panelIstorijaParkiranja.Show();
                    panelGaraze.Hide();
                    panelLogovanje.Hide();
                    panelUsluge.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelIstorijaParkiranja.Location = new Point(this.panelIstorijaParkiranja.Location.X - 100, this.panelIstorijaParkiranja.Location.Y);
                    PanelAnimator2.ShowSync(panelIstorijaParkiranja);

                }*/
                else if(trenutnaOpcija=="usluge")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUsluge.Location.Y);
                    slajdUsluge = "uvucen";
                    panelUsluge.Show();
                    panelGaraze.Hide();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelStatistika.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelUsluge.Location = new Point(this.panelUsluge.Location.X - 100, this.panelUsluge.Location.Y);
                    PanelAnimator2.ShowSync(panelUsluge);
                }
                else if (trenutnaOpcija == "statistika")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonStatistika.Location.Y);
                    slajdStatistika = "uvucen";
                    panelStatistika.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelStatistika.Location = new Point(this.panelStatistika.Location.X - 100, this.panelStatistika.Location.Y);
                    PanelAnimator2.ShowSync(panelStatistika);

                }
                else if(trenutnaOpcija== "rezervacijeproduzavanje")
                {
                    if (buttonRezervacije.selected == true)
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacije.Location.Y);
                    else
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonProduzavanje.Location.Y);
                    slajdRezervacijeProduzavanje = "prosiren";
                    slajdRezervacijeProduzavanje = "uvucen";
                    panelRezervacijeProduzavanja.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelStatistika.Hide();
                    panelPreostaloVreme.Hide();
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X - 100, this.panelRezervacijeProduzavanja.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervacijeProduzavanja);
                }
                else if(trenutnaOpcija=="preostalovreme")
                {
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreostaloVreme.Location.Y);
                    slajdPreostaloVreme = "uvucen";
                    panelPreostaloVreme.Show();
                    panelLogovanje.Hide();
                    panelIstorijaParkiranja.Hide();
                    panelUsluge.Hide();
                    panelGaraze.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    panelStatistika.Hide();
                    this.panelPreostaloVreme.Location = new Point(this.panelPreostaloVreme.Location.X - 100, this.panelPreostaloVreme.Location.Y);
                    PanelAnimator2.ShowSync(panelPreostaloVreme);
                }

                if (trenutnaOpcija != "istorijaParkiranja")
                    PanelAnimator.ShowSync(SlideMenu);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> lista = this.baza.CeneSniznjaPopusti();

            this.panelLogovanje.Visible = true;
            this.panelGaraze.Visible = false;
            this.panelUsluge.Visible = false;
            this.panelIstorijaParkiranja.Visible = false;
            this.panelStatistika.Visible = false;
            this.panelRezervacijeProduzavanja.Visible = false;
            this.panelPreostaloVreme.Visible = false;

            this.labelPozicija.Text = "Potrebno je da se ulogujete.";
            garaza1.myForm = this;
            garaza2.myForm = this;
            garaza3.myForm = this;

            listaPicBox.Add(picBoxGaraza1);
            listaPicBox.Add(picBoxGaraza2);
            listaPicBox.Add(picBoxGaraza3);
            listaPicBox[index].BringToFront();

            slikaDodaj.Visible = false;
            slikaUkloni.Visible = false;
            slikaIzmeni.Visible = false;
            cbxPozicija.Visible = false;
            btnIzmeniDalje.Visible = false;
            labelDodaj.Visible = false;
            labelIzmeni.Visible = false;
            labelUkloni.Visible = false;
            btnDodajRadnika.Visible = false;
            btnIzmeniRadnika.Visible = false;
            btnUkloniRadnika.Visible = false;

            buttonGaraze.Enabled = false;
            buttonIstorijaParkiranja.Enabled = false;
            buttonUsluge.Enabled = false;
            buttonPreostaloVreme.Enabled = false;
            
            buttonUsluge.Enabled = false;
            buttonStatistika.Enabled = false;
            buttonRezervacije.Enabled = false;
            buttonProduzavanje.Enabled = false;

            labelSelectedButton.Location= new Point(SlideMenu.Width-3, buttonLogovanje.Location.Y);
           

            groupBoxDodajVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = false;

            if(baza.ucitajAktivnost()!=null)
            {
               foreach(string aktivnost in baza.ucitajAktivnost())
                {
                    this.AppendTextInfo(aktivnost, Color.White, true, true);
                }
            }

            this.ucitajParkiranaVozila();
        }

        public void ucitajParkiranaVozila()
        {
            if (baza.parkiranaVozila() != null)
            {
                foreach (ParkingMesto p in baza.parkiranaVozila())
                {

                    if (p.BrGaraze == 1)
                    {
                        parkingServis.ListaGaraza[0].ListaParkingMesta[p.Broj - 1] = p;
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            garaza1.listaParkingMesta[p.Broj - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza1.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            garaza1.listaParkingMesta[p.Broj - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else
                        {
                            garaza1.listaParkingMesta[p.Broj - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                    }
                    else if (p.BrGaraze == 2)
                    {
                        parkingServis.ListaGaraza[1].ListaParkingMesta[p.Broj - 1] = p;
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            garaza2.listaParkingMesta[p.Broj - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza2.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            garaza2.listaParkingMesta[p.Broj - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else
                        {
                            garaza2.listaParkingMesta[p.Broj - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }

                    }
                    else if (p.BrGaraze == 3)
                    {
                        parkingServis.ListaGaraza[2].ListaParkingMesta[p.Broj - 1] = p;
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            garaza3.listaParkingMesta[p.Broj - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza3.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            garaza3.listaParkingMesta[p.Broj - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                        else
                        {
                            garaza3.listaParkingMesta[p.Broj - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[p.Broj - 1].Tag = p.Vozilo;
                        }
                    }
                    else { }
                }
            }
        }

        #region LOGOVANJE_ODJAVA
        private void buttonLogovanje_Click(object sender, EventArgs e)//dugme Logovanje u SlideMenu-ju
        {
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonLogovanje.Location.Y);

            if (SlideMenu.Width == 50)
            {
                if (slajdLogovanje == "prosiren")
                {
                    this.panelLogovanje.Location = new Point(this.panelLogovanje.Location.X - 100, this.panelLogovanje.Location.Y);
                    slajdLogovanje = "uvucen";
                }
            }
            else
            {
                if (slajdLogovanje == "uvucen")
                {
                    this.panelLogovanje.Location = new Point(this.panelLogovanje.Location.X + 100, this.panelLogovanje.Location.Y);
                    slajdLogovanje = "prosiren";
                }
            }
            trenutnaOpcija = "logovanje";
            panelGaraze.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            panelStatistika.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelPreostaloVreme.Hide();
            panelLogovanje.Show();
            buttonLog.Visible = true;
            label1.Text = "Korisničko ime";
            label2.Text = "Šifra";
            buttonLog.Text = "Loguj se";
            if (zaposlenLog == "menadzer")
            {
                labelDodaj.ForeColor = Color.White;
                labelIzmeni.ForeColor = Color.White;
                labelUkloni.ForeColor = Color.White;
                slikaLogovanje.Visible = true;
                slikaDodaj.Visible = false;
                slikaIzmeni.Visible = false;
                slikaUkloni.Visible = false;
                btnDodajRadnika.Visible = true;
                btnUkloniRadnika.Visible = true;
                btnIzmeniRadnika.Visible = true;
                cbxPozicija.Visible = false;
                btnIzmeniDalje.Visible = false;

            }
            if (logovan == true)
                buttonLog.Visible = false;

            buttonOdjavi.Visible = true;
            buttonLog.Text = "Loguj se";

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {

            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            if (AddChangeDelete == null)
            {
                if (baza.provera_zaposlenog(user, pass) == "menadzer")
                {
                    labelPozicija.Text = "Pozicija: " + "Menadžer";
                    labelKorisnik.Text = "Korisnik: " + user;
                    logovan = true;
                    zaposlenLog = "menadzer";
                    zaposlenIme = user;
                    labelDodaj.ForeColor = Color.White;
                    labelIzmeni.ForeColor = Color.White;
                    labelUkloni.ForeColor = Color.White;
                    slikaLogovanje.Visible = true;
                    slikaDodaj.Visible = false;
                    slikaIzmeni.Visible = false;
                    slikaUkloni.Visible = false;
                    btnDodajRadnika.Visible = true;
                    btnUkloniRadnika.Visible = true;
                    btnIzmeniRadnika.Visible = true;
                    cbxPozicija.Visible = false;
                    btnIzmeniDalje.Visible = false;
                    labelDodaj.Visible = true;
                    labelIzmeni.Visible = true;
                    labelUkloni.Visible = true;
                    trenutniKorisnik = user;
                    buttonLog.Visible = false;

                }
                else if (baza.provera_zaposlenog(user, pass) == "radnik")
                {
                    labelPozicija.Text = "Pozicija: " + "Radnik";
                    labelKorisnik.Text = "Korisnik: " + user;
                    logovan = true;
                    zaposlenLog = "radnik";
                    zaposlenIme = user;
                    trenutniKorisnik = user;
                    buttonLog.Visible = false;

                }
                else
                {
                    labelPozicija.Text = "Greška. Pokušajte ponovo.";
                    labelKorisnik.Text = "";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    timer1.Start();
                    buttonLog.Visible = true;
                }
            }
            else if (AddChangeDelete == "Add")
            {
                if (user!="" && pass!="" && cbxPozicija.SelectedIndex>-1)
                {
                    if (baza.dodajRadnika(user, pass, cbxPozicija.SelectedItem.ToString()) != false)
                    {
                        labelPozicija.Text = "Nalog je uspešno dodat.";
                        labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                        labelKorisnik.Text = "";
                        timer1.Start();

                    }
                    else
                    {
                        labelPozicija.Text = "Greška. Izmenite korisničko ime.";
                        labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                        labelKorisnik.Text = "";
                        timer1.Start();
                    }
                }
                else
                {
                    labelPozicija.Text = "Potrebno je popuniti sva polja.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer1.Start();
                }
            }
            else if (AddChangeDelete == "Change")
            {
                string pozicija = cbxPozicija.SelectedItem.ToString();
                if (baza.izmeniRadnika(IzmeniRadnikStaroIme, IzmeniRadnikStaraSifra, user, pass,pozicija) != false)
                {
                    labelPozicija.Text = "Nalog je uspešno izmenjen.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();
                    this.btnIzmeniRadnika_Click(sender, e);
                }
                else
                {
                    labelPozicija.Text = "Greška. Nalog ne postoji.";
                    labelKorisnik.Text = "";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    timer1.Start();
                }
            }
            else if (AddChangeDelete == "Delete")
            {
                if (baza.obrisiRadnika(user, pass) != false)
                {
                    labelPozicija.Text = "Nalog je uspešno uklonjen.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();

                }
                else
                {
                    labelPozicija.Text = "Greška. Nalog ne postoji.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer1.Start();
                }
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbxPozicija.SelectedItem = null;
            cbxPozicija.Text = "Pozicija";
            if (logovan == true)
            {
                buttonGaraze.Enabled = true;
                buttonPreostaloVreme.Enabled = true;
                if (zaposlenLog == "menadzer")
                    buttonIstorijaParkiranja.Enabled = true;
                else
                    buttonIstorijaParkiranja.Enabled = false;
                buttonUsluge.Enabled = true;
                if(zaposlenLog == "menadzer")
                    buttonStatistika.Enabled = true;
                else
                    buttonStatistika.Enabled = false;
                buttonRezervacije.Enabled = true;
                buttonProduzavanje.Enabled = true;
            }


        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void buttonOdjavi_Click(object sender, EventArgs e)
        {
            this.panelLogovanje.Visible = true;
            this.panelGaraze.Visible = false;
            this.panelIstorijaParkiranja.Visible = false;
            this.panelUsluge.Visible = false;
            this.panelStatistika.Visible = false;
            this.panelRezervacijeProduzavanja.Visible = false;
            this.panelPreostaloVreme.Visible = false;
            this.labelPozicija.Text = "Potrebno je da se ulogujete.";
            garaza1.myForm = this;
            garaza2.myForm = this;
            garaza3.myForm = this;

            listaPicBox.Add(picBoxGaraza1);
            listaPicBox.Add(picBoxGaraza2);
            listaPicBox.Add(picBoxGaraza3);
            listaPicBox[index].BringToFront();

            slikaDodaj.Visible = false;
            slikaUkloni.Visible = false;
            slikaIzmeni.Visible = false;
            cbxPozicija.Visible = false;
            btnIzmeniDalje.Visible = false;
            labelDodaj.Visible = false;
            labelIzmeni.Visible = false;
            labelUkloni.Visible = false;
            btnDodajRadnika.Visible = false;
            btnIzmeniRadnika.Visible = false;
            btnUkloniRadnika.Visible = false;

            buttonGaraze.Enabled = false;
            buttonIstorijaParkiranja.Enabled = false;
            buttonUsluge.Enabled = false;
            buttonStatistika.Enabled = false;
            buttonRezervacije.Enabled = false;
            buttonProduzavanje.Enabled = false;
            buttonPreostaloVreme.Enabled = false;

            groupBoxDodajVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = false;
            txtInfoHistory.Visible = false;
            //sve ovo iznad je copy paste sa pocetka FormLoad

            buttonLog.Visible = true;
            labelPozicija.Text = "Potrebno je da se ulogujete.";
            labelKorisnik.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            logovan = false;
            zaposlenLog = "";
            labelDodaj.Visible = false;
            labelIzmeni.Visible = false;
            labelUkloni.Visible = false;
            btnDodajRadnika.Visible = false;
            btnIzmeniRadnika.Visible = false;
            btnUkloniRadnika.Visible = false;
            AddChangeDelete = null;
            buttonGaraze.Enabled = false;
            buttonIstorijaParkiranja.Enabled = false;
            buttonUsluge.Enabled = false;
            buttonStatistika.Enabled = false;

            txtInfo.Clear();

        }
        #endregion

        #region GARAZE
        private void buttonGaraze_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "garaze";
            panelLogovanje.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            this.panelStatistika.Hide();
            this.panelRezervacijeProduzavanja.Hide();
            this.panelPreostaloVreme.Hide();
            panelGaraze.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonGaraze.Location.Y);

            groupBoxDodajVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = false;

            btnDodajVozilo.Visible = false;
            btnUkloniVozilo.Visible = false;
            btnIzmeniVozilo.Visible = false;
            btnTxtInfoHistory.Visible = false;
            btnClearHistory.Visible = false;
            panelClearHistory.Visible = false;

            this.ucitajParkiranaVozila();

            if (SlideMenu.Width == 50)
            {
                if (slajdGaraze == "prosiren")
                {
                    this.panelGaraze.Location = new Point(this.panelGaraze.Location.X - 100, this.panelGaraze.Location.Y);
                    slajdGaraze = "uvucen";
                }
            }
            else
            {
                if (slajdGaraze == "uvucen")
                {
                    this.panelGaraze.Location = new Point(this.panelGaraze.Location.X + 100, this.panelGaraze.Location.Y);
                    slajdGaraze = "prosiren";
                }
            }
        }

        private void buttonPrethodnaGaraza_Click_1(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listaPicBox[--index].BringToFront();
                indexTrenutneGaraze--;
            }
            labelGaraza.Text = "Garaža " + indexTrenutneGaraze;
        }

        private void buttonSledecaGaraza_Click_1(object sender, EventArgs e)
        {
            if (index < listaPicBox.Count - 1)
            {
                listaPicBox[++index].BringToFront();
                indexTrenutneGaraze++;
            }
            labelGaraza.Text = "Garaža " + indexTrenutneGaraze;

        }

        private void picBoxGaraza1_MouseClick(object sender, MouseEventArgs e)
        {
            garaza1.ShowDialog();
        }

        private void picBoxGaraza2_MouseClick(object sender, MouseEventArgs e)
        {
            garaza2.ShowDialog();
        }

        private void picBoxGaraza3_MouseClick(object sender, MouseEventArgs e)
        {
            garaza3.ShowDialog();
        }
        #endregion

        #region DODAJ_UKLONI_IZMENI_RADNIKA
        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            labelDodaj.ForeColor = Color.FromArgb(0, 102, 204);
            buttonLog.Text = "Dodaj";
            slikaLogovanje.Visible = false;
            slikaIzmeni.Visible = false;
            slikaUkloni.Visible = false;
            slikaDodaj.Visible = true;
            labelIzmeni.ForeColor = Color.White;
            labelUkloni.ForeColor = Color.White;
            cbxPozicija.Visible = true;
            buttonOdjavi.Visible = false;
            label1.Text = "Korisničko ime";
            label2.Text = "Šifra";
            btnIzmeniDalje.Visible = false;
            AddChangeDelete = "Add";
            buttonLog.Visible = true;
        }

        private void btnUkloniRadnika_Click(object sender, EventArgs e)
        {
            labelUkloni.ForeColor = Color.FromArgb(0, 102, 204);
            buttonLog.Text = "Ukolni";
            labelDodaj.ForeColor = Color.White;
            labelIzmeni.ForeColor = Color.White;
            slikaUkloni.Visible = true;
            slikaDodaj.Visible = false;
            slikaIzmeni.Visible = false;
            slikaLogovanje.Visible = false;
            cbxPozicija.Visible = false;
            buttonOdjavi.Visible = false;
            label1.Text = "Korisničko ime";
            label2.Text = "Šifra";
            btnIzmeniDalje.Visible = false;
            AddChangeDelete = "Delete";
            buttonLog.Visible = true;
        }

        private void btnIzmeniRadnika_Click(object sender, EventArgs e)
        {
            labelIzmeni.ForeColor = Color.FromArgb(0, 102, 204);
            buttonLog.Visible = false;
            labelDodaj.ForeColor = Color.White;
            labelUkloni.ForeColor = Color.White;
            slikaDodaj.Visible = false;
            slikaUkloni.Visible = false;
            slikaIzmeni.Visible = true;
            slikaLogovanje.Visible = false;
            cbxPozicija.Visible = false;
            buttonOdjavi.Visible = false;
            btnIzmeniDalje.Visible = true;
            label1.Text = "Staro ime";
            label2.Text = "Stara šifra";
            AddChangeDelete = "Change";
        }

        private void btnIzmeniDalje_Click(object sender, EventArgs e)
        {
            if (baza.provera_zaposlenog(txtUsername.Text, txtPassword.Text) == null)
            {
                labelPozicija.Text = "Greška. Nalog ne postoji.";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                timer1.Start();
                txtPassword.Text = "";
                txtUsername.Text = "";
                cbxPozicija.Visible = false;
                cbxPozicija.SelectedItem = null;
                cbxPozicija.Text = "Pozicija";

            }
            else
            {
                label1.Text = "Novo ime";
                label2.Text = "Nova šifra";
                cbxPozicija.Visible = true;
                buttonLog.Visible = true;
                buttonLog.Text = "Izmeni";
                buttonOdjavi.Visible = false;
                IzmeniRadnikStaroIme = txtUsername.Text;
                IzmeniRadnikStaraSifra = txtPassword.Text;
                btnIzmeniDalje.Visible = false;
                txtUsername.Text = "";
                txtPassword.Text = "";


            }

        }
        #endregion
       
        #region DODAJ_VOZILO
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            groupBoxDodajVozilo.Visible = true;
            groupBoxUkloniVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = false;
            txtInfoHistory.Visible = false;
            cbxGaraza.Enabled = false;
            cbxParkingMesto.Enabled = false;

            cbxTipVozila.SelectedItem = null;
            cbxGaraza.Text = "";
            cbxParkingMesto.Text = "";
            checkInvaliditet.Checked = false;
            radioButton1h.Checked = false;
            radioButton12h.Checked = false;
            radioButton24h.Checked = false;
            radioButton168h.Checked = false;
            radioButton720h.Checked = false;
            txtRegistracija.Text = "";

            btnDodajNovoVozilo.Visible = false;
            panelClearHistory.Visible = false;


        }

        public void proveraZaDugmeDodajVozilo()
        {
            char[] characters = txtRegistracija.Text.ToCharArray();
            if (cbxTipVozila.SelectedItem != null && cbxGaraza.SelectedItem != null && cbxParkingMesto.SelectedItem != null && txtRegistracija.Text != ""&& (cbxGaraza.SelectedIndex>=0)&& (cbxParkingMesto.SelectedIndex>=0))
            {
                if (radioButton1h.Checked == true || radioButton12h.Checked == true || radioButton24h.Checked == true || radioButton168h.Checked == true || radioButton720h.Checked == true)
                {
                    
                    btnDodajNovoVozilo.Visible = true;
                }
                else
                {
                    btnDodajNovoVozilo.Visible = false;
                }
            }
            else
                btnDodajNovoVozilo.Visible = false;
        }

        private void txtRegistracija_OnValueChanged_1(object sender, EventArgs e)
        {
            proveraZaDugmeDodajVozilo();
        }

        private void txtRegistracija_Leave(object sender, EventArgs e)
        {
            proveraZaDugmeDodajVozilo();
        }


        private void btnDodajNovoVozilo_Click(object sender, EventArgs e)//Dodaj vozilo dugme
        {
            Vozilo v = new Vozilo();
            string tip = cbxTipVozila.SelectedItem.ToString();
            string registracija = txtRegistracija.Text;
            int usluga = 0;
            int invalid;

            if (radioButton1h.Checked == true)
                usluga = 1;
            else if (radioButton12h.Checked == true)
                usluga = 12;
            else if (radioButton24h.Checked == true)
                usluga = 24;
            else if (radioButton168h.Checked == true)
                usluga = 168;
            else if (radioButton720h.Checked == true)
                usluga = 720;

            DateTime pocetak = DateTime.Now;
            DateTime kraj = pocetak.AddHours(usluga);

            if (checkInvaliditet.Checked == true)
                invalid = 1;
            else
                invalid = 0;

            if (tip == "automobil")
            {
                v = new Auto(registracija,checkInvaliditet.Checked,pocetak,kraj,usluga);
                    switch (usluga)
                    {
                        case 1: v.Racun = baza.automobil1h(); break;
                        case 12: v.Racun = baza.automobil12h(); break;
                        case 24: v.Racun = baza.automobil24h(); break;
                        case 168: v.Racun = baza.automobil168h(); break;
                        case 720: v.Racun = baza.automobil720h(); break;
                    }             
            }
            else if (tip == "autobus")
            {
                v = new Bus(registracija,pocetak,kraj,usluga);
                    switch (usluga)
                    {
                        case 1: v.Racun = baza.autobus1h(); break;
                        case 12: v.Racun = baza.autobus12h(); break;
                        case 24: v.Racun = baza.autobus24h(); break;
                        case 168: v.Racun = baza.autobus168h(); break;
                        case 720: v.Racun = baza.autobus720h(); break;
                    }    
            }
            else if (tip == "kamion")
            {
                v = new Kamion(registracija,pocetak,kraj,usluga);
                    switch (usluga)
                    {
                        case 1: v.Racun = baza.kamion1h(); break;
                        case 12: v.Racun = baza.kamion12h(); break;
                        case 24: v.Racun = baza.kamion24h(); break;
                        case 168: v.Racun = baza.kamion168h(); break;
                        case 720: v.Racun = baza.kamion720h(); break;
                    }
            }

            int racun = v.Racun;
            int garaza = cbxGaraza.SelectedIndex + 1;
            int parkingMesto = Convert.ToInt32(cbxParkingMesto.SelectedItem.ToString());

            ParkingMesto p = new ParkingMesto(parkingMesto);
            p.Vozilo = v;

            if(baza.dodajVozilo(garaza, parkingMesto, tip, invalid, registracija, pocetak.ToString("yyyy-MM-dd H:mm:ss"), kraj.ToString("yyyy-MM-dd H:mm:ss"), usluga,racun)==true)
            {
                    labelPozicija.Text = "Vozilo je uspešno dodato.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();

                this.AppendTextInfo("Dodavanje: ", Color.FromArgb(153, 255, 0), false,false);
                String textPrikaz = tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                textPrikaz += " " + registracija + " je uspešno dodat.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]";
                this.AppendTextInfo(textPrikaz, Color.White, true,false);

                
                String textPrikazHistory ="Dodavanje: "+ tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                string invText = null;
                if (invalid == 1)
                    invText = "da";
                else
                    invText = "ne";
                textPrikazHistory += " " + registracija + " je uspešno dodat. Invaliditet: "+invText+", početak: " + pocetak.ToString("yyyy-MM-dd H:mm:ss")+", kraj: "+ kraj.ToString("yyyy-MM-dd H:mm:ss")+", usluga: "+usluga+"h, račun: "+racun+"RSD.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]"+ " | "+zaposlenIme+" |";
                this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                baza.dodajAktivnost(textPrikazHistory);

                if (garaza == 1)
                {
                    parkingServis.ListaGaraza[0].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                    if (p.Vozilo.TipVozila == "automobil")
                    {
                        garaza1.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                        garaza1.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else if (p.Vozilo.TipVozila == "autobus")
                    {
                        garaza1.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                        garaza1.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else
                    {
                        garaza1.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                        garaza1.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                }
                else if (garaza == 2)
                {
                    parkingServis.ListaGaraza[1].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                    if (p.Vozilo.TipVozila == "automobil")
                    {
                        garaza2.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                        garaza2.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else if (p.Vozilo.TipVozila == "autobus")
                    {
                        garaza2.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                        garaza2.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else
                    {
                        garaza2.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                        garaza2.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }

                }
                else if (garaza == 3)
                {
                    parkingServis.ListaGaraza[2].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                    if (p.Vozilo.TipVozila == "automobil")
                    {
                        garaza3.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                        garaza3.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else if (p.Vozilo.TipVozila == "autobus")
                    {
                        garaza3.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                        garaza3.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                    else
                    {
                        garaza3.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                        garaza3.listaParkingMesta[parkingMesto - 1].Tag = p.Vozilo;
                    }
                }
                else { }
            }
            else
            {

                    labelPozicija.Text = "Greška pri dodavanju.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer1.Start();
            }

            cbxTipVozila.SelectedItem = null;
            cbxGaraza.Text = "";
            cbxParkingMesto.Text = "";
            checkInvaliditet.Checked = false;
            radioButton1h.Checked = false;
            radioButton12h.Checked = false;
            radioButton24h.Checked = false;
            radioButton168h.Checked = false;
            radioButton720h.Checked = false;
            txtRegistracija.Text = "";
            cbxGaraza.Enabled = false;
            cbxParkingMesto.Enabled = false;

            izmenaPocetakParkiranja = DateTime.Now;
            izmenaKrajParkiranja = DateTime.Now;
        }

        private void cbxGaraza_SelectedIndexChanged(object sender, EventArgs e)//promena izbora Garaze pri dodavanju
        {
            cbxParkingMesto.Items.Clear();
            cbxParkingMesto.Text = "";
            cbxParkingMesto.Enabled = true;

            if (cbxGaraza.SelectedIndex==0)
            {
                if(cbxTipVozila.SelectedIndex==0)
                {
                    if (checkInvaliditet.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza1.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza1.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                }
                else if(cbxTipVozila.SelectedIndex == 1 || cbxTipVozila.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza1.listaParkingMesta[i].Tag == null)
                            cbxParkingMesto.Items.Add(upis);
                    }
                }
               
            }
            else if (cbxGaraza.SelectedIndex==1)
            {
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    if (checkInvaliditet.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza2.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza2.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                }
                else if (cbxTipVozila.SelectedIndex == 1 || cbxTipVozila.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza2.listaParkingMesta[i].Tag == null)
                            cbxParkingMesto.Items.Add(upis);
                    }
                }
            }
            else if(cbxGaraza.SelectedIndex==2)
            {
                if (cbxTipVozila.SelectedIndex == 0)
                {
                    if (checkInvaliditet.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza3.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza3.listaParkingMesta[i].Tag == null)
                                cbxParkingMesto.Items.Add(upis);
                        }
                    }
                }
                else if (cbxTipVozila.SelectedIndex == 1 || cbxTipVozila.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza3.listaParkingMesta[i].Tag == null)
                            cbxParkingMesto.Items.Add(upis);
                    }
                }
            }

          
        }

        private void cbxTipVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxParkingMesto.SelectedIndex>=0)
            {
                cbxGaraza.Text = "";
                cbxParkingMesto.Text = "";
            }
            cbxGaraza.Enabled = true;
            cbxParkingMesto.Enabled = false;
            
        }

        private void checkInvaliditet_CheckedChanged(object sender, EventArgs e)
        {
            this.cbxGaraza_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region UKLONI_VOZILO
        private void btnUkloniVozilo_Click(object sender, EventArgs e)
        {
            groupBoxDodajVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = true;
            rdbParkingMesto.Checked = false;
            rdbRegistracija.Checked = false;
            cbxUkloniRegistracija.Text = "";
            groupBoxUkloniRegistracija.Visible = false;
            groupBoxUkloniParkingMesto.Visible = false;
            buttonUkloni.Visible = false;
            txtInfoHistory.Visible = false;
            panelClearHistory.Visible = false;
        }

        private void rdbParkingMesto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParkingMesto.Checked == true)
            {
                groupBoxUkloniParkingMesto.Visible = true;
                groupBoxUkloniRegistracija.Visible = false;
                cbxUkloniParkingMesto.Enabled = false;
            }
            else
            {
                groupBoxUkloniParkingMesto.Visible = false;
                groupBoxUkloniRegistracija.Visible = true;
            }
                
        }

        private void rdbRegistracija_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRegistracija.Checked == true)
            {
                groupBoxUkloniRegistracija.Visible = true;
                groupBoxUkloniParkingMesto.Visible = false;
            }
            else
            {
                groupBoxUkloniRegistracija.Visible = false;
                groupBoxUkloniParkingMesto.Visible = true;
            }

            cbxUkloniRegistracija.Items.Clear();
            for(int i=0;i<32;i++)
            {
                if (garaza1.listaParkingMesta[i].Tag != null)
                {
                    Vozilo v = new Vozilo();
                    v = (Vozilo)garaza1.listaParkingMesta[i].Tag;
                    cbxUkloniRegistracija.Items.Add(v.RegTab);
                }

            }
            for (int i = 0; i < 32; i++)
            {
                if (garaza2.listaParkingMesta[i].Tag != null)
                {
                    Vozilo v = new Vozilo();
                    v = (Vozilo)garaza2.listaParkingMesta[i].Tag;
                    cbxUkloniRegistracija.Items.Add(v.RegTab);
                }

            }
            for (int i = 0; i < 32; i++)
            {
                if (garaza3.listaParkingMesta[i].Tag != null)
                {
                    Vozilo v = new Vozilo();
                    v = (Vozilo)garaza3.listaParkingMesta[i].Tag;
                    cbxUkloniRegistracija.Items.Add(v.RegTab);
                }

            }
        }

        private void cbxUkloniGaraza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxUkloniParkingMesto.Items.Clear();
            cbxUkloniParkingMesto.Text = "";
            cbxUkloniParkingMesto.Enabled = true;

            if(cbxUkloniGaraza.SelectedIndex==0)
            {
                for(int i=0;i<32;i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza1.listaParkingMesta[i].Tag != null)
                        cbxUkloniParkingMesto.Items.Add(upis);
                }
            }
            else if(cbxUkloniGaraza.SelectedIndex == 1)
            {
                for (int i = 0; i < 32; i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza2.listaParkingMesta[i].Tag != null)
                        cbxUkloniParkingMesto.Items.Add(upis);
                }
            }
            else if(cbxUkloniGaraza.SelectedIndex == 2)
            {
                for (int i = 0; i < 32; i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza3.listaParkingMesta[i].Tag != null)
                        cbxUkloniParkingMesto.Items.Add(upis);
                }
            }

            proveraZaDugmeUkloniVozilo();
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            if (rdbParkingMesto.Checked == true)
            {
                int gar = Convert.ToInt32(cbxUkloniGaraza.SelectedItem.ToString());
                int mesto = Convert.ToInt32(cbxUkloniParkingMesto.SelectedItem.ToString());
                if (baza.ukloniVoziloLokacija(gar,mesto)==true)
                {
                     labelPozicija.Text = "Vozilo je uspešno uklonjeno.";

                    this.AppendTextInfo("Uklanjanje: ", Color.FromArgb(255, 102, 102), false,false);
                    String textPrikaz= parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo.TipVozila.Substring(0, 1).ToUpper() + parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo.TipVozila.Substring(1);
                    textPrikaz += " " + parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo.RegTab + " je uspešno uklonjen.  [ Garaža: " + parkingServis.ListaGaraza[gar - 1].RedniBrGaraze + ", Parking mesto: " + parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Broj + " ]";
                    this.AppendTextInfo(textPrikaz, Color.White, true,false);

                    Vozilo v = new Vozilo();
                    v = parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo;
                    string inval = null;
                    if (v.DalijeInvalidsko == true)
                        inval = "da";
                    else
                        inval = "ne";
                    String textPrikazHistory = "Uklanjanje: "+v.TipVozila.Substring(0, 1).ToUpper() +v.TipVozila.Substring(1);
                    textPrikazHistory += " " + v.RegTab + " je uspešno uklonjen. Invaliditet: " +
                        ""+inval+", početak: "+v.PocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss")+", kraj: "+v.KrajParkiranja.ToString("yyyy-MM-dd H:mm:ss")+", usluga: "+v.UslugaParkingServisa+"h, račun: "+v.Racun+"RSD.  [ Garaža: " + parkingServis.ListaGaraza[gar - 1].RedniBrGaraze + ", Parking mesto: " + parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Broj + " ]"+" | "+zaposlenIme+" |";
                    this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                    baza.dodajAktivnost(textPrikazHistory);

                    parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo = null;
                    switch (gar)
                    {
                        case 1: garaza1.listaParkingMesta[mesto - 1].Image= null; garaza1.listaParkingMesta[mesto - 1].Tag = null; parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo = null; break;//dodato
                        case 2: garaza2.listaParkingMesta[mesto - 1].Image = null; garaza2.listaParkingMesta[mesto - 1].Tag = null; parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo = null; break;//dodato
                        case 3: garaza3.listaParkingMesta[mesto - 1].Image = null; garaza3.listaParkingMesta[mesto - 1].Tag = null; parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo = null; break;//dodato
                        default:break;
                    }

                        labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                        labelKorisnik.Text = "";
                        timer1.Start();

                }
                else
                {
                        labelPozicija.Text = "Greška pri uklanjanju.";
                        labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                        labelKorisnik.Text = "";
                        timer1.Start();
                }
            }
            else if (rdbRegistracija.Checked == true)
            {
                string reg = cbxUkloniRegistracija.SelectedItem.ToString();
                if (baza.ukloniVoziloReg(reg)==true)
                {
                    labelPozicija.Text = "Vozilo je uspešno uklonjeno.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();

                    Vozilo v = new Vozilo();
                    foreach( Garaza g in parkingServis.ListaGaraza)
                    {
                        foreach(ParkingMesto p in g.ListaParkingMesta)
                        {
                            if(p.Vozilo!=null)
                            {
                                if (p.Vozilo.RegTab == reg)
                                {
                                    this.AppendTextInfo("Uklanjanje: ", Color.FromArgb(255, 102, 102), false,false);
                                    String textPrikaz = p.Vozilo.TipVozila.Substring(0, 1).ToUpper() + p.Vozilo.TipVozila.Substring(1);
                                    textPrikaz += " " + p.Vozilo.RegTab + " je uspešno uklonjen.  [ Garaža: " + g.RedniBrGaraze + ", Parking mesto: " + p.Broj + " ]";
                                    this.AppendTextInfo(textPrikaz, Color.White, true,false);

                                    
                                    string inval = null;
                                    if (p.Vozilo.DalijeInvalidsko == true)
                                        inval = "da";
                                    else
                                        inval = "ne";
                                    String istorija = "Uklanjanje: "+
                                        p.Vozilo.TipVozila.Substring(0, 1).ToUpper() + p.Vozilo.TipVozila.Substring(1);
                                    istorija += " " + p.Vozilo.RegTab + " je uspešno uklonjen. Invaliditet: " + inval + ", početak: " + p.Vozilo.PocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", kraj: " + p.Vozilo.KrajParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", usluga: " + p.Vozilo.UslugaParkingServisa + "h, račun: " + p.Vozilo.Racun + "RSD.  [ Garaža: " + g.RedniBrGaraze + ", Parking mesto: " + p.Broj + " ]" + " | " + zaposlenIme + " |";
                                    this.AppendTextInfo(istorija, Color.White, true, true);
                                    baza.dodajAktivnost(istorija);
                                    p.Vozilo = null;
                                }
                                    
                            }
                        }
                    }
                    foreach(PictureBox p in garaza1.listaParkingMesta)
                    {
                        if (p.Image != null)
                        {
                            v = (Vozilo)p.Tag;
                            if (v.RegTab == reg)
                            {
                                p.Image = null;
                                p.Tag = null;
                            }
                        }
                            
                    }
                    foreach (PictureBox p in garaza2.listaParkingMesta)
                    {
                        if (p.Image != null)
                        {
                            v = (Vozilo)p.Tag;
                            if (v.RegTab == reg)
                            {
                                p.Image = null;
                                p.Tag = null;
                            }
                        }
                    }
                    foreach (PictureBox p in garaza3.listaParkingMesta)
                    {
                        if (p.Image != null)
                        {
                            v = (Vozilo)p.Tag;
                            if (v.RegTab == reg)
                            {
                                p.Image = null;
                                p.Tag = null;
                            }
                        }
                    }
                }
                else
                {
                    labelPozicija.Text = "Greška pri uklanjanju.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer1.Start();
                }
            }

           
            cbxUkloniParkingMesto.Text = "";
            cbxUkloniRegistracija.Text = "";
            cbxUkloniGaraza.Text = "";
            cbxUkloniParkingMesto.Enabled = false;
            rdbParkingMesto.Checked = false;
            rdbRegistracija.Checked = false;
            groupBoxUkloniParkingMesto.Visible = false;
            groupBoxUkloniRegistracija.Visible = false;
        }

        private void cbxParkingMesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveraZaDugmeDodajVozilo();
        }

        private void radioButton1h_CheckedChanged(object sender, EventArgs e)
        {
            proveraZaDugmeDodajVozilo();
        }

        private void cbxUkloniParkingMesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveraZaDugmeUkloniVozilo();
        }

        private void cbxUkloniRegistracija_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveraZaDugmeUkloniVozilo();
        }

        public void proveraZaDugmeUkloniVozilo()
        {
            if(groupBoxUkloniParkingMesto.Visible==true)
            {
                if (cbxUkloniGaraza.SelectedIndex >= 0 && cbxUkloniParkingMesto.SelectedIndex >= 0)
                    buttonUkloni.Visible = true;
                else
                    buttonUkloni.Visible = false;
            }
            else if(groupBoxUkloniRegistracija.Visible==true)
            {
                if (cbxUkloniRegistracija.SelectedIndex >= 0)
                    buttonUkloni.Visible = true;
                else
                    buttonUkloni.Visible = false;
            }

        }
        #endregion

        #region IZMENI_VOZILO
        private void btnIzmeniVozilo_Click(object sender, EventArgs e)
        {
            groupBoxDodajVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = true;
            comboBoxIzmeniLokGaraza.Text = "";
            comboBoxIzmeniLokMesto.Text = "";
            txtIzmeniReg.Text = "";
            cbxIzmeniTip.SelectedIndex = -1;
            cbxIzmeniMesto.SelectedIndex = -1;
            cbxIzmeniTip.SelectedIndex = -1;
            checkBoxIzmeniInv.Checked = false;
            rdbIzmeni1h.Checked = false;
            rdbIzmeni12h.Checked = false;
            rdbIzmeni24h.Checked = false;
            rdbIzmeni168h.Checked = false;
            rdbIzmeni720h.Checked = false;
            groupBoxLokacijaVozila.Visible = true;
            groupBoxPodaciVozila.Visible = false;
            comboBoxIzmeniLokMesto.Enabled = false;
            txtInfoHistory.Visible = false;
            panelClearHistory.Visible = false;

        }

        private void comboBoxIzmeniLokGaraza_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIzmeniLokMesto.Enabled = true;
            comboBoxIzmeniLokMesto.Text = "";
            comboBoxIzmeniLokMesto.Items.Clear();

            if (comboBoxIzmeniLokGaraza.SelectedIndex == 0)
            {
                for (int i = 0; i < 32; i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza1.listaParkingMesta[i].Tag != null)
                        comboBoxIzmeniLokMesto.Items.Add(upis);
                }
            }
            else if (comboBoxIzmeniLokGaraza.SelectedIndex == 1)
            {
                for (int i = 0; i < 32; i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza2.listaParkingMesta[i].Tag != null)
                        comboBoxIzmeniLokMesto.Items.Add(upis);
                }
            }
            else if (comboBoxIzmeniLokGaraza.SelectedIndex == 2)
            {
                for (int i = 0; i < 32; i++)
                {
                    string upis = (i + 1).ToString();
                    if (garaza3.listaParkingMesta[i].Tag != null)
                        comboBoxIzmeniLokMesto.Items.Add(upis);
                }
            }
        }

        private void comboBoxIzmeniLokMesto_SelectedIndexChanged(object sender, EventArgs e)
        {

            groupBoxLokacijaVozila.Visible = false;
            groupBoxPodaciVozila.Visible = true;
            int gar = Convert.ToInt32(comboBoxIzmeniLokGaraza.SelectedItem.ToString());
            int mesto = Convert.ToInt32(comboBoxIzmeniLokMesto.SelectedItem.ToString());


            Vozilo v = new Vozilo();
            v = parkingServis.ListaGaraza[gar - 1].ListaParkingMesta[mesto - 1].Vozilo;

            izmenaPocetakParkiranja = v.PocetakParkiranja;
            izmenaKrajParkiranja = v.KrajParkiranja;
            izmenaRacun = v.Racun;
            izmenaTip = v.TipVozila;
            izmenaUsluga = v.UslugaParkingServisa;
            izmenaRegistracija = v.RegTab;
            izmenaInvalid = v.DalijeInvalidsko;

            //KORISTIMO U btnIzmeniInfo_Click da bi znali koje vozilo brisemo
            brisanjeGaraza = gar.ToString();
            brisanjeMesto = mesto.ToString();

            //POPUNJAVANJE PODATAKA O VOZILU KOJE MENJAMO, A KOJE SMO OBRISALI PRETHODNO IZ SISTEM
            cbxIzmeniTip.SelectedItem = v.TipVozila;
            if (v.DalijeInvalidsko == true)
                checkBoxIzmeniInv.Checked = true;
            txtIzmeniReg.Text = v.RegTab;
            switch (v.UslugaParkingServisa)
            {
                case 1: rdbIzmeni1h.Checked = true;izmenaUsluga = 1; break;
                case 12: rdbIzmeni12h.Checked = true;izmenaUsluga = 12; break;
                case 24: rdbIzmeni24h.Checked = true;izmenaUsluga = 24; break;
                case 168: rdbIzmeni168h.Checked = true;izmenaUsluga = 168; break;
                case 720: rdbIzmeni720h.Checked = true;izmenaUsluga = 720; break;
                default: break;
            }
            cbxIzmeniGar.SelectedItem = gar.ToString();
            cbxIzmeniGar_SelectedIndexChanged(sender,e);
            cbxIzmeniMesto.Items.Add(mesto.ToString());
            cbxIzmeniMesto.Sorted = true;
            cbxIzmeniMesto.SelectedIndex = cbxIzmeniMesto.FindStringExact(mesto.ToString());


        }

        private void btnIzmeniInfo_Click(object sender, EventArgs e)
        {

            TimeSpan span = izmenaKrajParkiranja.Subtract(izmenaPocetakParkiranja);
            int satiUsluge = (int)span.TotalHours;
            if (satiUsluge == izmenaUsluga)
            {
                string tip= cbxIzmeniTip.SelectedItem.ToString();
                string registracija= txtIzmeniReg.Text;
                int usluga = 0; int invalid = 0; int racun = 0;
                if (rdbIzmeni1h.Checked == true)
                    usluga = 1;
                else if (rdbIzmeni12h.Checked == true)
                    usluga = 12;
                else if (rdbIzmeni24h.Checked == true)
                    usluga = 24;
                else if (rdbIzmeni168h.Checked == true)
                    usluga = 168;
                else if (rdbIzmeni720h.Checked == true)
                    usluga = 720;
                if (checkBoxIzmeniInv.Checked == true)
                    invalid = 1;
                DateTime pocetak = izmenaPocetakParkiranja;
                DateTime kraj = pocetak.AddHours(usluga);
                int garaza = Convert.ToInt32(cbxIzmeniGar.SelectedItem.ToString());
                int parkingMesto = Convert.ToInt32(cbxIzmeniMesto.SelectedItem.ToString());

                if (tip == "automobil") //OD RACUNA MU ODUZIMAMO RACUN ZA POSLEDNJU USLUGU KOJU MENJAMO, da bi kasnije na racun dodali racun novoizmenjene usluge
                {
                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: racun= baza.automobil1h(); break;
                        case 12: racun += baza.automobil12h(); break;
                        case 24: racun += baza.automobil24h(); break;
                        case 168: racun += baza.automobil168h(); break;
                        case 720: racun += baza.automobil720h(); break;
                    }
                }
                else if (tip == "autobus")
                {
                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: racun += baza.autobus1h(); break;
                        case 12: racun += baza.autobus12h(); break;
                        case 24: racun += baza.autobus24h(); break;
                        case 168: racun += baza.autobus168h(); break;
                        case 720: racun += baza.autobus720h(); break;
                    }
                }
                else if (izmenaTip == "kamion")
                {
                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: racun += baza.kamion1h(); break;
                        case 12: racun += baza.kamion12h(); break;
                        case 24: racun += baza.kamion24h(); break;
                        case 168: racun += baza.kamion168h(); break;
                        case 720: racun += baza.kamion720h(); break;
                    }
                }

                Vozilo v = new Vozilo();
                v.PocetakParkiranja = pocetak;
                v.KrajParkiranja = kraj;
                if (invalid == 1)
                    v.DalijeInvalidsko = true;
                v.Racun = racun;
                v.TipVozila = tip;
                v.RegTab = registracija;
                v.UslugaParkingServisa = usluga;

                if (baza.izmeniVozilo(Convert.ToInt32(brisanjeGaraza), Convert.ToInt32(brisanjeMesto), garaza, parkingMesto, tip, invalid, registracija, pocetak.ToString("yyyy-MM-dd H:mm:ss"), kraj.ToString("yyyy-MM-dd H:mm:ss"), usluga, racun) == true)
                {
                      this.AppendTextInfo("Izmena: ", Color.Aqua, false,false);
                      String textPrikaz = tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                      textPrikaz += " " + registracija + " je uspešno izmenjen.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]";
                      this.AppendTextInfo(textPrikaz, Color.White,true,false);

                    string invStraro = null; string  invNovo = null;
                    if (izmenaInvalid == true)
                        invStraro = "da";
                    else
                        invStraro = "ne";

                    if (invalid == 1)
                        invNovo = "da";
                    else
                        invNovo = "ne";

                    
                    String textPrikazHistory = "Pre izmene: "+izmenaTip.Substring(0, 1).ToUpper() + izmenaTip.Substring(1);
                    textPrikazHistory += " " + izmenaRegistracija + " je uspešno izmenjen. Invaliditet: "+invStraro+", početak: "+izmenaPocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", kraj: "+izmenaKrajParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", usluga: "+izmenaUsluga+"h, račun: "+izmenaRacun+"RSD.  [ Garaža: " + brisanjeGaraza + ", Parking mesto: " + brisanjeMesto + " ]" + " | " + zaposlenIme + " |";
                    this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                    baza.dodajAktivnost(textPrikazHistory);
                    
                    textPrikazHistory = "Posle izmene: "+tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                    textPrikazHistory += " " + registracija + " je uspešno izmenjen. Invaliditet: " + invNovo + ", početak: " + pocetak.ToString("yyyy-MM-dd H:mm:ss") + ", kraj: " + kraj.ToString("yyyy-MM-dd H:mm:ss") + ", usluga: " + usluga + "h, račun: " + racun + "RSD.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]" + " | " + zaposlenIme + " |";
                    this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                    baza.dodajAktivnost(textPrikazHistory);

                    labelPozicija.Text = "Vozilo je uspešno izmenjeno.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();
                    //da bi obrisali vozilo sa prethodne lokacije ukoliko je pri izmeni promenjena lokacija
                    parkingServis.ListaGaraza[Convert.ToInt32(brisanjeGaraza) - 1].ListaParkingMesta[Convert.ToInt32(brisanjeMesto) - 1].Vozilo = null;

                    if (garaza == 1)
                    {
                        parkingServis.ListaGaraza[0].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                    }
                    else if (garaza == 2)
                    {
                        parkingServis.ListaGaraza[1].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }

                    }
                    else if (garaza == 3)
                    {
                        parkingServis.ListaGaraza[2].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                    }
                    else { }
                   


                    if(brisanjeGaraza==garaza.ToString() && brisanjeMesto==parkingMesto.ToString())
                    {

                    }
                    else
                    {
                        int brg = Convert.ToInt32(brisanjeGaraza);
                        int brm = Convert.ToInt32(brisanjeMesto);
                        if(brg==1)
                        {
                            garaza1.listaParkingMesta[brm - 1].Image = null;
                            garaza1.listaParkingMesta[brm - 1].Tag= null;
                        }
                        else if(brg==2)
                        {
                            garaza2.listaParkingMesta[brm - 1].Image = null;
                            garaza2.listaParkingMesta[brm - 1].Tag = null;
                        }
                        else if(brg==3)
                        {
                            garaza3.listaParkingMesta[brm - 1].Image = null;
                            garaza3.listaParkingMesta[brm - 1].Tag = null;
                        }
                    }
                }
                else
                {
                    labelPozicija.Text = "Greška pri izmeni.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer1.Start();
                }

                izmenaRacun = 0;
                izmenaTip = "";
                izmenaUsluga = 0;
                izmenaPocetakParkiranja = DateTime.Now;
                izmenaKrajParkiranja = DateTime.Now;
                izmenaRegistracija = "";
                izmenaInvalid = false;

            }
            else//znaci da se radi o vozilu koje je produzavalo usluge, ima vise usluga, pa je potrebno izmeniti samo poslednju uslugu
            {
                int usluga = 0;
                DateTime pocetak, kraj;
                string reg = txtIzmeniReg.Text;
                int inv = 0;
                int garaza = Convert.ToInt32(cbxIzmeniGar.SelectedItem.ToString());
                int parkingMesto = Convert.ToInt32(cbxIzmeniMesto.SelectedItem.ToString());
                string tip= cbxIzmeniTip.SelectedItem.ToString();
                int stariracun = izmenaRacun;

                if (checkBoxIzmeniInv.Checked == true)
                    inv = 1;
                else
                    inv = 0;

                if (rdbIzmeni1h.Checked == true)
                    usluga = 1;
                else if (rdbIzmeni12h.Checked == true)
                    usluga = 12;
                else if (rdbIzmeni24h.Checked == true)
                    usluga = 24;
                else if (rdbIzmeni168h.Checked == true)
                    usluga = 168;
                else if(rdbIzmeni720h.Checked==true)
                        usluga = 720;

                int negativnaUsluga = izmenaUsluga * (-1);//ako je bila 1h, sad mu oduzimamo 1h poslednje usluge, da bi kasnije dodali vremenski interval novoizmenjene usluge
                DateTime k1 = izmenaKrajParkiranja.AddHours(negativnaUsluga);//od kraj parkiranja smo mu oduzeli vreme poslednje usluge koju menjamo
                DateTime k2 = k1.AddHours(usluga);//dodamo mu vremenski interval za novu izmenjenu uslugu
                kraj = k2;//azuriramo kraj parkiranja!!! na ovaj nacin menjamo poslednju uslugu, ako je imao vise usluga
                pocetak = izmenaPocetakParkiranja;
                if (izmenaTip == "automobil") //OD RACUNA MU ODUZIMAMO RACUN ZA POSLEDNJU USLUGU KOJU MENJAMO, da bi kasnije na racun dodali racun novoizmenjene usluge
                {
                    switch (izmenaUsluga)//obrisemo racun za poslednju uslugu koju menjamo
                    {
                        case 1: izmenaRacun -= baza.automobil1h(); break;
                        case 12: izmenaRacun -= baza.automobil12h(); break;
                        case 24: izmenaRacun -= baza.automobil24h(); break;
                        case 168: izmenaRacun -= baza.automobil168h(); break;
                        case 720: izmenaRacun -= baza.automobil720h(); break;
                    }

                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: izmenaRacun += baza.automobil1h(); break;
                        case 12: izmenaRacun += baza.automobil12h(); break;
                        case 24: izmenaRacun += baza.automobil24h(); break;
                        case 168: izmenaRacun += baza.automobil168h(); break;
                        case 720: izmenaRacun += baza.automobil720h(); break;
                    }
                }
                else if (izmenaTip == "autobus")
                {
                    switch (izmenaUsluga)//obrisemo racun za poslednju uslugu koju menjamo
                    {
                        case 1: izmenaRacun -= baza.autobus1h(); break;
                        case 12: izmenaRacun -= baza.autobus12h(); break;
                        case 24: izmenaRacun -= baza.autobus24h(); break;
                        case 168: izmenaRacun -= baza.autobus168h(); break;
                        case 720: izmenaRacun -= baza.autobus720h(); break;
                    }

                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: izmenaRacun += baza.autobus1h(); break;
                        case 12: izmenaRacun += baza.autobus12h(); break;
                        case 24: izmenaRacun += baza.autobus24h(); break;
                        case 168: izmenaRacun += baza.autobus168h(); break;
                        case 720: izmenaRacun += baza.autobus720h(); break;
                    }
                }
                else if (izmenaTip == "kamion")
                {
                    switch (izmenaUsluga)//obrisemo racun za poslednju uslugu koju menjamo
                    {
                        case 1: izmenaRacun -= baza.kamion1h(); break;
                        case 12: izmenaRacun -= baza.kamion12h(); break;
                        case 24: izmenaRacun -= baza.kamion24h(); break;
                        case 168: izmenaRacun -= baza.kamion168h(); break;
                        case 720: izmenaRacun -= baza.kamion720h(); break;
                    }

                    switch (usluga)//dodamo na racun vrednost nove izmenjene usluge
                    {
                        case 1: izmenaRacun += baza.kamion1h(); break;
                        case 12: izmenaRacun += baza.kamion12h(); break;
                        case 24: izmenaRacun += baza.kamion24h(); break;
                        case 168: izmenaRacun += baza.kamion168h(); break;
                        case 720: izmenaRacun += baza.kamion720h(); break;
                    }
                }
                Vozilo v = new Vozilo();
                v.PocetakParkiranja = pocetak;
                v.KrajParkiranja = kraj;
                if (inv == 1)
                    v.DalijeInvalidsko = true;
                v.Racun = izmenaRacun;
                v.TipVozila = tip;
                v.RegTab = reg;
                v.UslugaParkingServisa = usluga;
                if (baza.izmeniVozilo(Convert.ToInt32(brisanjeGaraza),Convert.ToInt32(brisanjeMesto), garaza, parkingMesto, tip,inv,reg, pocetak.ToString("yyyy-MM-dd H:mm:ss"), kraj.ToString("yyyy-MM-dd H:mm:ss"), usluga, izmenaRacun) == true)
                {

                    this.AppendTextInfo("Izmena: ", Color.Aqua, false,false);
                    String textPrikaz = tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                    textPrikaz += " " + reg + " je uspešno izmenjen.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]";
                    this.AppendTextInfo(textPrikaz, Color.White, true,false);

                    string invStraro = null; string invNovo = null;
                    if (izmenaInvalid == true)
                        invStraro = "da";
                    else
                        invStraro = "ne";

                    if (inv == 1)
                        invNovo = "da";
                    else
                        invNovo = "ne";
                    
                    String textPrikazHistory = "Pre izmene: "+izmenaTip.Substring(0, 1).ToUpper() + izmenaTip.Substring(1);
                    textPrikazHistory += " " + izmenaRegistracija + " je uspešno izmenjen. Invaliditet: " + invStraro + ", početak: " + izmenaPocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", kraj: " + izmenaKrajParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ", usluga: " + izmenaUsluga + "h, račun: " + stariracun + "RSD.  [ Garaža: " + brisanjeGaraza + ", Parking mesto: " + brisanjeMesto + " ]" + " | " + zaposlenIme + " |";
                    this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                    baza.dodajAktivnost(textPrikazHistory);
                    
                    textPrikazHistory = "Posle izmene: "+tip.Substring(0, 1).ToUpper() + tip.Substring(1);
                    textPrikazHistory += " " + reg+ " je uspešno izmenjen. Invaliditet: " + invNovo + ", početak: " + pocetak.ToString("yyyy-MM-dd H:mm:ss") + ", kraj: " + kraj.ToString("yyyy-MM-dd H:mm:ss") + ", usluga: " + usluga + "h, račun: " + izmenaRacun + "RSD.  [ Garaža: " + garaza + ", Parking mesto: " + parkingMesto + " ]" + " | " + zaposlenIme + " |";
                    this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                    baza.dodajAktivnost(textPrikazHistory);

                    labelPozicija.Text = "Vozilo je uspešno izmenjeno.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer1.Start();

                    //da bi obrisali vozilo sa prethodne lokacije ukoliko je pri izmeni promenjena lokacija
                    parkingServis.ListaGaraza[Convert.ToInt32(brisanjeGaraza) - 1].ListaParkingMesta[Convert.ToInt32(brisanjeMesto) - 1].Vozilo = null;

                    if (garaza == 1)
                    {
                        parkingServis.ListaGaraza[0].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza1.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza1.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                    }
                    else if (garaza == 2)
                    {
                        parkingServis.ListaGaraza[1].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza2.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza2.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }

                    }
                    else if (garaza == 3)
                    {
                        parkingServis.ListaGaraza[2].ListaParkingMesta[parkingMesto - 1].Vozilo = v;
                        if (v.TipVozila == "automobil")
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = AutomobiliSlike[rnd.Next(0, 20)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else if (v.TipVozila == "autobus")
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = AutobusiSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                        else
                        {
                            garaza3.listaParkingMesta[parkingMesto - 1].Image = KamioniSlike[rnd.Next(0, 9)];
                            garaza3.listaParkingMesta[parkingMesto - 1].Tag = v;
                        }
                    }
                    else { }

                    if (brisanjeGaraza == garaza.ToString() && brisanjeMesto == parkingMesto.ToString())
                    {

                    }
                    else
                    {
                        int brg = Convert.ToInt32(brisanjeGaraza);
                        int brm = Convert.ToInt32(brisanjeMesto);
                        if (brg == 1)
                        {
                            garaza1.listaParkingMesta[brm - 1].Image = null;
                            garaza1.listaParkingMesta[brm - 1].Tag = null;
                        }
                        else if (brg == 2)
                        {
                            garaza2.listaParkingMesta[brm - 1].Image = null;
                            garaza2.listaParkingMesta[brm - 1].Tag = null;
                        }
                        else if (brg == 3)
                        {
                            garaza3.listaParkingMesta[brm - 1].Image = null;
                            garaza3.listaParkingMesta[brm - 1].Tag = null;
                        }
                    }
                }
                else
                {
                        labelPozicija.Text = "Greška pri izmeni.";
                        labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                        labelKorisnik.Text = "";
                        timer1.Start();
                }

                izmenaRacun = 0;
                izmenaTip = "";
                izmenaUsluga = 0;
                izmenaPocetakParkiranja = DateTime.Now;
                izmenaKrajParkiranja = DateTime.Now;
                izmenaRegistracija = "";
                izmenaInvalid = false;

            }
            btnIzmeniVozilo_Click(sender, e);

        }

        private void cbxIzmeniGar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIzmeniMesto.Items.Clear();
            cbxIzmeniMesto.Text = "";
           //obrisano

            if (cbxIzmeniGar.SelectedIndex == 0)
            {
                if (cbxIzmeniTip.SelectedIndex == 0)
                {
                    if (checkBoxIzmeniInv.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza1.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza1.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                }
                else if (cbxIzmeniTip.SelectedIndex == 1 || cbxIzmeniTip.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza1.listaParkingMesta[i].Image == null)
                            cbxIzmeniMesto.Items.Add(upis);
                    }
                }

            }
            else if (cbxIzmeniGar.SelectedIndex == 1)
            {
                if (cbxIzmeniTip.SelectedIndex == 0)
                {
                    if (checkBoxIzmeniInv.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza2.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza2.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                }
                else if (cbxIzmeniTip.SelectedIndex == 1 || cbxIzmeniTip.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza2.listaParkingMesta[i].Image == null)
                            cbxIzmeniMesto.Items.Add(upis);
                    }
                }
            }
            else if (cbxIzmeniGar.SelectedIndex == 2)
            {
                if (cbxIzmeniTip.SelectedIndex == 0)
                {
                    if (checkBoxIzmeniInv.Checked == false)
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza3.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                    else
                    {
                        for (int i = 20; i < 24; i++)
                        {

                            string upis = (i + 1).ToString();
                            if (garaza3.listaParkingMesta[i].Image == null)
                                cbxIzmeniMesto.Items.Add(upis);
                        }
                    }
                }
                else if (cbxIzmeniTip.SelectedIndex == 1 || cbxIzmeniTip.SelectedIndex == 2)
                {
                    for (int i = 24; i < 32; i++)
                    {
                        string upis = (i + 1).ToString();
                        if (garaza3.listaParkingMesta[i].Image == null)
                            cbxIzmeniMesto.Items.Add(upis);
                    }
                }
            }
        }

        private void checkBoxIzmeniInv_CheckedChanged(object sender, EventArgs e)
        {
            cbxIzmeniGar_SelectedIndexChanged(sender, e);
        }

        private void cbxIzmeniTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIzmeniGar_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region Aktivnosti
        public void AppendTextInfo(string text, Color color, bool NewLine, bool history)
        {
            if (history == true)
            {
                string txtAkcijaDodavanje = text.Substring(0, 10);//prvi parametar je index pocetka, drugi je offset!!!
                string txtAkcijaUklanjanje = text.Substring(0, 11);
                string txtAkcijaPreIzmene = text.Substring(0, 11);
                string txtAkcijaPosleIzmene = text.Substring(0, 13);
                string txtAkcijaProduzavanje = text.Substring(0, 13);
                string txtAkcijaRezervacija = text.Substring(0, 12);

                int index = text.IndexOf("|");//pozicija na kojoj se prvi put javlja | kao karakter

                if (txtAkcijaDodavanje=="Dodavanje:")
                {
                    int duzinaTekstaAkcije = index - 10;

                    txtInfoHistory.SelectionColor = Color.FromArgb(153, 255, 0);
                    txtInfoHistory.AppendText(txtAkcijaDodavanje);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(11,duzinaTekstaAkcije-1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");

                }
                else if(txtAkcijaUklanjanje=="Uklanjanje:")
                {
                    int duzinaTekstaAkcije = index - 11;

                    txtInfoHistory.SelectionColor = Color.FromArgb(255,102,102);
                    txtInfoHistory.AppendText(txtAkcijaUklanjanje);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(12,duzinaTekstaAkcije-1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");
                }
                else if(txtAkcijaPreIzmene=="Pre izmene:")
                {
                    int duzinaTekstaAkcije = index - 11;

                    txtInfoHistory.SelectionColor = Color.Aqua;
                    txtInfoHistory.AppendText(txtAkcijaPreIzmene);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(12,duzinaTekstaAkcije-1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");
                }
                else if(txtAkcijaPosleIzmene=="Posle izmene:")
                {
                    int duzinaTekstaAkcije = index - 13;

                    txtInfoHistory.SelectionColor = Color.Aqua;
                    txtInfoHistory.AppendText(txtAkcijaPosleIzmene);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(14,duzinaTekstaAkcije-1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");
                }
                else if(txtAkcijaProduzavanje=="Produžavanje:")
                {
                    int duzinaTekstaAkcije = index - 13;

                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 211, 78);
                    txtInfoHistory.AppendText(txtAkcijaProduzavanje);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(14, duzinaTekstaAkcije - 1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");
                }
                else if (txtAkcijaRezervacija == "Rezervacija:")
                {
                    int duzinaTekstaAkcije = index - 12;

                    txtInfoHistory.SelectionColor = Color.FromArgb(174, 99, 255);
                    txtInfoHistory.AppendText(txtAkcijaProduzavanje);
                    txtInfoHistory.SelectionColor = Color.White;
                    txtInfoHistory.AppendText(text.Substring(13, duzinaTekstaAkcije - 1));
                    txtInfoHistory.SelectionColor = Color.FromArgb(255, 5, 209);
                    txtInfoHistory.AppendText(text.Substring(index));
                    txtInfoHistory.AppendText("\n");
                }
            }
            else
            {
                if (NewLine)
                {
                    text += Environment.NewLine;
                }

                txtInfo.SelectionStart = txtInfo.TextLength;
                txtInfo.SelectionLength = 0;

                txtInfo.SelectionColor = color;
                txtInfo.AppendText(text);
                txtInfo.SelectionColor = txtInfo.ForeColor;
            }

        }

        private void btnTxtInfoHistory_Click(object sender, EventArgs e)
        {
            txtInfoHistory.Visible = !txtInfoHistory.Visible;
            if (txtInfoHistory.Visible == true)
                txtInfoHistory.BringToFront();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            panelClearHistory.Visible = true;
            panelClearHistory.BringToFront();
            gbxPocetak.Visible = false;
            gbxKraj.Visible = false;
            txtInfoHistory.Visible = false;
        }

        private void rdbPocetak_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPocetak.Checked == true)
            {
                gbxPocetak.Visible = true;
                gbxPocetak.BringToFront();
                numericPocetak.Maximum = baza.brojAktivnosti();
            }
            else
            {
                gbxKraj.Visible = true;
                gbxKraj.BringToFront();
                numericKraj.Maximum = baza.brojAktivnosti();
            }

        }

        private void rdbKraj_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKraj.Checked == true)
            {
                gbxKraj.Visible = true;
                gbxKraj.BringToFront();
                numericKraj.Maximum = baza.brojAktivnosti();
            }
            else
            {
                gbxPocetak.Visible = true;
                gbxPocetak.BringToFront();
                numericPocetak.Maximum = baza.brojAktivnosti();
            }

        }

        private void btnObrisiKraj_Click(object sender, EventArgs e)
        {
            if (baza.obrisiAktivnostiSaKraja(Convert.ToInt32(numericKraj.Value)))
            {
                labelPozicija.Text = "Aktivnosti uspešno obrisane.";
                labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                labelKorisnik.Text = "";
                timer1.Start();
                txtInfoHistory.Clear();
                if (baza.ucitajAktivnost() != null)
                {
                    foreach (string aktivnost in baza.ucitajAktivnost())
                    {
                        this.AppendTextInfo(aktivnost, Color.White, true, true);
                    }
                }
                numericPocetak.Maximum = baza.brojAktivnosti();
                numericKraj.Maximum = baza.brojAktivnosti();
                numericPocetak.Value = 0;
                numericKraj.Value = 0;
            }
            else
            {
                labelPozicija.Text = "Greška pri brisanju aktivnosti.";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                labelKorisnik.Text = "";
                timer1.Start();
            }
        }

        private void btnObrisiPocetak_Click(object sender, EventArgs e)
        {
            if (baza.obrisiAktivnostiSaPocetka(Convert.ToInt32(numericPocetak.Value)))
            {
                labelPozicija.Text = "Aktivnosti uspešno obrisane.";
                labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                labelKorisnik.Text = "";
                timer1.Start();
                txtInfoHistory.Clear();
                if (baza.ucitajAktivnost() != null)
                {
                    foreach (string aktivnost in baza.ucitajAktivnost())
                    {
                        this.AppendTextInfo(aktivnost, Color.White, true, true);
                    }
                }
                numericPocetak.Maximum = baza.brojAktivnosti();
                numericKraj.Maximum = baza.brojAktivnosti();
                numericPocetak.Value = 0;
                numericKraj.Value = 0;
            }
            else
            {
                labelPozicija.Text = "Greška pri brisanju aktivnosti.";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                labelKorisnik.Text = "";
                timer1.Start();
            }
        }
        #endregion

        private void btnCarSettings_Click(object sender, EventArgs e)
        {
            btnDodajVozilo.Visible = !btnDodajVozilo.Visible;
            btnIzmeniVozilo.Visible = !btnIzmeniVozilo.Visible;
            btnUkloniVozilo.Visible = !btnUkloniVozilo.Visible;
            if (zaposlenLog == "menadzer")
            {
                btnTxtInfoHistory.Visible = !btnTxtInfoHistory.Visible;
                btnClearHistory.Visible = !btnClearHistory.Visible;
            }
            groupBoxDodajVozilo.Visible = false;
            groupBoxIzmeniVozilo.Visible = false;
            groupBoxUkloniVozilo.Visible = false;
            txtInfoHistory.Visible = false;
            panelClearHistory.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (brSekundi == 3)
            {
                if (zaposlenLog == "menadzer")
                {
                    labelPozicija.Text = "Pozicija: " + "Menadžer";
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                    labelKorisnik.Text = "Korisnik: " + trenutniKorisnik;
                    labelKorisnik.Visible = true;
                }
                else if (zaposlenLog == "menadzer")
                {
                    labelPozicija.Text = "Pozicija: " + "Radnik";
                    labelKorisnik.Text = "Korisnik: " + trenutniKorisnik;
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                }
                else
                {
                    labelPozicija.Text = "Potrebno je da se ulogujete.";
                    labelKorisnik.Text = "";
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                }
                brSekundi = 0;
                timer1.Stop();
            }

            brSekundi++;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (brSekundi == 2)
            {
                if (zaposlenLog == "menadzer")
                {
                    labelPozicija.Text = "Pozicija: " + "Menadžer";
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                    labelKorisnik.Text = "Korisnik: " + trenutniKorisnik;
                    labelKorisnik.Visible = true;
                }
                else if (zaposlenLog == "menadzer")
                {
                    labelPozicija.Text = "Pozicija: " + "Radnik";
                    labelKorisnik.Text = "Korisnik: " + trenutniKorisnik;
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                }
                else
                {
                    labelPozicija.Text = "Potrebno je da se ulogujete.";
                    labelKorisnik.Text = "";
                    labelPozicija.ForeColor = Color.FromArgb(0, 102, 204);
                }
                brSekundi = 0;
                timer2.Stop();
            }

            brSekundi++;
        }

        #region IstorijaParkiranja
        private void buttonIstorijaParkiranja_Click(object sender, EventArgs e)
        {
            if(SlideMenu.Width!=50)
            {
                LogoAnimator.Hide(Logo);
                SlideMenu.Visible = false;
                SlideMenu.Width = 50;
                PanelAnimator.ShowSync(SlideMenu);
            }

            trenutnaOpcija = "istorijaParkiranja";
            panelLogovanje.Hide();
            panelGaraze.Hide();
            panelUsluge.Hide();
            panelStatistika.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelPreostaloVreme.Hide();
            panelIstorijaParkiranja.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonIstorijaParkiranja.Location.Y);

            rdbIstorijaGaraza1.Checked = false;
            rdbIstorijaGaraza2.Checked = false;
            rdbIstorijaGaraza3.Checked = false;
            txtIstorijaMesto.Text = "";
            cbxIstorijaTipVozila.SelectedIndex = -1;
            txtIstorijaRegistracija.Text = "";
            cbxIstorijaUsluga.SelectedIndex = -1;
            cbxIstorijaTermin.SelectedIndex = -1;
            txtIstorijaOd.Text = "";
            txtIstorijaDo.Text = "";
            istorijaParkiranjaDatumDoKliknut = false;
            istorijaParkiranjaDatumOdKliknut = false;


          

            /* if (SlideMenu.Width == 50)
             {
                 if (slajdIstorijaParkiranja == "prosiren")
                 {
                     this.panelIstorijaParkiranja.Location = new Point(this.panelIstorijaParkiranja.Location.X - 150, this.panelIstorijaParkiranja.Location.Y);
                     slajdIstorijaParkiranja = "uvucen";
                 }
             }
             else
             {
                 if (slajdIstorijaParkiranja == "uvucen")
                 {
                     this.panelIstorijaParkiranja.Location = new Point(this.panelIstorijaParkiranja.Location.X + 150, this.panelIstorijaParkiranja.Location.Y);
                     slajdIstorijaParkiranja = "prosiren";
                 }
             }*/

            List<ParkingMesto> lista = new List<ParkingMesto>();
            lista = this.baza.istorijaParkiranja();
            numericUpDownIstorijaParkiranjaBrisanje.Maximum = lista.Count;
            dataGrid.Rows.Clear();

            foreach(ParkingMesto p in lista)
            {
                string inv = "";
                if(p.Vozilo.DalijeInvalidsko==true)
                    inv = "✔";
                else
                    inv = "✘";
                string usluga = "";
                switch(p.Vozilo.UslugaParkingServisa)
                {
                    case 1:usluga = "jednočаsovna";break;
                    case 12:usluga = "poludnevna";break;
                    case 24:usluga = "dnevna";break;
                    case 168:usluga = "nedeljna";break;
                    case 720:usluga = "mesečna";break;
                    default:break;
                }

                dataGrid.Rows.Add
                    (
                    new object[]
                    {
                        p.BrGaraze,
                        p.Broj,
                        p.Vozilo.TipVozila,
                        inv,
                        p.Vozilo.RegTab,
                        p.Vozilo.PocetakParkiranja,
                        p.Vozilo.KrajParkiranja,
                        usluga,
                        p.Vozilo.Racun+" RSD"
                    }
                    );
            }
        }

        private void btnObrisiNajstarijaParkiranja_Click(object sender, EventArgs e)
        {
            this.baza.obrisiParkingIstoriju(Convert.ToInt32(numericUpDownIstorijaParkiranjaBrisanje.Value));
            this.buttonIstorijaParkiranja_Click(sender, e);
            numericUpDownIstorijaParkiranjaBrisanje.Value = 0;
        }

        public void filtrirajIstorijuParkiranja()
        {
            dataGrid.Rows.Clear();

            List<ParkingMesto> filtriranaLista = new List<ParkingMesto>();
            List<ParkingMesto> pomocnaLista = new List<ParkingMesto>();

            int garaza = -1;
            int mesto = -1;

            if (rdbIstorijaGaraza1.Checked == true)
                garaza = 1;
            else if (rdbIstorijaGaraza2.Checked == true)
                garaza = 2;
            else if (rdbIstorijaGaraza3.Checked == true)
                garaza = 3;

            if (int.TryParse(txtIstorijaMesto.Text, out mesto))
            { }
            else
            {
                mesto = -1;
            }

            //filtriranje za garazu i mesto
            if (garaza!=-1)
            {
                if(mesto!=-1)
                { 
                    foreach (ParkingMesto p in this.baza.istorijaParkiranja())
                    {
                        if (p.BrGaraze == garaza && p.Broj==mesto)
                            pomocnaLista.Add(p);
                    }
                }
                else
                {
                    foreach (ParkingMesto p in this.baza.istorijaParkiranja())
                    {
                        if (p.BrGaraze == garaza)
                            pomocnaLista.Add(p);
                    }
                }
            }
            else
            {
                if(mesto!=-1)
                {
                        foreach (ParkingMesto p in this.baza.istorijaParkiranja())
                        {
                            if (p.Broj == mesto)
                                pomocnaLista.Add(p);
                        }
                }
                else
                {
                    foreach (ParkingMesto p in this.baza.istorijaParkiranja())
                    {
                            pomocnaLista.Add(p);
                    }
                }
            }
            //nakon filtriranja garaze i mesta rezultat je u pomocnaLista

            //filtriranje tipa vozila i invaliditeta
            switch(cbxIstorijaTipVozila.SelectedIndex)
            {
                case 0:
                    foreach(ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.TipVozila == "automobil")
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 1:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.TipVozila == "automobil" && p.Vozilo.DalijeInvalidsko==true)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 2:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.TipVozila == "automobil" && p.Vozilo.DalijeInvalidsko == false)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 3:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.TipVozila == "autobus")
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 4:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.TipVozila == "kamion")
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                default:
                    break;
            }
            //nakon filtriranja tipa vozila i invaliditeta rezultat je u pomocnaLista

            filtriranaLista.Clear();

            //filtriranje za registraciju
            if (txtIstorijaRegistracija.Text != null && txtIstorijaRegistracija.Text!="")
            {
                foreach(ParkingMesto p in pomocnaLista)
                {
                    if (p.Vozilo.RegTab.StartsWith(txtIstorijaRegistracija.Text))
                        filtriranaLista.Add(p);
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);
            }
            //nakon filtriranja registracije rezultat je u pomocnaLista
            filtriranaLista.Clear();

            //filtriranje usluge
            switch (cbxIstorijaUsluga.SelectedIndex)
            {
                case 0:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.UslugaParkingServisa == 1)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 1:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.UslugaParkingServisa == 12)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 2:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.UslugaParkingServisa == 24)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 3:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.UslugaParkingServisa == 168)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                case 4:
                    foreach (ParkingMesto p in pomocnaLista)
                    {
                        if (p.Vozilo.UslugaParkingServisa == 720)
                            filtriranaLista.Add(p);
                    }
                    pomocnaLista = new List<ParkingMesto>(filtriranaLista);
                    break;

                default:
                    break;
            }
            //nakon filtriranja usluge rezultat se nalazi u pomocnaLista
            filtriranaLista.Clear();

            //filtriranje racuna
            if(txtIstorijaOd.Text!="" && txtIstorijaOd!=null)
            {
                foreach(ParkingMesto p in pomocnaLista)
                {
                    if (p.Vozilo.Racun >= Convert.ToInt32(txtIstorijaOd.Text))
                        filtriranaLista.Add(p);
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);
            }
            filtriranaLista.Clear();

            if (txtIstorijaDo.Text != "" && txtIstorijaDo != null)
            {
                foreach (ParkingMesto p in pomocnaLista)
                {
                    if (p.Vozilo.Racun <= Convert.ToInt32(txtIstorijaDo.Text))
                        filtriranaLista.Add(p);
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);
            }
            //nakon filtriranja racuna rezultat se nalazi u pomocnaLista
            filtriranaLista.Clear();

            //filtriranje datuma
            if (istorijaParkiranjaDatumOdKliknut == true && istorijaPocetakPreskoci==false)
            {
                string datumOd = dtpIstorijaPocetak.Value.ToString("yyyy/MM/dd");

                foreach (ParkingMesto p in pomocnaLista)
                {
                    string VozilodatumOd = p.Vozilo.PocetakParkiranja.ToString("yyyy/MM/dd");
                   
                    if (DateTime.Parse(VozilodatumOd) >= DateTime.Parse(datumOd))
                    {
                        filtriranaLista.Add(p);
                    }
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);

                
            }

            filtriranaLista.Clear();

            if (istorijaParkiranjaDatumDoKliknut==true && istorijaKrajPreskoci==false)
            {
                string datumDo = dtpIstorijaKraj.Value.ToString("yyyy/MM/dd");

                foreach (ParkingMesto p in pomocnaLista)
                {
                    string VozilodatumDo = p.Vozilo.KrajParkiranja.ToString("yyyy/MM/dd");

                    if (DateTime.Parse(VozilodatumDo) <= DateTime.Parse(datumDo))
                    {
                        filtriranaLista.Add(p);
                    }
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);

                
            }

            filtriranaLista.Clear();
            //nakon filtriranja datuma  rezultat je u pomocnaLista

            //filtriranje termina
             if(cbxIstorijaTermin.SelectedIndex>=0 && cbxIstorijaTermin.SelectedIndex<=24)
            {
                foreach(ParkingMesto p in pomocnaLista)
                {
                    if(p.Vozilo.PocetakParkiranja.Hour==cbxIstorijaTermin.SelectedIndex)
                    {
                        filtriranaLista.Add(p);
                    }
                }
                pomocnaLista = new List<ParkingMesto>(filtriranaLista);
            }

            filtriranaLista.Clear();
            //nakon filtriranja termina rezultat je u pomocnaLista

            foreach (ParkingMesto p in pomocnaLista)
            {
                string inv = "";
                if (p.Vozilo.DalijeInvalidsko == true)
                    inv = "✔";
                else
                    inv = "✘";
                string usluga = "";
                switch (p.Vozilo.UslugaParkingServisa)
                {
                    case 1: usluga = "jednočаsovna"; break;
                    case 12: usluga = "poludnevna"; break;
                    case 24: usluga = "dnevna"; break;
                    case 168: usluga = "nedeljna"; break;
                    case 720: usluga = "mesečna"; break;
                    default: break;
                }

                dataGrid.Rows.Add
                    (
                    new object[]
                    {
                        p.BrGaraze,
                        p.Broj,
                        p.Vozilo.TipVozila,
                        inv,
                        p.Vozilo.RegTab,
                        p.Vozilo.PocetakParkiranja,
                        p.Vozilo.KrajParkiranja,
                        usluga,
                        p.Vozilo.Racun+" RSD"
                    }
                    );
            }


        }

        private void istorijaCbxGaraza_onItemSelected(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void btnPonistiFiltere_Click(object sender, EventArgs e)
        {
            istorijaPocetakPreskoci = true;
            istorijaKrajPreskoci = true;
            istorijaParkiranjaDatumDoKliknut = false;
            istorijaParkiranjaDatumOdKliknut = false;
            this.buttonIstorijaParkiranja_Click(sender, e);
            dtpIstorijaPocetak.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
            dtpIstorijaKraj.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
            istorijaKrajPreskoci = false;
            istorijaPocetakPreskoci = false;
            istorijaParkiranjaDatumDoKliknut = false;
            istorijaParkiranjaDatumOdKliknut = false;
        }

        private void rdbIstorijaGaraza1_CheckedChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void rdbIstorijaGaraza2_CheckedChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void rdbIstorijaGaraza3_CheckedChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void txtIstorijaMesto_OnValueChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void cbxIstorijaTipVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void txtIstorijaRegistracija_OnValueChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void cbxIstorijaUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void txtIstorijaOd_OnValueChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void txtIstorijaDo_OnValueChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        private void dtpIstorijaPocetak_onValueChanged(object sender, EventArgs e)
        {
            istorijaParkiranjaDatumOdKliknut = true;
            this.filtrirajIstorijuParkiranja();
        }

        private void dtpIstorijaKraj_onValueChanged(object sender, EventArgs e)
        {
            istorijaParkiranjaDatumDoKliknut = true;
            this.filtrirajIstorijuParkiranja();
        }

        private void cbxIstorijaTermin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrirajIstorijuParkiranja();
        }

        #endregion

        #region UslugeSnizenja
        private void buttonUsluge_Click(object sender, EventArgs e)
        {
            List<int> lista = this.baza.CeneSniznjaPopusti();

            this.dataGridUsluge.Rows.Clear();
            this.dataGridUsluge.AllowUserToAddRows = false;
            this.dataGridUsluge.Rows.Add("jednočasovna", "automobil", lista[0] + " RSD", lista[1], lista[2]);
            this.dataGridUsluge.Rows.Add("poludnevna", "automobil", lista[3] + " RSD", lista[4], lista[5]);
            this.dataGridUsluge.Rows.Add("dnevna", "automobil", lista[6] + " RSD", lista[7], lista[8]);
            this.dataGridUsluge.Rows.Add("nedeljna", "automobil", lista[9] + " RSD", lista[10], lista[11]);
            this.dataGridUsluge.Rows.Add("mesečna", "automobil", lista[12] + " RSD", lista[13], lista[14]);
            this.dataGridUsluge.Rows.Add("jednočasovna", "autobus", lista[15] + " RSD", lista[16], lista[17]);
            this.dataGridUsluge.Rows.Add("poludnevna", "autobus", lista[18] + " RSD", lista[19], lista[20]);
            this.dataGridUsluge.Rows.Add("dnevna", "autobus", lista[21] + " RSD", lista[22], lista[23]);
            this.dataGridUsluge.Rows.Add("nedeljna", "autobus", lista[24] + " RSD", lista[25], lista[26]);
            this.dataGridUsluge.Rows.Add("mesečna", "autobus", lista[27] + " RSD", lista[28], lista[29]);
            this.dataGridUsluge.Rows.Add("jednočasovna", "kamion", lista[30] + " RSD", lista[31], lista[32]);
            this.dataGridUsluge.Rows.Add("poludnevna", "kamion", lista[33] + " RSD", lista[34], lista[35]);
            this.dataGridUsluge.Rows.Add("dnevna", "kamion", lista[36] + " RSD", lista[37], lista[38]);
            this.dataGridUsluge.Rows.Add("nedeljna", "kamion", lista[39] + " RSD", lista[40], lista[41]);
            this.dataGridUsluge.Rows.Add("mesečna", "kamion", lista[42] + " RSD", lista[43], lista[44]);
            this.dataGridUsluge.ClearSelection();

            trenutnaOpcija = "usluge";
            panelLogovanje.Hide();
            panelGaraze.Hide();
            panelIstorijaParkiranja.Hide();
            panelStatistika.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelPreostaloVreme.Hide();
            panelUsluge.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUsluge.Location.Y);

            groupBoxUslugePrikaz.Visible = false;

            if (SlideMenu.Width == 50)
            {
                if (slajdUsluge == "prosiren")
                {
                    this.panelUsluge.Location = new Point(this.panelUsluge.Location.X - 100, this.panelUsluge.Location.Y);
                    slajdUsluge = "uvucen";
                }
            }
            else
            {
                if (slajdUsluge == "uvucen")
                {
                    this.panelUsluge.Location = new Point(this.panelUsluge.Location.X + 100, this.panelUsluge.Location.Y);
                    slajdUsluge = "prosiren";
                }
            }

        }

        private void dataGridUsluge_SelectionChanged(object sender, EventArgs e)
        {
            txtUslugaCena.Text = "";
            checkUslugaSnizenje.Checked = false;
            cbxUslugaPopust.SelectedIndex = -1;
            cbxUslugaPopust.Text = "";

            List<int> lista = this.baza.CeneSniznjaPopusti();

            if (zaposlenLog=="menadzer")
            {
                this.groupBoxUslugePrikaz.Visible = true;
                txtUslugaCena.Enabled = false;
                cbxUslugaPopust.Enabled = false;
                checkUslugaSnizenje.Enabled = false;
                btnSacuvajIzmeneUsluge.Visible = false;

                switch(this.dataGridUsluge.CurrentRow.Index)
                {
                    case 0:
                        labelUslugaUsluga.Text = "jednočasovna";
                        labelUslugaVozilo.Text = "automobil";
                        txtUslugaCena.Text = lista[0].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[1]);
                        cbxUslugaPopust.SelectedValue = lista[2];
                        
                        break;
                    case 1:
                        labelUslugaUsluga.Text = "poludnevna";
                        labelUslugaVozilo.Text = "automobil";
                        txtUslugaCena.Text = lista[3].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[4]);
                        cbxUslugaPopust.SelectedValue = lista[5];
                        break;
                    case 2:
                        labelUslugaUsluga.Text = "dnevna";
                        labelUslugaVozilo.Text = "automobil";
                        txtUslugaCena.Text = lista[6].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[7]);
                        cbxUslugaPopust.SelectedValue = lista[8];
                        break;
                    case 3:
                        labelUslugaUsluga.Text = "nedeljna";
                        labelUslugaVozilo.Text = "automobil";
                        txtUslugaCena.Text = lista[9].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[10]);
                        cbxUslugaPopust.SelectedValue = lista[11];
                        break;
                    case 4:
                        labelUslugaUsluga.Text = "mesečna";
                        labelUslugaVozilo.Text = "automobil";
                        txtUslugaCena.Text = lista[12].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[13]);
                        cbxUslugaPopust.SelectedValue = lista[14];
                        break;
                    case 5:
                        labelUslugaUsluga.Text = "jednočasovna";
                        labelUslugaVozilo.Text = "autobus";
                        txtUslugaCena.Text = lista[15].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[16]);
                        cbxUslugaPopust.SelectedValue = lista[17];
                        break;
                    case 6:
                        labelUslugaUsluga.Text = "poludnevna";
                        labelUslugaVozilo.Text = "autobus";
                        txtUslugaCena.Text = lista[18].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[19]);
                        cbxUslugaPopust.SelectedValue = lista[20];
                        break;
                    case 7:
                        labelUslugaUsluga.Text = "dnevna";
                        labelUslugaVozilo.Text = "autobus";
                        txtUslugaCena.Text = lista[21].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[22]);
                        cbxUslugaPopust.SelectedValue = lista[23];
                        break;
                    case 8:
                        labelUslugaUsluga.Text = "nedeljna";
                        labelUslugaVozilo.Text = "autobus";
                        txtUslugaCena.Text = lista[24].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[25]);
                        cbxUslugaPopust.SelectedValue = lista[26];
                        break;
                    case 9:
                        labelUslugaUsluga.Text = "mesečna";
                        labelUslugaVozilo.Text = "autobus";
                        txtUslugaCena.Text = lista[27].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[28]);
                        cbxUslugaPopust.SelectedValue = lista[29];
                        break;
                    case 10:
                        labelUslugaUsluga.Text = "jednočasovna";
                        labelUslugaVozilo.Text = "kamion";
                        txtUslugaCena.Text = lista[30].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[31]);
                        cbxUslugaPopust.SelectedValue = lista[32];
                        break;
                    case 11:
                        labelUslugaUsluga.Text = "poludnevna";
                        labelUslugaVozilo.Text = "kamion";
                        txtUslugaCena.Text = lista[33].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[34]);
                        cbxUslugaPopust.SelectedValue = lista[35];
                        break;
                    case 12:
                        labelUslugaUsluga.Text = "dnevna";
                        labelUslugaVozilo.Text = "kamion";
                        txtUslugaCena.Text = lista[36].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[37]);
                        cbxUslugaPopust.SelectedValue = lista[38];
                        break;
                    case 13:
                        labelUslugaUsluga.Text = "nedeljna";
                        labelUslugaVozilo.Text = "kamion";
                        txtUslugaCena.Text = lista[39].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[40]);
                        cbxUslugaPopust.SelectedValue = lista[41];
                        break;
                    case 14:
                        labelUslugaUsluga.Text = "mesečna";
                        labelUslugaVozilo.Text = "kamion";
                        txtUslugaCena.Text = lista[42].ToString();
                        checkUslugaSnizenje.Checked = Convert.ToBoolean(lista[43]);
                        cbxUslugaPopust.SelectedValue = lista[44];
                        break;
                }
            }

            if(checkUslugaSnizenje.Checked==true)
            {
                cbxUslugaPopust.Items.Clear();
                cbxUslugaPopust.Items.Add("Poništi popust");
            }
            else
            {
                cbxUslugaPopust.Items.Clear();
                cbxUslugaPopust.Items.Add(5);
                cbxUslugaPopust.Items.Add(10);
                cbxUslugaPopust.Items.Add(15);
                cbxUslugaPopust.Items.Add(20);
                cbxUslugaPopust.Items.Add(25);
                cbxUslugaPopust.Items.Add(30);
                cbxUslugaPopust.Items.Add(35);
                cbxUslugaPopust.Items.Add(40);
                cbxUslugaPopust.Items.Add(45);
                cbxUslugaPopust.Items.Add(50);
                cbxUslugaPopust.Items.Add(55);
                cbxUslugaPopust.Items.Add(60);
                cbxUslugaPopust.Items.Add(65);
                cbxUslugaPopust.Items.Add(70);
            }
        }

        private void btnIzmeniUsluge_Click(object sender, EventArgs e)
        {
            txtUslugaCena.Enabled = true;
            cbxUslugaPopust.Enabled = true;
            checkUslugaSnizenje.Enabled= true;
            btnSacuvajIzmeneUsluge.Visible = true;
        }

        private void btnSacuvajIzmeneUsluge_Click(object sender, EventArgs e)
        {
            int snizenje = -1;
            int popust = 0;
            int cena = Convert.ToInt32(txtUslugaCena.Text);

            if(cbxUslugaPopust.Items.Count==1)
            {
                if (checkUslugaSnizenje.Checked == true)
                    snizenje = 1;
                else
                    snizenje = 0;
            }
            else if(cbxUslugaPopust.Items.Count==14)
            {
                if (cbxUslugaPopust.SelectedIndex >= 0)
                    snizenje = 1;
                else
                    snizenje = 0;
            }

            if(cbxUslugaPopust.Items.Count==1)
            {
                if (cbxUslugaPopust.SelectedIndex == 0)
                    popust = 0;
            }

            if (cbxUslugaPopust.Items.Count==14)
            {
                switch (cbxUslugaPopust.SelectedIndex)
                {
                    case 0: popust = 5; break;
                    case 1: popust = 10; break;
                    case 2: popust = 15; break;
                    case 3: popust = 20; break;
                    case 4: popust = 25; break;
                    case 5: popust = 30; break;
                    case 6: popust = 35; break;
                    case 7: popust = 40; break;
                    case 8: popust = 45; break;
                    case 9: popust = 50; break;
                    case 10: popust = 55; break;
                    case 11: popust = 60; break;
                    case 12: popust = 65; break;
                    case 13: popust = 70; break;


                }

            }

            if(labelUslugaVozilo.Text=="automobil")
            {
                if(labelUslugaUsluga.Text=="jednočasovna")
                {
                    baza.izmeniUslugu("1hautomobil", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    baza.izmeniUslugu("12hautomobil", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    baza.izmeniUslugu("24hautomobil", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    baza.izmeniUslugu("168hautomobil", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    baza.izmeniUslugu("720hautomobil", cena, snizenje, popust);
                }
            }
            else if(labelUslugaVozilo.Text=="autobus")
            {
                if (labelUslugaUsluga.Text == "jednočasovna")
                {
                    baza.izmeniUslugu("1hautobus", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    baza.izmeniUslugu("12hautobus", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    baza.izmeniUslugu("24hautobus", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    baza.izmeniUslugu("168hautobus", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    baza.izmeniUslugu("720hautobus", cena, snizenje, popust);
                }
            }
            else if(labelUslugaVozilo.Text=="kamion")
            {
                if (labelUslugaUsluga.Text == "jednočasovna")
                {
                    baza.izmeniUslugu("1hkamion", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    baza.izmeniUslugu("12hkamion", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    baza.izmeniUslugu("24hkamion", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    baza.izmeniUslugu("168hkamion", cena, snizenje, popust);
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    baza.izmeniUslugu("720hkamion", cena, snizenje, popust);
                }
            }

            List<int> lista = this.baza.CeneSniznjaPopusti();

            this.dataGridUsluge.Rows.Clear();
            this.dataGridUsluge.AllowUserToAddRows = false;
            this.dataGridUsluge.Rows.Add("jednočasovna", "automobil", lista[0] + " RSD", lista[1], lista[2]);
            this.dataGridUsluge.Rows.Add("poludnevna", "automobil", lista[3] + " RSD", lista[4], lista[5]);
            this.dataGridUsluge.Rows.Add("dnevna", "automobil", lista[6] + " RSD", lista[7], lista[8]);
            this.dataGridUsluge.Rows.Add("nedeljna", "automobil", lista[9] + " RSD", lista[10], lista[11]);
            this.dataGridUsluge.Rows.Add("mesečna", "automobil", lista[12] + " RSD", lista[13], lista[14]);
            this.dataGridUsluge.Rows.Add("jednočasovna", "autobus", lista[15] + " RSD", lista[16], lista[17]);
            this.dataGridUsluge.Rows.Add("poludnevna", "autobus", lista[18] + " RSD", lista[19], lista[20]);
            this.dataGridUsluge.Rows.Add("dnevna", "autobus", lista[21] + " RSD", lista[22], lista[23]);
            this.dataGridUsluge.Rows.Add("nedeljna", "autobus", lista[24] + " RSD", lista[25], lista[26]);
            this.dataGridUsluge.Rows.Add("mesečna", "autobus", lista[27] + " RSD", lista[28], lista[29]);
            this.dataGridUsluge.Rows.Add("jednočasovna", "kamion", lista[30] + " RSD", lista[31], lista[32]);
            this.dataGridUsluge.Rows.Add("poludnevna", "kamion", lista[33] + " RSD", lista[34], lista[35]);
            this.dataGridUsluge.Rows.Add("dnevna", "kamion", lista[36] + " RSD", lista[37], lista[38]);
            this.dataGridUsluge.Rows.Add("nedeljna", "kamion", lista[39] + " RSD", lista[40], lista[41]);
            this.dataGridUsluge.Rows.Add("mesečna", "kamion", lista[42] + " RSD", lista[43], lista[44]);
            this.dataGridUsluge.ClearSelection();

            groupBoxUslugePrikaz.Visible = false;
            txtUslugaCena.Text = "";
            checkUslugaSnizenje.Checked = false;
            cbxUslugaPopust.SelectedIndex = -1;
            cbxUslugaPopust.Text = "";
        }

        private void cbxUslugaPopust_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<int> lista = new List<int>();
            string usluga = "";

            if (labelUslugaVozilo.Text == "automobil")
            {
                if (labelUslugaUsluga.Text == "jednočasovna")
                {
                    usluga = "1hautomobil";
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    usluga = "12hautomobil";
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    usluga = "24hautomobil";
                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    usluga = "168hautomobil";
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    usluga = "720hautomobil";
                }
            }
            else if (labelUslugaVozilo.Text == "autobus")
            {
                if (labelUslugaUsluga.Text == "jednočasovna")
                {
                    usluga = "1hautobus";
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    usluga = "12hautobus";
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    usluga = "24hautobus";

                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    usluga = "168hautobus";
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    usluga = "720hautobus";
                }
            }
            else if (labelUslugaVozilo.Text == "kamion")
            {
                if (labelUslugaUsluga.Text == "jednočasovna")
                {
                    usluga = "1hkamion";
                }
                else if (labelUslugaUsluga.Text == "poludnevna")
                {
                    usluga = "12hkamion";
                }
                else if (labelUslugaUsluga.Text == "dnevna")
                {
                    usluga = "24hkamion";
                }
                else if (labelUslugaUsluga.Text == "nedeljna")
                {
                    usluga = "168hkamion";
                }
                else if (labelUslugaUsluga.Text == "mesečna")
                {
                    usluga = "720hkamion";
                }
            }

            lista = baza.vratiPodatkeUsluge(usluga);

            decimal cena = lista[0];

            if(lista[1]==1)
            {
                if(cbxUslugaPopust.SelectedIndex==0)
                {
                    int ponistiPopust = lista[2];
                    cena = Math.Floor(cena * 100 / (100 - ponistiPopust));
                    checkUslugaSnizenje.Checked = false;
                }
            }
            else
            {
                checkUslugaSnizenje.Checked = true;

                switch (cbxUslugaPopust.SelectedIndex)
                {
                    case 0: cena = Math.Ceiling(cena * 95 / 100); break;
                    case 1: cena = Math.Ceiling(cena * 90 / 100); break;
                    case 2: cena = Math.Ceiling(cena * 85 / 100); break;
                    case 3: cena = Math.Ceiling(cena * 80 / 100); break;
                    case 4: cena = Math.Ceiling(cena * 75 / 100); break;
                    case 5: cena = Math.Ceiling(cena * 70 / 100); break;
                    case 6: cena = Math.Ceiling(cena * 65 / 100); break;
                    case 7: cena = Math.Ceiling(cena * 60 / 100); break;
                    case 8: cena = Math.Ceiling(cena * 55 / 100); break;
                    case 9: cena = Math.Ceiling(cena * 50 / 100); break;
                    case 10: cena = Math.Ceiling(cena * 45 / 100); break;
                    case 11: cena = Math.Ceiling(cena * 40 / 100); break;
                    case 12: cena = Math.Ceiling(cena * 35 / 100); break;
                    case 13: cena = Math.Ceiling(cena * 30 / 100); break;

                }
            }
            txtUslugaCena.Text = cena.ToString();
        }


        #endregion

        #region Statistika
        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            
            trenutnaOpcija = "statistika";
            panelLogovanje.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            panelGaraze.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelPreostaloVreme.Hide();
            panelStatistika.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonStatistika.Location.Y);

            this.panelStatistika.Visible = true;
            this.panelStatistikaProcenti.Visible = false;

            this.labelStatistikaOpcija.Visible = false;
            this.btnNajpozeljnijaParkingMesta.Visible = true;
            this.labelNajpozeljnijaParkingMesta.Visible = true;
            this.btnNajpozeljnijeGaraze.Visible = true;
            this.labelNajpozeljnijeGaraze.Visible = true;
            this.btnNajpozeljnijeUsluge.Visible = true;
            this.labelNajpozeljnijeUsluge.Visible = true;
            this.btnNajpozeljnijiTermini.Visible = true;
            this.labelNajpozeljnijiTermini.Visible = true;


            if (SlideMenu.Width == 50)
            {
                if (slajdStatistika == "prosiren")
                {
                    this.panelStatistika.Location = new Point(this.panelStatistika.Location.X - 100, this.panelStatistika.Location.Y);
                    slajdStatistika = "uvucen";
                }
            }
            else
            {
                if (slajdStatistika == "uvucen")
                {
                    this.panelStatistika.Location = new Point(this.panelStatistika.Location.X + 100, this.panelStatistika.Location.Y);
                    slajdStatistika = "prosiren";
                }
            }

        }

        private void btnNajpozeljnijeUsluge_Click(object sender, EventArgs e)
        {
            this.btnNajpozeljnijaParkingMesta.Visible = true;
            this.labelNajpozeljnijaParkingMesta.Visible = true;
            this.btnNajpozeljnijeGaraze.Visible = true;
            this.labelNajpozeljnijeGaraze.Visible = true;
            this.btnNajpozeljnijeUsluge.Visible = false;
            this.labelNajpozeljnijeUsluge.Visible = false;
            this.btnNajpozeljnijiTermini.Visible = true;
            this.labelNajpozeljnijiTermini.Visible = true;
            this.panelStatistikaProcenti.Visible = true;
            this.progressBar1.Visible = true;
            this.progressBar2.Visible = true;
            this.progressBar3.Visible = true;
            this.progressBar4.Visible = true;
            this.panelProgressBar4.Visible = true;
            this.progressBar1linija9.Visible = false;
            this.progressBar2linija9.Visible = false;
            this.progressBar3linija9.Visible = false;
            this.progressBar4linija9.Visible = false;
            this.progressBar1linija10.Visible = false;
            this.progressBar2linija10.Visible = false;
            this.progressBar3linija10.Visible = false;
            this.progressBar4linija10.Visible = false;
            this.labelStatistikaOpcija.Text = "Najpoželjnije parking usluge";
            this.labelStatistikaOpcija.Visible = true;

            List<int> usluge = new List<int>(); //0 je 1hAuto, 5 je 1hBus, 10 je 1hKamion

            for(int i=0;i<15;i++)
            {
                usluge.Add(0);
            }

            int ukupanBrojUsluga = 0;

            foreach(ParkingMesto p in this.baza.istorijaParkiranja())
            {
                ukupanBrojUsluga++;
                switch (p.Vozilo.UslugaParkingServisa)
                {
                    case 1:
                        if(p.Vozilo.TipVozila=="automobil")
                        {
                            usluge[0]++;
                        }
                        else if(p.Vozilo.TipVozila=="autobus")
                        {
                            usluge[5]++;
                        }
                        else if(p.Vozilo.TipVozila=="kamion")
                        {
                            usluge[10]++;
                        }
                        break;

                    case 12:
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            usluge[1]++;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            usluge[6]++;
                        }
                        else if (p.Vozilo.TipVozila == "kamion")
                        {
                            usluge[11]++;
                        }
                        break;

                    case 24:
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            usluge[2]++;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            usluge[7]++;
                        }
                        else if (p.Vozilo.TipVozila == "kamion")
                        {
                            usluge[12]++;
                        }
                        break;

                    case 168:
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            usluge[3]++;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            usluge[8]++;
                        }
                        else if (p.Vozilo.TipVozila == "kamion")
                        {
                            usluge[13]++;
                        }
                        break;

                    case 720:
                        if (p.Vozilo.TipVozila == "automobil")
                        {
                            usluge[4]++;
                        }
                        else if (p.Vozilo.TipVozila == "autobus")
                        {
                            usluge[9]++;
                        }
                        else if (p.Vozilo.TipVozila == "kamion")
                        {
                            usluge[14]++;
                        }
                        break;

                }
            }

            //                      1. USLUGA
            int max = usluge.Max();
            int indeks = usluge.IndexOf(max);
            usluge[indeks] = 0;

            progressBar1.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 /ukupanBrojUsluga)));

            progressBar1linija1.Text = "Usluga";
            progressBar1linija1.ForeColor = Color.SpringGreen;
            switch(indeks)
            {
                case 0:
                    progressBar1linija2.Text = "jednočasovna za automobile";
                    break;
                case 1:
                    progressBar1linija2.Text = "poludnevna za automobile";
                    break;
                case 2:
                    progressBar1linija2.Text = "dnevna za automobile";
                    break;
                case 3:
                    progressBar1linija2.Text = "nedeljna za automobile";
                    break;
                case 4:
                    progressBar1linija2.Text = "mesečna za automobile";
                    break;
                case 5:
                    progressBar1linija2.Text = "jednočasovna za autobuse";
                    break;
                case 6:
                    progressBar1linija2.Text = "poludnevna za autobuse";
                    break;
                case 7:
                    progressBar1linija2.Text = "dnevna za autobuse";
                    break;
                case 8:
                    progressBar1linija2.Text = "nedeljna za autobuse";
                    break;
                case 9:
                    progressBar1linija2.Text = "mesečna za autobuse";
                    break;
                case 10:
                    progressBar1linija2.Text = "jednočasovna za kamione";
                    break;
                case 11:
                    progressBar1linija2.Text = "poludnevna za kamione";
                    break;
                case 12:
                    progressBar1linija2.Text = "dnevna za kamione";
                    break;
                case 13:
                    progressBar1linija2.Text = "nedeljna za kamione";
                    break;
                case 14:
                    progressBar1linija2.Text = "mesečna za kamione";
                    break;
                default:
                    break;
                
            }
            progressBar1linija2.ForeColor = Color.White;
            progressBar1linija3.Text = "Broj odabira usluge";
            progressBar1linija3.ForeColor = Color.SpringGreen;
            progressBar1linija4.Text = max.ToString();
            progressBar1linija4.ForeColor = Color.White;
            progressBar1linija5.Text = "Ukupan broj parkiranja";
            progressBar1linija5.ForeColor = Color.SpringGreen;
            progressBar1linija6.Text = ukupanBrojUsluga.ToString();
            progressBar1linija6.ForeColor = Color.White;
            progressBar1linija7.Text = "Udeo";
            progressBar1linija7.ForeColor = Color.SpringGreen;
            progressBar1linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar1linija8.ForeColor = Color.White;


            //                   2. USLUGA
             max = usluge.Max();
            indeks = usluge.IndexOf(max);
            usluge[indeks] = 0;

            progressBar2.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar2linija1.Text = "Usluga";
            progressBar2linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar2linija2.Text = "jednočasovna za automobile";
                    break;
                case 1:
                    progressBar2linija2.Text = "poludnevna za automobile";
                    break;
                case 2:
                    progressBar2linija2.Text = "dnevna za automobile";
                    break;
                case 3:
                    progressBar2linija2.Text = "nedeljna za automobile";
                    break;
                case 4:
                    progressBar2linija2.Text = "mesečna za automobile";
                    break;
                case 5:
                    progressBar2linija2.Text = "jednočasovna za autobuse";
                    break;
                case 6:
                    progressBar2linija2.Text = "poludnevna za autobuse";
                    break;
                case 7:
                    progressBar2linija2.Text = "dnevna za autobuse";
                    break;
                case 8:
                    progressBar2linija2.Text = "nedeljna za autobuse";
                    break;
                case 9:
                    progressBar2linija2.Text = "mesečna za autobuse";
                    break;
                case 10:
                    progressBar2linija2.Text = "jednočasovna za kamione";
                    break;
                case 11:
                    progressBar2linija2.Text = "poludnevna za kamione";
                    break;
                case 12:
                    progressBar2linija2.Text = "dnevna za kamione";
                    break;
                case 13:
                    progressBar2linija2.Text = "nedeljna za kamione";
                    break;
                case 14:
                    progressBar2linija2.Text = "mesečna za kamione";
                    break;
                default:
                    break;

            }
            progressBar2linija2.ForeColor = Color.White;
            progressBar2linija3.Text = "Broj odabira usluge";
            progressBar2linija3.ForeColor = Color.SpringGreen;
            progressBar2linija4.Text = max.ToString();
            progressBar2linija4.ForeColor = Color.White;
            progressBar2linija5.Text = "Ukupan broj parkiranja";
            progressBar2linija5.ForeColor = Color.SpringGreen;
            progressBar2linija6.Text = ukupanBrojUsluga.ToString();
            progressBar2linija6.ForeColor = Color.White;
            progressBar2linija7.Text = "Udeo";
            progressBar2linija7.ForeColor = Color.SpringGreen;
            progressBar2linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar2linija8.ForeColor = Color.White;

            //                   3. USLUGA
            max = usluge.Max();
            indeks = usluge.IndexOf(max);
            usluge[indeks] = 0;

            progressBar3.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar3linija1.Text = "Usluga";
            progressBar3linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar3linija2.Text = "jednočasovna za automobile";
                    break;
                case 1:
                    progressBar3linija2.Text = "poludnevna za automobile";
                    break;
                case 2:
                    progressBar3linija2.Text = "dnevna za automobile";
                    break;
                case 3:
                    progressBar3linija2.Text = "nedeljna za automobile";
                    break;
                case 4:
                    progressBar3linija2.Text = "mesečna za automobile";
                    break;
                case 5:
                    progressBar3linija2.Text = "jednočasovna za autobuse";
                    break;
                case 6:
                    progressBar3linija2.Text = "poludnevna za autobuse";
                    break;
                case 7:
                    progressBar3linija2.Text = "dnevna za autobuse";
                    break;
                case 8:
                    progressBar3linija2.Text = "nedeljna za autobuse";
                    break;
                case 9:
                    progressBar3linija2.Text = "mesečna za autobuse";
                    break;
                case 10:
                    progressBar3linija2.Text = "jednočasovna za kamione";
                    break;
                case 11:
                    progressBar3linija2.Text = "poludnevna za kamione";
                    break;
                case 12:
                    progressBar3linija2.Text = "dnevna za kamione";
                    break;
                case 13:
                    progressBar3linija2.Text = "nedeljna za kamione";
                    break;
                case 14:
                    progressBar3linija2.Text = "mesečna za kamione";
                    break;
                default:
                    break;

            }
            progressBar3linija2.ForeColor = Color.White;
            progressBar3linija3.Text = "Broj odabira usluge";
            progressBar3linija3.ForeColor = Color.SpringGreen;
            progressBar3linija4.Text = max.ToString();
            progressBar3linija4.ForeColor = Color.White;
            progressBar3linija5.Text = "Ukupan broj parkiranja";
            progressBar3linija5.ForeColor = Color.SpringGreen;
            progressBar3linija6.Text = ukupanBrojUsluga.ToString();
            progressBar3linija6.ForeColor = Color.White;
            progressBar3linija7.Text = "Udeo";
            progressBar3linija7.ForeColor = Color.SpringGreen;
            progressBar3linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar3linija8.ForeColor = Color.White;

            //                   4. USLUGA
            max = usluge.Max();
            indeks = usluge.IndexOf(max);
            usluge[indeks] = 0;

            progressBar4.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar4linija1.Text = "Usluga";
            progressBar4linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar4linija2.Text = "jednočasovna za automobile";
                    break;
                case 1:
                    progressBar4linija2.Text = "poludnevna za automobile";
                    break;
                case 2:
                    progressBar4linija2.Text = "dnevna za automobile";
                    break;
                case 3:
                    progressBar4linija2.Text = "nedeljna za automobile";
                    break;
                case 4:
                    progressBar4linija2.Text = "mesečna za automobile";
                    break;
                case 5:
                    progressBar4linija2.Text = "jednočasovna za autobuse";
                    break;
                case 6:
                    progressBar4linija2.Text = "poludnevna za autobuse";
                    break;
                case 7:
                    progressBar4linija2.Text = "dnevna za autobuse";
                    break;
                case 8:
                    progressBar4linija2.Text = "nedeljna za autobuse";
                    break;
                case 9:
                    progressBar4linija2.Text = "mesečna za autobuse";
                    break;
                case 10:
                    progressBar4linija2.Text = "jednočasovna za kamione";
                    break;
                case 11:
                    progressBar4linija2.Text = "poludnevna za kamione";
                    break;
                case 12:
                    progressBar4linija2.Text = "dnevna za kamione";
                    break;
                case 13:
                    progressBar4linija2.Text = "nedeljna za kamione";
                    break;
                case 14:
                    progressBar4linija2.Text = "mesečna za kamione";
                    break;
                default:
                    break;

            }
            progressBar4linija2.ForeColor = Color.White;
            progressBar4linija3.Text = "Broj odabira usluge";
            progressBar4linija3.ForeColor = Color.SpringGreen;
            progressBar4linija4.Text = max.ToString();
            progressBar4linija4.ForeColor = Color.White;
            progressBar4linija5.Text = "Ukupan broj parkiranja";
            progressBar4linija5.ForeColor = Color.SpringGreen;
            progressBar4linija6.Text = ukupanBrojUsluga.ToString();
            progressBar4linija6.ForeColor = Color.White;
            progressBar4linija7.Text = "Udeo";
            progressBar4linija7.ForeColor = Color.SpringGreen;
            progressBar4linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar4linija8.ForeColor = Color.White;
        }

        private void btnNajpozeljnijiTermini_Click(object sender, EventArgs e)
        {
            this.btnNajpozeljnijaParkingMesta.Visible = true;
            this.labelNajpozeljnijaParkingMesta.Visible = true;
            this.btnNajpozeljnijeGaraze.Visible = true;
            this.labelNajpozeljnijeGaraze.Visible = true;
            this.btnNajpozeljnijeUsluge.Visible = true;
            this.labelNajpozeljnijeUsluge.Visible = true;
            this.btnNajpozeljnijiTermini.Visible = false;
            this.labelNajpozeljnijiTermini.Visible = false;
            this.panelStatistikaProcenti.Visible = true;
            this.progressBar1.Visible = true;
            this.progressBar2.Visible = true;
            this.progressBar3.Visible = true;
            this.progressBar4.Visible = true;
            this.panelProgressBar4.Visible = true;
            this.progressBar1linija9.Visible = false;
            this.progressBar2linija9.Visible = false;
            this.progressBar3linija9.Visible = false;
            this.progressBar4linija9.Visible = false;
            this.progressBar1linija10.Visible = false;
            this.progressBar2linija10.Visible = false;
            this.progressBar3linija10.Visible = false;
            this.progressBar4linija10.Visible = false;
            this.labelStatistikaOpcija.Text = "Najpoželjniji termini parkiranja";
            this.labelStatistikaOpcija.Visible = true;

            List<int> termini = new List<int>(); //0 je 00h-01h, 1 je 01h-02h,... 23 je 23h-00h

            for (int i = 0; i < 24; i++)
            {
                termini.Add(0);
            }

            int ukupanBrojUsluga = 0;

            foreach (ParkingMesto p in this.baza.istorijaParkiranja())
            {
                ukupanBrojUsluga++;
                switch (p.Vozilo.PocetakParkiranja.Hour)
                {
                    case 0:
                        termini[0]++;
                        break;

                    case 1:
                        termini[1]++;
                        break;

                    case 2:
                        termini[2]++;
                        break;

                    case 3:
                        termini[3]++;
                        break;

                    case 4:
                        termini[4]++;
                        break;

                    case 5:
                        termini[5]++;
                        break;

                    case 6:
                        termini[6]++;
                        break;

                    case 7:
                        termini[7]++;
                        break;

                    case 8:
                        termini[8]++;
                        break;

                    case 9:
                        termini[9]++;
                        break;

                    case 10:
                        termini[10]++;
                        break;

                    case 11:
                        termini[11]++;
                        break;

                    case 12:
                        termini[12]++;
                        break;

                    case 13:
                        termini[13]++;
                        break;

                    case 14:
                        termini[14]++;
                        break;

                    case 15:
                        termini[15]++;
                        break;

                    case 16:
                        termini[16]++;
                        break;

                    case 17:
                        termini[17]++;
                        break;

                    case 18:
                        termini[18]++;
                        break;

                    case 19:
                        termini[19]++;
                        break;

                    case 20:
                        termini[20]++;
                        break;

                    case 21:
                        termini[21]++;
                        break;

                    case 22:
                        termini[22]++;
                        break;

                    case 23:
                        termini[23]++;
                        break;

                    default:
                        break;

                }
            }

            //                      1. TERMIN
            int max = termini.Max();
            int indeks = termini.IndexOf(max);
            termini[indeks] = 0;

            progressBar1.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar1linija1.Text = "Termin";
            progressBar1linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar1linija2.Text = "00h - 01h";
                    break;

                case 1:
                    progressBar1linija2.Text = "01h - 02h";
                    break;

                case 2:
                    progressBar1linija2.Text = "02h - 03h";
                    break;

                case 3:
                    progressBar1linija2.Text = "03h - 04h";
                    break;

                case 4:
                    progressBar1linija2.Text = "04h - 05h";
                    break;

                case 5:
                    progressBar1linija2.Text = "05h - 06h";
                    break;

                case 6:
                    progressBar1linija2.Text = "06h - 07h";
                    break;

                case 7:
                    progressBar1linija2.Text = "07h - 08h";
                    break;

                case 8:
                    progressBar1linija2.Text = "08h - 09h";
                    break;

                case 9:
                    progressBar1linija2.Text = "09h - 10h";
                    break;

                case 10:
                    progressBar1linija2.Text = "10h - 11h";
                    break;

                case 11:
                    progressBar1linija2.Text = "11h - 12h";
                    break;

                case 12:
                    progressBar1linija2.Text = "12h - 13h";
                    break;

                case 13:
                    progressBar1linija2.Text = "13h - 14h";
                    break;

                case 14:
                    progressBar1linija2.Text = "14h - 15h";
                    break;

                case 15:
                    progressBar1linija2.Text = "15h - 16h";
                    break;

                case 16:
                    progressBar1linija2.Text = "16h - 17h";
                    break;

                case 17:
                    progressBar1linija2.Text = "17h - 18h";
                    break;

                case 18:
                    progressBar1linija2.Text = "18h - 19h";
                    break;

                case 19:
                    progressBar1linija2.Text = "19h - 20h";
                    break;

                case 20:
                    progressBar1linija2.Text = "20h - 21h";
                    break;

                case 21:
                    progressBar1linija2.Text = "21h - 22h";
                    break;

                case 22:
                    progressBar1linija2.Text = "22h - 23h";
                    break;

                case 23:
                    progressBar1linija2.Text = "23h - 00h";
                    break;

                default:
                    break;

            }
            progressBar1linija2.ForeColor = Color.White;
            progressBar1linija3.Text = "Broj odabira termina";
            progressBar1linija3.ForeColor = Color.SpringGreen;
            progressBar1linija4.Text = max.ToString();
            progressBar1linija4.ForeColor = Color.White;
            progressBar1linija5.Text = "Ukupan broj parkiranja";
            progressBar1linija5.ForeColor = Color.SpringGreen;
            progressBar1linija6.Text = ukupanBrojUsluga.ToString();
            progressBar1linija6.ForeColor = Color.White;
            progressBar1linija7.Text = "Udeo";
            progressBar1linija7.ForeColor = Color.SpringGreen;
            progressBar1linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar1linija8.ForeColor = Color.White;


            //                      2. TERMIN
           max = termini.Max();
           indeks = termini.IndexOf(max);
            termini[indeks] = 0;

            progressBar2.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar2linija1.Text = "Termin";
            progressBar2linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar2linija2.Text = "00h - 01h";
                    break;

                case 1:
                    progressBar2linija2.Text = "01h - 02h";
                    break;

                case 2:
                    progressBar2linija2.Text = "02h - 03h";
                    break;

                case 3:
                    progressBar2linija2.Text = "03h - 04h";
                    break;

                case 4:
                    progressBar2linija2.Text = "04h - 05h";
                    break;

                case 5:
                    progressBar2linija2.Text = "05h - 06h";
                    break;

                case 6:
                    progressBar2linija2.Text = "06h - 07h";
                    break;

                case 7:
                    progressBar2linija2.Text = "07h - 08h";
                    break;

                case 8:
                    progressBar2linija2.Text = "08h - 09h";
                    break;

                case 9:
                    progressBar2linija2.Text = "09h - 10h";
                    break;

                case 10:
                    progressBar2linija2.Text = "10h - 11h";
                    break;

                case 11:
                    progressBar2linija2.Text = "11h - 12h";
                    break;

                case 12:
                    progressBar2linija2.Text = "12h - 13h";
                    break;

                case 13:
                    progressBar2linija2.Text = "13h - 14h";
                    break;

                case 14:
                    progressBar2linija2.Text = "14h - 15h";
                    break;

                case 15:
                    progressBar2linija2.Text = "15h - 16h";
                    break;

                case 16:
                    progressBar2linija2.Text = "16h - 17h";
                    break;

                case 17:
                    progressBar2linija2.Text = "17h - 18h";
                    break;

                case 18:
                    progressBar2linija2.Text = "18h - 19h";
                    break;

                case 19:
                    progressBar2linija2.Text = "19h - 20h";
                    break;

                case 20:
                    progressBar2linija2.Text = "20h - 21h";
                    break;

                case 21:
                    progressBar2linija2.Text = "21h - 22h";
                    break;

                case 22:
                    progressBar2linija2.Text = "22h - 23h";
                    break;

                case 23:
                    progressBar2linija2.Text = "23h - 00h";
                    break;

                default:
                    break;

            }
            progressBar2linija2.ForeColor = Color.White;
            progressBar2linija3.Text = "Broj odabira termina";
            progressBar2linija3.ForeColor = Color.SpringGreen;
            progressBar2linija4.Text = max.ToString();
            progressBar2linija4.ForeColor = Color.White;
            progressBar2linija5.Text = "Ukupan broj parkiranja";
            progressBar2linija5.ForeColor = Color.SpringGreen;
            progressBar2linija6.Text = ukupanBrojUsluga.ToString();
            progressBar2linija6.ForeColor = Color.White;
            progressBar2linija7.Text = "Udeo";
            progressBar2linija7.ForeColor = Color.SpringGreen;
            progressBar2linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar2linija8.ForeColor = Color.White;

            //                      3. TERMIN
             max = termini.Max();
             indeks = termini.IndexOf(max);
            termini[indeks] = 0;

            progressBar3.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar3linija1.Text = "Termin";
            progressBar3linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar3linija2.Text = "00h - 01h";
                    break;

                case 1:
                    progressBar3linija2.Text = "01h - 02h";
                    break;

                case 2:
                    progressBar3linija2.Text = "02h - 03h";
                    break;

                case 3:
                    progressBar3linija2.Text = "03h - 04h";
                    break;

                case 4:
                    progressBar3linija2.Text = "04h - 05h";
                    break;

                case 5:
                    progressBar3linija2.Text = "05h - 06h";
                    break;

                case 6:
                    progressBar3linija2.Text = "06h - 07h";
                    break;

                case 7:
                    progressBar3linija2.Text = "07h - 08h";
                    break;

                case 8:
                    progressBar3linija2.Text = "08h - 09h";
                    break;

                case 9:
                    progressBar3linija2.Text = "09h - 10h";
                    break;

                case 10:
                    progressBar3linija2.Text = "10h - 11h";
                    break;

                case 11:
                    progressBar3linija2.Text = "11h - 12h";
                    break;

                case 12:
                    progressBar3linija2.Text = "12h - 13h";
                    break;

                case 13:
                    progressBar3linija2.Text = "13h - 14h";
                    break;

                case 14:
                    progressBar3linija2.Text = "14h - 15h";
                    break;

                case 15:
                    progressBar3linija2.Text = "15h - 16h";
                    break;

                case 16:
                    progressBar3linija2.Text = "16h - 17h";
                    break;

                case 17:
                    progressBar3linija2.Text = "17h - 18h";
                    break;

                case 18:
                    progressBar3linija2.Text = "18h - 19h";
                    break;

                case 19:
                    progressBar3linija2.Text = "19h - 20h";
                    break;

                case 20:
                    progressBar3linija2.Text = "20h - 21h";
                    break;

                case 21:
                    progressBar3linija2.Text = "21h - 22h";
                    break;

                case 22:
                    progressBar3linija2.Text = "22h - 23h";
                    break;

                case 23:
                    progressBar3linija2.Text = "23h - 00h";
                    break;

                default:
                    break;

            }
            progressBar3linija2.ForeColor = Color.White;
            progressBar3linija3.Text = "Broj odabira termina";
            progressBar3linija3.ForeColor = Color.SpringGreen;
            progressBar3linija4.Text = max.ToString();
            progressBar3linija4.ForeColor = Color.White;
            progressBar3linija5.Text = "Ukupan broj parkiranja";
            progressBar3linija5.ForeColor = Color.SpringGreen;
            progressBar3linija6.Text = ukupanBrojUsluga.ToString();
            progressBar3linija6.ForeColor = Color.White;
            progressBar3linija7.Text = "Udeo";
            progressBar3linija7.ForeColor = Color.SpringGreen;
            progressBar3linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar3linija8.ForeColor = Color.White;
        
            //                      4. TERMIN
             max = termini.Max();
             indeks = termini.IndexOf(max);
            termini[indeks] = 0;

            progressBar4.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar4linija1.Text = "Termin";
            progressBar4linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar4linija2.Text = "00h - 01h";
                    break;

                case 1:
                    progressBar4linija2.Text = "01h - 02h";
                    break;

                case 2:
                    progressBar4linija2.Text = "02h - 03h";
                    break;

                case 3:
                    progressBar4linija2.Text = "03h - 04h";
                    break;

                case 4:
                    progressBar4linija2.Text = "04h - 05h";
                    break;

                case 5:
                    progressBar4linija2.Text = "05h - 06h";
                    break;

                case 6:
                    progressBar4linija2.Text = "06h - 07h";
                    break;

                case 7:
                    progressBar4linija2.Text = "07h - 08h";
                    break;

                case 8:
                    progressBar4linija2.Text = "08h - 09h";
                    break;

                case 9:
                    progressBar4linija2.Text = "09h - 10h";
                    break;

                case 10:
                    progressBar4linija2.Text = "10h - 11h";
                    break;

                case 11:
                    progressBar4linija2.Text = "11h - 12h";
                    break;

                case 12:
                    progressBar4linija2.Text = "12h - 13h";
                    break;

                case 13:
                    progressBar4linija2.Text = "13h - 14h";
                    break;

                case 14:
                    progressBar4linija2.Text = "14h - 15h";
                    break;

                case 15:
                    progressBar4linija2.Text = "15h - 16h";
                    break;

                case 16:
                    progressBar4linija2.Text = "16h - 17h";
                    break;

                case 17:
                    progressBar4linija2.Text = "17h - 18h";
                    break;

                case 18:
                    progressBar4linija2.Text = "18h - 19h";
                    break;

                case 19:
                    progressBar4linija2.Text = "19h - 20h";
                    break;

                case 20:
                    progressBar4linija2.Text = "20h - 21h";
                    break;

                case 21:
                    progressBar4linija2.Text = "21h - 22h";
                    break;

                case 22:
                    progressBar4linija2.Text = "22h - 23h";
                    break;

                case 23:
                    progressBar4linija2.Text = "23h - 00h";
                    break;

                default:
                    break;

            }
            progressBar4linija2.ForeColor = Color.White;
            progressBar4linija3.Text = "Broj odabira termina";
            progressBar4linija3.ForeColor = Color.SpringGreen;
            progressBar4linija4.Text = max.ToString();
            progressBar4linija4.ForeColor = Color.White;
            progressBar4linija5.Text = "Ukupan broj parkiranja";
            progressBar4linija5.ForeColor = Color.SpringGreen;
            progressBar4linija6.Text = ukupanBrojUsluga.ToString();
            progressBar4linija6.ForeColor = Color.White;
            progressBar4linija7.Text = "Udeo";
            progressBar4linija7.ForeColor = Color.SpringGreen;
            progressBar4linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar4linija8.ForeColor = Color.White;
        }

        private void btnNajpozeljnijeGaraze_Click(object sender, EventArgs e)
        {
            this.btnNajpozeljnijaParkingMesta.Visible = true;
            this.labelNajpozeljnijaParkingMesta.Visible = true;
            this.btnNajpozeljnijeGaraze.Visible = false;
            this.labelNajpozeljnijeGaraze.Visible = false;
            this.btnNajpozeljnijeUsluge.Visible = true;
            this.labelNajpozeljnijeUsluge.Visible = true;
            this.btnNajpozeljnijiTermini.Visible = true;
            this.labelNajpozeljnijiTermini.Visible = true;
            this.panelStatistikaProcenti.Visible = true;
            this.progressBar1.Visible = true;
            this.progressBar2.Visible = true;
            this.progressBar3.Visible = true;
            this.progressBar4.Visible = false;
            this.panelProgressBar4.Visible = false;//ovde nam trebaju samo 3 progressbara za 3 garaze!!!
            this.progressBar1linija9.Visible = false;
            this.progressBar2linija9.Visible = false;
            this.progressBar3linija9.Visible = false;
            this.progressBar4linija9.Visible = false;
            this.progressBar1linija10.Visible = false;
            this.progressBar2linija10.Visible = false;
            this.progressBar3linija10.Visible = false;
            this.progressBar4linija10.Visible = false;
            this.labelStatistikaOpcija.Text = "Parkiranja po garažama";
            this.labelStatistikaOpcija.Visible = true;

            List<int> garaze = new List<int>(); //0 je 1. garaza, 1 je 2. garaza. 2 je 3. garaza

            for (int i = 0; i < 3; i++)
            {
                garaze.Add(0);
            }

            int ukupanBrojUsluga = 0;

            foreach (ParkingMesto p in this.baza.istorijaParkiranja())
            {
                ukupanBrojUsluga++;
                switch (p.BrGaraze)
                {

                    case 1:
                        garaze[0]++;
                        break;

                    case 2:
                        garaze[1]++;
                        break;

                    case 3:
                        garaze[2]++;
                        break;

                    default: break;

                }
            }

            //                      1. GARAZA
            int max = garaze.Max();
            int indeks = garaze.IndexOf(max);
            garaze[indeks] = 0;

            progressBar1.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar1linija1.Text = "Garaža";
            progressBar1linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar1linija2.Text = "prva";
                    break;
                case 1:
                    progressBar1linija2.Text = "druga";
                    break;
                case 2:
                    progressBar1linija2.Text = "treća";
                    break;
            }
            progressBar1linija2.ForeColor = Color.White;
            progressBar1linija3.Text = "Broj parkiranja u garaži";
            progressBar1linija3.ForeColor = Color.SpringGreen;
            progressBar1linija4.Text = max.ToString();
            progressBar1linija4.ForeColor = Color.White;
            progressBar1linija5.Text = "Ukupan broj parkiranja";
            progressBar1linija5.ForeColor = Color.SpringGreen;
            progressBar1linija6.Text = ukupanBrojUsluga.ToString();
            progressBar1linija6.ForeColor = Color.White;
            progressBar1linija7.Text = "Udeo";
            progressBar1linija7.ForeColor = Color.SpringGreen;
            progressBar1linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar1linija8.ForeColor = Color.White;


            //                      2. GARAZA
             max = garaze.Max();
             indeks = garaze.IndexOf(max);
            garaze[indeks] = 0;

            progressBar2.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar2linija1.Text = "Garaža";
            progressBar2linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar2linija2.Text = "prva";
                    break;
                case 1:
                    progressBar2linija2.Text = "druga";
                    break;
                case 2:
                    progressBar2linija2.Text = "treća";
                    break;
            }
            progressBar2linija2.ForeColor = Color.White;
            progressBar2linija3.Text = "Broj parkiranja u garaži";
            progressBar2linija3.ForeColor = Color.SpringGreen;
            progressBar2linija4.Text = max.ToString();
            progressBar2linija4.ForeColor = Color.White;
            progressBar2linija5.Text = "Ukupan broj parkiranja";
            progressBar2linija5.ForeColor = Color.SpringGreen;
            progressBar2linija6.Text = ukupanBrojUsluga.ToString();
            progressBar2linija6.ForeColor = Color.White;
            progressBar2linija7.Text = "Udeo";
            progressBar2linija7.ForeColor = Color.SpringGreen;
            progressBar2linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar2linija8.ForeColor = Color.White;

            //                      3. GARAZA
            max = garaze.Max();
            indeks = garaze.IndexOf(max);
            garaze[indeks] = 0;

            progressBar3.Value = Convert.ToInt32(Math.Round((decimal)(max * 100 / ukupanBrojUsluga)));

            progressBar3linija1.Text = "Garaža";
            progressBar3linija1.ForeColor = Color.SpringGreen;
            switch (indeks)
            {
                case 0:
                    progressBar3linija2.Text = "prva";
                    break;
                case 1:
                    progressBar3linija2.Text = "druga";
                    break;
                case 2:
                    progressBar3linija2.Text = "treća";
                    break;
            }
            progressBar3linija2.ForeColor = Color.White;
            progressBar3linija3.Text = "Broj parkiranja u garaži";
            progressBar3linija3.ForeColor = Color.SpringGreen;
            progressBar3linija4.Text = max.ToString();
            progressBar3linija4.ForeColor = Color.White;
            progressBar3linija5.Text = "Ukupan broj parkiranja";
            progressBar3linija5.ForeColor = Color.SpringGreen;
            progressBar3linija6.Text = ukupanBrojUsluga.ToString();
            progressBar3linija6.ForeColor = Color.White;
            progressBar3linija7.Text = "Udeo";
            progressBar3linija7.ForeColor = Color.SpringGreen;
            progressBar3linija8.Text = max.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar3linija8.ForeColor = Color.White;

        }

        private void btnNajpozeljnijaParkingMesta_Click(object sender, EventArgs e)
        {
            this.btnNajpozeljnijaParkingMesta.Visible = false;
            this.labelNajpozeljnijaParkingMesta.Visible = false;
            this.btnNajpozeljnijeGaraze.Visible = true;
            this.labelNajpozeljnijeGaraze.Visible = true;
            this.btnNajpozeljnijeUsluge.Visible = true;
            this.labelNajpozeljnijeUsluge.Visible = true;
            this.btnNajpozeljnijiTermini.Visible = true;
            this.labelNajpozeljnijiTermini.Visible = true;
            this.panelStatistikaProcenti.Visible = true;
            this.progressBar1.Visible = true;
            this.progressBar2.Visible = true;
            this.progressBar3.Visible = true;
            this.progressBar4.Visible = true;
            this.panelProgressBar4.Visible = true;
            this.progressBar1linija9.Visible = true;
            this.progressBar2linija9.Visible = true;
            this.progressBar3linija9.Visible = true;
            this.progressBar4linija9.Visible = true;
            this.progressBar1linija10.Visible = true;
            this.progressBar2linija10.Visible = true;
            this.progressBar3linija10.Visible = true;
            this.progressBar4linija10.Visible = true;
            this.labelStatistikaOpcija.Text = "Najpoželjnija parking mesta";
            this.labelStatistikaOpcija.Visible = true;


            List<int> parkingMesta1 = new List<int>(); // 0 je 1. parking mesto, 31 je 32. parking mesto za garazu1
            List<int> parkingMesta2 = new List<int>(); // 0 je 1. parking mesto, 31 je 32. parking mesto za garazu2
            List<int> parkingMesta3 = new List<int>(); // 0 je 1. parking mesto, 31 je 32. parking mesto za garazu3

            for (int i = 0; i < 32; i++)
            {
                parkingMesta1.Add(0);
                parkingMesta2.Add(0);
                parkingMesta3.Add(0);
            }

            int ukupanBrojUsluga = 0;

            foreach (ParkingMesto p in this.baza.istorijaParkiranja())
            {
                ukupanBrojUsluga++;
                switch (p.Broj)
                {

                    case 1:
                       if(p.BrGaraze==1)
                        {
                            parkingMesta1[0]++;
                        }
                       else if(p.BrGaraze==2)
                        {
                            parkingMesta2[0]++;
                        }
                       else if(p.BrGaraze==3)
                        {
                            parkingMesta3[0]++;
                        }
                        break;

                    case 2:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[1]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[1]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[1]++;
                        }
                        break;

                    case 3:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[2]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[2]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[2]++;
                        }
                        break;

                    case 4:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[3]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[3]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[3]++;
                        }
                        break;

                    case 5:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[4]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[4]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[4]++;
                        }
                        break;

                    case 6:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[5]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[5]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[5]++;
                        }
                        break;

                    case 7:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[6]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[6]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[6]++;
                        }
                        break;

                    case 8:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[7]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[7]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[7]++;
                        }
                        break;

                    case 9:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[8]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[8]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[8]++;
                        }
                        break;

                    case 10:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[9]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[9]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[9]++;
                        }
                        break;

                    case 11:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[10]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[10]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[10]++;
                        }
                        break;

                    case 12:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[11]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[11]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[11]++;
                        }
                        break;

                    case 13:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[12]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[12]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[12]++;
                        }
                        break;

                    case 14:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[13]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[13]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[13]++;
                        }
                        break;

                    case 15:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[14]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[14]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[14]++;
                        }
                        break;

                    case 16:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[15]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[15]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[15]++;
                        }
                        break;

                    case 17:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[16]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[16]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[16]++;
                        }
                        break;

                    case 18:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[17]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[17]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[17]++;
                        }
                        break;

                    case 19:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[18]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[18]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[18]++;
                        }
                        break;

                    case 20:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[19]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[19]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[19]++;
                        }
                        break;

                    case 21:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[20]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[20]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[20]++;
                        }
                        break;

                    case 22:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[21]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[21]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[21]++;
                        }
                        break;

                    case 23:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[22]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[22]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[22]++;
                        }
                        break;

                    case 24:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[23]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[23]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[23]++;
                        }
                        break;

                    case 25:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[24]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[24]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[24]++;
                        }
                        break;

                    case 26:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[25]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[25]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[25]++;
                        }
                        break;

                    case 27:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[26]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[26]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[26]++;
                        }
                        break;

                    case 28:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[27]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[27]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[27]++;
                        }
                        break;

                    case 29:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[28]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[28]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[28]++;
                        }
                        break;

                    case 30:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[29]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[29]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[29]++;
                        }
                        break;

                    case 31:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[30]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[30]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[30]++;
                        }
                        break;

                    case 32:
                        if (p.BrGaraze == 1)
                        {
                            parkingMesta1[31]++;
                        }
                        else if (p.BrGaraze == 2)
                        {
                            parkingMesta2[31]++;
                        }
                        else if (p.BrGaraze == 3)
                        {
                            parkingMesta3[31]++;
                        }
                        break;

                    default: break;

                }
            }

            //                      1. PARKING MESTO
            int max1 = parkingMesta1.Max();
            int indeks1 = parkingMesta1.IndexOf(max1);
            int max2 = parkingMesta2.Max();
            int indeks2 = parkingMesta2.IndexOf(max2);
            int max3 = parkingMesta3.Max();
            int indeks3 = parkingMesta3.IndexOf(max3);

            int maX = Math.Max(max1, Math.Max(max2,max3));
            int indeX = -1;
            int garaza = -1;

            if(maX==max1)
            {
                parkingMesta1[indeks1] = 0;
                indeX = indeks1;
                garaza = 1;
            }
            else if(maX==max2)
            {
                parkingMesta2[indeks2] = 0;
                indeX = indeks2;
                garaza = 2;
            }
            else if(maX==max3)
            {
                parkingMesta3[indeks3] = 0;
                indeX = indeks3;
                garaza = 3;
            }

            progressBar1.Value = Convert.ToInt32(Math.Round((decimal)(maX * 100 / ukupanBrojUsluga)));

            progressBar1linija1.Text = "Garaža";
            progressBar1linija1.ForeColor = Color.SpringGreen;
            switch (garaza-1)
            {
                case 0:
                    progressBar1linija2.Text = "prva";
                    break;
                case 1:
                    progressBar1linija2.Text = "druga";
                    break;
                case 2:
                    progressBar1linija2.Text = "treća";
                    break;
            }
            progressBar1linija2.ForeColor = Color.White;
            progressBar1linija3.Text = "Broj parking mesta";
            progressBar1linija3.ForeColor = Color.SpringGreen;
            progressBar1linija4.Text =(indeX+1).ToString();
            progressBar1linija4.ForeColor = Color.White;
            progressBar1linija5.Text = "Broj parkiranja";
            progressBar1linija5.ForeColor = Color.SpringGreen;
            progressBar1linija6.Text = maX.ToString();
            progressBar1linija6.ForeColor = Color.White;
            progressBar1linija7.Text = "Ukupan broj parkiranja";
            progressBar1linija7.ForeColor = Color.SpringGreen;
            progressBar1linija8.Text = ukupanBrojUsluga.ToString();
            progressBar1linija8.ForeColor = Color.White;
            progressBar1linija9.Text = "Udeo";
            progressBar1linija9.ForeColor = Color.SpringGreen;
            progressBar1linija10.Text = maX.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar1linija10.ForeColor = Color.White;


            //                      2. PARKING MESTO
             max1 = parkingMesta1.Max();
             indeks1 = parkingMesta1.IndexOf(max1);
             max2 = parkingMesta2.Max();
             indeks2 = parkingMesta2.IndexOf(max2);
             max3 = parkingMesta3.Max();
             indeks3 = parkingMesta3.IndexOf(max3);

             maX = Math.Max(max1, Math.Max(max2, max3));
             indeX = -1;
             garaza = -1;
            // garaze[indeks] = 0;

            if (maX == max1)
            {
                parkingMesta1[indeks1] = 0;
                indeX = indeks1;
                garaza = 1;
            }
            else if (maX == max2)
            {
                parkingMesta2[indeks2] = 0;
                indeX = indeks2;
                garaza = 2;
            }
            else if (maX == max3)
            {
                parkingMesta3[indeks3] = 0;
                indeX = indeks3;
                garaza = 3;
            }

            progressBar2.Value = Convert.ToInt32(Math.Round((decimal)(maX * 100 / ukupanBrojUsluga)));

            progressBar2linija1.Text = "Garaža";
            progressBar2linija1.ForeColor = Color.SpringGreen;
            switch (garaza - 1)
            {
                case 0:
                    progressBar2linija2.Text = "prva";
                    break;
                case 1:
                    progressBar2linija2.Text = "druga";
                    break;
                case 2:
                    progressBar2linija2.Text = "treća";
                    break;
            }
            progressBar2linija2.ForeColor = Color.White;
            progressBar2linija3.Text = "Broj parking mesta";
            progressBar2linija3.ForeColor = Color.SpringGreen;
            progressBar2linija4.Text = (indeX + 1).ToString();
            progressBar2linija4.ForeColor = Color.White;
            progressBar2linija5.Text = "Broj parkiranja";
            progressBar2linija5.ForeColor = Color.SpringGreen;
            progressBar2linija6.Text = maX.ToString();
            progressBar2linija6.ForeColor = Color.White;
            progressBar2linija7.Text = "Ukupan broj parkiranja";
            progressBar2linija7.ForeColor = Color.SpringGreen;
            progressBar2linija8.Text = ukupanBrojUsluga.ToString();
            progressBar2linija8.ForeColor = Color.White;
            progressBar2linija9.Text = "Udeo";
            progressBar2linija9.ForeColor = Color.SpringGreen;
            progressBar2linija10.Text = maX.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar2linija10.ForeColor = Color.White;

            //                      3. PARKING MESTO
            max1 = parkingMesta1.Max();
            indeks1 = parkingMesta1.IndexOf(max1);
            max2 = parkingMesta2.Max();
            indeks2 = parkingMesta2.IndexOf(max2);
            max3 = parkingMesta3.Max();
            indeks3 = parkingMesta3.IndexOf(max3);

            maX = Math.Max(max1, Math.Max(max2, max3));
            indeX = -1;
            garaza = -1;
            // garaze[indeks] = 0;

            if (maX == max1)
            {
                parkingMesta1[indeks1] = 0;
                indeX = indeks1;
                garaza = 1;
            }
            else if (maX == max2)
            {
                parkingMesta2[indeks2] = 0;
                indeX = indeks2;
                garaza = 2;
            }
            else if (maX == max3)
            {
                parkingMesta3[indeks3] = 0;
                indeX = indeks3;
                garaza = 3;
            }

            progressBar3.Value = Convert.ToInt32(Math.Round((decimal)(maX * 100 / ukupanBrojUsluga)));

            progressBar3linija1.Text = "Garaža";
            progressBar3linija1.ForeColor = Color.SpringGreen;
            switch (garaza - 1)
            {
                case 0:
                    progressBar3linija2.Text = "prva";
                    break;
                case 1:
                    progressBar3linija2.Text = "druga";
                    break;
                case 2:
                    progressBar3linija2.Text = "treća";
                    break;
            }
            progressBar3linija2.ForeColor = Color.White;
            progressBar3linija3.Text = "Broj parking mesta";
            progressBar3linija3.ForeColor = Color.SpringGreen;
            progressBar3linija4.Text = (indeX + 1).ToString();
            progressBar3linija4.ForeColor = Color.White;
            progressBar3linija5.Text = "Broj parkiranja";
            progressBar3linija5.ForeColor = Color.SpringGreen;
            progressBar3linija6.Text = maX.ToString();
            progressBar3linija6.ForeColor = Color.White;
            progressBar3linija7.Text = "Ukupan broj parkiranja";
            progressBar3linija7.ForeColor = Color.SpringGreen;
            progressBar3linija8.Text = ukupanBrojUsluga.ToString();
            progressBar3linija8.ForeColor = Color.White;
            progressBar3linija9.Text = "Udeo";
            progressBar3linija9.ForeColor = Color.SpringGreen;
            progressBar3linija10.Text = maX.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar3linija10.ForeColor = Color.White;

            //                      4. PARKING MESTO
            max1 = parkingMesta1.Max();
            indeks1 = parkingMesta1.IndexOf(max1);
            max2 = parkingMesta2.Max();
            indeks2 = parkingMesta2.IndexOf(max2);
            max3 = parkingMesta3.Max();
            indeks3 = parkingMesta3.IndexOf(max3);

            maX = Math.Max(max1, Math.Max(max2, max3));
            indeX = -1;
            garaza = -1;
            // garaze[indeks] = 0;

            if (maX == max1)
            {
                parkingMesta1[indeks1] = 0;
                indeX = indeks1;
                garaza = 1;
            }
            else if (maX == max2)
            {
                parkingMesta2[indeks2] = 0;
                indeX = indeks2;
                garaza = 2;
            }
            else if (maX == max3)
            {
                parkingMesta3[indeks3] = 0;
                indeX = indeks3;
                garaza = 3;
            }

            progressBar4.Value = Convert.ToInt32(Math.Round((decimal)(maX * 100 / ukupanBrojUsluga)));

            progressBar4linija1.Text = "Garaža";
            progressBar4linija1.ForeColor = Color.SpringGreen;
            switch (garaza - 1)
            {
                case 0:
                    progressBar4linija2.Text = "prva";
                    break;
                case 1:
                    progressBar4linija2.Text = "druga";
                    break;
                case 2:
                    progressBar4linija2.Text = "treća";
                    break;
            }
            progressBar4linija2.ForeColor = Color.White;
            progressBar4linija3.Text = "Broj parking mesta";
            progressBar4linija3.ForeColor = Color.SpringGreen;
            progressBar4linija4.Text = (indeX + 1).ToString();
            progressBar4linija4.ForeColor = Color.White;
            progressBar4linija5.Text = "Broj parkiranja";
            progressBar4linija5.ForeColor = Color.SpringGreen;
            progressBar4linija6.Text = maX.ToString();
            progressBar4linija6.ForeColor = Color.White;
            progressBar4linija7.Text = "Ukupan broj parkiranja";
            progressBar4linija7.ForeColor = Color.SpringGreen;
            progressBar4linija8.Text = ukupanBrojUsluga.ToString();
            progressBar4linija8.ForeColor = Color.White;
            progressBar4linija9.Text = "Udeo";
            progressBar4linija9.ForeColor = Color.SpringGreen;
            progressBar4linija10.Text = maX.ToString() + " / " + ukupanBrojUsluga.ToString();
            progressBar4linija10.ForeColor = Color.White;
        }

        #endregion

        private void switchRezervacijeProduzivanje_OnValueChange(object sender, EventArgs e)
        {
            if (switchRezervacijeProduzivanje.Value == true)
            {
                cbxRezervacijeGaraza.SelectedIndex = -1;
                cbxRezervacijeGaraza.Text = "";
                cbxRezervacijeMesto.SelectedIndex = -1;
                cbxRezervacijeMesto.Text = "";
                cbxRezervacijeUsluga.SelectedIndex = -1;
                cbxRezervacijeUsluga.Text = "";
                txtRezervacijeReg.Text = "";
                cbxRezervacijeTip.Text = "";
                cbxRezervacijeTip.Text = "";
                datePickerRezervacije.Value = DateTime.Now;
                TimePickerRezervacije.Value = DateTime.Now;

                labelRezervacijeProduzavanje.Text = "Rezervacije parking usluga";
                labelRezervacijeProduzavanje.ForeColor = Color.FromArgb(18, 71, 31);
                groupBoxProduziPodaciVozila.Visible = false;
                buttonRezervacije.selected = true;
                buttonProduzavanje.selected = false;
                gradienPanelRezProduz.GradientBottomRight = Color.SpringGreen;
                cardRezervacijaProduzavanje.color = Color.SpringGreen;
                dataGridProduzavanje.Visible = false;
                groupBoxProduziPodaciVozila.Visible = false;
                labelBrzaPretraga.Visible = false;
                txtProduzavanjeBrzaPretraga.Visible = false;
                panelRezervacije.Visible = true;

                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacije.Location.Y);

                dataGridRezervacije.Rows.Clear();

                List<ParkingMesto> lista = this.baza.vratiRezervacije();

                foreach(ParkingMesto p in lista)
                {
                    dataGridRezervacije.Rows.Add(p.Vozilo.RegTab, p.Vozilo.PocetakParkiranja, p.Vozilo.UslugaParkingServisa, p.Vozilo.TipVozila, p.BrGaraze, p.Broj);
                }
                
            }  
            else
            {

                txtProduzavanjeBrzaPretraga.Text = "";
                labelRezervacijeProduzavanje.Text = "Produžavanje parking usluga";
                labelRezervacijeProduzavanje.ForeColor = Color.MidnightBlue;
                groupBoxProduziPodaciVozila.Visible = false;
                gradienPanelRezProduz.GradientBottomRight = Color.SteelBlue;
                cardRezervacijaProduzavanje.color = Color.Aqua;
                buttonProduzavanje.selected = true;
                buttonRezervacije.selected = false;

                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonProduzavanje.Location.Y);

                dataGridProduzavanje.Visible = true;
                groupBoxProduziPodaciVozila.Visible = false;
                labelBrzaPretraga.Visible = true;
                txtProduzavanjeBrzaPretraga.Visible = true;

                labelProduzavanjeTip.Visible = false;
                labelProduzvanajeGaraza.Visible = false;
                labelProduzvanajeMesto.Visible = false;
                labelProduzvanajePocetak.Visible = false;
                labelProduzvanajeRacun.Visible = false;
                labelProduzvanajeKraj.Visible = false;
                labelProduzvanajeUsluga.Visible = false;
                labelProduzvanajeReg.Visible = false;
                label40.Visible = false;

                panelRezervacije.Visible = false;

                dataGridProduzavanje.Rows.Clear();

                for (int i = 0; i < 32; i++)
                {
                    if (garaza1.listaParkingMesta[i].Tag != null)
                    {
                        Vozilo v = new Vozilo();
                        v = (Vozilo)garaza1.listaParkingMesta[i].Tag;
                        dataGridProduzavanje.Rows.Add(v.RegTab);
                    }

                }
                for (int i = 0; i < 32; i++)
                {
                    if (garaza2.listaParkingMesta[i].Tag != null)
                    {
                        Vozilo v = new Vozilo();
                        v = (Vozilo)garaza2.listaParkingMesta[i].Tag;
                        dataGridProduzavanje.Rows.Add(v.RegTab);
                    }

                }
                for (int i = 0; i < 32; i++)
                {
                    if (garaza3.listaParkingMesta[i].Tag != null)
                    {
                        Vozilo v = new Vozilo();
                        v = (Vozilo)garaza3.listaParkingMesta[i].Tag;
                        dataGridProduzavanje.Rows.Add(v.RegTab);
                    }

                }

                dataGridProduzavanje.ClearSelection();

            }
                
        }

        private void buttonRezervacije_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "rezervacijeproduzavanje";
            panelLogovanje.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            panelGaraze.Hide();
            this.panelStatistika.Hide();
            panelPreostaloVreme.Hide();
            this.panelRezervacijeProduzavanja.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervacije.Location.Y);

            switchRezervacijeProduzivanje.Value = true;
    

            if (SlideMenu.Width == 50)
            {
                if (slajdRezervacijeProduzavanje == "prosiren")
                {
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X - 100, this.panelRezervacijeProduzavanja.Location.Y);
                    slajdRezervacijeProduzavanje = "uvucen";
                   
                }
            }
            else
            {
                if (slajdRezervacijeProduzavanje == "uvucen")
                {
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X + 100, this.panelRezervacijeProduzavanja.Location.Y);
                    slajdRezervacijeProduzavanje = "prosiren";
                    
                }
            }
        }

        private void buttonProduzavanje_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "rezervacijeproduzavanje";
            panelLogovanje.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            panelGaraze.Hide();
            panelPreostaloVreme.Hide();
            this.panelStatistika.Hide();
            this.panelRezervacijeProduzavanja.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonProduzavanje.Location.Y);

            switchRezervacijeProduzivanje.Value = false;


            if (SlideMenu.Width == 50)
            {
                if (slajdRezervacijeProduzavanje == "prosiren")
                {
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X - 100, this.panelRezervacijeProduzavanja.Location.Y);
                    slajdRezervacijeProduzavanje = "uvucen";
                }
            }
            else
            {
                if (slajdRezervacijeProduzavanje == "uvucen")
                {
                    this.panelRezervacijeProduzavanja.Location = new Point(this.panelRezervacijeProduzavanja.Location.X + 100, this.panelRezervacijeProduzavanja.Location.Y);
                    slajdRezervacijeProduzavanje = "prosiren";
                }
            }
        }

        private void dataGridProduzavanje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelProduzavanjeTip.Visible = true;
            labelProduzvanajeGaraza.Visible = true;
            labelProduzvanajeMesto.Visible = true;
            labelProduzvanajePocetak.Visible = true;
            labelProduzvanajeRacun.Visible = true;
            labelProduzvanajeKraj.Visible = true;
            labelProduzvanajeUsluga.Visible = true;
            labelProduzvanajeReg.Visible = true;
            label40.Visible = true;
            rdbProduzi1h.Checked = false;
            rdbProduzi12h.Checked = false;
            rdbProduzi24h.Checked = false;
            rdbProduzi168h.Checked = false;
            rdbProduzi720h.Checked = false;

            groupBoxProduziPodaciVozila.Visible = true;

            foreach (ParkingMesto p in this.baza.parkiranaVozila())
            {
                if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                {
                    labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                    labelProduzvanajeMesto.Text = p.Broj.ToString();
                    labelProduzvanajeReg.Text = p.Vozilo.RegTab;
                    switch (p.Vozilo.UslugaParkingServisa)
                    {
                        case 1: labelProduzvanajeUsluga.Text = "jednočasovna"; break;
                        case 12: labelProduzvanajeUsluga.Text = "poludnevna"; break;
                        case 24: labelProduzvanajeUsluga.Text = "dnevna"; break;
                        case 168: labelProduzvanajeUsluga.Text = "nedeljna"; break;
                        case 720: labelProduzvanajeUsluga.Text = "mesečna"; break;
                    }
                    labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                    labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                    labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                    labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                   
                }
            }
        }

    
        private void txtProduzavanjeBrzaPretraga_OnValueChanged(object sender, EventArgs e)
        {
            if (txtProduzavanjeBrzaPretraga.Text != null && txtProduzavanjeBrzaPretraga.Text != "")
            {
                dataGridProduzavanje.Rows.Clear();

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab.StartsWith(txtProduzavanjeBrzaPretraga.Text))
                        dataGridProduzavanje.Rows.Add(p.Vozilo.RegTab);
                }
              
            }
            else if(string.IsNullOrWhiteSpace(txtProduzavanjeBrzaPretraga.Text))
            {
                dataGridProduzavanje.Rows.Clear();
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    dataGridProduzavanje.Rows.Add(p.Vozilo.RegTab);
                }
            }

        }

        private void rdbProduzi1h_CheckedChanged(object sender, EventArgs e)
        {

            if(rdbProduzi1h.Checked==true)
            {
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                        labelProduzvanajeMesto.Text = p.Broj.ToString();
                        labelProduzvanajeReg.Text = p.Vozilo.RegTab;

                        p.Vozilo.produziParkiranje(1);
                        labelProduzvanajeUsluga.Text = "jednočasovna"; 
                        labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                        labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                        labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                        labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                    }
                }
            }
            else if(rdbProduzi12h.Checked==true)
            {
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                        labelProduzvanajeMesto.Text = p.Broj.ToString();
                        labelProduzvanajeReg.Text = p.Vozilo.RegTab;

                        p.Vozilo.produziParkiranje(12);
                        labelProduzvanajeUsluga.Text = "poludnevna";
                        labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                        labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                        labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                        labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                    }
                }
            }
            else if(rdbProduzi24h.Checked==true)
            {
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                        labelProduzvanajeMesto.Text = p.Broj.ToString();
                        labelProduzvanajeReg.Text = p.Vozilo.RegTab;

                        p.Vozilo.produziParkiranje(24);
                        labelProduzvanajeUsluga.Text = "dnevna";
                        labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                        labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                        labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                        labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                    }
                }
            }
            else if(rdbProduzi168h.Checked==true)
            {
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                        labelProduzvanajeMesto.Text = p.Broj.ToString();
                        labelProduzvanajeReg.Text = p.Vozilo.RegTab;

                        p.Vozilo.produziParkiranje(168);
                        labelProduzvanajeUsluga.Text = "nedeljna";
                        labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                        labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                        labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                        labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                    }
                }
            }
            else if (rdbProduzi720h.Checked==true)
            {
                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        labelProduzvanajeGaraza.Text = p.BrGaraze.ToString();
                        labelProduzvanajeMesto.Text = p.Broj.ToString();
                        labelProduzvanajeReg.Text = p.Vozilo.RegTab;

                        p.Vozilo.produziParkiranje(720);
                        labelProduzvanajeUsluga.Text = "mesečna";
                        labelProduzvanajePocetak.Text = p.Vozilo.PocetakParkiranja.ToString();
                        labelProduzvanajeKraj.Text = p.Vozilo.KrajParkiranja.ToString();
                        labelProduzvanajeRacun.Text = p.Vozilo.Racun.ToString();
                        labelProduzavanjeTip.Text = p.Vozilo.TipVozila;
                    }
                }
            }
            
        }

        private void btnProduziParkiranje_Click(object sender, EventArgs e)
        {
            ParkingMesto pp = new ParkingMesto();
            DateTime krajParkiranjaVozila = DateTime.Now;
            int cenaUsluge = 0;
            bool fleg = false;

            if (rdbProduzi1h.Checked == true)
            {
                fleg = true;

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        pp = p;
                        krajParkiranjaVozila = pp.Vozilo.KrajParkiranja;
                        pp.Vozilo.produziParkiranje(1);
                        pp.Vozilo.UslugaParkingServisa = 1;

                        if(pp.Vozilo.TipVozila=="automobil")
                        {
                            cenaUsluge =  50 ;
                        }
                        else if (pp.Vozilo.TipVozila == "autobus")
                        {
                            cenaUsluge = 100 ;
                        }
                        else if (pp.Vozilo.TipVozila == "kamion")
                        {
                            cenaUsluge =  120 ;
                        }
                    }
                }
            }
            else if (rdbProduzi12h.Checked == true)
            {
                fleg = true;

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        pp = p;
                        krajParkiranjaVozila = pp.Vozilo.KrajParkiranja;
                        pp.Vozilo.produziParkiranje(12);
                        pp.Vozilo.UslugaParkingServisa = 12;

                        if (pp.Vozilo.TipVozila == "automobil")
                        {
                            cenaUsluge = 200;
                        }
                        else if (pp.Vozilo.TipVozila == "autobus")
                        {
                            cenaUsluge = 300;
                        }
                        else if (pp.Vozilo.TipVozila == "kamion")
                        {
                            cenaUsluge = 350;
                        }
                    }
                }
            }
            else if (rdbProduzi24h.Checked == true)
            {
                fleg = true;

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        pp = p;
                        krajParkiranjaVozila = pp.Vozilo.KrajParkiranja;
                        pp.Vozilo.produziParkiranje(24);
                        pp.Vozilo.UslugaParkingServisa = 24;

                        if (pp.Vozilo.TipVozila == "automobil")
                        {
                            cenaUsluge = 350;
                        }
                        else if (pp.Vozilo.TipVozila == "autobus")
                        {
                            cenaUsluge = 500;
                        }
                        else if (pp.Vozilo.TipVozila == "kamion")
                        {
                            cenaUsluge = 550;
                        }
                    }
                }
            }
            else if (rdbProduzi168h.Checked == true)
            {
                fleg = true;

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        pp = p;
                        krajParkiranjaVozila = pp.Vozilo.KrajParkiranja;
                        pp.Vozilo.produziParkiranje(168);
                        pp.Vozilo.UslugaParkingServisa = 168;

                        if (pp.Vozilo.TipVozila == "automobil")
                        {
                            cenaUsluge = 700;
                        }
                        else if (pp.Vozilo.TipVozila == "autobus")
                        {
                            cenaUsluge = 1000;
                        }
                        else if (pp.Vozilo.TipVozila == "kamion")
                        {
                            cenaUsluge = 1100;
                        }
                    }
                }
            }
            else if (rdbProduzi720h.Checked == true)
            {
                fleg = true;

                foreach (ParkingMesto p in this.baza.parkiranaVozila())
                {
                    if (p.Vozilo.RegTab == dataGridProduzavanje.CurrentCell.Value.ToString())
                    {
                        pp = p;
                        krajParkiranjaVozila = pp.Vozilo.KrajParkiranja;
                        pp.Vozilo.produziParkiranje(720);
                        pp.Vozilo.UslugaParkingServisa = 720;

                        if (pp.Vozilo.TipVozila == "automobil")
                        {
                            cenaUsluge = 1400;
                        }
                        else if (pp.Vozilo.TipVozila == "autobus")
                        {
                            cenaUsluge = 1800;
                        }
                        else if (pp.Vozilo.TipVozila == "kamion")
                        {
                            cenaUsluge = 1900;
                        }
                    }
                }
            }

            if (fleg == true)
            {
                //izmena u bazi parking
                if (this.baza.izmeniVozilo(pp.BrGaraze, pp.Broj, pp.BrGaraze, pp.Broj, pp.Vozilo.TipVozila, Convert.ToInt32(pp.Vozilo.DalijeInvalidsko) + 70,
                    pp.Vozilo.RegTab, pp.Vozilo.PocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss"), pp.Vozilo.KrajParkiranja.ToString("yyyy-MM-dd H:mm:ss"),
                    pp.Vozilo.UslugaParkingServisa, pp.Vozilo.Racun))
                {
                    labelPozicija.Text = "Produženo parkiranje vozila " + pp.Vozilo.RegTab + ".";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer2.Start();
                }
                else
                {
                    labelPozicija.Text = "Nemoguć produžetak parkiranja vozila: " + pp.Vozilo.RegTab + ".";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer2.Start();
                }

                //dodavanje u bazi parkingIstorija
                this.baza.dodajVoziloIstorija(pp.BrGaraze, pp.Broj, pp.Vozilo.TipVozila, Convert.ToInt32(pp.Vozilo.DalijeInvalidsko),
                    pp.Vozilo.RegTab, krajParkiranjaVozila.ToString("yyyy-MM-dd H:mm:ss"), pp.Vozilo.KrajParkiranja.ToString("yyyy-MM-dd H:mm:ss"),
                    pp.Vozilo.UslugaParkingServisa, cenaUsluge);

                //da bi refresovali prikaz u formama za garaze
                this.ucitajParkiranaVozila();

                this.AppendTextInfo("Produžavanje: ", Color.FromArgb(255, 211, 78), false, false);
                String textPrikaz = pp.Vozilo.TipVozila.Substring(0, 1).ToUpper() + pp.Vozilo.TipVozila.Substring(1);
                textPrikaz += " " + pp.Vozilo.RegTab + " je uspešno produžio parkiranje.  [ Garaža: " + pp.BrGaraze + ", Parking mesto: " + pp.Broj + " ]";
                this.AppendTextInfo(textPrikaz, Color.White, true, false);


                String textPrikazHistory = "Produžavanje: " + pp.Vozilo.TipVozila.Substring(0, 1).ToUpper() + pp.Vozilo.TipVozila.Substring(1);
                string invText = null;
                if (pp.Vozilo.DalijeInvalidsko == true)
                    invText = "da";
                else
                    invText = "ne";
                textPrikazHistory += " " + pp.Vozilo.RegTab + " je uspešno produžio parkiranje.Invaliditet: " + invText + ",početak: " + pp.Vozilo.PocetakParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ",kraj: " + pp.Vozilo.KrajParkiranja.ToString("yyyy-MM-dd H:mm:ss") + ",usluga: " + pp.Vozilo.UslugaParkingServisa + "h, račun: " + pp.Vozilo.Racun + "RSD.  [ Garaža: " + pp.BrGaraze + ", Parking mesto: " + pp.Broj + " ]" + " | " + zaposlenIme + " |";
                this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                baza.dodajAktivnost(textPrikazHistory);

                this.groupBoxProduziPodaciVozila.Visible = false;
                rdbProduzi1h.Checked = false;
                rdbProduzi12h.Checked = false;
                rdbProduzi24h.Checked = false;
                rdbProduzi168h.Checked = false;
                rdbProduzi720h.Checked = false;
            }
            else
            {
                labelPozicija.Text = "Izaberite novu uslugu. " + pp.Vozilo.RegTab + ".";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                labelKorisnik.Text = "";
                timer2.Start();
            }
        }

        private void cbxRezervacijeTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxRezervacijeTip.SelectedItem.ToString()=="automobil")
            {
                cbxRezervacijeMesto.Items.Clear();

                for(int i=1;i<=20;i++)
                 cbxRezervacijeMesto.Items.Add(i);

                cbxRezervacijeMesto.Enabled = true;
            }
            else if (cbxRezervacijeTip.SelectedItem.ToString()=="automobil sa invaliditetom")
            {
                cbxRezervacijeMesto.Items.Clear();

                for (int i = 20; i <= 24; i++)
                    cbxRezervacijeMesto.Items.Add(i);

                cbxRezervacijeMesto.Enabled = true;
            }
            else if (cbxRezervacijeTip.SelectedItem.ToString()=="autobus")
            {
                cbxRezervacijeMesto.Items.Clear();

                for (int i = 25; i <= 32; i++)
                    cbxRezervacijeMesto.Items.Add(i);

                cbxRezervacijeMesto.Enabled = true;
            }
            else if(cbxRezervacijeTip.SelectedItem.ToString()=="kamion")
            {
                cbxRezervacijeMesto.Items.Clear();

                for (int i = 25; i <= 32; i++)
                    cbxRezervacijeMesto.Items.Add(i);

                cbxRezervacijeMesto.Enabled = true;
            }
            else
            {
                cbxRezervacijeMesto.Enabled = false;
            }

        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            int usluga = 0;
            switch(cbxRezervacijeUsluga.SelectedIndex)
            {
                case 0: usluga = 1; break;
                case 1: usluga = 12; break;
                case 2: usluga = 24; break;
                case 3: usluga = 168; break;
                case 4: usluga = 720; break;
            }
            int garaza = Convert.ToInt32(cbxRezervacijeGaraza.SelectedItem);
            int mesto = Convert.ToInt32(cbxRezervacijeMesto.SelectedItem);
            DateTime datum = DateTime.Parse(datePickerRezervacije.Value.ToString("yyyy-MM-dd") + " " + TimePickerRezervacije.Value.TimeOfDay.ToString());

            bool fleg = false;

            if (parkingServis.ListaGaraza[garaza - 1].ListaParkingMesta[mesto - 1].Vozilo != null)
            {
                Vozilo v = new Vozilo();
                v = parkingServis.ListaGaraza[garaza - 1].ListaParkingMesta[mesto - 1].Vozilo;
                if(v.KrajParkiranja<datum)
                {
                    fleg = true;
                }
                else
                {
                    fleg = false;
                }
            }

            if (this.baza.vratiRezervacije().Count > 0)
            {
                foreach (ParkingMesto p in this.baza.vratiRezervacije())
                {
                    if (p.Broj == mesto && p.BrGaraze == garaza)
                    {
                        DateTime zavrsetakParkiranjaRezervacije = p.Vozilo.PocetakParkiranja.AddHours(p.Vozilo.UslugaParkingServisa);
                        if (datum > zavrsetakParkiranjaRezervacije && datum.AddHours(usluga) < p.Vozilo.PocetakParkiranja)
                        {

                        }
                        else

                        {
                            fleg = false;
                        }
                    }
                }
            }

            if (fleg == true)
            {

                if (baza.dodajRezervaciju(cbxRezervacijeTip.SelectedItem.ToString(), Convert.ToInt32(cbxRezervacijeGaraza.SelectedItem),
                    Convert.ToInt32(cbxRezervacijeMesto.SelectedItem),
                    txtRezervacijeReg.Text, datePickerRezervacije.Value.ToString("yyyy-MM-dd") + " " + TimePickerRezervacije.Value.TimeOfDay.ToString(),
                    usluga))
                {
                    labelPozicija.Text = "Vozilo " + txtRezervacijeReg.Text + " je izvršilo rezervaciju.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer2.Start();
                }
                else
                {
                    labelPozicija.Text = "Neuspešna rezervacija.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer2.Start();
                }

                this.AppendTextInfo("Rezervacija: ", Color.FromArgb(174, 99, 255), false, false);
                String textPrikaz = cbxRezervacijeTip.SelectedItem.ToString().Substring(0, 1).ToUpper() + cbxRezervacijeTip.SelectedItem.ToString().Substring(1);
                textPrikaz += " " + txtRezervacijeReg.Text + " je uspešno izvršio rezervaciju.  [ Garaža: " + Convert.ToInt32(cbxRezervacijeGaraza.SelectedItem) + ", Parking mesto: " + Convert.ToInt32(cbxRezervacijeMesto.SelectedItem) + " ]";
                this.AppendTextInfo(textPrikaz, Color.White, true, false);


                String textPrikazHistory = "Rezervacija: " + cbxRezervacijeTip.SelectedItem.ToString().Substring(0, 1).ToUpper() + cbxRezervacijeTip.SelectedItem.ToString().Substring(1);
                textPrikazHistory += " " + txtRezervacijeReg.Text + " je uspešno izvršio rezervaciju. Datum: " + datePickerRezervacije.Value.ToString("yyyy-MM-dd") + ", termin: " + TimePickerRezervacije.Value.TimeOfDay.ToString() + ", usluga:" + usluga+ "h.   [ Garaža: " + Convert.ToInt32(cbxRezervacijeGaraza.SelectedItem) + ", Parking mesto: " + Convert.ToInt32(cbxRezervacijeMesto.SelectedItem) + " ]" + " | " + zaposlenIme + " |";
                this.AppendTextInfo(textPrikazHistory, Color.White, true, true);
                baza.dodajAktivnost(textPrikazHistory);

                //refresujemo prikaz aktivnosti

                dataGridRezervacije.Rows.Clear();

                List<ParkingMesto> lista = this.baza.vratiRezervacije();

                foreach (ParkingMesto p in lista)
                {
                    dataGridRezervacije.Rows.Add(p.Vozilo.RegTab, p.Vozilo.PocetakParkiranja, p.Vozilo.UslugaParkingServisa, p.Vozilo.TipVozila, p.BrGaraze, p.Broj);
                }
            }
            else
            {
                labelPozicija.Text = "Neuspešna rezervacija.";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                labelKorisnik.Text = "";
                timer2.Start();
            }

        
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {

            if (dataGridRezervacije.CurrentRow.Selected==true)
            {
                if (this.baza.obrisiRezervaciju(dataGridRezervacije.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridRezervacije.CurrentRow.Cells[2].Value), dataGridRezervacije.CurrentRow.Cells[3].Value.ToString(), Convert.ToInt32(dataGridRezervacije.CurrentRow.Cells[4].Value), Convert.ToInt32(dataGridRezervacije.CurrentRow.Cells[5].Value)))
                {
                    labelPozicija.Text = "Rezervacija je uspešno uklonjena.";
                    labelPozicija.ForeColor = Color.FromArgb(153, 255, 0);
                    labelKorisnik.Text = "";
                    timer2.Start();
                    this.buttonRezervacije_Click(sender, e);
                }
                else
                {
                    labelPozicija.Text = "Neuspešno uklanjanje rezervacije.";
                    labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                    labelKorisnik.Text = "";
                    timer2.Start();
                }
            }
            else
            {
                labelPozicija.Text = "Potrebno je selektovati rezervaciju.";
                labelPozicija.ForeColor = Color.FromArgb(255, 45, 45);
                labelKorisnik.Text = "";
                timer2.Start();
            }
        }

        private void buttonPreostaloVreme_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "preostalovreme";
            panelLogovanje.Hide();
            panelIstorijaParkiranja.Hide();
            panelUsluge.Hide();
            this.panelStatistika.Hide();
            this.panelRezervacijeProduzavanja.Hide();
            panelGaraze.Hide();
            panelPreostaloVreme.Show();

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreostaloVreme.Location.Y);

            if (SlideMenu.Width == 50)
            {
                if (slajdPreostaloVreme == "prosiren")
                {
                    this.panelPreostaloVreme.Location = new Point(this.panelPreostaloVreme.Location.X - 100, this.panelPreostaloVreme.Location.Y);
                    slajdPreostaloVreme = "uvucen";
                }
            }
            else
            {
                if (slajdPreostaloVreme == "uvucen")
                {
                    this.panelPreostaloVreme.Location = new Point(this.panelPreostaloVreme.Location.X + 100, this.panelPreostaloVreme.Location.Y);
                    slajdPreostaloVreme = "prosiren";
                }
            }

            List<ParkingMesto> lista = this.baza.parkiranaVozila();
            List<bool> ll = new List<bool>();
            dataGridPreostaloVreme.Rows.Clear();
            string preostaloVremeParkiranja;
            //1h=10sec,12h=2min,24h=4min,nedeljuDana=28min, mesecDana=120min
            
            foreach (ParkingMesto p in lista)
            {
                if (DateTime.Now > p.Vozilo.KrajParkiranja)
                {
                    preostaloVremeParkiranja = "Isteklo parkiranje.";

                    dataGridPreostaloVreme.Rows.Add(p.BrGaraze, p.Broj, p.Vozilo.RegTab, preostaloVremeParkiranja);
                    ll.Add(true);
                   
                }
                else
                {
                    TimeSpan span =p.Vozilo.KrajParkiranja.Subtract(DateTime.Now);
                   // double sekunde = (double)span.Seconds;
                    //span = TimeSpan.FromSeconds(sekunde);
                    preostaloVremeParkiranja= string.Format("{0}:{1}", (int)span.TotalMinutes, span.Seconds);
                    preostaloVremeParkiranja = String.Format("{0} days, {1} hours, {2} minutes",
                     span.Days, span.Hours, span.Minutes);
                   /* long lng = span.Days * 24 * 60 * 60 + span.Hours * 60 * 60 + span.Minutes * 60 + span.Seconds;
                    lng /= 360;
                    long min = lng / 60;
                    long sec = lng - min * 60;
                    preostaloVremeParkiranja = min.ToString() + " min " + sec.ToString() + " sec";*/

                    dataGridPreostaloVreme.Rows.Add(p.BrGaraze, p.Broj, p.Vozilo.RegTab, preostaloVremeParkiranja);
                    ll.Add(false);
                }
                
            }

            for(int i=0;i<ll.Count;i++)
            {
                if(ll[i]==true)
                    dataGridPreostaloVreme.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                dataGridPreostaloVreme.Rows[i].Selected = false;
            }
           
        }

        private void dataGridPreostaloVreme_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPreostaloVreme.CurrentRow.Selected == true && dataGridPreostaloVreme.CurrentRow.DefaultCellStyle.ForeColor==Color.Red)
                btnPreostaloVremeUkloni.Visible = true;
            else
                btnPreostaloVremeUkloni.Visible = false;
        }

        private void btnPreostaloVremeUkloni_Click(object sender, EventArgs e)
        {
            if(dataGridPreostaloVreme.CurrentRow.Selected==true)
            {
                rdbParkingMesto.Checked = true;
                cbxUkloniGaraza.SelectedIndex = Convert.ToInt32(dataGridPreostaloVreme.CurrentRow.Cells[0].Value) - 1;
                cbxUkloniParkingMesto.SelectedItem = dataGridPreostaloVreme.CurrentRow.Cells[1].Value.ToString();
                buttonUkloni_Click(sender, e);
                buttonPreostaloVreme_Click(sender, e);
            }
        }
    }
}
