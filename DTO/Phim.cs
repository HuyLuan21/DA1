using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phim
    {
        private int _MaPhim;
        private int _MaLoaiPhim;
        private string _TenPhim;
        private string _MoTa;
        private int _ThoiLuong;
        private DateTime _NgayKhoiChieu;
        private DateTime _NgayKetThuc;
        private string _QuocGia;
        private string _DaoDien;
        private int _GioiHanTuoi;
        private int _NamSX;

        public int MaPhim { get; set; }
        public int MaLoaiPhim { get; set; }
        public string TenPhim { get; set; }
        public string MoTa { get; set; }
        public int ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string QuocGia { get; set; }
        public string DaoDien { get; set; }
        public int GioiHanTuoi { get; set; }
        public int NamSX { get; set; }

        public Phim() { }

        public Phim(int MaPhim, int MaLoaiPhim, string TenPhim, string MoTa, int ThoiLuong, 
                   DateTime NgayKhoiChieu, DateTime NgayKetThuc, string QuocGia, string DaoDien, 
                   int GioiHanTuoi, int NamSX)
        {
            this.MaPhim = MaPhim;
            this.MaLoaiPhim = MaLoaiPhim;
            this.TenPhim = TenPhim;
            this.MoTa = MoTa;
            this.ThoiLuong = ThoiLuong;
            this.NgayKhoiChieu = NgayKhoiChieu;
            this.NgayKetThuc = NgayKetThuc;
            this.QuocGia = QuocGia;
            this.DaoDien = DaoDien;
            this.GioiHanTuoi = GioiHanTuoi;
            this.NamSX = NamSX;
        }
    }
}
