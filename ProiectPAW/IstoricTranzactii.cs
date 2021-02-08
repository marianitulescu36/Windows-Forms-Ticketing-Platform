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
    public partial class IstoricTranzactii : Form
    {
        List<Models.Tranzactii> tranzactii;
        public IstoricTranzactii(int iduser)
        {
            InitializeComponent();
            tranzactii = SqliteDataAccess.SearchTranzactieId(iduser);
            dataGridView.DataSource = tranzactii;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
