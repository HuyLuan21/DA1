using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoan_BLL
    {
        private static TaiKhoan_BLL instance;
        public static TaiKhoan_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoan_BLL();
                return instance;
            }
        }
        private TaiKhoan_BLL() { }

        public DataTable GetAccounts()
        {
            return TaiKhoan_DAL.Instance.GetAccount();
        }

        public string ValidateInput(string tenDangNhap, string matKhau, int loaitk, int maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    return "Vui lòng nhập đầy đủ thông tin!";
                }

                // Kiểm tra tên đăng nhập đã tồn tại
                var accounts = TaiKhoan_DAL.Instance.GetAllUsernames();
                if (accounts.Contains(tenDangNhap))
                {
                    return "Tên đăng nhập đã tồn tại!";
                }

                // Kiểm tra mã nhân viên
                if (maNV <= 0)
                {
                    return "Mã nhân viên không hợp lệ!";
                }

                return "Success";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string InsertAccount(string tenDangNhap, string matKhau, int loaiTK, int maNV)
        {
            try
            {
                // Kiểm tra nhân viên đã có tài khoản chưa
                string checkQuery = $"SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = {maNV}";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(checkQuery).Rows[0][0]);
                if (count > 0)
                {
                    return "Nhân viên này đã có tài khoản!";
                }

                // Kiểm tra tên đăng nhập đã tồn tại chưa
                checkQuery = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '{tenDangNhap}'";
                count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(checkQuery).Rows[0][0]);
                if (count > 0)
                {
                    return "Tên đăng nhập đã tồn tại!";
                }

                // Kiểm tra nhân viên có tồn tại không
                checkQuery = $"SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = {maNV}";
                count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(checkQuery).Rows[0][0]);
                if (count == 0)
                {
                    return "Mã nhân viên không tồn tại!";
                }

                int result = TaiKhoan_DAL.Instance.InsertTK(tenDangNhap, matKhau, loaiTK, maNV);
                return result > 0 ? "Success" : "Thêm tài khoản không thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateAccount(string tenDangNhap, string matKhau, int loaitk, int maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    return "Vui lòng nhập đầy đủ thông tin!";
                }

                // Kiểm tra mã nhân viên
                if (maNV <= 0)
                {
                    return "Mã nhân viên không hợp lệ!";
                }

             
                int result = TaiKhoan_DAL.Instance.UpdateTK(tenDangNhap, matKhau, loaitk, maNV);
                return result > 0 ? "Success" : "Cập nhật tài khoản thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }
        public string DeleteAccount(string tendangnhap)
        {
            try
            {
               if(string.IsNullOrEmpty(tendangnhap))
                {
                    return "Vui lòng nhập username cần xóa!";
                }

                int result = TaiKhoan_DAL.Instance.DeleteTK(tendangnhap);
                return result > 0 ? "Success" : "Xóa tài khoản thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }
        public DataTable SearchAccount(string searchValue)
        {
            try
            {
                if (string.IsNullOrEmpty(searchValue))
                {
                    return GetAccounts();
                }
                return TaiKhoan_DAL.Instance.Search(searchValue);
            }
            catch (Exception)
            {
                return GetAccounts();
            }
        }
        public List<string> GetAccountTypes()
        {
          List<string> accountTypes = new List<string>();
            string query = "SELECT DISTINCT LoaiTK FROM TaiKhoan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                accountTypes.Add(row["LoaiTK"].ToString());
            }
            return accountTypes;
        }
    }
}
