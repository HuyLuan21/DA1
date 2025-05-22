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
            setsoghe();
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
    }
}
