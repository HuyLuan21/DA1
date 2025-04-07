using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DA1
{

    public partial class Staff : Form
    {
        Staff_BLL staff_bll = Staff_BLL.Instance;
        public Staff()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

       
        private void Staff_Load(object sender, EventArgs e)
        {
            Staff_grv.DataSource = staff_bll.GetStaff();
        }

        private void Staff_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Staff_grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staff_id_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            Birth_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            Address_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[3].Value.ToString();
            Sdt_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID_tbx.Text = Staff_grv.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }

}
