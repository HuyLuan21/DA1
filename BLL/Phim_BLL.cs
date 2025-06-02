using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Phim_BLL
    {
        private static Phim_BLL instance;
        public static Phim_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Phim_BLL();
                return instance;
            }
        }
        private Phim_BLL() { }
    
        public DataTable GetPhimList()
        {
            return DAL.Phim_DAL.Instance.GetPhim();
        }

        public DataTable SearchPhim(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetPhimList();
            return DAL.Phim_DAL.Instance.SearchPhim(keyword);
        }

        public List<string> GetMovieListName()
        {
            return DAL.Phim_DAL.Instance.GetMoviesName();
        }
        public List<string> GetMovieTypes(int maphim)
        {
            return DAL.Phim_DAL.Instance.GetmovieType(maphim);
        }
        public string InsertPhim(string tenphim, string mota, int thoiluong, DateTime ngaykhoichieu, DateTime ngayketthuc, string quocgia, string daodien, int gioihan, int namsx, List<string> theLoaiList)
        {
            if (string.IsNullOrEmpty(tenphim) || string.IsNullOrEmpty(mota) || string.IsNullOrEmpty(quocgia) || string.IsNullOrEmpty(daodien))
            {
                throw new ArgumentException("Bạn phải điền đầy đủ thông tin");
            }
            if (thoiluong <= 0)
            {
                throw new ArgumentException("Thời lượng phải lớn hơn 0");
            }
            if (ngayketthuc < ngaykhoichieu)
            {
                throw new ArgumentException("Ngày kết thúc phải sau ngày khởi chiếu");
            }
            if (namsx > DateTime.Now.Year)
            {
                throw new ArgumentException("Năm sản xuất không được lớn hơn năm hiện tại");
            }
            if (gioihan < 0 || gioihan > 18)
            {
                throw new ArgumentException("Giới hạn tuổi không hợp lệ");
            }
            if (theLoaiList == null || theLoaiList.Count == 0)
            {
                throw new ArgumentException("Phải chọn ít nhất một thể loại phim");
            }

            int result = DAL.Phim_DAL.Instance.insertphim(tenphim, mota, thoiluong, ngaykhoichieu, ngayketthuc, quocgia, daodien, gioihan, namsx);
            if (result > 0)
            {
                int maPhim = DAL.Phim_DAL.Instance.GetLastInsertedMovieId();
                foreach (string tenTheLoai in theLoaiList)
                {
                    int maTheLoai = DAL.Phim_DAL.Instance.GetTheLoaiIdByName(tenTheLoai);
                    if (maTheLoai != -1)
                    {
                        DAL.Phim_DAL.Instance.InsertMovieGenre(maPhim, maTheLoai);
                    }
                }
                return "Success";
            }
            return "Thêm phim không thành công";
        }

        public string UpdatePhim(int maphim, string tenphim, string mota, int thoiluong, DateTime ngaykhoichieu, DateTime ngayketthuc, string quocgia, string daodien, int gioihan, int namsx, List<string> theLoaiList)
        {
            if (string.IsNullOrEmpty(tenphim) || string.IsNullOrEmpty(mota) || string.IsNullOrEmpty(quocgia) || string.IsNullOrEmpty(daodien))
            {
                throw new ArgumentException("Bạn phải điền đầy đủ thông tin");
            }
            if (thoiluong <= 0)
            {
                throw new ArgumentException("Thời lượng phải lớn hơn 0");
            }
            if (ngayketthuc < ngaykhoichieu)
            {
                throw new ArgumentException("Ngày kết thúc phải sau ngày khởi chiếu");
            }
            if (namsx > DateTime.Now.Year)
            {
                throw new ArgumentException("Năm sản xuất không được lớn hơn năm hiện tại");
            }
            if (gioihan < 0 || gioihan > 18)
            {
                throw new ArgumentException("Giới hạn tuổi không hợp lệ");
            }
            if (theLoaiList == null || theLoaiList.Count == 0)
            {
                throw new ArgumentException("Phải chọn ít nhất một thể loại phim");
            }

            int result = DAL.Phim_DAL.Instance.UpdatePhim(maphim, tenphim, mota, thoiluong, ngaykhoichieu, ngayketthuc, quocgia, daodien, gioihan, namsx);
            if (result > 0)
            {
                // Xóa các thể loại cũ
                DAL.Phim_DAL.Instance.DeleteMovieGenres(maphim);
                // Thêm các thể loại mới
                foreach (string tenTheLoai in theLoaiList)
                {
                    int maTheLoai = DAL.Phim_DAL.Instance.GetTheLoaiIdByName(tenTheLoai);
                    if (maTheLoai != -1)
                    {
                        DAL.Phim_DAL.Instance.InsertMovieGenre(maphim, maTheLoai);
                    }
                }
                return "Success";
            }
            return "Cập nhật phim không thành công";
        }

        public string DeletePhim(int maphim)
        {
            int result = DAL.Phim_DAL.Instance.DeletePhim(maphim);
            return result > 0 ? "Success" : "Xóa phim không thành công";
        }

        public List<string> GetPhimId()
        {
            return Phim_DAL.Instance.GetPhimId();
        }
        public string GetPhimbyId(int maphim)
        {
            return Phim_DAL.Instance.GetPhimbyID(maphim);
        }
        public List<string> GetDirectorName()
        {
            return Phim_DAL.Instance.GetDirectorName();
        }
    }
}
