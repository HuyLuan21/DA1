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
            bool result = Dangnhap_BLL.Instance.CheckLogin(username, password);
            bool isAdmin = Dangnhap_BLL.Instance.ismanager(username);
            if (result)
            {
                if(isAdmin)
                {
                    Chonchucnang control = new Chonchucnang(username);
                    control.ShowDialog();
                }
                else
                {
                    LichChieuPhim bkg = new LichChieuPhim();
                    bkg.ShowDialog();
                }
              
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                // Nếu người dùng chọn "No", hủy việc đóng form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
