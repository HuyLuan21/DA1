using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDon_BLL
    {
        private static HoaDon_BLL instance;
        public static HoaDon_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDon_BLL();
                return instance;
            }
        }
        private HoaDon_BLL() { }

        public int InsertHoaDon(int maKhachHang, int maNhanVien, decimal tongTien)
        {
            return HoaDon_DAL.Instance.InsertHoaDon(maKhachHang, maNhanVien, tongTien);
        }

        public bool InsertChiTietHoaDon(int maHoaDon, int maVe, decimal donGia)
        {
            return HoaDon_DAL.Instance.InsertChiTietHoaDon(maHoaDon, maVe, donGia);
        }

        public DataTable GetHoaDonByMaKH(int maKhachHang)
        {
            return HoaDon_DAL.Instance.GetHoaDonByMaKH(maKhachHang);
        }
        public DataTable GetTable()
        {
            return HoaDon_DAL.Instance.GetTable();
        }
    }
}