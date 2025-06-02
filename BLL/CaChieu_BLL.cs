using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
  public class CaChieu_BLL
    {
        public static CaChieu_BLL instance;
        public static CaChieu_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaChieu_BLL();
                return instance;
            }
        }
        private CaChieu_BLL() { }
     
       public DataTable GetCaChieuList()
        {
            return CaChieu_DAL.Instance.GetCaChieu();
        }
        public DataTable GetCaChieuListByMovie(string movieName)
        {
            return CaChieu_DAL.Instance.GetCaChieuByMovie(movieName);
        }
        public DataTable GetCaChieuTable()
        {
            return CaChieu_DAL.Instance.GetCaChieuTable();
        }
        public int InsertCaChieu(int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            return CaChieu_DAL.Instance.InsertCaChieu( maPhim, maPhongChieu, thoiGianChieu, thoiGianKetThuc, giaVe);
        }
        private bool ValidateCaChieu(string tenphong, string thoiGianChieu, string thoiGianKetThuc, int? maCaChieuHienTai = null)
        {
            int maphong = PhongChieu_BLL.Instance.GetMaPhongByTen(tenphong);
            DateTime dtChieuMoi, dtKetThucMoi;
            
            // Kiểm tra định dạng thời gian
            if (!DateTime.TryParse(thoiGianChieu, out dtChieuMoi) || !DateTime.TryParse(thoiGianKetThuc, out dtKetThucMoi))
            {
                return false;
            }

            // Kiểm tra thời gian chiếu không được sau 23h
            if (dtChieuMoi.Hour >= 23)
            {
                return false;
            }

            // Kiểm tra thời gian kết thúc phải sau thời gian chiếu
            if (dtKetThucMoi <= dtChieuMoi)
            {
                return false;
            }

            var table = CaChieu_DAL.Instance.GetCaChieuTable();
            foreach (System.Data.DataRow row in table.Rows)
            {
                // Bỏ qua ca chiếu hiện tại khi update
                if (maCaChieuHienTai.HasValue && Convert.ToInt32(row["Mã ca chiếu"]) == maCaChieuHienTai.Value)
                {
                    continue;
                }

                int maPhong = PhongChieu_BLL.Instance.GetMaPhongByTen(row["Phòng chiếu"].ToString());
                if (maPhong != maphong) continue;

                DateTime start = DateTime.Parse(row["Thời gian chiếu"].ToString());
                DateTime end = DateTime.Parse(row["Thời gian kết thúc"].ToString());

                // Kiểm tra xem có trùng giờ chiếu không
                if (!(dtChieuMoi >= end || dtKetThucMoi <= start))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Checkinsert(string tenphong, string thoiGianChieu, string thoiGianKetThuc)
        {
            return ValidateCaChieu(tenphong, thoiGianChieu, thoiGianKetThuc);
        }

        public bool CheckUpdate(int maCaChieu, string tenphong, string thoiGianChieu, string thoiGianKetThuc)
        {
            return ValidateCaChieu(tenphong, thoiGianChieu, thoiGianKetThuc, maCaChieu);
        }

        public int UpdateCaChieu(int maCaChieu, int maPhim, int maPhongChieu, string thoiGianChieu, string thoiGianKetThuc, int giaVe)
        {
            return CaChieu_DAL.Instance.UpdateCaChieu(maCaChieu, maPhim, maPhongChieu, thoiGianChieu, thoiGianKetThuc, giaVe);
        }
        public int DeleteCaChieu(int maCaChieu)
        {
            return CaChieu_DAL.Instance.DeleteCaChieu(maCaChieu);
        }
        
        public string ValidateCaChieuInfo(string tenphong, string thoiGianChieu, string thoiGianKetThuc, int? maCaChieuHienTai = null)
        {
            if (string.IsNullOrEmpty(tenphong) || string.IsNullOrEmpty(thoiGianChieu) || string.IsNullOrEmpty(thoiGianKetThuc))
            {
                return "Vui lòng nhập đầy đủ thông tin ca chiếu";
            }

            DateTime dtChieuMoi, dtKetThucMoi;
            if (!DateTime.TryParse(thoiGianChieu, out dtChieuMoi) || !DateTime.TryParse(thoiGianKetThuc, out dtKetThucMoi))
            {
                return "Định dạng thời gian không hợp lệ";
            }

            if (dtChieuMoi.Hour >= 23)
            {
                return "Không được phép chiếu sau 23h";
            }

            if (dtKetThucMoi <= dtChieuMoi)
            {
                return "Thời gian kết thúc phải sau thời gian chiếu";
            }

            if (!ValidateCaChieu(tenphong, thoiGianChieu, thoiGianKetThuc, maCaChieuHienTai))
            {
                return "Ca chiếu bị trùng giờ với ca chiếu khác trong cùng phòng";
            }

            return "OK";
        }

        public int GetGiaVe(int maCaChieu)
        {
            return CaChieu_DAL.Instance.GetGiaVe(maCaChieu);
        }

        public DataTable SearchCaChieu(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetCaChieuTable();
            return CaChieu_DAL.Instance.SearchCaChieu(keyword);
        }
    }
}
