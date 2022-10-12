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
            this.courseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseTitle.Location = new System.Drawing.Point(12, 12);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(342, 23);
            this.courseTitle.TabIndex = 0;
            this.courseTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockNum_KeyPress);
            // 
            // courseTerm
            // 
            this.courseTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseTerm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.courseTerm.Location = new System.Drawing.Point(12, 41);
            this.courseTerm.Name = "courseTerm";
            this.courseTerm.Size = new System.Drawing.Size(200, 23);
            this.courseTerm.TabIndex = 1;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.Location = new System.Drawing.Point(12, 70);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(342, 96);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // courseType
            // 
            this.courseType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseType.FormattingEnabled = true;
            this.courseType.Location = new System.Drawing.Point(12, 172);
            this.courseType.Name = "courseType";
            this.courseType.Size = new System.Drawing.Size(342, 23);
            this.courseType.TabIndex = 3;
            // 
            // priceCourse
            // 
            this.priceCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceCourse.Location = new System.Drawing.Point(12, 201);
            this.priceCourse.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceCourse.Name = "priceCourse";
            this.priceCourse.Size = new System.Drawing.Size(342, 23);
            this.priceCourse.TabIndex = 4;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(147, 263);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 5;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // chengeRow
            // 
            this.chengeRow.Location = new System.Drawing.Point(12, 263);
            this.chengeRow.Name = "chengeRow";
            this.chengeRow.Size = new System.Drawing.Size(75, 23);
            this.chengeRow.TabIndex = 6;
            this.chengeRow.Text = "Изменить";
            this.chengeRow.UseVisualStyleBackColor = true;
            this.chengeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(279, 263);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 7;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // courseEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 324);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.chengeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.priceCourse);
            this.Controls.Add(this.courseType);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.courseTerm);
            this.Controls.Add(this.courseTitle);
            this.Name = "courseEditPage";
            this.Text = "courseEditPage";
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