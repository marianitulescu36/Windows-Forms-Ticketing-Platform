using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPAW
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            List<string> servicii = SqliteDataAccess.LoadDomenii();
            List<int> nrAparitii = new List<int>();
            int nr;
            foreach (string i in servicii)
            {
                nr = SqliteDataAccess.SearchNrServicii(i);
                nrAparitii.Add(nr);
            }

            string[] x = servicii.ToArray();
            int[] y = nrAparitii.ToArray();

            Chart.Series[0].ChartType = SeriesChartType.Pie;
            Chart.Series[0].Points.DataBindXY(x, y);
            Chart.Legends[0].Enabled = true;
            //Chart.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        public void PrintPanel(Panel MyPanel)
        {
            Bitmap MyChartPanel = new Bitmap(MyPanel.Width, MyPanel.Height);
            MyPanel.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, MyPanel.Width, MyPanel.Height));

            PrintDialog MyPrintDialog = new PrintDialog();

            if (MyPrintDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Printing.PrinterSettings values;
                values = MyPrintDialog.PrinterSettings;
                MyPrintDialog.Document = new PrintDocument();
                MyPrintDocument.PrintController = new System.Drawing.Printing.StandardPrintController();
                MyPrintDocument.Print();
            }

            MyPrintDocument.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //PrintPanel(MyPanel);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = this.Chart.Printing.PrintDocument;
            ppd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
