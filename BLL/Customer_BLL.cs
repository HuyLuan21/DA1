using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Customer_BLL
    {
        private static Customer_BLL instance;
        public static Customer_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Customer_BLL();
                return instance;
            }
        }
        private Customer_BLL() { }

        public DataTable GetCustomer()
        {
            return Customer_DAL.Instance.GetCustomer();
        }

        public string InsertCustomer(Customer_DTO Customer)
        {
            try
            {
                int newId = Customer_DAL.Instance.InsertCustomer(Customer);
                if (newId > 0)
                {
                    Customer.MaKh = newId;
                    return "Success";
                }
                return "Thêm nhân viên thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string UpdateCustomer(Customer_DTO Customer)
        {
            try
            {
                int result = Customer_DAL.Instance.UpdateCustomer(Customer);
                return result > 0 ? "Success" : "Cập nhật thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }

        public string DeleteCustomer(int maNV)
        {
            try
            {
                int result = Customer_DAL.Instance.DeleteCustomer(maNV);
                return result > 0 ? "Success" : "Xóa nhân viên thất bại!";
            }
            catch (Exception ex)
            {
                return $"Lỗi: {ex.Message}";
            }
        }
    }
}
