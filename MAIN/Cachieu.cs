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
    public partial class Movies_time : Form
    {
        public Movies_time()
        {
            InitializeComponent();
        }

        private void Movie_id_Click(object sender, EventArgs e)
        {

        }

        private void Name_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_of_movie_Click(object sender, EventArgs e)
        {

        }

        private void Id_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Movies_time_Load(object sender, EventArgs e)
        {
            Time_grv.DataSource = CaChieu_BLL.Instance.GetCaChieuTable();
            Movies_id_cbx.DataSource = Phim_BLL.Instance.GetPhimId();
            Phongchieu_cbx.DataSource = PhongChieu_BLL.Instance.GetPhongChieuNames();
        }

     

        private void Movies_id_cbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Name_tbx.Text = Phim_BLL.Instance.GetPhimbyId(int.Parse(Movies_id_cbx.SelectedValue.ToString()));
        }

        private void Time_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <0) return;
            Cachieu_tbx.Text = Time_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Movies_id_cbx.Text = Time_grv.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}
