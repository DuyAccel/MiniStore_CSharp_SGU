using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DAO
{
    public static class InputDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllInput()
        {
            return conn.executeQuery("select id, receiver, price, date from input");
        }
        public static int addInput(InputDTO input)
        {
            return conn.executeNonQuery("insert into input (receiver, price, date, available) " +
                $"values ('{input.Receiver}', '{input.Price}', '{input.Date.ToString("dd-MM-yyyy HH:mm:ss.fff")}', 1)");
        }
        public static DataTable getLastedInput()
        {
            return conn.executeQuery("select top 1 id, receiver, price, date from input");
        }
    }
}
