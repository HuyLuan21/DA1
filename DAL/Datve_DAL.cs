using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Datve_DAL
    {
        private static Datve_DAL instance;
        public static Datve_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Datve_DAL();
                return instance;
            }
        }
        private Datve_DAL() { }

        public DataTable GetDanhSachGhe(int maCaChieu)
        {
            string query = $@"SELECT g.MaGheNgoi,g.HangGhe + CAST(g.SoGhe AS VARCHAR) as MaGhe,
                            CASE 
                            WHEN v.MaVe IS NOT NULL THEN N'Đã đặt'
                            ELSE N'Trống'
                            END as TrangThai
                            FROM GheNgoi g
                            INNER JOIN PhongChieu pc ON g.MaPhongChieu = pc.MaPhongChieu
                            INNER JOIN CaChieu cc ON pc.MaPhongChieu = cc.MaPhongChieu
                            LEFT JOIN Ve v ON g.MaGheNgoi = v.MaGheNgoi AND v.MaCaChieu = {maCaChieu}
                            WHERE cc.MaCaChieu = {maCaChieu}
                            ORDER BY g.HangGhe, g.SoGhe";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DatVe(int maCaChieu, int maGheNgoi)
        {
            string query = $"INSERT INTO Ve (MaCaChieu, MaGheNgoi) VALUES ({maCaChieu}, {maGheNgoi})";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
    }


