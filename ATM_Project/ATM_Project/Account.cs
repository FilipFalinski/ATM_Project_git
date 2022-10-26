using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ATM_Project
{
    internal class Account
    {
        private int pin;
        private int balance;
        private int accID;

        public Account(int pin, int balance, int accID)
        {
            this.pin = pin;
            this.balance = balance;
            this.accID = accID;
        }

        public int getPin()
        {
            return pin;
        }

        public int getBalance()
        {
            return balance;
        }

        public int getAccID()
        {
            return accID;
        }


        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public void setPin(int pin)
        {
            this.pin = pin;
        }

        public void setAccID(int accID)
        {
            this.accID = accID;
        }

        public void lodge(int amount)
        {
            balance += amount;
        }

        public void withdraw(int amount)
        {
            balance -= amount;
        }

        public bool checkPin(int pin)
        {
            if (this.pin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
        

       /* private static DataSet getDataSet(String query)
        {
            OracleConnection con = DB.getConnection();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            var da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();
            return ds;
        }
       */


    }
}
