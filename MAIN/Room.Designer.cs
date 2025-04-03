namespace DA1
{
    partial class Room
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.per_row_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Row_tbx = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.status_tbx = new System.Windows.Forms.TextBox();
            this.seats = new System.Windows.Forms.Label();
            this.Seats_tbx = new System.Windows.Forms.TextBox();
            this.Name_of_room = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.Room_id = new System.Windows.Forms.Label();
            this.Id_tbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.Room_grid_view = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 614);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.per_row_tbx);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Row_tbx);
            this.panel3.Controls.Add(this.Status);
            this.panel3.Controls.Add(this.status_tbx);
            this.panel3.Controls.Add(this.seats);
            this.panel3.Controls.Add(this.Seats_tbx);
            this.panel3.Controls.Add(this.Name_of_room);
            this.panel3.Controls.Add(this.Name_tbx);
            this.panel3.Controls.Add(this.Room_id);
            this.panel3.Controls.Add(this.Id_tbx);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(565, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 614);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số ghế hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // per_row_tbx
            // 
            this.per_row_tbx.Location = new System.Drawing.Point(203, 337);
            this.per_row_tbx.Name = "per_row_tbx";
            this.per_row_tbx.Size = new System.Drawing.Size(305, 22);
            this.per_row_tbx.TabIndex = 10;
            this.per_row_tbx.TextChanged += new System.EventHandler(this.per_row_tbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số hàng ghế:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Row_tbx
            // 
            this.Row_tbx.Location = new System.Drawing.Point(203, 277);
            this.Row_tbx.Name = "Row_tbx";
            this.Row_tbx.Size = new System.Drawing.Size(305, 22);
            this.Row_tbx.TabIndex = 8;
            this.Row_tbx.TextChanged += new System.EventHandler(this.Row_tbx_TextChanged);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Status.Location = new System.Drawing.Point(23, 214);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(106, 23);
            this.Status.TabIndex = 7;
            this.Status.Text = "Tình trạng:";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // status_tbx
            // 
            this.status_tbx.Location = new System.Drawing.Point(203, 216);
            this.status_tbx.Name = "status_tbx";
            this.status_tbx.Size = new System.Drawing.Size(305, 22);
            this.status_tbx.TabIndex = 6;
            this.status_tbx.TextChanged += new System.EventHandler(this.status_tbx_TextChanged);
            // 
            // seats
            // 
            this.seats.AutoSize = true;
            this.seats.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.seats.Location = new System.Drawing.Point(23, 154);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(112, 23);
            this.seats.TabIndex = 5;
            this.seats.Text = "Số chỗ ngồi:";
            this.seats.Click += new System.EventHandler(this.seats_Click);
            // 
            // Seats_tbx
            // 
            this.Seats_tbx.Location = new System.Drawing.Point(203, 156);
            this.Seats_tbx.Name = "Seats_tbx";
            this.Seats_tbx.Size = new System.Drawing.Size(305, 22);
            this.Seats_tbx.TabIndex = 4;
            this.Seats_tbx.TextChanged += new System.EventHandler(this.Seats_tbx_TextChanged);
            // 
            // Name_of_room
            // 
            this.Name_of_room.AutoSize = true;
            this.Name_of_room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Name_of_room.Location = new System.Drawing.Point(23, 102);
            this.Name_of_room.Name = "Name_of_room";
            this.Name_of_room.Size = new System.Drawing.Size(104, 23);
            this.Name_of_room.TabIndex = 3;
            this.Name_of_room.Text = "Tên phòng:";
            this.Name_of_room.Click += new System.EventHandler(this.Name_of_room_Click);
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(203, 104);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(305, 22);
            this.Name_tbx.TabIndex = 2;
            this.Name_tbx.TextChanged += new System.EventHandler(this.Name_tbx_TextChanged);
            // 
            // Room_id
            // 
            this.Room_id.AutoSize = true;
            this.Room_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Room_id.Location = new System.Drawing.Point(23, 51);
            this.Room_id.Name = "Room_id";
            this.Room_id.Size = new System.Drawing.Size(100, 23);
            this.Room_id.TabIndex = 1;
            this.Room_id.Text = "Mã phòng:";
            this.Room_id.Click += new System.EventHandler(this.Room_id_Click);
            // 
            // Id_tbx
            // 
            this.Id_tbx.Location = new System.Drawing.Point(203, 53);
            this.Id_tbx.Name = "Id_tbx";
            this.Id_tbx.Size = new System.Drawing.Size(305, 22);
            this.Id_tbx.TabIndex = 0;
            this.Id_tbx.TextChanged += new System.EventHandler(this.Id_tbx_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.Room_grid_view);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 614);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(233, 12);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(93, 42);
            this.remove_btn.TabIndex = 17;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(123, 12);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 42);
            this.edit_btn.TabIndex = 16;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(10, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 42);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Room_grid_view
            // 
            this.Room_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Room_grid_view.Location = new System.Drawing.Point(0, 113);
            this.Room_grid_view.Name = "Room_grid_view";
            this.Room_grid_view.RowHeadersWidth = 51;
            this.Room_grid_view.RowTemplate.Height = 24;
            this.Room_grid_view.Size = new System.Drawing.Size(565, 501);
            this.Room_grid_view.TabIndex = 0;
            this.Room_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 113);
            this.panel4.TabIndex = 18;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.Text = "Room";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Room_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Room_grid_view;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label Room_id;
        private System.Windows.Forms.TextBox Id_tbx;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox status_tbx;
        private System.Windows.Forms.Label seats;
        private System.Windows.Forms.TextBox Seats_tbx;
        private System.Windows.Forms.Label Name_of_room;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Row_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox per_row_tbx;
        private System.Windows.Forms.Panel panel4;
    }
}