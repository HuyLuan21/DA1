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

        private void Datve_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
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
            dataGridView1.DataSource = CaChieu_BLL.Instance.GetCaChieuListByMovie(selectedMovie);
        }
        /// <summary>
        /// sử lý sự kiện bấm đặt vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

