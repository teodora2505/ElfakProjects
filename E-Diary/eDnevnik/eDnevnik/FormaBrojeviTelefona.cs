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
    public partial class FormaBrojeviTelefona : Form
    {
        public FormaBrojeviTelefona()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKorisnikId.Text))
            {
                if(DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(txtKorisnikId.Text)) != null)
                {
                    List<BrojTelefonaPregled> lista = DTOManager.GetBrojTelefonaKorisnika(Convert.ToInt32(txtKorisnikId.Text));

                    datagridTelefon.Visible = true;
                    datagridTelefon.Rows.Clear();

                    foreach(BrojTelefonaPregled br in lista)
                    {
                        datagridTelefon.Rows.Add(br.Id, br.broj);
                    }

                    datagridTelefon.ClearSelection();
                }
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(txtDodajKorisnikId.Text)) != null)
            {
                int idKorisnika = DTOManager.GetKorisnikPregledInfos(Convert.ToInt32(txtDodajKorisnikId.Text)).KorisnikId;
                string telefon = txtDodajTel.Text;

                DTOManager.SaveBrojTelefona(idKorisnika, telefon);
                txtKorisnikId.Text = idKorisnika.ToString();
                txtDodajTel.Text = "";
                txtDodajKorisnikId.Text = "";
                btnPrikazi_Click(sender, e);
            }
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
            if(datagridTelefon.CurrentRow.Selected==true)
            {
                DTOManager.deleteBrojTelefona(Convert.ToInt32(datagridTelefon.CurrentRow.Cells[0].Value));
                btnPrikazi_Click(sender, e);
            }
        }

        private void datagridTelefon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridTelefon.CurrentRow.Selected = true;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (datagridTelefon.CurrentRow.Selected == true)
            {
                groupBox2.Visible = true;
                txtIzmenii.Text = datagridTelefon.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnIzmeniKontakt_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtIzmenii.Text))
            {
                DTOManager.UpdateBrojTelefona(Convert.ToInt32(datagridTelefon.CurrentRow.Cells[0].Value), txtIzmenii.Text);
                txtIzmenii.Text = "";
                groupBox2.Visible = false;
                btnPrikazi_Click(sender, e);
            }
        }
    }
}
