using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        private static TaiKhoan_DAL instance;
        public static TaiKhoan_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoan_DAL();
                return instance;
            }
        }
        private TaiKhoan_DAL() { }
        public DataTable GetAccount()
        {
            string query = @"SELECT TenDangNhap AS "" Tên đăng nhập"",MatKhau AS ""Mật khẩu"",LoaiTK AS ""Loại TK"",MaNV AS ""Mã nhân viên"" FROM TaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertTK(string tenDangNhap, string matKhau, int loaiTK, int maNV)
        {
            string query = $@"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTK, MaNV)
                              VALUES ('{tenDangNhap}', 
                                     '{matKhau}', 
                                     {loaiTK}, 
                                     {maNV})";
            int rowAffected = DataProvider.Instance.ExecuteNonQuery(query);
            return rowAffected;
        }
        public int UpdateTK(string tenDangNhap, string matKhau, int loaiTK, int maNV)
        {
            string query = $@"UPDATE TaiKhoan
                          SET MatKhau = '{matKhau}', 
                              LoaiTK = {loaiTK},
                              MaNV = {maNV}
                          WHERE TenDangNhap = '{tenDangNhap}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteTK(string tendangnhap)
        {
            string query = $@"DELETE FROM TaiKhoan
                          WHERE MaNV = '{tendangnhap}'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable Search(string searchValue)
        {
            string query = $@"SELECT TenDangNhap AS "" Tên đăng nhập"",MatKhau AS ""Mật khẩu"",LoaiTK AS ""Loại TK"",MaNV AS ""Mã nhân viên"" FROM TaiKhoan WHERE TenDangNhap LIKE '%{searchValue}%' OR MatKhau LIKE '%{searchValue}%' OR LoaiTK LIKE '%{searchValue}%' OR MaNV LIKE '%{searchValue}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<string> GetAllUsernames()
        {
            List<string> usernames = new List<string>();
            string query = "SELECT TenDangNhap FROM TaiKhoan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                usernames.Add(row["TenDangNhap"].ToString());
            }
            return usernames;
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
