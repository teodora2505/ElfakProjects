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
    public partial class ReceptObroci : Form
    {
        public GraphClient client;
        public string recept;

        public ReceptObroci()
        {
            InitializeComponent();
        }
        private void ReceptObroci_Load(object sender, EventArgs e)
        {
            dgvRaspolozivi.DataSource = null;
            dgvRaspolozivi.Rows.Clear();
            dgvObroci.DataSource = null;
            dgvObroci.Rows.Clear();

            string nazivObroka = ".*.*";
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivObroka", nazivObroka);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka =~ {nazivObroka} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

            foreach (Obrok o in obroci)
            {
                query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SLUZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivObroka) and n.nazivRecepta='" + recept + "' and m.nazivObroka = '" + o.nazivObroka + "' return m",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
                List<Obrok> rObrok = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();
                if (rObrok.Count == 0)
                    dgvRaspolozivi.Rows.Add(o.nazivObroka);
                else
                    dgvObroci.Rows.Add(o.nazivObroka);
            }

            dgvRaspolozivi.ClearSelection();
            dgvObroci.ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvRaspolozivi.SelectedRows.Count > 0)
            {
                if (dgvRaspolozivi.SelectedRows[0].Cells[0].Value == null)
                    return;
                string nazivObroka = dgvRaspolozivi.SelectedRows[0].Cells[0].Value.ToString();

                client.Cypher
                    .Match("(recept:Recept), (obrok:Obrok)")
                    .Where("recept.nazivRecepta='" + recept + "' AND obrok.nazivObroka='" + nazivObroka + "'")
                    .Create("(recept)<-[:SLUZI]-(obrok)")
                    .ExecuteWithoutResultsAsync();

                this.ReceptObroci_Load(sender, e);
            }
            else
                MessageBox.Show("Selektuj željeni obrok!");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvObroci.SelectedRows.Count > 0)
            {
                if (dgvObroci.SelectedRows[0].Cells[0].Value == null)
                    return;

                string nazivObrokaZaUklanjanje = dgvObroci.SelectedRows[0].Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivObrokaZaUklanjanje", nazivObrokaZaUklanjanje);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SLUZI]-(m) where (n:Recept) and (m:Obrok) and exists(n.nazivRecepta) and exists(m.nazivObroka) and n.nazivRecepta='"+recept+"' and m.nazivObroka =~ {nazivObrokaZaUklanjanje} delete r",
                                                                queryDict, CypherResultMode.Projection);

                List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

                this.ReceptObroci_Load(sender, e);
            }
            else MessageBox.Show("Selektujte jedan obrok koji želite da obrišete!\n");
        }
     
    }
}