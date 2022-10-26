using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ATM_Project
{
  /*   class DB
    {
        public static OracleConnection getConnection()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            return conn;
        }

        public OracleDataAdapter getData(String query)
        {
            OracleConnection con = getConnection();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            return new OracleDataAdapter(cmd);
        }

        public static DataSet getDataSet(String query)
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

    }*/
}
