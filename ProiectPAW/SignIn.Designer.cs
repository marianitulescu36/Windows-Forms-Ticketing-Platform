namespace ProiectPAW
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblBuna = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.tbPrenume);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.tbNume);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.tbPassword);
            this.panel.Controls.Add(this.lblPassword);
            this.panel.Controls.Add(this.tbUsername);
            this.panel.Controls.Add(this.lblUsername);
            this.panel.Controls.Add(this.lblBuna);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(608, 358);
            this.panel.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(12, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 51);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(373, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 51);
            this.button1.TabIndex = 24;
            this.button1.Text = "Inregistreaza-te!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrenume.Location = new System.Drawing.Point(203, 134);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(300, 30);
            this.tbPrenume.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNume.Location = new System.Drawing.Point(203, 82);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(300, 30);
            this.tbNume.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nume";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(204, 238);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(300, 30);
            this.tbPassword.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(93, 238);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 25);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Parola";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUsername.Location = new System.Drawing.Point(204, 186);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(300, 30);
            this.tbUsername.TabIndex = 17;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(93, 186);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // lblBuna
            // 
            this.lblBuna.AutoSize = true;
            this.lblBuna.BackColor = System.Drawing.Color.Transparent;
            this.lblBuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuna.Location = new System.Drawing.Point(216, 23);
            this.lblBuna.Name = "lblBuna";
            this.lblBuna.Size = new System.Drawing.Size(149, 29);
            this.lblBuna.TabIndex = 15;
            this.lblBuna.Text = "Bine ai venit!";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 358);
            this.Controls.Add(this.panel);
            this.Name = "SignIn";
            this.Text = "Inregistrare";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblBuna;
        private System.Windows.Forms.Button btnBack;
    }
}