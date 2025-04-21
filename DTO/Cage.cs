using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cage
    {
        private int _MaLoai;
        private string _TenLoai;
        public int MaLoai
        {
            get => _MaLoai;
            set => _MaLoai = value;
        }
        public string TenLoai
        {
            get => _TenLoai;
            set => _TenLoai = value;
        }
        public Cage() { }
        public Cage(int MaLoai, string TenLoai)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
        }
    }
}
