using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;


namespace MovieCritic
{
    public partial class Pocetna : Form
    {
        public MovieCriticAdmin myForm;
        int sec_counter = 0;
        
        public Pocetna()
        {
            InitializeComponent();
            panelKorisnik.Visible = true;
            panelAdmin.Visible = false;
            labelWarning.Visible = false;
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)//zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //minimizacija forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonKorReg_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.ime = txtRegKorIme.Text;
            korisnik.prezime = txtRegKorPrezime.Text;
            korisnik.username = txtRegKorUsername.Text;
            korisnik.password = txtRegKorPassword.Text;
            korisnik.mail = txtRegKorMail.Text;
            korisnik.admin = "ne";

            if (!string.IsNullOrEmpty(korisnik.ime)
                && !string.IsNullOrEmpty(korisnik.prezime)
                && !string.IsNullOrEmpty(korisnik.username)
                && !string.IsNullOrEmpty(korisnik.password)
                && !string.IsNullOrEmpty(korisnik.mail)
                && korisnik.mail.Contains('@')
                && !DataProvider.daLiPostojiUsernamePassword(korisnik.username, korisnik.password))
            {
                DataProvider.dodajKorisnika(korisnik);
                txtRegKorIme.Text = string.Empty;
                txtRegKorPrezime.Text = string.Empty;
                txtRegKorUsername.Text = string.Empty;
                txtRegKorPassword.Text = string.Empty;
                txtRegKorMail.Text = string.Empty;
            }
            else
            {
                sec_counter = 0;
                timerWarning.Start();
            }
        }

        private void ButtonAdminLog_Click(object sender, EventArgs e)
        {
            string username = txtLogAdminUser.Text;
            string password = txtLogAdminPass.Text;
            if (DataProvider.daLiPostojiUsernamePassword(username, password) 
                && DataProvider.daLiJeKorisnikAdministrator(username,password))
            {
                this.Hide();
                MovieCriticAdmin formaAdmin = new MovieCriticAdmin();
                formaAdmin.logovanUsername = username;
                formaAdmin.logovanPassword = password;
                formaAdmin.Closed += (s, args) => this.Close();
                formaAdmin.Show();

            }
            else
            {
                sec_counter = 0;
                timerWarning.Start();
            }
        }

        private void ButtonKorLog_Click(object sender, EventArgs e)
        {
            string username = txtLogKorUsername.Text;
            string password = txtLogKorPassword.Text;
            if (DataProvider.daLiPostojiUsernamePassword(username, password))
            {
                this.Hide();
                MovieCriticKorisnik formaKorisnik = new MovieCriticKorisnik();
                formaKorisnik.logovanUsername = username;
                formaKorisnik.logovanPassword = password;
                formaKorisnik.Closed += (s, args) => this.Close();
                formaKorisnik.Show();
            }
            else
            {
                sec_counter = 0;
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

        private void RadioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdmin.Checked)
            {
                panelAdmin.Visible = false;
                panelKorisnik.Visible = true;
            }
            else if (radioKorisnik.Checked)
            {

                panelKorisnik.Visible = false;
                panelAdmin.Visible = true;
            }
        }

        private void RadioKorisnik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdmin.Checked)
            {
                panelAdmin.Visible = false;
                panelKorisnik.Visible = true;
            }
            else if (radioKorisnik.Checked)
            {
                
                panelKorisnik.Visible = false;
                panelAdmin.Visible = true;
            }
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

      
    }
}
