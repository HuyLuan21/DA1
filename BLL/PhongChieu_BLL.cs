using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PhongChieu_BLL
    {
        private static PhongChieu_BLL instance;
        public static PhongChieu_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongChieu_BLL();
                return instance;
            }
        }
        private PhongChieu_BLL() { }

        public DataTable GetPhongChieu()
        {
            return PhongChieu_DAL.Instance.GetPhongChieu();
        }

        public bool InsertPhongChieu(string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang, out string message)
        {
            message = "";
            if (string.IsNullOrEmpty(tenPhong))
            {
                message = "Tên phòng không được để trống";
                return false;
            }
            
            if (tongSoGhe != 100 || soHangGhe != 10 || soGhe1Hang != 10)
            {
                message = "Hiện chỉ hỗ trợ cho 100 ghế, 10 hàng, 10 ghế 1 hàng";
                return false;
            }
            
            bool result = PhongChieu_DAL.Instance.InsertPhongChieu(tenPhong, tongSoGhe, soHangGhe, soGhe1Hang);
            message = result ? "Thêm phòng chiếu thành công" : "Thêm phòng chiếu thất bại";
            return result;
        }

        public bool UpdatePhongChieu(int maPhongChieu, string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang, out string message)
        {
            message = "";
            if (string.IsNullOrEmpty(tenPhong))
            {
                message = "Tên phòng không được để trống";
                return false;
            }
            
            if (tongSoGhe != 100 || soHangGhe != 10 || soGhe1Hang != 10)
            {
                message = "Hiện chỉ hỗ trợ cho 100 ghế, 10 hàng, 10 ghế 1 hàng";
                return false;
            }
            
            bool result = PhongChieu_DAL.Instance.UpdatePhongChieu(maPhongChieu, tenPhong, tongSoGhe, soHangGhe, soGhe1Hang);
            message = result ? "Cập nhật phòng chiếu thành công" : "Cập nhật phòng chiếu thất bại";
            return result;
        }

        public bool DeletePhongChieu(int maPhongChieu)
        {
            return PhongChieu_DAL.Instance.DeletePhongChieu(maPhongChieu);
        }
        public List<string> GetPhongChieuNames()
        {
            return PhongChieu_DAL.Instance.GetPhongchieuName();
        }
        public int GetMaPhongByTen(string tenPhong)
        {
            return PhongChieu_DAL.Instance.GetMaPhongByTen(tenPhong);
        }

        public DataTable SearchPhongChieu(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetPhongChieu();
            return PhongChieu_DAL.Instance.SearchPhongChieu(keyword);
        }
    }
}
