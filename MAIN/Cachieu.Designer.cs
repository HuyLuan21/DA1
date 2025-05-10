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
            this.Time_grid_view = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Price_tbx = new System.Windows.Forms.TextBox();
            this.Room_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.Day_on_air = new System.Windows.Forms.Label();
            this.on_air_time = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Room = new System.Windows.Forms.Label();
            this.Time_id = new System.Windows.Forms.Label();
            this.Time_tbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatePicker3 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.Movies_id_cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Time_grid_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_of_movie
            // 
            this.Name_of_movie.AutoSize = true;
            this.Name_of_movie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Name_of_movie.Location = new System.Drawing.Point(549, 108);
            this.Name_of_movie.Name = "Name_of_movie";
            this.Name_of_movie.Size = new System.Drawing.Size(59, 23);
            this.Name_of_movie.TabIndex = 22;
            this.Name_of_movie.Text = "Phim:";
            this.Name_of_movie.Click += new System.EventHandler(this.Name_of_movie_Click);
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(697, 108);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.ReadOnly = true;
            this.Name_tbx.Size = new System.Drawing.Size(218, 22);
            this.Name_tbx.TabIndex = 21;
            this.Name_tbx.TextChanged += new System.EventHandler(this.Name_tbx_TextChanged);
            // 
            // Movie_id
            // 
            this.Movie_id.AutoSize = true;
            this.Movie_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Movie_id.Location = new System.Drawing.Point(549, 73);
            this.Movie_id.Name = "Movie_id";
            this.Movie_id.Size = new System.Drawing.Size(85, 23);
            this.Movie_id.TabIndex = 20;
            this.Movie_id.Text = "Mã Phim";
            this.Movie_id.Click += new System.EventHandler(this.Movie_id_Click);
            // 
            // Time_grid_view
            // 
            this.Time_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Time_grid_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Time_grid_view.Location = new System.Drawing.Point(0, 88);
            this.Time_grid_view.Name = "Time_grid_view";
            this.Time_grid_view.RowHeadersWidth = 51;
            this.Time_grid_view.RowTemplate.Height = 24;
            this.Time_grid_view.Size = new System.Drawing.Size(516, 479);
            this.Time_grid_view.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Movies_id_cbx);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Price_tbx);
            this.panel1.Controls.Add(this.Room_cbx);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Room);
            this.panel1.Controls.Add(this.Time_id);
            this.panel1.Controls.Add(this.Time_tbx);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Name_of_movie);
            this.panel1.Controls.Add(this.Name_tbx);
            this.panel1.Controls.Add(this.Movie_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 567);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(549, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Giá:";
            // 
            // Price_tbx
            // 
            this.Price_tbx.Location = new System.Drawing.Point(697, 509);
            this.Price_tbx.Name = "Price_tbx";
            this.Price_tbx.Size = new System.Drawing.Size(218, 22);
            this.Price_tbx.TabIndex = 46;
            // 
            // Room_cbx
            // 
            this.Room_cbx.FormattingEnabled = true;
            this.Room_cbx.Location = new System.Drawing.Point(697, 155);
            this.Room_cbx.Name = "Room_cbx";
            this.Room_cbx.Size = new System.Drawing.Size(218, 24);
            this.Room_cbx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.Day_on_air);
            this.groupBox1.Controls.Add(this.on_air_time);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(553, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 125);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian chiếu";
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
            // on_air_time
            // 
            this.on_air_time.BackColor = System.Drawing.Color.Transparent;
            this.on_air_time.BorderRadius = 1;
            this.on_air_time.Color = System.Drawing.Color.Silver;
            this.on_air_time.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.on_air_time.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.on_air_time.DisabledColor = System.Drawing.Color.Gray;
            this.on_air_time.DisplayWeekNumbers = false;
            this.on_air_time.DPHeight = 0;
            this.on_air_time.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.on_air_time.FillDatePicker = false;
            this.on_air_time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.on_air_time.ForeColor = System.Drawing.Color.Black;
            this.on_air_time.Icon = ((System.Drawing.Image)(resources.GetObject("on_air_time.Icon")));
            this.on_air_time.IconColor = System.Drawing.Color.Gray;
            this.on_air_time.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.on_air_time.LeftTextMargin = 5;
            this.on_air_time.Location = new System.Drawing.Point(136, 29);
            this.on_air_time.MinimumSize = new System.Drawing.Size(4, 32);
            this.on_air_time.Name = "on_air_time";
            this.on_air_time.Size = new System.Drawing.Size(220, 32);
            this.on_air_time.TabIndex = 26;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Room.Location = new System.Drawing.Point(549, 156);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(111, 23);
            this.Room.TabIndex = 43;
            this.Room.Text = "Phòng chiếu";
            // 
            // Time_id
            // 
            this.Time_id.AutoSize = true;
            this.Time_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Time_id.Location = new System.Drawing.Point(549, 31);
            this.Time_id.Name = "Time_id";
            this.Time_id.Size = new System.Drawing.Size(121, 23);
            this.Time_id.TabIndex = 41;
            this.Time_id.Text = "Mã lịch chiếu";
            // 
            // Time_tbx
            // 
            this.Time_tbx.Location = new System.Drawing.Point(697, 31);
            this.Time_tbx.Name = "Time_tbx";
            this.Time_tbx.Size = new System.Drawing.Size(218, 22);
            this.Time_tbx.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remove_btn);
            this.panel2.Controls.Add(this.edit_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.Time_grid_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 567);
            this.panel2.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bunifuDatePicker3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(553, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 125);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian kết thúc";
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
            // bunifuDatePicker3
            // 
            this.bunifuDatePicker3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker3.BorderRadius = 1;
            this.bunifuDatePicker3.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker3.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker3.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker3.DisplayWeekNumbers = false;
            this.bunifuDatePicker3.DPHeight = 0;
            this.bunifuDatePicker3.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker3.FillDatePicker = false;
            this.bunifuDatePicker3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker3.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker3.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker3.Icon")));
            this.bunifuDatePicker3.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker3.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker3.LeftTextMargin = 5;
            this.bunifuDatePicker3.Location = new System.Drawing.Point(136, 29);
            this.bunifuDatePicker3.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker3.Name = "bunifuDatePicker3";
            this.bunifuDatePicker3.Size = new System.Drawing.Size(220, 32);
            this.bunifuDatePicker3.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 30);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 30);
            this.dateTimePicker2.TabIndex = 49;
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
            // Movies_id_cbx
            // 
            this.Movies_id_cbx.FormattingEnabled = true;
            this.Movies_id_cbx.Location = new System.Drawing.Point(697, 72);
            this.Movies_id_cbx.Name = "Movies_id_cbx";
            this.Movies_id_cbx.Size = new System.Drawing.Size(218, 24);
            this.Movies_id_cbx.TabIndex = 48;
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
            ((System.ComponentModel.ISupportInitialize)(this.Time_grid_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Name_of_movie;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label Movie_id;
        private System.Windows.Forms.DataGridView Time_grid_view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label Time_id;
        private System.Windows.Forms.TextBox Time_tbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Room_cbx;
        private Bunifu.UI.WinForms.BunifuDatePicker on_air_time;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Day_on_air;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price_tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox Movies_id_cbx;
    }
}