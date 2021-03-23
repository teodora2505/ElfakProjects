using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Mongo_DataLayer.Entities;

namespace MongoApplication
{
    public partial class ControlPonuda : UserControl
    {
        public ControlPonuda()
        {
            InitializeComponent();
        }

        public void setDestinacija(string destinacija)
        {
            labelDestinacija.Text = destinacija;
        }

        public void setPolazak(string polazak)
        {
            labelPolazak.Text = polazak;
        }

        public void setDani(string dani)
        {
            labelDani.Text = dani;
        }

        public void setNoci(string noci)
        {
            labelNoci.Text = noci;
        }

        public void setTipPonude(string tip)
        {
            labelTipPonude.Text = tip;
        }

        public void setPicture(string slika)
        {
            Image image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slika);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Bunifu.Framework.UI.BunifuFlatButton getButtonDetaljnije()
        {
            return buttonDetaljnije;
        }

        public void setCena(string cena)
        {
            labelCena.Text = cena;
        }

        public void setButtonDetaljnijeTag(Ponuda ponuda)
        {
            buttonDetaljnije.Tag = ponuda;
        }
    }
}
