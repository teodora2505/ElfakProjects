using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using eDnevnik.Entiteti;
using NHibernate.Linq;


namespace eDnevnik
{
    public partial class FormaNastavnikPocetna : Form
    {
        public KorisnikPregled prijavljeniNastavnik {get;set;}

        public FormaNastavnikPocetna()
        {
            InitializeComponent();
        }

        public FormaNastavnikPocetna(KorisnikPregled kp)
        {
       
            InitializeComponent();
            txtImePrezimeNastavnika.Text = kp.Ime+" "+kp.Prezime;
            prijavljeniNastavnik = kp;
        }

        private void FormaNastavnikPocetna_Load(object sender, EventArgs e)
        {
            dataGridMojaOdeljenja.Visible = false;
            dataGridPredmeti.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) //Odjava 
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();
        }

        private void btnMojiPredmeti_Click(object sender, EventArgs e)
        {
            dataGridPredmeti.Visible = true;
            dataGridMojaOdeljenja.Visible = false;
            dataGridPredmeti.Rows.Clear();

            List<PredmetBasic> predmeti = DTOManager.GetPredmetiInfos(this.prijavljeniNastavnik.KorisnikId);
            foreach (PredmetBasic p in predmeti)
            {
                dataGridPredmeti.Rows.Add(p.PredmetId, p.Naziv, p.Opis, p.BrojCasvoa, p.TipPredmeta.ToLower(), p.MinBrUcenika, p.BlokNastava.ToLower(), p.SpecijalniKabinet.ToLower());
            }
            dataGridPredmeti.Refresh();
        }

        private void btnMojaOdeljenja_Click(object sender, EventArgs e)
        {
            dataGridMojaOdeljenja.Visible = true;
            dataGridPredmeti.Visible = false;
            dataGridMojaOdeljenja.Rows.Clear();

            List<OdeljenjeBasic> odeljenja = DTOManager.GetOdeljenjeInfos(this.prijavljeniNastavnik.KorisnikId);
            foreach (OdeljenjeBasic o in odeljenja)
            {
                dataGridMojaOdeljenja.Rows.Add(o.OdeljenjeId, o.Naziv, o.Smer.ToLower());
            }
            dataGridMojaOdeljenja.Refresh();
        }

        private void dataGridMojaOdeljenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow d in dataGridMojaOdeljenja.Rows)
            {
                d.Selected = false;
            }
           dataGridMojaOdeljenja.CurrentRow.Selected = true;

            OdeljenjeBasic odeljenje = DTOManager.GetOdeljenje(Convert.ToInt32(dataGridMojaOdeljenja.CurrentRow.Cells[0].Value));
            List<PredmetBasic> predmeti = DTOManager.GetNastavnikOdeljenjuDrziPredmet(prijavljeniNastavnik.KorisnikId, odeljenje.OdeljenjeId);

            FormaNastavnikovoOdeljenje forma = new FormaNastavnikovoOdeljenje(odeljenje,predmeti);
            forma.BringToFront();
            forma.Show();
           
        }
    }
}
