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
    public partial class FormaPredstavniciOdeljenja : Form
    {
        public FormaPredstavniciOdeljenja()
        {
            InitializeComponent();
        }

        private void FormaPredstavniciOdeljenja_Load(object sender, EventArgs e)
        {
            this.osvezi();
        }

        public void osvezi()
        {
            dataGridPredstavniciOdeljenja.Rows.Clear();
            cbxIzmeni.Items.Clear();
            cbxUkloni.Items.Clear();

            foreach (PredstavljaPregled predstavljanje in DTOManager.GetOdeljenskiPredstavnici())
            {
                DateTime? datum = predstavljanje.DatumDo;
                OdeljenjeBasic odeljenje = DTOManager.GetOdeljenje(predstavljanje.OdeljenjeId);
                KorisnikExtended nastavnik = DTOManager.GetKorisnikPregledInfos(predstavljanje.RoditeljId);

                cbxIzmeni.Items.Add(predstavljanje.PredstavljaId);

                if (datum == null)
                {
                    dataGridPredstavniciOdeljenja.Rows.Add(predstavljanje.PredstavljaId, odeljenje.Naziv, odeljenje.Smer.ToLower(), nastavnik.KorisnikId, nastavnik.Ime + " " + nastavnik.Prezime,
                        predstavljanje.DatumOd.ToShortDateString(), "");

                    cbxUkloni.Items.Add(predstavljanje.PredstavljaId);
                }
                else
                {
                    DateTime d = (DateTime)datum;
                    dataGridPredstavniciOdeljenja.Rows.Add(predstavljanje.PredstavljaId, odeljenje.Naziv, odeljenje.Smer.ToLower(), nastavnik.KorisnikId, nastavnik.Ime + " " + nastavnik.Prezime,
                           predstavljanje.DatumOd.ToShortDateString(), d.ToShortDateString());
                }
            }

            dataGridPredstavniciOdeljenja.ClearSelection();

            cbxDodajOdeljenje.Items.Clear();

            foreach(OdeljenjeBasic odeljenje in DTOManager.GetOdeljenjaBezPredstavnika())
            {
                cbxDodajOdeljenje.Items.Add(odeljenje.Naziv);
            }

        }

        private void btnDodajPredstavnika_Click(object sender, EventArgs e)
        {
            if(cbxDodajOdeljenje.SelectedIndex>-1 && DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(txtDodajPredstavnika.Text)).FRoditelj==1)
            {
                DTOManager.SavePredstavlja(Convert.ToInt32(txtDodajPredstavnika.Text), DTOManager.GetOdeljenjeNaziv(cbxDodajOdeljenje.SelectedItem.ToString()).OdeljenjeId);
                this.osvezi();
                txtDodajPredstavnika.Text = "";
                cbxDodajOdeljenje.Text = "";
            }
        }

        private void btnUkloniPredstavljanje_Click(object sender, EventArgs e)
        {
            PredstavljaPregled pp = new PredstavljaPregled();

            foreach (PredstavljaPregled p in DTOManager.GetOdeljenskiPredstavnici())
            {
                
                if(p.PredstavljaId==Convert.ToInt32(cbxUkloni.SelectedItem.ToString()))
                {
                    pp = p;
                }
            }

            DTOManager.deletePredstavlja(pp.PredstavljaId);
            this.osvezi();
            cbxUkloni.Text = "";
        }

        private void checkBoxPocetak_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {
                dateTimePicker1.Visible = true;
                foreach (PredstavljaPregled jr in DTOManager.GetOdeljenskiPredstavnici())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.PredstavljaId)
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
                foreach (PredstavljaPregled jr in DTOManager.GetOdeljenskiPredstavnici())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.PredstavljaId)
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

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            DateTime pocetak;
            DateTime? kraj;
            PredstavljaPregled jr1 = new PredstavljaPregled();

            foreach (PredstavljaPregled jr in DTOManager.GetOdeljenskiPredstavnici())
            {
                if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.PredstavljaId)
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

            DTOManager.UpdatePredstavlja(jr1.PredstavljaId, pocetak, kraj);
            this.osvezi();
            cbxIzmeni.Text = "";
            checkBoxKraj.Checked = false;
            checkBoxPocetak.Checked = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }
    }
}
