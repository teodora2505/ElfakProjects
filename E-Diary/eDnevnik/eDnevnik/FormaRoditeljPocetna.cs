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
using System.Globalization;

namespace eDnevnik
{
    public partial class FormaRoditeljPocetna : Form
    {
        KorisnikPregled prijavljeniRoditelj { get; set; }

        public FormaRoditeljPocetna()
        {
            InitializeComponent();
        }

        public FormaRoditeljPocetna(KorisnikPregled kp)
        {
            InitializeComponent();
            txtImePrezimeRoditelja.Text = kp.Ime + " " + kp.Prezime;
            prijavljeniRoditelj = kp;
        }

        private void FormaRoditeljPocetna_Load(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = false;
            groupBoxRaspored.Visible = false;
            groupBoxOpravdavanjeCasova.Visible = false;
            groupBoxFunkcija.Visible = false;
            groupBoxPredstavljanje.Visible = false;

            dataGridMojaDeca.Rows.Clear();

            List<UcenikBasics> mojaDeca = new List<UcenikBasics>();
            mojaDeca = DTOManager.GetRoditeljevaDecaInfos(prijavljeniRoditelj.KorisnikId);

            foreach(UcenikBasics dete in mojaDeca)
            {
                OdeljenjeBasic odljenje = DTOManager.GetOdeljenje(dete.OdeljenjeId);
                dataGridMojaDeca.Rows.Add(dete.UcenikId, dete.Ime, dete.Prezime, odljenje.Naziv, odljenje.Smer, dete.BrNeopravdanih, dete.BrOpravdanih);
            }

            FunkcijaPregled fja = DTOManager.GetFunkcijaInfos(prijavljeniRoditelj.KorisnikId);
            if(fja.RoditeljId==prijavljeniRoditelj.KorisnikId)//postoji fja koju vrsi roditelj
            {
                groupBoxFunkcija.Visible = true;
                labelFjaTip.Text = fja.TipFunkcije.ToLower();
                labelFjaPocetak.Text = fja.DatumOd.ToString().Substring(0, 10); ;
                if (fja.DatumDo == null)
                    labelFjaKraj.Text = "   /   ";
                else
                    labelFjaKraj.Text = fja.DatumDo.ToString().Substring(0, 10);
            }

            PredstavljaPregled predstavlja = DTOManager.GetPredstavljaInfos(prijavljeniRoditelj.KorisnikId);
            if(predstavlja.RoditeljId==prijavljeniRoditelj.KorisnikId) //postoji odeljenje koje roditelj predstavlja
            {
                groupBoxPredstavljanje.Visible = true;
                OdeljenjeBasic odeljenje = DTOManager.GetOdeljenje(predstavlja.OdeljenjeId);
                labelPredstavljaOdeljenje.Text = odeljenje.Naziv;
                labelPredtsavljaOdeljenjeSmer.Text= odeljenje.Smer.ToLower();
                labelPredstavljanjePocetak.Text = predstavlja.DatumOd.ToString().Substring(0, 10); ;
                if (predstavlja.DatumDo == null)
                    labelPredstavljanjeKraj.Text = "   /   ";
                else
                    labelPredstavljanjeKraj.Text = predstavlja.DatumDo.ToString().Substring(0,10);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();
        }

        private void dataGridMojaDeca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow d in dataGridMojaDeca.Rows)
            {
                d.Selected = false;
            }
            dataGridMojaDeca.CurrentRow.Selected = true;
        }

