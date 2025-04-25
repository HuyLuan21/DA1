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
    public partial class Controlselect : Form
    {
        public Controlselect()
        {
            InitializeComponent();
        }
        private Point origiCapsPos;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Management mng = new Management();
            mng.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking bkg = new Booking();
            bkg.ShowDialog();
        }
    }
}
