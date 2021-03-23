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
    public partial class FormaSviKorisnici : Form
    {
        public FormaSviKorisnici()
        {
            InitializeComponent();
        }

        private void FormaSviKorisnici_Load(object sender, EventArgs e)
        {
            this.osveziDataGridKorisnici();
        }

        public void osveziDataGridKorisnici()
        {
            dataGridKorisnici.Rows.Clear();


            List<KorisnikExtended> lista = DTOManager.GetKorisnici();

            foreach (KorisnikExtended kk in lista)
            {
                string fadmin = "";
                string fucenik = "";
                string fnastavnik = "";
                string froditelj = "";

                if (kk.FAdministrator == 1)
                {
                    fadmin = "✔";
                }
                else
                {
                    fadmin = "✗";
                }

                if (kk.FUcenik == 1)
                {
                    fucenik = "✔";
                }
                else
                {
                    fucenik = "✗";
                }

                if (kk.FNastavnik == 1)
                {
                    fnastavnik = "✔";
                }
                else
                {
                    fnastavnik = "✗";
                }

                if (kk.FRoditelj == 1)
                {
                    froditelj = "✔";
                }
                else
                {
                    froditelj = "✗";
                }

                dataGridKorisnici.Rows.Add(kk.KorisnikId, kk.Ime, kk.Prezime, kk.JMBG, kk.DatumRodjenja.ToShortDateString(), kk.Pol, fadmin, fucenik, fnastavnik, froditelj);
            }

            foreach (DataGridViewRow row in dataGridKorisnici.Rows)
                row.Selected = false;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            FormaDodavanjeKorisnika formica = new FormaDodavanjeKorisnika(true,null);
            if(formica.ShowDialog()==DialogResult.OK)
                this.osveziDataGridKorisnici();
            else
                this.osveziDataGridKorisnici();
        }

        private void dataGridKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridKorisnici.CurrentRow.Selected = true;
        }

        private void buttonIzmeniKorisnika_Click(object sender, EventArgs e)
        {
            
            if(dataGridKorisnici.CurrentRow.Selected==true)
            {
                KorisnikExtended k = DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(dataGridKorisnici.CurrentRow.Cells[0].Value));

                FormaDodavanjeKorisnika formica = new FormaDodavanjeKorisnika(false,k);
                if (formica.ShowDialog() == DialogResult.OK)
                    this.osveziDataGridKorisnici();
                else
                    this.osveziDataGridKorisnici();
            }
        }

        private void buttonUkloniKorisnika_Click(object sender, EventArgs e)
        {
            if (dataGridKorisnici.CurrentRow.Selected == true)
            {
                int id = Convert.ToInt32(dataGridKorisnici.CurrentRow.Cells[0].Value);

                DTOManager.DeleteKorisnik(id);

                this.osveziDataGridKorisnici();
            }
        }
    }
}
