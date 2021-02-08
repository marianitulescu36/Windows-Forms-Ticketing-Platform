namespace ProiectPAW
{
    partial class CumparaOferta
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
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.lblDetalii = new System.Windows.Forms.Label();
            this.cbNrPersoane = new System.Windows.Forms.ComboBox();
            this.lblNrPersoane = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Location = new System.Drawing.Point(105, 283);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(270, 22);
            this.dtpCheckin.TabIndex = 12;
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(102, 263);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(95, 17);
            this.lblCheckin.TabIndex = 11;
            this.lblCheckin.Text = "Data check-in";
            // 
            // lblDetalii
            // 
            this.lblDetalii.Location = new System.Drawing.Point(102, 23);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(354, 164);
            this.lblDetalii.TabIndex = 13;
            // 
            // cbNrPersoane
            // 
            this.cbNrPersoane.FormattingEnabled = true;
            this.cbNrPersoane.Location = new System.Drawing.Point(105, 221);
            this.cbNrPersoane.Name = "cbNrPersoane";
            this.cbNrPersoane.Size = new System.Drawing.Size(270, 24);
            this.cbNrPersoane.TabIndex = 15;
            // 
            // lblNrPersoane
            // 
            this.lblNrPersoane.AutoSize = true;
            this.lblNrPersoane.Location = new System.Drawing.Point(102, 201);
            this.lblNrPersoane.Name = "lblNrPersoane";
            this.lblNrPersoane.Size = new System.Drawing.Size(114, 17);
            this.lblNrPersoane.TabIndex = 14;
            this.lblNrPersoane.Text = "Numar persoane";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(105, 338);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(270, 24);
            this.tbEmail.TabIndex = 31;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(102, 318);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            // 
            // tbIBAN
            // 
            this.tbIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIBAN.Location = new System.Drawing.Point(105, 395);
            this.tbIBAN.Multiline = true;
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.Size = new System.Drawing.Size(270, 24);
            this.tbIBAN.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(102, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cont IBAN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(312, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 66);
            this.button1.TabIndex = 34;
            this.button1.Text = "Comanda oferta!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(28, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 66);
            this.button2.TabIndex = 35;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CumparaOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cbNrPersoane);
            this.Controls.Add(this.lblNrPersoane);
            this.Controls.Add(this.lblDetalii);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.lblCheckin);
            this.Name = "CumparaOferta";
            this.Text = "CumparaOferta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label lblDetalii;
        private System.Windows.Forms.ComboBox cbNrPersoane;
        private System.Windows.Forms.Label lblNrPersoane;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}