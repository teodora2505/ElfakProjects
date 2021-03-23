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
    public partial class FormaVrsiociFunkcija : Form
    {
        public FormaVrsiociFunkcija()
        {
            InitializeComponent();
        }

        private void FormaVrsiociFunkcija_Load(object sender, EventArgs e)
        {
            this.osvezi();
        }

        public void osvezi()
        {
            datagridFunkcije.Rows.Clear();
            cbxIzmeni.Items.Clear();
            cbxUkloni.Items.Clear();

            foreach (FunkcijaPregled funkcija in DTOManager.GetSveFunkcije())
            {
                DateTime? datum = funkcija.DatumDo;
                KorisnikExtended roditelj = DTOManager.GetKorisnikPregledInfos(funkcija.RoditeljId);

                cbxIzmeni.Items.Add(funkcija.FunkcijaId);
              

                if (datum == DateTime.MinValue)
                {
                    datagridFunkcije.Rows.Add(funkcija.FunkcijaId,roditelj.KorisnikId,roditelj.Ime+" "+roditelj.Prezime,funkcija.TipFunkcije.ToLower(),funkcija.DatumOd.ToShortDateString(),"");

                    cbxUkloni.Items.Add(funkcija.FunkcijaId);
                }
                else
                {
                    DateTime d = (DateTime)datum;
                    datagridFunkcije.Rows.Add(funkcija.FunkcijaId, roditelj.KorisnikId, roditelj.Ime + " " + roditelj.Prezime, funkcija.TipFunkcije.ToLower(), funkcija.DatumOd.ToShortDateString(),d.ToShortDateString());
                }
            }

            datagridFunkcije.ClearSelection();

            cbxDodajRoditeljId.Items.Clear();

            foreach (KorisnikExtended kor in DTOManager.GetRoditeljiBezFunkcije())
            {
                cbxDodajRoditeljId.Items.Add(kor.KorisnikId);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbxDodajFunkcija.SelectedIndex > -1 && DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(cbxDodajRoditeljId.SelectedItem.ToString())).FRoditelj == 1)
            {
                DTOManager.SaveFunkcija(Convert.ToInt32(cbxDodajRoditeljId.SelectedItem.ToString()), cbxDodajFunkcija.SelectedItem.ToString().ToUpper());
                this.osvezi();
                cbxDodajFunkcija.Text = "";
                cbxDodajRoditeljId.Text = "";
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            FunkcijaPregled pp = new FunkcijaPregled();

            foreach (FunkcijaPregled p in DTOManager.GetSveFunkcije())
            {

                if (p.FunkcijaId == Convert.ToInt32(cbxUkloni.SelectedItem.ToString()))
                {
                    pp = p;
                }
            }

            DTOManager.deleteFunkcija(pp.FunkcijaId);
            this.osvezi();
            cbxUkloni.Text = "";
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            DateTime pocetak;
            DateTime? kraj;
            FunkcijaPregled jr1 = new FunkcijaPregled();

            foreach (FunkcijaPregled jr in DTOManager.GetSveFunkcije())
            {
                if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.FunkcijaId)
                {
                    jr1 = jr;
                }
            }

            if (checkBoxPocetak.Checked == true)
            {
                pocetak = dateTimePicker1.Value;
            }
            else
            {
                pocetak = jr1.DatumOd;
            }

            if (checkBoxKraj.Checked == true)
            {
                kraj = dateTimePicker2.Value;
            }
            else
            {
                kraj = jr1.DatumDo;
            }

            DTOManager.UpdateFunkcija(jr1.FunkcijaId, pocetak, kraj);
            this.osvezi();
            cbxIzmeni.Text = "";
            checkBoxKraj.Checked = false;
            checkBoxPocetak.Checked = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void cbxIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {
                checkBoxKraj.Checked = false;
                checkBoxPocetak.Checked = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        private void checkBoxPocetak_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {
                dateTimePicker1.Visible = true;
                foreach (FunkcijaPregled jr in DTOManager.GetSveFunkcije())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.FunkcijaId)
                        dateTimePicker1.Value = DateTime.Parse(jr.DatumOd.ToShortDateString());

                }
            }
        }

        private void checkBoxKraj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {

                DateTime datum;
                dateTimePicker2.Visible = true;
                foreach (FunkcijaPregled jr in DTOManager.GetSveFunkcije())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.FunkcijaId)
                    {
                        if (jr.DatumDo == null)
                            dateTimePicker2.Value = DateTime.Now;
                        else
                        {
                            datum = (DateTime)jr.DatumDo;
                            dateTimePicker2.Value = datum;

                        }
                    }
                }
            }
        }
    }
}
