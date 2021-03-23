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
    public partial class OpisRecepta : Form
    {
        public GraphClient client;
        public string recept;

        public OpisRecepta()
        {
            InitializeComponent();
        }

        private void OpisRecepta_Load(object sender, EventArgs e)
        {
            string nazivRecepta = recept;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            txtOpis.Text = recepti[0].opisRecepta;
            if (txtOpis.Text == "")
            {
                btnDodajOpis.Enabled = true;
                btnIzmeniOpis.Enabled = false;
                btnObrisiOpis.Enabled = false;
            }
            else
            {
                btnDodajOpis.Enabled = false;
                btnIzmeniOpis.Enabled = true;
                btnObrisiOpis.Enabled = true;
            }
        }

        private void btnDodajOpis_Click(object sender, EventArgs e)
        {
            if (txtOpis.Text != "")
            {
                string opisRecepta = txtOpis.Text;

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta = '" + recept + "' set n.opisRecepta = '" + opisRecepta + "' return n",
                                                                   new Dictionary<string, object>(), CypherResultMode.Set);

                List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

                this.OpisRecepta_Load(sender, e);
            }
            else
                 MessageBox.Show("Dodajte opis recepta!");
        }

        private void btnIzmeniOpis_Click(object sender, EventArgs e)
        {
            if (txtOpis.Text != "")
            {
                string opisRecepta = txtOpis.Text;

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta = '" + recept + "' set n.opisRecepta = '" + opisRecepta + "' return n",
                                                                   new Dictionary<string, object>(), CypherResultMode.Set);

                List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

                this.OpisRecepta_Load(sender, e);
            }
            else
                MessageBox.Show("Dodajte novi opis recepta!");
        }

        private void btnObrisiOpis_Click(object sender, EventArgs e)
        {
            string opisRecepta = "";

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta = '" + recept + "' set n.opisRecepta = '" + opisRecepta + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            this.OpisRecepta_Load(sender, e);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}