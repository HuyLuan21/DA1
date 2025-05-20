namespace DA1
{
    partial class TheLoai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Theloai_grv = new System.Windows.Forms.DataGridView();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.Cate_name = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.Cate_id = new System.Windows.Forms.Label();
            this.Id_tbx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Theloai_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.Cate_name);
            this.panel1.Controls.Add(this.remove_btn);
            this.panel1.Controls.Add(this.Name_tbx);
            this.panel1.Controls.Add(this.Cate_id);
            this.panel1.Controls.Add(this.Id_tbx);
            this.panel1.Controls.Add(this.Theloai_grv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 729);
            this.panel1.TabIndex = 0;
            // 
            // Theloai_grv
            // 
            this.Theloai_grv.AllowUserToAddRows = false;
            this.Theloai_grv.AllowUserToDeleteRows = false;
            this.Theloai_grv.AllowUserToResizeColumns = false;
            this.Theloai_grv.AllowUserToResizeRows = false;
            this.Theloai_grv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Theloai_grv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Theloai_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Theloai_grv.Location = new System.Drawing.Point(14, 14);
            this.Theloai_grv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Theloai_grv.Name = "Theloai_grv";
            this.Theloai_grv.ReadOnly = true;
            this.Theloai_grv.RowHeadersVisible = false;
            this.Theloai_grv.RowHeadersWidth = 51;
            this.Theloai_grv.RowTemplate.Height = 24;
            this.Theloai_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Theloai_grv.Size = new System.Drawing.Size(1378, 425);
            this.Theloai_grv.TabIndex = 29;
            this.Theloai_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Theloai_grv_CellClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(150, 593);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(105, 50);
            this.edit_btn.TabIndex = 27;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(17, 593);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(105, 50);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(289, 593);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(105, 50);
            this.remove_btn.TabIndex = 28;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Cate_name
            // 
            this.Cate_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cate_name.AutoSize = true;
            this.Cate_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Cate_name.Location = new System.Drawing.Point(12, 525);
            this.Cate_name.Name = "Cate_name";
            this.Cate_name.Size = new System.Drawing.Size(116, 23);
            this.Cate_name.TabIndex = 25;
            this.Cate_name.Text = "Tên thể loại:";
            // 
            // Name_tbx
            // 
            this.Name_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Name_tbx.Location = new System.Drawing.Point(192, 525);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(355, 27);
            this.Name_tbx.TabIndex = 24;
            // 
            // Cate_id
            // 
            this.Cate_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cate_id.AutoSize = true;
            this.Cate_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Cate_id.Location = new System.Drawing.Point(12, 464);
            this.Cate_id.Name = "Cate_id";
            this.Cate_id.Size = new System.Drawing.Size(111, 23);
            this.Cate_id.TabIndex = 23;
            this.Cate_id.Text = "Mã Thể loại";
            // 
            // Id_tbx
            // 
            this.Id_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Id_tbx.Location = new System.Drawing.Point(192, 464);
            this.Id_tbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id_tbx.Name = "Id_tbx";
            this.Id_tbx.Size = new System.Drawing.Size(355, 27);
            this.Id_tbx.TabIndex = 22;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 729);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TheLoai";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Theloai_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Theloai_grv;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Label Cate_name;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label Cate_id;
        private System.Windows.Forms.TextBox Id_tbx;
    }
}