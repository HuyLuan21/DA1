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
    public partial class Taikhoan : Form
    {
        private string currentPassword = ""; // Lưu mật khẩu hiện tại
        private bool showpass = false;
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = textBox1.Text.Trim();
                string matKhau = textBox3.Text.Trim();
                int loaiTK = comboBox1.SelectedIndex;
                int maNV = Convert.ToInt32(comboBox1.SelectedValue);

                string result = TaiKhoan_BLL.Instance.InsertAccount(tenDangNhap, matKhau, loaiTK, maNV);
                if (result == "Success")
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh data grid
                    TK_grv.DataSource = TaiKhoan_BLL.Instance.GetAccounts();
                    // Clear input fields
                    textBox1.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TK_grv.SelectedRows.Count > 0)
                {
                    string tendangnhap = TK_grv.SelectedRows[0].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        string deleteResult = TaiKhoan_BLL.Instance.DeleteAccount(tendangnhap);
                        if (deleteResult == "Success")
                        {
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh data grid
                            TK_grv.DataSource = TaiKhoan_BLL.Instance.GetAccounts();
                        }
                        else
                        {
                            MessageBox.Show(deleteResult, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TK_grv.SelectedRows.Count > 0)
                {
                    string tenDangNhap = textBox1.Text.Trim();
                    string matKhau = textBox3.Text.Trim();
                    int loaiTK = comboBox1.SelectedIndex;
                    int maNV = Convert.ToInt32(comboBox1.SelectedValue);

                    string result = TaiKhoan_BLL.Instance.UpdateAccount(tenDangNhap, matKhau, loaiTK, maNV);
                    if (result == "Success")
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh data grid
                        TK_grv.DataSource = TaiKhoan_BLL.Instance.GetAccounts();

                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            TK_grv.DataSource = TaiKhoan_BLL.Instance.GetAccounts();
            comboBox1.DataSource = TaiKhoan_BLL.Instance.GetAccountTypes();
     
        }

        private void TK_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            textBox1.Text = TK_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = TK_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = TK_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = TK_grv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TK_grv.DataSource = TaiKhoan_BLL.Instance.SearchAccount(textBox4.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
