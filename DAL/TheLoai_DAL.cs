using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoai_DAL
    {
        private static TheLoai_DAL instance;
        public static TheLoai_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoai_DAL();
                return instance;
            }
        }
        private TheLoai_DAL() { }
        public List<string> GetTheLoaiList()
        {
            string query = "SELECT TenTLP FROM TheLoaiPhim";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<string> theloaiList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                theloaiList.Add(row["TenTLP"].ToString());
            }
            return theloaiList;
        }
    }
    }
