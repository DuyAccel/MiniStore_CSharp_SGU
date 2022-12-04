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
    public static class InputBUS
    {
        public static DataTable getAllInput()
        {
            return InputDAO.getAllInput();
        }
        public static bool addInput(InputDTO input, List<InputDetailDTO> details)
        {
            if (InputDAO.addInput(input) == 0) return false;
            string id = InputDAO.getLastedInput().Rows[0][0].ToString();
            foreach (InputDetailDTO detail in details)
            {
                if (InputDetailDAO.addDetail(detail, id) == 0) return false;
            }
            return true;
        }
        
    }
}
