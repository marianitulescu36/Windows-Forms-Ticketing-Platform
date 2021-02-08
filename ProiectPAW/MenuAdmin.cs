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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModificaOferte modifica = new ModificaOferte();
            modifica.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            ChartForm charts = new ChartForm();
            charts.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DragDrop dd = new DragDrop();
            dd.ShowDialog();
        }
    }
}
