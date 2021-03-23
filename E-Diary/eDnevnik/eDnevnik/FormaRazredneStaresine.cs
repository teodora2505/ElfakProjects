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
    public partial class FormaRazredneStaresine : Form
    {
        public FormaRazredneStaresine()
        {
            InitializeComponent();
        }

        private void FormaRazredneStaresine_Load(object sender, EventArgs e)
        {
            this.osvezi();
        }

        public void osvezi()
        {
            dataGridRazredni.Rows.Clear();
            cbxUkloniStaresinstvo.Items.Clear();
            cbxDodajOdeljenje.Items.Clear();
            cbxRazredniDodaj.Items.Clear();
            cbxIzmeni.Items.Clear();

            foreach (jeRazredniPregled jr in DTOManager.GetRazredneStaresine())
            {
                DateTime datumdooo = DateTime.Now;
                string datum = "";

                if (jr.datumDo != null)
                {
                    datumdooo = (DateTime)jr.datumDo;
                    datum = datumdooo.ToShortDateString();
                }

                dataGridRazredni.Rows.Add(jr.jeRazredniId,
                                         DTOManager.GetKorisnikPregledInfos(jr.NastavnikId).Ime + " " + DTOManager.GetKorisnikPregledInfos(jr.NastavnikId).Prezime
                                         , DTOManager.GetOdeljenje(jr.OdeljenjeId).Naziv, jr.datumOd.ToShortDateString(), datum);
                if (datum == "")
                {
                    cbxUkloniStaresinstvo.Items.Add(jr.jeRazredniId);
                }
                cbxIzmeni.Items.Add(jr.jeRazredniId);
            }
            dataGridRazredni.ClearSelection();

            foreach (OdeljenjeBasic odeljenje in DTOManager.GetOdeljenjaBezRazrednogStaresine())
                cbxDodajOdeljenje.Items.Add(DTOManager.GetOdeljenje(odeljenje.OdeljenjeId).Naziv);

            foreach (KorisnikExtended nastavnik in DTOManager.GetNastavniciNisuRazredni())
                cbxRazredniDodaj.Items.Add(nastavnik.Ime + " " + nastavnik.Prezime);
        }

        private void btnUkloniStaresinstvo_Click(object sender, EventArgs e)
        {
            if (cbxUkloniStaresinstvo.SelectedIndex > -1)
            {
                DTOManager.deleteJeRazredi(Convert.ToInt32(cbxUkloniStaresinstvo.SelectedItem.ToString()));
                this.osvezi();
                cbxUkloniStaresinstvo.Text = "";
            }
        }

        private void btnDodajStaresinstvo_Click(object sender, EventArgs e)
        {
            if (cbxDodajOdeljenje.SelectedIndex > -1 && cbxRazredniDodaj.SelectedIndex > -1)
            {
                DTOManager.SaveJeRazredni(Convert.ToInt32(DTOManager.GetKorisnikImePrezime(cbxRazredniDodaj.SelectedItem.ToString()).KorisnikId),
                                            Convert.ToInt32(DTOManager.GetOdeljenjeNaziv(cbxDodajOdeljenje.SelectedItem.ToString()).OdeljenjeId));
                this.osvezi();
                cbxDodajOdeljenje.Text = "";
                cbxRazredniDodaj.Text = "";
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

        private void checkBoxKraj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {
               
                DateTime datum;
                dateTimePicker2.Visible = true;
                foreach (jeRazredniPregled jr in DTOManager.GetRazredneStaresine())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.jeRazredniId)
                    {
                        if (jr.datumDo == null)
                            dateTimePicker2.Value = DateTime.Now;
                        else
                        {
                            datum = (DateTime)jr.datumDo;
                            dateTimePicker2.Value = datum;

                        }
                    }
                }
            }
        }

        private void checkBoxPocetak_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIzmeni.SelectedIndex > -1)
            {
                dateTimePicker1.Visible = true;
                foreach (jeRazredniPregled jr in DTOManager.GetRazredneStaresine())
                {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.jeRazredniId)
                        dateTimePicker1.Value = DateTime.Parse(jr.datumOd.ToShortDateString());

                }
            }


        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            DateTime pocetak;
            DateTime? kraj;
            jeRazredniPregled jr1 = new jeRazredniPregled();

                 foreach (jeRazredniPregled jr in DTOManager.GetRazredneStaresine())
                 {
                    if (Convert.ToInt32(cbxIzmeni.SelectedItem.ToString()) == jr.jeRazredniId)
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
                    pocetak = jr1.datumOd;
                }

                if (checkBoxKraj.Checked == true)
                {
                    kraj = dateTimePicker2.Value;
                }
                else
                {
                    kraj = jr1.datumDo;
                }

                DTOManager.UpdateJeRazredi(jr1.jeRazredniId, pocetak, kraj);
                this.osvezi();
                cbxIzmeni.Text = "";
                checkBoxKraj.Checked = false;
                checkBoxPocetak.Checked = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

        }
    }
}