using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoApplication
{
    public partial class ControlRecenzija : UserControl
    {
        public ControlRecenzija()
        {
            InitializeComponent();
        }

        public void setAutor(string autor)
        {
            labelAutor.Text = autor;
        }

        public void setDatum(string datum)
        {
            labelDatum.Text = datum;
        }

        public void setRecenzija(string recenzija)
        {
            richTextBox.Text = recenzija;
        }
    }
}
