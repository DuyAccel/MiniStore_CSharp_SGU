using MiniStore.DAO;
using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.BUS
{
    public static class InputDetailBUS
    {
        public static DataTable getAllInputDetail()
        {
            return InputDetailDAO.getAllInputDetail();
        }

        public static int addInputDetail(InputDetailDTO detail)
        {
            return InputDetailDAO.addDetail(detail);
        }
    }
}
