using BLL;
using System;
using System.Windows.Forms;

namespace DA1
{
    public partial class NhanVien : Form
    {
        Nhanvien_BLL staff_bll = Nhanvien_BLL.Instance;
        public NhanVien()
        {
            InitializeComponent();
            // Ẩn cột chọn của DataGridView
            Staff_grv.RowHeadersVisible = false;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Staff_grv.DataSource = staff_bll.GetStaff();
        }

        private void Staff_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row
            staff_id_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            Birth_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            Address_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[3].Value.ToString();
            Sdt_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string result = staff_bll.InsertStaff(
                    Name_tbx.Text.Trim(),
                    DateTime.Parse(Birth_tbx.Text),
                    Address_tbx.Text.Trim(),
                    Sdt_tbx.Text.Trim(),
                    ID_tbx.Text.Trim()
                );

                if (result == "Success")
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    Staff_grv.DataSource = staff_bll.GetStaff();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string result = staff_bll.UpdateStaff(
                    int.Parse(staff_id_tbx.Text),
                    Name_tbx.Text.Trim(),
                    DateTime.Parse(Birth_tbx.Text),
                    Address_tbx.Text.Trim(),
                    Sdt_tbx.Text.Trim(),
                    ID_tbx.Text.Trim()
                );

                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    Staff_grv.DataSource = staff_bll.GetStaff();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn chuyển nhân viên này sang trạng thái nghỉ việc không?\n" +
                "Lưu ý: Thông tin nhân viên vẫn được lưu giữ trong hệ thống.", 
                "Xác nhận",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int maNV = int.Parse(staff_id_tbx.Text);
                    string result = staff_bll.DeleteStaff(maNV);
                    if (result == "Success")
                    {
                        MessageBox.Show("Đã chuyển trạng thái nhân viên sang nghỉ việc!");
                        Staff_grv.DataSource = staff_bll.GetStaff();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = searchbox.Text.Trim();
            var (message, data) = staff_bll.SearchStaff(searchValue);
            
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Staff_grv.DataSource = data;
        }
    }
}