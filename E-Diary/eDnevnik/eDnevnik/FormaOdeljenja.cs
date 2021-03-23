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
    public partial class FormaOdeljenja : Form
    {
        public FormaOdeljenja()
        {
            InitializeComponent();
        }

        private void dataGridOdeljenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridOdeljenja.CurrentRow.Selected = true;

        }

        private void FormaOdeljenja_Load(object sender, EventArgs e)
        {
            osvezi();
        }

        public void osvezi()
        {
            List<OdeljenjeBasic> lista = DTOManager.GetSvaOdeljenja();
            dataGridOdeljenja.Rows.Clear();

            foreach(OdeljenjeBasic o in lista)
            {
                dataGridOdeljenja.Rows.Add(o.OdeljenjeId, o.Naziv, o.Smer.ToLower());
            }
        }

        private void btnDodajOdeljenje_Click(object sender, EventArgs e)
        {
            panelOdeljenja.Visible = true;

            btnDodaj.Text = "Dodaj odeljenje";
        }

        private void btnIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            panelOdeljenja.Visible = true;

            btnDodaj.Text = "Izmeni odeljenje";
            txtNazivOdeljenja.Text = dataGridOdeljenja.CurrentRow.Cells[1].Value.ToString();
            txtSmer.Text = dataGridOdeljenja.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnUkloniOdeljenje_Click(object sender, EventArgs e)
        {
            if (dataGridOdeljenja.CurrentRow.Selected == true)
            {
                DTOManager.DeleteOdeljenje(Convert.ToInt32(dataGridOdeljenja.CurrentRow.Cells[0].Value));
            }
            osvezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            OdeljenjeBasic odeljenje = new OdeljenjeBasic();
            odeljenje.Naziv = txtNazivOdeljenja.Text;
            odeljenje.Smer = txtSmer.Text;
            if(btnDodaj.Text== "Dodaj odeljenje")
            {
                DTOManager.SaveOdeljenje(odeljenje);
            }
            if (btnDodaj.Text == "Izmeni odeljenje")
            {
                DTOManager.UpdateOdeljenje(Convert.ToInt32(dataGridOdeljenja.CurrentRow.Cells[0].Value),odeljenje);
            }

            txtNazivOdeljenja.Clear();
            txtSmer.Clear();
            panelOdeljenja.Visible = false;
            osvezi();

        }
    }
}
