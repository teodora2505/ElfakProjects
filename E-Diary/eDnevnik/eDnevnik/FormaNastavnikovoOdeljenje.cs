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
    public partial class FormaNastavnikovoOdeljenje : Form
    {
        OdeljenjeBasic odeljenje { get; set; }
        List<PredmetBasic> predmetiKojeNastavnikDrziOdeljenju { get; set; }
        UcenikBasics izabraniUcenik { get; set; }
        PredmetBasic izabraniPredmet { get; set; }
        int BrojSekundeTimera { get; set; } = 0;

        public FormaNastavnikovoOdeljenje()
        {
            InitializeComponent();
        }

        public FormaNastavnikovoOdeljenje(OdeljenjeBasic IzabranoOdeljenje, List<PredmetBasic> predmeti)
        {
            InitializeComponent();
            odeljenje = IzabranoOdeljenje;
            predmetiKojeNastavnikDrziOdeljenju = new List<PredmetBasic>();
            predmetiKojeNastavnikDrziOdeljenju = predmeti;
        }

        private void NastavnikovoOdeljenje_Load(object sender, EventArgs e)
        {
            groupBoxIzabraniUcenik.Visible = false;
            labelObavestenje.Visible = false;

            labelOdeljenjeNaziv.Text += odeljenje.Naziv;
            labelOdeljenjeSmer.Text += odeljenje.Smer.ToLower();

            cbxPredajemPredmete.Items.Clear();

            foreach(PredmetBasic p in predmetiKojeNastavnikDrziOdeljenju)
            {
                cbxPredajemPredmete.Items.Add(p.Naziv);
            }

            List<UcenikBasics> uceniciOdeljenja = DTOManager.GetUceniciOdeljenja(odeljenje.OdeljenjeId);
            cbxUceniciOdeljenja.Items.Clear();
            dataGridOdsutniUcenici.Rows.Clear();

            foreach (UcenikBasics u in uceniciOdeljenja)
            {
                cbxUceniciOdeljenja.Items.Add(u.Ime + " " + u.Prezime);
                dataGridOdsutniUcenici.Rows.Add(u.UcenikId, u.Ime, u.Prezime,u.BrNeopravdanih);
            }

           


        }

        private void btnPodaciUcenika_Click(object sender, EventArgs e)
        {

            if (cbxPredajemPredmete.SelectedIndex >= 0 && cbxUceniciOdeljenja.SelectedIndex >= 0)
            {
                groupBoxIzabraniUcenik.Visible = true;
                dataGridOceneUcenika.Visible = true;
                dataGridOceneUcenika.BringToFront();
                groupBoxDodajOcenu.Visible = false;
                groupBoxUkloniOcenu.Visible = false;
                groupBoxIzmeniOcenu.Visible = false;

                string ucenikImePrezime = cbxUceniciOdeljenja.SelectedItem.ToString();

                foreach(UcenikBasics u in DTOManager.GetUceniciOdeljenja(odeljenje.OdeljenjeId))
                {
                    if(u.Ime+" "+u.Prezime==ucenikImePrezime)
                    {
                        labelIzabraniUcenikIme.Text = u.Ime;
                        labelIzabraniUcenikPrezime.Text= u.Prezime;
                        labelIzabraniUcnikOdeljenje.Text = odeljenje.Naziv;
                        labelIzabraniUcenikOpravdani.Text = u.BrOpravdanih.ToString();
                        labelIzabraniUcenikNeopravdani.Text = u.BrNeopravdanih.ToString();
                        labelIzabraniUcenikPredmet.Text = cbxPredajemPredmete.SelectedItem.ToString();
                        izabraniUcenik = u;

                        foreach(PredmetBasic p in predmetiKojeNastavnikDrziOdeljenju)
                        {
                            if (p.Naziv == cbxPredajemPredmete.SelectedItem.ToString())
                                izabraniPredmet = p;
                        }

                        dataGridOceneUcenika.Rows.Clear();

                        List<ImaOcenuPregled> oceneUcenika = DTOManager.GetOcenaPredmetInfo(u.UcenikId, izabraniPredmet.PredmetId);
                        foreach(ImaOcenuPregled ocena in oceneUcenika)
                        {
                            if(ocena.TipOcene=="BROJCANA")
                            {
                                dataGridOceneUcenika.Rows.Add(ocena.ImaOcenuId, ocena.TipOcene, ocena.Vrednost);
                            }
                            else if(ocena.TipOcene=="OPISNA")
                            {
                                dataGridOceneUcenika.Rows.Add(ocena.ImaOcenuId, ocena.TipOcene, ocena.Opis);
                            }
                        }
                    }
                }
            }
            else
            {
                timer1.Start();
                labelObavestenje.Text = "Potrebno je izabrati predmet i učenika.";

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BrojSekundeTimera++;
            labelObavestenje.Visible = true;

            if(BrojSekundeTimera==3)
            {
                labelObavestenje.Visible = false;
                BrojSekundeTimera = 0;
                timer1.Stop();
            }
        }

        private void btnOpcijaDodajOcenu_Click(object sender, EventArgs e)
        {
            dataGridOceneUcenika.Visible = false;
            groupBoxIzmeniOcenu.Visible = false;
            groupBoxUkloniOcenu.Visible = false;
            groupBoxDodajOcenu.Visible = true;
            groupBoxDodajOcenu.BringToFront();
        }

        private void btnOpcijaUkloniOcenu_Click(object sender, EventArgs e)
        {
            dataGridOceneUcenika.Visible = false;
            groupBoxDodajOcenu.Visible = false;
            groupBoxIzmeniOcenu.Visible = false;
            groupBoxUkloniOcenu.Visible = true;
            groupBoxUkloniOcenu.BringToFront();
        }

        private void btnOpcijaIzmeniOcenu_Click(object sender, EventArgs e)
        {
            if (dataGridOceneUcenika.SelectedRows.Count == 1)
            {
                labelOcenaIdKojaSeMenja.Text = dataGridOceneUcenika.CurrentRow.Cells[0].Value.ToString();
                dataGridOceneUcenika.Visible = false;
                groupBoxDodajOcenu.Visible = false;
                groupBoxUkloniOcenu.Visible = false;
                groupBoxIzmeniOcenu.Visible = true;
                groupBoxIzmeniOcenu.BringToFront();
             
            }
            else
            {
                labelObavestenje.Text= "Neophodno je da izaberete opciju koju menjate.";
                timer1.Start();
            }
        }

        private void btnOpcijaPodaci_Click(object sender, EventArgs e)
        {
            btnPodaciUcenika_Click(sender, e);
        }


        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {
            if(cbxDodajTipOcene.SelectedIndex==0)//brojcana ocena
            {
                int ocena = Convert.ToInt32(txtOcena.Text);
                if(ocena>=1 && ocena <=5)
                    DTOManager.SaveImaOcenu(izabraniUcenik.UcenikId, izabraniPredmet.PredmetId, "BROJCANA", txtOcena.Text);
            }
            else if(cbxDodajTipOcene.SelectedIndex==1)//opisna ocena
            {
                string opis = txtOcena.Text;
                DTOManager.SaveImaOcenu(izabraniUcenik.UcenikId, izabraniPredmet.PredmetId, "OPISNA", opis);
            }

            btnPodaciUcenika_Click(sender, e);
        }

        private void btnIzmeniOcenu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtIzmenjenaOcena.Text))
             DTOManager.UpdateImaOcenu(Convert.ToInt32(dataGridOceneUcenika.CurrentRow.Cells[0].Value),dataGridOceneUcenika.CurrentRow.Cells[1].Value.ToString(), txtIzmenjenaOcena.Text);

            btnPodaciUcenika_Click(sender, e);
        }

        private void btnUkloniOcenu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUkloniOcenuId.Text))
            {
                DTOManager.brisiImaOcenu(Convert.ToInt32(txtUkloniOcenuId.Text));
            }

            btnPodaciUcenika_Click(sender, e);
        }

        private void dataGridOceneUcenika_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow d in dataGridOceneUcenika.Rows)
            {
                d.Selected = false;
            }
            dataGridOceneUcenika.CurrentRow.Selected = true;
        }

        private void btnUpisOdsutnih_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow d in dataGridOdsutniUcenici.Rows)
            {
                if(Convert.ToBoolean(d.Cells[4].Value))//znaci da je cekiran ucekin u tom redu kao odsutan ucenik
                {
                    DTOManager.UpdateUcenikPovecajNeopravdane(Convert.ToInt32(d.Cells[0].Value));
                }
            }

            List<UcenikBasics> uceniciOdeljenja = DTOManager.GetUceniciOdeljenja(odeljenje.OdeljenjeId);
            dataGridOdsutniUcenici.Rows.Clear();

            foreach (UcenikBasics u in uceniciOdeljenja)
            {

                dataGridOdsutniUcenici.Rows.Add(u.UcenikId, u.Ime, u.Prezime, u.BrNeopravdanih,false);
            }
        }
    }
}
