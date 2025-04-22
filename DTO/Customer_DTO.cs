namespace DTO
{
    public class Customer_DTO
    {
        private int _MaKh;
        private string _TenKh;
        private int _Namsinh;
        private string _SDT;
        private int _Diemtichluy;
        private string _CCCD;

        public int MaKh { get => _MaKh; set => _MaKh = value; }
        public string TenKh { get => _TenKh; set => _TenKh = value; }
        public int Namsinh { get => _Namsinh; set => _Namsinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public int Diemtichluy { get => _Diemtichluy; set => _Diemtichluy = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public Customer_DTO() { }
        public Customer_DTO(int MaKh, string TenKh, int Namsinh, string SDT, int Diemtichluy, string CCCD)
        {
            MaKh = MaKh;
            TenKh = TenKh;
            Namsinh = Namsinh;
            SDT = SDT;
            Diemtichluy = Diemtichluy;
            CCCD = CCCD;
        }
    }
}
