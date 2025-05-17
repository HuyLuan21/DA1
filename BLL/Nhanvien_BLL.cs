using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class Nhanvien_BLL
    {
        private static Nhanvien_BLL instance;
        public static Nhanvien_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Nhanvien_BLL();
                return instance;
            }
        }
        private Nhanvien_BLL() { }

        public DataTable GetStaff()
        {
            return NhanVien_DAL.Instance.GetStaff();
        }

        public (string message, DataTable data) SearchStaff(string searchValue)
        {
            try
            {
                // Kiểm tra chuỗi tìm kiếm
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    return ("Vui lòng nhập thông tin tìm kiếm!", GetStaff());
                }

                // Chuẩn hóa chuỗi tìm kiếm
                searchValue = searchValue.Trim();
                
                // Kiểm tra nếu tìm theo ngày
                DateTime searchDate;
                if (DateTime.TryParse(searchValue, out searchDate))
                {
                    // Nếu là ngày hợp lệ, định dạng lại theo dd/MM/yyyy
                    searchValue = searchDate.ToString("dd/MM/yyyy");
                }

                DataTable result = NhanVien_DAL.Instance.SearchStaff(searchValue);
                if (result.Rows.Count == 0)
                {
                    return ("Không tìm thấy nhân viên nào!", GetStaff());
                }
                return (string.Empty, result); // string.Empty nghĩa là không có lỗi
            }
            catch (Exception ex)
            {
                return ($"Lỗi tìm kiếm: {ex.Message}", GetStaff());
            }
        }

        public string InsertStaff(string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string cccd)
        {
            try
            {
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || 
                    string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(cccd))
                    return "Vui lòng nhập đầy đủ thông tin!";

                // Kiểm tra số điện thoại đã tồn tại
                var existingPhones = GetAllPhoneNumbers();
                if (existingPhones.Contains(soDienThoai))
                {
                    return "Số điện thoại này đã được đăng ký cho nhân viên khác!";
                }

                // Kiểm tra CCCD đã tồn tại
                var existingCCCDs = GetAllCCCDs();
                if (existingCCCDs.Contains(cccd))
                {
                    return "Số CCCD này đã được đăng ký cho nhân viên khác!";
                }

                int newId = NhanVien_DAL.Instance.InsertStaff(hoTen, ngaySinh, diaChi, soDienThoai, cccd);
                return newId > 0 ? "Success" : "Thêm nhân viên thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string UpdateStaff(int maNV, string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string cccd)
        {
            try
            {
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || 
                    string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(cccd))
                    return "Vui lòng nhập đầy đủ thông tin!";

                // Lấy danh sách số điện thoại và CCCD hiện có (trừ nhân viên đang cập nhật)
                var currentPhones = GetAllPhoneNumbers();
                var currentCCCDs = GetAllCCCDs();
                
                // Kiểm tra số điện thoại trùng (ngoại trừ của chính nhân viên này)
                DataTable staffData = GetStaff();
                string currentPhone = staffData.AsEnumerable()
                    .Where(row => Convert.ToInt32(row["Mã nhân viên"]) == maNV)
                    .Select(row => row["Số điện thoại"].ToString())
                    .FirstOrDefault();

                if (currentPhone != soDienThoai && currentPhones.Contains(soDienThoai))
                {
                    return "Số điện thoại này đã được đăng ký cho nhân viên khác!";
                }

                // Kiểm tra CCCD trùng (ngoại trừ của chính nhân viên này)
                string currentCCCD = staffData.AsEnumerable()
                    .Where(row => Convert.ToInt32(row["Mã nhân viên"]) == maNV)
                    .Select(row => row["CCCD"].ToString())
                    .FirstOrDefault();

                if (currentCCCD != cccd && currentCCCDs.Contains(cccd))
                {
                    return "Số CCCD này đã được đăng ký cho nhân viên khác!";
                }

                int result = NhanVien_DAL.Instance.UpdateStaff(maNV, hoTen, ngaySinh, diaChi, soDienThoai, cccd);
                return result > 0 ? "Success" : "Cập nhật thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string DeleteStaff(int maNV)
        {
            try
            {
                // Thay đổi từ xóa hoàn toàn sang soft delete
                int result = NhanVien_DAL.Instance.SoftDeleteStaff(maNV);
                return result > 0 ? "Success" : "Cập nhật trạng thái nhân viên thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public List<string> GetAllPhoneNumbers()
        {
            return NhanVien_DAL.Instance.GetAllPhoneNumbers();
        }

        public List<string> GetAllCCCDs()
        {
            return NhanVien_DAL.Instance.GetAllCCCDs();
        }
    }
}
