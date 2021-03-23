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
    public partial class Recepti : Form
    {
        public GraphClient client;

        public Recepti()
        {
            InitializeComponent();
        }

        private void Recepti_Load(object sender, EventArgs e)
        {
            string nazivRecepta = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            foreach (Recept r in recepti)
            {
                dgvRecepti.Rows.Add(r.nazivRecepta, r.tezinaPripreme, r.vremePripreme);
            }
            dgvRecepti.ClearSelection();
            onemoguciIzmenu();
        }
        public void InitializeAllAgain()
        {
            dgvRecepti.DataSource = null;
            dgvRecepti.Rows.Clear();

            string nazivRecepta = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            foreach (Recept r in recepti)
            {
                dgvRecepti.Rows.Add(r.nazivRecepta, r.tezinaPripreme, r.vremePripreme);
            }
            dgvRecepti.ClearSelection();
            onemoguciIzmenu();
        }

        private Recept kreirajRecept()
        {
            Recept r = new Recept();
            r.nazivRecepta = txtDodajRecept.Text;
            r.tezinaPripreme = cbxDodajTezinu.SelectedItem.ToString();
            r.vremePripreme = cbxDodajVreme.SelectedItem.ToString();
            return r;
        }

        private void btnDodajRecept_Click(object sender, EventArgs e)
        {
            if (txtDodajRecept.Text == "" || cbxDodajTezinu.SelectedItem.ToString() == "" || cbxDodajVreme.SelectedItem.ToString() =="")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            Recept r = this.kreirajRecept();

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Recept {nazivRecepta:'" + r.nazivRecepta + 
                                                            "', tezinaPripreme:'"+r.tezinaPripreme+
                                                            "', vremePripreme:'" + r.vremePripreme+
                                                            "'}) return n", new Dictionary<string, object>(), CypherResultMode.Set);
            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            txtDodajRecept.Text = "";
            cbxDodajTezinu.SelectedIndex = -1;
            cbxDodajVreme.SelectedIndex = -1;
            InitializeAllAgain();
        }

        private void btnIzmeniRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count == 1 && txtIzmeniRecept.Text != "" && cbxIzmeniTezinu.SelectedItem.ToString() != "" && cbxIzmeniVreme.SelectedItem.ToString() != "")
            {
                DataGridViewRow row = dgvRecepti.SelectedRows[0];
                string stariNazivRecepta = row.Cells[0].Value.ToString();
                string staraTezinaPripreme = row.Cells[1].Value.ToString();
                string staroVremePripreme = row.Cells[2].Value.ToString();

                string nazivRecepta = txtIzmeniRecept.Text;
                string tezinaPripreme = cbxIzmeniTezinu.SelectedItem.ToString();
                string vremePripreme = cbxIzmeniVreme.SelectedItem.ToString();
                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and exists(n.tezinaPripreme) and exists(n.vremePripreme) and n.nazivRecepta = '" + stariNazivRecepta + "'  and n.tezinaPripreme = '" + staraTezinaPripreme + "' and n.vremePripreme = '" + staroVremePripreme + 
                                                                "' set n.nazivRecepta = '" + nazivRecepta + "' , n.tezinaPripreme = '" + tezinaPripreme + "' , n.vremePripreme = '" + vremePripreme + "' return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);

                List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

                txtIzmeniRecept.Text = "";
                cbxIzmeniTezinu.SelectedIndex = -1;
                cbxIzmeniVreme.SelectedIndex = -1;
                InitializeAllAgain();
            }
            else if (dgvRecepti.SelectedRows.Count == 1 && (txtIzmeniRecept.Text == "" || cbxIzmeniTezinu.SelectedItem.ToString() == ""|| cbxIzmeniVreme.SelectedItem.ToString() == "")) MessageBox.Show("Unesite sve potrebne podatke.\n");
            else MessageBox.Show("Selektuj jedan recept!\n");
        }

        private void btnObrisiRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count == 1)
            {
                if (dgvRecepti.SelectedRows[0].Cells[0].Value == null)
                    return;
                DataGridViewRow row = dgvRecepti.SelectedRows[0];
                string nazivRecepta = row.Cells[0].Value.ToString();

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("nazivRecepta", nazivRecepta);

                var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} detach delete n",
                                                                queryDict, CypherResultMode.Projection);

                List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

                InitializeAllAgain();
            }
            else MessageBox.Show("Selektuj jedan recept!\n");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpisRecepta_Click(object sender, EventArgs e)
        {
            OpisRecepta OpisReceptaForm = new OpisRecepta();
            OpisReceptaForm.client = client;
            OpisReceptaForm.recept = dgvRecepti.SelectedRows[0].Cells[0].Value.ToString();
            OpisReceptaForm.ShowDialog();
        }

        private void onemoguciIzmenu()
        {
            txtIzmeniRecept.Enabled = false;
            cbxIzmeniTezinu.Enabled = false;
            cbxIzmeniVreme.Enabled = false;
            btnIzmeniRecept.Enabled = false;
            btnOpisRecepta.Enabled = false;
            btnSastojci.Enabled = false;
            btnOcena.Enabled = false;
            btnUkus.Enabled = false;
            btnObrok.Enabled = false;
        }
        private void dgvRecepti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count > 0)
            {
                if (dgvRecepti.SelectedRows[0].Cells[0].Value != null)
                {
                    DataGridViewRow row = dgvRecepti.SelectedRows[0];
                    string naziv = row.Cells[0].Value.ToString();
                    string tezina = row.Cells[1].Value.ToString();
                    string vreme = row.Cells[2].Value.ToString();
                    txtIzmeniRecept.Text = naziv;
                    cbxIzmeniTezinu.Text = tezina;
                    cbxIzmeniVreme.Text = vreme;
                    txtIzmeniRecept.Enabled = true;
                    cbxIzmeniTezinu.Enabled = true;
                    cbxIzmeniVreme.Enabled = true;
                    btnIzmeniRecept.Enabled = true;
                    btnOpisRecepta.Enabled = true;
                    btnSastojci.Enabled = true;
                    btnOcena.Enabled = true;
                    btnUkus.Enabled = true;
                    btnObrok.Enabled = true;

                }
                else
                {
                    txtIzmeniRecept.Text = "";
                    cbxIzmeniTezinu.SelectedIndex = -1;
                    cbxIzmeniVreme.SelectedIndex = -1;
                    onemoguciIzmenu();
                }
            }
        }

        private void btnSastojci_Click(object sender, EventArgs e)
        {
            ReceptSastojci ReceptSastojciForm = new ReceptSastojci();
            ReceptSastojciForm.client = client;
            ReceptSastojciForm.recept = dgvRecepti.SelectedRows[0].Cells[0].Value.ToString();
            ReceptSastojciForm.ShowDialog();
        }

        private void btnUkus_Click(object sender, EventArgs e)
        {
            ReceptUkusi ReceptUkusiForm = new ReceptUkusi();
            ReceptUkusiForm.client = client;
            ReceptUkusiForm.recept = dgvRecepti.SelectedRows[0].Cells[0].Value.ToString();
            ReceptUkusiForm.ShowDialog();
        }

        private void btnObrok_Click(object sender, EventArgs e)
        {
            ReceptObroci ReceptObrociForm = new ReceptObroci();
            ReceptObrociForm.client = client;
            ReceptObrociForm.recept = dgvRecepti.SelectedRows[0].Cells[0].Value.ToString();
            ReceptObrociForm.ShowDialog();
        }

        private void btnOcena_Click(object sender, EventArgs e)
        {
            ReceptOcena ReceptOcenaForm = new ReceptOcena();
            ReceptOcenaForm.client = client;
            ReceptOcenaForm.recept = dgvRecepti.SelectedRows[0].Cells[0].Value.ToString();
            ReceptOcenaForm.ShowDialog();
        }
    }
}