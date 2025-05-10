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
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Movie_id_Click(object sender, EventArgs e)
        {

        }

        private void Phim_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            List<string> genres = TheLoai_BLL.Instance.GetTheLoaiList();
            foreach (string genre in genres)
            {
                checkedListBox1.Items.Add(genre);
            }
        }

    }
}
