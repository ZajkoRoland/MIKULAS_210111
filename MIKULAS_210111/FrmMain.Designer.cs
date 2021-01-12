
namespace MIKULAS_210111
{
    partial class FrmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnosztalybetolt = new System.Windows.Forms.Button();
            this.btnsorsolas = new System.Windows.Forms.Button();
            this.btncsomagepit = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::MIKULAS_210111.Properties.Resources.csomag_BG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnosztalybetolt
            // 
            this.btnosztalybetolt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnosztalybetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.32F);
            this.btnosztalybetolt.Location = new System.Drawing.Point(282, 3);
            this.btnosztalybetolt.Name = "btnosztalybetolt";
            this.btnosztalybetolt.Size = new System.Drawing.Size(499, 97);
            this.btnosztalybetolt.TabIndex = 1;
            this.btnosztalybetolt.Text = "osztály betöltése";
            this.btnosztalybetolt.UseVisualStyleBackColor = false;
            this.btnosztalybetolt.Click += new System.EventHandler(this.btnosztalybetolt_Click);
            // 
            // btnsorsolas
            // 
            this.btnsorsolas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsorsolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.32F);
            this.btnsorsolas.Location = new System.Drawing.Point(282, 115);
            this.btnsorsolas.Name = "btnsorsolas";
            this.btnsorsolas.Size = new System.Drawing.Size(499, 97);
            this.btnsorsolas.TabIndex = 2;
            this.btnsorsolas.Text = "sorsolás";
            this.btnsorsolas.UseVisualStyleBackColor = false;
            this.btnsorsolas.Click += new System.EventHandler(this.btnsorsolas_Click);
            // 
            // btncsomagepit
            // 
            this.btncsomagepit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncsomagepit.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.32F);
            this.btncsomagepit.Location = new System.Drawing.Point(282, 232);
            this.btncsomagepit.Name = "btncsomagepit";
            this.btncsomagepit.Size = new System.Drawing.Size(499, 97);
            this.btncsomagepit.TabIndex = 3;
            this.btncsomagepit.Text = "csomagépítő";
            this.btncsomagepit.UseVisualStyleBackColor = false;
            this.btncsomagepit.Click += new System.EventHandler(this.btncsomagepit_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.32F);
            this.btnkilep.ForeColor = System.Drawing.Color.Green;
            this.btnkilep.Location = new System.Drawing.Point(282, 350);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(499, 97);
            this.btnkilep.TabIndex = 4;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = false;
            this.btnkilep.Click += new System.EventHandler(this.btnkilep_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btncsomagepit);
            this.Controls.Add(this.btnsorsolas);
            this.Controls.Add(this.btnosztalybetolt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnosztalybetolt;
        private System.Windows.Forms.Button btnsorsolas;
        private System.Windows.Forms.Button btncsomagepit;
        private System.Windows.Forms.Button btnkilep;
    }
}

