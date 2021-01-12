
namespace MIKULAS_210111
{
    partial class FrmSorsolas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtv1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.a_ID1 = new System.Windows.Forms.Label();
            this.a_ID2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "válaszd ki az osztályt:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(241, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "véletlenszerű összepárosítás";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtv1
            // 
            this.dtv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv1.Location = new System.Drawing.Point(30, 115);
            this.dtv1.Name = "dtv1";
            this.dtv1.ReadOnly = true;
            this.dtv1.Size = new System.Drawing.Size(565, 249);
            this.dtv1.TabIndex = 3;
            this.dtv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 412);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(121, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "csere";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(321, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Véglegesítés!";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // a_ID1
            // 
            this.a_ID1.AutoSize = true;
            this.a_ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a_ID1.ForeColor = System.Drawing.SystemColors.Control;
            this.a_ID1.Location = new System.Drawing.Point(33, 392);
            this.a_ID1.Name = "a_ID1";
            this.a_ID1.Size = new System.Drawing.Size(41, 13);
            this.a_ID1.TabIndex = 8;
            this.a_ID1.Text = "a_ID1";
            // 
            // a_ID2
            // 
            this.a_ID2.AutoSize = true;
            this.a_ID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a_ID2.ForeColor = System.Drawing.SystemColors.Control;
            this.a_ID2.Location = new System.Drawing.Point(202, 392);
            this.a_ID2.Name = "a_ID2";
            this.a_ID2.Size = new System.Drawing.Size(41, 13);
            this.a_ID2.TabIndex = 9;
            this.a_ID2.Text = "a_ID2";
            // 
            // FrmSorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.a_ID2);
            this.Controls.Add(this.a_ID1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSorsolas";
            this.Text = "FrmSorsolas";
            this.Load += new System.EventHandler(this.FrmSorsolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtv1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label a_ID1;
        private System.Windows.Forms.Label a_ID2;
    }
}