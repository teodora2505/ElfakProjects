
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using System.ComponentModel;
using System.Data;
using System.Text;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;
using Cassandra;


namespace MovieCritic
{
    public partial class MovieCriticKorisnik : Form
    {
        #region Promenljive
        public string logovanUsername;
        public string logovanPassword;
        public string trenutnaOpcija = "pocetna";//"pocetna","filmovi"
        public bool slideMenuExpanded = true;
        public string slajdFilmoviii = "prosiren";
        public string slajdFilmovi = "prosiren";
        public string slajdOmiljeniFilmovi = "prosiren";
        public string slajdOdgledaniFilmovi = "prosiren";
        public string slajdRecenzije = "prosiren";
        public string slajdTop10 = "prosiren";
        public Film selektovaniFilm = null;
        public bool ocenjivanjeFilma = false;
        public bool recenzijranjeFilma = false;
        public List<Film> omiljeniFilmovi = new List<Film>(); int trenutnoOmiljen;
        public List<Film> odgledaniFilmovi = new List<Film>(); int trenutnoOdgledan;
        string sifraFilmaZaRecenziju;
        int sec_counter = 0;

        #endregion

        public MovieCriticKorisnik()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideMenuExpanded = !slideMenuExpanded;
            if (SlideMenu.Width == 50)//kad je slideMenu uvucen
            {
                    
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 200;
                    PanelAnimator.ShowSync(SlideMenu);
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);

