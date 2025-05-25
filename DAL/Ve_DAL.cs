using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Ve_DAL
    {
        private static Ve_DAL instance;
        public static Ve_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Ve_DAL();
                return instance;
            }
        }
        private Ve_DAL() { }
        public DataTable GetVeByMaCaChieu(int maCaChieu)
        {
            string query = $@"SELECT v.MaVe, v.MaCaChieu, v.MaGheNgoi, h.MaKhachHang, h.TongTien as TienBanVe
                             FROM Ve v
                             LEFT JOIN ChiTietHoaDon cthd ON v.MaVe = cthd.MaVe
                             LEFT JOIN HoaDon h ON cthd.MaHoaDon = h.MaHoaDon
                             WHERE v.MaCaChieu = {maCaChieu}";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        
        
        
    }
}
