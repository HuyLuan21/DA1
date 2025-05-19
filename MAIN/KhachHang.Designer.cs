namespace DA1
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.ID_tbx = new System.Windows.Forms.TextBox();
            this.Sdt_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.KHid_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Customer_id_lbl = new System.Windows.Forms.Label();
            this.customer_info = new System.Windows.Forms.GroupBox();
            this.Diemtichluy = new System.Windows.Forms.NumericUpDown();
            this.NamSinh = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KH_grv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.customer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diemtichluy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamSinh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KH_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(462, 207);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(261, 30);
            this.searchbox.TabIndex = 26;
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
            this.ID_tbx.Location = new System.Drawing.Point(603, 85);
            this.ID_tbx.Name = "ID_tbx";
            this.ID_tbx.Size = new System.Drawing.Size(220, 30);
            this.ID_tbx.TabIndex = 20;
            // 
            // Sdt_tbx
            // 
            this.Sdt_tbx.Location = new System.Drawing.Point(603, 45);
            this.Sdt_tbx.Name = "Sdt_tbx";
            this.Sdt_tbx.Size = new System.Drawing.Size(220, 30);
            this.Sdt_tbx.TabIndex = 19;
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(156, 85);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(220, 30);
            this.Name_tbx.TabIndex = 17;
            // 
            // KHid_tbx
            // 
            this.KHid_tbx.Location = new System.Drawing.Point(156, 45);
            this.KHid_tbx.Name = "KHid_tbx";
            this.KHid_tbx.Size = new System.Drawing.Size(220, 30);
            this.KHid_tbx.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "CMND/CCCD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Điểm tích lũy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Năm sinh:";
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
            // Customer_id_lbl
            // 
            this.Customer_id_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_id_lbl.Location = new System.Drawing.Point(6, 48);
            this.Customer_id_lbl.Name = "Customer_id_lbl";
            this.Customer_id_lbl.Size = new System.Drawing.Size(130, 23);
            this.Customer_id_lbl.TabIndex = 2;
            this.Customer_id_lbl.Text = "Mã KH:";
            // 
            // customer_info
            // 
            this.customer_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_info.Controls.Add(this.Diemtichluy);
            this.customer_info.Controls.Add(this.NamSinh);
            this.customer_info.Controls.Add(this.button1);
            this.customer_info.Controls.Add(this.searchbox);
            this.customer_info.Controls.Add(this.remove_btn);
            this.customer_info.Controls.Add(this.edit_btn);
            this.customer_info.Controls.Add(this.add_btn);
            this.customer_info.Controls.Add(this.ID_tbx);
            this.customer_info.Controls.Add(this.Sdt_tbx);
            this.customer_info.Controls.Add(this.Name_tbx);
            this.customer_info.Controls.Add(this.KHid_tbx);
            this.customer_info.Controls.Add(this.label4);
            this.customer_info.Controls.Add(this.label3);
            this.customer_info.Controls.Add(this.label2);
            this.customer_info.Controls.Add(this.label1);
            this.customer_info.Controls.Add(this.Name_lbl);
            this.customer_info.Controls.Add(this.Customer_id_lbl);
            this.customer_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_info.Location = new System.Drawing.Point(26, 29);
            this.customer_info.Name = "customer_info";
            this.customer_info.Size = new System.Drawing.Size(982, 261);
            this.customer_info.TabIndex = 0;
            this.customer_info.TabStop = false;
            this.customer_info.Text = "Thông tin khách hàng";
            // 
            // Diemtichluy
            // 
            this.Diemtichluy.Location = new System.Drawing.Point(603, 134);
            this.Diemtichluy.Name = "Diemtichluy";
            this.Diemtichluy.Size = new System.Drawing.Size(120, 30);
            this.Diemtichluy.TabIndex = 29;
            // 
            // NamSinh
            // 
            this.NamSinh.Location = new System.Drawing.Point(156, 134);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(120, 30);
            this.NamSinh.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KH_grv);
            this.panel1.Controls.Add(this.customer_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 610);
            this.panel1.TabIndex = 1;
            // 
            // KH_grv
            // 
            this.KH_grv.AllowCustomTheming = false;
            this.KH_grv.AllowUserToAddRows = false;
            this.KH_grv.AllowUserToDeleteRows = false;
            this.KH_grv.AllowUserToResizeColumns = false;
            this.KH_grv.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            this.KH_grv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.KH_grv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KH_grv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KH_grv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KH_grv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KH_grv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KH_grv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.KH_grv.ColumnHeadersHeight = 40;
            this.KH_grv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.KH_grv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.KH_grv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.KH_grv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.KH_grv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.KH_grv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.KH_grv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.KH_grv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.KH_grv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.KH_grv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KH_grv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.KH_grv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.KH_grv.CurrentTheme.Name = null;
            this.KH_grv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KH_grv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.KH_grv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.KH_grv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.KH_grv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KH_grv.DefaultCellStyle = dataGridViewCellStyle12;
            this.KH_grv.EnableHeadersVisualStyles = false;
            this.KH_grv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.KH_grv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.KH_grv.HeaderBgColor = System.Drawing.Color.Empty;
            this.KH_grv.HeaderForeColor = System.Drawing.Color.White;
            this.KH_grv.Location = new System.Drawing.Point(26, 309);
            this.KH_grv.Name = "KH_grv";
            this.KH_grv.ReadOnly = true;
            this.KH_grv.RowHeadersVisible = false;
            this.KH_grv.RowHeadersWidth = 51;
            this.KH_grv.RowTemplate.Height = 40;
            this.KH_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KH_grv.Size = new System.Drawing.Size(982, 289);
            this.KH_grv.TabIndex = 4;
            this.KH_grv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.KH_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KH_grv_CellClick);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 610);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.customer_info.ResumeLayout(false);
            this.customer_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Diemtichluy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KH_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox ID_tbx;
        private System.Windows.Forms.TextBox Sdt_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.TextBox KHid_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Customer_id_lbl;
        private System.Windows.Forms.GroupBox customer_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Diemtichluy;
        private System.Windows.Forms.NumericUpDown NamSinh;
        private Bunifu.UI.WinForms.BunifuDataGridView KH_grv;
    }
}