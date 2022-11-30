
using _2019cafe;
using ATM_Project;
using System;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class frmDashBoard : Form
    {
        internal string accountId;
        private frmLogin frmLogin;
        internal object txtUser;

        public frmDashBoard()
        {
            InitializeComponent();
            
            
        }

        public frmDashBoard(frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckBalance nextForm = new frmCheckBalance(this);
            nextForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Managment nextForm = new Account_Managment();
            nextForm.Show();
        }

        private void bntWithdraw_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Withdraw nextForm = new Withdraw(this);
            nextForm.Show();
            
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit nextForm = new Deposit(this);
            nextForm.Show();
        }
    }
}
