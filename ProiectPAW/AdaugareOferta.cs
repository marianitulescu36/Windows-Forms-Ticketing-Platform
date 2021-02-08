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
    public partial class AdaugareOferta : Form
    {
        public AdaugareOferta()
        {
            InitializeComponent();
        }

        private void btnServicii_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(btnServicii.Left + btnServicii.Width + this.Left, btnServicii.Top + btnServicii.Height + this.Top);
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Cazare - Hotel";
        }

        private void pensiuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Cazare - Pensiune";
        }

        private void airBnbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Cazare - AirBnb";
        }

        private void asigurareMedicalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Asigurare medicala";
        }

        private void asigurareDeCalatorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Asigurare de calatorie";
        }

        private void circuitReligiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Circuit religios";
        }

        private void circuiteMontaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Circuite montane";
        }

        private void circuiteInNaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Circuite in natura";
        }

        private void croazieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnServicii.Text = "Croaziera";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDestinatie.Text == "")
                errorProvider.SetError(tbDestinatie, "Introduceti destinatie");
            else
            {
                errorProvider.Clear();
                if (btnServicii.Text=="Alege") errorProvider.SetError(btnServicii, "Alege un serviciu!");
                else
                    if (tbDetalii.Text== "") errorProvider.SetError(tbDetalii, "Introduceti detalii oferta!");
                else
                    if (tbEmail.Text == "") errorProvider.SetError(tbEmail, "Introduceti email!");
                else
                {
                    StringBuilder mesaj = new StringBuilder();
                    string unu = "Oferta dumneavoastra a fost trimisa!", doi = "Destinatia: ", trei = "Serviciu prestat: ", patru = "Detalii: ", cinci = "Veti fi contactat pe email in maximum 5 zile lucratoare pentru validarea datelor!";
                    mesaj.Append(unu + Environment.NewLine + Environment.NewLine + doi + tbDestinatie.Text + Environment.NewLine + trei + btnServicii.Text + Environment.NewLine + patru + tbDetalii.Text + Environment.NewLine + Environment.NewLine + cinci);
                    MessageBox.Show(mesaj.ToString(), "Formularul a fost trimis cu succes!");
                    this.Close();
                }
            }
            
        }
    }
}
