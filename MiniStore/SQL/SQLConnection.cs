using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniStore.SQL
{
    internal class SQLConnection
    {
        private string strCon = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=MiniStore;User ID=duy;Password=1";
        private SqlConnection conn = null;

        public SQLConnection()
        {
            conn = new SqlConnection(strCon);
        }
        
        

        public void openConn()
        {
            conn.Open();
        }
        public void closeConn()
        {
            conn.Close();
        }
    }
}
