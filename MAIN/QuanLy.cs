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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

      

       
        private void load_into_panel(object form)
        {
            if (this.content.Controls.Count > 0)
                this.content.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.content.Controls.Add(fh);
            //this.content.Tag = fh;
            fh.Show();
        }
        private void Database_btn_Click(object sender, EventArgs e)
        {
            sidebar.Visible = true; 
            content.Location = new Point(115,84);
        

        }
        private void Staff_btn_Click(object sender, EventArgs e)
        {
          
            sidebar.Visible = false;
            content.Visible = true;
            content.Location = new Point(12, 84);
            load_into_panel(new NhanVien());
        }
        private void Customer_btn_Click(object sender, EventArgs e)
        {
            sidebar.Visible = false;
            content.Visible = true;
            content.Location = new Point(12, 84);
            load_into_panel(new KhachHang());

        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            sidebar.Visible = false;
            content.Visible = true;
            content.Location = new Point(12, 84);
            load_into_panel(new Taikhoan());
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            sidebar.Visible = false;
            content.Visible = true;
            content.Location = new Point(12, 84);
            load_into_panel(new Thongke());
        }



        private void Room_btn_Click(object sender, EventArgs e)
        {
            content.Visible = true;
            load_into_panel(new PhongChieu());
        }

   

        private void Category_btn_Click(object sender, EventArgs e)
        {
            content.Visible = true;
            load_into_panel(new TheLoai());
        }

        private void Movies_btn_Click(object sender, EventArgs e)
        {
            load_into_panel(new Phim());
        }

        private void Time_btn_Click(object sender, EventArgs e)
        {
            content.Visible = true;
            load_into_panel(new Movies_time());
        }

        private void Ticket_btn_Click(object sender, EventArgs e)
        {
            content.Visible = true;
            load_into_panel(new Ve());

        }
        private void Management_Load(object sender, EventArgs e)
        {
            content.Visible = false;
        }

        private void HoaDon_Click(object sender, EventArgs e)
        {
            sidebar.Visible = false;
            content.Visible = true;
            content.Location = new Point(12, 84);
            load_into_panel(new HoaDon());
        }
    }
}
