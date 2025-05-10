namespace DA1
{
    partial class Taikhoan
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
            this.Name_lbl = new System.Windows.Forms.Label();
            this.staffid_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Staff_grv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.staff_info = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).BeginInit();
            this.staff_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_lbl
            // 
            this.Name_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(6, 92);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(90, 23);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Mã NV:";
            // 
            // staffid_lbl
            // 
            this.staffid_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffid_lbl.Location = new System.Drawing.Point(6, 48);
            this.staffid_lbl.Name = "staffid_lbl";
            this.staffid_lbl.Size = new System.Drawing.Size(114, 23);
            this.staffid_lbl.TabIndex = 2;
            this.staffid_lbl.Text = "User name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Staff_grv);
            this.panel1.Controls.Add(this.staff_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 614);
            this.panel1.TabIndex = 1;
            // 
            // Staff_grv
            // 
            this.Staff_grv.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
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
            this.Staff_grv.Location = new System.Drawing.Point(26, 232);
            this.Staff_grv.Name = "Staff_grv";
            this.Staff_grv.RowHeadersVisible = false;
            this.Staff_grv.RowHeadersWidth = 51;
            this.Staff_grv.RowTemplate.Height = 40;
            this.Staff_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Staff_grv.Size = new System.Drawing.Size(1206, 353);
            this.Staff_grv.TabIndex = 3;
            this.Staff_grv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // staff_info
            // 
            this.staff_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staff_info.Controls.Add(this.remove_btn);
            this.staff_info.Controls.Add(this.edit_btn);
            this.staff_info.Controls.Add(this.add_btn);
            this.staff_info.Controls.Add(this.comboBox1);
            this.staff_info.Controls.Add(this.checkBox1);
            this.staff_info.Controls.Add(this.textBox3);
            this.staff_info.Controls.Add(this.label2);
            this.staff_info.Controls.Add(this.label1);
            this.staff_info.Controls.Add(this.textBox2);
            this.staff_info.Controls.Add(this.textBox1);
            this.staff_info.Controls.Add(this.Name_lbl);
            this.staff_info.Controls.Add(this.staffid_lbl);
            this.staff_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_info.Location = new System.Drawing.Point(26, 29);
            this.staff_info.Name = "staff_info";
            this.staff_info.Size = new System.Drawing.Size(1206, 197);
            this.staff_info.TabIndex = 0;
            this.staff_info.TabStop = false;
            this.staff_info.Text = "Thông tin tài khoản ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(628, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 30);
            this.comboBox1.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(691, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(628, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 30);
            this.textBox3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại tài khoản:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 30);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 16;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(230, 139);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(96, 48);
            this.remove_btn.TabIndex = 47;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(126, 139);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(98, 48);
            this.edit_btn.TabIndex = 46;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(15, 139);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(105, 48);
            this.add_btn.TabIndex = 45;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_grv)).EndInit();
            this.staff_info.ResumeLayout(false);
            this.staff_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label staffid_lbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView Staff_grv;
        private System.Windows.Forms.GroupBox staff_info;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
    }
}