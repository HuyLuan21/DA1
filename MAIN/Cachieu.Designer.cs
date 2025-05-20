namespace DA1
{
    partial class Movies_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies_time));
            this.Name_of_movie = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.Movie_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Movies_id_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GioKT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ketthuc = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.GiaVe = new System.Windows.Forms.TextBox();
            this.Phongchieu_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Giochieu = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.Label();
            this.Day_on_air = new System.Windows.Forms.Label();
            this.Ngaychieu = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Room = new System.Windows.Forms.Label();
            this.Time_id = new System.Windows.Forms.Label();
            this.Cachieu_tbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Time_grv = new System.Windows.Forms.DataGridView();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_of_movie
            // 
            this.Name_of_movie.AutoSize = true;
            this.Name_of_movie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Name_of_movie.Location = new System.Drawing.Point(841, 108);
            this.Name_of_movie.Name = "Name_of_movie";
            this.Name_of_movie.Size = new System.Drawing.Size(59, 23);
            this.Name_of_movie.TabIndex = 22;
            this.Name_of_movie.Text = "Phim:";
            this.Name_of_movie.Click += new System.EventHandler(this.Name_of_movie_Click);
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(989, 108);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(218, 22);
            this.Name_tbx.TabIndex = 21;
            this.Name_tbx.TextChanged += new System.EventHandler(this.Name_tbx_TextChanged);
            // 
            // Movie_id
            // 
            this.Movie_id.AutoSize = true;
            this.Movie_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Movie_id.Location = new System.Drawing.Point(841, 73);
            this.Movie_id.Name = "Movie_id";
            this.Movie_id.Size = new System.Drawing.Size(85, 23);
            this.Movie_id.TabIndex = 20;
            this.Movie_id.Text = "Mã Phim";
            this.Movie_id.Click += new System.EventHandler(this.Movie_id_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Movies_id_cbx);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GiaVe);
            this.panel1.Controls.Add(this.Phongchieu_cbx);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Room);
            this.panel1.Controls.Add(this.Time_id);
            this.panel1.Controls.Add(this.Cachieu_tbx);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Name_of_movie);
            this.panel1.Controls.Add(this.Name_tbx);
            this.panel1.Controls.Add(this.Movie_id);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 567);
            this.panel1.TabIndex = 1;
            // 
            // Movies_id_cbx
            // 
            this.Movies_id_cbx.FormattingEnabled = true;
            this.Movies_id_cbx.Location = new System.Drawing.Point(989, 72);
            this.Movies_id_cbx.Name = "Movies_id_cbx";
            this.Movies_id_cbx.Size = new System.Drawing.Size(218, 24);
            this.Movies_id_cbx.TabIndex = 48;
            this.Movies_id_cbx.SelectedValueChanged += new System.EventHandler(this.Movies_id_cbx_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GioKT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Ketthuc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(845, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 125);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian kết thúc";
            // 
            // GioKT
            // 
            this.GioKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.GioKT.Location = new System.Drawing.Point(142, 79);
            this.GioKT.Name = "GioKT";
            this.GioKT.ShowUpDown = true;
            this.GioKT.Size = new System.Drawing.Size(220, 30);
            this.GioKT.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Giờ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày:";
            // 
            // Ketthuc
            // 
            this.Ketthuc.BackColor = System.Drawing.Color.Transparent;
            this.Ketthuc.BorderRadius = 1;
            this.Ketthuc.Color = System.Drawing.Color.Silver;
            this.Ketthuc.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Ketthuc.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Ketthuc.DisabledColor = System.Drawing.Color.Gray;
            this.Ketthuc.DisplayWeekNumbers = false;
            this.Ketthuc.DPHeight = 0;
            this.Ketthuc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Ketthuc.FillDatePicker = false;
            this.Ketthuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ketthuc.ForeColor = System.Drawing.Color.Black;
            this.Ketthuc.Icon = ((System.Drawing.Image)(resources.GetObject("Ketthuc.Icon")));
            this.Ketthuc.IconColor = System.Drawing.Color.Gray;
            this.Ketthuc.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Ketthuc.LeftTextMargin = 5;
            this.Ketthuc.Location = new System.Drawing.Point(136, 29);
            this.Ketthuc.MinimumSize = new System.Drawing.Size(4, 32);
            this.Ketthuc.Name = "Ketthuc";
            this.Ketthuc.Size = new System.Drawing.Size(220, 32);
            this.Ketthuc.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(841, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Giá:";
            // 
            // GiaVe
            // 
            this.GiaVe.Location = new System.Drawing.Point(989, 509);
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.Size = new System.Drawing.Size(218, 22);
            this.GiaVe.TabIndex = 46;
            // 
            // Phongchieu_cbx
            // 
            this.Phongchieu_cbx.FormattingEnabled = true;
            this.Phongchieu_cbx.Location = new System.Drawing.Point(989, 155);
            this.Phongchieu_cbx.Name = "Phongchieu_cbx";
            this.Phongchieu_cbx.Size = new System.Drawing.Size(218, 24);
            this.Phongchieu_cbx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Giochieu);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.Day_on_air);
            this.groupBox1.Controls.Add(this.Ngaychieu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(845, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 125);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian chiếu";
            // 
            // Giochieu
            // 
            this.Giochieu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Giochieu.Location = new System.Drawing.Point(136, 78);
            this.Giochieu.Name = "Giochieu";
            this.Giochieu.ShowUpDown = true;
            this.Giochieu.Size = new System.Drawing.Size(220, 30);
            this.Giochieu.TabIndex = 48;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Time.Location = new System.Drawing.Point(26, 85);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(49, 23);
            this.Time.TabIndex = 29;
            this.Time.Text = "Giờ:";
            // 
            // Day_on_air
            // 
            this.Day_on_air.AutoSize = true;
            this.Day_on_air.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Day_on_air.Location = new System.Drawing.Point(26, 38);
            this.Day_on_air.Name = "Day_on_air";
            this.Day_on_air.Size = new System.Drawing.Size(61, 23);
            this.Day_on_air.TabIndex = 28;
            this.Day_on_air.Text = "Ngày:";
            // 
            // Ngaychieu
            // 
            this.Ngaychieu.BackColor = System.Drawing.Color.Transparent;
            this.Ngaychieu.BorderRadius = 1;
            this.Ngaychieu.Color = System.Drawing.Color.Silver;
            this.Ngaychieu.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Ngaychieu.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Ngaychieu.DisabledColor = System.Drawing.Color.Gray;
            this.Ngaychieu.DisplayWeekNumbers = false;
            this.Ngaychieu.DPHeight = 0;
            this.Ngaychieu.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Ngaychieu.FillDatePicker = false;
            this.Ngaychieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ngaychieu.ForeColor = System.Drawing.Color.Black;
            this.Ngaychieu.Icon = ((System.Drawing.Image)(resources.GetObject("Ngaychieu.Icon")));
            this.Ngaychieu.IconColor = System.Drawing.Color.Gray;
            this.Ngaychieu.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Ngaychieu.LeftTextMargin = 5;
            this.Ngaychieu.Location = new System.Drawing.Point(136, 29);
            this.Ngaychieu.MinimumSize = new System.Drawing.Size(4, 32);
            this.Ngaychieu.Name = "Ngaychieu";
            this.Ngaychieu.Size = new System.Drawing.Size(220, 32);
            this.Ngaychieu.TabIndex = 26;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Room.Location = new System.Drawing.Point(841, 156);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(111, 23);
            this.Room.TabIndex = 43;
            this.Room.Text = "Phòng chiếu";
            // 
            // Time_id
            // 
            this.Time_id.AutoSize = true;
            this.Time_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Time_id.Location = new System.Drawing.Point(841, 31);
            this.Time_id.Name = "Time_id";
            this.Time_id.Size = new System.Drawing.Size(111, 23);
            this.Time_id.TabIndex = 41;
            this.Time_id.Text = "Mã ca chiếu";
            // 
            // Cachieu_tbx
            // 
            this.Cachieu_tbx.Location = new System.Drawing.Point(989, 31);
            this.Cachieu_tbx.Name = "Cachieu_tbx";
            this.Cachieu_tbx.Size = new System.Drawing.Size(218, 22);
            this.Cachieu_tbx.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Time_grv);
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 567);
            this.panel2.TabIndex = 39;
            // 
            // Time_grv
            // 
            this.Time_grv.AllowUserToAddRows = false;
            this.Time_grv.AllowUserToDeleteRows = false;
            this.Time_grv.AllowUserToResizeColumns = false;
            this.Time_grv.AllowUserToResizeRows = false;
            this.Time_grv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_grv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Time_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Time_grv.Location = new System.Drawing.Point(3, 72);
            this.Time_grv.MultiSelect = false;
            this.Time_grv.Name = "Time_grv";
            this.Time_grv.ReadOnly = true;
            this.Time_grv.RowHeadersVisible = false;
            this.Time_grv.RowHeadersWidth = 51;
            this.Time_grv.RowTemplate.Height = 24;
            this.Time_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Time_grv.Size = new System.Drawing.Size(829, 495);
            this.Time_grv.TabIndex = 21;
            this.Time_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Time_grv_CellClick);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(235, 12);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(93, 42);
            this.remove_btn.TabIndex = 20;
            this.remove_btn.Text = "Xóa";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(125, 12);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 42);
            this.edit_btn.TabIndex = 19;
            this.edit_btn.Text = "Sửa ";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(12, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 42);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // Movies_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 567);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movies_time";
            this.Text = "Movies_time";
            this.Load += new System.EventHandler(this.Movies_time_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Time_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Name_of_movie;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label Movie_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label Time_id;
        private System.Windows.Forms.TextBox Cachieu_tbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Phongchieu_cbx;
        private Bunifu.UI.WinForms.BunifuDatePicker Ngaychieu;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Day_on_air;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GiaVe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker Ketthuc;
        private System.Windows.Forms.DateTimePicker Giochieu;
        private System.Windows.Forms.DateTimePicker GioKT;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox Movies_id_cbx;
        private System.Windows.Forms.DataGridView Time_grv;
    }
}