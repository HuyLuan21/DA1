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
    public partial class BanVe : Form
    {
        private int maCaChieu = 1;
        private int maPhongChieu = 1;
        private List<Button> seatButtons;
       
        private List<string> selectedSeats;
        public BanVe(int maCaChieu, int maPhongChieu)
        {
            InitializeComponent();
            setsoghe();
            this.maCaChieu = maCaChieu;
            this.maPhongChieu = maPhongChieu;
            this.seatButtons = new List<Button>();
            for (int i = 4; i <= 103; i++)
            {
                var btn = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    seatButtons.Add(btn);
                }
            }

                this.selectedSeats = new List<string>();
            LoadSeatStatus();
        }

        public void setsoghe()
        {
            int soHang = 10;
            int soGhe1Hang = 10;
            int start = 4; // button4
            int end = 103; // button103

            for (int i = start; i <= end; i++)
            {
                int hang = (i - start) / soGhe1Hang; // 0 -> 9
                int ghe = (i - start) % soGhe1Hang;  // 0 -> 9
                string text = $"{(char)('A' + hang)}{ghe}";
                var btn = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (btn != null)
                    btn.Text = text;
            }
        }
        private void LoadSeatStatus()
        {
            try
            {
                // Lấy danh sách ghế đã đặt
                var danhSachGhe = Datve_BLL.Instance.GetDanhSachGheDaDat(maCaChieu);

                List<string> daDat = new List<string>();

                foreach (DataRow row in danhSachGhe.Rows)
                {
                    daDat.Add(string.Join("", row["MaGhe"].ToString().Split(' ')));
                }

                for (int i = 0; i < this.seatButtons.Count; i++)
                {
                    Button btn = this.seatButtons[i];
                    if (btn != null)
                    {
                        btn.Enabled = !daDat.Contains(btn.Text.ToString().ToUpper());
                        btn.BackColor = daDat.Contains(btn.Text.ToString().ToUpper()) ? Color.DarkGray : Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trạng thái ghế: " + ex.Message);
            }
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            try
            {
                // Thực hiện đặt vé
                foreach (string maGhe in selectedSeats)
                {
                    // Lấy MaGheNgoi từ MaGhe
                    var danhSachGhe = Datve_BLL.Instance.GetDanhSachGheDaDat(maCaChieu);
                    var row = danhSachGhe.Select($"MaGhe = '{maGhe}'").FirstOrDefault();
                    if (row != null)
                    {
                        int maGheNgoi = Convert.ToInt32(row["MaGheNgoi"]);
                        if (!Datve_BLL.Instance.DatVe(maCaChieu, maGheNgoi))
                        {
                            throw new Exception($"Không thể đặt ghế {maGhe}");
                        }
                    }
                    else
                    {
                        throw new Exception($"Không tìm thấy thông tin ghế {maGhe}");
                    }
                }
                MessageBox.Show("Đặt vé thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi đặt vé: " + ex.Message);
            }
        }

    }
}
