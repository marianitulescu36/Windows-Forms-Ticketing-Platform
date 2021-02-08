namespace ProiectPAW
{
    partial class EditeazaOferte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeazaOferte));
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblServicii = new System.Windows.Forms.Label();
            this.cbServicii = new System.Windows.Forms.ComboBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDetalii
            // 
            this.tbDetalii.Location = new System.Drawing.Point(35, 229);
            this.tbDetalii.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetalii.Multiline = true;
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(268, 127);
            this.tbDetalii.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Detalii Oferta";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(35, 168);
            this.tbPret.Margin = new System.Windows.Forms.Padding(4);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(268, 22);
            this.tbPret.TabIndex = 34;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(32, 147);
            this.lblPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(103, 17);
            this.lblPret.TabIndex = 33;
            this.lblPret.Text = "Pret/ Persoana";
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Location = new System.Drawing.Point(32, 83);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(77, 17);
            this.lblServicii.TabIndex = 32;
            this.lblServicii.Text = "Tip Servicii";
            // 
            // cbServicii
            // 
            this.cbServicii.FormattingEnabled = true;
            this.cbServicii.Location = new System.Drawing.Point(35, 103);
            this.cbServicii.Name = "cbServicii";
            this.cbServicii.Size = new System.Drawing.Size(268, 24);
            this.cbServicii.TabIndex = 31;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(35, 45);
            this.tbLocatie.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(268, 22);
            this.tbLocatie.TabIndex = 30;
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Location = new System.Drawing.Point(32, 24);
            this.labelLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(54, 17);
            this.labelLocatie.TabIndex = 29;
            this.labelLocatie.Text = "Locatie";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(189, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 62);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Anuleaza";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirma.Image = global::ProiectPAW.Properties.Resources.good;
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirma.Location = new System.Drawing.Point(35, 375);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(111, 62);
            this.btnConfirma.TabIndex = 37;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // EditeazaOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.tbDetalii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblServicii);
            this.Controls.Add(this.cbServicii);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.labelLocatie);
            this.Name = "EditeazaOferte";
            this.Text = "Editeaza Oferta";
            this.Load += new System.EventHandler(this.EditeazaOferte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.ComboBox cbServicii;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label labelLocatie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirma;
    }
}