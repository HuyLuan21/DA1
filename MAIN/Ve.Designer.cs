namespace DA1
{
    partial class Ve
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.All_ve = new System.Windows.Forms.DataGridView();
            this.Cachieu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_ve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cachieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 822);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.All_ve, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cachieu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 748);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // All_ve
            // 
            this.All_ve.AllowUserToAddRows = false;
            this.All_ve.AllowUserToDeleteRows = false;
            this.All_ve.AllowUserToOrderColumns = true;
            this.All_ve.AllowUserToResizeColumns = false;
            this.All_ve.AllowUserToResizeRows = false;
            this.All_ve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.All_ve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_ve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All_ve.Location = new System.Drawing.Point(3, 3);
            this.All_ve.Name = "All_ve";
            this.All_ve.ReadOnly = true;
            this.All_ve.RowHeadersVisible = false;
            this.All_ve.RowHeadersWidth = 51;
            this.All_ve.RowTemplate.Height = 24;
            this.All_ve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.All_ve.Size = new System.Drawing.Size(563, 742);
            this.All_ve.TabIndex = 2;
            // 
            // Cachieu
            // 
            this.Cachieu.AllowUserToAddRows = false;
            this.Cachieu.AllowUserToDeleteRows = false;
            this.Cachieu.AllowUserToOrderColumns = true;
            this.Cachieu.AllowUserToResizeColumns = false;
            this.Cachieu.AllowUserToResizeRows = false;
            this.Cachieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cachieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cachieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cachieu.Location = new System.Drawing.Point(572, 3);
            this.Cachieu.Name = "Cachieu";
            this.Cachieu.ReadOnly = true;
            this.Cachieu.RowHeadersVisible = false;
            this.Cachieu.RowHeadersWidth = 51;
            this.Cachieu.RowTemplate.Height = 24;
            this.Cachieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cachieu.Size = new System.Drawing.Size(564, 742);
            this.Cachieu.TabIndex = 1;
            this.Cachieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cachieu_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 74);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xem tất cả lịch chiếu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 822);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ve";
            this.Text = "Ve";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.All_ve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cachieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView All_ve;
        private System.Windows.Forms.DataGridView Cachieu;
    }
}