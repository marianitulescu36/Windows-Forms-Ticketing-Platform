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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Models.Turist turist;
            string user = tbUsername.Text;
            string pass = tbPassword.Text;
            turist = SqliteDataAccess.SearchTurist(user, pass);

            if (tbUsername.Text == "")
                errorProvider.SetError(tbUsername, "Introduceti username");
            else
            {
                errorProvider.Clear();
                if (tbPassword.Text == "") errorProvider.SetError(tbPassword, "Introduceti parola");
                else
                    if(tbUsername.Text=="admin" && tbPassword.Text=="admin")
                {
                    MenuAdmin menuadm = new MenuAdmin();
                    this.Hide();
                    menuadm.ShowDialog();
                    this.Close();
                }
                else
                    if (turist == null) MessageBox.Show("Introduceti date corecte!", "Error");
                else
                {
                    Menu menu = new Menu(user, pass);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnSign_Click_1(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
