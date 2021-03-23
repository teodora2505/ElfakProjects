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
    public partial class Ocene : Form
    {
        public GraphClient client;

        public Ocene()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ocene_Load(object sender, EventArgs e)
        {
            dgvOcene.Rows.Clear();

            string ocena = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ocena", ocena);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ocena) and exists(n.ocena) and n.ocena =~ {ocena} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();

            foreach (Ocena o in ocene)
            {
                dgvOcene.Rows.Add(o.ocena);
            }
            dgvOcene.ClearSelection();
        }
        private Ocena kreirajOcenu()
        {
            Ocena o = new Ocena();
            o.ocena = txtDodajOcenu.Text;
            return o;
        }

        private void btnDodajOcenu_Click(object sender, EventArgs e)
        {
            Ocena o = this.kreirajOcenu();

            if (txtDodajOcenu.Text == "")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Ocena {ocena:'" + o.ocena + "'}) return n",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

            txtDodajOcenu.Text = "";
            this.Ocene_Load(sender,e);
        }

        private void btnIzmeniOcenu_Click(object sender, EventArgs e)
        {
            if (dgvOcene.SelectedRows.Count == 1 && txtIzmeniOcenu.Text != "")
            {
                if (dgvOcene.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvOcene.SelectedRows[0];
                String staraOcena = row.Cells[0].Value.ToString();

                String novaOcena = txtIzmeniOcenu.Text;
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ocena) and exists(n.ocena) and n.ocena = '" + staraOcena + "' set n.ocena = '" + novaOcena + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

                List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

                txtIzmeniOcenu.Text = "";
                this.Ocene_Load(sender, e);
            }
            else if (dgvOcene.SelectedRows.Count == 1 && txtIzmeniOcenu.Text == "") MessageBox.Show("Unesite novu vrednost ocene.\n");
            else MessageBox.Show("Selektujte jednu ocenu!\n");
        }

        private void btnObrisiOcenu_Click(object sender, EventArgs e)
        {
            if (dgvOcene.SelectedRows.Count == 1)
            {
                if (dgvOcene.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvOcene.SelectedRows[0];
                string ocena = row.Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("ocena", ocena);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ocena) and exists(n.ocena) and n.ocena =~ {ocena} detach delete n",
                                                                queryDict, CypherResultMode.Projection);

                List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();

                this.Ocene_Load(sender, e);
            }
            else MessageBox.Show("Selektujte jednu ocenu!\n");
        }
    }
}
