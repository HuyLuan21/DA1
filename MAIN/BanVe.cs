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
        private int lastPrice = 0;

        private List<Button> seatButtons;
        private List<string> selectedSeats;
        private int discount = 0;
        private int usedPoints = 0;
        private int maKH = 0; // Thêm biến để lưu mã khách hàng

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
                diemTichLuy.Enabled = false;
                CongThem.Enabled = false;
                Sudung.Enabled = false;

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

                for (int i = 0; i < seatButtons.Count; i++)
                {
                    Button btn = seatButtons[i];
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
                if (string.IsNullOrEmpty(TenKH.Text) || string.IsNullOrEmpty(Sdt.Text) || 
                    string.IsNullOrEmpty(Id.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
                    return;
                }

                // Xử lý thông tin khách hàng
                if (Ismember.Checked)
                {
                    // Cập nhật khách hàng thành viên
                    int diemMoi = int.Parse(diemTichLuy.Text) + (int)CongThem.Value - usedPoints;
                    string result = KhachHang_BLL.Instance.UpdateCustomer(
                        maKH,
                        TenKH.Text.Trim(),
                        (int)NamSinh.Value,
                        Sdt.Text.Trim(),
                        Id.Text.Trim(),
                        diemMoi
                    );

                    if (result != "Success")
                    {
                        MessageBox.Show(result);
                        return;
                    }
                }
                else
                {
                    // Thêm khách hàng mới
                    string result = KhachHang_BLL.Instance.InsertCustomer(
                        TenKH.Text.Trim(),
                        (int)NamSinh.Value,
                        Sdt.Text.Trim(),
                        Id.Text.Trim(),
                        (int)CongThem.Value
                    );

                    if (result != "Success")
                    {
                        MessageBox.Show(result);
                        return;
                    }
                }

                // Thực hiện đặt vé và lưu chi tiết hóa đơn
                //luu thong tin ve vao bang ve
                foreach (string maGhe in selectedSeats)
                {
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
                //viet hoa don cho khach hang
                HoaDon_BLL.Instance.InsertHoaDon(maKH, maCaChieu, lastPrice);
                //viet chi tiet hoa don cho khach hang
                foreach (string maGhe in selectedSeats)
                {
                    var danhSachGhe = Datve_BLL.Instance.GetDanhSachGhe(maCaChieu);
                    var row = danhSachGhe.Select($"MaGhe = '{maGhe}'").FirstOrDefault();
                    if (row != null)
                    {
                        int maGheNgoi = Convert.ToInt32(row["MaGheNgoi"]);
                        HoaDon_BLL.Instance.InsertChiTietHoaDon(maCaChieu, maGheNgoi, giaVe);
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

        public void UpdateGia(int giamGia, int diemSudung)
        {
            discount = giamGia;
            usedPoints = diemSudung;
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int pluspoint = selectedSeats.Count * 10;
            int totalPrice = selectedSeats.Count * giaVe;
            textBox1.Text = $"{totalPrice:N0} VNĐ";
            textBox3.Text = $"{discount:N0} VNĐ";
            lastPrice = totalPrice - discount;
            textBox2.Text = $"{lastPrice:N0} VNĐ";
            CongThem.Value = pluspoint;
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
                diemTichLuy.Enabled = false;
                Sudung.Enabled = true;
                TenKH.Enabled = false;
                Sdt.Enabled = false;
                Id.Enabled = false;
                NamSinh.Enabled = false;
               
            }
            else
            {
                TenKH.Text = "";
                Sdt.Text = "";
                Id.Text = "";
                diemTichLuy.Text = "";
                diemTichLuy.Enabled = false;
                Sudung.Enabled = false;
                TenKH.Enabled = true;
                Sdt.Enabled = true;
                Id.Enabled = true;
                NamSinh.Enabled = true;
            }
        }
        public void SetKhachHangInfo(int maKH, string tenKH, int namsinh, string sdt, int diemtichluy, string cccd)
        {
            this.maKH = maKH; // Lưu mã khách hàng
            TenKH.Text = tenKH;
            Sdt.Text = sdt;
            Id.Text = cccd;
            diemTichLuy.Text = diemtichluy.ToString();
            DateTime date = DateTime.Now;
            NamSinh.Maximum = date.Year;
            NamSinh.Minimum = 1900;
            NamSinh.Value = namsinh;
        }

        private void Sudung_Click(object sender, EventArgs e)
        {
            int currentPoints = int.Parse(diemTichLuy.Text);

            NhapDiem input = new NhapDiem(currentPoints, this);
            input.ShowDialog();
        }
    }
}
