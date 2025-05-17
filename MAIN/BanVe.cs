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
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
        }

        private void Chonghe_Load(object sender, EventArgs e)
        {
            //thiết lập kích thước form
            this.Size = new System.Drawing.Size(800, 800);  // Kích thước của form
            // Tạo panel chứa các button
            Panel buttonPanel = new Panel();
            buttonPanel.Location = new System.Drawing.Point(400, 20);  // Vị trí của panel
            buttonPanel.Size = new System.Drawing.Size(600, 600);  // Kích thước của panel
            buttonPanel.AutoScroll = true;  // Cho phép cuộn khi các button vượt quá kích thước panel

            // Kích thước mỗi button
            int buttonWidth = 50;
            int buttonHeight = 50;

            // Khoảng cách giữa các button
            int padding = 10;

            // Vòng lặp tạo ma trận 10x10 các button
            for (int i = 0; i < 10; i++)  // Dòng (A, B, C, ...)
            {
                for (int j = 0; j < 10; j++)  // Cột (0-9)
                {
                    // Tạo button mới
                    Button btn = new Button();
                    btn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    btn.Location = new System.Drawing.Point(j * (buttonWidth + padding), i * (buttonHeight + padding));

                    // Đặt tên cho button theo định dạng A0, A1, ..., B0, B1, ...
                    btn.Name = $"{(char)('A' + i)}{j}";  // Tên button sẽ là A0, A1, ..., B0, B1, ...
                    btn.Text = btn.Name;  // Gán tên button vào text của nó

                    // Thêm sự kiện click cho button
                    btn.Click += Button_Click;

                    // Thêm button vào panel thay vì form trực tiếp
                    buttonPanel.Controls.Add(btn);
                }
            }

            // Thêm panel vào form
            this.Controls.Add(buttonPanel);
        }
        

        // Xử lý sự kiện click trên button
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Button {btn.Name} clicked!");
        }
    }
}
   
