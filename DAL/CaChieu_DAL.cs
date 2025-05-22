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

        public DataTable GetCaChieuTable()
        {
            string query = "SELECT\r\n    cc.MaCaChieu AS \"Mã ca chiếu\",\r\n    p.MaPhim AS \"Mã Phim\",\r\n    p.TenPhim AS \"Tên Phim\",\r\n    pc.TenPhong AS \"Phòng chiếu\",\r\n    cc.ThoiGianChieu AS \"Thời gian chiếu\",\r\n    cc.ThoiGianKetThuc AS \"Thời gian kết thúc\",\r\n    cc.GiaVe AS \"Giá\"\r\nFROM\r\n    CaChieu cc\r\nJOIN\r\n    Phim p ON cc.MaPhim = p.MaPhim\r\nJOIN\r\n    PhongChieu pc ON cc.MaPhongChieu = pc.MaPhongChieu;";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertCaChieu(int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            string query = $"INSERT INTO CaChieu (MaPhim, MaPhongChieu, ThoiGianChieu, ThoiGianKetThuc, GiaVe) VALUES ('{maPhim}', '{maPhongChieu}', '{thoiGianChieu}', '{thoiGianKetThuc}', '{giaVe}')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateCaChieu(int maCaChieu, int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            string query = $"UPDATE CaChieu SET MaPhim = '{maPhim}', MaPhongChieu = '{maPhongChieu}', ThoiGianChieu = '{thoiGianChieu:yyyy-MM-dd HH:mm:ss}', ThoiGianKetThuc = '{thoiGianKetThuc:yyyy-MM-dd HH:mm:ss}', GiaVe = '{giaVe}' WHERE MaCaChieu = '{maCaChieu}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteCaChieu(int maCaChieu)
        {
            string query = $"DELETE FROM CaChieu WHERE MaCaChieu = '{maCaChieu}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
