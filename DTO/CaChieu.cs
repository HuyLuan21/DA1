using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaChieu
    {
        private int _MaCaChieu;
        private int _MaPhong;
        private int _MaPhim;
        private string _TenPhim;
        private DateTime _ThoiGianChieu;
        private DateTime _ThoiGianKetThuc;
        private decimal _GiaVe;
        
        public int MaCaChieu { get; set; }
        public int MaPhong { get; set; }
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public decimal GiaVe { get; set; }
        public CaChieu() { }
        public CaChieu(int MaCaChieu, int MaPhong, int MaPhim, string TenPhim, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, decimal GiaVe)
        {
            this.MaCaChieu = MaCaChieu;
            this.MaPhong = MaPhong;
            this.MaPhim = MaPhim;
            this.TenPhim = TenPhim;
            this.ThoiGianChieu = ThoiGianChieu;
            this.ThoiGianKetThuc = ThoiGianKetThuc;
            this.GiaVe = GiaVe;
        }
        

    }
}
