
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang_DAL
    {
        private static KhachHang_DAL instance;
        public static KhachHang_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHang_DAL();
                return instance;
            }
        }
        private KhachHang_DAL() { }

        public DataTable GetCustomer()
        {
            
            string query = "SELECT MaKH AS \"Mã khách hàng\", Tenkh AS \"Tên khách hàng\", NamSinh AS \"Năm sinh\", SoDienThoai AS \"Số điện thoại\", DiemTichLuy AS \"Điểm tích lũy\", CCCD\r\nFROM KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //public int InsertCustomer( Customer)
        //{
        //    string query = $@"INSERT INTO KhachHang (TenKH, NamSinh, SoDienThoai, DiemTichLuy, CCCD)
        //                 VALUES (N'{Customer.TenKh}', 
        //                        '{Customer.Namsinh}', 
        //                        '{Customer.SDT}', 
        //                        '{Customer.Diemtichluy}',
        //                        '{Customer.CCCD}');
        //                 SELECT SCOPE_IDENTITY()";

        //    object result = DataProvider.Instance.ExecuteScalar(query);
        //    return (result != null) ? Convert.ToInt32(result) : -1;
        //}

        //public int UpdateCustomer( Customer)
        //{
        //    string query = $@"UPDATE KhachHang
        //                 SET TenKH = N'{Customer.TenKh}', 
        //                     NamSinh = '{Customer.Namsinh}',
        //                     SoDienThoai = '{Customer.SDT}',
        //                     DiemTichLuy = '{Customer.Diemtichluy}',
        //                     CCCD = '{Customer.CCCD}'
        //                 WHERE MaKH = {Customer.MaKh}";

        //    return DataProvider.Instance.ExecuteNonQuery(query);
        //}

        //public int DeleteCustomer(int maKH)
        //{
        //    // Kiểm tra xem khách hàng có vé không
        //    string checkQuery = $"SELECT COUNT(*) FROM Ve WHERE MaKhachHang = {maKH}";
        //    int ticketCount = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(checkQuery));
            
        //    if (ticketCount > 0)
        //    {
        //        return -1; // Trả về -1 nếu khách hàng đã có vé
        //    }
            
        //    // Nếu không có vé, tiến hành xóa khách hàng
        //    string deleteQuery = $"DELETE FROM KhachHang WHERE MaKH = {maKH}";
        //    return DataProvider.Instance.ExecuteNonQuery(deleteQuery);
        //}


    }
}
