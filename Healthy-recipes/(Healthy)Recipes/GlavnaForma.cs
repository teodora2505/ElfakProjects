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
    public partial class GlavnaForma : Form
    {
        public GraphClient client;

        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nazivRecepta = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);

            List<Recept> recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();
            foreach (Recept r in recepti)
            {
                dgvRecepti.Rows.Add(r.nazivRecepta);
            }
            dgvRecepti.ClearSelection();

            UcitajFiltere();
        }

        private void UcitajFiltere()
        {
            listBoxSastojci.Items.Clear();
            listBoxObroci.Items.Clear();
            listBoxUkusi.Items.Clear();

            string nazivSastojka = ".*.*";
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivSastojka", nazivSastojka);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Sastojak) and exists(n.nazivSastojka) and n.nazivSastojka =~ {nazivSastojka} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Sastojak> sastojci = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();

            foreach (Sastojak s in sastojci)
            {
                listBoxSastojci.Items.Add(s.nazivSastojka);
            }

            string nazivUkusa = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivUkusa", nazivUkusa);

            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ukus) and exists(n.nazivUkusa) and n.nazivUkusa =~ {nazivUkusa} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Ukus> ukusi = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();

            foreach (Ukus u in ukusi)
            {
                listBoxUkusi.Items.Add(u.nazivUkusa);
            }

            string nazivObroka = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivObroka", nazivObroka);

            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Obrok) and exists(n.nazivObroka) and n.nazivObroka =~ {nazivObroka} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Obrok> obroci = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();

            foreach (Obrok o in obroci)
            {
                listBoxObroci.Items.Add(o.nazivObroka);
            }

            string ocena = ".*.*";
            queryDict = new Dictionary<string, object>();
            queryDict.Add("ocena", ocena);

            query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Ocena) and exists(n.ocena) and n.ocena =~ {ocena} return n",
                                                            queryDict, CypherResultMode.Set);
            List<Ocena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();

            foreach (Ocena o in ocene)
            {
                cbxOcene.Items.Add(o.ocena);
            }
        }

        private void PrikaziFiltrirano(List<Recept> recepti, List<Sastojak> sastojci, List<Obrok> obroci, List<Ukus> ukusi, Ocena ocena, string tezinaPripreme, string vremePripreme)
        {
            List<Recept> filtriranRecepti = new List<Recept>();
            foreach(Recept r in recepti)
            {
                bool sadrziSastojke = true;
                bool seSluzi = true;
                bool jeUkusa = true;
                bool jeOcena = true;
                bool tezina = true;
                bool vreme = true;

                if (sastojci != null)
                    foreach (Sastojak s in sastojci)
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SADRZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivSastojka) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivSastojka = '" + s.nazivSastojka + "' return m",
                                                                    new Dictionary<string, object>(), CypherResultMode.Set);
                        List<Sastojak> rSastojak = ((IRawGraphClient)client).ExecuteGetCypherResults<Sastojak>(query).ToList();
                        if (rSastojak.Count == 0)
                            sadrziSastojke = false;
                    }

                if (obroci != null)
                    foreach (Obrok o in obroci)
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:SLUZI]-(m) where exists(n.nazivRecepta) and exists(m.nazivObroka) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivObroka = '" + o.nazivObroka + "' return m",
                                                                new Dictionary<string, object>(), CypherResultMode.Set);
                        List<Obrok> rObrok = ((IRawGraphClient)client).ExecuteGetCypherResults<Obrok>(query).ToList();
                        if (rObrok.Count == 0)
                            seSluzi = false;
                    }

                if (ukusi != null)
                    foreach (Ukus u in ukusi)
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:UKUSA]-(m) where exists(n.nazivRecepta) and exists(m.nazivUkusa) and n.nazivRecepta='" + r.nazivRecepta + "' and m.nazivUkusa = '" + u.nazivUkusa + "' return m",
                                                                    new Dictionary<string, object>(), CypherResultMode.Set);
                        List<Ukus> rUkus = ((IRawGraphClient)client).ExecuteGetCypherResults<Ukus>(query).ToList();
                        if (rUkus.Count == 0)
                            jeUkusa = false;
                    }

                if (ocena.ocena != null)
                { 
                    var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)<-[r:OCENA]-(m) where exists(n.nazivRecepta) and exists(m.ocena) and n.nazivRecepta='" + r.nazivRecepta + "' and m.ocena = '" + ocena.ocena + "' return m",
                                                                    new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Ocena> rOcena = ((IRawGraphClient)client).ExecuteGetCypherResults<Ocena>(query).ToList();
                    if (rOcena.Count == 0)
                       jeOcena = false;
                }

                if (tezinaPripreme != null)
                    if (tezinaPripreme != r.tezinaPripreme)
                        tezina = false;

                if (vremePripreme != null)
                    if (vremePripreme != r.vremePripreme)
                        vreme = false;

                if (sadrziSastojke == true && seSluzi == true && jeUkusa == true && jeOcena==true && tezina && vreme)
                    filtriranRecepti.Add(r);
            }

            foreach (Recept r in filtriranRecepti)
            {
                dgvRecepti.Rows.Add(r.nazivRecepta);
            }
            dgvRecepti.ClearSelection();
        }

        private void btnSastojci_Click(object sender, EventArgs e)
        {
            Sastojci SastojciForm = new Sastojci();
            SastojciForm.client = client;
            SastojciForm.ShowDialog();
        }

        private void btnObroci_Click(object sender, EventArgs e)
        {
            Obroci ObrociForm = new Obroci();
            ObrociForm.client = client;
            ObrociForm.ShowDialog();
        }

        private void btnUkusi_Click(object sender, EventArgs e)
        {
            Ukusi UkusiForm = new Ukusi();
            UkusiForm.client = client;
            UkusiForm.ShowDialog();
        }

        private void btnRecepti_Click(object sender, EventArgs e)
        {
            Recepti ReceptiForm = new Recepti();
            ReceptiForm.client = client;
            ReceptiForm.ShowDialog();
        }

        private void btnOcene_Click(object sender, EventArgs e)
        {
            Ocene OceneForm = new Ocene();
            OceneForm.client = client;
            OceneForm.ShowDialog();
        }

        private void btnFltriraj_Click(object sender, EventArgs e)
        {
            List<Recept> recepti = new List<Recept>();
            List<Sastojak> sastojci = new List<Sastojak>();
            List<Ukus> ukusi = new List<Ukus>();
            List<Obrok> obroci = new List<Obrok>();
            Ocena ocena = new Ocena();

            string tezinaPripreme=null;
            string vremePripreme=null;

            foreach(string item in listBoxSastojci.SelectedItems)
            {
                    Sastojak s = new Sastojak();
                    s.nazivSastojka = item;
                    sastojci.Add(s);
            }
            foreach (string item in listBoxUkusi.SelectedItems)
            {
                    Ukus u = new Ukus();
                    u.nazivUkusa = item;
                    ukusi.Add(u);
            }
            foreach (string item in listBoxObroci.SelectedItems)
            {
                    Obrok o = new Obrok();
                    o.nazivObroka = item;
                    obroci.Add(o);
            }

            if (cbxOcene.SelectedIndex > -1)
            {
                ocena.ocena = cbxOcene.SelectedItem.ToString();
            }
            if (cbxTezinaPripreme.SelectedIndex > -1)
            {
                tezinaPripreme = cbxTezinaPripreme.SelectedItem.ToString();
            }
            if (cbxVremePripreme.SelectedIndex > -1)
            {
                vremePripreme = cbxVremePripreme.SelectedItem.ToString();
            }

            string nazivRecepta = ".*.*";

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("nazivRecepta", nazivRecepta);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Recept) and exists(n.nazivRecepta) and n.nazivRecepta =~ {nazivRecepta} return n",
                                                            queryDict, CypherResultMode.Set);

            recepti = ((IRawGraphClient)client).ExecuteGetCypherResults<Recept>(query).ToList();

            dgvRecepti.Rows.Clear();
            PrikaziFiltrirano(recepti, sastojci, obroci, ukusi, ocena, tezinaPripreme, vremePripreme);

            cbxOcene.SelectedIndex = -1;
            cbxTezinaPripreme.SelectedIndex = -1;
            cbxVremePripreme.SelectedIndex = -1;
            listBoxSastojci.SelectedItems.Clear();
            listBoxUkusi.SelectedItems.Clear();
            listBoxObroci.SelectedItems.Clear();
        }

        private void dgvRecepti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRecepti.CurrentRow.Cells[0].Value == null)
            {
                return;
            }
            ReceptiDetalji ReceptiDetaljiForm = new ReceptiDetalji();
            ReceptiDetaljiForm.client = client;
            ReceptiDetaljiForm.recept = dgvRecepti.CurrentRow.Cells[0].Value.ToString();
            ReceptiDetaljiForm.ShowDialog();
        }

    }
}