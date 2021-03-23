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
    public partial class Obroci : Form
    {
        public GraphClient client;

        public Obroci()
        {
            InitializeComponent();
        }

        private void Obroci_Load(object sender, EventArgs e)
        {
            string nazivObroka = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivObroka", nazivObroka);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka =~ {nazivObroka} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

            foreach (Obrok o in obroci)
            {
                dgvObroci.Rows.Add(o.nazivObroka, o.vremeOd+"-"+o.vremeDo);
            }
            dgvObroci.ClearSelection();
            onemoguciSve();      
        }

        public void InitializeAllAgain()
        {
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
                dgvObroci.Rows.Add(o.nazivObroka, o.vremeOd + "-" + o.vremeDo);
            }

            dgvObroci.ClearSelection();
            onemoguciSve();
        }

        private void onemoguciSve()
        {
            txtVremeOd.Enabled = false;
            txtVremeDo.Enabled = false;
            btnPostaviVreme.Enabled = false;
            txtVremeOd1.Enabled = false;
            txtVremeDo1.Enabled = false;
            btnIzmeniVreme.Enabled = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Obrok kreirajObrok()
        {
            Obrok o = new Obrok();
            o.nazivObroka = txtDodajObrok.Text;
            return o;
        }

        private void btnDodajObrok_Click(object sender, EventArgs e)
        {
            Obrok o = this.kreirajObrok();

            if (txtDodajObrok.Text == "")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Obrok {nazivObroka:'" + o.nazivObroka + "'}) return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

            txtDodajObrok.Text = "";
            InitializeAllAgain();
        }

        private void btnIzmeniObrok_Click(object sender, EventArgs e)
        {
            if (dgvObroci.SelectedRows.Count == 1 && txtIzmeniObrok.Text != "")
            {
                if (dgvObroci.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvObroci.SelectedRows[0];
                String stariNazivObroka = row.Cells[0].Value.ToString();

                String nazivObroka = txtIzmeniObrok.Text;
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka = '" + stariNazivObroka + "' set n.nazivObroka = '" + nazivObroka + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

                List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

                txtIzmeniObrok.Text = "";
                InitializeAllAgain();
            }
            else if (dgvObroci.SelectedRows.Count == 1 && txtIzmeniObrok.Text == "") MessageBox.Show("Unesite novi naziv obroka.\n");
            else MessageBox.Show("Selektuj jedan obrok!\n");

        }

        private void btnObrisiObrok_Click(object sender, EventArgs e)
        {
            if (dgvObroci.SelectedRows.Count == 1)
            {
                if (dgvObroci.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvObroci.SelectedRows[0];
                string nazivObroka = row.Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivObroka", nazivObroka);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka =~ {nazivObroka} detach delete n",
                                                                queryDict, CypherResultMode.Projection);

                List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

                InitializeAllAgain();
            }
            else MessageBox.Show("Selektuj jedan obrok!\n");
        }

        private void btnPostaviVreme_Click(object sender, EventArgs e)
        {
            if (dgvObroci.SelectedRows.Count > 0 && txtVremeOd.Text != "" && txtVremeDo.Text != "")
            {
                string vremeOd = txtVremeOd.Text.ToString();
                string vremeDo = txtVremeDo.Text.ToString();
                string obrok;

                foreach (DataGridViewRow row in dgvObroci.SelectedRows)
                {
                    obrok = row.Cells[0].Value.ToString();
                    var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka = '" + obrok + "' set n.vremeOd = '" + vremeOd + "', n.vremeDo = '" + vremeDo + "' return n",
                                                                   new Dictionary<string, object>(), CypherResultMode.Set);

                    List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();
                }
                txtVremeOd.Text = "";
                txtVremeDo.Text = "";
                txtVremeOd1.Text = "";
                txtVremeDo1.Text = "";
                InitializeAllAgain();
            }
            else if (dgvObroci.SelectedRows.Count == 1 && txtVremeOd.Text == "" && txtVremeDo.Text == "") MessageBox.Show("Unesite vreme služenja.\n");
            else
                MessageBox.Show("Selektuj željeni obrok!");
        }

        private void btnIzmeniVreme_Click(object sender, EventArgs e)
        {
            if (dgvObroci.SelectedRows.Count > 0 && txtVremeOd1.Text != "" && txtVremeDo1.Text != "")
            {   
                string novoVremeOd = txtVremeOd1.Text.ToString();
                string novoVremeDo = txtVremeDo1.Text.ToString();
                string obrok;

                foreach (DataGridViewRow row in dgvObroci.SelectedRows)
                {
                    obrok = row.Cells[0].Value.ToString();
                    var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka = '" + obrok + "' set n.vremeOd = '" + novoVremeOd + "', n.vremeDo = '" + novoVremeDo + "' return n",
                                                                   new Dictionary<string, object>(), CypherResultMode.Set);

                    List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();
                }
                txtVremeOd1.Text = "";
                txtVremeDo1.Text = "";
                InitializeAllAgain();
            }
            else if (dgvObroci.SelectedRows.Count == 1 && txtVremeOd1.Text == "" && txtVremeDo1.Text == "") MessageBox.Show("Unesite novo vreme služenja.\n");
            else
                MessageBox.Show("Selektuj željeni obrok!");
        }

        private void dgvObroci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvObroci.SelectedRows.Count==1)
            {
                if(dgvObroci.SelectedRows[0].Cells[1].Value == null)
                {
                    onemoguciSve();
                    txtVremeOd1.Text = "";
                    txtVremeDo1.Text = "";
                    return;
                }
                if(dgvObroci.SelectedRows[0].Cells[1].Value.ToString() != "-")
                {
                    DataGridViewRow row = dgvObroci.SelectedRows[0];
                    string[] vreme = row.Cells[1].Value.ToString().Split('-');
                    txtVremeOd.Enabled = false;
                    txtVremeDo.Enabled = false;
                    btnPostaviVreme.Enabled = false;
                    txtVremeOd1.Enabled = true;
                    txtVremeDo1.Enabled = true;
                    btnIzmeniVreme.Enabled = true;
                    txtVremeOd1.Text = vreme[0];
                    txtVremeDo1.Text = vreme[1];
                }
                else
                {                   
                    txtVremeOd.Enabled = true;
                    txtVremeDo.Enabled = true;
                    btnPostaviVreme.Enabled = true;
                    txtVremeOd1.Enabled = false;
                    txtVremeDo1.Enabled = false;
                    btnIzmeniVreme.Enabled = false;
                    txtVremeOd1.Text = "";
                    txtVremeDo1.Text = "";
                }             
            }
            else
            {
                onemoguciSve();
                txtVremeOd1.Text = "";
                txtVremeDo1.Text = "";
            }
        }
    }
}