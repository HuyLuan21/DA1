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
    public partial class LichChieuPhim : Form
    {
       
        public LichChieuPhim()
        {
            InitializeComponent();
        }
        int maCaChieu = 1 ;
        int maPhongChieu = 1 ;
        private void Datve_Load(object sender, EventArgs e)
        {
         
            var movieList = Phim_BLL.Instance.GetMovieListName();
            foreach (var movie in movieList)
            {
                comboBox1.Items.Add(movie);
            }
            comboBox1.Sorted = true;

            comboBox1.SelectedIndex = 0;


            dataGridView1.DataSource = CaChieu_BLL.Instance.GetCaChieuList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cap nhat datagrid view theo combo box
            string selectedMovie = comboBox1.SelectedItem.ToString();
            if (selectedMovie == "*")
            {
                dataGridView1.DataSource = CaChieu_BLL.Instance.GetCaChieuList();
                return;
            }
            dataGridView1.DataSource = CaChieu_BLL.Instance.GetCaChieuListByMovie(selectedMovie);
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            BanVe booking = new BanVe(maCaChieu);

            booking.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maCaChieu = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

