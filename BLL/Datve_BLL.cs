using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Datve_BLL
    {
        private static Datve_BLL instance;
        public static Datve_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Datve_BLL();
                return instance;
            }
        }
            private Datve_BLL() { }
        public DataTable GetDanhSachGhe(int maCaChieu)
        {
            return Datve_DAL.Instance.GetDanhSachGhe(maCaChieu);
        }

        public bool DatVe(int maCaChieu, int maGheNgoi)
        {
            return Datve_DAL.Instance.DatVe(maCaChieu, maGheNgoi);
        }

        
    }
}
