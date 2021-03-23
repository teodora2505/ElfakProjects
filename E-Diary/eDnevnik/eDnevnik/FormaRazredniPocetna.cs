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
    public partial class FormaRazredniPocetna : Form
    {
        public KorisnikPregled prijavljeniKorisnik { get; set; }
        public OdeljenjeBasic OdeljenjeRazrednogStaresine { get; set; }
        public List<UcenikBasics> mojiUcenici { get; set; }

        public FormaRazredniPocetna()
        {
            InitializeComponent();
        }

        public FormaRazredniPocetna(KorisnikPregled kp)
        {
            InitializeComponent();
            prijavljeniKorisnik = kp;
        }

        private void FormaRazredniPocetna_Load(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = false;

            labelImePrezimeRazrednog.Text = prijavljeniKorisnik.Ime + " " + prijavljeniKorisnik.Prezime;
            OdeljenjeRazrednogStaresine = DTOManager.OdeljenjeRazrednogStaresineInfos(prijavljeniKorisnik.KorisnikId);
            List<UcenikBasics> ucenici = DTOManager.GetUceniciOdeljenja(OdeljenjeRazrednogStaresine.OdeljenjeId);
            mojiUcenici = ucenici;

            labelMojeOdeljenjeNaziv.Text = OdeljenjeRazrednogStaresine.Naziv;
            labelMojeOdeljenjeSmer.Text = OdeljenjeRazrednogStaresine.Smer.ToLower();
            dataGridMojiUcenici.Rows.Clear();
            foreach(UcenikBasics u in mojiUcenici)
            {
                dataGridMojiUcenici.Rows.Add(u.UcenikId, u.Ime, u.Prezime, u.BrOpravdanih, u.BrNeopravdanih, DTOManager.GetUcenikInfos(u.UcenikId).OcenaVladanje);
            }

            foreach (DataGridViewRow row in dataGridMojiUcenici.Rows)
            {
                row.Selected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();
        }

        private void dataGridMojiUcenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridMojiUcenici.Rows)
            {
                row.Selected = false;
            }
            dataGridMojiUcenici.CurrentRow.Selected = true;
        }

        private void btnDodajUcenika_Click(object sender, EventArgs e)
        {
            FormaNoviUčenik formica = new FormaNoviUčenik(OdeljenjeRazrednogStaresine,false,-1);
            formica.ShowDialog();
            this.FormaRazredniPocetna_Load(sender, e);

        }

        private void btnUkloniUcenika_Click(object sender, EventArgs e)
        {
            if(dataGridMojiUcenici.CurrentRow.Selected==true)
            {
                DTOManager.brisiUcenika(Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[0].Value));
                this.FormaRazredniPocetna_Load(sender, e);
            }
        }

        private void btnIzmeniUcenika_Click(object sender, EventArgs e)
        {
            FormaNoviUčenik formica = new FormaNoviUčenik(OdeljenjeRazrednogStaresine,true,Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[0].Value));
            formica.ShowDialog();
            this.FormaRazredniPocetna_Load(sender, e);
        }

        private void dataGridMojiUcenici_SelectionChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[4].Value);
        }

        private void btnOpravdajCasove_Click(object sender, EventArgs e)
        {
            if(dataGridMojiUcenici.CurrentRow.Selected==true)
            {
                DTOManager.UpdateUcenikSmanjiNeopravdane(Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[0].Value),Convert.ToInt32(numericUpDown1.Value));
                DTOManager.UpdateUcenikPovecajOpravdane(Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[0].Value), Convert.ToInt32(numericUpDown1.Value));
                this.FormaRazredniPocetna_Load(sender, e);
            }
        }

        private void btnPregledOcena_Click(object sender, EventArgs e)
        {
            if (dataGridMojiUcenici.CurrentRow.Selected)
            {
                groupBoxOcene.Visible = true;
                dataGridOcene.Rows.Clear();

                labelOceneUcenikIme.Text = dataGridMojiUcenici.CurrentRow.Cells[1].Value.ToString();
                labelOceneUcenikPrezime.Text = dataGridMojiUcenici.CurrentRow.Cells[2].Value.ToString();

                int IdUcenika = Convert.ToInt32(dataGridMojiUcenici.CurrentRow.Cells[0].Value);

                List<ImaOcenuPregled> ocene = DTOManager.GetUcenikoveOcene(IdUcenika);

                foreach (ImaOcenuPregled imaO in ocene)
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(imaO.PredmetId);
                    if (imaO.TipOcene == "BROJCANA")
                    {
                        dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene.ToLower(), imaO.Vrednost);
                    }
                    else if (imaO.TipOcene == "OPISNA")
                    {
                        dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene.ToLower(), imaO.Opis);
                    }

                }

                dataGridOcene.Rows.Add("/", "Vladanje", "brojcana", DTOManager.GetUcenikInfos(IdUcenika).OcenaVladanje);


            }
        }

        private void btnRasporedCasova_Click(object sender, EventArgs e)
        {
            FormaRasporedCasova formica = new FormaRasporedCasova(OdeljenjeRazrednogStaresine);
            formica.ShowDialog();
        }
    }
}
