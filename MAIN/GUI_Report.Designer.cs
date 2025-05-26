namespace DA1
{
    partial class GUI_Report
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
            this.crv_ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_ReportViewer
            // 
            this.crv_ReportViewer.ActiveViewIndex = -1;
            this.crv_ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crv_ReportViewer.Name = "crv_ReportViewer";
            this.crv_ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.crv_ReportViewer.TabIndex = 0;
            // 
            // GUI_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_ReportViewer);
            this.Name = "GUI_Report";
            this.Text = "GUI_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ReportViewer;
    }
}