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
    public partial class Menu : Form
    {
        string username;
        int iduser;
        public Menu(string user, string pass)
        {
            InitializeComponent();
            Models.Turist turist;
            turist = SqliteDataAccess.SearchTurist(user, pass);
            lblBunVenit.Text = "Bine ai venit, " + turist.Prenume + "!";
            username = user;
            iduser = turist.Id;
        }

        private void btnCautaOferte_Click(object sender, EventArgs e)
        {
            OferteVacanta cautare = new OferteVacanta(username);
            cautare.ShowDialog();
        }

        private void btnOferte_Click(object sender, EventArgs e)
        {
            ListaOferte listaoferte = new ListaOferte(username);
            listaoferte.ShowDialog();
        }

        private void btnAdaugaOferta_Click(object sender, EventArgs e)
        {
            AdaugareOferta newOferta = new AdaugareOferta();
            newOferta.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnIstoric_Click(object sender, EventArgs e)
        {
            IstoricTranzactii ist = new IstoricTranzactii(iduser);
            ist.ShowDialog();
        }
    }
}
