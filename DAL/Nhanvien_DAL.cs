using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class NhanVien_DAL
    {
        private static NhanVien_DAL instance;
        public static NhanVien_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVien_DAL();
                return instance;
            }
        }
        private NhanVien_DAL() { }

        public DataTable GetStaff()
        {
            string query = @"SELECT MaNhanVien AS ""Mã nhân viên"",
                                  HoTen AS ""Họ tên"",
                                  NgaySinh AS""Ngày sinh"",
                                  DiaChi AS""Địa chỉ"",
                                  SoDienThoai AS""Số điện thoại"",
                                  CMND_CCCD AS ""CCCD"",
                                  CASE TrangThai 
                                    WHEN 1 THEN N'Đang làm việc'
                                    ELSE N'Đã nghỉ việc'
                                  END AS ""Trạng thái""
                           FROM NhanVien 
                           WHERE TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertStaff(string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string cccd)
        {
            string query = $@"INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD, TrangThai)
                             VALUES (N'{hoTen}', 
                                    '{ngaySinh:yyyy-MM-dd}', 
                                    N'{diaChi}', 
                                    '{soDienThoai}', 
                                    '{cccd}',
                                    1)";

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int UpdateStaff(int maNV, string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string cccd)
        {
            string query = $@"UPDATE NhanVien
                         SET HoTen = N'{hoTen}', 
                             NgaySinh = '{ngaySinh:yyyy-MM-dd}',
                             DiaChi = N'{diaChi}',
                             SoDienThoai = '{soDienThoai}',
                             CMND_CCCD = '{cccd}'
                         WHERE MaNhanVien = {maNV}";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int SoftDeleteStaff(int maNV)
        {
            // Thay vì xóa, chỉ cập nhật trạng thái
            string query = $"UPDATE NhanVien SET TrangThai = 0 WHERE MaNhanVien = {maNV}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable SearchStaff(string searchValue)
        {
            string query = $@"SELECT MaNhanVien AS ""Mã nhân viên"", 
                                  HoTen AS ""Họ tên"", 
                                  NgaySinh AS ""Ngày sinh"", 
                                  DiaChi AS ""Địa chỉ"", 
                                  SoDienThoai AS ""Số điện thoại"", 
                                  CMND_CCCD AS ""CCCD"",
                                  CASE TrangThai 
                                    WHEN 1 THEN N'Đang làm việc'
                                    ELSE N'Đã nghỉ việc'
                                  END AS ""Trạng thái""
                           FROM NhanVien 
                           WHERE TrangThai = 1 
                           AND (
                               CAST(MaNhanVien AS NVARCHAR) LIKE N'%{searchValue}%'
                               OR HoTen LIKE N'%{searchValue}%'
                               OR CONVERT(NVARCHAR, NgaySinh, 103) LIKE N'%{searchValue}%'
                               OR DiaChi LIKE N'%{searchValue}%'
                               OR SoDienThoai LIKE N'%{searchValue}%'
                               OR CMND_CCCD LIKE N'%{searchValue}%'
                           )";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> GetAllPhoneNumbers()
        {
            // Chỉ lấy số điện thoại của nhân viên đang làm việc
            string query = "SELECT SoDienThoai FROM NhanVien WHERE TrangThai = 1";
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
            // Chỉ lấy CCCD của nhân viên đang làm việc
            string query = "SELECT CMND_CCCD FROM NhanVien WHERE TrangThai = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> ccNumbers = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                ccNumbers.Add(row["CMND_CCCD"].ToString());
            }
            return ccNumbers;
        }
    }
}
