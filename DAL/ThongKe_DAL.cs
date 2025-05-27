using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKe_DAL
    {
        private static ThongKe_DAL instance;
        public static ThongKe_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKe_DAL();
                return instance;
            }
        }
        private ThongKe_DAL() { }
        public DataTable GetStaticByMovie(string movieName,DateTime begin_day,DateTime End_day)
        {
            string query = $@"sp_ThongKeDoanhThu_TheoTenPhim_TheoNgay N'{movieName}', '{begin_day}', '{End_day}'";
           
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStaticByDirector(string Director, DateTime begin_day, DateTime End_day)
        {
            string query = $"sp_ThongKeDoanhThu_TheoDaoDien_TheoNgay N'{Director}', '{begin_day}', '{End_day}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStaticByDay(DateTime begin_day)
        {
            string query = $"sp_ThongKeDoanhThu_TrongNgay '{begin_day}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
