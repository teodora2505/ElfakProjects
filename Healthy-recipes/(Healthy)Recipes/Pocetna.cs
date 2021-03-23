using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Healthy_Recipes.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace _Healthy_Recipes
{
    public partial class Pocetna : Form
    {
        private GraphClient client;
        public int sec = 0;
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "neo3j");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec==4)
            {
                this.Hide();
                GlavnaForma GlavnaForma = new GlavnaForma();
                GlavnaForma.client = client;
                GlavnaForma.Closed += (s, args) => this.Close();
                GlavnaForma.Show();
            }
        }
    }
}