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
            richTextBox1.Text = Movies_grv.Rows[e.RowIndex].Cells[2].Value.ToString();
            lenght_tbx.Text = Movies_grv.Rows[e.RowIndex].Cells[3].Value.ToString();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedGenres = new List<string>();
                foreach (object item in checkedListBox1.CheckedItems)
                {
                    selectedGenres.Add(item.ToString());
                }

                string result = Phim_BLL.Instance.InsertPhim(
                    Name_tbx.Text.Trim(),
                    richTextBox1.Text.Trim(),
                    int.Parse(lenght_tbx.Text),
                    dateTimePicker1.Value,
                    dateTimePicker2.Value,
                    nation_tbx.Text.Trim(),
                    director_tbx.Text.Trim(),
                    int.Parse(age_tbx.Text),
                    int.Parse(proc_tbx.Text),
                    selectedGenres
                );

                if (result == "Success")
                {
                    MessageBox.Show("Thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Phim_Load(sender, e); // Refresh the movie list
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Id_tbx.Text))
                {
                    List<string> selectedGenres = new List<string>();
                    foreach (object item in checkedListBox1.CheckedItems)
                    {
                        selectedGenres.Add(item.ToString());
                    }

                    string result = Phim_BLL.Instance.UpdatePhim(
                        int.Parse(Id_tbx.Text),
                        Name_tbx.Text.Trim(),
                        richTextBox1.Text.Trim(),
                        int.Parse(lenght_tbx.Text),
                        dateTimePicker1.Value,
                        dateTimePicker2.Value,
                        nation_tbx.Text.Trim(),
                        director_tbx.Text.Trim(),
                        int.Parse(age_tbx.Text),
                        int.Parse(proc_tbx.Text),
                        selectedGenres
                    );

                    if (result == "Success")
                    {
                        MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Phim_Load(sender, e); // Refresh the movie list
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phim cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Id_tbx.Text))
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string result = Phim_BLL.Instance.DeletePhim(int.Parse(Id_tbx.Text));
                        if (result == "Success")
                        {
                            MessageBox.Show("Xóa phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Phim_Load(sender, e); // Refresh the movie list
                        }
                        else
                        {
                            MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phim cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Movies_grv.DataSource = Phim_BLL.Instance.SearchPhim(search_tbx.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

      
