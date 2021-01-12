using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIKULAS_210111
{
    public partial class FrmOsztaly : Form
    {
        public FrmOsztaly(string constring)
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        private void btntalloz_Click(object sender, EventArgs e)
        {
            // var ofd = new OpenFileDialog();
            //talloz1.Text = ofd.ShowDialog() == DialogResult.OK
            //         ? ofd.FileName
            //         : null;
        }

        private void btnhozzad_Click(object sender, EventArgs e)
        {

            //StreamReader sr = new StreamReader(talloz1.Text);
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("insert into emberek (nev, osztaly) VALUES(@nev, @osztaly)");
            //while (!sr.EndOfStream)
            //{

            //}
        }

        private void FrmOsztaly_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
        }
    }
}