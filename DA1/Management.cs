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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

     

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void content_Click(object sender, EventArgs e)
        {

        }

        private void Database_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void load_into_panel(object form)
        {
            if (this.content.Controls.Count > 0)
                this.content.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.content.Controls.Add(fh);
            this.content.Tag = fh;
            fh.Show();
        }

        private void Staff_btn_Click(object sender, EventArgs e)
        {
            load_into_panel(new Staff());
        }

        private void show_hide_btn_Click(object sender, EventArgs e)
        {

        }
        private void show_hide_sidebar()
        {
            
        }
    }
}
