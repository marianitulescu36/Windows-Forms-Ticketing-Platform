namespace ProiectPAW
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.MyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(3, 0);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(758, 405);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Comenzi servicii";
            title1.Name = "Comenzi servicii";
            this.Chart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivelul ofertei pentru fiecare tip de serviciu";
            // 
            // MyPanel
            // 
            this.MyPanel.Controls.Add(this.Chart);
            this.MyPanel.Location = new System.Drawing.Point(12, 58);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(771, 416);
            this.MyPanel.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.Location = new System.Drawing.Point(655, 490);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 47);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(15, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.label1);
            this.Name = "ChartForm";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.MyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MyPanel;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}