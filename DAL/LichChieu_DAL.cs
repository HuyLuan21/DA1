using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class LichChieu_DAL
    {
        private static LichChieu_DAL instance;
        public static LichChieu_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichChieu_DAL();
                return instance;
            }
        }
        private LichChieu_DAL() { }
        public DataTable GetThoigian()
        {
            string query = "SELECT  ThoiGianChieu AS \"Thời gian chiếu\" FROM LichChieuPhim";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
