using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIKULAS_210111
{
    public partial class FrmMain : Form
    {
        static string constring = @"Server=(localdb)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\Resources\mikulas.mdf";
        public FrmMain()
        {
        
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void btnosztalybetolt_Click(object sender, EventArgs e)
        {
            FrmOsztaly frmOsztaly = new FrmOsztaly(constring);
            frmOsztaly.Show();
        }

        private void btnsorsolas_Click(object sender, EventArgs e)
        {
            FrmSorsolas frmSorsolas = new FrmSorsolas(constring);
            frmSorsolas.Show();
        }

        private void btncsomagepit_Click(object sender, EventArgs e)
        {
            FrmCsomagEpito frmCsomagEpito = new FrmCsomagEpito(constring);
            frmCsomagEpito.Show();
        }
        private void btnkilep_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés megerősítés",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        
    }

     
    }
}
