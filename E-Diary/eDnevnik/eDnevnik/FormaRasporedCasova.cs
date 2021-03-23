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
    public partial class FormaRasporedCasova : Form
    {
        public OdeljenjeBasic odeljenje { get; set; }

        public FormaRasporedCasova()
        {
            InitializeComponent();
        }

        public FormaRasporedCasova(OdeljenjeBasic odelj)
        {
            InitializeComponent();
            odeljenje = odelj;
        }

        private void FormaRasporedCasova_Load(object sender, EventArgs e)
        {
            groupBoxRaspored.Visible = true;
            groupBoxDodavanjeCasa.Visible = false;

            dataGridRaspored.Rows.Clear();

            labelRasporedOdeljenje.Text = odeljenje.Naziv;
            labelRasporedSmer.Text = odeljenje.Smer.ToLower();

            List<RasporedPregled> raspored = DTOManager.GetRasporedOdeljenjaInfos(odeljenje.OdeljenjeId);

            for (int i = 0; i <=5; i++)
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

          foreach(DataGridViewRow row in dataGridRaspored.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnDodajCasOpcija_Click(object sender, EventArgs e)
        {
            groupBoxDodavanjeCasa.Visible = true;
            groupBoxDodavanjeCasa.Text = "Dodavanje časa:";
            btnDodajCas.Text = "Dodaj čas";
            cbxBrojCasa.Enabled = false;

            List<PredmetBasic> OdeljenskiPredmeti = DTOManager.GetOdeljenskiPredmeti(odeljenje.OdeljenjeId);

            cbxPredmeti.Items.Clear();

            foreach(PredmetBasic p in OdeljenskiPredmeti)
            {
                cbxPredmeti.Items.Add(p.Naziv);
            }

        }

        private void cbxDani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBrojCasa.Enabled = true;

            List<bool> slobodniCasovi = new List<bool>();

            for(int i=0; i<7; i++)
            {
                slobodniCasovi.Add(false);
            }

            foreach(DataGridViewRow row in dataGridRaspored.Rows)
            {
                if(row.Cells[cbxDani.SelectedIndex].Value == null)
                {
                    slobodniCasovi[row.Index] = true;
                }
          
            }

            cbxBrojCasa.Items.Clear();
            for(int i=0; i<7; i++)
            {
                if (slobodniCasovi[i] == true)
                    cbxBrojCasa.Items.Add(i + 1);
            }
            cbxBrojCasa.Text = "";
        }

        private void btnDodajCas_Click(object sender, EventArgs e)
        {
            if (btnDodajCas.Text == "Dodaj čas")
            {
                if (cbxPredmeti.SelectedIndex > -1 && cbxDani.SelectedIndex > -1 && cbxBrojCasa.SelectedIndex > -1)
                {
                    int brojCasa = Convert.ToInt32(cbxBrojCasa.SelectedItem);
                    string dan = cbxDani.SelectedItem.ToString().ToUpper();
                    string predmet = cbxPredmeti.SelectedItem.ToString();

                    RasporedPregled ras = new RasporedPregled();
                    ras.Cas = brojCasa;
                    ras.Dan = dan;
                    ras.PredmetId = DTOManager.GetPredmetNaziv(predmet).PredmetId;
                    ras.OdeljenjeId = odeljenje.OdeljenjeId;

                    DTOManager.SaveRaspored(ras);

                    this.FormaRasporedCasova_Load(sender, e);
                }
            }
            else if (btnDodajCas.Text=="Izmeni čas")
            {
                if (cbxPredmeti.SelectedIndex > -1 && cbxDani.SelectedIndex > -1 && cbxBrojCasa.SelectedIndex > -1)
                {
                    int brojCasa = Convert.ToInt32(cbxBrojCasa.SelectedItem);
                    string dan = cbxDani.SelectedItem.ToString().ToUpper();
                    string predmet = cbxPredmeti.SelectedItem.ToString();

                    RasporedPregled ras = new RasporedPregled();
                    ras.Cas = brojCasa;
                    ras.Dan = dan;
                    ras.PredmetId = DTOManager.GetPredmetNaziv(predmet).PredmetId;
                    ras.OdeljenjeId = odeljenje.OdeljenjeId;

                    int brojCasaKojiSeMenja = Convert.ToInt32(dataGridRaspored.CurrentCell.RowIndex + 1);
                    string danKojiSeMenja = "";
                    switch (dataGridRaspored.CurrentCell.ColumnIndex)
                    {
                        case 0:
                            danKojiSeMenja = "PONEDELJAK";
                            break;
                        case 1:
                            danKojiSeMenja = "UTORAK";
                            break;
                        case 2:
                            danKojiSeMenja = "SREDA";
                            break;
                        case 3:
                            danKojiSeMenja = "CETVRTAK";
                            break;
                        case 4:
                            danKojiSeMenja = "PETAK";
                            break;
                    }

                    DTOManager.UpdateRaspored(DTOManager.GetRasporedDanCasOdeljenje(brojCasaKojiSeMenja, danKojiSeMenja, odeljenje.OdeljenjeId).RasporedId, ras);

                    this.FormaRasporedCasova_Load(sender, e);
                }
            }
               

        }

        private void btnUkloniCasOpcija_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sigurno želite da uklonite izabrani čas?", "Uklanjanje časa iz rasporeda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridRaspored.CurrentCell.Selected == true)
                {
                    int brojCasa = dataGridRaspored.CurrentCell.RowIndex + 1;
                    string dan = "";
                    switch (dataGridRaspored.CurrentCell.ColumnIndex)
                    {
                        case 0:
                            dan = "PONEDELJAK";
                            break;
                        case 1:
                            dan = "UTORAK";
                            break;
                        case 2:
                            dan = "SREDA";
                            break;
                        case 3:
                            dan = "CETVRTAK";
                            break;
                        case 4:
                            dan = "PETAK";
                            break;
                    }

                    RasporedPregled ras = DTOManager.GetRasporedDanCasOdeljenje(brojCasa, dan, odeljenje.OdeljenjeId);

                    DTOManager.brisiRaspored(ras.RasporedId);

                    this.FormaRasporedCasova_Load(sender, e);

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btnIzmeniCasOpcija_Click(object sender, EventArgs e)
        {
            if(dataGridRaspored.CurrentCell.Selected==true)
            {
                groupBoxDodavanjeCasa.Visible = true;
                groupBoxDodavanjeCasa.Text = "Izmena časa:";
                btnDodajCas.Text = "Izmeni čas";


                List<PredmetBasic> OdeljenskiPredmeti = DTOManager.GetOdeljenskiPredmeti(odeljenje.OdeljenjeId);

                cbxPredmeti.Items.Clear();

                foreach (PredmetBasic p in OdeljenskiPredmeti)
                {
                    cbxPredmeti.Items.Add(p.Naziv);
                }

                int brojCasa = dataGridRaspored.CurrentCell.RowIndex + 1;

                string dan = "";
                switch (dataGridRaspored.CurrentCell.ColumnIndex)
                {
                    case 0:
                        dan = "PONEDELJAK";
                        break;
                    case 1:
                        dan = "UTORAK";
                        break;
                    case 2:
                        dan = "SREDA";
                        break;
                    case 3:
                        dan = "CETVRTAK";
                        break;
                    case 4:
                        dan = "PETAK";
                        break;
                }

                cbxPredmeti.SelectedIndex = cbxPredmeti.FindStringExact(dataGridRaspored.CurrentCell.Value.ToString());
                cbxDani.SelectedIndex = cbxDani.FindStringExact(dan);
                cbxBrojCasa.Items.Add(brojCasa);
                cbxBrojCasa.SelectedIndex = cbxBrojCasa.FindStringExact(brojCasa.ToString());
            }
            
        }
    }
}
