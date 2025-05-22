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

        public bool InsertPhongChieu(string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang)
        {
            if (string.IsNullOrEmpty(tenPhong))
                return false;
            if (tongSoGhe <= 0 || soHangGhe <= 0 || soGhe1Hang <= 0)
                return false;
            if (tongSoGhe != soHangGhe * soGhe1Hang)
                return false;
            return PhongChieu_DAL.Instance.InsertPhongChieu(tenPhong, tongSoGhe, soHangGhe, soGhe1Hang);
        }

        public bool UpdatePhongChieu(int maPhongChieu, string tenPhong, int tongSoGhe, int soHangGhe, int soGhe1Hang)
        {
            if (string.IsNullOrEmpty(tenPhong))
                return false;
            if (tongSoGhe <= 0 || soHangGhe <= 0 || soGhe1Hang <= 0)
                return false;
            if (tongSoGhe != soHangGhe * soGhe1Hang)
                return false;
            return PhongChieu_DAL.Instance.UpdatePhongChieu(maPhongChieu, tenPhong, tongSoGhe, soHangGhe, soGhe1Hang);
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

    }
}
