using ATMProject;
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

namespace ATM_Project
{
    
    public partial class Withdraw :  Form 
    {
        frmDashBoard parent;
      
        private int balance;
        private Account_Managment account_Managment;

        public Withdraw(ATMProject.frmDashBoard frmDashBoard)
        {
            InitializeComponent();
            parent = (frmDashBoard)Parent;
        }

        public Withdraw(Account_Managment account_Managment)
        {
            this.account_Managment = account_Managment;
        }

        private int GetBalance()
        {
            return balance;
        }

        private void Twenty_btn_Click(object sender, EventArgs e)
        {
            balance = GetBalance();
            balance = balance - 20;
            
            
        }

        private void fifty_btn_Click(object sender, EventArgs e)
        {
            
            balance = GetBalance();
            balance = balance - 50;
            

        }

        private void hundred_btn_Click(object sender, EventArgs e)
        {
            balance = GetBalance();
            balance = balance - 100;
        }

        private void twoHundred_btn_Click(object sender, EventArgs e)
        {
            balance = GetBalance();
            balance = balance - 200;

        }

        private void fiveHundred_btn_Click(object sender, EventArgs e)
        {
            balance = GetBalance();
            balance = balance - 500;

        }

        private void grnad_btn_Click(object sender, EventArgs e)
        {
           
            balance = GetBalance();
            balance = balance - 1000;

        }

        private void Amount_txt_TextChanged(object sender, EventArgs e)
        {
            


        }
        
        private void Confirm_btn_Click(object sender, EventArgs e)
        {

            
            string connectionString = "host=localhost;user=root;password=Gearsofwar2;database=ATM;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE accounts SET Balance = @balance WHERE AccountID = @AccountID";
            command.Parameters.AddWithValue("@balance", balance);
            command.Parameters.AddWithValue("@AccountID", 1);
            command.ExecuteNonQuery();
            connection.Close();
            
            MessageBox.Show("Your new balance is: " + balance);
            
            MessageBox.Show("Withdrawl Confirmed");
            
           
            
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show();


            this.Close();
            


        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

            
        }
    }
}
