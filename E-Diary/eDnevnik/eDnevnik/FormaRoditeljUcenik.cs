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
    public partial class FormaRoditeljUcenik : Form
    {
        public FormaRoditeljUcenik()
        {
            InitializeComponent();
            
        }

        private void FormaRoditeljUcenik_Load(object sender, EventArgs e)
        {
            osvezi();

        }

        public void osvezi()
        {
            List<KorisnikExtended> lista = DTOManager.getRoditelji();
            dataGridRoditelji.Rows.Clear();

            foreach (KorisnikExtended k in lista)
            {
                dataGridRoditelji.Rows.Add(k.KorisnikId, k.Ime, k.Prezime);
            }

            dataGridRoditelji.Rows[0].Selected=true;

            dataGridDeca.Visible = true;
            labelDeca.Visible = true;

            List<UcenikBasics> deca = DTOManager.GetRoditeljevaDecaInfos(Convert.ToInt32(dataGridRoditelji.CurrentRow.Cells[0].Value));
            dataGridDeca.Rows.Clear();

            foreach (UcenikBasics k in deca)
            {
                dataGridDeca.Rows.Add(k.UcenikId, k.Ime, k.Prezime);
            }

            foreach (DataGridViewRow row in dataGridDeca.Rows)
            {
                row.Selected = false;
            }

        }

        private void dataGridRoditelji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridRoditelji.CurrentRow.Selected = true;
            dataGridDeca.Visible = true;
            labelDeca.Visible = true;

            List<UcenikBasics> deca = DTOManager.GetRoditeljevaDecaInfos(Convert.ToInt32(dataGridRoditelji.CurrentRow.Cells[0].Value));
            dataGridDeca.Rows.Clear();

            foreach (UcenikBasics k in deca)
            {
                dataGridDeca.Rows.Add(k.UcenikId, k.Ime, k.Prezime);
            }

            foreach (DataGridViewRow row in dataGridDeca.Rows)
            {
                row.Selected = false;
            }
        }

        private void dataGridDeca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridDeca.CurrentRow.Selected = true;
        }

        private void btnDodajRoditeljDete_Click(object sender, EventArgs e)
        {
            labelDodaj.Visible = true;
            btnDodaj.Visible = true;
            btnDodajRoditeljDete.Visible = false;
            btnUkloniDete.Visible = false;

            List<UcenikBasics> deca = DTOManager.getUcenici();
            dataGridDeca.Rows.Clear();

            foreach (UcenikBasics k in deca)
            {
                dataGridDeca.Rows.Add(k.UcenikId, k.Ime, k.Prezime);
            }

            foreach (DataGridViewRow row in dataGridDeca.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(dataGridRoditelji.CurrentRow.Selected==true && dataGridDeca.CurrentRow.Selected == true)
            {
                DTOManager.saveJeRoditelj(Convert.ToInt32(dataGridRoditelji.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridDeca.CurrentRow.Cells[0].Value));
            }
            btnDodaj.Visible = false;
            btnDodajRoditeljDete.Visible = true;
            labelDodaj.Visible = false;
            osvezi();
            btnDodaj.Visible = true;
        }

        private void btnUkloniDete_Click(object sender, EventArgs e)
        {
            if(dataGridDeca.CurrentRow.Selected == true)
            {
                DTOManager.deleteJeRoditelj(Convert.ToInt32(dataGridRoditelji.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridDeca.CurrentRow.Cells[0].Value));
                labelDodaj.Visible = false;
                osvezi();
            }
            else
            {
                labelDodaj.Visible = true;
            }
        }
    }
}
