
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Mongo_DataLayer.Entities;
using Mongo_DataLayer;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;


namespace MongoApplication
{
    public partial class TravelmaniaAdmin : Form
    {
        #region pomocne_promenljive
        int secCount = 0;
        public string logovanIme;
        public string logovanPrezime;
        public string trenutnaOpcija = "logovanje";//"logovanje","garaze"
        public bool slideMenuExpanded = true;

        public string slajdUpravljanjeKorisnicima = "prosiren";
        public string slajdPonude = "prosiren";
        public string slajdOmiljenePonude = "prosiren";
        public string slajdRezervacija = "prosiren";
        public string slajdRecenzije = "prosiren";
        public List<Korisnik> listaKorisnikaOmiljeno;
        public List<Rezervacija> listaRezervacija;
        public List<Recenzija> listaRecenzija;
        public List<string> slikePonude = new List<string>();
        public List<string> slikeIzmena;
        #endregion

        #region funkcije_za_admin_formu

        public TravelmaniaAdmin()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)// Dugme X za zatvaranje forme
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Dugme za minimizaciju forme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slideMenuExpanded = !slideMenuExpanded;
            if (SlideMenu.Width == 50)//kad je slideMenu uvucen
            {
                    
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 200;
                    PanelAnimator.ShowSync(SlideMenu);
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

                if (trenutnaOpcija == "korisnici")
                {
                   
                    slajdUpravljanjeKorisnicima = "prosiren";
                    panelKorisnici.Show();
                    panelPonude.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelKorisnici.Location = new Point(this.panelKorisnici.Location.X + 100, this.panelKorisnici.Location.Y);
                    PanelAnimator2.ShowSync(panelKorisnici);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeKorisnicima.Location.Y);
                }
                else if (trenutnaOpcija == "ponude")
                {
                    
                    slajdPonude = "prosiren";
                    panelPonude.Show();
                    panelKorisnici.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X + 100, this.panelPonude.Location.Y);
                    PanelAnimator2.ShowSync(panelPonude);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
                }
                else if (trenutnaOpcija == "omiljenePonude")
                {
                   
                    slajdOmiljenePonude = "prosiren";
                    panelOmiljeno.Show();
                    panelKorisnici.Hide();
                    panelPonude.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelOmiljeno.Location = new Point(this.panelOmiljeno.Location.X + 100, this.panelOmiljeno.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeno);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);
                }
                else if (trenutnaOpcija == "rezervacija")
                {
                   
                    slajdRezervacija = "prosiren";
                    panelRezervacija.Show();
                    panelKorisnici.Hide();
                    panelPonude.Hide();
                    panelOmiljeno.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRezervacija.Location = new Point(this.panelRezervacija.Location.X + 100, this.panelRezervacija.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervacija);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervisanje.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                
                    slajdRecenzije = "prosiren";
                    panelRecenzije.Show();
                    panelKorisnici.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelPonude.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

                }

                    LogoAnimator.ShowSync(Logo);
            }
            else//kad je slideMenu prosiren
            {

                    LogoAnimator.Hide(Logo);
                    SlideMenu.Visible = false;
                    SlideMenu.Width = 50;
                labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

                if (trenutnaOpcija == "korisnici")
                {
                    
                    slajdUpravljanjeKorisnicima = "uvucen";
                    panelKorisnici.Show();
                    panelPonude.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelKorisnici.Location = new Point(this.panelKorisnici.Location.X - 100, this.panelKorisnici.Location.Y);
                    PanelAnimator2.ShowSync(panelKorisnici);

                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeKorisnicima.Location.Y);
                }
                else if (trenutnaOpcija == "ponude")
                {
                   
                    slajdPonude = "uvucen";
                    panelPonude.Show();
                    panelKorisnici.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X - 100, this.panelPonude.Location.Y);
                    PanelAnimator2.ShowSync(panelPonude);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
                }
                else if (trenutnaOpcija == "omiljenePonude")
                {
               
                    slajdOmiljenePonude = "uvucen";
                    panelOmiljeno.Show();
                    panelPonude.Hide();
                    panelKorisnici.Hide();
                    panelRezervacija.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelOmiljeno.Location = new Point(this.panelOmiljeno.Location.X - 100, this.panelOmiljeno.Location.Y);
                    PanelAnimator2.ShowSync(panelOmiljeno);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);
                }
                else if (trenutnaOpcija == "rezervacija")
                {
                  
                    slajdRezervacija = "uvucen";
                    panelRezervacija.Show();
                    panelPonude.Hide();
                    panelKorisnici.Hide();
                    panelOmiljeno.Hide();
                    panelRecenzije.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRezervacija.Location = new Point(this.panelRezervacija.Location.X - 100, this.panelRezervacija.Location.Y);
                    PanelAnimator2.ShowSync(panelRezervacija);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervisanje.Location.Y);
                }
                else if (trenutnaOpcija == "recenzije")
                {
                   
                    slajdRecenzije = "uvucen";
                    panelRecenzije.Show();
                    panelKorisnici.Hide();
                    panelOmiljeno.Hide();
                    panelRezervacija.Hide();
                    panelPonude.Hide();
                    panelRezervacijeProduzavanja.Hide();
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    PanelAnimator2.ShowSync(panelRecenzije);
                    labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);
                }
             
                    PanelAnimator.ShowSync(SlideMenu);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panelKorisnici.Visible = true;
            this.panelPonude.Visible = false;
            this.panelRezervacija.Visible = false;
            this.panelOmiljeno.Visible = false;
            this.panelRecenzije.Visible = false;
            this.panelRezervacijeProduzavanja.Visible = false;

            this.labelKorisnik.Text = logovanIme + " " + logovanPrezime;
            this.panelKorisniciBrisanje.Visible = false;
            this.panelKorisniciAzuriranje.Visible = false;
            this.panelKorisniciDodavanje.Visible = false;
            dataGridKorisnici.Visible = false;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeKorisnicima.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secCount == 3)
            {
                labelWarning.Visible = false;
                secCount = 0;
                timer1.Stop();
            }
            else
            {
                labelWarning.Visible = true;
                secCount++;
            }
        }

        #endregion

        #region Upravljanje_Korisnicima

        private void buttonUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            if (SlideMenu.Width == 50)
            {
                if (slajdUpravljanjeKorisnicima == "prosiren")
                {
                    this.panelKorisnici.Location = new Point(this.panelKorisnici.Location.X - 100, this.panelKorisnici.Location.Y);
                    slajdUpravljanjeKorisnicima = "uvucen";
                }
            }
            else
            {
                if (slajdUpravljanjeKorisnicima == "uvucen")
                {
                    this.panelKorisnici.Location = new Point(this.panelKorisnici.Location.X + 100, this.panelKorisnici.Location.Y);
                    slajdUpravljanjeKorisnicima = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonUpravljanjeKorisnicima.Location.Y);

            trenutnaOpcija = "korisnici";
            panelPonude.Hide();
            panelOmiljeno.Hide();
            panelRezervacija.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelKorisnici.Show();
            btnKorisniciDodavanje.Visible = true;

            panelKorisniciDodavanje.Visible = false;
            panelKorisniciBrisanje.Visible = false;
            panelKorisniciAzuriranje.Visible = false;
            dataGridKorisnici.Visible = false;
        }

        private void btnKorisniciDodavanje_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.Ime = txtKorisniciDodajIme.Text;
            k.Prezime = txtKorisniciDodajPrezime.Text;
            k.Password = txtKorisniciDodajPass.Text;
            k.Email = txtKorisniciDodajMail.Text;
            if (rdbDodajAdmin.Checked)
                k.Admin = "da";
            else
                k.Admin = "ne";

            if(!string.IsNullOrEmpty(k.Ime)
                && !string.IsNullOrEmpty(k.Prezime)
                && !string.IsNullOrEmpty(k.Password)
                && !string.IsNullOrEmpty(k.Email))
            {
                MongoProvider.dodajKorisnika(k);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje";
                secCount = 0;
                timer1.Start();
                txtKorisniciDodajPass.Text = string.Empty;
                txtKorisniciDodajPrezime.Text = string.Empty;
                txtKorisniciDodajMail.Text = string.Empty;
                txtKorisniciDodajIme.Text = string.Empty;
                rdbDodajKorisnik.Checked = true;
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
            
        }

        private void txtKorisniciStaroMail_OnValueChanged(object sender, EventArgs e)
        {
            string unos = txtKorisniciStaroMail.Text;
            Korisnik k =MongoProvider.vratiKorisnika(unos);
            if(k!=null)
            {
                txtKorisniciNovoIme.Text = k.Ime;
                txtKorisniciNovoMail.Text = k.Email;
                txtKorisniciNovoPass.Text = k.Password;
                txtKorisniciNovoPrezime.Text = k.Prezime;
                if (k.Admin == "da")
                    rdbKorisniciNovoAdmin.Checked = true;
                else
                    rdbKorisniciNovoKorisnik.Checked = true;

                panelPrikaziKorisnika.Visible = true;
                panelPrikaziKorisnika.BringToFront();
                txtKorisniciStaroMail.Enabled = false;
            }
        }

        private void btnKorisniciAzuriranje_Click(object sender, EventArgs e)
        {
            string stariMail = txtKorisniciStaroMail.Text;
            Korisnik k = new Korisnik();
            k.Ime = txtKorisniciNovoIme.Text;
            k.Prezime = txtKorisniciNovoPrezime.Text;
            k.Email = txtKorisniciNovoMail.Text;
            k.Password = txtKorisniciNovoPass.Text;
            if (rdbKorisniciNovoAdmin.Checked)
                k.Admin = "da";
            else
                k.Admin = "ne";

            if(!string.IsNullOrEmpty(k.Ime)
                && !string.IsNullOrEmpty(k.Prezime)
                && !string.IsNullOrEmpty(k.Password)
                && !string.IsNullOrEmpty(k.Email))
            {
                MongoProvider.azurirajKorisnika(stariMail, k);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno ažuriranje";
                secCount = 0;
                timer1.Start();
                panelPrikaziKorisnika.Visible = false;
                txtKorisniciStaroMail.Enabled = true;
                txtKorisniciStaroMail.Text = string.Empty;
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void btnKorisniciUkloniNalog_Click(object sender, EventArgs e)
        {
            string mail = txtKorisniciObrisiMail.Text;
            if(MongoProvider.vratiKorisnika(mail)!=null)
            {
                Korisnik k = MongoProvider.vratiKorisnika(mail);

                //brisanje referenca omiljenih ponuda
                foreach (Omiljeno o in MongoProvider.vratiSveOmiljenePonudeZaKorisnika(k._id))
                {
                    MongoProvider.obrisiOmiljenuPonudu(o);
                }

                //brisanje reference recenzija
                foreach (Recenzija r in MongoProvider.vratiSveRecenzijeZaKorisnika(k._id))
                {
                    MongoProvider.obrisiRecenziju(r);
                }

                //brisanje reference rezervacije
                foreach (Rezervacija rez in MongoProvider.vratiSveRezervacijeZaKorisnika(k._id))
                {
                    MongoProvider.obrisiRezervaciju(rez);
                }

                MongoProvider.obrisiKorisnika(mail);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno uklanjanje";
                secCount = 0;
                timer1.Start();
                txtKorisniciObrisiMail.Text = string.Empty;
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void btnKorisniciDodaj_Click(object sender, EventArgs e)
        {
            panelKorisniciDodavanje.Visible = true;
            panelKorisniciDodavanje.BringToFront();
            panelKorisniciBrisanje.Visible = false;
            panelKorisniciAzuriranje.Visible = false;
            txtKorisniciDodajPass.Text = string.Empty;
            txtKorisniciDodajPrezime.Text = string.Empty;
            txtKorisniciDodajMail.Text = string.Empty;
            txtKorisniciDodajIme.Text = string.Empty;
            rdbDodajKorisnik.Checked = true;
            dataGridKorisnici.Visible = false;
        }

        private void btnKorisniciIzmeni_Click(object sender, EventArgs e)
        {
            panelKorisniciAzuriranje.Visible = true;
            panelKorisniciAzuriranje.BringToFront();
            panelKorisniciBrisanje.Visible = false;
            panelKorisniciDodavanje.Visible = false;
            txtKorisniciStaroMail.Text = string.Empty;
            this.panelPrikaziKorisnika.Visible = false;
            dataGridKorisnici.Visible = false;
        }

        private void btnKorisniciObrisi_Click(object sender, EventArgs e)
        {
            panelKorisniciBrisanje.Visible = true;
            panelKorisniciBrisanje.BringToFront();
            panelKorisniciAzuriranje.Visible = false;
            panelKorisniciDodavanje.Visible = false;
            txtKorisniciObrisiMail.Text = string.Empty;
            dataGridKorisnici.Visible = false;
        }

        private void btnKorisniciPretrazi_Click(object sender, EventArgs e)
        {
            dataGridKorisnici.Visible = true;
            dataGridKorisnici.BringToFront();
            panelKorisniciDodavanje.Visible = false;
            panelKorisniciBrisanje.Visible = false;
            panelKorisniciAzuriranje.Visible = false;

            List<Korisnik> korisnici = MongoProvider.vratiSveKorisnike();
            dataGridKorisnici.Rows.Clear();

            string admin = null;
            foreach (Korisnik k in korisnici)
            {
                if (k.Admin == "da") admin = "✔"; else admin = "✘";
                dataGridKorisnici.Rows.Add(k.Ime, k.Prezime, k.Email, k.Password,admin);
            }

            dataGridKorisnici.Refresh();
        }

        #endregion

        #region Upravljanje_Ponudama_i_Smestajem

        private void buttonPonude_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "ponude";
            panelKorisnici.Hide();
            panelOmiljeno.Hide();
            panelRezervacija.Hide();
            this.panelRecenzije.Hide();
            this.panelRezervacijeProduzavanja.Hide();
            panelPonude.Show();


            if (SlideMenu.Width == 50)
            {
                if (slajdPonude == "prosiren")
                {
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X - 100, this.panelPonude.Location.Y);
                    slajdPonude = "uvucen";
                }
            }
            else
            {
                if (slajdPonude == "uvucen")
                {
                    this.panelPonude.Location = new Point(this.panelPonude.Location.X + 100, this.panelPonude.Location.Y);
                    slajdPonude = "prosiren";
                }
            }

            panelPonudeDodaj.Visible = false;
            panelPonudeObrisi.Visible = false;
            panelPonudeIzmeni.Visible = false;
            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonPonude.Location.Y);
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;

            this.openFileDialog1.Title = "My Image Browser";
        }

        private Image CorrectExifOrientation(Image image)
        {
            if (image == null) return null;
            int orientationId = 0x0112;
            if (image.PropertyIdList.Contains(orientationId))
            {
                var orientation = (int)image.GetPropertyItem(orientationId).Value[0];
                var rotateFlip = RotateFlipType.RotateNoneFlipNone;
                switch (orientation)
                {
                    case 1: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
                    case 2: rotateFlip = RotateFlipType.RotateNoneFlipX; break;
                    case 3: rotateFlip = RotateFlipType.Rotate180FlipNone; break;
                    case 4: rotateFlip = RotateFlipType.Rotate180FlipX; break;
                    case 5: rotateFlip = RotateFlipType.Rotate90FlipX; break;
                    case 6: rotateFlip = RotateFlipType.Rotate90FlipNone; break;
                    case 7: rotateFlip = RotateFlipType.Rotate270FlipX; break;
                    case 8: rotateFlip = RotateFlipType.Rotate270FlipNone; break;
                    default: rotateFlip = RotateFlipType.RotateNoneFlipNone; break;
                }
                if (rotateFlip != RotateFlipType.RotateNoneFlipNone)
                {
                    image.RotateFlip(rotateFlip);
                    image.RemovePropertyItem(orientationId);
                }
            }
            return image;
        }

        private void btnPonudeDodajSlike_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    Image img = CorrectExifOrientation(loadedImage);
                    if (img.Height > img.Width)
                    {
                        pb.Height = 100 * loadedImage.Height / loadedImage.Width;
                        pb.Width = 100;
                    }
                    else
                    {
                        pb.Height = 100;
                        pb.Width = 100 * loadedImage.Width / loadedImage.Height;
                    }
                    string[] niz = file.Split(new string[] { "\\" }, StringSplitOptions.None);

                    pb.Image = img;
                    pb.Image.Save(Application.StartupPath + @"\\..\\..\\..\\Images\\" + niz[niz.Count() - 1]);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(pb);
                    slikePonude.Add(niz[niz.Count() - 1]);
                }
            }
        }

        private void btnPonudeDodaj_Click(object sender, EventArgs e)
        {
            panelPonudeDodaj.Visible = true;
            panelPonudeDodaj.BringToFront();
            panelPonudeObrisi.Visible = false;
            panelPonudeIzmeni.Visible = false;
            txtPonudeDodajDestinacija.Text = string.Empty;
            cbxPonudeDodajPrevoz.SelectedIndex = -1;
            cbxPonudeDodajPrevoz.ResetText();
            cbxPonudeDodajKategorija.SelectedIndex = -1;
            cbxPonudeDodajKategorija.ResetText();
            numPonudeDodajDani.Value = 0;
            numPonudeDodajNoci.Value = 0;
            numPonudeDodajCena.Value = 0;
            numPonudeDodajSoba1.Value = 0;
            numPonudeDodajSoba2.Value = 0;
            numPonudeDodajSoba3.Value = 0;
            numPonudeDodajSoba4.Value = 0;
            dtpPonudeDodajPolazak.Value = DateTime.Now;
            txtPonudeDodajHotel.Text = string.Empty;
            ponudeDodajZvezdice.Value = 0;
            flowLayoutPanel1.Controls.Clear();
            cbxPonudeDodajFirst.Checked = false;
            cbxPonudeDodajLast.Checked = false;
            slikePonude.Clear();
        }

        private void btnDodavanjePonude_Click(object sender, EventArgs e)
        {
            if (slikePonude.Count < 2) //minimum je neophodno dodati 2 slike za oglas!
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Neophodno min 2 slike.";
                secCount = 0;
                timer1.Start();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPonudeDodajDestinacija.Text)
                    && cbxPonudeDodajPrevoz.SelectedIndex > -1
                    && cbxPonudeDodajKategorija.SelectedIndex > -1
                    && numPonudeDodajDani.Value > 0
                    && numPonudeDodajNoci.Value >= 0
                    && !string.IsNullOrEmpty(txtPonudeDodajHotel.Text)
                    && ponudeDodajZvezdice.Value >= 1
                    && numPonudeDodajCena.Value > 0
                    )
                {
                    Ponuda ponuda = new Ponuda();
                    ponuda.Destinacija = txtPonudeDodajDestinacija.Text;
                    ponuda.Prevoz = cbxPonudeDodajPrevoz.SelectedItem.ToString();
                    ponuda.Kategorija = cbxPonudeDodajKategorija.SelectedItem.ToString();
                    ponuda.BrojDana = Convert.ToInt32(numPonudeDodajDani.Value);
                    ponuda.BrojNoci = Convert.ToInt32(numPonudeDodajNoci.Value);
                    ponuda.DatumPolaska = dtpPonudeDodajPolazak.Value.ToString("dd-MM-yyyy");
                    ponuda.Hotel = new Smestaj();
                    ponuda.Hotel._id = ObjectId.GenerateNewId();
                    ponuda.Hotel.NazivHotela = txtPonudeDodajHotel.Text;
                    ponuda.Hotel.BrojZvezdica = Convert.ToInt32(ponudeDodajZvezdice.Value);
                    ponuda.Hotel.BrojJednokrevetnih = Convert.ToInt32(numPonudeDodajSoba1.Value);
                    ponuda.Hotel.BrojDvokrevetnih = Convert.ToInt32(numPonudeDodajSoba2.Value);
                    ponuda.Hotel.BrojTrokrevetnih = Convert.ToInt32(numPonudeDodajSoba3.Value);
                    ponuda.Hotel.BrojCetvorokrevetnih = Convert.ToInt32(numPonudeDodajSoba4.Value);
                    ponuda.CenaPoOsobi = Convert.ToInt32(numPonudeDodajCena.Value);
                    ponuda.Slike = slikePonude;

                    if (cbxPonudeDodajFirst.Checked)
                        ponuda.TipPonude = "First minute";
                    else if (cbxPonudeDodajLast.Checked)
                        ponuda.TipPonude = "Last minute";
                    else
                        ponuda.TipPonude = "Redovna ponuda";

                    MongoProvider.dodajPonudu(ponuda);
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Uspešno dodavanje";
                    slikeIzmena = null;
                    secCount = 0;
                    timer1.Start();
                    txtPonudeDodajDestinacija.Text = string.Empty;
                    cbxPonudeDodajPrevoz.SelectedIndex = -1;
                    cbxPonudeDodajPrevoz.ResetText();
                    cbxPonudeDodajKategorija.SelectedIndex = -1;
                    cbxPonudeDodajKategorija.ResetText();
                    numPonudeDodajDani.Value = 0;
                    numPonudeDodajNoci.Value = 0;
                    numPonudeDodajCena.Value = 0;
                    numPonudeDodajSoba1.Value = 0;
                    numPonudeDodajSoba2.Value = 0;
                    numPonudeDodajSoba3.Value = 0;
                    numPonudeDodajSoba4.Value = 0;
                    dtpPonudeDodajPolazak.Value = DateTime.Now;
                    txtPonudeDodajHotel.Text = string.Empty;
                    ponudeDodajZvezdice.Value = 0;
                    flowLayoutPanel1.Controls.Clear();
                    cbxPonudeDodajFirst.Checked = false;
                    cbxPonudeDodajLast.Checked = false;
                    btnPonudeObrisi_Click(sender, e);

                }
                else
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Pokušajte ponovo";
                    secCount = 0;
                    timer1.Start();
                }
            }
        }

        private void btnPonudeObrisi_Click(object sender, EventArgs e)
        {
            panelPonudeObrisi.Visible = true;
            panelPonudeObrisi.BringToFront();
            panelPonudeDodaj.Visible = false;
            panelPonudaUkloni.Visible = false;
            panelPonudeIzmeni.Visible = false;
            List<Ponuda> ponude = MongoProvider.vratiSvePonude();
            dataGridPonude.Rows.Clear();

            foreach (Ponuda k in ponude)
            {
                dataGridPonude.Rows.Add(k.Destinacija,k.Prevoz,k.Kategorija,k.BrojDana,k.BrojNoci, k.DatumPolaska, k.Hotel.NazivHotela, k.Hotel.BrojZvezdica, k.Hotel.BrojJednokrevetnih,
                                        k.Hotel.BrojDvokrevetnih, k.Hotel.BrojTrokrevetnih, k.Hotel.BrojCetvorokrevetnih, k.CenaPoOsobi, k.TipPonude);
            }

            dataGridPonude.Refresh();

        }

        private void dataGridPonude_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPonudaUkloni.Visible = true;
            Ponuda p= MongoProvider.vratiPonudu(dataGridPonude.CurrentRow.Cells[0].Value.ToString(), dataGridPonude.CurrentRow.Cells[6].Value.ToString(), dataGridPonude.CurrentRow.Cells[5].Value.ToString());
            btnUkloniPonudu.Tag = p;
            btnPonudeIzmeni.Tag = p;
            slikeIzmena = null;
        }

        private void btnPonudaUkloniOdustani_Click(object sender, EventArgs e)
        {
            btnPonudeObrisi_Click(sender, e);
        }

        private void btnUkloniPonudu_Click(object sender, EventArgs e)
        {
            Ponuda p = (Ponuda)btnUkloniPonudu.Tag;
            for (int i = 0; i < p.Slike.Count;i++ )
            {
                try
                {
                    File.Delete(Application.StartupPath + @"\\..\\..\\..\\Images\\" + p.Slike[i]);
                }
                catch (Exception ex)
                {

                }
            }

            //brisanje referenca omiljenih ponuda
            foreach(Omiljeno o in MongoProvider.vratiSveOmiljenePonudeZaPonudu(p._id))
            {
                MongoProvider.obrisiOmiljenuPonudu(o);
            }

            //brisanje reference recenzija
            foreach(Recenzija r in MongoProvider.vratiSveRecenzijeZaPonudu(p._id))
            {
                MongoProvider.obrisiRecenziju(r);
            }

            //brisanje reference rezervacije
            foreach(Rezervacija rez in MongoProvider.vratiSveRezervacijeZaPonudu(p._id))
            {
                MongoProvider.obrisiRezervaciju(rez);
            }

            MongoProvider.obrisiPonudu(p.Destinacija, p.DatumPolaska, p.Kategorija);
            btnPonudeObrisi_Click(sender, e);
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uspešno uklanjanje";
            secCount = 0;
            timer1.Start();
        }

        private void btnPonudeIzmeni_Click(object sender, EventArgs e)
        {
            panelPonudaUkloni.Visible = false;
            panelPonudeObrisi.Visible = false;
            panelPonudeDodaj.Visible = false;
            panelPonudeIzmeni.Visible = true;
            panelPonudeIzmeni.BringToFront();
            flowLayoutPanel2.Controls.Clear();

            izmenaFlowPanel();
            Ponuda p = (Ponuda)btnPonudeIzmeni.Tag;

            txtPonudeIzmeniDestinacija.Text = p.Destinacija;
            int prevoz = -1;
            if (p.Prevoz == "sopstveni") prevoz = 0;
            else if (p.Prevoz == "autobus") prevoz = 1;
            else if (p.Prevoz == "avion") prevoz = 2;
            int kategorija = -1;
            if (p.Kategorija == "letovanje") kategorija = 0;
            else if (p.Kategorija == "zimovanje") kategorija = 1;
            else if (p.Kategorija == "izlet") kategorija = 2;
            else if (p.Kategorija == "banja") kategorija = 3;
            else if (p.Kategorija == "gradovi Evrope") kategorija = 4;
            else if (p.Kategorija == "daleke destinacije") kategorija = 5;
            else if (p.Kategorija == "krstarenje") kategorija = 6;
            else if (p.Kategorija == "Nova Godina") kategorija = 7;
            cbxPonudeIzmeniPrevoz.SelectedIndex = prevoz;
            cbxPonudeIzmeniKategorija.SelectedIndex = kategorija;
            numPonudeIzmeniDani.Value = p.BrojDana;
            numPonudeIzmeniNoci.Value = p.BrojNoci;
            dtpPonudeIzmeniPolazak.Value = DateTime.ParseExact(p.DatumPolaska, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            PonudeIzmeniHotel.Text = p.Hotel.NazivHotela;
            PonudeIzmeniZvezdice.Value = p.Hotel.BrojZvezdica;
            numPonudeIzmeniKrevet1.Value = p.Hotel.BrojJednokrevetnih;
            numPonudeIzmeniKrevet2.Value = p.Hotel.BrojDvokrevetnih;
            numPonudeIzmeniKrevet3.Value = p.Hotel.BrojTrokrevetnih;
            numPonudeIzmeniKrevet4.Value = p.Hotel.BrojCetvorokrevetnih;
            numPonudeIzmeniCena.Value = p.CenaPoOsobi;
            if (p.TipPonude == "First minute")
                cbxPonudeIzmeniFirst.Checked = true;
            else if (p.TipPonude == "Last minute")
                cbxPonudeIzmeniLast.Checked = true;
        }

        public void izmenaFlowPanel()
        {
            flowLayoutPanel2.Controls.Clear();
            Ponuda p = (Ponuda)btnPonudeIzmeni.Tag;

            if (slikeIzmena == null)
            {
                if(p.Slike.Count>0)
                slikeIzmena = new List<string>();

                for (int i = 0; i < p.Slike.Count; i++)
                {
                    PictureBox pic = new PictureBox();
                    Button but = new Button();
                    but.Text = "Ukloni";
                    but.BackColor = Color.FromArgb(26, 32, 40);
                    but.ForeColor = Color.White;
                    but.Width = 120;
                    but.Height = 30;
                    string putanjaSlike = Application.StartupPath + @"\\..\\..\\..\\Images\\" + p.Slike[i];
                    but.Tag = putanjaSlike;
                    slikeIzmena.Add(putanjaSlike);
                    but.Click += new EventHandler(butClick_Click);
                    pic.Size = new Size(200, 200);
                    pic.Name = "pic" + i;
                    Image image = Image.FromFile(Application.StartupPath + @"\\..\\..\\..\\Images\\" + p.Slike[i]);
                    pic.Image = image;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel2.Controls.Add(pic);
                    flowLayoutPanel2.Controls.Add(but);
                }
            }
            else
            {
                for (int i = 0; i < slikeIzmena.Count; i++)
                {
                    PictureBox pic = new PictureBox();
                    Button but = new Button();
                    but.Name = "but" + i;
                    but.Text = "Ukloni";
                    but.BackColor = Color.FromArgb(26, 32, 40);
                    but.ForeColor = Color.White;
                    but.Width = 120;
                    but.Height = 30;
                    but.Tag = slikeIzmena[i];
                    but.Click += new EventHandler(butClick_Click);
                    pic.Size = new Size(200, 200);
                    pic.Name = "pic" + i;
                    Image image = Image.FromFile(slikeIzmena[i]);
                    pic.Image = image;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel2.Controls.Add(pic);
                    flowLayoutPanel2.Controls.Add(but);
                }
            }

            flowLayoutPanel2.Refresh();
        }

        protected void butClick_Click(object sender, EventArgs e)
        {
            
            Button but = sender as Button;
            string str_uploadpath = Application.StartupPath + @"\\..\\..\..\\Images\\";
            try
            {
                File.Delete(Path.Combine(str_uploadpath, but.Tag.ToString()));
            }
            catch (Exception ex)
            {

            }
            slikeIzmena = slikeIzmena.Where(x => x != but.Tag.ToString()).ToList();
            izmenaFlowPanel();
        }

        private void btnPonudeIzmeniDodajSlike_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
               // slikePonude.Clear();
                if (slikeIzmena == null)
                    slikeIzmena = new List<string>();

                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    Image loadedImage = Image.FromFile(file);
                    Image img = CorrectExifOrientation(loadedImage); 
                    string[] niz = file.Split(new string[] { "\\" }, StringSplitOptions.None);
                    if(!File.Exists(Application.StartupPath + @"\\..\\..\\..\\Images\\" + niz[niz.Count() - 1]))
                    {
                        img.Save(Application.StartupPath + @"\\..\\..\\..\\Images\\" + niz[niz.Count() - 1]);
                    }
                    slikeIzmena.Add(Application.StartupPath + @"\\..\\..\\..\\Images\\" + niz[niz.Count() - 1]);
                    izmenaFlowPanel();
                }
            }
        }

        private void btnIzmeniPonudu_Click(object sender, EventArgs e)
        {
            if (slikeIzmena.Count < 2) //minimum je neophodno dodati 2 slike za oglas!
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Neophodno min 2 slike.";
                secCount = 0;
                timer1.Start();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtPonudeIzmeniDestinacija.Text)
                     && cbxPonudeIzmeniPrevoz.SelectedIndex > -1
                     && cbxPonudeIzmeniKategorija.SelectedIndex > -1
                     && numPonudeIzmeniDani.Value > 0
                     && numPonudeIzmeniNoci.Value >= 0
                     && !string.IsNullOrEmpty(PonudeIzmeniHotel.Text)
                     && PonudeIzmeniZvezdice.Value >= 1
                     && numPonudeIzmeniCena.Value > 0
                   )
                {
                    Ponuda staraPonuda = (Ponuda)btnPonudeIzmeni.Tag;
                    Ponuda novaPonuda = new Ponuda();
                    novaPonuda.Destinacija = txtPonudeIzmeniDestinacija.Text;
                    novaPonuda.Prevoz = cbxPonudeIzmeniPrevoz.SelectedItem.ToString();
                    novaPonuda.Kategorija = cbxPonudeIzmeniKategorija.SelectedItem.ToString();
                    novaPonuda.BrojDana = Convert.ToInt32(numPonudeIzmeniDani.Value);
                    novaPonuda.BrojNoci = Convert.ToInt32(numPonudeIzmeniNoci.Value);
                    novaPonuda.DatumPolaska = dtpPonudeIzmeniPolazak.Value.ToString("dd-MM-yyyy");
                    novaPonuda.Hotel = new Smestaj();
                    novaPonuda.Hotel._id = staraPonuda.Hotel._id;
                    novaPonuda.Hotel.NazivHotela = PonudeIzmeniHotel.Text;
                    novaPonuda.Hotel.BrojZvezdica = Convert.ToInt32(PonudeIzmeniZvezdice.Value);
                    novaPonuda.Hotel.BrojJednokrevetnih = Convert.ToInt32(numPonudeIzmeniKrevet1.Value);
                    novaPonuda.Hotel.BrojDvokrevetnih = Convert.ToInt32(numPonudeIzmeniKrevet2.Value);
                    novaPonuda.Hotel.BrojTrokrevetnih = Convert.ToInt32(numPonudeIzmeniKrevet3.Value);
                    novaPonuda.Hotel.BrojCetvorokrevetnih = Convert.ToInt32(numPonudeIzmeniKrevet4.Value);
                    novaPonuda.CenaPoOsobi = Convert.ToInt32(numPonudeIzmeniCena.Value);
                    if (cbxPonudeIzmeniFirst.Checked)
                        novaPonuda.TipPonude = "First minute";
                    else if (cbxPonudeIzmeniLast.Checked)
                        novaPonuda.TipPonude = "Last minute";
                    else
                        novaPonuda.TipPonude = "Redovna ponuda";

                    for (int i = 0; i < slikeIzmena.Count; i++)
                    {
                        string[] niz = slikeIzmena[i].Split(new string[] { "\\" }, StringSplitOptions.None);
                        slikeIzmena[i] = niz[niz.Count() - 1];
                    }
                    novaPonuda.Slike = slikeIzmena;
                    //fizicko brisanje obrisanih slika za datu ponudu koja je izmenjena
                    foreach (string slika in staraPonuda.Slike)
                    {
                        bool obrisana = true;
                        foreach (string slika1 in novaPonuda.Slike)
                        {
                            if (slika == slika1)
                                obrisana = false;
                        }

                        if (obrisana == true)
                        {
                            try
                            {
                                File.Delete(Application.StartupPath + @"\\..\\..\\..\\Images\\" + slika);
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                    MongoProvider.azurirajPonudu(staraPonuda, novaPonuda);
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Uspešna izmena";
                    secCount = 0;
                    timer1.Start();
                    slikeIzmena = null;
                    btnPonudeObrisi_Click(sender, e);
                }
                else
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Pokušajte ponovo";
                    secCount = 0;
                    timer1.Start();
                }
            }
        }

        private void cbxPonudeIzmeniLast_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPonudeIzmeniLast.Checked)
                cbxPonudeIzmeniFirst.Checked = false;
        }

        private void cbxPonudeIzmeniFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPonudeIzmeniFirst.Checked)
                cbxPonudeIzmeniLast.Checked = false;
        }

        private void cbxPonudeDodajLast_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPonudeDodajLast.Checked)
                cbxPonudeDodajFirst.Checked = false;
        }

        private void cbxPonudeDodajFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPonudeDodajFirst.Checked)
                cbxPonudeDodajLast.Checked = false;
        }

        #endregion

        #region Upravljanje_OmiljenimPonudama

        private void buttonOmiljenePonude_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "omiljenePonude";
            panelKorisnici.Hide();
            panelPonude.Hide();
            panelRezervacija.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelOmiljeno.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdOmiljenePonude == "prosiren")
                {
                    this.panelOmiljeno.Location = new Point(this.panelOmiljeno.Location.X - 150, this.panelOmiljeno.Location.Y);
                    slajdOmiljenePonude = "uvucen";
                }
            }
            else
            {
                if (slajdOmiljenePonude == "uvucen")
                {
                    this.panelOmiljeno.Location = new Point(this.panelOmiljeno.Location.X + 150, this.panelOmiljeno.Location.Y);
                    slajdOmiljenePonude = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonOmiljenePonude.Location.Y);

            datagridOmiljenePonude.Rows.Clear();

            listaKorisnikaOmiljeno = new List<Korisnik>();
            foreach(Korisnik k in MongoProvider.vratiSveKorisnike())
            {
                
                foreach(Ponuda p in MongoProvider.vratiSveKorisnikoveOmiljenePonude(k._id))
                {
                    listaKorisnikaOmiljeno.Add(k);
                    datagridOmiljenePonude.Rows.Add(k._id, k.Ime+" "+k.Prezime, k.Email, p.Destinacija, p.Kategorija, p.DatumPolaska, p.Hotel.NazivHotela);
                }
            }
            datagridOmiljenePonude.Refresh();

            refreshCombosOmiljeno();
            
        }

        public void refreshCombosOmiljeno()
        {
            omiljenoDestinacija.Visible = false;
            omiljenoDestinacijaLab.Visible = false;
            omiljenoKorisnik.Visible = false;
            omiljenoKorisnikLab.Visible = false;

            omiljenoKorisnikID.SelectedIndex = -1;
            omiljenoKorisnikID.ResetText();
            omiljenoKorisnikID.Items.Clear();
            omiljenoPonudaID.SelectedIndex = -1;
            omiljenoPonudaID.ResetText();
            omiljenoPonudaID.Items.Clear();
            panelOmiljenoUkloni.Visible = false;
            foreach (Korisnik k in MongoProvider.vratiSveKorisnike())
                omiljenoKorisnikID.Items.Add(k._id.ToString());
            foreach (Ponuda p in MongoProvider.vratiSvePonude())
                omiljenoPonudaID.Items.Add(p._id.ToString());
        }

        private void btnOmiljenoDodaj_Click(object sender, EventArgs e)
        {
            Korisnik k= MongoProvider.vratiKorisnika(ObjectId.Parse(omiljenoKorisnikID.SelectedItem.ToString()));
            Ponuda p = MongoProvider.vratiPonudu(ObjectId.Parse(omiljenoPonudaID.SelectedItem.ToString()));
            if(k!=null && p!=null && MongoProvider.vratiOmiljenuPonudu(k._id,p._id)==null)
            {
                Omiljeno o= new Omiljeno();
                o.Korisnik= new MongoDBRef("Korisnici",k._id);
                o.Ponuda= new MongoDBRef("Ponude",p._id);
                MongoProvider.dodajOmiljenuPonudu(o);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Uspešno dodavanje";
                secCount = 0;
                buttonOmiljenePonude_Click(sender, e);
                refreshCombosOmiljeno();
                timer1.Start();

            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
            
        }

        private void datagridOmiljenePonude_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ponuda p = MongoProvider.vratiPonudu(datagridOmiljenePonude.CurrentRow.Cells[3].Value.ToString(), datagridOmiljenePonude.CurrentRow.Cells[6].Value.ToString(), datagridOmiljenePonude.CurrentRow.Cells[5].Value.ToString());
            panelOmiljenoUkloni.Visible = true;
        }

        private void btnOmiljenoUkloni_Click(object sender, EventArgs e)
        {
            Ponuda p = MongoProvider.vratiPonudu(datagridOmiljenePonude.CurrentRow.Cells[3].Value.ToString(), datagridOmiljenePonude.CurrentRow.Cells[6].Value.ToString(), datagridOmiljenePonude.CurrentRow.Cells[5].Value.ToString());
            Omiljeno o = new Omiljeno();
            Korisnik k = listaKorisnikaOmiljeno[datagridOmiljenePonude.CurrentRow.Index];
            o = MongoProvider.vratiOmiljenuPonudu(listaKorisnikaOmiljeno[datagridOmiljenePonude.CurrentRow.Index]._id, p._id);
            MongoProvider.obrisiOmiljenuPonudu(o);
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Uspešno uklonjeno";
            secCount = 0;
            timer1.Start();
            buttonOmiljenePonude_Click(sender, e);
        }

        private void omiljenoKorisnikID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (omiljenoKorisnikID.SelectedIndex > -1)
            {
                Korisnik k = MongoProvider.vratiKorisnika(ObjectId.Parse(omiljenoKorisnikID.SelectedItem.ToString()));
                omiljenoKorisnik.Text = k.Ime + " " + k.Prezime;
                omiljenoKorisnik.Visible = true;
                omiljenoKorisnikLab.Visible = true;
            }
        }

        private void omiljenoPonudaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (omiljenoPonudaID.SelectedIndex > -1)
            {
                Ponuda k = MongoProvider.vratiPonudu(ObjectId.Parse(omiljenoPonudaID.SelectedItem.ToString()));
                omiljenoDestinacija.Text = k.Destinacija + ", " + k.DatumPolaska;
                omiljenoDestinacija.Visible = true;
                omiljenoDestinacijaLab.Visible = true;
            }
        }

        #endregion

        #region Upravljanje_Rezervacijama

        private void buttonRezervisanje_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "rezervacija";
            panelKorisnici.Hide();
            panelPonude.Hide();
            panelOmiljeno.Hide();
            panelRecenzije.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelRezervacija.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdRezervacija == "prosiren")
                {
                    this.panelRezervacija.Location = new Point(this.panelRezervacija.Location.X - 100, this.panelRezervacija.Location.Y);
                    slajdRezervacija = "uvucen";
                }
            }
            else
            {
                if (slajdRezervacija == "uvucen")
                {
                    this.panelRezervacija.Location = new Point(this.panelRezervacija.Location.X + 100, this.panelRezervacija.Location.Y);
                    slajdRezervacija = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRezervisanje.Location.Y);

            dataGridRezervacije.Rows.Clear();

            listaRezervacija = new List<Rezervacija>();
            foreach(Rezervacija r in MongoProvider.vratiSveRezervacije())
            {
                Korisnik k = MongoProvider.vratiKorisnikaRezervacije(r._id);
                Ponuda p = MongoProvider.vratiRezervisanuPonudu(r._id);
                listaRezervacija.Add(r);
                int ukupnaCena=p.CenaPoOsobi;
                if(r.Soba=="jednokrevetna") ukupnaCena*=1;
                else if(r.Soba=="dvokrevetna") ukupnaCena*=2;
                else if(r.Soba=="trokrevetna") ukupnaCena*=3;
                else if(r.Soba=="cetvorokrevetna") ukupnaCena*=4;
                dataGridRezervacije.Rows.Add(p.Destinacija,p.DatumPolaska,p.Hotel.NazivHotela,r.Soba,ukupnaCena,k._id,k.Ime+" "+k.Prezime,k.Email);
            }
            dataGridRezervacije.Refresh();
            refreshCombosRezervacije();
            rdbk1.Checked = true;
            panelAzurirajRezervaciju.Visible = false;
        }

        public void refreshCombosRezervacije()
        {
            rezervacijePonuda.Visible = false;
            rezervacijePonudaLab.Visible = false;
            rezervacijeKorisnik.Visible = false;
            rezervacijeKorisnikLab.Visible = false;

            rezervacijeKorisnikID.SelectedIndex = -1;
            rezervacijeKorisnikID.ResetText();
            rezervacijeKorisnikID.Items.Clear();
            rezervacijePonudaID.SelectedIndex = -1;
            rezervacijePonudaID.ResetText();
            rezervacijePonudaID.Items.Clear();

            foreach (Korisnik k in MongoProvider.vratiSveKorisnike())
                rezervacijeKorisnikID.Items.Add(k._id.ToString());
            foreach (Ponuda p in MongoProvider.vratiSvePonude())
                rezervacijePonudaID.Items.Add(p._id.ToString());
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            Korisnik k = MongoProvider.vratiKorisnika(ObjectId.Parse(rezervacijeKorisnikID.SelectedItem.ToString()));
            Ponuda p = MongoProvider.vratiPonudu(ObjectId.Parse(rezervacijePonudaID.SelectedItem.ToString()));

            if (k != null && p != null && MongoProvider.vratiRezervaciju(k._id, p._id) == null)
            {
                Rezervacija r = new Rezervacija();
                if((rdbk1.Checked==true && p.Hotel.BrojJednokrevetnih<=0)
                    ||(rdbk2.Checked==true && p.Hotel.BrojDvokrevetnih<=0)
                    ||(rdbk3.Checked==true && p.Hotel.BrojTrokrevetnih<=0)
                    ||(rdbk4.Checked==true && p.Hotel.BrojCetvorokrevetnih<=0))
                {
                    labelWarning.ForeColor = Color.Red;
                    labelWarning.Text = "Nema takvih soba.";
                    secCount = 0;
                    timer1.Start();
                }
                else
                {
                    Ponuda nova = p;
                    if(rdbk1.Checked)
                    {
                        nova.Hotel.BrojJednokrevetnih = p.Hotel.BrojJednokrevetnih - 1;
                        r.Soba = "jednokrevetna";
                    }
                    else if(rdbk2.Checked)
                    {
                        nova.Hotel.BrojDvokrevetnih = p.Hotel.BrojDvokrevetnih - 1;
                        r.Soba = "dvokrevetna";
                    }
                    else if(rdbk3.Checked)
                    {
                        nova.Hotel.BrojTrokrevetnih = p.Hotel.BrojTrokrevetnih - 1;
                        r.Soba = "trokrevetna";
                    }
                    else if(rdbk4.Checked)
                    {
                        nova.Hotel.BrojCetvorokrevetnih = p.Hotel.BrojCetvorokrevetnih - 1;
                        r.Soba = "cetvorokrevetna";
                    }
                    else
                    {
                        nova.Hotel.BrojJednokrevetnih = p.Hotel.BrojJednokrevetnih - 1;
                        r.Soba = "jednokrevetna";
                    }
                    r.DatumRezervisanja = DateTime.Now;
                    r.Korisnik = new MongoDBRef("Korisnici", k._id);
                    r.Ponuda = new MongoDBRef("Ponude", p._id);
                    MongoProvider.dodajRezervaciju(r);
                    MongoProvider.azurirajPonudu(p, nova);
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Uspešna rezervacija";
                    refreshCombosRezervacije();
                    secCount = 0;
                    buttonRezervisanje_Click(sender, e);
                    timer1.Start();
                }
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void dataGridRezervacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelAzurirajRezervaciju.Visible = true;
            Rezervacija r = listaRezervacija[dataGridRezervacije.CurrentRow.Index];
            if (r.Soba == "jednokrevetna")
                rdbAzurk1.Checked = true;
            else if (r.Soba == "dvokrevetna") rdbAzurk2.Checked = true;
            else if (r.Soba == "trokrevetna") rdbAzurk3.Checked = true;
            else if (r.Soba == "cetvorokrevetna") rdbAzurk4.Checked = true;
            else rdbAzurk1.Checked = true;
        }

        private void btnAzurirajRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacija r = listaRezervacija[dataGridRezervacije.CurrentRow.Index];
            Ponuda p = MongoProvider.vratiRezervisanuPonudu(r._id);
            Ponuda nova = p;
            if ((rdbAzurk1.Checked == true && p.Hotel.BrojJednokrevetnih <= 0)
                    || (rdbAzurk2.Checked == true && p.Hotel.BrojDvokrevetnih <= 0)
                    || (rdbAzurk3.Checked == true && p.Hotel.BrojTrokrevetnih <= 0)
                    || (rdbAzurk4.Checked == true && p.Hotel.BrojCetvorokrevetnih <= 0))
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Nema takvih soba.";
                secCount = 0;
                timer1.Start();
            }
            else
            {
                if (r.Soba == "jednokrevetna") nova.Hotel.BrojJednokrevetnih += 1;
                else if (r.Soba == "dvokrevetna") nova.Hotel.BrojDvokrevetnih += 1;
                else if (r.Soba == "trokrevetna") nova.Hotel.BrojTrokrevetnih += 1;
                else if(r.Soba=="cetvorokrevetna") nova.Hotel.BrojCetvorokrevetnih+=1;

                if (rdbAzurk1.Checked)
                {
                    nova.Hotel.BrojJednokrevetnih = p.Hotel.BrojJednokrevetnih - 1;
                    r.Soba = "jednokrevetna";
                }
                else if (rdbAzurk2.Checked)
                {
                    nova.Hotel.BrojDvokrevetnih = p.Hotel.BrojDvokrevetnih - 1;
                    r.Soba = "dvokrevetna";
                }
                else if (rdbAzurk3.Checked)
                {
                    nova.Hotel.BrojTrokrevetnih = p.Hotel.BrojTrokrevetnih - 1;
                    r.Soba = "trokrevetna";
                }
                else if (rdbAzurk4.Checked)
                {
                    nova.Hotel.BrojCetvorokrevetnih = p.Hotel.BrojCetvorokrevetnih - 1;
                    r.Soba = "cetvorokrevetna";
                }
                else
                {
                    nova.Hotel.BrojJednokrevetnih = p.Hotel.BrojJednokrevetnih - 1;
                    r.Soba = "jednokrevetna";
                }

                MongoProvider.azurirajRezervaciju(r.Soba, r);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Rezervacija azurirana";
                secCount = 0;
                timer1.Start();
                MongoProvider.azurirajPonudu(p, nova);
                buttonRezervisanje_Click(sender, e);
            }
        }

        private void btnOtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacija r =listaRezervacija[dataGridRezervacije.CurrentRow.Index];
            Ponuda stara = MongoProvider.vratiRezervisanuPonudu(r._id);
            Ponuda nova = stara;
            if (r.Soba == "jednokrevetna")
            {
                nova.Hotel.BrojJednokrevetnih = stara.Hotel.BrojJednokrevetnih + 1;
            }
            else if (r.Soba == "dvokrevetna")
            {
                nova.Hotel.BrojDvokrevetnih = stara.Hotel.BrojDvokrevetnih + 1;
            }
            else if (r.Soba == "trokrevetna")
            {
                nova.Hotel.BrojTrokrevetnih = stara.Hotel.BrojTrokrevetnih + 1;
            }
            else if (r.Soba == "cetvorokrevetna")
            {
                nova.Hotel.BrojCetvorokrevetnih = stara.Hotel.BrojCetvorokrevetnih + 1;
            }
            MongoProvider.obrisiRezervaciju(r);
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Rezervacija otkazana";
            secCount = 0;
            timer1.Start();
            MongoProvider.azurirajPonudu(stara, nova);
            buttonRezervisanje_Click(sender, e);
        }

        private void rezervacijeKorisnikID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rezervacijeKorisnikID.SelectedIndex > -1)
            {
                Korisnik k = MongoProvider.vratiKorisnika(ObjectId.Parse(rezervacijeKorisnikID.SelectedItem.ToString()));
                rezervacijeKorisnik.Text = k.Ime + " " + k.Prezime;
                rezervacijeKorisnik.Visible = true;
                rezervacijeKorisnikLab.Visible = true;
            }
        }

        private void rezervacijePonudaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rezervacijePonudaID.SelectedIndex > -1)
            {
                Ponuda k = MongoProvider.vratiPonudu(ObjectId.Parse(rezervacijePonudaID.SelectedItem.ToString()));
                rezervacijePonuda.Text = k.Destinacija + ", " + k.DatumPolaska;
                rezervacijePonuda.Visible = true;
                rezervacijePonudaLab.Visible = true;
            }
        }

        #endregion

        #region Upravljanje_Recenzijama

        private void buttonRecenzije_Click(object sender, EventArgs e)
        {
            trenutnaOpcija = "recenzije";
            panelKorisnici.Hide();
            panelOmiljeno.Hide();
            panelRezervacija.Hide();
            panelPonude.Hide();
            panelRezervacijeProduzavanja.Hide();
            panelRecenzije.Show();

            if (SlideMenu.Width == 50)
            {
                if (slajdRecenzije == "prosiren")
                {
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X - 100, this.panelRecenzije.Location.Y);
                    slajdRecenzije = "uvucen";
                }
            }
            else
            {
                if (slajdRecenzije == "uvucen")
                {
                    this.panelRecenzije.Location = new Point(this.panelRecenzije.Location.X + 100, this.panelRecenzije.Location.Y);
                    slajdRecenzije = "prosiren";
                }
            }

            labelSelectedButton.Location = new Point(SlideMenu.Width - 3, buttonRecenzije.Location.Y);

            dataGridRecenzije.Rows.Clear();

            listaRecenzija = new List<Recenzija>();

            foreach (Recenzija r in MongoProvider.vratiSveRecenzije())
            {
                Korisnik k = MongoProvider.vratiAutoraRecenzije(r._id);
                Ponuda p = MongoProvider.vratiPonuduRecenzije(r._id);
                listaRecenzija.Add(r);
                dataGridRecenzije.Rows.Add( k._id, k.Ime + " " + k.Prezime, k.Email,r.Datum.ToString("dd-MM-yyyy"), r.TekstRecenzije, p.Destinacija, p.DatumPolaska, p.Hotel.NazivHotela);
            }
            dataGridRecenzije.Refresh();
            refreshCombosRecenzije();
            richTextBoxRecenzijaDodaj.Text = string.Empty;
            panelAzurirajRecenziju.Visible = false;
        }

        public void refreshCombosRecenzije()
        {
            recenzijePonuda.Visible = false;
            recenzijePonudaLab.Visible = false;
            recenzijeKorisnik.Visible = false;
            recenzijeKorisnikLab.Visible = false;

            recenzijeKorisnikID.SelectedIndex = -1;
            recenzijeKorisnikID.ResetText();
            recenzijeKorisnikID.Items.Clear();
            recenzijePonudaID.SelectedIndex = -1;
            recenzijePonudaID.ResetText();
            recenzijePonudaID.Items.Clear();

            foreach (Korisnik k in MongoProvider.vratiSveKorisnike())
                recenzijeKorisnikID.Items.Add(k._id.ToString());
            foreach (Ponuda p in MongoProvider.vratiSvePonude())
                recenzijePonudaID.Items.Add(p._id.ToString());
        }

        private void btnRecenzijaDodaj_Click(object sender, EventArgs e)
        {
            Recenzija r = new Recenzija();
            Korisnik k = MongoProvider.vratiKorisnika(ObjectId.Parse(recenzijeKorisnikID.SelectedItem.ToString()));
            Ponuda p = MongoProvider.vratiPonudu(ObjectId.Parse(recenzijePonudaID.SelectedItem.ToString()));
            r.Ponuda = new MongoDBRef("Ponude", p._id);
            r.Korisnik = new MongoDBRef("Korisnici", k._id);
            r.Datum = DateTime.Now;
            r.TekstRecenzije = richTextBoxRecenzijaDodaj.Text;
            if(!string.IsNullOrEmpty(r.TekstRecenzije))
            {
                MongoProvider.dodajRecenziju(r);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Recenzija dodata";
                refreshCombosRecenzije();
                secCount = 0;
                timer1.Start();
                buttonRecenzije_Click(sender, e);
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void dataGridRecenzije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelAzurirajRecenziju.Visible = true;
            Recenzija r = listaRecenzija[dataGridRecenzije.CurrentRow.Index];
            richTextBoxAzurirajRecenziju.Text = r.TekstRecenzije;
            btnAzurirajRecenziju.Tag = r;
            btnUkloniRecenziju.Tag = r;
        }

        private void btnAzurirajRecenziju_Click(object sender, EventArgs e)
        {
            string novaRec = richTextBoxAzurirajRecenziju.Text;
            Recenzija r = (Recenzija)btnAzurirajRecenziju.Tag;
            if(!string.IsNullOrEmpty(novaRec))
            {
                MongoProvider.azurirajRecenziju(novaRec,r);
                labelWarning.ForeColor = Color.Green;
                labelWarning.Text = "Recenzija ažurirana";
                secCount = 0;
                timer1.Start();
                buttonRecenzije_Click(sender, e);
            }
            else
            {
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Pokušajte ponovo";
                secCount = 0;
                timer1.Start();
            }
        }

        private void btnUkloniRecenziju_Click(object sender, EventArgs e)
        {
            Recenzija r = (Recenzija)btnUkloniRecenziju.Tag;
            MongoProvider.obrisiRecenziju(r);
            labelWarning.ForeColor = Color.Green;
            labelWarning.Text = "Recenzija uklonjena";
            secCount = 0;
            timer1.Start();
            buttonRecenzije_Click(sender, e);
        }

        private void recenzijeKorisnikID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recenzijeKorisnikID.SelectedIndex > -1)
            {
                Korisnik k = MongoProvider.vratiKorisnika(ObjectId.Parse(recenzijeKorisnikID.SelectedItem.ToString()));
                recenzijeKorisnik.Text = k.Ime + " " + k.Prezime;
                recenzijeKorisnik.Visible = true;
                recenzijeKorisnikLab.Visible = true;
            }
        }

        private void recenzijePonudaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recenzijePonudaID.SelectedIndex > -1)
            {
                Ponuda k = MongoProvider.vratiPonudu(ObjectId.Parse(recenzijePonudaID.SelectedItem.ToString()));
                recenzijePonuda.Text = k.Destinacija + ", " + k.DatumPolaska;
                recenzijePonuda.Visible = true;
                recenzijePonudaLab.Visible = true;
            }
        }

        #endregion
    }


}
