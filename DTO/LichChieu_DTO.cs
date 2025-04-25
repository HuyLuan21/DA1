using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieu_DTO
    {
        private int _MaCaChieu;
        private string _TenPhim;
        private DateTime _ThoiGianChieu;
        private int _MaPhong;

        public int MaCaChieu { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public int MaPhong { get; set; }

        public LichChieu_DTO() { }

        public LichChieu_DTO(int MaCaChieu, string TenPhim, DateTime ThoiGianChieu, int MaPhong)
        {
            this.MaCaChieu = MaCaChieu;
            this.TenPhim = TenPhim;
            this.ThoiGianChieu = ThoiGianChieu;
            this.MaPhong = MaPhong;
        }
    }
}
