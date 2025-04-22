namespace DA1
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.staff_info = new System.Windows.Forms.GroupBox();
            this.CCCD = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.diemtichluy = new System.Windows.Forms.DomainUpDown();
            this.tenkh = new System.Windows.Forms.TextBox();
            this.Makh = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.namsinh = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Customer_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.khachhang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.staff_info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "CCCD/CMND :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Năm sinh :";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(6, 92);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(90, 23);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Tên KH :";
            // 
            // staff_info
            // 
            this.staff_info.Controls.Add(this.CCCD);
            this.staff_info.Controls.Add(this.sdt);
            this.staff_info.Controls.Add(this.diemtichluy);
            this.staff_info.Controls.Add(this.tenkh);
            this.staff_info.Controls.Add(this.Makh);
            this.staff_info.Controls.Add(this.remove_btn);
            this.staff_info.Controls.Add(this.edit_btn);
            this.staff_info.Controls.Add(this.add_btn);
            this.staff_info.Controls.Add(this.namsinh);
            this.staff_info.Controls.Add(this.label5);
            this.staff_info.Controls.Add(this.label4);
            this.staff_info.Controls.Add(this.label3);
            this.staff_info.Controls.Add(this.label1);
            this.staff_info.Controls.Add(this.Name_lbl);
            this.staff_info.Controls.Add(this.Customer_id);
            this.staff_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_info.Location = new System.Drawing.Point(26, 29);
            this.staff_info.Name = "staff_info";
            this.staff_info.Size = new System.Drawing.Size(1000, 261);
            this.staff_info.TabIndex = 0;
            this.staff_info.TabStop = false;
            this.staff_info.Text = "Thông tin khách hàng";
            // 
            // CCCD
            // 
            this.CCCD.Location = new System.Drawing.Point(620, 85);
            this.CCCD.Name = "CCCD";
            this.CCCD.Size = new System.Drawing.Size(188, 30);
            this.CCCD.TabIndex = 26;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(620, 41);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(188, 30);
            this.sdt.TabIndex = 25;
            // 
            // diemtichluy
            // 
            this.diemtichluy.Location = new System.Drawing.Point(620, 134);
            this.diemtichluy.Name = "diemtichluy";
            this.diemtichluy.Size = new System.Drawing.Size(120, 30);
            this.diemtichluy.TabIndex = 24;
            this.diemtichluy.Text = "0";
            // 
            // tenkh
            // 
            this.tenkh.Location = new System.Drawing.Point(134, 85);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(188, 30);
            this.tenkh.TabIndex = 23;
            // 
            // Makh
            // 
            this.Makh.Location = new System.Drawing.Point(134, 41);
            this.Makh.Name = "Makh";
            this.Makh.Size = new System.Drawing.Size(188, 30);
            this.Makh.TabIndex = 22;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(244, 200);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(93, 42);
            this.remove_btn.TabIndex = 21;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(134, 200);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 42);
            this.edit_btn.TabIndex = 20;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(21, 200);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 42);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // namsinh
            // 
            this.namsinh.Location = new System.Drawing.Point(134, 134);
            this.namsinh.Name = "namsinh";
            this.namsinh.Size = new System.Drawing.Size(120, 30);
            this.namsinh.TabIndex = 18;
            this.namsinh.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điểm tích lũy:";
            // 
            // Customer_id
            // 
            this.Customer_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_id.Location = new System.Drawing.Point(6, 48);
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Size = new System.Drawing.Size(130, 23);
            this.Customer_id.TabIndex = 2;
            this.Customer_id.Text = "Mã KH :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.khachhang);
            this.panel1.Controls.Add(this.staff_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 591);
            this.panel1.TabIndex = 1;
            // 
            // khachhang
            // 
            this.khachhang.AllowCustomTheming = false;
            this.khachhang.AllowUserToAddRows = false;
            this.khachhang.AllowUserToDeleteRows = false;
            this.khachhang.AllowUserToResizeColumns = false;
            this.khachhang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            this.khachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.khachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.khachhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.khachhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.khachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.khachhang.ColumnHeadersHeight = 40;
            this.khachhang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.khachhang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.khachhang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.khachhang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.khachhang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.khachhang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.khachhang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.khachhang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.khachhang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.khachhang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.khachhang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.khachhang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.khachhang.CurrentTheme.Name = null;
            this.khachhang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.khachhang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.khachhang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.khachhang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.khachhang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.khachhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.khachhang.EnableHeadersVisualStyles = false;
            this.khachhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.khachhang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.khachhang.HeaderBgColor = System.Drawing.Color.Empty;
            this.khachhang.HeaderForeColor = System.Drawing.Color.White;
            this.khachhang.Location = new System.Drawing.Point(26, 299);
            this.khachhang.Name = "khachhang";
            this.khachhang.ReadOnly = true;
            this.khachhang.RowHeadersVisible = false;
            this.khachhang.RowHeadersWidth = 51;
            this.khachhang.RowTemplate.Height = 40;
            this.khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.khachhang.Size = new System.Drawing.Size(1000, 289);
            this.khachhang.TabIndex = 4;
            this.khachhang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachhang_CellClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.staff_info.ResumeLayout(false);
            this.staff_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.GroupBox staff_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Customer_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown namsinh;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox CCCD;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.DomainUpDown diemtichluy;
        private System.Windows.Forms.TextBox tenkh;
        private System.Windows.Forms.TextBox Makh;
        private Bunifu.UI.WinForms.BunifuDataGridView khachhang;
    }
}