using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phongchieu_DTO
    {
        private int _MaPhong;
        private string _TenPhong;
        private int _SoChoNgoi;
        private string _TinhTrang;
        private int _SoHangGhe;
        private int _SoGheMotHang;

        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SoChoNgoi { get; set; }
        public string TinhTrang { get; set; }
        public int SoHangGhe { get; set; }
        public int SoGheMotHang { get; set; }

        public Phongchieu_DTO() { }

        public Phongchieu_DTO(int MaPhong, string TenPhong, int SoChoNgoi, string TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            this.MaPhong = MaPhong;
            this.TenPhong = TenPhong;
            this.SoChoNgoi = SoChoNgoi;
            this.TinhTrang = TinhTrang;
            this.SoHangGhe = SoHangGhe;
            this.SoGheMotHang = SoGheMotHang;
        }
    }
}
