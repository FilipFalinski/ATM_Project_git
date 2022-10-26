using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class Account_Managment : Form
    {
        public Account_Managment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lodge_btn_Click(object sender, EventArgs e)
        {
            new Deposit().Show();
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
           // new Balance().Show();
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            new Withdraw().Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
           // new Login().Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
