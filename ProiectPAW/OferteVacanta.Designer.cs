namespace ProiectPAW
{
    partial class OferteVacanta
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
            this.gbTurist = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblServicii = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.cbServicii = new System.Windows.Forms.ComboBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lblDestinatie = new System.Windows.Forms.Label();
            this.lblOferte = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.turistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.turistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbTurist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTurist
            // 
            this.gbTurist.Controls.Add(this.button1);
            this.gbTurist.Controls.Add(this.lblServicii);
            this.gbTurist.Controls.Add(this.btnCauta);
            this.gbTurist.Controls.Add(this.cbServicii);
            this.gbTurist.Controls.Add(this.tbNume);
            this.gbTurist.Controls.Add(this.lblDestinatie);
            this.gbTurist.Location = new System.Drawing.Point(13, 54);
            this.gbTurist.Name = "gbTurist";
            this.gbTurist.Size = new System.Drawing.Size(310, 374);
            this.gbTurist.TabIndex = 0;
            this.gbTurist.TabStop = false;
            this.gbTurist.Text = "Cauta sejurul perfect";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(180, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Alege oferta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Location = new System.Drawing.Point(6, 106);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(53, 17);
            this.lblServicii.TabIndex = 8;
            this.lblServicii.Text = "Servicii";
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauta.Image = global::ProiectPAW.Properties.Resources.search2;
            this.btnCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCauta.Location = new System.Drawing.Point(9, 309);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(119, 44);
            this.btnCauta.TabIndex = 11;
            this.btnCauta.Text = "Cauta  ";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // cbServicii
            // 
            this.cbServicii.FormattingEnabled = true;
            this.cbServicii.Location = new System.Drawing.Point(9, 126);
            this.cbServicii.Name = "cbServicii";
            this.cbServicii.Size = new System.Drawing.Size(290, 24);
            this.cbServicii.TabIndex = 6;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(9, 64);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(290, 22);
            this.tbNume.TabIndex = 1;
            // 
            // lblDestinatie
            // 
            this.lblDestinatie.AutoSize = true;
            this.lblDestinatie.Location = new System.Drawing.Point(6, 44);
            this.lblDestinatie.Name = "lblDestinatie";
            this.lblDestinatie.Size = new System.Drawing.Size(71, 17);
            this.lblDestinatie.TabIndex = 0;
            this.lblDestinatie.Text = "Destinatie";
            // 
            // lblOferte
            // 
            this.lblOferte.AutoSize = true;
            this.lblOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOferte.Location = new System.Drawing.Point(659, 24);
            this.lblOferte.Name = "lblOferte";
            this.lblOferte.Size = new System.Drawing.Size(112, 25);
            this.lblOferte.TabIndex = 2;
            this.lblOferte.Text = "Lista Oferte";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.destinatieDataGridViewTextBoxColumn,
            this.serviciuDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.oferteBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(329, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(869, 367);
            this.dataGridView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinatieDataGridViewTextBoxColumn
            // 
            this.destinatieDataGridViewTextBoxColumn.DataPropertyName = "Destinatie";
            this.destinatieDataGridViewTextBoxColumn.HeaderText = "Destinatie";
            this.destinatieDataGridViewTextBoxColumn.Name = "destinatieDataGridViewTextBoxColumn";
            this.destinatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinatieDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviciuDataGridViewTextBoxColumn
            // 
            this.serviciuDataGridViewTextBoxColumn.DataPropertyName = "Serviciu";
            this.serviciuDataGridViewTextBoxColumn.HeaderText = "Serviciu";
            this.serviciuDataGridViewTextBoxColumn.Name = "serviciuDataGridViewTextBoxColumn";
            this.serviciuDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviciuDataGridViewTextBoxColumn.Width = 150;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret/ persoana";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 130;
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            this.detaliiDataGridViewTextBoxColumn.ReadOnly = true;
            this.detaliiDataGridViewTextBoxColumn.Width = 500;
            // 
            // oferteBindingSource
            // 
            this.oferteBindingSource.DataSource = typeof(ProiectPAW.Models.Oferte);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // turistBindingSource1
            // 
            this.turistBindingSource1.DataSource = typeof(ProiectPAW.Models.Turist);
            // 
            // turistBindingSource
            // 
            this.turistBindingSource.DataSource = typeof(ProiectPAW.Models.Turist);
            // 
            // OferteVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 435);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblOferte);
            this.Controls.Add(this.gbTurist);
            this.Name = "OferteVacanta";
            this.Text = "Oferte Vacanta";
            this.gbTurist.ResumeLayout(false);
            this.gbTurist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTurist;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblDestinatie;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblOferte;
        private System.Windows.Forms.BindingSource turistBindingSource1;
        private System.Windows.Forms.BindingSource turistBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctPlecareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.ComboBox cbServicii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretPersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oferteBindingSource;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
    }
}

