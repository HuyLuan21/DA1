namespace DA1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbUser = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Caplocks = new System.Windows.Forms.PictureBox();
            this.Showpassword = new System.Windows.Forms.PictureBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Loginbtnn = new System.Windows.Forms.Button();
            this.inkForgot = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.inkForgotPass = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caplocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showpassword)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.txbUser.Location = new System.Drawing.Point(88, 35);
            this.txbUser.Multiline = true;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(306, 34);
            this.txbUser.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbUser);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(6, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 77);
            this.panel6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "UserName ";
            // 
            // Caplocks
            // 
            this.Caplocks.BackColor = System.Drawing.SystemColors.Window;
            this.Caplocks.Image = global::DA1.Properties.Resources.capslock_icon;
            this.Caplocks.Location = new System.Drawing.Point(326, 35);
            this.Caplocks.Name = "Caplocks";
            this.Caplocks.Size = new System.Drawing.Size(32, 30);
            this.Caplocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Caplocks.TabIndex = 67;
            this.Caplocks.TabStop = false;
            // 
            // Showpassword
            // 
            this.Showpassword.BackColor = System.Drawing.SystemColors.Window;
            this.Showpassword.Image = global::DA1.Properties.Resources.eye_open;
            this.Showpassword.Location = new System.Drawing.Point(362, 35);
            this.Showpassword.Name = "Showpassword";
            this.Showpassword.Size = new System.Drawing.Size(32, 30);
            this.Showpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Showpassword.TabIndex = 2;
            this.Showpassword.TabStop = false;
            this.Showpassword.Click += new System.EventHandler(this.Showpassword_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("Times New Roman", 13.875F);
            this.tbxPass.Location = new System.Drawing.Point(88, 35);
            this.tbxPass.Multiline = true;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(306, 34);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.Enter += new System.EventHandler(this.tbxPass_Enter);
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPass_KeyDown);
            this.tbxPass.Leave += new System.EventHandler(this.tbxPass_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(226, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "OR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Location = new System.Drawing.Point(155, 470);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(178, 45);
            this.Createbtn.TabIndex = 4;
            this.Createbtn.Text = "Create new account";
            this.Createbtn.UseVisualStyleBackColor = false;
            // 
            // Loginbtnn
            // 
            this.Loginbtnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(230)))));
            this.Loginbtnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtnn.ForeColor = System.Drawing.Color.White;
            this.Loginbtnn.Location = new System.Drawing.Point(98, 335);
            this.Loginbtnn.Name = "Loginbtnn";
            this.Loginbtnn.Size = new System.Drawing.Size(306, 72);
            this.Loginbtnn.TabIndex = 3;
            this.Loginbtnn.Text = "LOGIN";
            this.Loginbtnn.UseVisualStyleBackColor = false;
            this.Loginbtnn.Click += new System.EventHandler(this.Loginbtnn_Click);
            // 
            // inkForgot
            // 
            this.inkForgot.AutoSize = true;
            this.inkForgot.Location = new System.Drawing.Point(94, 281);
            this.inkForgot.Name = "inkForgot";
            this.inkForgot.Size = new System.Drawing.Size(178, 23);
            this.inkForgot.TabIndex = 2;
            this.inkForgot.TabStop = true;
            this.inkForgot.Text = "Forgotten password?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Caplocks);
            this.panel5.Controls.Add(this.Showpassword);
            this.panel5.Controls.Add(this.tbxPass);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(6, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 77);
            this.panel5.TabIndex = 1;
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(88, 26);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(306, 29);
            this.cbbRole.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbRole);
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 77);
            this.panel4.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Createbtn);
            this.groupBox2.Controls.Add(this.Loginbtnn);
            this.groupBox2.Controls.Add(this.inkForgot);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Location = new System.Drawing.Point(11, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 539);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(88, 35);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(306, 34);
            this.txbUsername.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 77);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName ";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(88, 35);
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(306, 34);
            this.txbPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(228, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "OR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create new account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(230)))));
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(100, 307);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(306, 72);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // inkForgotPass
            // 
            this.inkForgotPass.AutoSize = true;
            this.inkForgotPass.Location = new System.Drawing.Point(100, 271);
            this.inkForgotPass.Name = "inkForgotPass";
            this.inkForgotPass.Size = new System.Drawing.Size(178, 23);
            this.inkForgotPass.TabIndex = 2;
            this.inkForgotPass.TabStop = true;
            this.inkForgotPass.Text = "Forgotten password?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 77);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 34);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(6, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 77);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.inkForgotPass);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 519);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(165, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 75);
            this.label1.TabIndex = 101;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 836);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Caplocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showpassword)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Caplocks;
        private System.Windows.Forms.PictureBox Showpassword;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button Loginbtnn;
        private System.Windows.Forms.LinkLabel inkForgot;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel inkForgotPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}