using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class OferteVacanta : Form
    {
        List<Models.Oferte> oferte;
        string user;
        public OferteVacanta(string username)
        {
            InitializeComponent();
            user = username;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            List<string> servicii = SqliteDataAccess.LoadServicii();
            cbServicii.DataSource = servicii;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (cbServicii.Text == "None")
                oferte = SqliteDataAccess.SearchOferte(tbNume.Text);
            else
                oferte = SqliteDataAccess.SearchOferteDestServ(tbNume.Text, cbServicii.Text);
            dataGridView.DataSource = oferte;

            if (oferte.Count()==0 && cbServicii.Text == "None")
                MessageBox.Show("Nu exista destinatia cautata!", "oof");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells!=null)
            {
                try
                {
                    int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                    string a = Convert.ToString(selectedRow.Cells[0].Value);

                    int id = Int32.Parse(a);
                    CumparaOferta buyit = new CumparaOferta(user, id);
                    buyit.Show();
                }
                catch
                {
                    MessageBox.Show("Nu exista nicio oferta cu specificatiile dorite!");
                }

            }
            else
                MessageBox.Show("Alege o oferta!");
        }
    }
}
