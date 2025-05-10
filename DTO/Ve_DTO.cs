using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Ve_DTO
    {
        private int _ID;
        private string _LoaiVe;
        private int _MaCA;
        private string _MaGhe;
        private int _MaKH;
        private int _MaNV;

        private string _TrangThai;
        private int _TienBanVe;
        
        public int ID { get => _ID; set => _ID = value; }
        public string LoaiVe { get => _LoaiVe; set => _LoaiVe = value; }
        public int MaCA { get => _MaCA; set => _MaCA = value; }
        public string MaGhe { get => _MaGhe; set => _MaGhe = value; }
        public int MaKH { get => _MaKH; set => _MaKH = value; }
        public int MaNV { get => _MaNV; set => _MaNV = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public int TienBanVe { get => _TienBanVe; set => _TienBanVe = value; }
        
        public Ve_DTO() { }
        public Ve_DTO(int ID, string LoaiVe, int MaCA, string MaGhe, int MaKH, int MaNV, string TrangThai, int TienBanVe)
        {
            this.ID = ID;
            this.LoaiVe = LoaiVe;
            this.MaCA = MaCA;
            this.MaGhe = MaGhe;
            this.MaKH = MaKH;
            this.MaNV = MaNV;
            this.TrangThai = TrangThai;
            this.TienBanVe = TienBanVe;
        }
    }
}
