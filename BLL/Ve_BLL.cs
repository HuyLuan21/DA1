using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class Ve_BLL
    {
        private static Ve_BLL instance;
        public static Ve_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Ve_BLL();
                return instance;
            }
        }
        private Ve_BLL() { }
        public DataTable GetVeByMaCaChieu(int maCaChieu)
        {
            return Ve_DAL.Instance.GetVeByMaCaChieu(maCaChieu);
        }
    }
}
