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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var movieList = Phim_BLL.Instance.GetMovieListName();
            foreach (var movie in movieList)
            {
                comboBox1.Items.Add(movie);
            }
            comboBox1.Sorted = true;
            comboBox1.SelectedIndex = 0;
        }
    }
}
