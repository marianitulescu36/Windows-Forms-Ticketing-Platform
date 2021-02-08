namespace ProiectPAW
{
    partial class ListaOferte
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
            this.dgvListaOferte = new System.Windows.Forms.DataGridView();
            this.btnAlege = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordoneazaAlfabeticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteazaInFunctieDePretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descrescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descarcaListaOferteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOferte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaOferte
            // 
            this.dgvListaOferte.AllowUserToResizeColumns = false;
            this.dgvListaOferte.AllowUserToResizeRows = false;
            this.dgvListaOferte.AutoGenerateColumns = false;
            this.dgvListaOferte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOferte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.destinatieDataGridViewTextBoxColumn,
            this.serviciuDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dgvListaOferte.DataSource = this.oferteBindingSource;
            this.dgvListaOferte.Location = new System.Drawing.Point(12, 47);
            this.dgvListaOferte.Name = "dgvListaOferte";
            this.dgvListaOferte.ReadOnly = true;
            this.dgvListaOferte.RowHeadersVisible = false;
            this.dgvListaOferte.RowTemplate.Height = 24;
            this.dgvListaOferte.Size = new System.Drawing.Size(1193, 381);
            this.dgvListaOferte.TabIndex = 4;
            // 
            // btnAlege
            // 
            this.btnAlege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlege.Location = new System.Drawing.Point(1050, 447);
            this.btnAlege.Name = "btnAlege";
            this.btnAlege.Size = new System.Drawing.Size(155, 57);
            this.btnAlege.TabIndex = 5;
            this.btnAlege.Text = "Alege oferta!";
            this.btnAlege.UseVisualStyleBackColor = true;
            this.btnAlege.Click += new System.EventHandler(this.btnAlege_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordoneazaAlfabeticToolStripMenuItem,
            this.sorteazaInFunctieDePretToolStripMenuItem,
            this.descarcaListaOferteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordoneazaAlfabeticToolStripMenuItem
            // 
            this.ordoneazaAlfabeticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem});
            this.ordoneazaAlfabeticToolStripMenuItem.Name = "ordoneazaAlfabeticToolStripMenuItem";
            this.ordoneazaAlfabeticToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.ordoneazaAlfabeticToolStripMenuItem.Text = "Ordoneaza alfabetic";
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.aZToolStripMenuItem.Text = "A - Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.zAToolStripMenuItem.Text = "Z - A";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.zAToolStripMenuItem_Click);
            // 
            // sorteazaInFunctieDePretToolStripMenuItem
            // 
            this.sorteazaInFunctieDePretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescatorToolStripMenuItem,
            this.descrescatorToolStripMenuItem});
            this.sorteazaInFunctieDePretToolStripMenuItem.Name = "sorteazaInFunctieDePretToolStripMenuItem";
            this.sorteazaInFunctieDePretToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.sorteazaInFunctieDePretToolStripMenuItem.Text = "Sorteaza in functie de pret";
            // 
            // crescatorToolStripMenuItem
            // 
            this.crescatorToolStripMenuItem.Name = "crescatorToolStripMenuItem";
            this.crescatorToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.crescatorToolStripMenuItem.Text = "Crescator";
            this.crescatorToolStripMenuItem.Click += new System.EventHandler(this.crescatorToolStripMenuItem_Click);
            // 
            // descrescatorToolStripMenuItem
            // 
            this.descrescatorToolStripMenuItem.Name = "descrescatorToolStripMenuItem";
            this.descrescatorToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.descrescatorToolStripMenuItem.Text = "Descrescator";
            this.descrescatorToolStripMenuItem.Click += new System.EventHandler(this.descrescatorToolStripMenuItem_Click);
            // 
            // descarcaListaOferteToolStripMenuItem
            // 
            this.descarcaListaOferteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentTextToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.descarcaListaOferteToolStripMenuItem.Name = "descarcaListaOferteToolStripMenuItem";
            this.descarcaListaOferteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.descarcaListaOferteToolStripMenuItem.Text = "Descarca lista oferte";
            // 
            // documentTextToolStripMenuItem
            // 
            this.documentTextToolStripMenuItem.Name = "documentTextToolStripMenuItem";
            this.documentTextToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.documentTextToolStripMenuItem.Text = "Document Text";
            this.documentTextToolStripMenuItem.Click += new System.EventHandler(this.documentTextToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xmlToolStripMenuItem.Text = "XML";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
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
            this.destinatieDataGridViewTextBoxColumn.Width = 200;
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
            this.pretDataGridViewTextBoxColumn.Width = 150;
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
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(865, 447);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 57);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Inapoi la meniu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListaOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 516);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAlege);
            this.Controls.Add(this.dgvListaOferte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaOferte";
            this.Text = "ListaOferte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOferte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaOferte;
        private System.Windows.Forms.BindingSource oferteBindingSource;
        private System.Windows.Forms.Button btnAlege;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordoneazaAlfabeticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteazaInFunctieDePretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descarcaListaOferteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descrescatorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}