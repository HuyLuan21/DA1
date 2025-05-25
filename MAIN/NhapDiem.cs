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
    public partial class NhapDiem : Form
    {
        private int currentPoints;
        private BanVe banVeForm;

        public NhapDiem(int points, BanVe banVe)
        {
            InitializeComponent();
            currentPoints = points;
            banVeForm = banVe;
            label2.Text = $"Bạn đang có: {currentPoints} điểm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int diemsudung = int.Parse(textBox1.Text);
                if (diemsudung <= 0)
                {
                    MessageBox.Show("Số điểm sử dụng phải lớn hơn 0!");
                    return;
                }
                if (diemsudung > currentPoints)
                {
                    MessageBox.Show("Số điểm sử dụng không được vượt quá số điểm hiện có!");
                    return;
                }
                // Tính giảm giá: mỗi 10 điểm giảm 1000 VND
                int giamGia = (diemsudung * 1000) / 10;
                banVeForm.UpdateGia(giamGia, diemsudung);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số điểm hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
