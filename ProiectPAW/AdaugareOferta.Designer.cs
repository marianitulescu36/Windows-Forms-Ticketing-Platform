namespace ProiectPAW
{
    partial class AdaugareOferta
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
            this.lblServicii = new System.Windows.Forms.Label();
            this.tbDestinatie = new System.Windows.Forms.TextBox();
            this.lblDestinatie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pensiuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airBnbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asigurariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asigurareMedicalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asigurareDeCalatorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuitReligiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuiteMontaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuiteInNaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.croazieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServicii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Location = new System.Drawing.Point(28, 140);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(53, 17);
            this.lblServicii.TabIndex = 20;
            this.lblServicii.Text = "Servicii";
            // 
            // tbDestinatie
            // 
            this.tbDestinatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDestinatie.Location = new System.Drawing.Point(31, 92);
            this.tbDestinatie.Multiline = true;
            this.tbDestinatie.Name = "tbDestinatie";
            this.tbDestinatie.Size = new System.Drawing.Size(333, 38);
            this.tbDestinatie.TabIndex = 16;
            // 
            // lblDestinatie
            // 
            this.lblDestinatie.AutoSize = true;
            this.lblDestinatie.Location = new System.Drawing.Point(28, 72);
            this.lblDestinatie.Name = "lblDestinatie";
            this.lblDestinatie.Size = new System.Drawing.Size(71, 17);
            this.lblDestinatie.TabIndex = 15;
            this.lblDestinatie.Text = "Destinatie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detalii";
            // 
            // tbDetalii
            // 
            this.tbDetalii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDetalii.Location = new System.Drawing.Point(31, 234);
            this.tbDetalii.Multiline = true;
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(333, 83);
            this.tbDetalii.TabIndex = 23;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.asigurariToolStripMenuItem,
            this.circuiteToolStripMenuItem,
            this.croazieraToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(142, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.pensiuneToolStripMenuItem,
            this.airBnbToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1.Text = "Cazare";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.hotelToolStripMenuItem.Text = "Hotel";
            this.hotelToolStripMenuItem.Click += new System.EventHandler(this.hotelToolStripMenuItem_Click);
            // 
            // pensiuneToolStripMenuItem
            // 
            this.pensiuneToolStripMenuItem.Name = "pensiuneToolStripMenuItem";
            this.pensiuneToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.pensiuneToolStripMenuItem.Text = "Pensiune";
            this.pensiuneToolStripMenuItem.Click += new System.EventHandler(this.pensiuneToolStripMenuItem_Click);
            // 
            // airBnbToolStripMenuItem
            // 
            this.airBnbToolStripMenuItem.Name = "airBnbToolStripMenuItem";
            this.airBnbToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.airBnbToolStripMenuItem.Text = "AirBnb";
            this.airBnbToolStripMenuItem.Click += new System.EventHandler(this.airBnbToolStripMenuItem_Click);
            // 
            // asigurariToolStripMenuItem
            // 
            this.asigurariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asigurareMedicalaToolStripMenuItem,
            this.asigurareDeCalatorieToolStripMenuItem});
            this.asigurariToolStripMenuItem.Name = "asigurariToolStripMenuItem";
            this.asigurariToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.asigurariToolStripMenuItem.Text = "Asigurari";
            // 
            // asigurareMedicalaToolStripMenuItem
            // 
            this.asigurareMedicalaToolStripMenuItem.Name = "asigurareMedicalaToolStripMenuItem";
            this.asigurareMedicalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asigurareMedicalaToolStripMenuItem.Text = "Asigurare medicala";
            this.asigurareMedicalaToolStripMenuItem.Click += new System.EventHandler(this.asigurareMedicalaToolStripMenuItem_Click);
            // 
            // asigurareDeCalatorieToolStripMenuItem
            // 
            this.asigurareDeCalatorieToolStripMenuItem.Name = "asigurareDeCalatorieToolStripMenuItem";
            this.asigurareDeCalatorieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asigurareDeCalatorieToolStripMenuItem.Text = "Asigurare de calatorie";
            this.asigurareDeCalatorieToolStripMenuItem.Click += new System.EventHandler(this.asigurareDeCalatorieToolStripMenuItem_Click);
            // 
            // circuiteToolStripMenuItem
            // 
            this.circuiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuitReligiosToolStripMenuItem,
            this.circuiteMontaneToolStripMenuItem,
            this.circuiteInNaturaToolStripMenuItem});
            this.circuiteToolStripMenuItem.Name = "circuiteToolStripMenuItem";
            this.circuiteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.circuiteToolStripMenuItem.Text = "Circuite";
            // 
            // circuitReligiosToolStripMenuItem
            // 
            this.circuitReligiosToolStripMenuItem.Name = "circuitReligiosToolStripMenuItem";
            this.circuitReligiosToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.circuitReligiosToolStripMenuItem.Text = "Circuit religios";
            this.circuitReligiosToolStripMenuItem.Click += new System.EventHandler(this.circuitReligiosToolStripMenuItem_Click);
            // 
            // circuiteMontaneToolStripMenuItem
            // 
            this.circuiteMontaneToolStripMenuItem.Name = "circuiteMontaneToolStripMenuItem";
            this.circuiteMontaneToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.circuiteMontaneToolStripMenuItem.Text = "Circuite montane";
            this.circuiteMontaneToolStripMenuItem.Click += new System.EventHandler(this.circuiteMontaneToolStripMenuItem_Click);
            // 
            // circuiteInNaturaToolStripMenuItem
            // 
            this.circuiteInNaturaToolStripMenuItem.Name = "circuiteInNaturaToolStripMenuItem";
            this.circuiteInNaturaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.circuiteInNaturaToolStripMenuItem.Text = "Circuite in natura";
            this.circuiteInNaturaToolStripMenuItem.Click += new System.EventHandler(this.circuiteInNaturaToolStripMenuItem_Click);
            // 
            // croazieraToolStripMenuItem
            // 
            this.croazieraToolStripMenuItem.Name = "croazieraToolStripMenuItem";
            this.croazieraToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.croazieraToolStripMenuItem.Text = "Croaziera";
            this.croazieraToolStripMenuItem.Click += new System.EventHandler(this.croazieraToolStripMenuItem_Click);
            // 
            // btnServicii
            // 
            this.btnServicii.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServicii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnServicii.Location = new System.Drawing.Point(31, 160);
            this.btnServicii.Name = "btnServicii";
            this.btnServicii.Size = new System.Drawing.Size(333, 41);
            this.btnServicii.TabIndex = 24;
            this.btnServicii.Text = "Alege";
            this.btnServicii.UseVisualStyleBackColor = false;
            this.btnServicii.Click += new System.EventHandler(this.btnServicii_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Posteaza propria oferta!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(136, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Trimite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(31, 350);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(333, 38);
            this.tbEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 330);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AdaugareOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 485);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServicii);
            this.Controls.Add(this.tbDetalii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServicii);
            this.Controls.Add(this.tbDestinatie);
            this.Controls.Add(this.lblDestinatie);
            this.Name = "AdaugareOferta";
            this.Text = "Trimite oferta";
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.TextBox tbDestinatie;
        private System.Windows.Forms.Label lblDestinatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pensiuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airBnbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asigurariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asigurareMedicalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asigurareDeCalatorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuitReligiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuiteMontaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuiteInNaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem croazieraToolStripMenuItem;
        private System.Windows.Forms.Button btnServicii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}