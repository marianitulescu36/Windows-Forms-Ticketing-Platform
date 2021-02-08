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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string pren = tbPrenume.Text;
            string user = tbUsername.Text;
            string pass = tbPassword.Text;
            Models.Turist turist = new Models.Turist(nume, pren, user, pass);
            if (nume!="" && pren!="" && user!="" && pass!="") {
                SqliteDataAccess.SaveTurist(turist);
                MessageBox.Show("Ati fost inregistrat cu succes!", " ");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            else
                MessageBox.Show("Introduceti date valide!", " ");

        }
    }
}
