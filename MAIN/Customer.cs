using System;
using System.Windows.Forms;
using BLL;
using DTO;
namespace DA1
{
    public partial class Customer : Form
    {
        Customer_BLL customer_bll = Customer_BLL.Instance;
        public Customer()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_DTO customer = new Customer_DTO
                {
                    MaKh = int.Parse(Makh.Text),
                    TenKh = tenkh.Text,
                    Namsinh = int.Parse(namsinh.Text),
                    SDT = sdt.Text,
                    Diemtichluy = int.Parse(diemtichluy.Text),
                    CCCD = CCCD.Text
                };

                string result = customer_bll.UpdateCustomer(customer);
                if (result == "Success")
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    khachhang.DataSource = customer_bll.GetCustomer();
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
            DialogResult comfirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirm == DialogResult.Yes)
            {


                try
                {
                    int maKH = int.Parse(Makh.Text);
                    string result = customer_bll.DeleteCustomer(maKH);
                    if (result == "Success")
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        khachhang.DataSource = customer_bll.GetCustomer();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_DTO customer = new Customer_DTO
                {
                    MaKh = int.Parse(Makh.Text),
                    TenKh = tenkh.Text,
                    Namsinh = int.Parse(namsinh.Text),
                    SDT = sdt.Text,
                    Diemtichluy = int.Parse(diemtichluy.Text),
                    CCCD = CCCD.Text
                };

                string result = customer_bll.InsertCustomer(customer);
                if (result == "Success")
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    khachhang.DataSource = customer_bll.GetCustomer();
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

        private void Customer_Load(object sender, EventArgs e)
        {
            khachhang.DataSource = customer_bll.GetCustomer();
        }

        private void khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Makh.Text = khachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tenkh.Text = khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
            namsinh.Text = khachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
            sdt.Text = khachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
            diemtichluy.Text = khachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
            CCCD.Text = khachhang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void diemtichluy_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
