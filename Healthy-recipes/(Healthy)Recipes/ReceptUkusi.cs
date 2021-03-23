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
    public partial class ReceptUkusi : Form
    {
        public GraphClient client;
        public string recept;

        public ReceptUkusi()
        {
            InitializeComponent();
        }

        private void ReceptUkusi_Load(object sender, EventArgs e)
        {
            dgvRaspolozivi.DataSource = null;
            dgvRaspolozivi.Rows.Clear();
            dgvUkusi.DataSource = null;
            dgvUkusi.Rows.Clear();

            string nazivUkusa = ".*.*";
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivUkusa", nazivUkusa);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ukus) and exists(n.nazivUkusa) and n.nazivUkusa =~ {nazivUkusa} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

            foreach (Ukus u in ukusi)
            {
                query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:UKUSA]-(m) where exists(n.nazivRecepta) and exists(m.nazivUkusa) and n.nazivRecepta='"+ recept +"' and m.nazivUkusa = '" + u.nazivUkusa + "' return m",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
                List<Ukus> rUkus = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();
                if (rUkus.Count == 0)
                    dgvRaspolozivi.Rows.Add(u.nazivUkusa);
                else
                    dgvUkusi.Rows.Add(u.nazivUkusa);        
            }

            dgvRaspolozivi.ClearSelection();
            dgvUkusi.ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvRaspolozivi.SelectedRows.Count > 0)
            {
                if (dgvRaspolozivi.SelectedRows[0].Cells[0].Value == null)
                    return;
                string nazivUkusa = dgvRaspolozivi.SelectedRows[0].Cells[0].Value.ToString();
                
                    client.Cypher
                        .Match("(recept:Recept), (ukus:Ukus)")
                        .Where("recept.nazivRecepta='" + recept + "' AND ukus.nazivUkusa='" + nazivUkusa + "'")
                        .Create("(recept)<-[:UKUSA]-(ukus)")
                        .ExecuteWithoutResultsAsync();
               
                this.ReceptUkusi_Load(sender, e);
            }
            else
                MessageBox.Show("Selektuj željeni ukus!");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvUkusi.SelectedRows.Count > 0)
            {
                if (dgvUkusi.SelectedRows[0].Cells[0].Value == null)
                    return;

                string nazivUkusaZaUklanjanje = dgvUkusi.SelectedRows[0].Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivUkusaZaUklanjanje", nazivUkusaZaUklanjanje);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:UKUSA]-(m) where (n:Recept) and (m:Ukus) and exists(n.nazivRecepta) and exists(m.nazivUkusa) and n.nazivRecepta='"+recept+"' and m.nazivUkusa =~ {nazivUkusaZaUklanjanje} delete r",
                                                                queryDict, CypherResultMode.Projection);

                List<Ukusi> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukusi>(query).ToList();

                this.ReceptUkusi_Load(sender, e);
            }
            else MessageBox.Show("Selektujte jedan ukus koji želite da obrišete!\n");
        }
       
    }
}