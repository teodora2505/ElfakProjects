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
    public partial class FormaNastaviKao : Form
    {
        KorisnikPregled prijavljeniKorisnik { get; set; }

        public FormaNastaviKao()
        {
            InitializeComponent();
        }

        public FormaNastaviKao(KorisnikPregled kp, bool nastavnik, bool razredni, bool roditelj, bool admin)
        {
            InitializeComponent();
            prijavljeniKorisnik = kp;
            rdbAdministrator.Checked = false;
            rdbNastavnik.Checked = false;
            rdbRoditelj.Checked = false;
            rdbRazredni.Checked = false;
            rdbAdministrator.Enabled = admin;
            rdbNastavnik.Enabled = nastavnik;
            rdbRoditelj.Enabled = roditelj;
            rdbRazredni.Enabled = razredni;
            rdbAdministrator.Checked = false;
            rdbNastavnik.Checked = false;
            rdbRoditelj.Checked = false;
            rdbRazredni.Checked = false;

        }

        private void FormaNastaviKao_Load(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if(rdbNastavnik.Checked==true)
            {
                this.Hide();
                FormaNastavnikPocetna nastavnikPocetna = new FormaNastavnikPocetna(prijavljeniKorisnik);
                nastavnikPocetna.FormClosed += (s, args) => this.Close();
                nastavnikPocetna.Show();
            }
            else if(rdbRazredni.Checked==true)
            {
                this.Hide();
                FormaRazredniPocetna nastavnikPocetna = new FormaRazredniPocetna(prijavljeniKorisnik);
                nastavnikPocetna.FormClosed += (s, args) => this.Close();
                nastavnikPocetna.Show();
            }
            else if(rdbRoditelj.Checked==true)
            {
                this.Hide();
                FormaRoditeljPocetna nastavnikPocetna = new FormaRoditeljPocetna(prijavljeniKorisnik);
                nastavnikPocetna.FormClosed += (s, args) => this.Close();
                nastavnikPocetna.Show();
            }
            else if(rdbAdministrator.Checked==true)
            {
                this.Hide();
                FormaAdministrator adminPocetna = new FormaAdministrator(prijavljeniKorisnik);
                adminPocetna.FormClosed += (s, args) => this.Close();
                adminPocetna.Show();
            }
        }
    }
}
