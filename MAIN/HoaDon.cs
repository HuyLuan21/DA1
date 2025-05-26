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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            HoaDon_grv.DataSource = BLL.HoaDon_BLL.Instance.GetTable();
            button1.Enabled = false; 
        }

        private void HoaDon_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; // Không có hàng nào được chọn
            }
           
            MaHD_tbx.Text = HoaDon_grv.Rows[e.RowIndex].Cells["Mã hóa đơn"].Value.ToString();
            MaKH_tbx.Text = HoaDon_grv.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString();
            TongTien_tbx.Text = HoaDon_grv.Rows[e.RowIndex].Cells["Tổng tiền"].Value.ToString();
            MaNV_tbx.Text = HoaDon_grv.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            NgayLap.Value = DateTime.Parse(HoaDon_grv.Rows[e.RowIndex].Cells["Ngày bán"].Value.ToString());
            button1.Enabled = true; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTHoaDon cthd = new CTHoaDon();
            cthd.ShowDialog();
        }
    }
}
