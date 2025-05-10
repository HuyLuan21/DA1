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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Staff_grv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.ID_tbx = new System.Windows.Forms.TextBox();
            this.Sdt_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.staff_id_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Customer_id_lbl = new System.Windows.Forms.Label();
            this.customer_info = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Náminh = new System.Windows.Forms.NumericUpDown();
            this.Diemtichluy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).BeginInit();
            this.customer_info.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Náminh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diemtichluy)).BeginInit();
            this.SuspendLayout();
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
            this.Staff_grv.Size = new System.Drawing.Size(982, 289);
            this.Staff_grv.TabIndex = 3;
            this.Staff_grv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 206);
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
            this.searchbox.Size = new System.Drawing.Size(196, 30);
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
            // 
            // ID_tbx
            // 
            this.ID_tbx.Location = new System.Drawing.Point(603, 90);
            this.ID_tbx.Name = "ID_tbx";
            this.ID_tbx.Size = new System.Drawing.Size(220, 30);
            this.ID_tbx.TabIndex = 20;
            // 
            // Sdt_tbx
            // 
            this.Sdt_tbx.Location = new System.Drawing.Point(603, 41);
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
            // staff_id_tbx
            // 
            this.staff_id_tbx.Enabled = false;
            this.staff_id_tbx.Location = new System.Drawing.Point(156, 45);
            this.staff_id_tbx.Name = "staff_id_tbx";
            this.staff_id_tbx.Size = new System.Drawing.Size(220, 30);
            this.staff_id_tbx.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 97);
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
            this.label2.Location = new System.Drawing.Point(458, 147);
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
            this.customer_info.Controls.Add(this.Náminh);
            this.customer_info.Controls.Add(this.button1);
            this.customer_info.Controls.Add(this.searchbox);
            this.customer_info.Controls.Add(this.remove_btn);
            this.customer_info.Controls.Add(this.edit_btn);
            this.customer_info.Controls.Add(this.add_btn);
            this.customer_info.Controls.Add(this.ID_tbx);
            this.customer_info.Controls.Add(this.Sdt_tbx);
            this.customer_info.Controls.Add(this.Name_tbx);
            this.customer_info.Controls.Add(this.staff_id_tbx);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Staff_grv);
            this.panel1.Controls.Add(this.customer_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 610);
            this.panel1.TabIndex = 1;
            // 
            // Náminh
            // 
            this.Náminh.Location = new System.Drawing.Point(156, 140);
            this.Náminh.Name = "Náminh";
            this.Náminh.Size = new System.Drawing.Size(120, 30);
            this.Náminh.TabIndex = 28;
            // 
            // Diemtichluy
            // 
            this.Diemtichluy.Location = new System.Drawing.Point(603, 147);
            this.Diemtichluy.Name = "Diemtichluy";
            this.Diemtichluy.Size = new System.Drawing.Size(120, 30);
            this.Diemtichluy.TabIndex = 29;
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
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).EndInit();
            this.customer_info.ResumeLayout(false);
            this.customer_info.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Náminh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diemtichluy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView Staff_grv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox ID_tbx;
        private System.Windows.Forms.TextBox Sdt_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.TextBox staff_id_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Customer_id_lbl;
        private System.Windows.Forms.GroupBox customer_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Diemtichluy;
        private System.Windows.Forms.NumericUpDown Náminh;
    }
}