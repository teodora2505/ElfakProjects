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
    public partial class Garaza3 : Form
    {
        public List<PictureBox> listaParkingMesta = new List<PictureBox>();
        public Form1 myForm;

        public Garaza3()
        {
            InitializeComponent();
            listaParkingMesta.Add(g3m1); listaParkingMesta.Add(g3m2); listaParkingMesta.Add(g3m3);
            listaParkingMesta.Add(g3m4); listaParkingMesta.Add(g3m5); listaParkingMesta.Add(g3m6);
            listaParkingMesta.Add(g3m7); listaParkingMesta.Add(g3m8); listaParkingMesta.Add(g3m9);
            listaParkingMesta.Add(g3m10); listaParkingMesta.Add(g3m11); listaParkingMesta.Add(g3m12);
            listaParkingMesta.Add(g3m13); listaParkingMesta.Add(g3m14); listaParkingMesta.Add(g3m15);
            listaParkingMesta.Add(g3m16); listaParkingMesta.Add(g3m17); listaParkingMesta.Add(g3m18);
            listaParkingMesta.Add(g3m19); listaParkingMesta.Add(g3m20); listaParkingMesta.Add(g3m21);
            listaParkingMesta.Add(g3m22); listaParkingMesta.Add(g3m23); listaParkingMesta.Add(g3m24);
            listaParkingMesta.Add(g3m25); listaParkingMesta.Add(g3m26); listaParkingMesta.Add(g3m27);
            listaParkingMesta.Add(g3m28); listaParkingMesta.Add(g3m29); listaParkingMesta.Add(g3m30);
            listaParkingMesta.Add(g3m31); listaParkingMesta.Add(g3m32);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        #region PIXBOX_HOVERS
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

        private void g3m1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            labelInvalid.Visible = false;
            label4.Visible = false;
        }

        private void g3m1_MouseHover(object sender, EventArgs e)
        {
            if (g3m1.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "1";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m1.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m2_MouseHover(object sender, EventArgs e)
        {
            if (g3m2.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "2";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m2.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m3_MouseHover(object sender, EventArgs e)
        {
            if (g3m3.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "3";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m3.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m4_MouseHover(object sender, EventArgs e)
        {
            if (g3m4.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "4";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m4.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m5_MouseHover(object sender, EventArgs e)
        {
            if (g3m5.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "5";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m5.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m6_MouseHover(object sender, EventArgs e)
        {
            if (g3m6.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "6";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m6.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m7_MouseHover(object sender, EventArgs e)
        {
            if (g3m7.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "7";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m7.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m8_MouseHover(object sender, EventArgs e)
        {
            if (g3m8.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "8";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m8.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m9_MouseHover(object sender, EventArgs e)
        {
            if (g3m9.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "9";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m9.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m10_MouseHover(object sender, EventArgs e)
        {
            if (g3m10.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "10";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m10.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m11_MouseHover(object sender, EventArgs e)
        {
            if (g3m11.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "11";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m11.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m12_MouseHover(object sender, EventArgs e)
        {
            if (g3m12.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "12";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m12.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m13_MouseHover(object sender, EventArgs e)
        {
            if (g3m13.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "13";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m13.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m14_MouseHover(object sender, EventArgs e)
        {
            if (g3m14.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "14";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m14.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m15_MouseHover(object sender, EventArgs e)
        {
            if (g3m15.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "15";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m15.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m16_MouseHover(object sender, EventArgs e)
        {
            if (g3m16.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "16";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m16.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m17_MouseHover(object sender, EventArgs e)
        {
            if (g3m17.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "17";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m17.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m18_MouseHover(object sender, EventArgs e)
        {
            if (g3m18.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "18";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m18.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m19_MouseHover(object sender, EventArgs e)
        {
            if (g3m19.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "19";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m19.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m20_MouseHover(object sender, EventArgs e)
        {
            if (g3m20.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "20";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m20.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m21_MouseHover(object sender, EventArgs e)
        {
            if (g3m21.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "21";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m21.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m22_MouseHover(object sender, EventArgs e)
        {
            if (g3m22.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "22";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m22.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m23_MouseHover(object sender, EventArgs e)
        {
            if (g3m23.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "23";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m23.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m24_MouseHover(object sender, EventArgs e)
        {
            if (g3m24.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "24";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m24.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m25_MouseHover(object sender, EventArgs e)
        {
            if (g3m25.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "25";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m25.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m26_MouseHover(object sender, EventArgs e)
        {
            if (g3m26.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "26";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m26.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m27_MouseHover(object sender, EventArgs e)
        {
            if (g3m27.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "27";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m27.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m28_MouseHover(object sender, EventArgs e)
        {
            if (g3m28.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "28";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m28.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m29_MouseHover(object sender, EventArgs e)
        {
            if (g3m29.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "29";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m29.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m30_MouseHover(object sender, EventArgs e)
        {
            if (g3m30.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "30";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m30.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m31_MouseHover(object sender, EventArgs e)
        {
            if (g3m31.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "31";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m31.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g3m32_MouseHover(object sender, EventArgs e)
        {
            if (g3m32.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "3";
                labelMesto.Text = "32";
                Vozilo v = new Vozilo();
                v = (Vozilo)g3m32.Tag;
                this.prikaziInfo(v);
            }
        }
        #endregion
    }
}
