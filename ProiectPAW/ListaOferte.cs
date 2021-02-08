using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAW
{
    public partial class ListaOferte : Form
    {
        List<Models.Oferte> oferte;
        string username;
        public ListaOferte(string user)
        {
            InitializeComponent();
            this.KeyPreview = true;
            username = user;
            oferte = SqliteDataAccess.LoadOferte();
            dgvListaOferte.DataSource = oferte;
            dgvListaOferte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaOferte.MultiSelect = false;
            dgvListaOferte.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Salveaza in fisier text";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    oferte = SqliteDataAccess.LoadOferte();

                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    foreach (Models.Oferte each in oferte)
                    {
                        sw.Write(each.Id + "    " + each.Destinatie + "    " + each.Serviciu + "    " + each.Pret + " lei    " + each.Detalii + "\n" + "\n");
                    }

                    sw.Close();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void btnAlege_Click(object sender, EventArgs e)
        {
            if (dgvListaOferte.SelectedRows.Count < 1)
            {
                MessageBox.Show("Alege o oferta!");
                return;
            }

            else
            {
                int selectedrowindex = dgvListaOferte.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvListaOferte.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells[0].Value); // id-ul ofertei
                int id = Int32.Parse(a);

                CumparaOferta buyit = new CumparaOferta(username, id);
                buyit.Show();

            }
        }
        

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.OrdoneazaOferteAlf();
            dgvListaOferte.DataSource = oferte;
        }

        private void crescatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.OrdoneazaOferteNum();
            dgvListaOferte.DataSource = oferte;
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.OrdoneazaOferteAlfDesc();
            dgvListaOferte.DataSource = oferte;
        }

        private void descrescatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.OrdoneazaOferteNumDesc();
            dgvListaOferte.DataSource = oferte;
        }

        private void documentTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                oferte = SqliteDataAccess.LoadOferte();

                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Models.Oferte each in oferte)
                {
                    sw.Write(each.Id + "    " + each.Destinatie + "    " + each.Serviciu + "    " + each.Pret + " lei    " + each.Detalii + "\n" + "\n");
                }

                sw.Close();
            }
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.LoadOferte();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Models.Oferte>));

            FileStream fs = File.Create("Oferte.xml");
            xmlSerializer.Serialize(fs, oferte);

            fs.Close();

            MessageBox.Show("Serializare cu succes in Oferte.xml");
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oferte = SqliteDataAccess.LoadOferte();

            JsonSerializer jsonSerializer = new JsonSerializer();

            FileStream fs = File.Create("OferteJSON.json");
            TextWriter tw = new StreamWriter(fs);

            jsonSerializer.Serialize(tw, oferte);

            tw.Close();
            fs.Close();

            MessageBox.Show("Serializare cu succes in OferteJSON.json");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
