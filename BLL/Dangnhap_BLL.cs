using DAL;


namespace BLL
{
    public class Dangnhap_BLL
    {
        private static Dangnhap_BLL instance;
        public static Dangnhap_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dangnhap_BLL();
                return instance;
            }
        }
        private Dangnhap_BLL() { }
        public bool CheckLogin(string username, string password)
        {
            return DAL.DangNhap_DAL.Instance.CheckLogin(username, password);
        }
        public bool ismanager(string username)
        {
            return DAL.DangNhap_DAL.Instance.ismanager(username);
        }
        public int GetMaNhanVienByTenDangNhap(string tenDangNhap)
        {
            return DangNhap_DAL.Instance.GetMaNhanVienByTenDangNhap(tenDangNhap);
        }
    }
}
