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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            Theloai_grv.DataSource = BLL.TheLoai_BLL.Instance.GetTheLoai();
        }

        private void Theloai_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Id_tbx.Text = Theloai_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = Theloai_grv.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (Theloai_grv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa!");
                return;
            }

            if (string.IsNullOrEmpty(Name_tbx.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại mới!");
                return;
            }

            int maTheLoai = Convert.ToInt32(Theloai_grv.SelectedRows[0].Cells["Mã thể loại"].Value);
            if (BLL.TheLoai_BLL.Instance.UpdateTheLoai(maTheLoai, Name_tbx.Text))
            {
                MessageBox.Show("Sửa thể loại thành công!");
                Theloai_grv.DataSource = BLL.TheLoai_BLL.Instance.GetTheLoai();
                Name_tbx.Clear();
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại!");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (Theloai_grv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maTheLoai = Convert.ToInt32(Theloai_grv.SelectedRows[0].Cells["Mã thể loại"].Value);
                if (BLL.TheLoai_BLL.Instance.DeleteTheLoai(maTheLoai))
                {
                    MessageBox.Show("Xóa thể loại thành công!");
                    Theloai_grv.DataSource = BLL.TheLoai_BLL.Instance.GetTheLoai();
               
                }
                else
                {
                    MessageBox.Show("Xóa thể loại thất bại!");
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_tbx.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                return;
            }

            if (BLL.TheLoai_BLL.Instance.InsertTheLoai(Name_tbx.Text))
            {
                MessageBox.Show("Thêm thể loại thành công!");
                Theloai_grv.DataSource = BLL.TheLoai_BLL.Instance.GetTheLoai();
                Name_tbx.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Theloai_grv.DataSource = BLL.TheLoai_BLL.Instance.SearchTheLoai(textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm thể loại. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
