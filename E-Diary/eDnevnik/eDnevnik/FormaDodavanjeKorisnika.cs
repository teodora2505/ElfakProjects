using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik
{
    public partial class FormaDodavanjeKorisnika : Form
    {
        public KorisnikExtended korisnikIzmena { get; set; }

        public FormaDodavanjeKorisnika(bool DodajOrIzmeni,KorisnikExtended k)
        {
            InitializeComponent();

            comboBoxOdeljenjeUcenika.Items.Clear();
            List<OdeljenjeBasic> lista = DTOManager.GetSvaOdeljenja();

            foreach (OdeljenjeBasic o in lista)
            {
                comboBoxOdeljenjeUcenika.Items.Add(o.Naziv);
            }

            if (DodajOrIzmeni==true)//radi se o dodavanju novog korisnika
            {

            }
            else //radi se o izmeni podataka za selektovanog korisnika
            {
                button.Text = "Izmeni korisnika";
                korisnikIzmena = k;
                txtIme.Text = k.Ime;
                txtPrezime.Text = k.Prezime;
                txtPol.Text = k.Pol.ToString();
                txtJmbg.Text = k.JMBG;
                txtUsername.Text = k.KorisnickoIme;
                txtPassword.Text = k.Sifra;
                dateTimePicker1.Value = k.DatumRodjenja;

                if (k.FUcenik == 1)
                {
                    checkBoxUcenik.Checked = true;
                    panelUcenika.Visible = true;
                    panelNastavnik.Visible = false;
                    txtOpravdani.Text = k.Opravdani.ToString();
                    txtNeopravdani.Text = k.Neopravdani.ToString();
                    txtVladanje.Text = k.OcenaVladanje.ToString();
                    OdeljenjeBasic odeljenje = DTOManager.GetOdeljenje(k.OdeljenjeId);
                    comboBoxOdeljenjeUcenika.SelectedItem = odeljenje.Naziv;
                }

                if (k.FNastavnik == 1)
                {
                    checkBoxNastavnik.Checked = true;
                    panelUcenika.Visible = false;
                    panelNastavnik.Visible = true;
                    txtsss.Text = korisnikIzmena.StrucnaSprema;

                }
                   
                if (k.FAdministrator == 1)
                    checkBoxAdmin.Checked = true;

                if (k.FRoditelj == 1)
                    checkBoxRoditelj.Checked = true;

            }
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUcenik.Checked = false;
        }

        private void checkBoxNastavnik_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUcenik.Checked = false;
            if(checkBoxNastavnik.Checked==true)
            {
                panelNastavnik.Visible = true;
                panelUcenika.Visible = false;
            }
        }

        private void checkBoxRoditelj_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUcenik.Checked = false;
        }

        private void checkBoxUcenik_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAdmin.Checked = false;
            checkBoxNastavnik.Checked = false;
            checkBoxRoditelj.Checked = false;
            if (checkBoxUcenik.Checked == true)
            {
                panelUcenika.Visible = true;
                panelNastavnik.Visible = false;
            }
                
        }

        private void button_Click(object sender, EventArgs e)
        {
            KorisnikExtended korisnik = new KorisnikExtended();
            korisnik.Ime = txtIme.Text;
            korisnik.Prezime = txtPrezime.Text;
            korisnik.Pol = Convert.ToChar(txtPol.Text);
            korisnik.DatumRodjenja = dateTimePicker1.Value;
            korisnik.JMBG = txtJmbg.Text;
            korisnik.KorisnickoIme = txtUsername.Text;
            korisnik.Sifra = txtPassword.Text;

            if (checkBoxAdmin.Checked == true)
                korisnik.FAdministrator = 1;

            if (checkBoxNastavnik.Checked == true)
            {
                korisnik.FNastavnik = 1;
                korisnik.StrucnaSprema = txtsss.Text;
            }

            if (checkBoxRoditelj.Checked == true)
                korisnik.FRoditelj = 1;

            if (checkBoxUcenik.Checked == true)
            {
                korisnik.FUcenik = 1;
                korisnik.Opravdani = Convert.ToInt32(txtOpravdani.Text);
                korisnik.Neopravdani = Convert.ToInt32(txtNeopravdani.Text);
                korisnik.OcenaVladanje = Convert.ToInt32(txtVladanje.Text);
                korisnik.OdeljenjeId = DTOManager.GetOdeljenjeNaziv(comboBoxOdeljenjeUcenika.SelectedItem.ToString()).OdeljenjeId;
            }

            if (button.Text == "Dodaj korisnika")
            {
                DTOManager.SaveKorisnik(korisnik);
            }
            else if(button.Text== "Izmeni korisnika")
            {
                DTOManager.UpdateKorisnik(korisnikIzmena.KorisnikId, korisnik);
            }
            this.Close();

        }

        private void FormaDodavanjeKorisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
