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
    public partial class FormaPredmeti : Form
    {
        public FormaPredmeti()
        {
            InitializeComponent();
        }

        private void FormaPredmeti_Load(object sender, EventArgs e)
        {
            this.osvezi();
        }

        public void osvezi()
        {
            dataGridPredmeti.Rows.Clear();

            foreach(PredmetBasic p in DTOManager.GetSviPredmeti())
            {
                if (p.MinBrUcenika != 0 )
                     dataGridPredmeti.Rows.Add(p.PredmetId, p.Naziv, p.Opis, p.BrojCasvoa, p.TipPredmeta.ToLower(), p.MinBrUcenika, p.BlokNastava.ToLower(), p.SpecijalniKabinet.ToLower());
                else
                    dataGridPredmeti.Rows.Add(p.PredmetId, p.Naziv, p.Opis, p.BrojCasvoa, p.TipPredmeta.ToLower(),"", p.BlokNastava.ToLower(), p.SpecijalniKabinet.ToLower());

            }

            dataGridPredmeti.ClearSelection();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            FormaDodajPredmet formica = new FormaDodajPredmet(null);
            formica.ShowDialog();

            this.osvezi();
        }

        private void dataGridPredmeti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridPredmeti.CurrentRow.Selected = true;
        }

        private void btnUkloniPredmet_Click(object sender, EventArgs e)
        {
            if(dataGridPredmeti.CurrentRow.Selected==true)
            {
                DTOManager.DeletePredmet(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value));
                this.osvezi();
            }
        }

        private void btnIzmeniPredmet_Click(object sender, EventArgs e)
        {

            FormaDodajPredmet formica = new FormaDodajPredmet(DTOManager.GetPredmetBasicInfo(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value)));
            formica.ShowDialog();

            this.osvezi();
        }

        private void btnSpisakPredavaca_Click(object sender, EventArgs e)
        {
            if (dataGridPredmeti.CurrentRow.Selected == true)
            {
                groupBoxSpisakPredavaca.Visible = true;

                dataGridPredavaci.Rows.Clear();
                cbxDodajPredavaca.Items.Clear();
                cbxUkloniPredavaca.Items.Clear();

                labelPredmet.Text = dataGridPredmeti.CurrentRow.Cells[1].Value.ToString() + ", " + dataGridPredmeti.CurrentRow.Cells[2].Value.ToString();

                foreach (KorisnikExtended korisnik in DTOManager.GetPredavaciPredmeta(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value)))
                {
                    dataGridPredavaci.Rows.Add(korisnik.KorisnikId, korisnik.Ime, korisnik.Prezime);
                    cbxUkloniPredavaca.Items.Add(korisnik.Ime + " " + korisnik.Prezime);
                }

                foreach(KorisnikExtended nastavnik in DTOManager.GetNastavniciNePredajuPredmet(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value)))
                {
                    cbxDodajPredavaca.Items.Add(nastavnik.Ime + " " + nastavnik.Prezime);
                }
            }
        }

        private void btnDodajPredavaca_Click(object sender, EventArgs e)
        {
            if(cbxDodajPredavaca.SelectedIndex>-1)
            {
                KorisnikExtended nastavnik = DTOManager.GetKorisnikImePrezime(cbxDodajPredavaca.SelectedItem.ToString());

                DTOManager.savePredaje(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value), nastavnik.KorisnikId);

            }

            btnSpisakPredavaca_Click(sender, e);
            cbxDodajPredavaca.Text = "";
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if(cbxUkloniPredavaca.SelectedIndex > -1)
            {
                KorisnikExtended nastavnik = DTOManager.GetKorisnikImePrezime(cbxUkloniPredavaca.SelectedItem.ToString());

                DTOManager.deletePredaje(Convert.ToInt32(dataGridPredmeti.CurrentRow.Cells[0].Value), nastavnik.KorisnikId);

            }

            btnSpisakPredavaca_Click(sender, e);
            cbxUkloniPredavaca.Text = "";
        }
    }
}
