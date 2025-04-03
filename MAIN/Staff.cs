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
using DAL;

namespace DA1
{

    public partial class Staff : Form
    {

        public Staff()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Staff_Load(object sender, EventArgs e)
        {
         
        }

        private void Staff_Load_1(object sender, EventArgs e)
        {
            try
            {
                Staff_BLL staffBLL = new Staff_BLL();
                DataTable data = staffBLL.GetNhanVienList();

                Staff_grv.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Staff_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
