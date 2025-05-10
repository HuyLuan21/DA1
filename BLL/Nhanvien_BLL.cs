using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

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
            return Nhanvien_DAL.Instance.GetStaff();
        }

        public string InsertStaff(Nhanvien_DTO staff)
        {
            try
            { 
                int newId = Nhanvien_DAL.Instance.InsertStaff(staff);
                if (newId > 0)
                {
                    staff.MaNV = newId;
                    return "Success";
                }
                return "Thêm nhân viên thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string UpdateStaff(Nhanvien_DTO staff)
        {
            try
            {
                int result = Nhanvien_DAL.Instance.UpdateStaff(staff);
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
                int result = Nhanvien_DAL.Instance.DeleteStaff(maNV);
                if (result == -1)
                {
                    return "Không thể xóa nhân viên này vì bảng vé đang tham chiếu";
                }
                return result > 0 ? "Success" : "Xóa khách hàng thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
           
        }

        public DataTable SearchStaff(string searchValue)
        {
            return Nhanvien_DAL.Instance.SearchStaff(searchValue);
        }
    }
}
