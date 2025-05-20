using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoai_DAL
    {
        private static TheLoai_DAL instance;
        public static TheLoai_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoai_DAL();
                return instance;
            }
        }
        private TheLoai_DAL() { }
        public List<string> GetTheLoaiList()
        {
            string query = "SELECT TenTLP FROM TheLoaiPhim";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> theloaiList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                theloaiList.Add(row["TenTLP"].ToString());
            }
            return theloaiList;
        }
        public DataTable GetTheLoai()
        {
            string query = "SELECT MaTLP AS 'Mã thể loại', TenTLP AS 'Tên thể loại' FROM TheLoaiPhim";
            return DataProvider.Instance.ExecuteQuery(query);
        }
     

        // Thêm thể loại mới
        public bool InsertTheLoai(string tenTheLoai)
        {
            string query = "INSERT INTO TheLoaiPhim (TenTLP) VALUES (N'" + tenTheLoai + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Sửa thể loại
        public bool UpdateTheLoai(int maTheLoai, string tenTheLoaiMoi)
        {
            string query = "UPDATE TheLoaiPhim SET TenTLP = N'" + tenTheLoaiMoi + "' WHERE MaTLP = " + maTheLoai;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Xóa thể loại
        public bool DeleteTheLoai(int maTheLoai)
        {
            string query = "DELETE FROM TheLoaiPhim WHERE MaTLP = " + maTheLoai;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
