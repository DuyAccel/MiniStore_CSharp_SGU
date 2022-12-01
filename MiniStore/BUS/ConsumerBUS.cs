using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.DAO;
using MiniStore.DTO;

namespace MiniStore.BUS
{
    public static class ConsumerBUS
    {
        public static DataTable getAllConsumer()
        {
            return ConsumerDAO.getAllConsumer();
        }
        public static bool addConsumer(ConsumerDTO consumer)
        {
            return (ConsumerDAO.addConsumer(consumer) == 1);
        }
        public static bool removeConsumer(string PhoneNumer)
        {
            return (ConsumerDAO.removeConsumer(PhoneNumer) == 1);
        }
        public static DataTable seachAdvance(string column, string keywords)
        {
            return ConsumerDAO.searchAdvance(column, keywords);
        }
    }
}
