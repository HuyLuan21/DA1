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
        Dangnhap_BLL dn_bll = Dangnhap_BLL.Instance;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username_tbx.Text;
            string password = Pass_tbx.Text;
            bool isAdmin = dn_bll.ismanager(username);
            bool result = dn_bll.CheckLogin(username, password);
            if (result)
            {
                if(isAdmin)
                {
                    Chonchucnang control = new Chonchucnang();
                    control.ShowDialog();
                }
                else
                {
                    Datve bkg = new Datve();
                    bkg.ShowDialog();
                }
              
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
