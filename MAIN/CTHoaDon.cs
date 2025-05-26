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
    public partial class CTHoaDon : Form
    {
        private int maHoaDon;
        private int maNhanVien;
        private int maKhachHang;

        public CTHoaDon(int maHoaDon, DateTime NgayBan, decimal TongTien, int maNhanVien, int maKhachHang)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.maKhachHang = maKhachHang;
            MaHD.Text = maHoaDon.ToString();
            NgayLap.Value = NgayBan;
            this.TongTien.Text = TongTien.ToString();
            LoadTenNhanVienVaKhachHang();
            LoadChiTietHoaDon();
        }

        private void LoadChiTietHoaDon()
        {
            Chitiet.DataSource =BLL.HoaDon_BLL.Instance.GetChiTietHoaDon(maHoaDon);
        }

        private void LoadTenNhanVienVaKhachHang()
        {
            var dt = BLL.HoaDon_BLL.Instance.GetTenNhanVienVaKhachHang(maNhanVien, maKhachHang);
            if (dt.Rows.Count > 0)
            {
                textBox3.Text = dt.Rows[0]["TenNhanVien"].ToString();
                textBox2.Text = dt.Rows[0]["TenKhachHang"].ToString();
            }
        }
        private void inhoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
