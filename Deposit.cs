using ATMProject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class Deposit : Form
    {


        frmDashBoard parent;
        public Deposit(ATMProject.frmDashBoard frmDashBoard)
        {
            InitializeComponent();
            parent = (frmDashBoard)Parent;
        }

        string connectionString = "host=localhost;user=root;password=Gearsofwar2;database=ATM;";
        int balance = 0;
        private object ten_total;
        private object fiveHun_total;
        private object twoHun_total;
        private object hundred_total;
        private string fifty_total;
        private string twenty_total;
        private object txtPin;

        public Deposit(Account_Managment account_Managment)
        {
        }

        public Deposit()
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ten_txt_TextChanged(object sender, EventArgs e)
        {

            int ten = 0;
            if (ten_txt.Text != "")
            {
                ten = Convert.ToInt32(ten_txt.Text);
            }
            int total = ten * 10;
            ten_total = total.ToString();


        }

        private void twenty_txt_TextChanged(object sender, EventArgs e)
        {
            int twenty = 0;
            if (twenty_txt.Text != "")
            {
                twenty = Convert.ToInt32(twenty_txt.Text);
            }
            int total = twenty * 20;
            twenty_total = total.ToString();
        }

        private void fifty_txt_TextChanged(object sender, EventArgs e)
        {
            int fifty = 0;
            if (fifty_txt.Text != "")
            {
                fifty = Convert.ToInt32(fifty_txt.Text);
            }
            int total = fifty * 50;
            fifty_total = total.ToString();



        }

        private void hundred_txt_TextChanged(object sender, EventArgs e)
        {
            int hundred = 0;
            if (hundred_txt.Text != "")
            {
                hundred = Convert.ToInt32(hundred_txt.Text);
            }
            int total = hundred * 100;
            hundred_total = total.ToString();

        }

        private void twoHun_txt_TextChanged(object sender, EventArgs e)
        {
            int twoHun = 0;
            if (twoHun_txt.Text != "")
            {
                twoHun = Convert.ToInt32(twoHun_txt.Text);
            }
            int total = twoHun * 200;
            twoHun_total = total.ToString();
        }

        private void fiveHun_txt_TextChanged(object sender, EventArgs e)
        {
            int fiveHun = 0;
            if (fiveHun_txt.Text != "")
            {
                fiveHun = Convert.ToInt32(fiveHun_txt.Text);
            }
            int total = fiveHun * 500;
            fiveHun_total = total.ToString();
        }

        private void total_txt_TextChanged(object sender, EventArgs e)
        {


        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {

            int total = Convert.ToInt32(ten_total) + Convert.ToInt32(twenty_total) + Convert.ToInt32(fifty_total) + Convert.ToInt32(hundred_total) + Convert.ToInt32(twoHun_total) + Convert.ToInt32(fiveHun_total);
            total_txt.Text = total.ToString();
            balance = balance + total;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE Accounts SET Balance = '" + balance + "' WHERE Pin = '" + txtPin + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your new balance is: " + balance);

        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //return to dashboard
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show();
            

        }

        
    }
}

