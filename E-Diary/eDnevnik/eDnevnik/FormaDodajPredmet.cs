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
    public partial class FormaDodajPredmet : Form
    {
        PredmetBasic predmetIzmena { get; set; }

        public FormaDodajPredmet(PredmetBasic predmet)
        {
            InitializeComponent();
            predmetIzmena = predmet;
            if (predmet != null)
            {
                btnDodajPredmet.Text = "Izmeni predmet";
                txtNaziv.Text = predmet.Naziv;
                txtOpis.Text = predmet.Opis;
                cbxBlok.SelectedItem = predmet.BlokNastava.ToLower();
                cbxSpecKab.SelectedItem = predmet.SpecijalniKabinet.ToLower();
                cbxTip.SelectedItem = predmet.TipPredmeta.ToLower();
                numericUpDownBrojCasova.Value = predmet.BrojCasvoa;
                numericUpDownMinUcenika.Value = predmet.MinBrUcenika;
            }
             
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            if (btnDodajPredmet.Text == "Dodaj predmet")
            {
                if (!string.IsNullOrEmpty(txtNaziv.Text) && !string.IsNullOrEmpty(txtOpis.Text) && cbxTip.SelectedIndex > -1 && cbxBlok.SelectedIndex > -1 && cbxSpecKab.SelectedIndex > -1)
                {
                    PredmetBasic predmet = new PredmetBasic();
                    predmet.Naziv = txtNaziv.Text;
                    predmet.Opis = txtOpis.Text;
                    predmet.BrojCasvoa = Convert.ToInt32(numericUpDownBrojCasova.Value);
                    predmet.MinBrUcenika = Convert.ToInt32(numericUpDownMinUcenika.Value);
                    predmet.TipPredmeta = cbxTip.SelectedItem.ToString().ToUpper();
                    predmet.SpecijalniKabinet = cbxSpecKab.SelectedItem.ToString().ToUpper();
                    predmet.BlokNastava = cbxBlok.SelectedItem.ToString().ToUpper();

                    DTOManager.SavePredmet(predmet);
                    this.Close();
                }
            }
            else if(btnDodajPredmet.Text=="Izmeni predmet")
            {
                if (!string.IsNullOrEmpty(txtNaziv.Text) && !string.IsNullOrEmpty(txtOpis.Text) && cbxTip.SelectedIndex > -1 && cbxBlok.SelectedIndex > -1 && cbxSpecKab.SelectedIndex > -1)
                {
                    PredmetBasic predmet = new PredmetBasic();
                    predmet.Naziv = txtNaziv.Text;
                    predmet.Opis = txtOpis.Text;
                    predmet.BrojCasvoa = Convert.ToInt32(numericUpDownBrojCasova.Value);
                    predmet.MinBrUcenika = Convert.ToInt32(numericUpDownMinUcenika.Value);
                    predmet.TipPredmeta = cbxTip.SelectedItem.ToString().ToUpper();
                    predmet.SpecijalniKabinet = cbxSpecKab.SelectedItem.ToString().ToUpper();
                    predmet.BlokNastava = cbxBlok.SelectedItem.ToString().ToUpper();

                    DTOManager.UpdatePredmet(predmetIzmena.PredmetId,predmet);
                    this.Close();
                }
            }
        }
    }
}
