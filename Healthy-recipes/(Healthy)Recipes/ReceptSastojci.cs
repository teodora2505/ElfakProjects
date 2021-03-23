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
    public partial class ReceptSastojci : Form
    {
        public GraphClient client;
        public string recept;

        public ReceptSastojci()
        {
            InitializeComponent();
        }

        private void ReceptSastojci_Load(object sender, EventArgs e)
        {
            dgvRaspolozivi.DataSource = null;
            dgvRaspolozivi.Rows.Clear();
            dgvSastojci.DataSource = null;
            dgvSastojci.Rows.Clear();

            string nazivSastojka = ".*.*";
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivSastojka", nazivSastojka);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.nazivSastojka) and n.nazivSastojka =~ {nazivSastojka} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

            foreach (Sastojak s in sastojci)
            {
                query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SADRZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivSastojka) and n.nazivRecepta='" + recept + "' and m.nazivSastojka = '" + s.nazivSastojka + "' return m",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
                List<Sastojak> rSastojak = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
                if (rSastojak.Count == 0)
                    dgvRaspolozivi.Rows.Add(s.nazivSastojka);
                else
                    dgvSastojci.Rows.Add(s.nazivSastojka);
            }

            dgvRaspolozivi.ClearSelection();
            dgvSastojci.ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvRaspolozivi.SelectedRows.Count > 0)
            {
                if (dgvRaspolozivi.SelectedRows[0].Cells[0].Value == null)
                    return;
                string nazivSastojka = dgvRaspolozivi.SelectedRows[0].Cells[0].Value.ToString();

                client.Cypher
                    .Match("(recept:Recept), (sastojak:Sastojak)")
                    .Where("recept.nazivRecepta='" + recept + "' AND sastojak.nazivSastojka='" + nazivSastojka + "'")
                    .Create("(recept)<-[:SADRZI]-(sastojak)")
                    .ExecuteWithoutResultsAsync();

                this.ReceptSastojci_Load(sender, e);
            }
            else
                MessageBox.Show("Selektuj željeni sastojak!");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count > 0)
            {
                if (dgvSastojci.SelectedRows[0].Cells[0].Value == null)
                    return;
                string nazivSastojkaZaUklanjanje = dgvSastojci.SelectedRows[0].Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivSastojkaZaUklanjanje", nazivSastojkaZaUklanjanje);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SADRZI]-(m) where (m:Sastojak) and exists(m.nazivSastojka) and m.nazivSastojka =~ {nazivSastojkaZaUklanjanje} delete r",
                                                                queryDict, CypherResultMode.Projection);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                this.ReceptSastojci_Load(sender, e);
            }
            else MessageBox.Show("Selektujte jedan sastojak koji želite da obrišete!\n");
        }

    }
}
