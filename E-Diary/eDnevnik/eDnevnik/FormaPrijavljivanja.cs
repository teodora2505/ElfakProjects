using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NHibernate;
using eDnevnik.Entiteti;
using NHibernate.Linq;

namespace eDnevnik
{
    public partial class FormaPrijavljivanja : Form
    {
        public int BrojSekundiTajmera { get; set; } = 0;
        public int KorisnikId { get; set; }

        public FormaPrijavljivanja()
        {
            InitializeComponent();
            KorisnikId = 0;
        }

        private void FormaPrijavljivanja_Load(object sender, EventArgs e)
        {
            labelPokusajtePonovo.Text = "Potrebno je da se prijavite.";
            labelPokusajtePonovo.ForeColor = Color.MidnightBlue;

        }

        

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if(txtKorisnickoIme.Text!="" && txtSifra.Text!="")
            {
                KorisnikPregled kp = DTOManager.GetKorisnikPregled(txtKorisnickoIme.Text, txtSifra.Text);

                if (kp != null)
                {
                    KorisnikId = kp.KorisnikId;

                    bool nastavnik = false; bool admin = false; bool razredni = false; bool roditelj = false;

                    if (Convert.ToBoolean(kp.FAdministrator))
                    {
                        admin = true;
                    }

                    if (Convert.ToBoolean(kp.FNastavnik))
                    {
                        nastavnik = true;
                    }

                    if (Convert.ToBoolean(kp.FRoditelj))
                    {
                        roditelj = true;
                    }

                    if (DTOManager.DaLiJeRazredni(kp.KorisnikId))
                    {
                        razredni = true;
                    }

                    if (Convert.ToBoolean(kp.FUcenik))
                    {
                        this.Hide();
                        FormaUcenikPocetna ucenikPocetna = new FormaUcenikPocetna(kp);
                        ucenikPocetna.FormClosed += (s, args) => this.Close();
                        ucenikPocetna.Show();
                    }
                    else if (!Convert.ToBoolean(kp.FUcenik) && kp != null)
                    {
                        this.Hide();
                        FormaNastaviKao nastaviForma = new FormaNastaviKao(kp, nastavnik, razredni, roditelj, admin);
                        nastaviForma.FormClosed += (s, args) => this.Close();
                        nastaviForma.Show();
                    }
                }
                else //javila se greska pri prijavljivanju
                {
                    txtKorisnickoIme.Text = "";
                    txtSifra.Text = "";
                    timer1.Start();
                }
                
            }

            
           
        }

        private void timer1_Tick(object sender, EventArgs e) //obavestenje o nesupesnom prijavljivanju
        {
            BrojSekundiTajmera++;
            labelPokusajtePonovo.Text = "Greška pri prijavljivanju, pokušajte ponovo.";
            labelPokusajtePonovo.ForeColor = Color.Red;
            txtKorisnickoIme.BackColor = Color.FromArgb(255, 181, 195);
            txtSifra.BackColor = Color.FromArgb(255, 181, 195);

            if(BrojSekundiTajmera==3)
            {
                timer1.Stop();
                labelPokusajtePonovo.Visible = false;
                BrojSekundiTajmera = 0;
                txtKorisnickoIme.BackColor = Color.White;
                txtSifra.BackColor = Color.White;
                labelPokusajtePonovo.Text = "Potrebno je da se prijavite.";
                labelPokusajtePonovo.ForeColor = Color.MidnightBlue;
            }
        }
    }
}
