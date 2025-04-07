using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Xml.Linq;

namespace DAL
{
    public class Staff_DAL
    {
        private static Staff_DAL instance;
        public static Staff_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Staff_DAL();
                }
                return instance;
            }
        }
        private Staff_DAL() { }
        public DataTable GetStaff()
        {
                string query = "SELECT * FROM NhanVien";
                DataTable res = DataProvider.Instance.ExecuteQuery(query);
                return res;
        }
        public int InsertStaff()
        {
            string query = $@"INSERT INTO NhanVien )";

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);

            return rowsAffected;
        }
    }
}
