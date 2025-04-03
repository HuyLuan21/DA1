using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Staff_BLL
    {

        private Staff_DAL staffDAL = new Staff_DAL();

        public DataTable GetNhanVienList()
        {
            return staffDAL.GetAllStaff(); // Lấy dữ liệu từ DAL
        }
    }
}
