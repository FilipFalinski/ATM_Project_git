using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ATM_Project
{
    internal class Balance
    {
        private int balance;

        public Balance(int balance)
        {
            this.balance = balance;
        }

        public int getBalance()
        {
            return balance;
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }

     /*   public static List<Balance> LoadAll()
        {
            string query = "select Balacne as amount from Categories";

            DataSet ds = DB.getDataSet(query);

            //OracleDataAdapter da = db.getData(query);
            //var dt = new DataTable();
            //da.Fill(dt);

            var list = ds.Tables[0].AsEnumerable().Select(r => new Balance((string)r["amount"])).ToList();

            return list;
        }*/
        
    }
}
