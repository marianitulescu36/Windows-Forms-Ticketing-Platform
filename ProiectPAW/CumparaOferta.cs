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
    public partial class CumparaOferta : Form
    {
        Models.Tranzactii tranzactie;
        int iduser;
        int idof;
        double pretof;
        public CumparaOferta(string username, int idOferta)
        {
            InitializeComponent();
            
            idof = idOferta;
            StringBuilder mesaj = new StringBuilder();
            // aici caut detaliile cumparatorului si ale ofertei si scriu in label frum
            Models.Turist turist;
            turist = SqliteDataAccess.SearchTuristUsername(username);
            iduser = turist.Id;

            Models.Oferte oferta;
            oferta = SqliteDataAccess.SearchOferteId(idOferta);
            pretof = Convert.ToDouble(oferta.Pret);

            StringBuilder labelMesaj = new StringBuilder();
            string unu = "Detalii oferta aleasa", doi = "Destinatia: ", trei = "Serviciu prestat: ", patru = "Detalii: ", cinci = "Pret/ persoana: ";
            labelMesaj.Append(unu + Environment.NewLine + Environment.NewLine + doi + oferta.Destinatie + Environment.NewLine + trei + oferta.Serviciu + Environment.NewLine + patru + oferta.Detalii + Environment.NewLine + cinci + oferta.Pret);

            lblDetalii.Text = labelMesaj.ToString();

            List<int> pers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbNrPersoane.DataSource = pers;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tranzactie = new Models.Tranzactii();
            tranzactie.IdUser = iduser;
            tranzactie.IdOferta = idof;
            tranzactie.ContIBAN = tbIBAN.Text;

            StringBuilder detaliitr = new StringBuilder();
            string unu = "Numar persoane: ", doi = "Data check-in: ", trei = "Email: ";
            detaliitr.Append(unu + cbNrPersoane.Text + "   " + doi + dtpCheckin.Text + "   " + trei + tbEmail.Text);

            tranzactie.DetaliiTranzactie = detaliitr.ToString();
            double nrpers = Convert.ToDouble(cbNrPersoane.Text);
            tranzactie.Suma = nrpers * pretof;

            tranzactie.DataTranzactie = DateTime.Now.ToString();

            SqliteDataAccess.SaveTranzactie(tranzactie);

            MessageBox.Show("Tranzactia a fost finalizata" + Environment.NewLine + "Vacanta placuta!", "Va multumim!");

            this.Close();
        }
    }
}
