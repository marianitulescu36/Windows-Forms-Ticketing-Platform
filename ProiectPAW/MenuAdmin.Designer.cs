namespace ProiectPAW
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblBunVenit = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.btnLogout);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.btnCharts);
            this.panel.Controls.Add(this.btnEdit);
            this.panel.Controls.Add(this.lblBunVenit);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(428, 558);
            this.panel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.Location = new System.Drawing.Point(112, 386);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 56);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(112, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Drag and Drop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = System.Drawing.SystemColors.Info;
            this.btnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCharts.Location = new System.Drawing.Point(112, 208);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(217, 56);
            this.btnCharts.TabIndex = 5;
            this.btnCharts.Text = "Vizualizare statistici";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(112, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(217, 56);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editeaza oferte";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblBunVenit
            // 
            this.lblBunVenit.BackColor = System.Drawing.Color.Transparent;
            this.lblBunVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBunVenit.Location = new System.Drawing.Point(31, 27);
            this.lblBunVenit.Name = "lblBunVenit";
            this.lblBunVenit.Size = new System.Drawing.Size(385, 56);
            this.lblBunVenit.TabIndex = 3;
            this.lblBunVenit.Text = "Bine ai revenit, admin!";
            this.lblBunVenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 558);
            this.Controls.Add(this.panel);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblBunVenit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLogout;
    }
}