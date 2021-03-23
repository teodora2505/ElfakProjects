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
    public partial class Sastojci : Form
    {
        public GraphClient client;

        public Sastojci()
        {
            InitializeComponent();
        }

        private void Sastojci_Load(object sender, EventArgs e)
        {
            string nazivSastojka = ".*.*";
            string nazivAlternative = ".*.*";
           
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivSastojka", nazivSastojka);
            queryDict.Add("nazivAlternative", nazivAlternative);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.nazivSastojka) and n.nazivSastojka =~ {nazivSastojka} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

            foreach (Sastojak s in sastojci)
            {
                query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:ALTERNATIVA]->(m) where exists(n.nazivSastojka) and n.nazivSastojka = '"+ s.nazivSastojka + "' return m", new Dictionary<string, object>(), CypherResultMode.Set);
                List<Sastojak> alternativa = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
                if (alternativa.Count == 0)
                    dgvSastojci.Rows.Add(s.nazivSastojka, "");
                else
                    dgvSastojci.Rows.Add(s.nazivSastojka,alternativa[0].nazivSastojka);             
            }

            dgvSastojci.ClearSelection();
        }

        public void InitializeAllAgain()
        {
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
                query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:ALTERNATIVA]->(m) where exists(n.nazivSastojka) and n.nazivSastojka = '" + s.nazivSastojka + "' return m", new Dictionary<string, object>(), CypherResultMode.Set);
                List<Sastojak> alternativa = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
                if (alternativa.Count == 0)
                    dgvSastojci.Rows.Add(s.nazivSastojka, "");
                else
                    dgvSastojci.Rows.Add(s.nazivSastojka, alternativa[0].nazivSastojka);
            }

            panelAlternativaSastojka.Visible = false;
            dgvSastojci.ClearSelection();
        }

        private Sastojak kreirajSastojak()
        {
            Sastojak s = new Sastojak();
            s.nazivSastojka = txtDodajSastojak.Text;
            return s;
        }

        private void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            Sastojak s = this.kreirajSastojak();

            if (txtDodajSastojak.Text == "")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Sastojak {nazivSastojka:'" + s.nazivSastojka + "'}) return n",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);
            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

            txtDodajSastojak.Text = "";
            InitializeAllAgain();
        }

        private void btnIzmeniSastojak_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count == 1 && txtIzmeniSastojak.Text != "")
            {
                if (dgvSastojci.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvSastojci.SelectedRows[0];
                String stariNazivSastojka = row.Cells[0].Value.ToString();

                String nazivSastojka = txtIzmeniSastojak.Text;
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.nazivSastojka) and n.nazivSastojka = '" + stariNazivSastojka + "' set n.nazivSastojka = '" + nazivSastojka + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                txtIzmeniSastojak.Text = "";
                InitializeAllAgain();
            }
            else if (dgvSastojci.SelectedRows.Count == 1 && txtIzmeniSastojak.Text == "") MessageBox.Show("Unesite novi naziv sastojka.\n");
            else MessageBox.Show("Selektuj jedan sastojak!\n");
            
        }

        private void btnObrisiSastojak_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count == 1)
            {
                if (dgvSastojci.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvSastojci.SelectedRows[0];
                string nazivSastojka = row.Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivSastojka", nazivSastojka);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.nazivSastojka) and n.nazivSastojka =~ {nazivSastojka} detach delete n",
                                                                queryDict, CypherResultMode.Projection);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                InitializeAllAgain();
            }
            else MessageBox.Show("Selektuj jedan sastojak!\n");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajAlternativu_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count > 0 && txtDodajAlternativu.Text!="")
            {
                string nazivAlternative = txtDodajAlternativu.Text;
                string sastojak;

                foreach (DataGridViewRow row in dgvSastojci.SelectedRows)
                {
                    if (row.Cells[0].Value == null)
                        return;

                    sastojak = row.Cells[0].Value.ToString();

                    client.Cypher
                        .Match("(sastojak1:Sastojak), (sastojak2:Sastojak)")
                        .Where("sastojak1.nazivSastojka='" + sastojak + "' AND sastojak2.nazivSastojka='" + nazivAlternative + "'")
                        .Create("(sastojak1)-[:ALTERNATIVA]->(sastojak2)")
                        .ExecuteWithoutResultsAsync();
                }
                txtDodajAlternativu.Text = "";
                InitializeAllAgain();
            }
            else if(dgvSastojci.SelectedRows.Count == 1 && txtIzmeniSastojak.Text == "") MessageBox.Show("Unesite naziv alternative.\n");
            else
                MessageBox.Show("Selektuj željeni sastojak!");
        }

        private void btnIzmeniAlternativu_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows[0].Cells[1].Value == null)
                return;
            if (dgvSastojci.SelectedRows.Count == 1 && dgvSastojci.SelectedRows[0].Cells[1].Value.ToString() != "" && txtIzmeniAlternativu.Text != "")
            {
                DataGridViewRow row = dgvSastojci.SelectedRows[0];
                string nazivAlternative = row.Cells[1].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivAlternative", nazivAlternative);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:ALTERNATIVA]->(m) where (m:Sastojak) and exists(m.nazivSastojka) and m.nazivSastojka =~ {nazivAlternative} delete r",
                                                                queryDict, CypherResultMode.Projection);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                string nazivAlternative1 = txtIzmeniAlternativu.Text;
                string sastojak;

                foreach (DataGridViewRow row1 in dgvSastojci.SelectedRows)
                {
                    sastojak = row1.Cells[0].Value.ToString();

                    client.Cypher
                        .Match("(sastojak1:Sastojak), (sastojak2:Sastojak)")
                        .Where("sastojak1.nazivSastojka='" + sastojak + "' AND sastojak2.nazivSastojka='" + nazivAlternative1 + "'")
                        .Create("(sastojak1)-[:ALTERNATIVA]->(sastojak2)")
                        .ExecuteWithoutResultsAsync();
                }
                txtIzmeniAlternativu.Text = "";

                InitializeAllAgain();
            }
            else if (dgvSastojci.SelectedRows.Count == 1 && dgvSastojci.SelectedRows[0].Cells[1].Value != null && txtIzmeniAlternativu.Text == "") MessageBox.Show("Unesite novi naziv alternative.\n");
            else MessageBox.Show("Selektuj jedan sastojak sa alternativom!\n");
        }

        private void btnObrisiAlternativu_Click(object sender, EventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count == 1 && dgvSastojci.SelectedRows[0].Cells[1].Value.ToString() != "")
            {
                DataGridViewRow row = dgvSastojci.SelectedRows[0];
                string nazivAlternative = row.Cells[1].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivAlternative", nazivAlternative);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:ALTERNATIVA]->(m) where (m:Sastojak) and exists(m.nazivSastojka) and m.nazivSastojka =~ {nazivAlternative} delete r",
                                                                queryDict, CypherResultMode.Projection);

                List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

                InitializeAllAgain();
            }
            else MessageBox.Show("Selektuj jedan sastojak sa alternativom!\n");
        }

        private void dgvSastojci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSastojci.SelectedRows.Count > 0)
            {
                panelAlternativaSastojka.Visible = true;
            }
            else
                panelAlternativaSastojka.Visible = false;
        }
    }
}