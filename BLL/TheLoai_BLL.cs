using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TheLoai_BLL
    {
        private static TheLoai_BLL instance;
        public static TheLoai_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoai_BLL();
                return instance;
            }
        }
        private TheLoai_BLL() { }
        // Add methods for TheLoai_BLL here
        public List<string> GetTheLoaiList()
        {
            return TheLoai_DAL.Instance.GetTheLoaiList();
        }
        public DataTable GetTheLoai()
        {
            return TheLoai_DAL.Instance.GetTheLoai();
        }

        public bool InsertTheLoai(string tenTheLoai)
        {
            if (string.IsNullOrEmpty(tenTheLoai))
                return false;
            return TheLoai_DAL.Instance.InsertTheLoai(tenTheLoai);
        }

        public bool UpdateTheLoai(int maTheLoai, string tenTheLoaiMoi)
        {
            if (string.IsNullOrEmpty(tenTheLoaiMoi))
                return false;
            return TheLoai_DAL.Instance.UpdateTheLoai(maTheLoai, tenTheLoaiMoi);
        }

        public bool DeleteTheLoai(int maTheLoai)
        {
            return TheLoai_DAL.Instance.DeleteTheLoai(maTheLoai);
        }
    }
}
