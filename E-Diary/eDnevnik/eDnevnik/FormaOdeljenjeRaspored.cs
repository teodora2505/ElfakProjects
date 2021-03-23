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
    public partial class FormaOdeljenjeRaspored : Form
    {
        public FormaOdeljenjeRaspored()
        {
            InitializeComponent();
        }

        private void FormaOdeljenjeRaspored_Load(object sender, EventArgs e)
        {
            List<OdeljenjeBasic> lista = DTOManager.GetSvaOdeljenja();

            cbxOdeljenje.Items.Clear();


            foreach(OdeljenjeBasic odelj in lista)
            {
                cbxOdeljenje.Items.Add(odelj.Naziv);
            }
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if(cbxOdeljenje.SelectedIndex>-1)
            {
                OdeljenjeBasic odeljenje = DTOManager.GetOdeljenjeNaziv(cbxOdeljenje.SelectedItem.ToString());

                FormaRasporedCasova formica = new FormaRasporedCasova(odeljenje);
                formica.ShowDialog();

            }
        }
    }
}
