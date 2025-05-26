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
        public DataTable GetTable()
        {
            string query = @"SELECT MaHoaDon AS ""Mã hóa đơn"",NgayBan AS ""Ngày bán"",TongTien AS ""Tổng tiền"",MaNhanVien AS ""Mã nhân viên"",MaKhachHang AS ""Mã khách hàng"" FROM HoaDon";
            return DataProvider.Instance.ExecuteQuery(query);

        }
       

        public DataTable GetChiTietHoaDon(int maHoaDon)
        {
            string query = $@"SELECT 
    ROW_NUMBER() OVER (ORDER BY cc.ThoiGianChieu) AS ""STT"",
    p.TenPhim AS ""Tên phim"",
    pc.TenPhong AS ""Phòng"",
    CONVERT(VARCHAR(5), cc.ThoiGianChieu, 108) AS ""Ca"",
    g.HangGhe + CAST(g.SoGhe AS VARCHAR) AS ""Ghế"",
    cc.GiaVe AS ""Giá""
FROM ChiTietHoaDon cthd
INNER JOIN HoaDon h ON cthd.MaHoaDon = h.MaHoaDon
INNER JOIN Ve v ON cthd.MaVe = v.MaVe
INNER JOIN CaChieu cc ON v.MaCaChieu = cc.MaCaChieu
INNER JOIN Phim p ON cc.MaPhim = p.MaPhim
INNER JOIN PhongChieu pc ON cc.MaPhongChieu = pc.MaPhongChieu
INNER JOIN GheNgoi g ON v.MaGheNgoi = g.MaGheNgoi
WHERE h.MaHoaDon = {maHoaDon} 
ORDER BY cc.ThoiGianChieu;";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTenNhanVienVaKhachHang(int maNhanVien, int maKhachHang)
        {
            string query = $@"
                SELECT 
                    (SELECT HoTen FROM NhanVien WHERE MaNhanVien = {maNhanVien}) AS TenNhanVien,
                    (SELECT HoTen FROM KhachHang WHERE MaKhachHang = {maKhachHang}) AS TenKhachHang
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetHoaDonChartData(int maHoaDon)
        {
            string query = $"EXEC sp_GetOrderChartData @MaHoaDon = {maHoaDon}";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving chart data: " + ex.Message);
            }
        }
    }
}