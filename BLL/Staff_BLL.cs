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
        private static Staff_BLL instance;
        public static Staff_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Staff_BLL();
                }
                return instance;
            }
        }
       private Staff_BLL() { }
        public DataTable GetStaff()
        {
            return Staff_DAL.Instance.GetStaff();
        }
    }
}
