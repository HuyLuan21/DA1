using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang_DAL
    {
        private static KhachHang_DAL instance;
        public static KhachHang_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHang_DAL();
                return instance;
            }
        }
        private KhachHang_DAL() { }

        public DataTable GetCustomer()
        {
            string query = @"SELECT MaKhachHang AS ""Mã KH"",
                                  HoTen AS ""Họ tên"",
                                  NamSinh AS ""Năm sinh"",
                                  SoDienThoai AS ""Số điện thoại"",
                                  DiemTichLuy AS ""Điểm tích lũy"",
                                  CCCD 
                           FROM KhachHang 
                           WHERE TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertCustomer(string hoTen, int namSinh, string soDienThoai, string cccd, int diemTichLuy)
        {
           

            string query = $@"INSERT INTO KhachHang (HoTen, NamSinh, SoDienThoai, CCCD, DiemTichLuy, TrangThai)
                             VALUES (N'{hoTen}', 
                                    {namSinh}, 
                                    '{soDienThoai}', 
                                    '{cccd}',
                                    {diemTichLuy},
                                    1)";
            int rowAffected = DataProvider.Instance.ExecuteNonQuery(query);

            return rowAffected;
        }

        public int UpdateCustomer(int maKH, string hoTen, int namSinh, string soDienThoai, string cccd, int diemTichLuy)
        {
            string query = $@"UPDATE KhachHang
                         SET HoTen = N'{hoTen}', 
                             NamSinh = {namSinh},
                             SoDienThoai = '{soDienThoai}',
                             CCCD = '{cccd}',
                             DiemTichLuy = {diemTichLuy}
                         WHERE MaKhachHang = {maKH}";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int SoftDeleteCustomer(int maKH)
        {
            string query = $"UPDATE KhachHang SET TrangThai = 0 WHERE MaKhachHang = {maKH}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable SearchCustomer(string searchValue)
        {
            string query = $@"SELECT MaKhachHang AS ""Mã KH"",
                                  HoTen AS ""Họ tên"",
                                  NamSinh AS ""Năm sinh"",
                                  SoDienThoai AS ""Số điện thoại"",
                                  DiemTichLuy AS ""Điểm tích lũy"",
                                  CCCD
                           FROM KhachHang 
                           WHERE TrangThai = 1 
                           AND (
                               CAST(MaKhachHang AS NVARCHAR) LIKE N'%{searchValue}%'
                               OR HoTen LIKE N'%{searchValue}%'
                               OR CAST(NamSinh AS NVARCHAR) LIKE N'%{searchValue}%'
                               OR SoDienThoai LIKE N'%{searchValue}%'
                               OR CCCD LIKE N'%{searchValue}%'
                               OR CAST(DiemTichLuy AS NVARCHAR) LIKE N'%{searchValue}%'
                           )";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> GetAllPhoneNumbers()
        {
            string query = "SELECT SoDienThoai FROM KhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> phoneNumbers = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                phoneNumbers.Add(row["SoDienThoai"].ToString());
            }
            return phoneNumbers;
        }

        public List<string> GetAllCCCDs()
        {
            string query = "SELECT CCCD FROM KhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> ccNumbers = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                ccNumbers.Add(row["CCCD"].ToString());
            }
            return ccNumbers;
        }
    }
}
