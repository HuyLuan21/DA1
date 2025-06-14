﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
     public  class Phim_DAL
     {
        private static Phim_DAL instance;
        public static Phim_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new Phim_DAL();
                return instance;
            }
        }
        private Phim_DAL() { }
        public DataTable GetPhim()
        {
            string query = "SELECT MaPhim AS \"Mã phim\", TenPhim AS \"Tên phim\", Mota AS \"Mô tả\", ThoiLuong AS \"Thời lượng\", NgayKhoiChieu AS \"Ngày khởi chiếu\", NgayKetThuc AS \"Ngày kết thúc\", QuocGia AS \"Quốc gia\",DaoDien AS\"Đạo diễn\",GioiHanTuoi AS\"Giới hạn tuổi\", NamSX AS \"Năm sản xuất\" FROM phim;";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchPhim(string keyword)
        {
            string query = @"SELECT MaPhim AS 'Mã phim', TenPhim AS 'Tên phim', Mota AS 'Mô tả', 
                           ThoiLuong AS 'Thời lượng', NgayKhoiChieu AS 'Ngày khởi chiếu', 
                           NgayKetThuc AS 'Ngày kết thúc', QuocGia AS 'Quốc gia',
                           DaoDien AS 'Đạo diễn', GioiHanTuoi AS 'Giới hạn tuổi', 
                           NamSX AS 'Năm sản xuất' 
                           FROM phim 
                           WHERE CAST(MaPhim AS VARCHAR) LIKE N'%" + keyword + "%' " +
                           "OR TenPhim LIKE N'%" + keyword + "%' " +
                           "OR Mota LIKE N'%" + keyword + "%' " +
                           "OR CAST(ThoiLuong AS VARCHAR) LIKE N'%" + keyword + "%' " +
                           "OR CONVERT(VARCHAR, NgayKhoiChieu, 103) LIKE N'%" + keyword + "%' " +
                           "OR CONVERT(VARCHAR, NgayKetThuc, 103) LIKE N'%" + keyword + "%' " +
                           "OR QuocGia LIKE N'%" + keyword + "%' " +
                           "OR DaoDien LIKE N'%" + keyword + "%' " +
                           "OR CAST(GioiHanTuoi AS VARCHAR) LIKE N'%" + keyword + "%' " +
                           "OR CAST(NamSX AS VARCHAR) LIKE N'%" + keyword + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> GetMoviesName()
        {
            string query = "SELECT TenPhim FROM phim ";
            List<string> movieNames = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                movieNames.Add(row["TenPhim"].ToString());
            }
            return movieNames;
        }
        public List<string> GetmovieType(int maphim)
        {
            string query = "SELECT tlp.TenTLP FROM Phim p INNER JOIN Phim_theloai pt ON p.MaPhim = pt.MaPhim " +
                           $"INNER JOIN TheLoaiPhim tlp ON pt.MaTLP = tlp.MaTLP WHERE p.MaPhim = {maphim}";
            List<string> type = new List<string>();
            foreach(DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                type.Add(row["TenTLP"].ToString());
            }
            return type;
        }
        public int insertphim(string tenphim, string mota, int thoiluong, DateTime ngaykhoichieu, DateTime ngayketthuc, string quocgia, string daodien, int gioihan, int namsx)
        {
            string query = $@"INSERT INTO phim (TenPhim, Mota, ThoiLuong, NgayKhoiChieu, NgayKetThuc, QuocGia, DaoDien, GioiHanTuoi, NamSX) 
                            VALUES (N'{tenphim}', N'{mota}', {thoiluong}, '{ngaykhoichieu:yyyy-MM-dd}', '{ngayketthuc:yyyy-MM-dd}', 
                            N'{quocgia}', N'{daodien}', {gioihan}, {namsx})";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhim(int maphim, string tenphim, string mota, int thoiluong, DateTime ngaykhoichieu, DateTime ngayketthuc, string quocgia, string daodien, int gioihan, int namsx)
        {
            string query = $@"UPDATE phim 
                            SET TenPhim = N'{tenphim}', 
                                Mota = N'{mota}', 
                                ThoiLuong = {thoiluong}, 
                                NgayKhoiChieu = '{ngaykhoichieu:yyyy-MM-dd}', 
                                NgayKetThuc = '{ngayketthuc:yyyy-MM-dd}', 
                                QuocGia = N'{quocgia}', 
                                DaoDien = N'{daodien}', 
                                GioiHanTuoi = {gioihan}, 
                                NamSX = {namsx} 
                            WHERE MaPhim = {maphim}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhim(int maphim)
        {
            string query = $"DELETE FROM phim WHERE MaPhim = {maphim}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public string GetPhimbyID(int maphim)
        {
            string query = $"SELECT TenPhim FROM Phim WHERE MaPhim = {maphim}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TenPhim"].ToString();
            return string.Empty;
        }
        public List<string> GetPhimId()
        {
            string query = "SELECT MaPhim FROM Phim";
            List<string> result = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                result.Add(row["MaPhim"].ToString());
            }
            return result;
        }
        public List<string> GetDirectorName()
        {
            string query = $"SELECT DaoDien FROM Phim";
            List<string> result = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                result.Add(row["DaoDien"].ToString());
            }
            return result;
        }
        public int GetLastInsertedMovieId()
        {
            string query = "SELECT IDENT_CURRENT('phim')";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
        public bool InsertMovieGenre(int maPhim, int maTheLoai)
        {
            string query = $"INSERT INTO Phim_theloai (MaPhim, MaTLP) VALUES ({maPhim}, {maTheLoai})";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteMovieGenres(int maPhim)
        {
            string query = $"DELETE FROM Phim_theloai WHERE MaPhim = {maPhim}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetTheLoaiIdByName(string tenTheLoai)
        {
            string query = $"SELECT MaTLP FROM TheLoaiPhim WHERE TenTLP = N'{tenTheLoai}'";
            var result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : -1;
        }
    }
}
