using DTO;
using System;
using System.Data;

namespace DAL
{
    public class Staff_DAL
    {
        private static Staff_DAL instance;
        public static Staff_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Staff_DAL();
                return instance;
            }
        }
        private Staff_DAL() { }

        public DataTable GetStaff()
        {
            string query = "SELECT MaNV AS \"Mã nhân viên\",HoTen AS \"Họ tên\",NgaySinh AS\"Ngày sinh\",DiaChi AS\"Địa chỉ\",SoDienThoai AS\"Số điện thoại\",CMND_CCCD AS \"CCCD\" FROM NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertStaff(Staff_DTO staff)
        {
            string query = $@"INSERT INTO NhanVien (HoTen, NgaySinh, DiaChi, SoDienThoai, CMND_CCCD)
                         VALUES (N'{staff.TenNV}', 
                                '{staff.NgaySinh.ToString("yyyy-MM-dd")}', 
                                N'{staff.DiaChi}', 
                                '{staff.SDT}', 
                                '{staff.CCCD}');
                         SELECT SCOPE_IDENTITY()";

            object result = DataProvider.Instance.ExecuteScalar(query);
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        public int UpdateStaff(Staff_DTO staff)
        {
            string query = $@"UPDATE NhanVien
                         SET HoTen = N'{staff.TenNV}', 
                             NgaySinh = '{staff.NgaySinh.ToString("yyyy-MM-dd")}',
                             DiaChi = N'{staff.DiaChi}',
                             SoDienThoai = '{staff.SDT}',
                             CMND_CCCD = '{staff.CCCD}'
                         WHERE MaNV = {staff.MaNV}";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int DeleteStaff(int manv)
        {
            // Kiểm tra xem khách hàng có vé không
            string checkQuery = $"SELECT COUNT(*) FROM Ve WHERE Manv = {manv}";
            int ticketCount = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(checkQuery));

            if (ticketCount > 0)
            {
                return -1; // Trả về -1 nếu khách hàng đã có vé
            }

            // Xóa 
            string query = $"DELETE FROM NhanVien WHERE MaNV = {manv}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable SearchStaff(string searchValue)
        {
            string query = $@"SELECT MaNV AS ""Mã nhân viên"", 
                                  HoTen AS ""Họ tên"", 
                                  NgaySinh AS ""Ngày sinh"", 
                                  DiaChi AS ""Địa chỉ"", 
                                  SoDienThoai AS ""Số điện thoại"", 
                                  CMND_CCCD AS ""CCCD""
                           FROM NhanVien 
                           WHERE HoTen LIKE N'%{searchValue}%' 
                           OR SoDienThoai LIKE '%{searchValue}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
