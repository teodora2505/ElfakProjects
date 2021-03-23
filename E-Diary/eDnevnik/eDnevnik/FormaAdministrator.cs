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
    public partial class FormaAdministrator : Form
    {
        public KorisnikPregled prijavljeniAdministrator { get; set; }

        public FormaAdministrator()
        {
            InitializeComponent();
        }

        public FormaAdministrator(KorisnikPregled kp)
        {
            InitializeComponent();
            txtImePrezimeAdministratora.Text = kp.Ime + " " + kp.Prezime;
            prijavljeniAdministrator = kp;
        }

        private void FormaAdministrator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPrijavljivanja prijavljivanje = new FormaPrijavljivanja();
            prijavljivanje.FormClosed += (s, args) => this.Close();
            prijavljivanje.Show();

        }

        private void btnSviKorisnici_Click(object sender, EventArgs e)
        {
            FormaSviKorisnici formica = new FormaSviKorisnici();
            formica.Show();
        }

        private void buttonUceniciOdeljenja_Click(object sender, EventArgs e)
        {
            FormaUceniciOdeljenja formica = new FormaUceniciOdeljenja();
            formica.Show();
        }

        private void btnOdeljenja_Click(object sender, EventArgs e)
        {
            FormaOdeljenja formica = new FormaOdeljenja();
            formica.Show();
        }

        private void btnRoditeljiDeca_Click(object sender, EventArgs e)
        {
            FormaRoditeljUcenik formica = new FormaRoditeljUcenik();
            formica.Show();
        }

        private void buttonRazredneStaresine_Click(object sender, EventArgs e)
        {
            FormaRazredneStaresine formica = new FormaRazredneStaresine();
            formica.Show();
        }

        private void buttonPredmeti_Click(object sender, EventArgs e)
        {
            FormaPredmeti formica = new FormaPredmeti();
            formica.Show();
        }

        private void buttonPredstavniciOdeljenja_Click(object sender, EventArgs e)
        {
            FormaPredstavniciOdeljenja formica = new FormaPredstavniciOdeljenja();
            formica.Show();
        }

        private void buttonVrsiociFunkcija_Click(object sender, EventArgs e)
        {
            FormaVrsiociFunkcija formica = new FormaVrsiociFunkcija();
            formica.Show();
        }

        private void buttonPredmetiNaGodini_Click(object sender, EventArgs e)
        {
            FormaPredmetiNaGodini formica = new FormaPredmetiNaGodini();
            formica.Show();
        }

        private void buttonBrojeviTelefona_Click(object sender, EventArgs e)
        {
            FormaBrojeviTelefona formica = new FormaBrojeviTelefona();
            formica.Show();
        }

        private void buttonRasporediCasova_Click(object sender, EventArgs e)
        {
            FormaOdeljenjeRaspored formica = new FormaOdeljenjeRaspored();
            formica.Show();
        }

        private void buttonDrziCas_Click(object sender, EventArgs e)
        {
            FormaDrziCas formica = new FormaDrziCas();
            formica.Show();
        }
    }
}
