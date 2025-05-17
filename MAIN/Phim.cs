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
            Movies_grv.DataSource = Phim_BLL.Instance.GetPhimList();
        }

        private void Movies_grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return; // Ignore header row
            Id_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = Movies_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            lenght_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[3].Value.ToString()+ " phút";
            dateTimePicker1.Text = Movies_grv.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = Movies_grv.Rows[e.RowIndex].Cells[5].Value.ToString();
            nation_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[6].Value.ToString();
            director_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[7].Value.ToString();
           age_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[8].Value.ToString();
           proc_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[9].Value.ToString();
            // Clear checked items
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            // Get the selected movie ID
            int selectedMovieId = Convert.ToInt32(Movies_grv.Rows[e.RowIndex].Cells[0].Value);
            // Get the genres for the selected movie
            List<string> movieGenres = Phim_BLL.Instance.GetMovieTypes(selectedMovieId);
            // Check the corresponding items in the checkedListBox
            foreach (string genre in movieGenres)
            {
                int index = checkedListBox1.Items.IndexOf(genre);
                if (index != -1)
                {
                    checkedListBox1.SetItemChecked(index, true);
                }
            }

        }
    }
}
