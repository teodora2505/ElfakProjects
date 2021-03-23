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
    public partial class Garaza2 : Form
    {
        public List<PictureBox> listaParkingMesta = new List<PictureBox>();
        public Form1 myForm;

        public Garaza2()
        {
            InitializeComponent();
            listaParkingMesta.Add(g2m1); listaParkingMesta.Add(g2m2); listaParkingMesta.Add(g2m3);
            listaParkingMesta.Add(g2m4); listaParkingMesta.Add(g2m5); listaParkingMesta.Add(g2m6);
            listaParkingMesta.Add(g2m7); listaParkingMesta.Add(g2m8); listaParkingMesta.Add(g2m9);
            listaParkingMesta.Add(g2m10); listaParkingMesta.Add(g2m11); listaParkingMesta.Add(g2m12);
            listaParkingMesta.Add(g2m13); listaParkingMesta.Add(g2m14); listaParkingMesta.Add(g2m15);
            listaParkingMesta.Add(g2m16); listaParkingMesta.Add(g2m17); listaParkingMesta.Add(g2m18);
            listaParkingMesta.Add(g2m19); listaParkingMesta.Add(g2m20); listaParkingMesta.Add(g2m21);
            listaParkingMesta.Add(g2m22); listaParkingMesta.Add(g2m23); listaParkingMesta.Add(g2m24);
            listaParkingMesta.Add(g2m25); listaParkingMesta.Add(g2m26); listaParkingMesta.Add(g2m27);
            listaParkingMesta.Add(g2m28); listaParkingMesta.Add(g2m29); listaParkingMesta.Add(g2m30);
            listaParkingMesta.Add(g2m31); listaParkingMesta.Add(g2m32);

        }
       
        private void bunifuImageButton2_Click(object sender, EventArgs e)  //zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)//minimizacija
        { 
                this.WindowState = FormWindowState.Minimized;
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

        private void g2m1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            labelInvalid.Visible = false;
            label4.Visible = false;
        }

        private void g2m1_MouseHover(object sender, EventArgs e)
        {
            if (g2m1.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "1";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m1.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m2_MouseHover(object sender, EventArgs e)
        {
            if (g2m2.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "2";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m2.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m3_MouseHover(object sender, EventArgs e)
        {
            if (g2m3.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "3";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m3.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m4_MouseHover(object sender, EventArgs e)
        {
            if (g2m4.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "4";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m4.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m5_MouseHover(object sender, EventArgs e)
        {
            if (g2m5.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "5";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m5.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m6_MouseHover(object sender, EventArgs e)
        {
            if (g2m6.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "6";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m6.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m7_MouseHover(object sender, EventArgs e)
        {
            if (g2m7.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "7";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m7.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m8_MouseHover(object sender, EventArgs e)
        {
            if (g2m8.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "8";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m8.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m9_MouseHover(object sender, EventArgs e)
        {
            if (g2m9.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "9";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m9.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m10_MouseHover(object sender, EventArgs e)
        {
            if (g2m10.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "10";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m10.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m11_MouseHover(object sender, EventArgs e)
        {
            if (g2m11.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "11";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m11.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m12_MouseHover(object sender, EventArgs e)
        {
            if (g2m12.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "12";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m12.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m13_MouseHover(object sender, EventArgs e)
        {
            if (g2m13.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "13";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m13.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m14_MouseHover(object sender, EventArgs e)
        {
            if (g2m14.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "14";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m14.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m15_MouseHover(object sender, EventArgs e)
        {
            if (g2m15.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "15";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m15.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m16_MouseHover(object sender, EventArgs e)
        {
            if (g2m16.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "16";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m16.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m17_MouseHover(object sender, EventArgs e)
        {
            if (g2m17.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "17";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m17.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m18_MouseHover(object sender, EventArgs e)
        {
            if (g2m18.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "18";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m18.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m19_MouseHover(object sender, EventArgs e)
        {
            if (g2m19.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "19";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m19.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m20_MouseHover(object sender, EventArgs e)
        {
            if (g2m20.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "20";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m20.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m21_MouseHover(object sender, EventArgs e)
        {
            if (g2m21.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "21";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m21.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m22_MouseHover(object sender, EventArgs e)
        {
            if (g2m22.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "22";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m22.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m23_MouseHover(object sender, EventArgs e)
        {
            if (g2m23.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "23";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m23.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m24_MouseHover(object sender, EventArgs e)
        {
            if (g2m24.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "24";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m24.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m25_MouseHover(object sender, EventArgs e)
        {
            if (g2m25.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "25";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m25.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m26_MouseHover(object sender, EventArgs e)
        {
            if (g2m26.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "26";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m26.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m27_MouseHover(object sender, EventArgs e)
        {
            if (g2m27.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "27";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m27.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m28_MouseHover(object sender, EventArgs e)
        {
            if (g2m28.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "28";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m28.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m29_MouseHover(object sender, EventArgs e)
        {
            if (g2m29.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "29";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m29.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m30_MouseHover(object sender, EventArgs e)
        {
            if (g2m30.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "30";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m30.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m31_MouseHover(object sender, EventArgs e)
        {
            if (g2m31.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "31";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m31.Tag;
                this.prikaziInfo(v);
            }
        }

        private void g2m32_MouseHover(object sender, EventArgs e)
        {
            if (g2m32.Image != null)
            {
                groupBox1.Visible = true;
                labelGaraza.Text = "2";
                labelMesto.Text = "32";
                Vozilo v = new Vozilo();
                v = (Vozilo)g2m32.Tag;
                this.prikaziInfo(v);
            }
        }
        #endregion

    }
}
