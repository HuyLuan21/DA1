namespace DA1
{
    partial class NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.staff_info = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.Birth_tbx = new System.Windows.Forms.DateTimePicker();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.ID_tbx = new System.Windows.Forms.TextBox();
            this.Sdt_tbx = new System.Windows.Forms.TextBox();
            this.Address_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.staff_id_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.staffid_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staff_grv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.staff_info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_info
            // 
            this.staff_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staff_info.Controls.Add(this.button1);
            this.staff_info.Controls.Add(this.searchbox);
            this.staff_info.Controls.Add(this.Birth_tbx);
            this.staff_info.Controls.Add(this.remove_btn);
            this.staff_info.Controls.Add(this.edit_btn);
            this.staff_info.Controls.Add(this.add_btn);
            this.staff_info.Controls.Add(this.ID_tbx);
            this.staff_info.Controls.Add(this.Sdt_tbx);
            this.staff_info.Controls.Add(this.Address_tbx);
            this.staff_info.Controls.Add(this.Name_tbx);
            this.staff_info.Controls.Add(this.staff_id_tbx);
            this.staff_info.Controls.Add(this.label4);
            this.staff_info.Controls.Add(this.label3);
            this.staff_info.Controls.Add(this.label2);
            this.staff_info.Controls.Add(this.label1);
            this.staff_info.Controls.Add(this.Name_lbl);
            this.staff_info.Controls.Add(this.staffid_lbl);
            this.staff_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_info.Location = new System.Drawing.Point(26, 29);
            this.staff_info.Name = "staff_info";
            this.staff_info.Size = new System.Drawing.Size(1000, 261);
            this.staff_info.TabIndex = 0;
            this.staff_info.TabStop = false;
            this.staff_info.Text = "Thông tin nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(462, 207);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(196, 30);
            this.searchbox.TabIndex = 26;
            // 
            // Birth_tbx
            // 
            this.Birth_tbx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birth_tbx.Location = new System.Drawing.Point(156, 136);
            this.Birth_tbx.Name = "Birth_tbx";
            this.Birth_tbx.Size = new System.Drawing.Size(220, 30);
            this.Birth_tbx.TabIndex = 25;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(240, 200);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(93, 42);
            this.remove_btn.TabIndex = 24;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(130, 200);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 42);
            this.edit_btn.TabIndex = 23;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(17, 200);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 42);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ID_tbx
            // 
            this.ID_tbx.Location = new System.Drawing.Point(603, 134);
            this.ID_tbx.Name = "ID_tbx";
            this.ID_tbx.Size = new System.Drawing.Size(220, 30);
            this.ID_tbx.TabIndex = 20;
            // 
            // Sdt_tbx
            // 
            this.Sdt_tbx.Location = new System.Drawing.Point(603, 85);
            this.Sdt_tbx.Name = "Sdt_tbx";
            this.Sdt_tbx.Size = new System.Drawing.Size(220, 30);
            this.Sdt_tbx.TabIndex = 19;
            // 
            // Address_tbx
            // 
            this.Address_tbx.Location = new System.Drawing.Point(603, 41);
            this.Address_tbx.Name = "Address_tbx";
            this.Address_tbx.Size = new System.Drawing.Size(220, 30);
            this.Address_tbx.TabIndex = 18;
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(156, 85);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(220, 30);
            this.Name_tbx.TabIndex = 17;
            // 
            // staff_id_tbx
            // 
            this.staff_id_tbx.Location = new System.Drawing.Point(156, 45);
            this.staff_id_tbx.Name = "staff_id_tbx";
            this.staff_id_tbx.Size = new System.Drawing.Size(220, 30);
            this.staff_id_tbx.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "CMND/CCCD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày sinh :";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(6, 92);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(90, 23);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Họ tên :";
            // 
            // staffid_lbl
            // 
            this.staffid_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffid_lbl.Location = new System.Drawing.Point(6, 48);
            this.staffid_lbl.Name = "staffid_lbl";
            this.staffid_lbl.Size = new System.Drawing.Size(130, 23);
            this.staffid_lbl.TabIndex = 2;
            this.staffid_lbl.Text = "Mã nhân viên :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.staff_info);
            this.panel1.Controls.Add(this.Staff_grv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 591);
            this.panel1.TabIndex = 0;
            // 
            // Staff_grv
            // 
            this.Staff_grv.AllowCustomTheming = false;
            this.Staff_grv.AllowUserToAddRows = false;
            this.Staff_grv.AllowUserToDeleteRows = false;
            this.Staff_grv.AllowUserToResizeColumns = false;
            this.Staff_grv.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Staff_grv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Staff_grv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Staff_grv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Staff_grv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staff_grv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Staff_grv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Staff_grv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Staff_grv.ColumnHeadersHeight = 40;
            this.Staff_grv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Staff_grv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Staff_grv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Staff_grv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Staff_grv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Staff_grv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Staff_grv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Staff_grv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Staff_grv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Staff_grv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Staff_grv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Staff_grv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Staff_grv.CurrentTheme.Name = null;
            this.Staff_grv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Staff_grv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Staff_grv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Staff_grv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Staff_grv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Staff_grv.DefaultCellStyle = dataGridViewCellStyle6;
            this.Staff_grv.EnableHeadersVisualStyles = false;
            this.Staff_grv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Staff_grv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Staff_grv.HeaderBgColor = System.Drawing.Color.Empty;
            this.Staff_grv.HeaderForeColor = System.Drawing.Color.White;
            this.Staff_grv.Location = new System.Drawing.Point(26, 296);
            this.Staff_grv.Name = "Staff_grv";
            this.Staff_grv.ReadOnly = true;
            this.Staff_grv.RowHeadersVisible = false;
            this.Staff_grv.RowHeadersWidth = 51;
            this.Staff_grv.RowTemplate.Height = 40;
            this.Staff_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Staff_grv.Size = new System.Drawing.Size(1000, 289);
            this.Staff_grv.TabIndex = 3;
            this.Staff_grv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Staff_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_grv_CellClick);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Staff_Load);
            this.staff_info.ResumeLayout(false);
            this.staff_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox staff_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label staffid_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox staff_id_tbx;
        private System.Windows.Forms.TextBox ID_tbx;
        private System.Windows.Forms.TextBox Sdt_tbx;
        private System.Windows.Forms.TextBox Address_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DateTimePicker Birth_tbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchbox;
        private Bunifu.UI.WinForms.BunifuDataGridView Staff_grv;
    }
}