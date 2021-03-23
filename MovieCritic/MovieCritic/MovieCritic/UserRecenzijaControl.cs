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
    public partial class UserRecenzijaControl : UserControl
    {
        public UserRecenzijaControl()
        {
            InitializeComponent();
        }

        public void setTxtAutor(string autor)
        {
            txtAutor.Text = autor;
        }

        public void setTxtDatum(string datum)
        {
            txtDatum.Text = datum;
        }

        public void setRichTxt(string recenzija)
        {
            richtxt.Text = recenzija;
        }

        public string getDatum()
        {
            return txtDatum.Text;
        }

        public string getRecenzija()
        {
            return richtxt.Text;
        }
    }
}
