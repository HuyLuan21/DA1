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
    public partial class ChonKH : Form
    {
        private BanVe banVeForm;

        public ChonKH(BanVe banVe)
        {
            InitializeComponent();
            banVeForm = banVe;
            KH_grv.DataSource = KhachHang_BLL.Instance.GetCustomer();
        }

        private void KH_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = KH_grv.Rows[e.RowIndex];
                int maKH = Convert.ToInt32(row.Cells[0].Value);
                string tenKH = row.Cells[1].Value.ToString();
                int namsinh = Convert.ToInt32 (row.Cells[2].Value);
                string sdt = row.Cells[3].Value.ToString();
                int diemtichluy = Convert.ToInt32(row.Cells[4].Value);
                string cccd = row.Cells[5].Value.ToString();

                // Truyền dữ liệu về form BanVe
                banVeForm.SetKhachHangInfo(maKH, tenKH,namsinh, sdt,diemtichluy,cccd);
                this.Close();
            }
        }
    }
}
