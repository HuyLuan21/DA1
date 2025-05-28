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
        public DataTable GetStaticByMovie(string movieName, string begin_day, string End_day)
        {
            string query = $@"sp_ThongKeDoanhThu_TheoTenPhim_TheoNgay N'{movieName}', '{begin_day}', '{End_day}'";
            //throw new Exception("Query: " + query);
           //sp_ThongKeDoanhThu_TheoTenPhim_TheoNgay N'Avengers: Endgame', '2024-04-01', '2024-04-30'
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStaticByDirector(string Director, string begin_day, string End_day)
        {
            string query = $"sp_ThongKeDoanhThu_TheoDaoDien_TheoNgay N'{Director}', '{begin_day}', '{End_day}'";
            //sp_ThongKeDoanhThu_TheoDaoDien_TheoNgay N'Anthony Russo, Joe Russo', '2024-04-01', '2024-04-30'
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStaticByDay(string begin_day)
        {
            string query = $"sp_ThongKeDoanhThu_TrongNgay '{begin_day}'";
            //sp_ThongKeDoanhThu_TrongNgay '2024-04-26'
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
