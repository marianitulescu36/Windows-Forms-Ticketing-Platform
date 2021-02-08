namespace ProiectPAW
{
    partial class ModificaOferte
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitluTabel = new System.Windows.Forms.Label();
            this.gbOferte = new System.Windows.Forms.GroupBox();
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblServicii = new System.Windows.Forms.Label();
            this.cbServicii = new System.Windows.Forms.ComboBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.epLocatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.gbOferte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(336, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 478);
            this.label1.TabIndex = 20;
            // 
            // labelTitluTabel
            // 
            this.labelTitluTabel.AutoSize = true;
            this.labelTitluTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitluTabel.Location = new System.Drawing.Point(769, 21);
            this.labelTitluTabel.Name = "labelTitluTabel";
            this.labelTitluTabel.Size = new System.Drawing.Size(124, 25);
            this.labelTitluTabel.TabIndex = 18;
            this.labelTitluTabel.Text = "Lista Oferte";
            // 
            // gbOferte
            // 
            this.gbOferte.Controls.Add(this.tbDetalii);
            this.gbOferte.Controls.Add(this.label2);
            this.gbOferte.Controls.Add(this.tbPret);
            this.gbOferte.Controls.Add(this.lblPret);
            this.gbOferte.Controls.Add(this.lblServicii);
            this.gbOferte.Controls.Add(this.cbServicii);
            this.gbOferte.Controls.Add(this.tbLocatie);
            this.gbOferte.Controls.Add(this.labelLocatie);
            this.gbOferte.Location = new System.Drawing.Point(12, 41);
            this.gbOferte.Name = "gbOferte";
            this.gbOferte.Size = new System.Drawing.Size(308, 387);
            this.gbOferte.TabIndex = 16;
            this.gbOferte.TabStop = false;
            this.gbOferte.Text = "Detalii Oferte";
            // 
            // tbDetalii
            // 
            this.tbDetalii.Location = new System.Drawing.Point(19, 236);
            this.tbDetalii.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetalii.Multiline = true;
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(268, 127);
            this.tbDetalii.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Detalii Oferta";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(19, 175);
            this.tbPret.Margin = new System.Windows.Forms.Padding(4);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(268, 22);
            this.tbPret.TabIndex = 26;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(16, 154);
            this.lblPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(103, 17);
            this.lblPret.TabIndex = 25;
            this.lblPret.Text = "Pret/ Persoana";
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Location = new System.Drawing.Point(16, 90);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(77, 17);
            this.lblServicii.TabIndex = 24;
            this.lblServicii.Text = "Tip Servicii";
            // 
            // cbServicii
            // 
            this.cbServicii.FormattingEnabled = true;
            this.cbServicii.Location = new System.Drawing.Point(19, 110);
            this.cbServicii.Name = "cbServicii";
            this.cbServicii.Size = new System.Drawing.Size(268, 24);
            this.cbServicii.TabIndex = 23;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(19, 52);
            this.tbLocatie.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(268, 22);
            this.tbLocatie.TabIndex = 5;
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(16, 31);
            this.labelLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(54, 17);
            this.labelLocatie.TabIndex = 4;
            this.labelLocatie.Text = "Locatie";
            // 
            // epLocatie
            // 
            this.epLocatie.ContainerControl = this;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.destinatieDataGridViewTextBoxColumn,
            this.serviciuDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.oferteBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(351, 49);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(928, 422);
            this.dataGridView.TabIndex = 23;
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
            this.serviciuDataGridViewTextBoxColumn.Width = 170;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            this.detaliiDataGridViewTextBoxColumn.ReadOnly = true;
            this.detaliiDataGridViewTextBoxColumn.Width = 450;
            // 
            // oferteBindingSource
            // 
            this.oferteBindingSource.DataSource = typeof(ProiectPAW.Models.Oferte);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditeaza.Image = global::ProiectPAW.Properties.Resources.paint;
            this.btnEditeaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditeaza.Location = new System.Drawing.Point(967, 478);
            this.btnEditeaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(146, 62);
            this.btnEditeaza.TabIndex = 22;
            this.btnEditeaza.Text = "Editeaza \r\noferta";
            this.btnEditeaza.UseVisualStyleBackColor = false;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSterge.Image = global::ProiectPAW.Properties.Resources.trash;
            this.btnSterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSterge.Location = new System.Drawing.Point(1133, 478);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(4);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(146, 62);
            this.btnSterge.TabIndex = 21;
            this.btnSterge.Text = "Sterge \r\noferta";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCurata.Image = global::ProiectPAW.Properties.Resources.eraser;
            this.btnCurata.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurata.Location = new System.Drawing.Point(174, 478);
            this.btnCurata.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(146, 62);
            this.btnCurata.TabIndex = 17;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurata.UseVisualStyleBackColor = false;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = global::ProiectPAW.Properties.Resources.add;
            this.btnAdauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdauga.Location = new System.Drawing.Point(12, 478);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(146, 62);
            this.btnAdauga.TabIndex = 15;
            this.btnAdauga.Text = "Adauga oferta";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // ModificaOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 550);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitluTabel);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.gbOferte);
            this.Controls.Add(this.btnAdauga);
            this.Name = "ModificaOferte";
            this.Text = "Modifica Oferte";
            this.gbOferte.ResumeLayout(false);
            this.gbOferte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLocatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitluTabel;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.GroupBox gbOferte;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.ComboBox cbServicii;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.ErrorProvider epLocatie;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource oferteBindingSource;
        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
    }
}