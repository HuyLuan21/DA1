using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangPhu
    {
        private int _MaCaChieu;
        private int _MaPhongChieu;
        private string _TenPhim;
        private DateTime _ThoiGian;
        private string _TrangThaiChieu;

        public int MaCaChieu { get; set; }
        public int MaPhongChieu { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGian { get; set; }
        public string TrangThaiChieu { get; set; }

        public BangPhu() { }

        public BangPhu(int MaCaChieu, int MaPhongChieu, string TenPhim, DateTime ThoiGian, string TrangThaiChieu)
        {
            this.MaCaChieu = MaCaChieu;
            this.MaPhongChieu = MaPhongChieu;
            this.TenPhim = TenPhim;
            this.ThoiGian = ThoiGian;
            this.TrangThaiChieu = TrangThaiChieu;
        }
    }
}
