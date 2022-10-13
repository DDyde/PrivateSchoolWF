namespace PrivateSchoolWF.pages.course
{
    partial class courseEditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseEditPage));
            this.courseTitle = new System.Windows.Forms.TextBox();
            this.courseTerm = new System.Windows.Forms.DateTimePicker();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.courseType = new System.Windows.Forms.ComboBox();
            this.priceCourse = new System.Windows.Forms.NumericUpDown();
            this.addRow = new System.Windows.Forms.Button();
            this.chengeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTitle
            // 
            resources.ApplyResources(this.courseTitle, "courseTitle");
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockNum_KeyPress);
            // 
            // courseTerm
            // 
            resources.ApplyResources(this.courseTerm, "courseTerm");
            this.courseTerm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.courseTerm.Name = "courseTerm";
            // 
            // descriptionBox
            // 
            resources.ApplyResources(this.descriptionBox, "descriptionBox");
            this.descriptionBox.Name = "descriptionBox";
            // 
            // courseType
            // 
            resources.ApplyResources(this.courseType, "courseType");
            this.courseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseType.FormattingEnabled = true;
            this.courseType.Name = "courseType";
            // 
            // priceCourse
            // 
            resources.ApplyResources(this.priceCourse, "priceCourse");
            this.priceCourse.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceCourse.Name = "priceCourse";
            // 
            // addRow
            // 
            resources.ApplyResources(this.addRow, "addRow");
            this.addRow.Name = "addRow";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // chengeRow
            // 
            resources.ApplyResources(this.chengeRow, "chengeRow");
            this.chengeRow.Name = "chengeRow";
            this.chengeRow.UseVisualStyleBackColor = true;
            this.chengeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            resources.ApplyResources(this.deleteRow, "deleteRow");
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // courseEditPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.chengeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.priceCourse);
            this.Controls.Add(this.courseType);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.courseTerm);
            this.Controls.Add(this.courseTitle);
            this.Name = "courseEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.priceCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox courseTitle;
        private DateTimePicker courseTerm;
        private RichTextBox descriptionBox;
        private ComboBox courseType;
        private NumericUpDown priceCourse;
        private Button addRow;
        private Button chengeRow;
        private Button deleteRow;
    }
}