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
    public partial class EditeazaOferte : Form
    {
        Models.Oferte _instance;

        public EditeazaOferte(Models.Oferte oferta)
        {
            InitializeComponent();
            _instance = oferta;
            List<string> servicii = SqliteDataAccess.LoadServicii();
            cbServicii.DataSource = servicii;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditeazaOferte_Load(object sender, EventArgs e)
        {
            tbLocatie.Text = _instance.Destinatie;
            cbServicii.Text = _instance.Serviciu;
            tbPret.Text = _instance.Pret.ToString();
            tbDetalii.Text = _instance.Detalii;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            _instance.Destinatie = tbLocatie.Text;
            _instance.Serviciu = cbServicii.Text;
            _instance.Pret = tbPret.Text;
            _instance.Detalii = tbDetalii.Text;

            SqliteDataAccess.UpdateOferta(_instance);

            this.Close();
        }
    }
}
