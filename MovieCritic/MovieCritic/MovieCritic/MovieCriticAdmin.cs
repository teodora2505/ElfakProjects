
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


namespace MovieCritic
{
    public partial class MovieCriticAdmin : Form
    {
        #region Promenljive

        public string logovanUsername;
        public string logovanPassword;
        public string trenutnaOpcija = "nalozi";
        public bool slideMenuExpanded = true;
        public string slajdUpravljanjeNalozima = "prosiren";
        public string slajdFilmovi = "prosiren";
        public string slajdOcene = "prosiren";
        public string slajdOmiljeniFilmovi = "prosiren";
        public string slajdOdgledaniFilmovi = "prosiren";
        public string slajdRecenzije = "prosiren";
        public Film selektovaniFilm = null;
        int sec_counter = 0;

        #endregion

        public MovieCriticAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelUpravljanjeNalozima.Visible = true;
            this.panelFilmovi.Visible = false;
            this.panelOmiljeniFilmovi.Visible = false;
            this.panelOcene.Visible = false;
            this.panelOdgledaniFilmovi.Visible = false;
            this.panelRecenzije.Visible = false;
            this.labelWarning.Visible = false;

            Korisnik k = DataProvider.GetKorisnik(logovanUsername, logovanPassword);
            labelKorisnik.Text = k.ime + " " + k.prezime;

            gbxUpravljanjeDodavanje.Visible = false;
            gbxUpravljanjeCitanje.Visible = false;
            gbxUpravljanjeAzuriranje.Visible = false;
            gbxUpravljanjeBrisanje.Visible = false;
            dataGridKorisnici.Visible = false;

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeNalozima.Location.Y);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideMenuExpanded = !slideMenuExpanded;
            if (SlideMenu.Width == 50)//kad je slideMenu uvucen
            {

                SlideMenu.Visible = false;
                SlideMenu.Width = 200;
                PanelAnimator.ShowSync(SlideMenu);
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOcene.Location.Y);

