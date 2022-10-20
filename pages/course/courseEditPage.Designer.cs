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
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.priceCourse = new System.Windows.Forms.NumericUpDown();
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            this.courseType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.courseTerm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.courseTermLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTitle
            // 
            resources.ApplyResources(this.courseTitle, "courseTitle");
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockNum_KeyPress);
            // 
            // descriptionBox
            // 
            resources.ApplyResources(this.descriptionBox, "descriptionBox");
            this.descriptionBox.Name = "descriptionBox";
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
            // deleteRow
            // 
            this.deleteRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteRow.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.deleteRow, "deleteRow");
            this.deleteRow.ForeColor = System.Drawing.Color.Black;
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeRow.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.changeRow, "changeRow");
            this.changeRow.ForeColor = System.Drawing.Color.Black;
            this.changeRow.Name = "changeRow";
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // addRow
            // 
            this.addRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRow.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.addRow, "addRow");
            this.addRow.ForeColor = System.Drawing.Color.Black;
            this.addRow.Name = "addRow";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // courseType
            // 
            resources.ApplyResources(this.courseType, "courseType");
            this.courseType.BackColor = System.Drawing.Color.Transparent;
            this.courseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.courseType.Name = "courseType";
            // 
            // courseTerm
            // 
            resources.ApplyResources(this.courseTerm, "courseTerm");
            this.courseTerm.Checked = true;
            this.courseTerm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.courseTerm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.courseTerm.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.courseTerm.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.courseTerm.Name = "courseTerm";
            this.courseTerm.ShowUpDown = true;
            this.courseTerm.Value = new System.DateTime(2022, 10, 19, 14, 20, 0, 591);
            // 
            // courseTermLabel
            // 
            resources.ApplyResources(this.courseTermLabel, "courseTermLabel");
            this.courseTermLabel.Name = "courseTermLabel";
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.Name = "priceLabel";
            // 
            // courseEditPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.courseTermLabel);
            this.Controls.Add(this.courseTerm);
            this.Controls.Add(this.courseType);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.priceCourse);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.courseTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "courseEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.priceCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox courseTitle;
        private RichTextBox descriptionBox;
        private NumericUpDown priceCourse;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button addRow;
        private Guna.UI2.WinForms.Guna2ComboBox courseType;
        private Guna.UI2.WinForms.Guna2DateTimePicker courseTerm;
        private Label courseTermLabel;
        private Label priceLabel;
    }
}