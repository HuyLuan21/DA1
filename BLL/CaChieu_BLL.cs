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
        public int InsertCaChieu(int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            return CaChieu_DAL.Instance.InsertCaChieu( maPhim, maPhongChieu, thoiGianChieu, thoiGianKetThuc, giaVe);
        }
        public bool Checkinsert(string tenphong, string thoiGianChieu, string thoiGianKetThuc)
        {
            int maphong = PhongChieu_BLL.Instance.GetMaPhongByTen(tenphong);
            DateTime dtChieuMoi, dtKetThucMoi;
            if (!DateTime.TryParse(thoiGianChieu, out dtChieuMoi) || !DateTime.TryParse(thoiGianKetThuc, out dtKetThucMoi))
            {
                // Lỗi định dạng thời gian
                return false;
            }
            // Không cho phép bắt đầu sau 23h
            if (dtChieuMoi.Hour >= 23)
                return false;
            var table = CaChieu_DAL.Instance.GetCaChieuTable();
            foreach (System.Data.DataRow row in table.Rows)
            {
                int maPhong = PhongChieu_BLL.Instance.GetMaPhongByTen(row["Phòng chiếu"].ToString());
                if (maPhong != maphong) continue;
                DateTime start = DateTime.Parse(row["Thời gian chiếu"].ToString());
                DateTime end = DateTime.Parse(row["Thời gian kết thúc"].ToString());
                // Nếu thời gian chiếu mới overlap hoặc sát với ca cũ (< 30 phút) thì không hợp lệ
                if (!(dtChieuMoi >= end.AddMinutes(30) || dtKetThucMoi <= start.AddMinutes(-30)))
                {
                    return false;
                }
            }
            return true;
        }
        public int UpdateCaChieu(int maCaChieu, int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            return CaChieu_DAL.Instance.UpdateCaChieu(maCaChieu, maPhim, maPhongChieu, thoiGianChieu, thoiGianKetThuc, giaVe);
        }
        public int DeleteCaChieu(int maCaChieu)
        {
            return CaChieu_DAL.Instance.DeleteCaChieu(maCaChieu);
        }
        
    }
}
