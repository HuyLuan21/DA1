using System;

namespace DTO
{
    public class Customer
    {
        private int _MaKh;
        private string _TenKh;
        private DateTime _Namsinh;
        private string _SDT;
        private int _Diemtichluy;
        private string _CCCD;

        public int MaKh { get => _MaKh; set => _MaKh = value; }
        public string TenKh { get => _TenKh; set => _TenKh = value; }
        public DateTime Namsinh { get => _Namsinh; set => _Namsinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public int Diemtichluy { get => _Diemtichluy; set => _Diemtichluy = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public Customer() { }
        public Customer(int MaKh, string TenKh, DateTime Namsinh, string SDT, int Diemtichluy, string CCCD)
        {
            this.MaKh = MaKh;
            this.TenKh = TenKh;
            this.Namsinh = Namsinh;
            this.SDT = SDT;
            this.Diemtichluy = Diemtichluy;
            this.CCCD = CCCD;
        }
    }
}
