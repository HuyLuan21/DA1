using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
     public  class Phim_DAL
        {
        private static Phim_DAL instance;
        public static Phim_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Phim_DAL();
                return instance;
            }
        }
        private Phim_DAL() { }
        public DataTable GetPhim()
        {
            string query = "SELECT MaPhim AS \"Mã phim\", TenPhim AS \"Tên phim\", Mota AS \"Mô tả\", ThoiLuong AS \"Thời lượng\", NgayKhoiChieu AS \"Ngày khởi chiếu\", NgayKetThuc AS \"Ngày kết thúc\", QuocGia AS \"Quốc gia\",DaoDien AS\"Đạo diễn\",GioiHanTuoi AS\"Giới hạn tuổi\", NamSX AS \"Năm sản xuất\" FROM phim;";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<string> GetMoviesName()
        {
            string query = "SELECT TenPhim FROM phim ";
         List<string> movieNames = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                movieNames.Add(row["TenPhim"].ToString());
            }
            return movieNames;
        }
         public List<string> GetmovieType(int maphim)
 {
             string query = "SELECT tlp.TenTLP FROM Phim p INNER JOIN Phim_theloai pt ON p.MaPhim = pt.MaPhim " +
                $"INNER JOIN TheLoaiPhim tlp ON pt.MaTLP = tlp.MaTLP WHERE p.MaPhim = {maphim}";
            List<string> type = new List<string>();
            foreach(DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                type.Add(row["TenTLP"].ToString());
            }
            return type;

        }
       
    }
}
