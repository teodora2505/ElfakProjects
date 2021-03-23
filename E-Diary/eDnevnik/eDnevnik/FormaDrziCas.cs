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
    public partial class FormaDrziCas : Form
    {
        public FormaDrziCas()
        {
            InitializeComponent();
        }

        private void FormaDrziCas_Load(object sender, EventArgs e)
        {
            this.osvezi();

            List<KorisnikExtended> nastavnici = DTOManager.GetKorisnici();
            cbxDodajNastavnikId.Items.Clear();
            cbxDodajOdeljenjeId.Items.Clear();
            foreach(KorisnikExtended kor in nastavnici)
            {
                if (kor.FNastavnik == 1)
                    cbxDodajNastavnikId.Items.Add(kor.KorisnikId);
            }

            List<OdeljenjeBasic> odeljenja = DTOManager.GetSvaOdeljenja();
            foreach(OdeljenjeBasic odelj in odeljenja)
            {
                cbxDodajOdeljenjeId.Items.Add(odelj.OdeljenjeId);
            }
        }

        public void osvezi()
        {
            dataGridDrziCas.Rows.Clear();

            foreach(DrziCasPregled drzi in DTOManager.GetDrziCas())
            {
                KorisnikExtended nastavnik = DTOManager.GetKorisnikPregledInfos(drzi.NastavnikId);
                OdeljenjeBasic odeljenje = DTOManager.GetOdeljenje(drzi.OdeljenjeId);
                PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(drzi.PredmetId);
                dataGridDrziCas.Rows.Add(drzi.DrziCasid, nastavnik.KorisnikId,nastavnik.Ime + " " + nastavnik.Prezime, odeljenje.OdeljenjeId,odeljenje.Naziv,predmet.PredmetId, predmet.Naziv);
            }

            dataGridDrziCas.ClearSelection();

        }

        private void dataGridDrziCas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridDrziCas.CurrentRow.Selected = true;
        }

        private void cbxDodajNastavnikId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDodajOdeljenjeId.SelectedIndex>-1 && cbxDodajNastavnikId.SelectedIndex>-1)
            {
                cbxDodajPredmetId.Enabled = true;
                cbxDodajPredmetId.Items.Clear();
                foreach (PredmetBasic p in DTOManager.GetNastavnikoviPredmetiKojeNeDrziOdeljenju(Convert.ToInt32(cbxDodajNastavnikId.SelectedItem.ToString()), Convert.ToInt32(cbxDodajOdeljenjeId.SelectedItem.ToString())))
                {
                    cbxDodajPredmetId.Items.Add(p.PredmetId);
                }
            }
        }

        private void cbxDodajOdeljenjeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDodajOdeljenjeId.SelectedIndex > -1 && cbxDodajNastavnikId.SelectedIndex > -1)
            {
                cbxDodajPredmetId.Enabled = true;
                cbxDodajPredmetId.Items.Clear();
                foreach (PredmetBasic p in DTOManager.GetNastavnikoviPredmetiKojeNeDrziOdeljenju(Convert.ToInt32(cbxDodajNastavnikId.SelectedItem.ToString()), Convert.ToInt32(cbxDodajOdeljenjeId.SelectedItem.ToString())))
                {
                    cbxDodajPredmetId.Items.Add(p.PredmetId);
                }
            }
        }

        private void btnDodajPredstavnika_Click(object sender, EventArgs e)
        {
            int nastavnikId = Convert.ToInt32(cbxDodajNastavnikId.SelectedItem.ToString());
            int odeljenjeId = Convert.ToInt32(cbxDodajOdeljenjeId.SelectedItem.ToString());
            int predmetId = Convert.ToInt32(cbxDodajPredmetId.SelectedItem.ToString());

            DTOManager.SaveDrziCas(nastavnikId, odeljenjeId, predmetId);
            cbxDodajOdeljenjeId.Text = "";
            cbxDodajNastavnikId.Text = "";
            cbxDodajPredmetId.Text = "";
            cbxDodajPredmetId.Enabled = false;
            this.osvezi();

        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if(dataGridDrziCas.CurrentRow.Selected==true)
            {
                DTOManager.deleteDrziCas(Convert.ToInt32(dataGridDrziCas.CurrentRow.Cells[0].Value));
                this.osvezi();
            }
        }
    }
}
