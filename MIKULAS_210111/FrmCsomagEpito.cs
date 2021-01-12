using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIKULAS_210111
{
    public partial class FrmCsomagEpito : Form
    {
        public FrmCsomagEpito(string constring)
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private void FrmCsomagEpito_Load(object sender, EventArgs e)
        {
            //dtv1_CellContentClick();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM belevalok");
            connection.Close();
        }


        private void dtv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtv1.Rows.Clear();
            connection.Open();
            var r = new SqlCommand("SELECT * FROM turazo;", connection);
                
            
            connection.Close();
        }
    }
}
