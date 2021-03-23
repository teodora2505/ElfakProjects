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
    public partial class FormaUceniciOdeljenja : Form
    {
        public FormaUceniciOdeljenja()
        {
            InitializeComponent();
        }

        private void FormaUceniciOdeljenja_Load(object sender, EventArgs e)
        {
            this.osvezi();
        }

        public void osvezi()
        {
            List<OdeljenjeBasic> lista = DTOManager.GetSvaOdeljenja();

            cbxOdeljenje.Items.Clear();
            foreach (OdeljenjeBasic o in lista)
            {
                cbxOdeljenje.Items.Add(o.Naziv);
            }
        }

        private void cbxOdeljenje_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<UcenikBasics> ucenici = DTOManager.GetUceniciOdeljenja(DTOManager.GetOdeljenjeNaziv(cbxOdeljenje.SelectedItem.ToString()).OdeljenjeId);

            dataGridUcenici.Visible = true;

            dataGridUcenici.Rows.Clear();

            foreach(UcenikBasics U in ucenici)
            {
                dataGridUcenici.Rows.Add(U.UcenikId, U.Ime, U.Prezime);
            }

            foreach (DataGridViewRow row in dataGridUcenici.Rows)
                row.Selected = false;

            btnPremestiUcenika.Visible = true;
        }

        private void dataGridUcenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridUcenici.CurrentRow.Selected = true; 

        }

        private void btnPremestiUcenika_Click(object sender, EventArgs e)
        {
            if(dataGridUcenici.CurrentRow.Selected==true)
            {
                panelPremestanje.Visible = true;
                panelPremestanje.BringToFront();
                List<OdeljenjeBasic> lista = DTOManager.GetSvaOdeljenja();

                cbxNovoOdeljenje.Items.Clear();
                foreach (OdeljenjeBasic o in lista)
                {
                    cbxNovoOdeljenje.Items.Add(o.Naziv);
                }

                labelIme.Text = dataGridUcenici.CurrentRow.Cells[1].Value.ToString();
                labelPrezime.Text= dataGridUcenici.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnPremesti_Click(object sender, EventArgs e)
        {
            DTOManager.UpdateUcenikovoOdeljenje(Convert.ToInt32(dataGridUcenici.CurrentRow.Cells[0].Value),
                                                DTOManager.GetOdeljenjeNaziv(cbxNovoOdeljenje.SelectedItem.ToString()).OdeljenjeId);

            panelPremestanje.Visible = false;
            btnPremestiUcenika.BringToFront();
            this.cbxOdeljenje_SelectedIndexChanged(sender, e);
        }
    }
}
