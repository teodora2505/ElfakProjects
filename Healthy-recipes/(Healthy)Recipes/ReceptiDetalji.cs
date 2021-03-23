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
    public partial class ReceptiDetalji : Form
    {
        public GraphClient client;
        public string recept;

        public ReceptiDetalji()
        {
            InitializeComponent();
        }

        private void ReceptiDetalji_Load(object sender, EventArgs e)
        {
            string nazivRecepta = recept;
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            Recept r = recepti[0];
            labelaNazivRecepta.Text = r.nazivRecepta;
            labelaTezinaPripreme.Text = r.tezinaPripreme;
            labelaVremePripreme.Text = r.vremePripreme;
            rtbxOpis.Text = r.opisRecepta;

            string nazivSastojka = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivSastojka", nazivSastojka);
            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SADRZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivSastojka) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivSastojka =~ {nazivSastojka} return m",
                                                            queryDict, CypherResultMode.Set);
            List<Sastojak> rSastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
            foreach(Sastojak s in rSastojci)
            {
                lbSastojci.Items.Add(s.nazivSastojka);
            }

            string nazivUkusa = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivUkusa", nazivUkusa);
            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:UKUSA]-(m) where exists(n.nazivRecepta) and exists(m.nazivUkusa) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivUkusa =~ {nazivUkusa} return m",
                                                            queryDict, CypherResultMode.Set);
            List<Ukus> rUkusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();
            labelaUkusi.Text = "";
            foreach (Ukus u in rUkusi)
            {
                labelaUkusi.Text+=u.nazivUkusa+", ";
            }
            if (labelaUkusi.Text != "")
            {
                labelaUkusi.Text = labelaUkusi.Text.Remove(labelaUkusi.Text.Length - 2);
            }

            string nazivObroka = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivObroka", nazivObroka);
            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SLUZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivObroka) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivObroka =~ {nazivObroka} return m",
                                                            queryDict, CypherResultMode.Set);
            List<Obrok> rObroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();
            labelaObrok.Text = "";
            foreach (Obrok o in rObroci)
            {
                labelaObrok.Text += o.nazivObroka + ", ";
            }
            if (labelaUkusi.Text != "")
            {
                labelaObrok.Text = labelaObrok.Text.Remove(labelaObrok.Text.Length - 2);
            }
            

            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:OCENA]-(m) where exists(n.nazivRecepta) and exists(m.ocena) and n.nazivRecepta='" + recept + "' return m",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
            List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();
            labelaOcena.Font= new Font("Arial",24,FontStyle.Regular);
            if (ocene.Count == 0)
            {
                labelaOcena.Text = "☆☆☆☆☆";
            }
            else
            {              
                switch (Convert.ToInt32(ocene[0].ocena))
                {
                    case 1:
                        labelaOcena.Text = "★☆☆☆☆";
                        break;
                    case 2:
                        labelaOcena.Text = "★★☆☆☆";
                        break;
                    case 3:
                        labelaOcena.Text = "★★★☆☆";
                        break;
                    case 4:
                        labelaOcena.Text = "★★★★☆";
                        break;
                    case 5:
                        labelaOcena.Text = "★★★★★";
                        break;
                    default:
                        labelaOcena.Text = "☆☆☆☆☆";
                        break;
                }
            }

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbSastojci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlternative.Items.Clear();
            string s = lbSastojci.SelectedItem.ToString();

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:ALTERNATIVA]->(m) where exists(n.nazivSastojka) and n.nazivSastojka = '" + s + "' return m", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Sastojak> alternative = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
            
            foreach(Sastojak a in alternative)
            lbAlternative.Items.Add(a.nazivSastojka);
        }
    }
}