using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Khachhang_BLL
    {
        private static Khachhang_BLL instance;
        public static Khachhang_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Khachhang_BLL();
                return instance;
            }
        }
        private Khachhang_BLL() { }

        public DataTable GetCustomer()
        {
            return KhachHang_DAL.Instance.GetCustomer();
        }

        //public string InsertCustomer(Khachhang_DTO Customer)
        //{
        //    try
        //    {
        //        int newId = Customer_DAL.Instance.InsertCustomer(Customer);
        //        if (newId > 0)
        //        {
        //            Customer.MaKh = newId;
        //            return "Success";
        //        }
        //        return "Thêm nhân viên thất bại!";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Lỗi: {ex.Message}";
        //    }
        //}

        //public string UpdateCustomer(Khachhang_DTO Customer)
        //{
        //    try
        //    {
        //        int result = Customer_DAL.Instance.UpdateCustomer(Customer);
        //        return result > 0 ? "Success" : "Cập nhật thất bại!";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Lỗi: {ex.Message}";
        //    }
        //}

        //public string DeleteCustomer(int maKH)
        //{
        //    try
        //    {
        //        int result = Customer_DAL.Instance.DeleteCustomer(maKH);
        //        if (result == -1)
        //        {
        //            return "Không thể xóa khách hàng này vì đã có lịch sử mua vé!";
        //        }
        //        return result > 0 ? "Success" : "Xóa khách hàng thất bại!";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Lỗi: {ex.Message}";
        //    }
        //}
    }
}
