using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace DA1
{
    public partial class PhongChieu : Form
    {
        public PhongChieu()
        {
            InitializeComponent();
        }

        private void PhongChieu_Load(object sender, EventArgs e)
        {
            PhongChieu_grv.DataSource = PhongChieu_BLL.Instance.GetPhongChieu();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_tbx.Text) || string.IsNullOrEmpty(TongSoGhe_tbx.Text) ||
                string.IsNullOrEmpty(SoHangGhe_tbx.Text) || string.IsNullOrEmpty(SoGhe1Hang_tbx.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                int tongSoGhe = Convert.ToInt32(TongSoGhe_tbx.Text);
                int soHangGhe = Convert.ToInt32(SoHangGhe_tbx.Text);
                int soGhe1Hang = Convert.ToInt32(SoGhe1Hang_tbx.Text);

                string message;
                if (PhongChieu_BLL.Instance.InsertPhongChieu(Name_tbx.Text, tongSoGhe, soHangGhe, soGhe1Hang, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongChieu_grv.DataSource = PhongChieu_BLL.Instance.GetPhongChieu();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số ghế!");
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (PhongChieu_grv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu cần sửa!");
                return;
            }

            if (string.IsNullOrEmpty(Name_tbx.Text) || string.IsNullOrEmpty(TongSoGhe_tbx.Text) ||
                string.IsNullOrEmpty(SoHangGhe_tbx.Text) || string.IsNullOrEmpty(SoGhe1Hang_tbx.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                int maPhongChieu = Convert.ToInt32(Id_tbx.Text);
                int tongSoGhe = Convert.ToInt32(TongSoGhe_tbx.Text);
                int soHangGhe = Convert.ToInt32(SoHangGhe_tbx.Text);
                int soGhe1Hang = Convert.ToInt32(SoGhe1Hang_tbx.Text);

                string message;
                if (PhongChieu_BLL.Instance.UpdatePhongChieu(maPhongChieu, Name_tbx.Text, tongSoGhe, soHangGhe, soGhe1Hang, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongChieu_grv.DataSource = PhongChieu_BLL.Instance.GetPhongChieu();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số ghế!");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (PhongChieu_grv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này?", "Xác nhận", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maPhongChieu = Convert.ToInt32(Id_tbx.Text);
                if (PhongChieu_BLL.Instance.DeletePhongChieu(maPhongChieu))
                {
                    MessageBox.Show("Xóa phòng chiếu thành công!");
                    PhongChieu_grv.DataSource = PhongChieu_BLL.Instance.GetPhongChieu();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa phòng chiếu thất bại!");
                }
            }
        }

        private void ClearInputs()
        {
            Id_tbx.Clear();
            Name_tbx.Clear();
            TongSoGhe_tbx.Clear();
            SoHangGhe_tbx.Clear();
            SoGhe1Hang_tbx.Clear();
        }

        private void PhongChieu_grv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Id_tbx.Text = PhongChieu_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = PhongChieu_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            TongSoGhe_tbx.Text = PhongChieu_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            SoHangGhe_tbx.Text = PhongChieu_grv.Rows[e.RowIndex].Cells[3].Value.ToString();
            SoGhe1Hang_tbx.Text = PhongChieu_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PhongChieu_grv.DataSource = PhongChieu_BLL.Instance.SearchPhongChieu(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
