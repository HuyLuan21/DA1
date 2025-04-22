using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer_DAL
    {
        private static Customer_DAL instance;
        public static Customer_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Customer_DAL();
                return instance;
            }
        }
        private Customer_DAL() { }

        public DataTable GetCustomer()
        {
            string query = "select * from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertCustomer(Customer_DTO Customer)
        {
            string query = $@"INSERT INTO KhachHang (TenKH, NamSinh, SoDienThoai, DiemTichLuy, CCCD)
                         VALUES (N'{Customer.TenKh}', 
                                '{Customer.Namsinh}', 
                                '{Customer.SDT}', 
                                '{Customer.Diemtichluy}',
                                '{Customer.CCCD}');
                         SELECT SCOPE_IDENTITY()";

            object result = DataProvider.Instance.ExecuteScalar(query);
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        public int UpdateCustomer(Customer_DTO Customer)
        {
            string query = $@"UPDATE KhachHang
                         SET TenKH = N'{Customer.TenKh}', 
                             NamSinh = '{Customer.Namsinh}',
                             SoDienThoai = '{Customer.SDT}',
                             DiemTichLuy = '{Customer.Diemtichluy}',
                             CCCD = '{Customer.CCCD}'
                         WHERE MaKH = {Customer.MaKh}";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int DeleteCustomer(int maNV)
        {
            // Xóa khách hàng
            string query = $"DELETE FROM KhachHang WHERE MaKH = {maNV}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }


    }
}
