using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DAO
{
    public class Connection
    {
        private string ConnStr;
        private SqlCommand cmd;
        private SqlConnection conn;
        public Connection()
        {
            ConnStr = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=ministore_csharp;User ID=duy;Password=1";
            conn = new SqlConnection(ConnStr);
        }
        public int executeNonQuery(string sqlStr)
        {
            conn.Open();
            cmd = new SqlCommand(sqlStr, conn);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows;
        }
        public DataTable executeQuery(string sqlStr)
        {
            conn.Open();
            DataAdapter da = new SqlDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }
    }
}
