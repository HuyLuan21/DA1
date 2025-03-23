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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Point origiCapsPos;

        private void Form1_Load(object sender, EventArgs e)
        {
            origiCapsPos = Caplocks.Location;
            Caplocks.Location = Showpassword.Location;
            toolTip1.SetToolTip(Showpassword, "Hiện mật khẩu");
            toolTip1.SetToolTip(Caplocks, "Caps Lock đang bật");
            tbxPass.PasswordChar = '\0';    // Mặc định hiển thị password

            Showpassword.Visible = false;   // Ẩn button show password khi khong o trong textbox

            Caplocks.Visible = false;       //an caplocks khi khong o trong textbox va an khi chua bat casplock
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (!Showpassword.ClientRectangle.Contains(Showpassword.PointToClient(Control.MousePosition)))
            {
                Showpassword.Visible = false;
                Caplocks.Location = Showpassword.Location;
            }
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            Showpassword.Visible = true;
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));
            Caplocks.Location = origiCapsPos; // Khi focus, đưa Caplocks về vị trí gốc
            Caplocks.Visible = capsLock;
            if (capsLock)
            {
                Caplocks.BringToFront();
            }
        }
        private bool showpass = false;//bien theo doi trang thai cua showpassword
        private void Showpassword_Click(object sender, EventArgs e)
        {
            showpass = !showpass;
            tbxPass.PasswordChar = showpass ? '\0' : '*';
            Showpassword.Image = showpass ? Properties.Resources.eye_open : Properties.Resources.eye_close; 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                // Nếu người dùng chọn "No", hủy việc đóng form
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra trạng thái Caps Lock
            bool capsLock = (Control.IsKeyLocked(Keys.CapsLock));

            // Hiển thị/ẩn biểu tượng Caps Lock
            if (capsLock)
            {
                Caplocks.Visible = true;
                Caplocks.BringToFront();
            }
            else
            {
                Caplocks.Visible = false;
            }
        }

        private void Loginbtnn_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            this.Hide();
            management.ShowDialog();
            this.Close();
        }
    }
}
