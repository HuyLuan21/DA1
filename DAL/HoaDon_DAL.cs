using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_DAL
    {
        private static HoaDon_DAL instance;
        public static HoaDon_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDon_DAL();
                return instance;
            }
        }
        private HoaDon_DAL() { }

        public int InsertHoaDon(int maKhachHang, int maNhanVien, decimal tongTien)
        {
            string query = $@"INSERT INTO HoaDon (MaKhachHang, MaNhanVien, TongTien, NgayBan)
                             VALUES ({maKhachHang}, {maNhanVien}, {tongTien}, GETDATE());
                             SELECT SCOPE_IDENTITY();";

            object result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public bool InsertChiTietHoaDon(int maHoaDon, int maVe, decimal donGia)
        {
            string query = $@"INSERT INTO ChiTietHoaDon (MaHoaDon, MaVe)
                             VALUES ({maHoaDon}, {maVe})";

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public DataTable GetHoaDonByMaKH(int maKhachHang)
        {
            string query = $@"SELECT h.MaHoaDon, h.NgayBan, h.TongTien,
                                    nv.HoTen as TenNhanVien,
                                    cthd.MaVe
                             FROM HoaDon h
                             INNER JOIN ChiTietHoaDon cthd ON h.MaHoaDon = cthd.MaHoaDon
                             INNER JOIN NhanVien nv ON h.MaNhanVien = nv.MaNhanVien
                             WHERE h.MaKhachHang = {maKhachHang}
                             ORDER BY h.NgayBan DESC";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}