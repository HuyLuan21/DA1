using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class PhongChieu_DAL
    {
        private static PhongChieu_DAL instance;
        public static PhongChieu_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongChieu_DAL();
                return instance;
            }
        }
        private PhongChieu_DAL() { }
        // Add methods for PhongChieu_DAL 
        public DataTable GetPhongChieu()
        {
            string query = @"SELECT MaPhongChieu AS ""Mã phòng chiếu"",TenPhong AS ""Tên phòng"",TongSoGhe AS ""Tổng số ghế"" ,SoHangGhe AS ""Số hàng ghế"",SoGhe1Hang AS ""Số ghế 1 hàng"" FROM PhongChieu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertPhongChieu(string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang)
        {
            string query = "INSERT INTO PhongChieu (TenPhong, TongSoGhe, SoHangGhe, SoGhe1Hang) VALUES (N'" + tenPhong + "', " + tongSoGhe + ", " + soHangGhe + ", " + soGhe1Hang + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePhongChieu(int maPhongChieu, string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang)
        {
            string query = "UPDATE PhongChieu SET TenPhong = N'" + tenPhong + "', TongSoGhe = " + tongSoGhe + ", SoHangGhe = " + soHangGhe + ", SoGhe1Hang = " + soGhe1Hang + " WHERE MaPhongChieu = " + maPhongChieu;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePhongChieu(int maPhongChieu) 
        {
            string query = "DELETE FROM PhongChieu WHERE MaPhongChieu = " + maPhongChieu;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<string> GetPhongchieuName()
        {
            string query = "  SELECT TenPhong FROM PhongChieu";
            List<string> result = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                result.Add(row["TenPhong"].ToString());
            }
            return result;
        }
    }
}
