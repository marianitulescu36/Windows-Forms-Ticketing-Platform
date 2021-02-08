namespace ProiectPAW
{
    partial class IstoricTranzactii
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idTranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contIBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiTranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTranzactieDataGridViewTextBoxColumn,
            this.idUserDataGridViewTextBoxColumn,
            this.idOfertaDataGridViewTextBoxColumn,
            this.contIBANDataGridViewTextBoxColumn,
            this.detaliiTranzactieDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.dataTranzactieDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tranzactiiBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 66);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 372);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // idTranzactieDataGridViewTextBoxColumn
            // 
            this.idTranzactieDataGridViewTextBoxColumn.DataPropertyName = "IdTranzactie";
            this.idTranzactieDataGridViewTextBoxColumn.HeaderText = "IdTranzactie";
            this.idTranzactieDataGridViewTextBoxColumn.Name = "idTranzactieDataGridViewTextBoxColumn";
            this.idTranzactieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTranzactieDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "IdUser";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "IdUser";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            this.idUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // idOfertaDataGridViewTextBoxColumn
            // 
            this.idOfertaDataGridViewTextBoxColumn.DataPropertyName = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.HeaderText = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.Name = "idOfertaDataGridViewTextBoxColumn";
            this.idOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOfertaDataGridViewTextBoxColumn.Visible = false;
            // 
            // contIBANDataGridViewTextBoxColumn
            // 
            this.contIBANDataGridViewTextBoxColumn.DataPropertyName = "ContIBAN";
            this.contIBANDataGridViewTextBoxColumn.HeaderText = "ContIBAN";
            this.contIBANDataGridViewTextBoxColumn.Name = "contIBANDataGridViewTextBoxColumn";
            this.contIBANDataGridViewTextBoxColumn.ReadOnly = true;
            this.contIBANDataGridViewTextBoxColumn.Visible = false;
            // 
            // detaliiTranzactieDataGridViewTextBoxColumn
            // 
            this.detaliiTranzactieDataGridViewTextBoxColumn.DataPropertyName = "DetaliiTranzactie";
            this.detaliiTranzactieDataGridViewTextBoxColumn.HeaderText = "DetaliiTranzactie";
            this.detaliiTranzactieDataGridViewTextBoxColumn.Name = "detaliiTranzactieDataGridViewTextBoxColumn";
            this.detaliiTranzactieDataGridViewTextBoxColumn.ReadOnly = true;
            this.detaliiTranzactieDataGridViewTextBoxColumn.Width = 300;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTranzactieDataGridViewTextBoxColumn
            // 
            this.dataTranzactieDataGridViewTextBoxColumn.DataPropertyName = "DataTranzactie";
            this.dataTranzactieDataGridViewTextBoxColumn.HeaderText = "DataTranzactie";
            this.dataTranzactieDataGridViewTextBoxColumn.Name = "dataTranzactieDataGridViewTextBoxColumn";
            this.dataTranzactieDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataTranzactieDataGridViewTextBoxColumn.Width = 200;
            // 
            // tranzactiiBindingSource
            // 
            this.tranzactiiBindingSource.DataSource = typeof(ProiectPAW.Models.Tranzactii);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(222, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acestea sunt tranzactiile tale de pana acum";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IstoricTranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "IstoricTranzactii";
            this.Text = "IstoricTranzactii";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tranzactiiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contIBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiTranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTranzactieDataGridViewTextBoxColumn;
    }
}