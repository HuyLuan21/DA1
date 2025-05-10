using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int _MaNV;
        private string _TenDN;
        private string _MatKhau;
        private string _LoaiTK;

        public int MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenDN { get => _TenDN; set => _TenDN = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string LoaiTK { get => _LoaiTK; set => _LoaiTK = value; }
        
        public TaiKhoan_DTO(){}
        public TaiKhoan_DTO(int MaNV, string TenDN, string MatKhau, string LoaiTK)
        {
            this.MaNV = MaNV;
            this.TenDN = TenDN;
            this.MatKhau = MatKhau;
            this.LoaiTK = LoaiTK;
        }
    }
}
