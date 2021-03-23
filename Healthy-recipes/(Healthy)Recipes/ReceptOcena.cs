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
    public partial class ReceptOcena : Form
    {
        public GraphClient client;
        public string recept;
        int brojac = 0;

        public ReceptOcena()
        {
            InitializeComponent();
        }

        private void ReceptOcena_Load(object sender, EventArgs e)
        {
            nazivRecepta.Text = recept;

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:OCENA]-(m) where exists(n.nazivRecepta) and exists(m.ocena) and n.nazivRecepta='" + recept + "' return m",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
            List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();

            if (ocene.Count == 0)
            {
                btnIzmeniOcenu.Enabled = false;
                btnObrisiOcenu.Enabled = false;
                btnDodajOcenu.Enabled = true;
                label3.Visible = true;
                trackBar1.Value = 1;
            }
            else
            {
                btnIzmeniOcenu.Enabled = true;
                btnObrisiOcenu.Enabled = true;
                btnDodajOcenu.Enabled = false;
                label3.Visible = false;
                trackBar1.Value = Convert.ToInt32(ocene[0].ocena);
            }       
        }

        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {
            string ocena = trackBar1.Value.ToString();

            client.Cypher
                    .Match("(recept:Recept), (ocena1:Ocena)")
                    .Where("recept.nazivRecepta='" + recept + "' AND ocena1.ocena='" + ocena + "'")
                    .Create("(recept)<-[:OCENA]-(ocena1)")
                    .ExecuteWithoutResultsAsync();

            brojac = 0;
            timer1.Start();
        }

        private void btnIzmeniOcenu_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:OCENA]-(m) where (n:Recept) and (m:Ocena) and exists(n.nazivRecepta) and exists(m.ocena) and n.nazivRecepta='" + recept + "'  delete r",
                                                            new Dictionary<string, object>(), CypherResultMode.Projection);

            List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();

            string ocena = trackBar1.Value.ToString();
            client.Cypher
                    .Match("(recept:Recept), (ocena1:Ocena)")
                    .Where("recept.nazivRecepta='" + recept + "' AND ocena1.ocena='" + ocena + "'")
                    .Create("(recept)<-[:OCENA]-(ocena1)")
                    .ExecuteWithoutResultsAsync();

            brojac = 0;
            timer1.Start();
        }

        private void btnObrisiOcenu_Click(object sender, EventArgs e)
        {
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:OCENA]-(m) where (n:Recept) and (m:Ocena) and exists(n.nazivRecepta) and exists(m.ocena) and n.nazivRecepta='" + recept + "' delete r",
                                                                new Dictionary<string, object>(), CypherResultMode.Projection);

                List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();
                this.ReceptOcena_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac++;
            if (brojac == 2)
            {
                this.ReceptOcena_Load(sender, e);
            }
        }
    }
}