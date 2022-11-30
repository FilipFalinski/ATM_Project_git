using ATMProject;
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
        frmDashBoard parent;
        public Account_Managment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lodge_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit nextForm = new Deposit(this);
            nextForm.Show();
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckBalance nextForm = new frmCheckBalance(this);
            nextForm.Show();
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw nextForm = new Withdraw(this);
            nextForm.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashBoard frmDashBoard = new frmDashBoard();
            frmDashBoard.Show();
        }

        internal object GetAccountID()
        {
            throw new NotImplementedException();
        }
    }
}
