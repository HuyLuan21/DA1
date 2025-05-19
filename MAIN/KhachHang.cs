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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            KH_grv.DataSource = KhachHang_BLL.Instance.GetCustomer();
            
            // Set limits for NamSinh (birth year)
            NamSinh.Minimum = 1900;
            NamSinh.Maximum = DateTime.Now.Year;
            
            // Set limits for Diemtichluy (loyalty points)
            Diemtichluy.Minimum = 0;
            Diemtichluy.Maximum = 1000000; // Adjust as needed
        }
         
        private void KH_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            KHid_tbx.Text = KH_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = KH_grv.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            NamSinh.Value = Convert.ToInt32(KH_grv.Rows[e.RowIndex].Cells[2].Value);
            Sdt_tbx.Text = KH_grv.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            Diemtichluy.Value = Convert.ToInt32(KH_grv.Rows[e.RowIndex].Cells[4].Value);
            ID_tbx.Text = KH_grv.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string result = KhachHang_BLL.Instance.InsertCustomer(
                    Name_tbx.Text.Trim(),
                    int.Parse(NamSinh.Text),
                    Sdt_tbx.Text.Trim(),
                    ID_tbx.Text.Trim(),
                    int.Parse(Diemtichluy.Text)
                );
                if (result == "Success")
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    KH_grv.DataSource = KhachHang_BLL.Instance.GetCustomer();
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
            try
            {
                if (string.IsNullOrEmpty(KHid_tbx.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string result = KhachHang_BLL.Instance.SoftDeleteCustomer(int.Parse(KHid_tbx.Text));
                    if (result == "Success")
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        KH_grv.DataSource = KhachHang_BLL.Instance.GetCustomer();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
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
                if (string.IsNullOrEmpty(KHid_tbx.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                    return;
                }

                string result = KhachHang_BLL.Instance.UpdateCustomer(
                    int.Parse(KHid_tbx.Text),
                    Name_tbx.Text.Trim(),
                    int.Parse(NamSinh.Text),
                    Sdt_tbx.Text.Trim(),
                    ID_tbx.Text.Trim(),
                    int.Parse(Diemtichluy.Text)
                );

                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    KH_grv.DataSource = KhachHang_BLL.Instance.GetCustomer();
          
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
}
