using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DA1
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            radioButton1.Checked = true;


        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //var movieList = Phim_BLL.Instance.GetMovieListName();
            //foreach (var movie in movieList)
            //{
            //    comboBox1.Items.Add(movie);
            //}
            //comboBox1.Sorted = true;
            //comboBox1.SelectedIndex = 0;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                Movies.Visible = true;
                Movies.Text = "Phim:";
                comboBox1.Visible = true;
                comboBox1.Location = new Point(115, 37);
                comboBox1.Size = new Size(260, 24);
                // Đổ danh sách phim vào ComboBox
                var phimNamelist = Phim_BLL.Instance.GetMovieListName(); // Hàm lấy danh sách phim từ DB
                comboBox1.DataSource = phimNamelist;
                label2.Visible = true;
                dateTimePicker2.Visible = true;
                button2.Location = new Point(380, 67);
                label1.Text = "Từ";
            }

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Movies.Visible = true;
                Movies.Text = "Đạo diễn:";
                comboBox1.Location = new Point(135, 37);
                comboBox1.Size = new Size(240, 24);
                comboBox1.Visible = true;
                button2.Location = new Point(380, 67);
                label1.Text = "Từ";

                // Đổ danh sách phim vào ComboBox
                var DsDaoDien = Phim_BLL.Instance.GetDirectorName(); // Hàm lấy danh sách phim từ DB
                comboBox1.DataSource = DsDaoDien;
                label2.Visible = true;
                dateTimePicker2.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Movies.Visible = false;
                label1.Text = "Ngày:";
                label2.Visible = false;
                comboBox1.Visible = false;
                dateTimePicker2.Visible = false;
                button2.Location = new Point(250, 67);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (radioButton1.Checked)
            {
                string tenPhim = comboBox1.SelectedItem.ToString();
                DateTime tuNgay = dateTimePicker1.Value.Date;
                DateTime denNgay = dateTimePicker2.Value.Date;
                dt = ThongKe_BLL.Instance.GetStaticByMovie(tenPhim, tuNgay, denNgay);


            }
            else if (radioButton2.Checked)
            {
                string TenTG = comboBox1.SelectedItem.ToString();
                DateTime tuNgay = dateTimePicker1.Value.Date;
                DateTime denNgay = dateTimePicker2.Value.Date;
                dt = ThongKe_BLL.Instance.GetStaticByDirector(TenTG, tuNgay, denNgay);
            }
            else if (radioButton3.Checked)
            {
                DateTime Ngay = dateTimePicker1.Value.Date;
                dt = ThongKe_BLL.Instance.GetStaticByDay(Ngay);
            }

            chart1.Series[0].Points.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                if (radioButton1.Checked)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string xValue = row["Ngay"] != null ? Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy") : "";
                        decimal yValue = Convert.ToDecimal(row["DoanhThu"]);
                        chart1.Series[0].Points.AddXY(xValue, yValue);
                    }
                    chart1.ChartAreas[0].AxisX.Title = "Ngày";
                }
                else if (radioButton2.Checked)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string xValue = row["Ngay"] != null ? Convert.ToDateTime(row["Ngay"]).ToString("yyyy/MM/dd") : "";
                        decimal yValue = Convert.ToDecimal(row["DoanhThu"]);
                        chart1.Series[0].Points.AddXY(xValue, yValue);
                    }
                    chart1.ChartAreas[0].AxisX.Title = "Ngày";
                }
                else if (radioButton3.Checked)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string xValue = row["TenPhim"].ToString();
                        decimal yValue = Convert.ToDecimal(row["DoanhThu"]);
                        chart1.Series[0].Points.AddXY(xValue, yValue);
                    }
                    chart1.ChartAreas[0].AxisX.Title = "Phim";
                }
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.ChartAreas[0].AxisY.Title = "Doanh thu";
                chart1.Titles.Clear();
                chart1.Titles.Add("Thống kê doanh thu");
            }
            else
            {
                chart1.Series[0].Points.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Không có dữ liệu");
            }
        }
    }
}
