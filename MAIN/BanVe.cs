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
        private int maCaChieu;
        private int giaVe;
        private List<Button> seatButtons;
        private List<string> selectedSeats;
       

        public BanVe(int maCaChieu)
        { 
            InitializeComponent();
            Setsoghe();
            this.maCaChieu = maCaChieu;
            this.giaVe = CaChieu_BLL.Instance.GetGiaVe(maCaChieu);
            this.seatButtons = new List<Button>();
            for (int i = 4; i <= 103; i++)
            {
                var btn = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    seatButtons.Add(btn);
                    btn.Click += SeatButton_Click;
                }
            }

            this.selectedSeats = new List<string>();
            LoadSeatStatus();
            UpdateTotalPrice();
        }
        
        public void Setsoghe()
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
                     btn.FlatStyle = FlatStyle.Flat;
            }
        }
        private void LoadSeatStatus()
        {
            try
            {
                // Lấy danh sách ghế đã đặt
                var danhSachGhe = Datve_BLL.Instance.GetDanhSachGhe(maCaChieu);

                List<string> daDat = new List<string>();

                foreach (DataRow row in danhSachGhe.Rows)
                {
                    if(row["TrangThai"].ToString() == "Đã đặt")
                    {
                        daDat.Add(row["MaGhe"].ToString());
                    }
                      
                }

                for (int i = 0; i < this.seatButtons.Count; i++)
                {
                    Button btn = this.seatButtons[i];
                    if (btn != null)
                    {
                        btn.Enabled = !daDat.Contains(btn.Text.ToString().ToUpper());
                        btn.BackColor = daDat.Contains(btn.Text.ToString().ToUpper()) ? Color.FromArgb(189, 189, 189) : Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trạng thái ghế: " + ex.Message);
            }
        }
    
        private void Thanhtoan_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            try
            {
                // Kiểm tra thông tin khách hàng
                if ((textBox4, textBox5, textBox6, textBox7,numericUpDown2).(string.IsNullOrEmpty))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
                    return;
                }
                // Thực hiện đặt vé
                foreach (string maGhe in selectedSeats)
                {
                    // Lấy MaGheNgoi từ MaGhe
                    var danhSachGhe = Datve_BLL.Instance.GetDanhSachGhe(maCaChieu);
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

        private void UpdateTotalPrice()
        {
            int totalPrice = selectedSeats.Count * giaVe;
            textBox1.Text = $"{totalPrice:N0} VNĐ";
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string seatNumber = clickedButton.Text;
                
                if (selectedSeats.Contains(seatNumber))
                {
                    // Nếu ghế đã được chọn thì bỏ chọn
                    selectedSeats.Remove(seatNumber);
                    clickedButton.BackColor = Color.White;
                }
                else
                {
                    // Nếu ghế chưa được chọn thì thêm vào danh sách
                    selectedSeats.Add(seatNumber);
                    clickedButton.BackColor = Color.FromArgb(255, 152, 0);
                }
                UpdateTotalPrice();
            }
        }

        private void Ismember_CheckedChanged(object sender, EventArgs e)
        {
            if (Ismember.Checked == true) {
                ChonKH chonKH = new ChonKH(this);
                chonKH.ShowDialog();
                textBox7.Enabled = true;
                Sudung.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                textBox7.Enabled = false;
                Sudung.Enabled = false;
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
             
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }
        public void SetKhachHangInfo(int maKH, string tenKH, int namsinh, string sdt, int diemtichluy, string cccd)
        {
            textBox4.Text = tenKH;
            textBox5.Text = sdt;
            textBox6.Text = cccd;
            textBox7.Text = diemtichluy.ToString();
            DateTime date = DateTime.Now;
            numericUpDown2.Maximum = date.Year;
            numericUpDown2.Minimum = 1900;
            numericUpDown2.Value = namsinh;

        }
    }
}
