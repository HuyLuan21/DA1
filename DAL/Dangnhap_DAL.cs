using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dangnhap_DAL
    {
        private static Dangnhap_DAL instance;
        public static Dangnhap_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dangnhap_DAL();
                return instance;
            }
        }
        private Dangnhap_DAL() { }
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
    }
}
