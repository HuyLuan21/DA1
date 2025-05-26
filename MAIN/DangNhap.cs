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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string username = Username_tbx.Text;
            string password = Pass_tbx.Text;
            username = "admin";
            password = "admin123";
            bool result = Dangnhap_BLL.Instance.CheckLogin(username, password);
            bool isAdmin = Dangnhap_BLL.Instance.ismanager(username);
            if (result)
            {
                string tenDangNhap = username.Trim();
                int maNhanVien = Dangnhap_BLL.Instance.GetMaNhanVienByTenDangNhap(tenDangNhap);
                if (maNhanVien > 0)
                {
                    if(isAdmin)
                    {
                        Chonchucnang control = new Chonchucnang(username,maNhanVien);
                        control.ShowDialog();
                        this.Close(); // Đóng form đăng nhập sau khi mở form Chonchucnang
                    }
                    else
                    {
                        LichChieuPhim bkg = new LichChieuPhim(maNhanVien);
                        bkg.ShowDialog();
                        this.Close(); // Đóng form đăng nhập sau khi mở form LichChieuPhim
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên!");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

       
    }
}
