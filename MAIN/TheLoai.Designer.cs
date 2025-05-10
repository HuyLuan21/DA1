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
            this.Cate_grid_view = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.Cate_name = new System.Windows.Forms.Label();
            this.Cate_id = new System.Windows.Forms.Label();
            this.Id_tbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cate_grid_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cate_grid_view
            // 
            this.Cate_grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cate_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cate_grid_view.Location = new System.Drawing.Point(0, 75);
            this.Cate_grid_view.Name = "Cate_grid_view";
            this.Cate_grid_view.RowHeadersWidth = 51;
            this.Cate_grid_view.RowTemplate.Height = 24;
            this.Cate_grid_view.Size = new System.Drawing.Size(790, 539);
            this.Cate_grid_view.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.Cate_grid_view);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 614);
            this.panel2.TabIndex = 0;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(234, 12);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(93, 42);
            this.remove_btn.TabIndex = 20;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(124, 12);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 42);
            this.edit_btn.TabIndex = 19;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(11, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 42);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // Cate_name
            // 
            this.Cate_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cate_name.AutoSize = true;
            this.Cate_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Cate_name.Location = new System.Drawing.Point(24, 126);
            this.Cate_name.Name = "Cate_name";
            this.Cate_name.Size = new System.Drawing.Size(116, 23);
            this.Cate_name.TabIndex = 3;
            this.Cate_name.Text = "Tên thể loại:";
            // 
            // Cate_id
            // 
            this.Cate_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cate_id.AutoSize = true;
            this.Cate_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Cate_id.Location = new System.Drawing.Point(24, 75);
            this.Cate_id.Name = "Cate_id";
            this.Cate_id.Size = new System.Drawing.Size(111, 23);
            this.Cate_id.TabIndex = 1;
            this.Cate_id.Text = "Mã Thể loại";
            this.Cate_id.Click += new System.EventHandler(this.Cate_id_Click);
            // 
            // Id_tbx
            // 
            this.Id_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Id_tbx.Location = new System.Drawing.Point(184, 75);
            this.Id_tbx.Name = "Id_tbx";
            this.Id_tbx.Size = new System.Drawing.Size(316, 22);
            this.Id_tbx.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 614);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Cate_name);
            this.panel3.Controls.Add(this.Name_tbx);
            this.panel3.Controls.Add(this.Cate_id);
            this.panel3.Controls.Add(this.Id_tbx);
            this.panel3.Location = new System.Drawing.Point(799, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 614);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Name_tbx
            // 
            this.Name_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Name_tbx.Location = new System.Drawing.Point(184, 126);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(316, 22);
            this.Name_tbx.TabIndex = 2;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheLoai";
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Cate_grid_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Cate_grid_view;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Cate_name;
        private System.Windows.Forms.Label Cate_id;
        private System.Windows.Forms.TextBox Id_tbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
    }
}