using BLL;
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
    public partial class Ve : Form
    {
        public Ve()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cachieu.DataSource = CaChieu_BLL.Instance.GetCaChieuList();
        }

  

        private void Cachieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
