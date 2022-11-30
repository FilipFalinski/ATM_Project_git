using ATM_Project;
using ATMProject;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _2019cafe
{
    public partial class frmLogin : Form
    {

        private string accountId;

        public object txtAccountNumber { get; private set; }
        public string AccountID { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //login with account pin stored in mysql database

            string connectionString = "datasource= localhost; database=ATM;port=3306; username = root; password= Gearsofwar2";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Accounts WHERE  Pin = '" + txtUser.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                AccountID = reader["AccountID"].ToString();
                frmDashBoard nextForm = new frmDashBoard();
                nextForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Account Number or Pin");
            }





            /* MySqlConnection con = new MySqlConnection("datasource= localhost; database=ATM;port=3306; username = root; password= Gearsofwar2"); //open connection
             con.Open();
             MySqlCommand cmd = new MySqlCommand("select * from Accounts where Pin = '" + txtUser.Text + "'", con);
             MySqlDataReader reader = cmd.ExecuteReader();
             if (reader.Read())
             {

                 frmDashBoard nextForm = new frmDashBoard();
                 nextForm.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("incorrect pin!");
             }
             txtUser.Text = string.Empty;
             reader.Close();
             cmd.Dispose();
             con.Close(); */
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

