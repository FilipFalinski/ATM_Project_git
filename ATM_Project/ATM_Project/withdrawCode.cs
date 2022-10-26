using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ATM_Project
{
    internal class withdrawCode
    {
        private int withdrawAmount;
        private int balance;

        public withdrawCode(int withdrawAmount, int balance)
        {
            this.withdrawAmount = withdrawAmount;
            this.balance = balance;
        }

        public int getWithdrawAmount()
        {
            return withdrawAmount;
        }

        public int getBalance()
        {
            return balance;
        }

        public void setWithdrawAmount(int withdrawAmount)
        {
            this.withdrawAmount = withdrawAmount;
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public void withdraw(int amount)
        {
            balance -= amount;
        }
    }

    /*   internal static DataSet getBalance()
       {
           string query = "SELECT i.NAME, c.description as CATEGORY, i.PRICE, i.QUANTITY  AS IN_STOCK, NVL(sum(l.QUANTITY), 0) AS SOLD, i.IS_REMOVED FROM products i left JOIN ORDERLINE l ON i.prodid = l.prodid inner join CATEGORIES C on i.catcode=c.catcode GROUP BY i.NAME, c.description, i.PRICE, i.quantity, i.IS_REMOVED  ORDER BY 1,2";
           return DB.getDataSet(query);
       }*/

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



