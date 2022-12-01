using MiniStore.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.BUS
{
    public static class ProviderBUS
    {
        public static DataTable getAllProvider()
        {
            return ProviderDAO.getAllProvider();
        }
        public static Collection<string> getProvidersCollection()
        {

            DataTable dt = getAllProvider();
            Collection<string> list = new Collection<string>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            return list;
        }
    }
}
