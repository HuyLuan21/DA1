using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class KhachHang_BLL
    {
        private static KhachHang_BLL instance;
        public static KhachHang_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHang_BLL();
                return instance;
            }
        }
        private KhachHang_BLL() { }

        public DataTable GetCustomer()
        {
            return KhachHang_DAL.Instance.GetCustomer();
        }
        public string ValidateInput(string soDienThoai, string cccd)
        {
            try
            {
                // Kiểm tra số điện thoại và CCCD có phải là số không
                if (!soDienThoai.All(char.IsDigit))
                {
                    return "Số điện thoại phải chỉ chứa các ký tự số!";
                }
                if (!cccd.All(char.IsDigit))
                {
                    return "CCCD phải chỉ chứa các ký tự số!";
                }

                // Kiểm tra số điện thoại trùng với khách hàng khác
                var phoneNumbers = GetAllPhoneNumbers();
                if (phoneNumbers.Contains(soDienThoai))
                {
                    return "Số điện thoại này đã được đăng ký cho khách hàng khác!";
                }

                // Kiểm tra CCCD trùng với khách hàng khác
                var ccNumbers = GetAllCCCDs();
                if (ccNumbers.Contains(cccd))
                {
                    return "CCCD này đã được đăng ký cho khách hàng khác!";
                }

                return "Success";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }
        public string InsertCustomer(string hoTen, int namSinh, string soDienThoai, string cccd, int diemTichLuy)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai) 
                    || string.IsNullOrEmpty(cccd) )
                {
                    return "Vui lòng nhập đầy đủ thông tin!";
                }

                // Kiểm tra năm sinh hợp lệ
                if (namSinh < 1900 || namSinh > DateTime.Now.Year)
                {
                    return "Năm sinh không hợp lệ!";
                }

                // Kiểm tra trùng lặp và định dạng
                string validateResult = ValidateInput(soDienThoai, cccd);
                if (validateResult != "Success")
                {
                    return validateResult;
                }



                int result = KhachHang_DAL.Instance.InsertCustomer(hoTen, namSinh, soDienThoai, cccd, diemTichLuy);
                return result > 0 ? "Success" : "Thêm khách hàng thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string UpdateCustomer(int maKH, string hoTen, int namSinh, string soDienThoai, string cccd, int diemTichLuy)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(cccd))
                {
                    return "Vui lòng nhập đầy đủ thông tin!";
                }

                // Kiểm tra năm sinh hợp lệ
                if (namSinh < 1900 || namSinh > DateTime.Now.Year)
                {
                    return "Năm sinh không hợp lệ!";
                }

                // Lấy thông tin khách hàng hiện tại
                var currentCustomer = GetCustomer().AsEnumerable()
                    .FirstOrDefault(row => Convert.ToInt32(row["Mã KH"]) == maKH);

                if (currentCustomer == null)
                {
                    return "Không tìm thấy khách hàng!";
                }

                string currentPhone = currentCustomer["Số điện thoại"].ToString().Trim();
                string currentCC = currentCustomer["CCCD"].ToString().Trim();

                // Kiểm tra số điện thoại đã tồn tại (trừ số điện thoại của khách hàng hiện tại)
                var phoneNumbers = KhachHang_DAL.Instance.GetAllPhoneNumbers();
                if (phoneNumbers.Contains(soDienThoai) && soDienThoai != currentPhone)
                {
                    return "Số điện thoại đã tồn tại trong hệ thống!";
                }

                // Kiểm tra CCCD đã tồn tại (trừ CCCD của khách hàng hiện tại)
                var ccNumbers = KhachHang_DAL.Instance.GetAllCCCDs();
                if (ccNumbers.Contains(cccd) && cccd != currentCC)
                {
                    return "CCCD đã tồn tại trong hệ thống!";
                }

                // Kiểm tra điểm tích lũy
                if (diemTichLuy < 0)
                {
                    return "Điểm tích lũy không được âm!";
                }

                int result = KhachHang_DAL.Instance.UpdateCustomer(maKH, hoTen, namSinh, soDienThoai, cccd, diemTichLuy);
                return result > 0 ? "Success" : "Cập nhật khách hàng thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }
        public string Validateinput(string soDienThoai, string CCCD)
        {
            try
            {
                // Kiểm tra số điện thoại và CCCD có phải là số không
                if (!soDienThoai.All(char.IsDigit))
                {
                    return "Số điện thoại phải chỉ chứa các ký tự số!";
                }
                if (!CCCD.All(char.IsDigit))
                {
                    return "CCCD phải chỉ chứa các ký tự số!";
                }

                // Kiểm tra độ dài số điện thoại (thường là 10 số)
                if (soDienThoai.Length != 10)
                {
                    return "Số điện thoại phải có 10 chữ số!";
                }

                // Kiểm tra độ dài CCCD (phải là 12 số)
                if (CCCD.Length != 12)
                {
                    return "CCCD phải có 12 chữ số!";
                }

                var phoneNumbers = GetAllPhoneNumbers();
                var ccNumbers = GetAllCCCDs();
                bool ExitsPhone = phoneNumbers.Contains(soDienThoai);
                bool ExitsCCCD = ccNumbers.Contains(CCCD);
                if (ExitsPhone)
                {
                    return "Số điện thoại đã tồn tại trong hệ thống!";
                }
                else if (ExitsCCCD)
                {
                    return "CCCD đã tồn tại trong hệ thống!";
                }
                else
                {
                    return "Success";
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string SoftDeleteCustomer(int maKH)
        {
            try
            {
                int result = KhachHang_DAL.Instance.SoftDeleteCustomer(maKH);
                return result > 0 ? "Success" : "Xóa khách hàng thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public DataTable SearchCustomer(string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                return GetCustomer();
            }
            return KhachHang_DAL.Instance.SearchCustomer(searchValue);
        }
        public List<string> GetAllPhoneNumbers()
        {
           return KhachHang_DAL.Instance.GetAllPhoneNumbers();
        }

        public List<string> GetAllCCCDs()
        {
            return KhachHang_DAL.Instance.GetAllCCCDs();
        }
    }
}
