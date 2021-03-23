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
    public partial class FormaPredmetiNaGodini : Form
    {
        public int MAX = 0;

        public FormaPredmetiNaGodini()
        {
            InitializeComponent();
        }

        private void FormaPredmetiNaGodini_Load(object sender, EventArgs e)
        {
            List<GodinaPregled> lista = DTOManager.GetNaGodini();
            int max = 1;
            foreach(GodinaPregled g in lista)
            {
                if (g.godina > max)
                    max = g.godina;
            }

            MAX = max;
            cbxGodina.Items.Clear();
            cbxUkloniGodina.Items.Clear();
            cbxDodajGodina.Items.Clear();

            for (int i = 1; i <=max; i++)
            {
                cbxGodina.Items.Add(i);
                cbxUkloniGodina.Items.Add(i);
                cbxDodajGodina.Items.Add(i);
            }
              
        }

        private void cbxGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxGodina.SelectedIndex>-1)
            {
                datagridPredmeti.Visible = true;
                datagridPredmeti.Rows.Clear();

                foreach(GodinaPregled g in DTOManager.GetNaGodini())
                {
                    if(Convert.ToInt32(cbxGodina.SelectedItem.ToString())==g.godina)
                    {
                        PredmetBasic pred = DTOManager.GetPredmetBasicInfo(g.PredmetId);

                        datagridPredmeti.Rows.Add(pred.PredmetId, pred.Naziv, pred.Opis);
                    }
                    datagridPredmeti.ClearSelection();
                }
            }
        }

        private void cbxDodajGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxDodajGodina.SelectedIndex>-1)
            {
                List<PredmetBasic> predmeti = DTOManager.GetPredmetiKojiNisuNaGodini(Convert.ToInt32(cbxDodajGodina.SelectedItem.ToString()));
                cbxDodajPredmeti.Enabled = true;
                cbxDodajPredmeti.Items.Clear();

                foreach(PredmetBasic p in predmeti)
                {
                    cbxDodajPredmeti.Items.Add(p.Naziv);
                }
            }
        }

        private void cbxUkloniGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUkloniGodina.SelectedIndex > -1)
            {
                List<PredmetBasic> predmeti = DTOManager.GetPredmetiNaGodini(Convert.ToInt32(cbxUkloniGodina.SelectedItem.ToString()));
                cbxUkloniPredet.Enabled = true;
                cbxUkloniPredet.Items.Clear();

                foreach (PredmetBasic p in predmeti)
                {
                    cbxUkloniPredet.Items.Add(p.Naziv);
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cbxDodajGodina.SelectedIndex > -1 && cbxDodajPredmeti.SelectedIndex > -1)
            {
                int god = Convert.ToInt32(cbxDodajGodina.SelectedItem.ToString());
                int predId = DTOManager.GetPredmetNaziv(cbxDodajPredmeti.SelectedItem.ToString()).PredmetId;
                DTOManager.SaveNaGodini(god,predId);
                cbxGodina.SelectedItem = cbxDodajGodina.SelectedItem.ToString();
                cbxGodina_SelectedIndexChanged(sender, e);

                cbxDodajPredmeti.Text = "";
                cbxDodajPredmeti.Enabled = false;
                cbxDodajGodina.Text = "";
            }
              
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (cbxUkloniGodina.SelectedIndex > -1 && cbxUkloniGodina.SelectedIndex > -1)
            {
                int god = Convert.ToInt32(cbxUkloniGodina.SelectedItem.ToString());
                int predId = DTOManager.GetPredmetNaziv(cbxUkloniPredet.SelectedItem.ToString()).PredmetId;

                DTOManager.deleteNaGodini(god, predId);
                cbxGodina.SelectedItem = cbxUkloniGodina.SelectedItem.ToString();
                cbxGodina_SelectedIndexChanged(sender, e);

                cbxUkloniPredet.Text = "";
                cbxUkloniPredet.Enabled = false;
                cbxUkloniGodina.Text = "";
            }
        }
    }
}
