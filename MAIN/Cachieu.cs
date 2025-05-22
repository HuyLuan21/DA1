using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1
{
    public partial class Movies_time : Form
    {
        public Movies_time()
        {
            InitializeComponent();
        }
       

        private void Movie_id_Click(object sender, EventArgs e)
        {

        }

        private void Name_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_of_movie_Click(object sender, EventArgs e)
        {

        }

        private void Id_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Movies_time_Load(object sender, EventArgs e)
        {
            Time_grv.DataSource = CaChieu_BLL.Instance.GetCaChieuTable();
            Movies_id_cbx.DataSource = Phim_BLL.Instance.GetPhimId();
            Phongchieu_cbx.DataSource = PhongChieu_BLL.Instance.GetPhongChieuNames();
        }

     

        private void Movies_id_cbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Name_tbx.Text = Phim_BLL.Instance.GetPhimbyId(int.Parse(Movies_id_cbx.SelectedValue.ToString()));
        }

        private void Time_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if(e.RowIndex <0) return;
            Cachieu_tbx.Text = Time_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Movies_id_cbx.Text = Time_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            Ngaychieu.Text = Time_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
            Giochieu.Text = Time_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
            Ketthuc.Text = Time_grv.Rows[e.RowIndex].Cells[5].Value.ToString();
            GioKT.Text = Time_grv.Rows[e.RowIndex].Cells[5].Value.ToString();
            GiaVe.Text = Time_grv.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int maCaChieu = int.Parse(Cachieu_tbx.Text);
                int result = CaChieu_BLL.Instance.DeleteCaChieu(maCaChieu);
                if (result > 0)
                {
                    MessageBox.Show("Xóa ca chiếu thành công!");
                    Time_grv.DataSource = CaChieu_BLL.Instance.GetCaChieuTable();
                }
                else
                {
                    MessageBox.Show("Xóa ca chiếu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int maCaChieu = int.Parse(Cachieu_tbx.Text);
                int maPhim = int.Parse(Movies_id_cbx.Text);
                DateTime dt_ngaychieu = Ngaychieu.Value.Date;
                string ngaychieu = dt_ngaychieu.ToString("yyyy-MM-dd");
                DateTime dt_giochieu = Giochieu.Value;          
                string giochieu = dt_giochieu.ToString("HH:mm:ss");
                DateTime dt_ngayketthuc = Ketthuc.Value.Date;
                string ngaykt = dt_ngaychieu.ToString("yyyy-MM-dd");      
                DateTime dt_giokt = GioKT.Value;
                string giokt = dt_giokt.ToString("HH:mm:ss");
                int giaVe = int.Parse(GiaVe.Text);
                string thoiGianChieu = ngaychieu + " " + giochieu;
                string thoiGianKetThuc = ngaykt + " " + giokt;
                string tenphong = Phongchieu_cbx.Text;

                // Kiểm tra điều kiện trước khi cập nhật
                string validationResult = CaChieu_BLL.Instance.ValidateCaChieuInfo(tenphong, thoiGianChieu, thoiGianKetThuc, maCaChieu);
                if (validationResult != "OK")
                {
                    MessageBox.Show(validationResult);
                    return;
                }

                int maPhong = PhongChieu_BLL.Instance.GetMaPhongByTen(tenphong);
                int result = CaChieu_BLL.Instance.UpdateCaChieu(maCaChieu, maPhim, maPhong, thoiGianChieu, thoiGianKetThuc, giaVe);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật ca chiếu thành công!");
                    Time_grv.DataSource = CaChieu_BLL.Instance.GetCaChieuTable();
                }
                else
                {
                    MessageBox.Show("Cập nhật ca chiếu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhim = int.Parse(Movies_id_cbx.Text);
                DateTime dt_ngaychieu = Ngaychieu.Value.Date;
                string ngaychieu = dt_ngaychieu.ToString("yyyy-MM-dd");
                DateTime dt_giochieu = Giochieu.Value;          
                string giochieu = dt_giochieu.ToString("HH:mm:ss");
                DateTime dt_ngayketthuc = Ketthuc.Value.Date;
                string ngaykt = dt_ngaychieu.ToString("yyyy-MM-dd");      
                DateTime dt_giokt = GioKT.Value;
                string giokt = dt_giokt.ToString("HH:mm:ss");
                int giaVe = int.Parse(GiaVe.Text);
                string thoiGianChieu = ngaychieu + " " + giochieu;
                string thoiGianKetThuc = ngaykt + " " + giokt;
                string tenphong = Phongchieu_cbx.Text;

                // Kiểm tra điều kiện trước khi thêm mới
                string validationResult = CaChieu_BLL.Instance.ValidateCaChieuInfo(tenphong, thoiGianChieu, thoiGianKetThuc);
                if (validationResult != "OK")
                {
                    MessageBox.Show(validationResult);
                    return;
                }

                int maPhong = PhongChieu_BLL.Instance.GetMaPhongByTen(tenphong);
                int result = CaChieu_BLL.Instance.InsertCaChieu(maPhim, maPhong, thoiGianChieu, thoiGianKetThuc, giaVe);
                if (result > 0)
                {
                    MessageBox.Show("Thêm ca chiếu thành công!");
                    Time_grv.DataSource = CaChieu_BLL.Instance.GetCaChieuTable();
                }
                else
                {
                    MessageBox.Show("Thêm ca chiếu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Ngaychieu_ValueChanged(object sender, EventArgs e)
        {
            string ngaychieu = Ngaychieu.Text;
            Ketthuc.Text = ngaychieu;
        }
    }
}
