using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DAO
{
    public static class InputDetailDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllInputDetail()
        {
            return conn.executeQuery("select inputid, productid, quanity, price from inputdetail");
        }
        public static int addDetail(InputDetailDTO input, string ID)
        {
            return conn.executeNonQuery("insert into input (inputid, productid, quanity, price, available) " +
                $"values ('{ID}', '{input.Productid}', '{input.Quantity}', '{input.Price}', 1)");
        }
        public static int addDetail(InputDetailDTO input)
        {
            return conn.executeNonQuery("insert into input (inputid, productid, quanity, price, available) " +
                $"values ('{input.Inputid}', '{input.Productid}', '{input.Quantity}', '{input.Price}', 1)");
        }

        //public static int updateDetail(InputDetailDTO input)
        //{
        //    return conn.executeNonQuery("insert into input (inputid, productid, quanity, price, available) " +
        //        $"values ('{input.Inputid}', '{input.Productid}', '{input.Quantity}', '{input.Price}', 1)");
        //}
    }
}
