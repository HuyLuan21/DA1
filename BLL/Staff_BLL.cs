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
    public class Staff_BLL
    {
        private static Staff_BLL instance;
        public static Staff_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Staff_BLL();
                return instance;
            }
        }
        private Staff_BLL() { }

        public DataTable GetStaff()
        {
            return Staff_DAL.Instance.GetStaff();
        }

        public string InsertStaff(Staff_DTO staff)
        {
            try
            { 
                int newId = Staff_DAL.Instance.InsertStaff(staff);
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

        public string UpdateStaff(Staff_DTO staff)
        {
            try
            {
                int result = Staff_DAL.Instance.UpdateStaff(staff);
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
                int result = Staff_DAL.Instance.DeleteStaff(maNV);
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
            return Staff_DAL.Instance.SearchStaff(searchValue);
        }
    }
}
