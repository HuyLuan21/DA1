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
            string query = "SELECT * FROM NhanVien";
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

        public int DeleteStaff(int maNV)
        {
            // Kiểm tra và xóa tài khoản trước (nếu có)
            string deleteAccountQuery = $"DELETE FROM TaiKhoan WHERE MaNV = {maNV}";
            DataProvider.Instance.ExecuteNonQuery(deleteAccountQuery);

            // Xóa nhân viên
            string query = $"DELETE FROM NhanVien WHERE MaNV = {maNV}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

       
    }
}