        private void btnOcene_Click(object sender, EventArgs e)
        {
            labelOceneUcenikIme.Text = dataGridMojaDeca.CurrentRow.Cells[1].Value.ToString();
            labelOceneUcenikPrezime.Text= dataGridMojaDeca.CurrentRow.Cells[2].Value.ToString();

            dataGridOcene.Rows.Clear();

            groupBoxOcene.Visible = true;
            groupBoxRaspored.Visible = false;
            groupBoxOpravdavanjeCasova.Visible = false;

            int IdUcenika = Convert.ToInt32(dataGridMojaDeca.CurrentRow.Cells[0].Value);

            List<ImaOcenuPregled> ocene = DTOManager.GetUcenikoveOcene(IdUcenika);

            foreach(ImaOcenuPregled imaO in ocene)
            {
                PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(imaO.PredmetId);
                if(imaO.TipOcene=="BROJCANA")
                {
                    dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene, imaO.Vrednost);
                }
                else if(imaO.TipOcene=="OPISNA")
                {
                    dataGridOcene.Rows.Add(imaO.ImaOcenuId, predmet.Naziv, imaO.TipOcene, imaO.Opis);
                }
               
            }
           
        }

        private void btnRasporedCasova_Click(object sender, EventArgs e)
        {
            groupBoxOcene.Visible = false;
            groupBoxOpravdavanjeCasova.Visible = false;
            groupBoxRaspored.Visible = true;

            dataGridRaspored.Rows.Clear();

            OdeljenjeBasic odeljenje = DTOManager.GetOdeljenjeNaziv(dataGridMojaDeca.CurrentRow.Cells[3].Value.ToString());

            labelRasporedOdeljenje.Text = dataGridMojaDeca.CurrentRow.Cells[3].Value.ToString();
            labelRasporedSmer.Text= dataGridMojaDeca.CurrentRow.Cells[4].Value.ToString().ToLower();

            List<RasporedPregled> raspored = DTOManager.GetRasporedOdeljenjaInfos(odeljenje.OdeljenjeId);

            int maxCasova = 0;

            foreach(RasporedPregled r in raspored) //da bi nasli maximalni broj casova
            {
                if (r.Cas > maxCasova)
                    maxCasova = r.Cas;
            }

            for(int i=0; i<maxCasova;i++)
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
                if(r.Dan=="PONEDELJAK") // 0. kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[0].Value = predmet.Naziv;
                }
                else if(r.Dan=="UTORAK")//1.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[1].Value = predmet.Naziv;
                }
                else if(r.Dan=="SREDA")//2.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[2].Value = predmet.Naziv;
                }
                else if(r.Dan=="CETVRTAK")//3.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[3].Value = predmet.Naziv;
                }
                else if(r.Dan=="PETAK")//4.kolona
                {
                    PredmetBasic predmet = DTOManager.GetPredmetBasicInfo(r.PredmetId);
                    dataGridRaspored.Rows[r.Cas - 1].Cells[4].Value = predmet.Naziv;
                }
            }

          
        }

        private void btnOpravdajCasove_Click(object sender, EventArgs e)
        {
            groupBoxOpravdavanjeCasova.Visible = true;
            groupBoxOcene.Visible = false;
            groupBoxRaspored.Visible = false;
            numericUpDownBrojCasova.Maximum = Convert.ToInt32(dataGridMojaDeca.CurrentRow.Cells[5].Value);
            labelOpravdajIme.Text = dataGridMojaDeca.CurrentRow.Cells[1].Value.ToString();
            labelOpravdajPrezime.Text = dataGridMojaDeca.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonOpavdajCasoveUceniku_Click(object sender, EventArgs e)
        {
            int UcenikId = Convert.ToInt32(dataGridMojaDeca.CurrentRow.Cells[0].Value);

            int brojCasova = Convert.ToInt32(numericUpDownBrojCasova.Value);

  
            DTOManager.UpdateUcenikSmanjiNeopravdane(UcenikId, brojCasova);
            DTOManager.UpdateUcenikPovecajOpravdane(UcenikId, brojCasova);

            groupBoxOpravdavanjeCasova.Visible = false;

            dataGridMojaDeca.Rows.Clear();

            List<UcenikBasics> mojaDeca = new List<UcenikBasics>();
            mojaDeca = DTOManager.GetRoditeljevaDecaInfos(prijavljeniRoditelj.KorisnikId);

            foreach (UcenikBasics dete in mojaDeca)
            {
                OdeljenjeBasic odljenje = DTOManager.GetOdeljenje(dete.OdeljenjeId);
                dataGridMojaDeca.Rows.Add(dete.UcenikId, dete.Ime, dete.Prezime, odljenje.Naziv, odljenje.Smer, dete.BrNeopravdanih, dete.BrOpravdanih);
            }

        }
    }
}
