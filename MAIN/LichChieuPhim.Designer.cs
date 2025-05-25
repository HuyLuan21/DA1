namespace DA1
{
    partial class LichChieuPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichChieuPhim));
            this.background = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.content = new Bunifu.UI.WinForms.BunifuPanel();
            this.Cachieu = new System.Windows.Forms.DataGridView();
            this.sidebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.Detail = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Nav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cachieu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.Detail.SuspendLayout();
            this.Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.BorderRadius = 1;
            this.background.Controls.Add(this.panel1);
            this.background.Controls.Add(this.Nav);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.background.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.background.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.background.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Quality = 10;
            this.background.Size = new System.Drawing.Size(1249, 614);
            this.background.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.content);
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 501);
            this.panel1.TabIndex = 2;
            // 
            // content
            // 
            this.content.BackgroundColor = System.Drawing.Color.LightGray;
            this.content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("content.BackgroundImage")));
            this.content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.content.BorderColor = System.Drawing.Color.Transparent;
            this.content.BorderRadius = 3;
            this.content.BorderThickness = 1;
            this.content.Controls.Add(this.Cachieu);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(329, 0);
            this.content.Name = "content";
            this.content.ShowBorders = false;
            this.content.Size = new System.Drawing.Size(920, 501);
            this.content.TabIndex = 2;
            // 
            // Cachieu
            // 
            this.Cachieu.AllowUserToAddRows = false;
            this.Cachieu.AllowUserToDeleteRows = false;
            this.Cachieu.AllowUserToOrderColumns = true;
            this.Cachieu.AllowUserToResizeColumns = false;
            this.Cachieu.AllowUserToResizeRows = false;
            this.Cachieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cachieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cachieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cachieu.Location = new System.Drawing.Point(0, 0);
            this.Cachieu.Name = "Cachieu";
            this.Cachieu.ReadOnly = true;
            this.Cachieu.RowHeadersVisible = false;
            this.Cachieu.RowHeadersWidth = 51;
            this.Cachieu.RowTemplate.Height = 24;
            this.Cachieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cachieu.Size = new System.Drawing.Size(920, 501);
            this.Cachieu.TabIndex = 0;
            this.Cachieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sidebar
            // 
            this.sidebar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sidebar.BorderRadius = 3;
            this.sidebar.BorderThickness = 3;
            this.sidebar.Controls.Add(this.Detail);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShowBorders = false;
            this.sidebar.Size = new System.Drawing.Size(329, 501);
            this.sidebar.TabIndex = 1;
            // 
            // Detail
            // 
            this.Detail.Controls.Add(this.button1);
            this.Detail.Controls.Add(this.comboBox1);
            this.Detail.Controls.Add(this.label2);
            this.Detail.Controls.Add(this.dateTimePicker1);
            this.Detail.Controls.Add(this.label1);
            this.Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail.ForeColor = System.Drawing.Color.Yellow;
            this.Detail.Location = new System.Drawing.Point(0, 0);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(329, 501);
            this.Detail.TabIndex = 0;
            this.Detail.TabStop = false;
            this.Detail.Text = "Chi tiết";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(218, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chọn vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.Black;
            this.Nav.Controls.Add(this.label3);
            this.Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(1249, 106);
            this.Nav.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(416, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "LỊCH CHIẾU PHIM ";
            // 
            // LichChieuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 614);
            this.Controls.Add(this.background);
            this.Name = "LichChieuPhim";
            this.Text = "Lich chieu phim";
            this.Load += new System.EventHandler(this.Datve_Load);
            this.background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cachieu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.Detail.ResumeLayout(false);
            this.Detail.PerformLayout();
            this.Nav.ResumeLayout(false);
            this.Nav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel background;
        private Bunifu.UI.WinForms.BunifuPanel sidebar;
        private System.Windows.Forms.Panel Nav;
        private Bunifu.UI.WinForms.BunifuPanel content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Cachieu;
        private System.Windows.Forms.Button button1;
    }
}