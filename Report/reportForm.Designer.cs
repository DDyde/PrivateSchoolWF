namespace PrivateSchoolWF.Report
{
    partial class reportForm
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
            this.educateReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // educateReportViewer
            // 
            this.educateReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educateReportViewer.Location = new System.Drawing.Point(0, 0);
            this.educateReportViewer.Name = "ReportViewer";
            this.educateReportViewer.ServerReport.BearerToken = null;
            this.educateReportViewer.Size = new System.Drawing.Size(800, 450);
            this.educateReportViewer.TabIndex = 0;
            // 
            // reportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.educateReportViewer);
            this.Name = "reportForm";
            this.Text = "reportForm";
            this.Load += new System.EventHandler(this.reportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer educateReportViewer;
    }
}