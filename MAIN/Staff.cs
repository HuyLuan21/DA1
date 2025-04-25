using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace DA1
{

    public partial class Staff : Form
    {
        Staff_BLL staff_bll = Staff_BLL.Instance;
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Staff_grv.DataSource = staff_bll.GetStaff();
        }

        private void Staff_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                Staff_DTO staff = new Staff_DTO
                {
                    TenNV = Name_tbx.Text.Trim(),
                    NgaySinh = DateTime.Parse(Birth_tbx.Text),
                    DiaChi = Address_tbx.Text.Trim(),
                    SDT = Sdt_tbx.Text.Trim(),
                    CCCD = ID_tbx.Text.Trim()
                };

                string result = staff_bll.InsertStaff(staff);
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
                Staff_DTO staff = new Staff_DTO
                {
                    MaNV = int.Parse(staff_id_tbx.Text),
                    TenNV = Name_tbx.Text.Trim(),
                    NgaySinh = DateTime.Parse(Birth_tbx.Text),
                    DiaChi = Address_tbx.Text.Trim(),
                    SDT = Sdt_tbx.Text.Trim(),
                    CCCD = ID_tbx.Text.Trim()
                };

                string result = staff_bll.UpdateStaff(staff);
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
            DialogResult comfirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirm == DialogResult.Yes)
            {
                try
                {
                    int maNV = int.Parse(staff_id_tbx.Text);
                    string result = staff_bll.DeleteStaff(maNV);
                    if (result == "Success")
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
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
            else
            {
                return;
            }
        }
    }

}
