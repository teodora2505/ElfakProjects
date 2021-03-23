using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elektronski_Parking_Sistem.Podaci;


namespace Elektronski_Parking_Sistem
{
    public partial class Garaza1 : Form
    {
        public List<PictureBox> listaParkingMesta = new List<PictureBox>();
        public Form1 myForm;
        
        public Garaza1()
        {
            InitializeComponent();
            listaParkingMesta.Add(g1m1); listaParkingMesta.Add(g1m2); listaParkingMesta.Add(g1m3);
            listaParkingMesta.Add(g1m4); listaParkingMesta.Add(g1m5); listaParkingMesta.Add(g1m6);
            listaParkingMesta.Add(g1m7); listaParkingMesta.Add(g1m8); listaParkingMesta.Add(g1m9);
            listaParkingMesta.Add(g1m10); listaParkingMesta.Add(g1m11); listaParkingMesta.Add(g1m12);
            listaParkingMesta.Add(g1m13); listaParkingMesta.Add(g1m14); listaParkingMesta.Add(g1m15);
            listaParkingMesta.Add(g1m16); listaParkingMesta.Add(g1m17); listaParkingMesta.Add(g1m18);
            listaParkingMesta.Add(g1m19); listaParkingMesta.Add(g1m20); listaParkingMesta.Add(g1m21);
            listaParkingMesta.Add(g1m22); listaParkingMesta.Add(g1m23); listaParkingMesta.Add(g1m24);
            listaParkingMesta.Add(g1m25); listaParkingMesta.Add(g1m26); listaParkingMesta.Add(g1m27);
            listaParkingMesta.Add(g1m28); listaParkingMesta.Add(g1m29); listaParkingMesta.Add(g1m30);
            listaParkingMesta.Add(g1m31); listaParkingMesta.Add(g1m32);
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)//zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //minimizacija forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Garaza1_Load(object sender, EventArgs e)
        {
           
        }

        #region PICBOX_HOVERS
        public void prikaziInfo(Vozilo v)
        {
            labelVozilo.Text = v.TipVozila;
            if (v.TipVozila == "automobil")
            {
                if (v.DalijeInvalidsko == true)
                {
                    labelInvalid.Visible = true;
                    label4.Visible = true;
                    labelInvalid.Text = "da";
                }
                else
                {
                    labelInvalid.Visible = false;
                    label4.Visible = false;
                }
            }
            labelTablice.Text = v.RegTab;
            switch (v.UslugaParkingServisa)
            {
                case 1: labelUsluga.Text = "1h"; break;
                case 12: labelUsluga.Text = "poludnevna"; break;
                case 24: labelUsluga.Text = "dnevna"; break;
                case 168: labelUsluga.Text = "nedeljna"; break;
                case 720: labelUsluga.Text = "mesečna"; break;
                default: break;
            }
            labelPocetak.Text = v.PocetakParkiranja.ToString();
            labelKraj.Text = v.KrajParkiranja.ToString();
            labelRacun.Text = v.Racun.ToString();
            
        }

        private void g1m5_MouseHover(object sender, EventArgs e)
        {
          if(g1m5.Image!=null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "5";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m5.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m1_MouseHover(object sender, EventArgs e)
        {
            if (g1m1.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "1";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m1.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m2_MouseHover(object sender, EventArgs e)
        {
            if (g1m2.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "2";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m2.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m3_MouseHover(object sender, EventArgs e)
        {
            if (g1m3.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "3";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m3.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m4_MouseHover(object sender, EventArgs e)
        {
            if (g1m4.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "4";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m4.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m6_MouseHover(object sender, EventArgs e)
        {
            if (g1m6.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "6";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m6.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m7_MouseHover(object sender, EventArgs e)
        {
            if (g1m7.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "7";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m7.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m8_MouseHover(object sender, EventArgs e)
        {
            if (g1m8.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "8";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m8.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m9_MouseHover(object sender, EventArgs e)
        {
            if (g1m9.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "9";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m9.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m10_MouseHover(object sender, EventArgs e)
        {
            if (g1m10.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "10";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m10.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m11_MouseHover(object sender, EventArgs e)
        {
            if (g1m11.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "11";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m11.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m12_MouseHover(object sender, EventArgs e)
        {
            if (g1m12.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "12";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m12.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m13_MouseHover(object sender, EventArgs e)
        {
            if (g1m13.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "13";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m13.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m14_MouseHover(object sender, EventArgs e)
        {
            if (g1m14.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "14";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m14.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m15_MouseHover(object sender, EventArgs e)
        {
            if (g1m15.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "15";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m15.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m16_MouseHover(object sender, EventArgs e)
        {
            if (g1m16.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "16";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m16.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m17_MouseHover(object sender, EventArgs e)
        {
            if (g1m17.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "17";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m17.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m18_MouseHover(object sender, EventArgs e)
        {
            if (g1m18.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "18";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m18.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m19_MouseHover(object sender, EventArgs e)
        {
            if (g1m19.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "19";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m19.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m20_MouseHover(object sender, EventArgs e)
        {
            if (g1m20.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "20";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m20.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m21_MouseHover(object sender, EventArgs e)
        {
            if (g1m21.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "21";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m21.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m22_MouseHover(object sender, EventArgs e)
        {
            if (g1m22.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "22";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m22.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m23_MouseHover(object sender, EventArgs e)
        {
            if (g1m23.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "23";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m23.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m24_MouseHover(object sender, EventArgs e)
        {
            if (g1m24.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "24";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m24.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m25_MouseHover(object sender, EventArgs e)
        {
            if (g1m25.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "25";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m25.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m26_MouseHover(object sender, EventArgs e)
        {
            if (g1m26.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "26";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m26.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m27_MouseHover(object sender, EventArgs e)
        {
            if (g1m27.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "27";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m27.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m28_MouseHover(object sender, EventArgs e)
        {
            if (g1m28.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "28";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m28.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m29_MouseHover(object sender, EventArgs e)
        {
            if (g1m29.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "29";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m29.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m30_MouseHover(object sender, EventArgs e)
        {
            if (g1m30.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "30";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m30.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m31_MouseHover(object sender, EventArgs e)
        {
            if (g1m31.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "31";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m31.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m32_MouseHover(object sender, EventArgs e)
        {
            if (g1m32.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "1";
                labelMesto.Text = "32";
                Vozilo v = new Vozilo();
                v = (Vozilo)g1m32.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g1m1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            labelInvalid.Visible = false;
            label4.Visible = false;
        }
        #endregion
    }
}
