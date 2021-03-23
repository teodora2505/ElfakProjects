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
    public partial class FormaUcenikPocetna : Form
    {
        public KorisnikPregled prijavljeniUcenik { get; set; }
        public FormaUcenikPocetna()
        {
            InitializeComponent();
        }

        public FormaUcenikPocetna(KorisnikPregled kp)
        {
            InitializeComponent();
            txtImePrezimeUcenika.Text = kp.Ime + " " + kp.Prezime;
            prijavljeniUcenik = kp;
        }

        private void FormaUcenikPocetna_Load(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = false;
            groupBoxRaspored.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();
            
           
        }

        private void btnOcene_Click(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = true;
            groupBoxRaspored.Visible = false;
            labelOceneUcenikIme.Text = prijavljeniUcenik.Ime;
            labelOceneUcenikPrezime.Text = prijavljeniUcenik.Prezime;
            List<ImaOcenuPregled> ocene = DTOManager.GetUcenikoveOcene(prijavljeniUcenik.KorisnikId);
            foreach (ImaOcenuPregled imaO in ocene)
            {
                PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(imaO.PredmetId);
                if (imaO.TipOcene == "BROJCANA")
                {
                    dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene, imaO.Vrednost);
                }
                else if (imaO.TipOcene == "OPISNA")
                {
                    dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene, imaO.Opis);
                }

            }
        }

        private void btnRasporedCasova_Click(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = false;
            groupBoxRaspored.Visible = true;
            dataGridRaspored.Rows.Clear();

            UcenikBasics u = DTOManager.GetUcenikInfos(prijavljeniUcenik.KorisnikId);
            OdeljenjeBasic o = DTOManager.GetOdeljenje(u.OdeljenjeId);

            labelRasporedOdeljenje.Text =o.Naziv;
            labelRasporedSmer.Text = o.Smer.ToLower();

            List<RasporedPregled> raspored = DTOManager.GetRasporedOdeljenjaInfos(o.OdeljenjeId);

            int maxCasova = 0;

            foreach (RasporedPregled r in raspored) //da bi nasli maximalni broj casova
            {
                if (r.Cas > maxCasova)
                    maxCasova = r.Cas;
            }

            for (int i = 0; i < maxCasova; i++)
            {
                dataGridRaspored.Rows.Add();
            }

            //da bi dodali redne brojeve casova u rowHeaderu 1. 2. 3. 4. 5. ...
            foreach (DataGridViewRow row in dataGridRaspored.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            foreach (RasporedPregled r in raspored)
            {
                if (r.Dan == "PONEDELJAK") // 0. kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[0].Value = predmet.Naziv;
                }
                else if (r.Dan == "UTORAK")//1.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[1].Value = predmet.Naziv;
                }
                else if (r.Dan == "SREDA")//2.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[2].Value = predmet.Naziv;
                }
                else if (r.Dan == "CETVRTAK")//3.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[3].Value = predmet.Naziv;
                }
                else if (r.Dan == "PETAK")//4.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[4].Value = predmet.Naziv;
                }
            }

        }
    }
}
