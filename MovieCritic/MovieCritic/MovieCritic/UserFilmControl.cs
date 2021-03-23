using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCritic
{
    public partial class UserFilmControl : UserControl
    {
        public UserFilmControl()
        {
            InitializeComponent();
        }

        public void setLabelNaziv(string naziv)
        {
            labelNaziv.Text = naziv;
        }

        public void setLabelZanr(string zanr)
        {
            labelZanr.Text = zanr;
        }

        public void setLabelReziser(string Reziser)
        {
            labelReziser.Text = Reziser;
        }

        public void setLabelGodina(string godina)
        {
            labelGodina.Text = godina;
        }
        public void setLabelGlumac1(string glum1)
        {
            labelGlumac1.Text = glum1;
        }

        public void setLabelGlumac2(string glum2)
        {
            labelGlumac2.Text = glum2;
        }

        public void setLabelGlumac3(string glum3)
        {
            labelGlumac3.Text = glum3;
        }

        public void setLabelOcena(string ocena)
        {
            labelOcena.Text = ocena;
        }
        public void setLabelLike(string like)
        {
            labelLike.Text = like;
        }

        public void setLabelDislike(string dislike)
        {
            labelDislike.Text = dislike;
        }

        public void setLabelRecenzija(string recenz)
        {
            labelRecenzija.Text = recenz;
        }

        public string getLabelNaziv()
        {
            return labelNaziv.Text;
        }

        public string getLabelGodina()
        {
            return labelGodina.Text;
        }



    }
}
