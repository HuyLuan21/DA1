namespace DA1
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username_tbx = new System.Windows.Forms.TextBox();
            this.Pass_tbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // Username_tbx
            // 
            this.Username_tbx.Location = new System.Drawing.Point(148, 58);
            this.Username_tbx.Name = "Username_tbx";
            this.Username_tbx.Size = new System.Drawing.Size(100, 22);
            this.Username_tbx.TabIndex = 2;
            this.Username_tbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pass_tbx
            // 
            this.Pass_tbx.Location = new System.Drawing.Point(148, 102);
            this.Pass_tbx.Name = "Pass_tbx";
            this.Pass_tbx.Size = new System.Drawing.Size(100, 22);
            this.Pass_tbx.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pass_tbx);
            this.Controls.Add(this.Username_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_tbx;
        private System.Windows.Forms.TextBox Pass_tbx;
        private System.Windows.Forms.Button button1;
    }
}