using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik
{
    public partial class FormaNoviUčenik : Form
    {
         public  OdeljenjeBasic odeljenjeUcenika { get; set; }
         public int ucenikIzmena { get; set; }
         public bool mod { get; set; }


        public FormaNoviUčenik()
        {
            InitializeComponent();
        }

        public FormaNoviUčenik(OdeljenjeBasic odeljenje, bool modForme, int UcenikIzmenaId)
        {
            InitializeComponent();
            odeljenjeUcenika = odeljenje;
            mod = modForme;
            if(mod==false)//dodavanje ucenika
            {
                groupBox1.Text = "Dodavanje učenika";
                btnDodajUcenika.Text = "Dodaj učenika";
                numericUpDown1.Visible = false;
                labelOcenaVladanja.Visible = false;
            }
            else//izmena ucenika
            {
                groupBox1.Text = "Izmenja učenika";
                btnDodajUcenika.Text = "Izmeni učenika";
                KorisnikExtended k = DTOManager.GetKorisnikPregledInfos(UcenikIzmenaId);
                txtIme.Text = k.Ime;
                txtPrezime.Text = k.Prezime;
                txtPol.Text = k.Pol.ToString();
                txtJmbg.Text = k.JMBG;
                dateTimePicker.Value = k.DatumRodjenja;
                numericUpDown1.Value = DTOManager.GetUcenikInfos(UcenikIzmenaId).OcenaVladanje;
                numericUpDown1.Visible = true;
                labelOcenaVladanja.Visible = true;
                ucenikIzmena = UcenikIzmenaId;
            }
            
        }

        private void FormaNoviUčenik_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            if (mod == false) //dodavanje ucenika
            {
                if (!string.IsNullOrEmpty(txtIme.Text) && !string.IsNullOrEmpty(txtPrezime.Text) && dateTimePicker.Value != null
                    && !string.IsNullOrEmpty(txtPol.Text) && !string.IsNullOrEmpty(txtJmbg.Text))
                {
                    KorisnikExtended ucenik = new KorisnikExtended();
                    ucenik.Ime = txtIme.Text;
                    ucenik.Prezime = txtPrezime.Text;
                    ucenik.DatumRodjenja = dateTimePicker.Value;
                    ucenik.Pol = Convert.ToChar(txtPol.Text);
                    ucenik.JMBG = txtJmbg.Text;
                    ucenik.KorisnickoIme = ucenik.Ime.ToLower() + ucenik.JMBG.Substring(4, 3);
                    ucenik.Sifra = ucenik.Prezime.ToLower() + ucenik.JMBG.Substring(4, 3);
                    ucenik.FUcenik = 1; ucenik.FAdministrator = 0; ucenik.FNastavnik = 0; ucenik.FRoditelj = 0;
                    ucenik.OdeljenjeId = odeljenjeUcenika.OdeljenjeId;
                    ucenik.Opravdani = 0; ucenik.Neopravdani = 0; ucenik.OcenaVladanje = 5;

                    DTOManager.SaveUcenik(ucenik);
                    this.Close();

                }
            }
            else//izmena ucenika
            {
                if (!string.IsNullOrEmpty(txtIme.Text) && !string.IsNullOrEmpty(txtPrezime.Text) && dateTimePicker.Value != null
                   && !string.IsNullOrEmpty(txtPol.Text) && !string.IsNullOrEmpty(txtJmbg.Text))
                {
                    KorisnikExtended ucenik = new KorisnikExtended();
                    ucenik.Ime = txtIme.Text;
                    ucenik.Prezime = txtPrezime.Text;
                    ucenik.DatumRodjenja = dateTimePicker.Value;
                    ucenik.Pol = Convert.ToChar(txtPol.Text);
                    ucenik.JMBG = txtJmbg.Text;
                    ucenik.KorisnickoIme = ucenik.Ime.ToLower() + ucenik.JMBG.Substring(4, 3);
                    ucenik.Sifra = ucenik.Prezime.ToLower() + ucenik.JMBG.Substring(4, 3);
                    ucenik.FUcenik = 1; ucenik.FAdministrator = 0; ucenik.FNastavnik = 0; ucenik.FRoditelj = 0;
                    ucenik.OdeljenjeId = odeljenjeUcenika.OdeljenjeId;
                    ucenik.Opravdani = 0; ucenik.Neopravdani = 0;
                    ucenik.OcenaVladanje = Convert.ToInt32(numericUpDown1.Value);
                    DTOManager.UpdateUcenik(ucenikIzmena, ucenik);
                    this.Close();

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
