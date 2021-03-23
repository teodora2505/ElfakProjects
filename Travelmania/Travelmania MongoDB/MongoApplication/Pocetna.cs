using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mongo_DataLayer;
using Mongo_DataLayer.Entities;
using MongoDB.Driver;

namespace MongoApplication
{
    public partial class Pocetna : Form
    {
        int secCount = 0;

        #region funkcije_za_formu

        public Pocetna()
        {
            InitializeComponent();
            switchPrijavaReg.Value = true;
            switchKorisnikAdmin.Value = true;
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)//zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //minimizacija forme
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Pocetna_Load(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
        }

        #endregion

        #region Prijavljivanje_Registrovanje

        private void switchKorisnikAdmin_OnValueChange(object sender, EventArgs e)
        {
            if(switchKorisnikAdmin.Value==true)
            {
                panelKorisnik.Visible = true;
                panelKorisnik.BringToFront();
                panelAdmin.Visible = false;
                labelKorisnikAdmin.Text = "Korisnik";
                panelPrijava.Visible = true;
                panelPrijava.BringToFront();
                panelReg.Visible = false;
                labPrijavaReg.Text = "Prijavljivanje";
                txtKorisnikPrijavaPass.Text = string.Empty;
                txtKorisnikPrijavaMail.Text = string.Empty;
            }
            else
            {
                panelAdmin.Visible = true;
                panelAdmin.BringToFront();
                panelKorisnik.Visible = false;
                labelKorisnikAdmin.Text = "Administrator";
                txtAdminMail.Text = string.Empty;
                txtAdminPassword.Text = string.Empty;
            }
        }

        private void switchPrijavaReg_OnValueChange(object sender, EventArgs e)
        {
            if(switchPrijavaReg.Value==true)
            {
                panelPrijava.Visible = true;
                panelPrijava.BringToFront();
                panelReg.Visible = false;
                labPrijavaReg.Text = "Prijavljivanje";
                txtKorisnikPrijavaPass.Text = string.Empty;
                txtKorisnikPrijavaMail.Text = string.Empty;
            }
            else
            {
                panelReg.Visible = true;
                panelReg.BringToFront();
                panelPrijava.Visible = false;
                labPrijavaReg.Text = "Registrovanje";
                txtKorRegMail.Text = string.Empty;
                txtKorRegPass.Text = string.Empty;
                txtKorisnikRegIme.Text = string.Empty;
                txtKorisnikRegPrezime.Text = string.Empty;
            }
        }

        private void btnKorisnikPrijava_Click(object sender, EventArgs e)
        {
            Korisnik k= MongoProvider.vratiKorisnika(txtKorisnikPrijavaMail.Text,txtKorisnikPrijavaPass.Text);
            if(k != null)
            {
                this.Hide();
                TravelmaniaKorisnik formaKorisnik = new TravelmaniaKorisnik();
                formaKorisnik.logovanIme = k.Ime;
                formaKorisnik.logovanPrezime = k.Prezime;
                formaKorisnik.logovanKorisnik = k;
                formaKorisnik.Closed += (s, args) => this.Close();
                formaKorisnik.Show();
            }
            else
            {
                secCount = 0;
                labelWarning.Visible = true;
                timer1.Start();

            }
        }

        private void btnKorReg_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.Ime = txtKorisnikRegIme.Text;
            k.Prezime = txtKorisnikRegPrezime.Text;
            k.Password = txtKorRegPass.Text;
            k.Email = txtKorRegMail.Text;
            k.Admin = "ne";
            if(string.IsNullOrEmpty(k.Ime)||
                string.IsNullOrEmpty(k.Prezime)||
                string.IsNullOrEmpty(k.Password) ||
                string.IsNullOrEmpty(k.Email)||
                !k.Email.Contains('@'))
            {
                secCount = 0;
                labelWarning.Visible = true;
                timer1.Start();
            }
            else
            {
                MongoProvider.dodajKorisnika(k);
                this.Hide();
                TravelmaniaKorisnik formaKorisnik = new TravelmaniaKorisnik();
                formaKorisnik.logovanIme = k.Ime;
                formaKorisnik.logovanPrezime = k.Prezime;
                formaKorisnik.logovanKorisnik = k;
                formaKorisnik.Closed += (s, args) => this.Close();
                formaKorisnik.Show();
            }
        }

        private void btnAdminPrijaviSe_Click(object sender, EventArgs e)
        {
            Korisnik k = MongoProvider.vratiKorisnika(txtAdminMail.Text, txtAdminPassword.Text);
            if (k != null)
            {
                if(k.Admin=="da")
                {
                    this.Hide();
                    TravelmaniaAdmin formaAdmin = new TravelmaniaAdmin();
                    formaAdmin.logovanIme = k.Ime;
                    formaAdmin.logovanPrezime = k.Prezime;
                    formaAdmin.Closed += (s, args) => this.Close();
                    formaAdmin.Show();
                }
                else
                {
                    secCount = 0;
                    labelWarning.Visible = true;
                    timer1.Start();
                }
       
            }
            else
            {
                secCount = 0;
                labelWarning.Visible = true;
                timer1.Start();
            }
        }

        //mora ovako za Bunifu MaterialTextBox da bi se setovao property .isPassword
        //inace direktnim setovanjem ovog property-ja ne radi
        private void txtKorRegPass_OnValueChanged(object sender, EventArgs e)
        {
            txtKorRegPass.isPassword = true;
        }

        private void txtAdminPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtAdminPassword.isPassword = true;
        }

        private void txtKorisnikPrijavaPass_OnValueChanged(object sender, EventArgs e)
        {
            txtKorisnikPrijavaPass.isPassword = true;
        }

        #endregion

    }
}
