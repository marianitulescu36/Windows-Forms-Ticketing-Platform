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
    public partial class ModificaOferte : Form
    {
        List<Models.Oferte> oferte;
        public ModificaOferte()
        {
            InitializeComponent();
            oferte = SqliteDataAccess.LoadOferte();
            dataGridView.DataSource = oferte;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List<string> servicii = SqliteDataAccess.LoadServicii();
            cbServicii.DataSource = servicii;
        }

        #region Validare formular
        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            String value = tbLocatie.Text;
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                epLocatie.SetError((Control)sender, "Completeaza locatia!");
                e.Cancel = true; // impiedica utilizatorul sa schimbe controlul
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            epLocatie.Clear();
        }

        #endregion

        private void curataCampuri() // metoda utilitara
        {
            tbLocatie.Clear();
            cbServicii.SelectedIndex = -1;
            tbPret.Clear();
            tbDetalii.Clear();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Models.Oferte newOferta = new Models.Oferte();
            newOferta.Destinatie = tbLocatie.Text;
            newOferta.Serviciu = cbServicii.Text;
            newOferta.Pret = tbPret.Text;
            newOferta.Detalii = tbDetalii.Text;
            SqliteDataAccess.CreateOferta(newOferta);

            MessageBox.Show("Oferta a fost adaudata cu succes!", " ");

            oferte = SqliteDataAccess.LoadOferte(); //refac lista
            dataGridView.DataSource = oferte;

            curataCampuri();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count != 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells[0].Value); // id-ul ofertei
                int id = Int32.Parse(a);

                Models.Oferte changeOferta = SqliteDataAccess.SearchOferteId(id);

                EditeazaOferte edit = new EditeazaOferte(changeOferta);
                edit.ShowDialog();

                oferte = SqliteDataAccess.LoadOferte(); //refac lista
                dataGridView.DataSource = oferte;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells[0].Value); // id-ul ofertei
            int id = Int32.Parse(a);

            SqliteDataAccess.DeleteOferta(id);

            oferte = SqliteDataAccess.LoadOferte();
            dataGridView.DataSource = oferte;
        }
    }
}
