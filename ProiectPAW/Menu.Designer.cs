namespace ProiectPAW
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelBackgroung = new System.Windows.Forms.Panel();
            this.btnAdaugaOferta = new System.Windows.Forms.Button();
            this.btnIstoric = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblBunVenit = new System.Windows.Forms.Label();
            this.btnOferte = new System.Windows.Forms.Button();
            this.btnCautaOferte = new System.Windows.Forms.Button();
            this.panelBackgroung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackgroung
            // 
            this.panelBackgroung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackgroung.BackgroundImage")));
            this.panelBackgroung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBackgroung.Controls.Add(this.btnAdaugaOferta);
            this.panelBackgroung.Controls.Add(this.btnIstoric);
            this.panelBackgroung.Controls.Add(this.btnLogout);
            this.panelBackgroung.Controls.Add(this.lblBunVenit);
            this.panelBackgroung.Controls.Add(this.btnOferte);
            this.panelBackgroung.Controls.Add(this.btnCautaOferte);
            this.panelBackgroung.Location = new System.Drawing.Point(1, 0);
            this.panelBackgroung.Name = "panelBackgroung";
            this.panelBackgroung.Size = new System.Drawing.Size(477, 612);
            this.panelBackgroung.TabIndex = 0;
            // 
            // btnAdaugaOferta
            // 
            this.btnAdaugaOferta.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdaugaOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaOferta.Location = new System.Drawing.Point(131, 375);
            this.btnAdaugaOferta.Name = "btnAdaugaOferta";
            this.btnAdaugaOferta.Size = new System.Drawing.Size(217, 52);
            this.btnAdaugaOferta.TabIndex = 5;
            this.btnAdaugaOferta.Text = "Adauga propria oferta";
            this.btnAdaugaOferta.UseVisualStyleBackColor = false;
            this.btnAdaugaOferta.Click += new System.EventHandler(this.btnAdaugaOferta_Click);
            // 
            // btnIstoric
            // 
            this.btnIstoric.BackColor = System.Drawing.SystemColors.Info;
            this.btnIstoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIstoric.Location = new System.Drawing.Point(131, 292);
            this.btnIstoric.Name = "btnIstoric";
            this.btnIstoric.Size = new System.Drawing.Size(217, 52);
            this.btnIstoric.TabIndex = 4;
            this.btnIstoric.Text = "Istoric tranzactii";
            this.btnIstoric.UseVisualStyleBackColor = false;
            this.btnIstoric.Click += new System.EventHandler(this.btnIstoric_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.Location = new System.Drawing.Point(131, 458);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 52);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblBunVenit
            // 
            this.lblBunVenit.BackColor = System.Drawing.Color.Transparent;
            this.lblBunVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBunVenit.Location = new System.Drawing.Point(49, 24);
            this.lblBunVenit.Name = "lblBunVenit";
            this.lblBunVenit.Size = new System.Drawing.Size(385, 56);
            this.lblBunVenit.TabIndex = 2;
            this.lblBunVenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOferte
            // 
            this.btnOferte.BackColor = System.Drawing.SystemColors.Info;
            this.btnOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOferte.Location = new System.Drawing.Point(131, 123);
            this.btnOferte.Name = "btnOferte";
            this.btnOferte.Size = new System.Drawing.Size(217, 56);
            this.btnOferte.TabIndex = 1;
            this.btnOferte.Text = "Vizualizare oferte";
            this.btnOferte.UseVisualStyleBackColor = false;
            this.btnOferte.Click += new System.EventHandler(this.btnOferte_Click);
            // 
            // btnCautaOferte
            // 
            this.btnCautaOferte.BackColor = System.Drawing.SystemColors.Info;
            this.btnCautaOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCautaOferte.Location = new System.Drawing.Point(131, 206);
            this.btnCautaOferte.Name = "btnCautaOferte";
            this.btnCautaOferte.Size = new System.Drawing.Size(217, 60);
            this.btnCautaOferte.TabIndex = 0;
            this.btnCautaOferte.Text = "Cauta vacanta perfecta";
            this.btnCautaOferte.UseVisualStyleBackColor = false;
            this.btnCautaOferte.Click += new System.EventHandler(this.btnCautaOferte_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 614);
            this.Controls.Add(this.panelBackgroung);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panelBackgroung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackgroung;
        private System.Windows.Forms.Button btnOferte;
        private System.Windows.Forms.Button btnCautaOferte;
        private System.Windows.Forms.Label lblBunVenit;
        private System.Windows.Forms.Button btnIstoric;
        private System.Windows.Forms.Button btnAdaugaOferta;
        private System.Windows.Forms.Button btnLogout;
    }
}