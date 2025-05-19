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
    public partial class Chonchucnang : Form
    {
        private string username;
        public Chonchucnang(string username)
        {
            InitializeComponent();
            this.username = username;
            label2.Text = "Tên tài khoản: " + username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy mng = new QuanLy();
            mng.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LichChieuPhim bkg = new LichChieuPhim();
            bkg.ShowDialog();
        }
    }
}