                if (trenutnaOpcija == "nalozi")
                {

                    slajdUpravljanjeNalozima = "prosiren";
                    panelUpravljanjeNalozima.Show();
                    panelFilmovi.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelUpravljanjeNalozima.Location = new Point(this.panelUpravljanjeNalozima.Location.X + 100, this.panelUpravljanjeNalozima.Location.Y);
                    PanelAnimator2.ShowSync(panelUpravljanjeNalozima);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeNalozima.Location.Y);
                }
                else if (trenutnaOpcija == "filmovi")
                {

                    slajdFilmovi = "prosiren";
                    panelFilmovi.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X + 100, this.panelFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "ocene")
                {

                    slajdOcene = "prosiren";
                    panelOcene.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelFilmovi.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOcene.Location = new Point(this.panelOcene.Location.X + 100, this.panelOcene.Location.Y);
                    PanelAnimator2.ShowSync(panelOcene);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOcene.Location.Y);
                }
                else if (trenutnaOpcija == "omiljeniFilmovi")
                {

                    slajdOmiljeniFilmovi = "prosiren";
                    panelOmiljeniFilmovi.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelFilmovi.Hide();
                    panelOcene.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X + 100, this.panelOmiljeniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "odgledaniFilmovi")
                {

                    slajdOdgledaniFilmovi = "prosiren";
                    panelOdgledaniFilmovi.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X + 100, this.panelOdgledaniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOdgledaniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOdgledaniFilmovi.Location.Y);

                }
                else if (trenutnaOpcija == "recenzije")
                {

                    slajdRecenzije = "prosiren";
                    panelRecenzije.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelOdgledaniFilmovi.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    if (buttonRecenzije.selected == true)
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);
                    else
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreporuke.Location.Y);
                }

                LogoAnimator.ShowSync(Logo);
            }
            else//kad je slideMenu prosiren
            {

                LogoAnimator.Hide(Logo);
                SlideMenu.Visible = false;
                SlideMenu.Width = 50;
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOcene.Location.Y);

                if (trenutnaOpcija == "nalozi")
                {

                    slajdUpravljanjeNalozima = "uvucen";
                    panelUpravljanjeNalozima.Show();
                    panelFilmovi.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelUpravljanjeNalozima.Location = new Point(this.panelUpravljanjeNalozima.Location.X - 100, this.panelUpravljanjeNalozima.Location.Y);
                    PanelAnimator2.ShowSync(panelUpravljanjeNalozima);

                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeNalozima.Location.Y);
                }
                else if (trenutnaOpcija == "filmovi")
                {

                    slajdFilmovi = "uvucen";
                    panelFilmovi.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelFilmovi.Location = new Point(this.panelFilmovi.Location.X - 100, this.panelFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "ocene")
                {

                    slajdOcene = "uvucen";
                    panelOcene.Show();
                    panelFilmovi.Hide();
                    panelUpravljanjeNalozima.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOcene.Location = new Point(this.panelOcene.Location.X - 100, this.panelOcene.Location.Y);
                    PanelAnimator2.ShowSync(panelOcene);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOcene.Location.Y);
                }
                else if (trenutnaOpcija == "omiljeniFilmovi")
                {

                    slajdOmiljeniFilmovi = "uvucen";
                    panelOmiljeniFilmovi.Show();
                    panelFilmovi.Hide();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOdgledaniFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X - 100, this.panelOmiljeniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "odgledaniFilmovi")
                {

                    slajdOdgledaniFilmovi = "uvucen";
                    panelOdgledaniFilmovi.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelRecenzije.Hide();
                    this.panelOdgledaniFilmovi.Location = new Point(this.panelOdgledaniFilmovi.Location.X - 100, this.panelOdgledaniFilmovi.Location.Y);
                    PanelAnimator2.ShowSync(panelOdgledaniFilmovi);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOdgledaniFilmovi.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {

                    slajdRecenzije = "prosiren";
                    slajdRecenzije = "uvucen";
                    panelRecenzije.Show();
                    panelUpravljanjeNalozima.Hide();
                    panelOcene.Hide();
                    panelOmiljeniFilmovi.Hide();
                    panelFilmovi.Hide();
                    panelRecenzije.Hide();
                    panelOdgledaniFilmovi.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    if (buttonRecenzije.selected == true)
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);
                    else
                        labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreporuke.Location.Y);
                }

                PanelAnimator.ShowSync(SlideMenu);
            }
        }

        #region PomocneFunkcije
        private void bunifuImageButton2_Click(object sender, EventArgs e)// Dugme X za zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Dugme za minimizaciju forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        #endregion

        #region Administrator_Upravljanje_Nalozima

        private void ButtonUpravljanjeNalozima_Click(object sender, EventArgs e)
        {
            if (SlideMenu.Width == 50)
            {
                if (slajdUpravljanjeNalozima == "prosiren")
                {
                    this.panelUpravljanjeNalozima.Location = new Point(this.panelUpravljanjeNalozima.Location.X - 100, this.panelUpravljanjeNalozima.Location.Y);
                    slajdUpravljanjeNalozima = "uvucen";
                }
            }
            else
            {
                if (slajdUpravljanjeNalozima == "uvucen")
                {
                    this.panelUpravljanjeNalozima.Location = new Point(this.panelUpravljanjeNalozima.Location.X + 100, this.panelUpravljanjeNalozima.Location.Y);
                    slajdUpravljanjeNalozima = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeNalozima.Location.Y);

            trenutnaOpcija = "nalozi";
            panelFilmovi.Hide();
            panelOcene.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelRecenzije.Hide();
            panelUpravljanjeNalozima.Show();
        }

        #region Create
        private void BtnUpravljanjeCreate_Click(object sender, EventArgs e)
        {
            gbxUpravljanjeDodavanje.Visible = true;
            gbxUpravljanjeDodavanje.BringToFront();
            gbxUpravljanjeCitanje.Visible = false;
            gbxUpravljanjeAzuriranje.Visible = false;
            gbxUpravljanjeBrisanje.Visible = false;
            dataGridKorisnici.Visible = false;

            txtUpravljanjeDodajIme.Text = string.Empty;
            txtUpravljanjeDodajPrezime.Text = string.Empty;
            txtUpravljanjeDodajUsername.Text = string.Empty;
            txtUpravljanjeDodajMail.Text = string.Empty;
            txtUpravljanjeDodajPassword.Text = string.Empty;
            rdbUpravljanjeDodajKorisnik.Checked = true;

        }

        private void BtnUpravljanjeDodaj_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.ime = txtUpravljanjeDodajIme.Text;
            korisnik.prezime = txtUpravljanjeDodajPrezime.Text;
            korisnik.username = txtUpravljanjeDodajUsername.Text;
            korisnik.password = txtUpravljanjeDodajPassword.Text;
            korisnik.mail = txtUpravljanjeDodajMail.Text;

            if (rdbUpravljanjeDodajAdmin.Checked)
                korisnik.admin = "da";
            else if(rdbUpravljanjeDodajKorisnik.Checked)
                korisnik.admin = "ne";

            if (!string.IsNullOrEmpty(korisnik.ime)
                && !string.IsNullOrEmpty(korisnik.prezime)
                && !string.IsNullOrEmpty(korisnik.username)
                && !string.IsNullOrEmpty(korisnik.password)
                && !string.IsNullOrEmpty(korisnik.mail)
                && IsValidEmail(korisnik.mail)
                && !DataProvider.daLiPostojiUsernamePassword(korisnik.username, korisnik.password))
            {
                DataProvider.dodajKorisnika(korisnik);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje.";
                txtUpravljanjeDodajIme.Text = string.Empty;
                txtUpravljanjeDodajPrezime.Text = string.Empty;
                txtUpravljanjeDodajUsername.Text = string.Empty;
                txtUpravljanjeDodajMail.Text = string.Empty;
                txtUpravljanjeDodajPassword.Text = string.Empty;
                rdbUpravljanjeDodajKorisnik.Checked = true;
                sec_counter = 0;
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Read
        private void BtnUpravljanjeRead_Click(object sender, EventArgs e)
        {
            gbxUpravljanjeCitanje.Visible = true;
            gbxUpravljanjeCitanje.BringToFront();
            gbxUpravljanjeDodavanje.Visible = false;
            gbxUpravljanjeAzuriranje.Visible = false;
            gbxUpravljanjeBrisanje.Visible = false;
            dataGridKorisnici.Visible = false;

            labelUpravljanjeCitanjeIme.Text = string.Empty;
            labelUpravljanjeCitanjePrezime.Text = string.Empty;
            labelUpravljanjeCitanjeMail.Text = string.Empty;
            labelUpravljanjeCitanjeNalog.Text = string.Empty;
        }

        private void BtnUpravljanjePrikazi_Click(object sender, EventArgs e)
        {
            String username = txtUpravljanjeCitanjeUsername.Text;
            String password = txtUpravljanjeCitanjePassword.Text;

            Korisnik korisnik = DataProvider.GetKorisnik(username, password);
            if(korisnik.username!=null)
            {
                labelUpravljanjeCitanjeIme.Text = korisnik.ime;
                labelUpravljanjeCitanjePrezime.Text = korisnik.prezime;
                labelUpravljanjeCitanjeMail.Text = korisnik.mail;
                if (korisnik.admin == "da")
                    labelUpravljanjeCitanjeNalog.Text = "administrator";
                else
                    labelUpravljanjeCitanjeNalog.Text = "korisnik";
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
         
        }

        #endregion

        #region Update
        private void BtnUpravljanjeUpdate_Click(object sender, EventArgs e)
        {
            gbxUpravljanjeAzuriranje.Visible = true;
            gbxUpravljanjeAzuriranje.BringToFront();
            gbxUpravljanjeDodavanje.Visible = false;
            gbxUpravljanjeCitanje.Visible = false;
            gbxUpravljanjeBrisanje.Visible = false;
            panelUpravljanjeAzuriranjePrikaz.Visible = false;
            dataGridKorisnici.Visible = false;

            txtUpravljanjeAzurirajUsername.Text = string.Empty;
            txtUpravljanjeAzurirajPassword.Text = string.Empty;
            txtUpravljanjeNovoIme.Text = string.Empty;
            txtUpravljanjeNovoPrezime.Text = string.Empty;
            txtUpravljanjeNovoUsername.Text = string.Empty;
            txtUpravljanjeNovoPassword.Text = string.Empty;
            txtUpravljanjeNovoMail.Text = string.Empty;
            rdbUpravljanjeNovoKorisnik.Checked = true;
        }

        private void TxtUpravljanjeAzurirajUsername_OnValueChanged(object sender, EventArgs e)
        {
            string username = txtUpravljanjeAzurirajUsername.Text;
            string password = txtUpravljanjeAzurirajPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (DataProvider.daLiPostojiUsernamePassword(username, password))
                {
                    panelUpravljanjeAzuriranjePrikaz.Visible = true;
                    Korisnik k = DataProvider.GetKorisnik(username, password);
                    txtUpravljanjeNovoIme.Text = k.ime;
                    txtUpravljanjeNovoPrezime.Text = k.prezime;
                    txtUpravljanjeNovoUsername.Text = k.username;
                    txtUpravljanjeNovoPassword.Text = k.password;
                    txtUpravljanjeNovoMail.Text = k.mail;
                    if (k.admin == "da")
                        rdbUpravljanjeNovoAdmin.Checked = true;
                    else if (k.admin == "ne")
                        rdbUpravljanjeNovoKorisnik.Checked = true;
                }
            }
            else
            {
                txtUpravljanjeNovoIme.Text = string.Empty;
                txtUpravljanjeNovoPrezime.Text = string.Empty;
                txtUpravljanjeNovoUsername.Text = string.Empty;
                txtUpravljanjeNovoPassword.Text = string.Empty;
                txtUpravljanjeNovoMail.Text = string.Empty;
                rdbUpravljanjeNovoKorisnik.Checked = true;
            }
        }

        private void BtnUpravljanjeAzuriraj_Click(object sender, EventArgs e)
        {
            string staroUsername = txtUpravljanjeAzurirajUsername.Text;
            string staroPassword = txtUpravljanjeAzurirajPassword.Text;

            if (DataProvider.daLiPostojiUsernamePassword(staroUsername, staroPassword))
            {
                Korisnik korisnik = new Korisnik();
                korisnik.username = txtUpravljanjeNovoUsername.Text;
                korisnik.password = txtUpravljanjeNovoPassword.Text;
                korisnik.ime = txtUpravljanjeNovoIme.Text;
                korisnik.prezime = txtUpravljanjeNovoPrezime.Text;
                korisnik.mail = txtUpravljanjeNovoMail.Text;

                if (rdbUpravljanjeNovoAdmin.Checked)
                    korisnik.admin = "da";
                else if (rdbUpravljanjeNovoKorisnik.Checked)
                    korisnik.admin = "ne";

                DataProvider.UpdateKorisnik(korisnik, staroUsername, staroPassword);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno ažuriranje.";
                timerWarning.Start();
                this.BtnUpravljanjeUpdate_Click(sender, e);

            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        #endregion

        #region Delete
        private void BtnUpravljanjeDelete_Click(object sender, EventArgs e)
        {
            gbxUpravljanjeBrisanje.Visible = true;
            gbxUpravljanjeBrisanje.BringToFront();
            gbxUpravljanjeDodavanje.Visible = false;
            gbxUpravljanjeCitanje.Visible = false;
            gbxUpravljanjeAzuriranje.Visible = false;
            dataGridKorisnici.Visible = false;

            txtUpravljanjeBrisanjeUsername.Text = string.Empty;
            txtUpravljanjeBrisanjePassword.Text = string.Empty;
        }

        private void BtnUpravljanjeBrisi_Click(object sender, EventArgs e)
        {
            string username = txtUpravljanjeBrisanjeUsername.Text;
            string password = txtUpravljanjeBrisanjePassword.Text;

            if(DataProvider.daLiPostojiUsernamePassword(username,password))
            {
                DataProvider.DeleteKorisnik(username, password);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno uklanjanje.";
                timerWarning.Start();
                txtUpravljanjeBrisanjeUsername.Text = string.Empty;
                txtUpravljanjeBrisanjePassword.Text = string.Empty;
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        #endregion

        private void BtnUpravljanjeSearch_Click(object sender, EventArgs e)
        {
            gbxUpravljanjeBrisanje.Visible = false;
            gbxUpravljanjeDodavanje.Visible = false;
            gbxUpravljanjeCitanje.Visible = false;
            gbxUpravljanjeAzuriranje.Visible = false;
            dataGridKorisnici.Visible = true;
            dataGridKorisnici.BringToFront();

            List<Korisnik> korisnici = DataProvider.GetKorisnici();
            dataGridKorisnici.Rows.Clear();

            foreach (Korisnik k in korisnici)
            {
                dataGridKorisnici.Rows.Add(k.ime, k.prezime, k.mail, k.admin, k.username,k.password);
            }

            dataGridKorisnici.Refresh();
        }

        #endregion

        #region Administrator_Upravljanje_Filmovima
        private void BtnFilmCreate_Click(object sender, EventArgs e)
        {
            gbxFilmDodavanje.Visible = true;
            gbxFilmDodavanje.BringToFront();
            gbxAzuriranjeFilma.Visible = false;
            dataGridFilmovi.Visible = false;
            txtFilmDodajGlumac1.Text = string.Empty;
            txtFilmDodajGlumac2.Text = string.Empty;
            txtFilmDodajGlumac3.Text = string.Empty;
            numericFilmDodajGodina.Value = 2019;
            cbxFilmDodajZanr.selectedIndex = -1;
            txtFilmDodajsifra.Text = string.Empty;
            txtFilmDodajNaziv.Text = string.Empty;
            txtFilmDodajRezisera.Text = string.Empty;
        }

        private void ButtonFilmovi_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "filmovi";
            panelUpravljanjeNalozima.Hide();
            panelOcene.Hide();
            panelOmiljeniFilmovi.Hide();
            this.panelOdgledaniFilmovi.Hide();
            this.panelRecenzije.Hide();
            panelFilmovi.Show();

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

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonFilmovi.Location.Y);

            dataGridFilmovi.BringToFront();
            dataGridFilmovi.Visible = true;
            gbxFilmDodavanje.Visible = false;
            gbxAzuriranjeFilma.Visible = false;

            List<Film> filmovi = DataProvider.GetFilmovi();
            dataGridFilmovi.Rows.Clear();

            foreach (Film f in filmovi)
            {
                dataGridFilmovi.Rows.Add(f.sifra, f.zanr, f.godina, f.naziv, f.reziser, f.glumci);
            }

            dataGridFilmovi.Refresh();
            panelSelektuj.Visible = true;
            panelSelektuj.BringToFront();

        }

        private void BtnFilmDodaj_Click(object sender, EventArgs e)
        {
            string sifra = txtFilmDodajsifra.Text;
            string naziv = txtFilmDodajNaziv.Text;
            string reziser = txtFilmDodajRezisera.Text;
            string godina = numericFilmDodajGodina.Value.ToString();
            string glumac1 = txtFilmDodajGlumac1.Text;
            string glumac2 = txtFilmDodajGlumac2.Text;
            string glumac3 = txtFilmDodajGlumac3.Text;
            string[] niz = new string[8]{ "drama", "horor", "fantastika", "krimi", "akcioni", "triler", "komedija", "romantika" };
            string zanr = niz[cbxFilmDodajZanr.selectedIndex];

            if (!string.IsNullOrEmpty(sifra) && !string.IsNullOrEmpty(naziv) && !string.IsNullOrEmpty(reziser) && !string.IsNullOrEmpty(godina)
                && !string.IsNullOrEmpty(zanr) && !string.IsNullOrEmpty(glumac1) && cbxFilmDodajZanr.selectedIndex>-1)
            {
                Film f = new Film();
                f.sifra = sifra;
                f.naziv = naziv;
                f.reziser = reziser;
                f.godina = godina;
                f.zanr = zanr;

                if(f.naziv.Contains('\''))  //u slucaju da se u nazivu filma nadje apostrof
                {
                    string[] nizStringova=f.naziv.Split('\'');
                    string rezultat = null;
                    for (int i = 0; i < nizStringova.Length - 1; i++)
                    {
                        rezultat += nizStringova[i] + "\'\'";
                    }
                    rezultat += nizStringova[nizStringova.Length - 1];
                    f.naziv = rezultat;
                }

                if (!string.IsNullOrEmpty(glumac3) && !string.IsNullOrEmpty(glumac2))
                {
                    f.glumci = glumac1 + ", " + glumac2 + ", " + glumac3;
                }
                else if(string.IsNullOrEmpty(glumac3) && !string.IsNullOrEmpty(glumac2))
                {
                    f.glumci = glumac1 + ", " + glumac2;
                }
                else if(!string.IsNullOrEmpty(glumac3) && string.IsNullOrEmpty(glumac2))
                {
                    f.glumci = glumac1 + ", " + glumac3;
                }
                else if(string.IsNullOrEmpty(glumac2))
                {
                    f.glumci = glumac1;
                }

                DataProvider.dodajFilm(f);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje.";
                txtFilmDodajGlumac1.Text = string.Empty;
                txtFilmDodajGlumac2.Text = string.Empty;
                txtFilmDodajGlumac3.Text = string.Empty;
                numericFilmDodajGodina.Value = 2019;
                cbxFilmDodajZanr.selectedIndex = -1;
                cbxFilmDodajZanr.ResetText();
                txtFilmDodajsifra.Text = string.Empty;
                txtFilmDodajNaziv.Text = string.Empty;
                txtFilmDodajRezisera.Text = string.Empty;
                ButtonFilmovi_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo.";
                timerWarning.Start();
            }
        }

        private void DataGridFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow d in dataGridFilmovi.Rows)
            {
                d.Selected = false;
            }
            dataGridFilmovi.CurrentRow.Selected = true;

            selektovaniFilm = new Film();
            selektovaniFilm.sifra = dataGridFilmovi.CurrentRow.Cells[0].Value.ToString();
            selektovaniFilm.zanr = dataGridFilmovi.CurrentRow.Cells[1].Value.ToString();
            selektovaniFilm.godina = dataGridFilmovi.CurrentRow.Cells[2].Value.ToString();
            selektovaniFilm.naziv = dataGridFilmovi.CurrentRow.Cells[3].Value.ToString();
            selektovaniFilm.reziser = dataGridFilmovi.CurrentRow.Cells[4].Value.ToString();
            selektovaniFilm.glumci = dataGridFilmovi.CurrentRow.Cells[5].Value.ToString();

            if (selektovaniFilm != null)
            {
                panelSelektuj.Visible = false;
                gbxAzuriranjeFilma.Visible = true;
                gbxAzuriranjeFilma.BringToFront();
                txtAzurirajFilmNovaSifra.Text = selektovaniFilm.sifra;
                txtAzurirajFilmNovNaziv.Text = selektovaniFilm.naziv;
                txtAzurirajFilmNovReziser.Text = selektovaniFilm.reziser;
                int commasNumber = selektovaniFilm.glumci.Count(f => f == ',');
                if (commasNumber == 0)
                {
                    txtAzurirajFilmNovGlumac1.Text = selektovaniFilm.glumci;
                }
                else if (commasNumber == 1)
                {
                    txtAzurirajFilmNovGlumac1.Text = selektovaniFilm.glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                    txtAzurirajFilmNovGlumac2.Text = selektovaniFilm.glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                }
                else if (commasNumber == 2)
                {
                    txtAzurirajFilmNovGlumac1.Text = selektovaniFilm.glumci.Split(new[] { ", " }, StringSplitOptions.None)[0];
                    txtAzurirajFilmNovGlumac2.Text = selektovaniFilm.glumci.Split(new[] { ", " }, StringSplitOptions.None)[1];
                    txtAzurirajFilmNovGlumac3.Text = selektovaniFilm.glumci.Split(new[] { ", " }, StringSplitOptions.None)[2];
                }
                txtAzurirajFilmNovaGodina.Value = Convert.ToInt32(selektovaniFilm.godina);
                int indeks = -1;
                if (selektovaniFilm.zanr == "drama")
                    indeks = 0;
                else if (selektovaniFilm.zanr == "horor")
                    indeks = 1;
                else if (selektovaniFilm.zanr == "fantastika")
                    indeks = 2;
                else if (selektovaniFilm.zanr == "krimi")
                    indeks = 3;
                else if (selektovaniFilm.zanr == "akcioni")
                    indeks = 4;
                else if (selektovaniFilm.zanr == "filter")
                    indeks = 5;
                else if (selektovaniFilm.zanr == "komedija")
                    indeks = 6;
                else if (selektovaniFilm.zanr == "romantika")
                    indeks = 7;
                cbxAzurirajFilmNovZanr.selectedIndex = indeks;
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Potrebno je selektovati film.";
                timerWarning.Start();
            }
        }

        private void BtnFilmSearch_Click(object sender, EventArgs e)
        {
            gbxFilmDodavanje.Visible = false;
            dataGridFilmovi.Visible = true;
            dataGridFilmovi.BringToFront();
        }

        private void BtnAzurirajFilm_Click(object sender, EventArgs e)
        {
            Film novi = new Film();
            novi.naziv = txtAzurirajFilmNovNaziv.Text;
            novi.reziser = txtAzurirajFilmNovReziser.Text;
            novi.sifra = txtAzurirajFilmNovaSifra.Text;
            novi.godina = txtAzurirajFilmNovaGodina.Value.ToString();
            string[] niz = new string[8] { "drama", "horor", "fantastika", "krimi", "akcioni", "triler", "komedija", "romantika" };
            novi.zanr = niz[cbxAzurirajFilmNovZanr.selectedIndex];
            if (!string.IsNullOrEmpty(txtAzurirajFilmNovGlumac1.Text) && !string.IsNullOrEmpty(txtAzurirajFilmNovGlumac2.Text) && !string.IsNullOrEmpty(labelica.Text))
            {
                novi.glumci = txtAzurirajFilmNovGlumac1.Text + ", " + txtAzurirajFilmNovGlumac2.Text + ", " + txtAzurirajFilmNovGlumac3.Text;
            }
            else if (!string.IsNullOrEmpty(txtAzurirajFilmNovGlumac1.Text) && !string.IsNullOrEmpty(txtAzurirajFilmNovGlumac2.Text))
            {
                novi.glumci = txtAzurirajFilmNovGlumac1.Text + ", " + txtAzurirajFilmNovGlumac2.Text;
            }
            else if (!string.IsNullOrEmpty(txtAzurirajFilmNovGlumac1.Text) && !string.IsNullOrEmpty(txtAzurirajFilmNovGlumac3.Text))
            {
                novi.glumci = txtAzurirajFilmNovGlumac1.Text + ", " + txtAzurirajFilmNovGlumac3.Text;
            }
            else if (!string.IsNullOrEmpty(txtAzurirajFilmNovGlumac1.Text))
            {
                novi.glumci = txtAzurirajFilmNovGlumac1.Text;
            }

            if (selektovaniFilm!=null && !string.IsNullOrEmpty(novi.naziv) && !string.IsNullOrEmpty(novi.sifra) && !string.IsNullOrEmpty(novi.reziser)
                && !string.IsNullOrEmpty(novi.glumci) && !string.IsNullOrEmpty(novi.godina) && !string.IsNullOrEmpty(novi.zanr))
            {
                DataProvider.UpdateFilm(selektovaniFilm, novi);
                DataProvider.UpdateFilmReziserGlumci(selektovaniFilm.sifra, novi);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno ažuriranje.";
                selektovaniFilm = null;
                ButtonFilmovi_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Potrebno je selektovati film.";
                timerWarning.Start();
            }
        }

        private void BtnFilmObrisi_Click(object sender, EventArgs e)
        {
            if (selektovaniFilm != null)
            {
                DataProvider.DeleteFilmReziserGlumci(selektovaniFilm.sifra);
                DataProvider.DeleteFilm(selektovaniFilm.zanr, selektovaniFilm.naziv, selektovaniFilm.godina);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno uklanjanje.";
                selektovaniFilm = null;
                ButtonFilmovi_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Potrebno je selektovati film.";
                timerWarning.Start();
            }

        }

        #endregion

        #region Administrator_Upravljanje_Ocenama

        private void BtnDodajOcenu_Click(object sender, EventArgs e)
        {
            Ocena o = new Ocena();
            o.sifraFilma = txtDodajOcenuSifra.Text;
            o.username = txtDodajOcenuUsername.Text;
            o.password = txtDodajOcenuPassword.Text;
            o.ocena = Convert.ToInt32(numericUpDownOcena.Value);

            if(!DataProvider.daLiJeKorisnikVecOcenioFilm(o.sifraFilma,o.username,o.password)
                && DataProvider.daLiPostojiUsernamePassword(o.username,o.password))
            {
                DataProvider.dodajOcenu(o);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Ocena dodata.";
                txtDodajOcenuSifra.Text = string.Empty;
                txtDodajOcenuUsername.Text = string.Empty;
                txtDodajOcenuPassword.Text = string.Empty;
                numericUpDownOcena.Value = 0;
                ButtonOcene_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        private void DataGridOcene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxOcenaAzurirajUkloni.Visible = true;
            txtAzurirajOcenaSifra.Text = dataGridOcene.CurrentRow.Cells[0].Value.ToString();
            txtAzurirajOcenaUsername.Text = dataGridOcene.CurrentRow.Cells[1].Value.ToString();
            txtAzurirajOcenaPassword.Text = dataGridOcene.CurrentRow.Cells[2].Value.ToString();
            numericUpDownAzurirajOcena.Value = Convert.ToInt32(dataGridOcene.CurrentRow.Cells[3].Value.ToString());
            txtAzurirajOcenaSifra.Enabled = false;
            txtAzurirajOcenaUsername.Enabled = false;
            txtAzurirajOcenaPassword.Enabled = false;
        }

        private void BtnAzurirajOcena_Click(object sender, EventArgs e)
        {
            Ocena staraOcena = new Ocena();
            staraOcena.sifraFilma = txtAzurirajOcenaSifra.Text;
            staraOcena.username = txtAzurirajOcenaUsername.Text;
            staraOcena.password = txtAzurirajOcenaPassword.Text;
            int novaOcena = Convert.ToInt32(numericUpDownAzurirajOcena.Value);

            DataProvider.UpdateOcena(staraOcena, novaOcena);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Ocena ažurirana.";
            timerWarning.Start();

            txtAzurirajOcenaSifra.Enabled = true;
            txtAzurirajOcenaUsername.Enabled = true;
            txtAzurirajOcenaPassword.Enabled = true;
            gbxOcenaAzurirajUkloni.Visible = false;

            ButtonOcene_Click(sender, e);
        }

        private void BtnUkloniOcenu_Click(object sender, EventArgs e)
        {
            Ocena o = new Ocena();
            o.sifraFilma = txtAzurirajOcenaSifra.Text;
            o.username = txtAzurirajOcenaUsername.Text;
            o.password = txtAzurirajOcenaPassword.Text;
            DataProvider.DeleteOcena(o);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Ocena uklonjena.";
            timerWarning.Start();
            txtAzurirajOcenaSifra.Enabled = true;
            txtAzurirajOcenaUsername.Enabled = true;
            txtAzurirajOcenaPassword.Enabled = true;
            gbxOcenaAzurirajUkloni.Visible = false;

            ButtonOcene_Click(sender, e);
        }

        private void ButtonOcene_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "ocene";
            panelUpravljanjeNalozima.Hide();
            panelFilmovi.Hide();
            panelOmiljeniFilmovi.Hide();
            panelOdgledaniFilmovi.Hide();
            panelRecenzije.Hide();
            panelOcene.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOcene == "prosiren")
                {
                    this.panelOcene.Location = new Point(this.panelOcene.Location.X - 150, this.panelOcene.Location.Y);
                    slajdOcene = "uvucen";
                }
            }
            else
            {
                if (slajdOcene == "uvucen")
                {
                    this.panelOcene.Location = new Point(this.panelOcene.Location.X + 150, this.panelOcene.Location.Y);
                    slajdOcene = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOcene.Location.Y);

            List<Ocena> ocene = DataProvider.GetSveOcene();
            dataGridOcene.Rows.Clear();

            foreach (Ocena k in ocene)
            {
                dataGridOcene.Rows.Add(k.sifraFilma, k.username, k.password, k.ocena);
            }

            dataGridOcene.Refresh();

            gbxOcenaAzurirajUkloni.Visible = false;
        }
        #endregion

        #region Administrator_Upravljanje_ListamaOmiljenihFilmova
        private void ButtonOmiljeniFilmovi_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "omiljeniFilmovi";
            panelUpravljanjeNalozima.Hide();
            panelFilmovi.Hide();
            panelOcene.Hide();
            panelOdgledaniFilmovi.Hide();
            panelRecenzije.Hide();
            panelOmiljeniFilmovi.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOmiljeniFilmovi == "prosiren")
                {
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X - 100, this.panelOmiljeniFilmovi.Location.Y);
                    slajdOmiljeniFilmovi = "uvucen";
                }
            }
            else
            {
                if (slajdOmiljeniFilmovi == "uvucen")
                {
                    this.panelOmiljeniFilmovi.Location = new Point(this.panelOmiljeniFilmovi.Location.X + 100, this.panelOmiljeniFilmovi.Location.Y);
                    slajdOmiljeniFilmovi = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljeniFilmovi.Location.Y);

            List<OmiljeniFilm> filmovi = DataProvider.GetSviOmiljeniFilmovi();
            dataGridOmiljeniFilmovi.Rows.Clear();

            foreach (OmiljeniFilm k in filmovi)
            {
                dataGridOmiljeniFilmovi.Rows.Add(k.korisnik.username,k.korisnik.password,k.naziv,k.godina,k.zanr,k.sifra);
            }

            dataGridOmiljeniFilmovi.Refresh();

            gbxOmiljUkloni.Visible = false;
        }

        private void BtnOmiljDodaj_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.username = txtOmiljDodajUsername.Text;
            k.password = txtOmiljDodajPassword.Text;
            Film f = new Film();
            f.naziv = txtOmiljDodajNaziv.Text;
            if(cbxOmiljDodajZanr.SelectedIndex>-1)
            f.zanr = cbxOmiljDodajZanr.SelectedItem.ToString();
            f.godina = txtOmiljDodajGod.Text;
            f.sifra = txtOmiljDodajSifra.Text;
            if (f.naziv.Contains('\''))
                f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);

            if (!DataProvider.daLiJeToKorisnikovOmiljeniFilm(k,f)
                && DataProvider.daLiPostojiUsernamePassword(k.username, k.password)
                && !string.IsNullOrEmpty(f.naziv) && !string.IsNullOrEmpty(f.zanr) && !string.IsNullOrEmpty(f.godina)
                && !string.IsNullOrEmpty(f.sifra) && cbxOmiljDodajZanr.SelectedIndex>-1)
            {
                DataProvider.dodajOmiljeniFilm(k, f);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje.";
                txtOmiljDodajSifra.Text = string.Empty;
                txtOmiljDodajGod.Text = string.Empty;
                txtOmiljDodajNaziv.Text = string.Empty;
                txtOmiljDodajUsername.Text = string.Empty;
                txtOmiljDodajPassword.Text = string.Empty;
                cbxOmiljDodajZanr.SelectedIndex = -1;
                cbxOmiljDodajZanr.SelectedText = string.Empty;
                ButtonOmiljeniFilmovi_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        private void DataGridOmiljeniFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxOmiljUkloni.Visible = true;
        }

        private void BtnOmiljUkloni_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            Film f = new Film();
            k.username = dataGridOmiljeniFilmovi.CurrentRow.Cells[0].Value.ToString();
            k.password= dataGridOmiljeniFilmovi.CurrentRow.Cells[1].Value.ToString();
            f.sifra= dataGridOmiljeniFilmovi.CurrentRow.Cells[5].Value.ToString();
            f.godina= dataGridOmiljeniFilmovi.CurrentRow.Cells[3].Value.ToString();
            f.naziv= dataGridOmiljeniFilmovi.CurrentRow.Cells[2].Value.ToString();
            f.zanr= dataGridOmiljeniFilmovi.CurrentRow.Cells[4].Value.ToString();
            if (f.naziv.Contains('\''))
                f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);
            DataProvider.deleteOmiljeniFilm(k, f);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uspešno uklonjeno.";
            timerWarning.Start();
            gbxOmiljUkloni.Visible = false;

            ButtonOmiljeniFilmovi_Click(sender, e);
        }

        #endregion

        #region Administrator_Upravljanje_ListamaOdgledanihFilmova
        private void ButtonOdgledaniFilmovi_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "odgledaniFilmovi";
            panelUpravljanjeNalozima.Hide();
            panelOcene.Hide();
            panelOmiljeniFilmovi.Hide();
            panelFilmovi.Hide();
            panelRecenzije.Hide();
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

            List<OmiljeniFilm> filmovi = DataProvider.GetSviOdgledaniFilmovi();
            dataGridOdgledaniFilmovi.Rows.Clear();

            foreach (OmiljeniFilm k in filmovi)
            {
                dataGridOdgledaniFilmovi.Rows.Add(k.korisnik.username, k.korisnik.password, k.naziv, k.godina, k.zanr, k.sifra);
            }

            dataGridOdgledaniFilmovi.Refresh();

            gbxOdgledaniUkloni.Visible = false;
        }

        private void BtnOdgledaniDodaj_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.username = txtOdgledaniUsername.Text;
            k.password = txtOdgledaniPassword.Text;
            Film f = new Film();
            f.naziv = txtOdgledaniNaziv.Text;
            if (cbxOdgledaniZanr.SelectedIndex > -1)
                f.zanr = cbxOdgledaniZanr.SelectedItem.ToString();
            f.godina = txtOdgledaniGodina.Text;
            f.sifra = txtOdgledaniSifra.Text;
            if (f.naziv.Contains('\''))
                f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);

            if (!DataProvider.daLiJeKorisnikOdgledaoFilm(k, f)
                && DataProvider.daLiPostojiUsernamePassword(k.username, k.password)
                && !string.IsNullOrEmpty(f.naziv) && !string.IsNullOrEmpty(f.zanr) && !string.IsNullOrEmpty(f.godina)
                && !string.IsNullOrEmpty(f.sifra) && cbxOdgledaniZanr.SelectedIndex > -1)
            {
                DataProvider.dodajOdgledaniFilm(k, f);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje.";
                txtOdgledaniSifra.Text = string.Empty;
                txtOdgledaniGodina.Text = string.Empty;
                txtOdgledaniNaziv.Text = string.Empty;
                txtOdgledaniUsername.Text = string.Empty;
                txtOdgledaniPassword.Text = string.Empty;
                cbxOdgledaniZanr.SelectedIndex = -1;
                cbxOdgledaniZanr.SelectedText = string.Empty;
                ButtonOdgledaniFilmovi_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        private void DataGridOdgledaniFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxOdgledaniUkloni.Visible = true;
        }

        private void BtnOdgledaniUkloni_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            Film f = new Film();
            k.username = dataGridOdgledaniFilmovi.CurrentRow.Cells[0].Value.ToString();
            k.password = dataGridOdgledaniFilmovi.CurrentRow.Cells[1].Value.ToString();
            f.sifra = dataGridOdgledaniFilmovi.CurrentRow.Cells[5].Value.ToString();
            f.godina = dataGridOdgledaniFilmovi.CurrentRow.Cells[3].Value.ToString();
            f.naziv = dataGridOdgledaniFilmovi.CurrentRow.Cells[2].Value.ToString();
            f.zanr = dataGridOdgledaniFilmovi.CurrentRow.Cells[4].Value.ToString();
            if (f.naziv.Contains('\''))
                f.naziv = DuplirajApostrofUNazivuFilmaUkolikoPostoji(f.naziv);
            DataProvider.deleteOdgledaniFilm(k, f);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uspešno uklonjeno.";
            timerWarning.Start();
            gbxOmiljUkloni.Visible = false;

            ButtonOdgledaniFilmovi_Click(sender, e);
        }

        #endregion

        #region Administrator_Upravljanje_Recenzijama
        private void ButtonRecenzije_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "recenzije";
            panelUpravljanjeNalozima.Hide();
            panelOcene.Hide();
            panelOmiljeniFilmovi.Hide();
            panelFilmovi.Hide();
            this.panelOdgledaniFilmovi.Hide();
            this.panelRecenzije.Show();

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

            panelRecGlavni.Visible = true;
            panelRecGlavni.BringToFront();
            panelRecAlter.Visible = false;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

            List<Recenzija> recenzije = DataProvider.GetSveRecenzije();
            dataGridRecenzije.Rows.Clear();

            foreach (Recenzija k in recenzije)
            {
                dataGridRecenzije.Rows.Add(k.sifraFilma, k.datum, k.username, k.recenzija);
            }

            dataGridRecenzije.Refresh();

            gbxRecenzAzuriraj.Visible = false;
            gbxRecenzDodaj.Visible = true;
        }

        private void DataGridRecenzije_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            gbxRecenzDodaj.Visible = false;
            gbxRecenzAzuriraj.Visible = true;
            Recenzija r = new Recenzija();
            r.sifraFilma = dataGridRecenzije.CurrentRow.Cells[0].Value.ToString();
            r.recenzija = dataGridRecenzije.CurrentRow.Cells[3].Value.ToString();
            r.username = dataGridRecenzije.CurrentRow.Cells[2].Value.ToString();
            string datum = dataGridRecenzije.CurrentRow.Cells[1].Value.ToString();
            btnRecenzAzur.Tag = r;
            btnRecenzUkloni.Tag = r;
            txtRecenzAzurTekst.Text = r.recenzija;
            txtRecenzAzurAutor.Text = r.username;
            txtRecenzAzurSifra.Text = r.sifraFilma;
            dateTimePickerRecenzAzur.Value = new DateTime(Convert.ToInt32(datum.Split('-')[0]), Convert.ToInt32(datum.Split('-')[1]), Convert.ToInt32(datum.Split('-')[2]));
        }

        private void BtnRecenzUkloni_Click_1(object sender, EventArgs e)
        {
            Recenzija r = new Recenzija();
            r = (Recenzija)btnRecenzUkloni.Tag;
            string datum = dataGridRecenzije.CurrentRow.Cells[1].Value.ToString();
            DataProvider.deleteRecenziju(r, datum);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uspešno uklonjeno.";
            timerWarning.Start();
            gbxOmiljUkloni.Visible = false;

            ButtonRecenzije_Click(sender, e);
        }

        private void BtnRecenzAzur_Click_1(object sender, EventArgs e)
        {
            Recenzija stara = new Recenzija();
            stara = (Recenzija)btnRecenzAzur.Tag;
            string datumStari = dataGridRecenzije.CurrentRow.Cells[1].Value.ToString();
            Recenzija nova = new Recenzija();
            nova.sifraFilma = txtRecenzAzurSifra.Text;
            nova.recenzija = txtRecenzAzurTekst.Text;
            nova.username = txtRecenzAzurAutor.Text;
            string Novidatum = dateTimePickerRecenzAzur.Value.ToString("yyyy/MM/dd");
            Novidatum = Novidatum.Replace("/", "-");

            if (!string.IsNullOrEmpty(nova.sifraFilma) && !string.IsNullOrEmpty(nova.recenzija) && !string.IsNullOrEmpty(nova.username))
            {
                DataProvider.UpdateRecenziju(stara, datumStari, nova, Novidatum);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno ažuriranje.";
                txtRecenzAzurAutor.Text = string.Empty;
                txtRecenzAzurSifra.Text = string.Empty;
                txtRecenzAzurTekst.Text = string.Empty;
                ButtonRecenzije_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        private void BtnDodajRecenz_Click_1(object sender, EventArgs e)
        {
            Recenzija r = new Recenzija();
            r.sifraFilma = txtRecenzDodajSifra.Text;
            r.recenzija = richTextBoxDodajRecenz.Text;
            r.username = txtRecenzDodajAutor.Text;
            string datum = dateTimePickerDodajRecenz.Value.ToString("yyyy/MM/dd");
            datum = datum.Replace("/", "-");

            if (!string.IsNullOrEmpty(r.sifraFilma) && !string.IsNullOrEmpty(r.recenzija) && !string.IsNullOrEmpty(r.username))
            {
                DataProvider.dodajRecenziju(r, datum);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje.";
                txtRecenzDodajAutor.Text = string.Empty;
                txtRecenzDodajSifra.Text = string.Empty;
                richTextBoxDodajRecenz.Text = string.Empty;
                ButtonRecenzije_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        #endregion

        #region Administrator_Upravljanje_Preporukama
        private void ButtonPreporuke_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "recenzije";
            panelUpravljanjeNalozima.Hide();
            panelOcene.Hide();
            panelOmiljeniFilmovi.Hide();
            panelFilmovi.Hide();
            this.panelOdgledaniFilmovi.Hide();
            this.panelRecenzije.Show();

            panelRecGlavni.Visible = false;
            panelRecAlter.BringToFront();
            panelRecAlter.Visible = true;

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

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPreporuke.Location.Y);

            List<Preporuka> preporuke = DataProvider.getSvePreporuke();
            dataGridPreporuke.Rows.Clear();

            foreach (Preporuka k in preporuke)
            {
                dataGridPreporuke.Rows.Add(k.sifraFilma, k.username, k.password, k.preporuka);
            }

            dataGridPreporuke.Refresh();
            gbxPreporukaIzmeniUkloni.Visible = false;
        }

        private void BtnDodajPreporuka_Click(object sender, EventArgs e)
        {
            Preporuka p = new Preporuka();
            p.sifraFilma = txtDodajPreporukaSifra.Text;
            p.username = txtDodajPreporukaUsername.Text;
            p.password = txtDodajPreporukaPassword.Text;
            p.preporuka = cbxDodajPreporuka.SelectedItem.ToString();

            if(!DataProvider.daLiJeKorisnikVecPreporucioFilm(p.sifraFilma,p.username,p.password)
                && !string.IsNullOrEmpty(p.sifraFilma) && !string.IsNullOrEmpty(p.username) && !string.IsNullOrEmpty(p.password)
                && cbxDodajPreporuka.SelectedIndex>-1 && DataProvider.daLiPostojiUsernamePassword(p.username,p.password))
            {
                DataProvider.dodajPreporuku(p);
                sec_counter = 0;
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Preporuka dodata.";
                ButtonPreporuke_Click(sender, e);
                timerWarning.Start();
            }
            else
            {
                sec_counter = 0;
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušaj ponovo.";
                timerWarning.Start();
            }
        }

        private void DataGridPreporuke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxPreporukaIzmeniUkloni.Visible = true;
        }

        private void BtnPreporukaIzmeni_Click(object sender, EventArgs e)
        {
            Preporuka p = new Preporuka();
            p.sifraFilma = dataGridPreporuke.CurrentRow.Cells[0].Value.ToString();
            p.username = dataGridPreporuke.CurrentRow.Cells[1].Value.ToString();
            p.password = dataGridPreporuke.CurrentRow.Cells[2].Value.ToString();
            p.preporuka = dataGridPreporuke.CurrentRow.Cells[3].Value.ToString();
            string novaPreporuka = null;
            if (p.preporuka == "da")
                novaPreporuka = "ne";
            else if (p.preporuka == "ne")
                novaPreporuka = "da";

            DataProvider.UpdatePreporuka(p, novaPreporuka);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Preporuka izmenjena.";
            ButtonPreporuke_Click(sender, e);
            timerWarning.Start();
        }

        private void BtnPreporukaUkloni_Click(object sender, EventArgs e)
        {
            Preporuka p = new Preporuka();
            p.sifraFilma = dataGridPreporuke.CurrentRow.Cells[0].Value.ToString();
            p.username = dataGridPreporuke.CurrentRow.Cells[1].Value.ToString();
            p.password = dataGridPreporuke.CurrentRow.Cells[2].Value.ToString();
            p.preporuka = dataGridPreporuke.CurrentRow.Cells[3].Value.ToString();

            DataProvider.DeletePreporuka(p);
            sec_counter = 0;
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Preporuka uklonjena.";
            ButtonPreporuke_Click(sender, e);
            timerWarning.Start();
        }

        #endregion
    }
}