                if (trenutnaOpcija == "pocetna")
                {
                   
                    slajdFilmoviii = "prosiren";
                    panelFilmoviii.Show();
                    panelFilmovi.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelFilmoviii.Location = new Point(this.panelFilmoviii.Location.X + 100, this.panelFilmoviii.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmoviii);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, btnZanrovi.Location.Y);
                }
                else if (trenutnaOpcija == "filmovi")
                {
                    
                    slajdFilmovi = "prosiren";
                    panelFilmovi.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X + 100, this.panelFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOceniFilm.Location.Y);
                }
                else if(trenutnaOpcija=="omiljeniFilmovi")
                {
                   
                    slajdOmiljeniFilmovi = "prosiren";
                    panelOmiljeniFilmovi.Show();
                    panelFilmoviii.Hide();
                    panelFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X + 100, this.panelOmiljeniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "odgledaniFilmovi")
                {
                   
                    slajdOdgledaniFilmovi = "prosiren";
                    panelOdgledaniFilmovi.Show();
                    panelFilmoviii.Hide();
                    panelFilmovi.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X + 100, this.panelOdgledaniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOdgledaniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOdgledaniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                
                    slajdRecenzije = "prosiren";
                    panelRecenzije.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelTop10.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

                }
                else if (trenutnaOpcija == "top10")
                {
                   
                    slajdTop10 = "prosiren";
                    panelTop10.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelTop10.Hide();
                    panelRecenzije.Hide();
                    this.panelTop10.Location = new Point(this.panelTop10.Location.X + 100, this.panelTop10.Location.Y);
                    PanelAnimator2.ShowSync(panelTop10);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonTop10.Location.Y);

                }

                    LogoAnimator.ShowSync(Logo);
            }
            else//kad je slideMenu prosiren
            {

                    LogoAnimator.Hide(Logo);
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 50;
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);

                if (trenutnaOpcija == "pocetna")
                {
                    
                    slajdFilmoviii = "uvucen";
                    panelFilmoviii.Show();
                    panelFilmovi.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelFilmoviii.Location = new Point(this.panelFilmoviii.Location.X - 100, this.panelFilmoviii.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmoviii);

                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, btnZanrovi.Location.Y);
                }
                else if (trenutnaOpcija == "filmovi")
                {
                   
                    slajdFilmovi = "uvucen";
                    panelFilmovi.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X - 100, this.panelFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOceniFilm.Location.Y);
                }
                else if (trenutnaOpcija == "omiljeniFilmovi")
                {
               
                    slajdOmiljeniFilmovi = "uvucen";
                    panelOmiljeniFilmovi.Show();
                    panelFilmovi.Hide();
                    panelFilmoviii.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X - 100, this.panelOmiljeniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "odgledaniFilmovi")
                {
                  
                    slajdOdgledaniFilmovi = "uvucen";
                    panelOdgledaniFilmovi.Show();
                    panelFilmovi.Hide();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelTop10.Hide();
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X - 100, this.panelOdgledaniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOdgledaniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOdgledaniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                   
                    slajdRecenzije = "uvucen";
                    panelRecenzije.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelTop10.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);
                }
                else if (trenutnaOpcija == "top10")
                {
                   
                    slajdTop10 = "prosiren";
                    slajdTop10 = "uvucen";
                    panelTop10.Show();
                    panelFilmoviii.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelTop10.Hide();
                    panelRecenzije.Hide();
                    this.panelTop10.Location = new Point(this.panelTop10.Location.X - 100, this.panelTop10.Location.Y);
                    PanelAnimator2.ShowSync(panelTop10);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonTop10.Location.Y);

                }

                    PanelAnimator.ShowSync(SlideMenu);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelZanrovi.Visible = true;
            this.panelFilmovi.Visible = false;
            this.panelOdgledaniFilmovi.Visible = false;
            this.panelOmiljeniFilmovi.Visible = false;
            this.panelRecenzije.Visible = false;
            this.panelTop10.Visible = false;

            this.labelWarning.Visible = false;

            Korisnik k = DataProvider.GetKorisnik(logovanUsername, logovanPassword);
            labelKorisnik.Text = k.ime + " " + k.prezime;
            
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, btnZanrovi.Location.Y);
        }


        #region PomocneFunkcije
        private void TimerWarning_Tick(object sender, EventArgs e)
        {
            if (sec_counter < 4)
            {
                labelWarning.Visible = true;
                sec_counter++;
            }
            else
            {
                labelWarning.Visible = false;
                sec_counter = 0;
                timerWarning.Stop();
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public string DuplirajApostrofUNazivuFilmaUkolikoPostoji(string filmNaziv)
        {
            string[] nizStringova = filmNaziv.Split('\'');
            string rezultat = null;
            for (int i = 0; i < nizStringova.Length - 1; i++)
            {
                rezultat += nizStringova[i] + "\'\'";
            }
            rezultat += nizStringova[nizStringova.Length - 1];
            filmNaziv = rezultat;

            return filmNaziv;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)// Dugme X za zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Dugme za minimizaciju forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Korisnik_FilmskiZanrovi
        private void BtnZanrovi_Click(object sender, EventArgs e)
        {
            if (SlideMenu.Width == 50)
            {
                if (slajdFilmoviii == "prosiren")
                {
                    this.panelFilmoviii.Location = new Point(this.panelFilmoviii.Location.X - 100, this.panelFilmoviii.Location.Y);
                    slajdFilmoviii = "uvucen";
                }
            }
            else
            {
                if (slajdFilmoviii == "uvucen")
                {
                    this.panelFilmoviii.Location = new Point(this.panelFilmoviii.Location.X + 100, this.panelFilmoviii.Location.Y);
                    slajdFilmoviii = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, btnZanrovi.Location.Y);

            trenutnaOpcija = "pocetna";
            panelFilmovi.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelRecenzije.Hide();
            panelTop10.Hide();
            panelFilmoviii.Show();
            panelZanrovi.Visible = true;
            flowPanelIzabraniZanr.Visible = false;
            flowPanelIzabraniZanr.Controls.Clear();
            
        }

        private void BtnZanrDrama_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> drame = DataProvider.GetZanr("drama");
            UserFilmControl[] kontrole = new UserFilmControl[drame.Count];
            Button[] nizButtonOceni = new Button[drame.Count];
            Button[] nizButtonLike = new Button[drame.Count];
            Button[] nizButtonDislike = new Button[drame.Count];
            Button[] nizButtonRecenzije = new Button[drame.Count];
            Button[] nizButtonFavoriteFilm = new Button[drame.Count];
            Button[] nizButtonOdgledaniFilm = new Button[drame.Count];

            this.popuniFlowPanelIzabraniZanr(drame, kontrole,nizButtonOceni,nizButtonLike,nizButtonDislike,nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
            
        }

        private void BtnZanrHoror_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> horori = DataProvider.GetZanr("horor");
            UserFilmControl[] kontrole = new UserFilmControl[horori.Count];
            Button[] nizButtonOceni = new Button[horori.Count];
            Button[] nizButtonLike = new Button[horori.Count];
            Button[] nizButtonDislike = new Button[horori.Count];
            Button[] nizButtonRecenzije = new Button[horori.Count];
            Button[] nizButtonFavoriteFilm = new Button[horori.Count];
            Button[] nizButtonOdgledaniFilm = new Button[horori.Count];

            this.popuniFlowPanelIzabraniZanr(horori, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrFantastika_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> fantastike = DataProvider.GetZanr("fantastika");
            UserFilmControl[] kontrole = new UserFilmControl[fantastike.Count];
            Button[] nizButtonOceni = new Button[fantastike.Count];
            Button[] nizButtonLike = new Button[fantastike.Count];
            Button[] nizButtonDislike = new Button[fantastike.Count];
            Button[] nizButtonRecenzije = new Button[fantastike.Count];
            Button[] nizButtonFavoriteFilm = new Button[fantastike.Count];
            Button[] nizButtonOdgledaniFilm = new Button[fantastike.Count];

            this.popuniFlowPanelIzabraniZanr(fantastike, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrKrimi_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> krimosi = DataProvider.GetZanr("krimi");
            UserFilmControl[] kontrole = new UserFilmControl[krimosi.Count];
            Button[] nizButtonOceni = new Button[krimosi.Count];
            Button[] nizButtonLike = new Button[krimosi.Count];
            Button[] nizButtonDislike = new Button[krimosi.Count];
            Button[] nizButtonRecenzije = new Button[krimosi.Count];
            Button[] nizButtonFavoriteFilm = new Button[krimosi.Count];
            Button[] nizButtonOdgledaniFilm = new Button[krimosi.Count];

            this.popuniFlowPanelIzabraniZanr(krimosi, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrAkcioni_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> akcionii = DataProvider.GetZanr("akcioni");
            UserFilmControl[] kontrole = new UserFilmControl[akcionii.Count];
            Button[] nizButtonOceni = new Button[akcionii.Count];
            Button[] nizButtonLike = new Button[akcionii.Count];
            Button[] nizButtonDislike = new Button[akcionii.Count];
            Button[] nizButtonRecenzije = new Button[akcionii.Count];
            Button[] nizButtonFavoriteFilm = new Button[akcionii.Count];
            Button[] nizButtonOdgledaniFilm = new Button[akcionii.Count];

            this.popuniFlowPanelIzabraniZanr(akcionii, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrTriler_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> trileri = DataProvider.GetZanr("triler");
            UserFilmControl[] kontrole = new UserFilmControl[trileri.Count];
            Button[] nizButtonOceni = new Button[trileri.Count];
            Button[] nizButtonLike = new Button[trileri.Count];
            Button[] nizButtonDislike = new Button[trileri.Count];
            Button[] nizButtonRecenzije = new Button[trileri.Count];
            Button[] nizButtonFavoriteFilm = new Button[trileri.Count];
            Button[] nizButtonOdgledaniFilm = new Button[trileri.Count];

            this.popuniFlowPanelIzabraniZanr(trileri, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrKomedija_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> komedije = DataProvider.GetZanr("komedija");
            UserFilmControl[] kontrole = new UserFilmControl[komedije.Count];
            Button[] nizButtonOceni = new Button[komedije.Count];
            Button[] nizButtonLike = new Button[komedije.Count];
            Button[] nizButtonDislike = new Button[komedije.Count];
            Button[] nizButtonRecenzije = new Button[komedije.Count];
            Button[] nizButtonFavoriteFilm = new Button[komedije.Count];
            Button[] nizButtonOdgledaniFilm = new Button[komedije.Count];

            this.popuniFlowPanelIzabraniZanr(komedije, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm, nizButtonOdgledaniFilm);
        }

        private void BtnZanrRomantika_Click(object sender, EventArgs e)
        {
            panelZanrovi.Visible = false;
            flowPanelIzabraniZanr.Visible = true;
            List<Film> romantike = DataProvider.GetZanr("romantika");
            UserFilmControl[] kontrole = new UserFilmControl[romantike.Count];
            Button[] nizButtonOceni = new Button[romantike.Count];
            Button[] nizButtonLike = new Button[romantike.Count];
            Button[] nizButtonDislike = new Button[romantike.Count];
            Button[] nizButtonRecenzije = new Button[romantike.Count];
            Button[] nizButtonFavoriteFilm = new Button[romantike.Count];
            Button[] nizButtonOdgledaniFilm = new Button[romantike.Count];

            this.popuniFlowPanelIzabraniZanr(romantike, kontrole, nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije, nizButtonFavoriteFilm,nizButtonOdgledaniFilm);
        }

        public void popuniFlowPanelIzabraniZanr(List<Film> listaFilmova, UserFilmControl[] kontrole, Button[] nizButtonOceni, Button[] nizButtonLike, Button[] nizButtonDislike, Button[] nizButtonRecenzije, Button[] nizButtonFavoriteFilm, Button[] nizButtonOdgledaniFilm)
        {
            for (int i = 0; i < listaFilmova.Count; i++)
            {
                kontrole[i] = new UserFilmControl();
                kontrole[i].setLabelNaziv(listaFilmova[i].naziv);
                kontrole[i].setLabelReziser(listaFilmova[i].reziser);
                kontrole[i].setLabelGodina(listaFilmova[i].godina);
                kontrole[i].setLabelZanr(listaFilmova[i].zanr);
                int commasNumber = listaFilmova[i].glumci.Count(f => f == ',');
                if (commasNumber == 0)
                {
                    kontrole[i].setLabelGlumac1(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0]);
                    kontrole[i].setLabelGlumac2("");
                    kontrole[i].setLabelGlumac3("");
                }
                else if (commasNumber == 1)
                {
                    kontrole[i].setLabelGlumac1(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0]);
                    kontrole[i].setLabelGlumac2(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1]);
                    kontrole[i].setLabelGlumac3("");
                }
                else if (commasNumber == 2)
                {
                    kontrole[i].setLabelGlumac1(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0]);
                    kontrole[i].setLabelGlumac2(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1]);
                    kontrole[i].setLabelGlumac3(listaFilmova[i].glumci.Split(new[] { ", " }, StringSplitOptions.None)[2]);
                }

                if (DataProvider.daLiJeFilmOcenjen(listaFilmova[i].sifra))
                    kontrole[i].setLabelOcena(DataProvider.GetOcena(listaFilmova[i].sifra).ocena.ToString("0.00"));
                else
                    kontrole[i].setLabelOcena("✗");

                kontrole[i].setLabelLike(DataProvider.GetBrojPreporuka(listaFilmova[i].sifra).ToString());
                kontrole[i].setLabelDislike(DataProvider.GetBrojNePreporuka(listaFilmova[i].sifra).ToString());
                kontrole[i].setLabelRecenzija(DataProvider.brojRecenzijaFilma(listaFilmova[i].sifra).ToString());

                flowPanelIzabraniZanr.Controls.Add(kontrole[i]);
                flowPanelIzabraniZanr.Controls.Add(kreirajPanelDugmica( nizButtonOceni, nizButtonLike, nizButtonDislike, nizButtonRecenzije,nizButtonFavoriteFilm, nizButtonOdgledaniFilm, i, listaFilmova[i]));
            }
        }

        public FlowLayoutPanel kreirajPanelDugmica(Button[] nizButtonOceni, Button[] nizButtonLike, Button[] nizButtonDislike, Button[] nizButtonRecenzije, Button[] nizButtonFavoriteFilm, Button[] nizButtonOdgledaniFilm, int i , Film film)
        {
            nizButtonOceni[i] = new Button();
            nizButtonOceni[i].Width = 90;
            nizButtonOceni[i].Height = 30;
            nizButtonOceni[i].BackColor = Color.Black;
            nizButtonOceni[i].ForeColor = Color.White;
            nizButtonOceni[i].FlatStyle = FlatStyle.Flat;
            nizButtonOceni[i].FlatAppearance.BorderSize = 3;
            nizButtonOceni[i].FlatAppearance.BorderColor = Color.MidnightBlue;
            nizButtonOceni[i].Font = new Font(nizButtonOceni[i].Font, FontStyle.Bold);
            nizButtonOceni[i].Text = "Oceni";
            nizButtonOceni[i].Tag = film;
            nizButtonOceni[i].Click += (s, e) => {
                ocenjivanjeFilma = true;
                ButtonOceniFilm_Click(s, e);
                panelFilmovi.Visible = true;
                flowPanelIzabraniZanr.Visible = false;
                dataGridFilmovi.Visible = false;
                labelOceniObavestenje.Visible = false;
                panelOceni.Visible = true;
                panelOceni.BringToFront();
                txtOceniFilmSifra.Text =film.sifra;
                txtOceniFilmZanr.Text =film.zanr;
                txtOceniFilmGodina.Text = film.godina;
                txtOceniFilmNaziv.Text = film.naziv;
                txtOceniFilmOcena.Text = DataProvider.GetOcena(film.sifra).ocena.ToString("0.00");
                txtOceniFilmReziser.Text = film.reziser;
                int commasNumber = film.glumci.Count(f => f == ',');
                if (commasNumber == 0)
                {
                    txtOceniFilmGlumac1.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                    txtOceniFilmGlumac2.Text = "";
                    txtOceniFilmGlumac3.Text = "";
                }
                else if (commasNumber == 1)
                {
                    txtOceniFilmGlumac1.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                    txtOceniFilmGlumac2.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                    txtOceniFilmGlumac3.Text = "";
                }
                else if (commasNumber == 2)
                {
                    txtOceniFilmGlumac1.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                    txtOceniFilmGlumac2.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                    txtOceniFilmGlumac3.Text = film.glumci.Split(new[] { ", " }, StringSplitOptions.None)[2];
                }

            };
            nizButtonLike[i] = new Button();
            nizButtonLike[i].Width = 44;
            nizButtonLike[i].Height = 40;
            nizButtonLike[i].BackColor = Color.FromArgb(107, 227, 127);
            nizButtonLike[i].ForeColor = Color.MidnightBlue;
            nizButtonLike[i].FlatStyle = FlatStyle.Flat;
            nizButtonLike[i].FlatAppearance.BorderSize = 3;
            nizButtonLike[i].FlatAppearance.BorderColor = Color.MidnightBlue;
            nizButtonLike[i].Font = new Font("Arial",14, FontStyle.Bold);
            nizButtonLike[i].Text = "👍";
            nizButtonLike[i].Click += (s, e) =>
            {
                if(!DataProvider.daLiJeKorisnikVecPreporucioFilm(film.sifra,logovanUsername,logovanPassword))
                {
                    Preporuka p = new Preporuka();
                    p.username = logovanUsername;
                    p.password = logovanPassword;
                    p.preporuka = "da";
                    p.sifraFilma = film.sifra;
                    DataProvider.dodajPreporuku(p);
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Preporučujete film.";
                    timerWarning.Start();
                    foreach(UserFilmControl u in GetAll(flowPanelIzabraniZanr, typeof(UserFilmControl)))
                    {
                        if(u.getLabelNaziv()==film.naziv && u.getLabelGodina()==film.godina)
                        {
                            u.setLabelLike(DataProvider.GetBrojPreporuka(film.sifra).ToString());
                        }
                    }
                }
                else
                {
                    if(DataProvider.getKorisnikovaPreporuka(film.sifra,logovanUsername,logovanPassword).preporuka=="ne")
                    {
                        Preporuka staraPreporuka = new Preporuka();
                        staraPreporuka = DataProvider.getKorisnikovaPreporuka(film.sifra, logovanUsername, logovanPassword);
                        DataProvider.UpdatePreporuka(staraPreporuka, "da");
                        sec_counter = 0;
                        labelWarning.ForeColor = Color.Green;
                        labelWarning.Text = "Preporučujete film.";
                        timerWarning.Start();
                        foreach (UserFilmControl u in GetAll(flowPanelIzabraniZanr, typeof(UserFilmControl)))
                        {
                            if (u.getLabelNaziv() == film.naziv && u.getLabelGodina() == film.godina)
                            {
                                u.setLabelLike(DataProvider.GetBrojPreporuka(film.sifra).ToString());
                                u.setLabelDislike(DataProvider.GetBrojNePreporuka(film.sifra).ToString());
                            }
                        }
                    }
                    else
                    {
                        sec_counter = 0;
                        labelWarning.ForeColor = Color.Red;
                        labelWarning.Text = "Već ste preporučili film.";
                        timerWarning.Start();
                    }
                   
                }
            };
            nizButtonDislike[i] = new Button();
            nizButtonDislike[i].Width = 44;
            nizButtonDislike[i].Height =40;
            nizButtonDislike[i].BackColor = Color.FromArgb(255, 66, 66);
            nizButtonDislike[i].ForeColor = Color.MidnightBlue;
            nizButtonDislike[i].FlatStyle = FlatStyle.Flat;
            nizButtonDislike[i].FlatAppearance.BorderSize = 3;
            nizButtonDislike[i].FlatAppearance.BorderColor = Color.MidnightBlue;
            nizButtonDislike[i].Font = new Font("Arial",14, FontStyle.Bold);
            nizButtonDislike[i].Text = "👎";
            nizButtonDislike[i].Click += (s, e) =>
            {
                if (!DataProvider.daLiJeKorisnikVecPreporucioFilm(film.sifra, logovanUsername, logovanPassword))
                {
                    Preporuka p = new Preporuka();
                    p.username = logovanUsername;
                    p.password = logovanPassword;
                    p.preporuka = "ne";
                    p.sifraFilma = film.sifra;
                    DataProvider.dodajPreporuku(p);
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Ne preporučujete film.";
                    timerWarning.Start();
                    foreach (UserFilmControl u in GetAll(flowPanelIzabraniZanr, typeof(UserFilmControl)))
                    {
                        if (u.getLabelNaziv() == film.naziv && u.getLabelGodina() == film.godina)
                        {
                            u.setLabelDislike(DataProvider.GetBrojNePreporuka(film.sifra).ToString());
                        }
                    }
                }
                else
                {
                    if (DataProvider.getKorisnikovaPreporuka(film.sifra, logovanUsername, logovanPassword).preporuka == "da")
                    {
                        Preporuka staraPreporuka = new Preporuka();
                        staraPreporuka = DataProvider.getKorisnikovaPreporuka(film.sifra, logovanUsername, logovanPassword);
                        DataProvider.UpdatePreporuka(staraPreporuka, "ne");
                        sec_counter = 0;
                        labelWarning.ForeColor = Color.Green;
                        labelWarning.Text = "Ne preporučujete film.";
                        timerWarning.Start();
                        foreach (UserFilmControl u in GetAll(flowPanelIzabraniZanr, typeof(UserFilmControl)))
                        {
                            if (u.getLabelNaziv() == film.naziv && u.getLabelGodina() == film.godina)
                            {
                                u.setLabelDislike(DataProvider.GetBrojNePreporuka(film.sifra).ToString());
                                u.setLabelLike(DataProvider.GetBrojPreporuka(film.sifra).ToString());
                            }
                        }
                    }
                    else
                    {
                        sec_counter = 0;
                        labelWarning.ForeColor = Color.Red;
                        labelWarning.Text = "Već ne preporučujete film.";
                        timerWarning.Start();
                    }
                }
            };
            nizButtonRecenzije[i] = new Button();
            nizButtonRecenzije[i].Width = 90;
            nizButtonRecenzije[i].Height = 30;
            nizButtonRecenzije[i].BackColor = Color.Black;
            nizButtonRecenzije[i].ForeColor = Color.White;
            nizButtonRecenzije[i].FlatStyle = FlatStyle.Flat;
            nizButtonRecenzije[i].FlatAppearance.BorderSize = 3;
            nizButtonRecenzije[i].FlatAppearance.BorderColor = Color.MidnightBlue;
            nizButtonRecenzije[i].Font = new Font(nizButtonRecenzije[i].Font, FontStyle.Bold);
            nizButtonRecenzije[i].Text = "Recenzije";
            nizButtonRecenzije[i].Click += (s, e) =>
            {
                recenzijranjeFilma = true;
                sifraFilmaZaRecenziju = film.sifra;
                ButtonRecenzije_Click(s, e);
            };
                nizButtonFavoriteFilm[i] = new Button();
            nizButtonFavoriteFilm[i].Width = 44;
            nizButtonFavoriteFilm[i].Height = 50;
            nizButtonFavoriteFilm[i].BackColor = Color.Black;
            nizButtonFavoriteFilm[i].ForeColor = Color.Yellow;
            nizButtonFavoriteFilm[i].FlatStyle = FlatStyle.Flat;
            nizButtonFavoriteFilm[i].FlatAppearance.BorderSize = 0;
            nizButtonFavoriteFilm[i].FlatAppearance.BorderColor = Color.Black;
            nizButtonFavoriteFilm[i].Font = new Font("Arial",29, FontStyle.Regular);

            Korisnik k = new Korisnik();
            k.username = logovanUsername;
            k.password = logovanPassword;
            Film filmcopy = new Film();
            filmcopy = film;
            if (filmcopy.naziv.Contains('\''))  //u slucaju da se u nazivu filma nadje apostrof
                filmcopy.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(filmcopy.naziv);

            if (DataProvider.daLiJeToKorisnikovOmiljeniFilm(k,filmcopy))
                nizButtonFavoriteFilm[i].Text = "★";
            else
            nizButtonFavoriteFilm[i].Text = "✰";

            nizButtonFavoriteFilm[i].Click += (s, e) =>
            {  
                if (nizButtonFavoriteFilm[i].Text == "★") //zeli da izbaci film iz liste omiljenih
                {
                    DataProvider.deleteOmiljeniFilm(k, filmcopy);
                    nizButtonFavoriteFilm[i].Text = "✰";
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Film izbačen iz liste omiljenih.";
                    timerWarning.Start();
                }
                else if(nizButtonFavoriteFilm[i].Text == "✰") //zeli da doda film u listu omiljenih
                {
                    DataProvider.dodajOmiljeniFilm(k, filmcopy);
                    nizButtonFavoriteFilm[i].Text = "★";
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Film dodat u listu omiljenih.";
                    timerWarning.Start();

                } 
            };
            nizButtonOdgledaniFilm[i] = new Button();
            nizButtonOdgledaniFilm[i].Width = 44;
            nizButtonOdgledaniFilm[i].Height = 50;
            nizButtonOdgledaniFilm[i].BackColor = Color.Black;
            nizButtonOdgledaniFilm[i].ForeColor = Color.Green;
            nizButtonOdgledaniFilm[i].FlatStyle = FlatStyle.Flat;
            nizButtonOdgledaniFilm[i].FlatAppearance.BorderSize = 3;
            nizButtonOdgledaniFilm[i].FlatAppearance.BorderColor = Color.Black;
            if (DataProvider.daLiJeKorisnikOdgledaoFilm(k, filmcopy))
            {
                nizButtonOdgledaniFilm[i].Text = "☑";
                nizButtonOdgledaniFilm[i].Font = new Font("Arial", 19, FontStyle.Bold);
                nizButtonOdgledaniFilm[i].ForeColor = Color.Green;
            }
            else
            {
                nizButtonOdgledaniFilm[i].Text = "☐";
                nizButtonOdgledaniFilm[i].Font = new Font("Arial", 26, FontStyle.Bold);
                nizButtonOdgledaniFilm[i].ForeColor = Color.White;
            }
               
            nizButtonOdgledaniFilm[i].Click += (s, e) =>
            {

                if (nizButtonOdgledaniFilm[i].Text == "☑") //zeli da izbaci film iz liste odgledanih
                {
                    DataProvider.deleteOdgledaniFilm(k, filmcopy);
                    nizButtonOdgledaniFilm[i].Text = "☐";
                    nizButtonOdgledaniFilm[i].Font = new Font("Arial", 26, FontStyle.Bold);
                    nizButtonOdgledaniFilm[i].ForeColor = Color.White;
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Film izbačen iz liste odgledanih.";
                    timerWarning.Start();
                }
                else if (nizButtonOdgledaniFilm[i].Text == "☐") //zeli da doda film u listu odgledanih
                {
                    DataProvider.dodajOdgledaniFilm(k, filmcopy);
                    nizButtonOdgledaniFilm[i].Text = "☑";
                    nizButtonOdgledaniFilm[i].Font = new Font("Arial", 19, FontStyle.Bold);
                    nizButtonOdgledaniFilm[i].ForeColor = Color.Green;
                    sec_counter = 0;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Film dodat u listu odgledanih.";
                    timerWarning.Start();

                }
            };
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.Width = 100;
            pnl.Height = 160;
            pnl.Controls.Add(nizButtonOceni[i]);
            pnl.Controls.Add(nizButtonLike[i]);
            pnl.Controls.Add(nizButtonDislike[i]);
            pnl.Controls.Add(nizButtonRecenzije[i]);
            pnl.Controls.Add(nizButtonFavoriteFilm[i]);
            pnl.Controls.Add(nizButtonOdgledaniFilm[i]);
            return pnl;
        }

        #endregion

        #region Korisnik_OcenjivanjeFilmova
        private void ButtonOceniFilm_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "filmovi";
            panelFilmoviii.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            this.panelRecenzije.Hide();
            this.panelTop10.Hide();
            panelFilmovi.Show();
            panelFilmovi.BringToFront();

            if (SlideMenu.Width == 50)
            {
                if (slajdFilmovi == "prosiren")
                {
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X - 100, this.panelFilmovi.Location.Y);
                    slajdFilmovi = "uvucen";
                }
            }
            else
            {
                if (slajdFilmovi == "uvucen")
                {
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X + 100, this.panelFilmovi.Location.Y);
                    slajdFilmovi = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOceniFilm.Location.Y);

            if(ocenjivanjeFilma==false)
            {
                dataGridFilmovi.BringToFront();
                dataGridFilmovi.Visible = true;
                labelOceniObavestenje.Visible = true;
                panelOceni.Visible = false;

                List<Film> filmovi = DataProvider.GetFilmovi();
                dataGridFilmovi.Rows.Clear();

                string ocena;

                foreach (Film f in filmovi)
                {
                    if (DataProvider.daLiJeFilmOcenjen(f.sifra))
                    {
                        ocena = DataProvider.GetOcena(f.sifra).ocena.ToString("0.00");
                    }
                    else
                    {
                        ocena = "✗";
                    }
                    dataGridFilmovi.Rows.Add(f.sifra, f.zanr, f.godina, f.naziv, ocena, f.reziser, f.glumci);
                }

                dataGridFilmovi.Refresh();
            }
            else
            {
                dataGridFilmovi.Visible = false;
                labelOceniObavestenje.Visible = false;
                panelOceni.Visible = true;
                ocenjivanjeFilma = false;
            }
           
       
        }

        private void DataGridFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow d in dataGridFilmovi.Rows)
            {
                d.Selected = false;
            }
            dataGridFilmovi.CurrentRow.Selected = true;

            panelOceni.Visible = true;
            panelOceni.BringToFront();
            labelOceniObavestenje.Visible = false;

            txtOceniFilmSifra.Text = dataGridFilmovi.CurrentRow.Cells[0].Value.ToString();
            txtOceniFilmZanr.Text = dataGridFilmovi.CurrentRow.Cells[1].Value.ToString();
            txtOceniFilmGodina.Text = dataGridFilmovi.CurrentRow.Cells[2].Value.ToString();
            txtOceniFilmNaziv.Text = dataGridFilmovi.CurrentRow.Cells[3].Value.ToString();
            txtOceniFilmOcena.Text = dataGridFilmovi.CurrentRow.Cells[4].Value.ToString();
            txtOceniFilmReziser.Text = dataGridFilmovi.CurrentRow.Cells[5].Value.ToString();
            int commasNumber = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Count(f => f == ',');
            if (commasNumber == 0)
            {
                txtOceniFilmGlumac1.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[0];
                txtOceniFilmGlumac2.Text = "";
                txtOceniFilmGlumac3.Text = "";
            }
            else if (commasNumber == 1)
            {
                txtOceniFilmGlumac1.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[0];
                txtOceniFilmGlumac2.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[1];
                txtOceniFilmGlumac3.Text = "";
            }
            else if (commasNumber == 2)
            {
                txtOceniFilmGlumac1.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[0];
                txtOceniFilmGlumac2.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[1];
                txtOceniFilmGlumac3.Text = dataGridFilmovi.CurrentRow.Cells[6].Value.ToString().Split(new[] { ", " }, StringSplitOptions.None)[2];
            }

            dataGridFilmovi.Visible = false;
            trackOcena.Value = 0;
        }

        private void BtnOceniIzabraniFilm_Click(object sender, EventArgs e)
        {
            if(!DataProvider.daLiJeKorisnikVecOcenioFilm(txtOceniFilmSifra.Text,logovanUsername,logovanPassword))
            {
                Ocena ocena = new Ocena();
                ocena.username = logovanUsername;
                ocena.password = logovanPassword;
                ocena.sifraFilma = txtOceniFilmSifra.Text;
                ocena.ocena = (float)trackOcena.Value;
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Ocenili ste film.";
                DataProvider.dodajOcenu(ocena);
                timerWarning.Start();
                ButtonOceniFilm_Click(sender, e);
            }
            else
            {
                Ocena staraOcena = new Ocena();
                staraOcena = DataProvider.getKorisnikovaOcena(txtOceniFilmSifra.Text, logovanUsername, logovanPassword);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Promenili ste ocenu.";
                DataProvider.UpdateOcena(staraOcena, trackOcena.Value);
                timerWarning.Start();
                ButtonOceniFilm_Click(sender, e);

            }
        }

        #endregion

        #region Korisnik_OmiljeniFilmovi
        private void ButtonOmiljeniFilmovi_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "omiljeniFilmovi";
            panelFilmoviii.Hide();
            panelFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelRecenzije.Hide();
            panelTop10.Hide();
            panelOmiljeniFilmovi.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOmiljeniFilmovi == "prosiren")
                {
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X - 150, this.panelOmiljeniFilmovi.Location.Y);
                    slajdOmiljeniFilmovi = "uvucen";
                }
            }
            else
            {
                if (slajdOmiljeniFilmovi == "uvucen")
                {
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X + 150, this.panelOmiljeniFilmovi.Location.Y);
                    slajdOmiljeniFilmovi = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);

            trenutnoOmiljen = 0;
            prikazOmiljenogFilma(trenutnoOmiljen);
        }

        public void prikazOmiljenogFilma(int trenutnoOmiljen)
        {
            omiljeniFilmovi.Clear();
            omiljeniFilmovi = DataProvider.GetKorisnikoviOmiljeniFilmovi(logovanUsername, logovanPassword);
            labelOmiljeniNaziv.Text = omiljeniFilmovi[trenutnoOmiljen].naziv;
            labelOmiljeniZanr.Text = omiljeniFilmovi[trenutnoOmiljen].zanr;
            labelOmiljeniGodina.Text = omiljeniFilmovi[trenutnoOmiljen].godina;
            labelOmiljeniReziser.Text = omiljeniFilmovi[trenutnoOmiljen].reziser;
            labelOmiljeniOcena.Text = DataProvider.GetOcena(omiljeniFilmovi[trenutnoOmiljen].sifra).ocena.ToString();
            int commasNumber = omiljeniFilmovi[trenutnoOmiljen].glumci.Count(f => f == ',');
            if (commasNumber == 0)
            {
                labelOmiljeniGlumac1.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOmiljeniGlumac2.Text = "";
                labelOmiljeniGlumac3.Text = "";
            }
            else if (commasNumber == 1)
            {
                labelOmiljeniGlumac1.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOmiljeniGlumac2.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                labelOmiljeniGlumac3.Text = "";
            }
            else if (commasNumber == 2)
            {
                labelOmiljeniGlumac1.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOmiljeniGlumac2.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                labelOmiljeniGlumac3.Text = omiljeniFilmovi[trenutnoOmiljen].glumci.Split(new[] { ", " }, StringSplitOptions.None)[2];
            }
        }

        private void BtnOmiljeniLeft_Click(object sender, EventArgs e)
        {
            omiljeniFilmovi.Clear();
            omiljeniFilmovi = DataProvider.GetKorisnikoviOmiljeniFilmovi(logovanUsername, logovanPassword);

            if (trenutnoOmiljen - 1 >= 0)
            {
                trenutnoOmiljen--;
                prikazOmiljenogFilma(trenutnoOmiljen);
            }
            else
                trenutnoOmiljen = 0;
        }

        private void BtnOmiljeniRight_Click(object sender, EventArgs e)
        {
            omiljeniFilmovi.Clear();
            omiljeniFilmovi = DataProvider.GetKorisnikoviOmiljeniFilmovi(logovanUsername, logovanPassword);

            if (omiljeniFilmovi.Count - 1 != trenutnoOmiljen)
            {
                trenutnoOmiljen++;
                prikazOmiljenogFilma(trenutnoOmiljen);
            }
            else
                trenutnoOmiljen = omiljeniFilmovi.Count - 1;
        }
        #endregion

        #region Korisnik_OdgledaniFilmovi
        private void ButtonOdgledaniFilmovi_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "odgledaniFilmovi";
            panelFilmoviii.Hide();
            panelFilmovi.Hide();
            panelOmiljeniFilmovi.Hide();
            panelRecenzije.Hide();
            panelTop10.Hide();
            panelOdgledaniFilmovi.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOdgledaniFilmovi == "prosiren")
                {
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X - 100, this.panelOdgledaniFilmovi.Location.Y);
                    slajdOdgledaniFilmovi = "uvucen";
                }
            }
            else
            {
                if (slajdOdgledaniFilmovi == "uvucen")
                {
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X + 100, this.panelOdgledaniFilmovi.Location.Y);
                    slajdOdgledaniFilmovi = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOdgledaniFilmovi.Location.Y);

            trenutnoOdgledan = 0;
            prikazOdgledanogFilma(trenutnoOdgledan);
        }

        private void BtnOdgledaniLeft_Click(object sender, EventArgs e)
        {
            odgledaniFilmovi.Clear();
            odgledaniFilmovi = DataProvider.GetKorisnikoviOdgledaniFilmovi(logovanUsername, logovanPassword);

            if (trenutnoOdgledan - 1 >= 0)
            {
                trenutnoOdgledan--;
                prikazOdgledanogFilma(trenutnoOdgledan);
            }
            else
                trenutnoOdgledan = 0;
        }

        private void BtnOdgledaniRight_Click(object sender, EventArgs e)
        {
            odgledaniFilmovi.Clear();
            odgledaniFilmovi = DataProvider.GetKorisnikoviOdgledaniFilmovi(logovanUsername, logovanPassword);

            if (odgledaniFilmovi.Count - 1 != trenutnoOdgledan)
            {
                trenutnoOdgledan++;
                prikazOdgledanogFilma(trenutnoOdgledan);
            }
            else
                trenutnoOdgledan = odgledaniFilmovi.Count - 1;
        }

        public void prikazOdgledanogFilma(int trenutnoOdgledan)
        {
            odgledaniFilmovi.Clear();
            odgledaniFilmovi = DataProvider.GetKorisnikoviOdgledaniFilmovi(logovanUsername, logovanPassword);
            labelOdgledaniNaziv.Text = odgledaniFilmovi[trenutnoOdgledan].naziv;
            labelOdgledaniZanr.Text = odgledaniFilmovi[trenutnoOdgledan].zanr;
            labelOdgledaniGodina.Text = odgledaniFilmovi[trenutnoOdgledan].godina;
            labelOdgledaniReziser.Text = odgledaniFilmovi[trenutnoOdgledan].reziser;
            labelOdgledaniOcena.Text = DataProvider.GetOcena(odgledaniFilmovi[trenutnoOdgledan].sifra).ocena.ToString();
            int commasNumber = odgledaniFilmovi[trenutnoOdgledan].glumci.Count(f => f == ',');
            if (commasNumber == 0)
            {
                labelOdgledaniGlumac1.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOdgledaniGlumac2.Text = "";
                labelOdgledaniGlumac3.Text = "";
            }
            else if (commasNumber == 1)
            {
                labelOdgledaniGlumac1.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOdgledaniGlumac2.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                labelOdgledaniGlumac3.Text = "";
            }
            else if (commasNumber == 2)
            {
                labelOdgledaniGlumac1.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                labelOdgledaniGlumac2.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                labelOdgledaniGlumac3.Text = odgledaniFilmovi[trenutnoOdgledan].glumci.Split(new[] { ", " }, StringSplitOptions.None)[2];
            }
        }

        #endregion

        #region Korisnik_Recenzije
        private void ButtonRecenzije_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "recenzije";
            panelFilmoviii.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelFilmovi.Hide();
            panelTop10.Hide();
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

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

            if (recenzijranjeFilma == false)
            {
                panelIzaberiFilmRecenzije.Visible = true;
                panelIzaberiFilmRecenzije.BringToFront();
                panelPrikazRecenzija.Visible = false;

                List<Film> filmovi = DataProvider.GetFilmovi();
                dataGridRecenzije.Rows.Clear();

                string ocena;

                foreach (Film f in filmovi)
                {
                    if (DataProvider.daLiJeFilmOcenjen(f.sifra))
                    {
                        ocena = DataProvider.GetOcena(f.sifra).ocena.ToString("0.00");
                    }
                    else
                    {
                        ocena = "✗";
                    }
                    dataGridRecenzije.Rows.Add(f.sifra, f.zanr, f.godina, f.naziv, ocena, f.reziser, f.glumci);
                }

                dataGridRecenzije.Refresh();
            }
            else
            {
                panelIzaberiFilmRecenzije.Visible = false;
                panelPrikazRecenzija.Visible = true;
                panelPrikazRecenzija.BringToFront();
                recenzijranjeFilma = false;
                panelDodajRecenziju.Visible = false;
                flowLayoutPanelRecenzije.Visible = true;
                flowLayoutPanelRecenzije.BringToFront();
                btnDodajRecenziju.Visible = true;
                panelDodajRecenziju.Visible = false;

                List<Recenzija> recenzijeFilma = DataProvider.GetRecenzijeFilma(sifraFilmaZaRecenziju);
                UserRecenzijaControl[] nizKontrola = new UserRecenzijaControl[recenzijeFilma.Count];

                flowLayoutPanelRecenzije.Controls.Clear();

                for (int i = 0; i < recenzijeFilma.Count; i++)
                {
                    nizKontrola[i] = new UserRecenzijaControl();
                    nizKontrola[i].setTxtAutor(recenzijeFilma[i].username);
                    nizKontrola[i].setTxtDatum(recenzijeFilma[i].datum.ToString());
                    nizKontrola[i].setRichTxt(recenzijeFilma[i].recenzija);
                    flowLayoutPanelRecenzije.Controls.Add(nizKontrola[i]);
                }

            }
        }

        private void DataGridRecenzije_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow d in dataGridRecenzije.Rows)
            {
                d.Selected = false;
            }
            dataGridRecenzije.CurrentRow.Selected = true;

            panelPrikazRecenzija.Visible = true;
            panelPrikazRecenzija.BringToFront();
            panelIzaberiFilmRecenzije.Visible = false;
            flowLayoutPanelRecenzije.Visible = true;
            flowLayoutPanelRecenzije.BringToFront();
            btnDodajRecenziju.Visible = true;
            panelDodajRecenziju.Visible = false;

            List<Recenzija> recenzijeFilma = DataProvider.GetRecenzijeFilma(dataGridRecenzije.CurrentRow.Cells[0].Value.ToString());
            sifraFilmaZaRecenziju = dataGridRecenzije.CurrentRow.Cells[0].Value.ToString();
            UserRecenzijaControl[] nizKontrola = new UserRecenzijaControl[recenzijeFilma.Count];

            flowLayoutPanelRecenzije.Controls.Clear();

            for (int i = 0; i < recenzijeFilma.Count; i++)
            {
                nizKontrola[i] = new UserRecenzijaControl();
                nizKontrola[i].setTxtAutor(recenzijeFilma[i].username);
                nizKontrola[i].setTxtDatum(recenzijeFilma[i].datum.ToString());
                nizKontrola[i].setRichTxt(recenzijeFilma[i].recenzija);
                flowLayoutPanelRecenzije.Controls.Add(nizKontrola[i]);
            }
        }

        private void BtnDodajRecenziju_Click_1(object sender, EventArgs e)
        {
            btnDodajRecenziju.Visible = false;
            panelDodajRecenziju.Visible = true;
            panelDodajRecenziju.BringToFront();
            flowLayoutPanelRecenzije.Visible = false;

            recenzControl.setTxtAutor(logovanUsername);
            recenzControl.setTxtDatum(DateTime.Now.ToString(@"yyyy-MM-dd"));
            recenzControl.setRichTxt("");
        }
        private void BtnDodajNapisanuRecenziju_Click_1(object sender, EventArgs e)
        {
            panelDodajRecenziju.Visible = false;
            flowLayoutPanelRecenzije.Visible = true;
            flowLayoutPanelRecenzije.BringToFront();
            panelPrikazRecenzija.Visible = true;
            panelIzaberiFilmRecenzije.Visible = false;
            btnDodajRecenziju.Visible = true;

            Recenzija recenzija = new Recenzija();
            recenzija.sifraFilma = sifraFilmaZaRecenziju;
            recenzija.username = logovanUsername;
            recenzija.recenzija = recenzControl.getRecenzija();
            string datum = recenzControl.getDatum();
            DataProvider.dodajRecenziju(recenzija, datum);

            List<Recenzija> recenzijeFilma = DataProvider.GetRecenzijeFilma(recenzija.sifraFilma);

            UserRecenzijaControl[] nizKontrola = new UserRecenzijaControl[recenzijeFilma.Count];

            flowLayoutPanelRecenzije.Controls.Clear();

            for (int i = 0; i < recenzijeFilma.Count; i++)
            {
                nizKontrola[i] = new UserRecenzijaControl();
                nizKontrola[i].setTxtAutor(recenzijeFilma[i].username);
                nizKontrola[i].setTxtDatum(recenzijeFilma[i].datum.ToString());
                nizKontrola[i].setRichTxt(recenzijeFilma[i].recenzija);
                flowLayoutPanelRecenzije.Controls.Add(nizKontrola[i]);
            }
        }

        #endregion

        #region Korisnik_Top10
        private void ButtonTop10_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "top10";
            panelFilmoviii.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelFilmovi.Hide();
            this.panelRecenzije.Hide();
            this.panelTop10.Show();


            if (SlideMenu.Width == 50)
            {
                if (slajdTop10 == "prosiren")
                {
                    this.panelTop10.Location = new Point(this.panelTop10.Location.X - 100, this.panelTop10.Location.Y);
                    slajdTop10 = "uvucen";

                }
            }
            else
            {
                if (slajdTop10 == "uvucen")
                {
                    this.panelTop10.Location = new Point(this.panelTop10.Location.X + 100, this.panelTop10.Location.Y);
                    slajdTop10 = "prosiren";

                }
            }


            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonTop10.Location.Y);
            dataGridTop10.Visible = false;
            paneltop10Naj.Visible = true;
        }

        private void BtnNajvisePregleda_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();
            Dictionary<string, int> dicPregledi = new Dictionary<string, int>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                dic.Add(f.sifra, f);
                int brojacPregleda = 0;
                if (f.naziv.Contains('\''))  //u slucaju da se u nazivu filma nadje apostrof
                    f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);
                foreach (Korisnik k in DataProvider.GetKorisnici())
                {
                    if (DataProvider.daLiJeKorisnikOdgledaoFilm(k, f))
                    {
                        brojacPregleda++;
                    }
                }
                dicPregledi.Add(f.sifra, brojacPregleda);
            }

            var ordered = dicPregledi.OrderByDescending(x => x.Value);
            var backToDictionary = ordered.ToDictionary(r => r.Key, r => r.Value);

            dataGridTop10.Columns[3].HeaderText = "Pregledi";
            dataGridTop10.Rows.Clear();
            int top10 = 0;
            foreach (KeyValuePair<string, int> element in backToDictionary)
            {
                if (top10 == 10)
                    break;
                Film f = dic[element.Key];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, element.Value);
                top10++;
            }
            dataGridTop10.Refresh();
        }

        private void BtnNajviseKritika_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();
            Dictionary<string, int> dicKritike = new Dictionary<string, int>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                dic.Add(f.sifra, f);
                dicKritike.Add(f.sifra, DataProvider.GetBrojNePreporuka(f.sifra));
            }

            var ordered = dicKritike.OrderByDescending(x => x.Value);
            var backToDictionary = ordered.ToDictionary(r => r.Key, r => r.Value);

            dataGridTop10.Columns[3].HeaderText = "Broj kritika";
            dataGridTop10.Rows.Clear();
            int top10 = 0;
            foreach (KeyValuePair<string, int> element in backToDictionary)
            {
                if (top10 == 10)
                    break;
                Film f = dic[element.Key];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, element.Value);
                top10++;
            }
            dataGridTop10.Refresh();
        }

        private void BtnNajOmiljeniji_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();
            Dictionary<string, int> dicOmiljeni = new Dictionary<string, int>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                dic.Add(f.sifra, f);
                int brojacPregleda = 0;
                if (f.naziv.Contains('\''))  //u slucaju da se u nazivu filma nadje apostrof
                    f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);
                foreach (Korisnik k in DataProvider.GetKorisnici())
                {
                    if (DataProvider.daLiJeToKorisnikovOmiljeniFilm(k, f))
                    {
                        brojacPregleda++;
                    }
                }

                dicOmiljeni.Add(f.sifra, brojacPregleda);
            }

            var ordered = dicOmiljeni.OrderByDescending(x => x.Value);

            var backToDictionary = ordered.ToDictionary(r => r.Key, r => r.Value);

            dataGridTop10.Columns[3].HeaderText = "U listi omiljenih";
            dataGridTop10.Rows.Clear();

            int top10 = 0;
            foreach (KeyValuePair<string, int> element in backToDictionary)
            {
                if (top10 == 10)
                    break;
                Film f = dic[element.Key];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, element.Value);
                top10++;
            }
            dataGridTop10.Refresh();
        }

        private void BtnNajvisePreporuka_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();
            Dictionary<string, int> dicPreporuke = new Dictionary<string, int>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                dic.Add(f.sifra, f);
                dicPreporuke.Add(f.sifra, DataProvider.GetBrojPreporuka(f.sifra));
            }

            var ordered = dicPreporuke.OrderByDescending(x => x.Value);
            var backToDictionary = ordered.ToDictionary(r => r.Key, r => r.Value);

            dataGridTop10.Columns[3].HeaderText = "Broj preporuka";
            dataGridTop10.Rows.Clear();
            int top10 = 0;
            foreach (KeyValuePair<string, int> element in backToDictionary)
            {
                if (top10 == 10)
                    break;
                Film f = dic[element.Key];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, element.Value);
                top10++;
            }
            dataGridTop10.Refresh();
        }

        private void BtnNajviseRecenzija_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();
            Dictionary<string, int> dicRecenzije = new Dictionary<string, int>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                dic.Add(f.sifra, f);
                dicRecenzije.Add(f.sifra, DataProvider.GetRecenzijeFilma(f.sifra).Count);
            }

            var ordered = dicRecenzije.OrderByDescending(x => x.Value);
            var backToDictionary = ordered.ToDictionary(r => r.Key, r => r.Value);

            dataGridTop10.Columns[3].HeaderText = "Recenzije";
            dataGridTop10.Rows.Clear();
            int top10 = 0;
            foreach (KeyValuePair<string, int> element in backToDictionary)
            {
                if (top10 == 10)
                    break;
                Film f = dic[element.Key];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, element.Value);
                top10++;
            }
            dataGridTop10.Refresh();
        }

        private void BtnNajboljeOcenjeni_Click_1(object sender, EventArgs e)
        {
            paneltop10Naj.Visible = false;
            dataGridTop10.Visible = true;
            dataGridTop10.BringToFront();
            List<Ocena> lista = new List<Ocena>();
            Dictionary<string, Film> dic = new Dictionary<string, Film>();

            foreach (Film f in DataProvider.GetFilmovi())
            {
                lista.Add(DataProvider.GetOcena(f.sifra));
                dic.Add(f.sifra, f);
            }
            List<Ocena> SortedList = lista.OrderByDescending(o => o.ocena).ToList();

            dataGridTop10.Columns[3].HeaderText = "Ocena";
            dataGridTop10.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                Film f = dic[SortedList[i].sifraFilma];
                dataGridTop10.Rows.Add(f.naziv, f.zanr, f.godina, SortedList[i].ocena);
            }
            dataGridTop10.Refresh();
        }

        #endregion
    }
}
