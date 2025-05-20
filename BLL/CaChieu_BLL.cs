using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
  public class CaChieu_BLL
    {
        public static CaChieu_BLL instance;
        public static CaChieu_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaChieu_BLL();
                return instance;
            }
        }
        private CaChieu_BLL() { }
     
       public DataTable GetCaChieuList()
        {
            return CaChieu_DAL.Instance.GetCaChieu();
        }
        public DataTable GetCaChieuListByMovie(string movieName)
        {
            return CaChieu_DAL.Instance.GetCaChieuByMovie(movieName);
        }
        public DataTable GetCaChieuTable()
        {
            return CaChieu_DAL.Instance.GetCaChieuTable();
        }
    }
}
