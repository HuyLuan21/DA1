using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CaChieu_DAL
    {
        private static CaChieu_DAL instance;
        public static CaChieu_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaChieu_DAL();
                return instance;
            }
        }
        private CaChieu_DAL() { }
        public DataTable GetCaChieu()
        {
            string query = "SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p on cc.MaPhim = p.MaPhim";
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable GetCaChieuByMovie(string movieName)
        {
            string query = $"SELECT MaCaChieu,p.TenPhim,ThoiGianChieu,MaPhongChieu FROM CaChieu cc JOIN Phim p on cc.MaPhim = p.MaPhim WHERE p.TenPhim = '{movieName}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
