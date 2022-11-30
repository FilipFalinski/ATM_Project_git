using ATM_Project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class frmCheckBalance : Form
    {
        frmDashBoard parent;
        double balance;
        private Account_Managment account_Managment;

        public frmCheckBalance(frmDashBoard Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmCheckBalance(Account_Managment account_Managment)
        {
            this.account_Managment = account_Managment;
        }

        private void frmCheckBalance_Load(object sender, EventArgs e)
        {

        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {



            string sql = " SELECT * FROM Accounts";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=Gearsofwar2;database=ATM;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            
             
            MySqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                textBox1.Text = reader.GetString("Balance");
                  
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
