
namespace MIKULAS_210111
{
    partial class FrmOsztaly
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
            this.label1 = new System.Windows.Forms.Label();
            this.btntallozas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhozzad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.32F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osztálynévsor tallózása:";
            // 
            // btntallozas
            // 
            this.btntallozas.AllowDrop = true;
            this.btntallozas.BackColor = System.Drawing.Color.White;
            this.btntallozas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btntallozas.FlatAppearance.BorderSize = 2;
            this.btntallozas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntallozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btntallozas.Location = new System.Drawing.Point(458, 83);
            this.btntallozas.Name = "btntallozas";
            this.btntallozas.Size = new System.Drawing.Size(170, 38);
            this.btntallozas.TabIndex = 1;
            this.btntallozas.Text = "Tallózás";
            this.btntallozas.UseVisualStyleBackColor = false;
            this.btntallozas.Click += new System.EventHandler(this.btntalloz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.32F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Írja be az osztályjelzést:";
            // 
            // btnhozzad
            // 
            this.btnhozzad.BackColor = System.Drawing.Color.White;
            this.btnhozzad.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnhozzad.FlatAppearance.BorderSize = 2;
            this.btnhozzad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhozzad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnhozzad.Location = new System.Drawing.Point(33, 240);
            this.btnhozzad.Name = "btnhozzad";
            this.btnhozzad.Size = new System.Drawing.Size(595, 38);
            this.btnhozzad.TabIndex = 3;
            this.btnhozzad.Text = "Hozzáadás az adatbázishoz";
            this.btnhozzad.UseVisualStyleBackColor = false;
            this.btnhozzad.Click += new System.EventHandler(this.btnhozzad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(666, 294);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnhozzad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntallozas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOsztaly";
            this.Text = "FrmOsztaly";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmOsztaly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntallozas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhozzad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}