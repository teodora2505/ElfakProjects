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
    public partial class Ukusi : Form
    {
        public GraphClient client;

        public Ukusi()
        {
            InitializeComponent();
        }

        private void Ukusi_Load(object sender, EventArgs e)
        {
            string nazivUkusa = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivUkusa", nazivUkusa);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ukus) and exists(n.nazivUkusa) and n.nazivUkusa =~ {nazivUkusa} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

            foreach (Ukus u in ukusi)
            {
                dgvUkusi.Rows.Add(u.nazivUkusa);
            }
            dgvUkusi.ClearSelection();
        }

        public void InitializeAllAgain()
        {
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
                dgvUkusi.Rows.Add(u.nazivUkusa);
            }
            dgvUkusi.ClearSelection();
        }

        private Ukus kreirajUkus()
        {
            Ukus u = new Ukus();
            u.nazivUkusa = txtDodajUkus.Text;
            return u;
        }

        private void btnDodajUkus_Click(object sender, EventArgs e)
        {
            Ukus u = this.kreirajUkus();

            if (txtDodajUkus.Text == "")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Ukus {nazivUkusa:'" + u.nazivUkusa + "'}) return n",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);
            
            List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

            txtDodajUkus.Text = "";
            InitializeAllAgain();
        }

        private void btnIzmeniUkus_Click(object sender, EventArgs e)
        {
            if (dgvUkusi.SelectedRows.Count == 1 && txtIzmeniUkus.Text != "")
            {
                if (dgvUkusi.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvUkusi.SelectedRows[0];
                String stariNazivUkusa = row.Cells[0].Value.ToString();

                String nazivUkusa = txtIzmeniUkus.Text;
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ukus) and exists(n.nazivUkusa) and n.nazivUkusa = '" + stariNazivUkusa + "' set n.nazivUkusa = '" + nazivUkusa + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

                List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

                txtIzmeniUkus.Text = "";
                InitializeAllAgain();
            }
            else if (dgvUkusi.SelectedRows.Count == 1 && txtIzmeniUkus.Text == "") MessageBox.Show("Unesite novi naziv ukusa.\n");
            else MessageBox.Show("Selektuj jedan ukus!\n");
        }

        private void btnObrisiUkus_Click(object sender, EventArgs e)
        {
            if (dgvUkusi.SelectedRows.Count == 1)
            {
                if (dgvUkusi.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvUkusi.SelectedRows[0];
                string nazivUkusa = row.Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivUkusa", nazivUkusa);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ukus) and exists(n.nazivUkusa) and n.nazivUkusa =~ {nazivUkusa} detach delete n",
                                                                queryDict, CypherResultMode.Projection);

                List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

                InitializeAllAgain();
            }
            else MessageBox.Show("Selektuj jedan ukus!\n");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}