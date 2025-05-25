using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhap_DAL
    {
        private static DangNhap_DAL instance;
        public static DangNhap_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhap_DAL();
                return instance;
            }
        }
        private DangNhap_DAL() { }
        public bool CheckLogin(string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '{username}' AND MatKhau = '{password}'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public bool ismanager(string username)
        {
            string query = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '{username}' AND LoaiTK = '1'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public int GetMaNhanVienByTenDangNhap(string tenDangNhap)
        {
            string query = $"SELECT MaNV FROM TaiKhoan WHERE TenDangNhap = '{tenDangNhap}'";
            var result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : -1;
        }
    }
}
