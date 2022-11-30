using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ATM_Project
{
    internal class DBConnect
    {
        public static void Main(string[] args)
        {

            string server = "localhost";
            string database = "localhost";
            string username = "root";
            string password = "";
            string Constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                                "USERID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(Constring);
            conn.Open();
            string query = "select * from Accounts";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["AccountID"]);
                Console.WriteLine(reader["Pin"]);


            }
        }
        public DataSet getBalance(DataSet dataset, string connection, string query)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, conn);
            adapter.Fill(dataset);
            return dataset;
        }


    }
}
