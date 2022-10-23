namespace PrivateSchoolWF.pages.course
{
    partial class coursePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coursePage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addRowButton = new Guna.UI2.WinForms.Guna2Button();
            this.courseListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.filterCourse = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.groupCourseTypeRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.singleCourseTypeRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.courseTypeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.searchCourseBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            this.filterCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.addRowButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseListGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterCourse, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addRowButton
            // 
            this.addRowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addRowButton.Animated = true;
            this.addRowButton.AutoRoundedCorners = true;
            this.addRowButton.BorderRadius = 21;
            this.addRowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRowButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRowButton.ForeColor = System.Drawing.Color.White;
            this.addRowButton.Location = new System.Drawing.Point(765, 48);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(114, 45);
            this.addRowButton.TabIndex = 0;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // courseListGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.courseListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.courseListGrid.ColumnHeadersHeight = 35;
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.courseListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.courseListGrid.Location = new System.Drawing.Point(3, 3);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.courseListGrid, 3);
            this.courseListGrid.RowTemplate.Height = 25;
            this.courseListGrid.Size = new System.Drawing.Size(749, 444);
            this.courseListGrid.TabIndex = 1;
            this.courseListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.courseListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.courseListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.courseListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.courseListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.courseListGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.courseListGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.courseListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.courseListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.courseListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.courseListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.courseListGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.courseListGrid.ThemeStyle.ReadOnly = false;
            this.courseListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.courseListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.courseListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.courseListGrid.ThemeStyle.RowsStyle.Height = 25;
            this.courseListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.courseListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.courseListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseListGrid_CellClick);
            // 
            // filterCourse
            // 
            this.filterCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterCourse.Controls.Add(this.cancelButton);
            this.filterCourse.Controls.Add(this.groupCourseTypeRadio);
            this.filterCourse.Controls.Add(this.singleCourseTypeRadio);
            this.filterCourse.Controls.Add(this.courseTypeLabel);
            this.filterCourse.Controls.Add(this.guna2Separator1);
            this.filterCourse.Controls.Add(this.searchCourseBox);
            this.filterCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterCourse.Location = new System.Drawing.Point(758, 106);
            this.filterCourse.Name = "filterCourse";
            this.filterCourse.Size = new System.Drawing.Size(128, 340);
            this.filterCourse.TabIndex = 2;
            this.filterCourse.Text = "Фильтр";
            // 
            // cancelButton
            // 
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(0, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 45);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Сброс";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupCourseTypeRadio
            // 
            this.groupCourseTypeRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCourseTypeRadio.AutoSize = true;
            this.groupCourseTypeRadio.BackColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupCourseTypeRadio.CheckedState.BorderThickness = 0;
            this.groupCourseTypeRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupCourseTypeRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.groupCourseTypeRadio.CheckedState.InnerOffset = -4;
            this.groupCourseTypeRadio.Location = new System.Drawing.Point(3, 139);
            this.groupCourseTypeRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupCourseTypeRadio.Name = "groupCourseTypeRadio";
            this.groupCourseTypeRadio.Size = new System.Drawing.Size(85, 19);
            this.groupCourseTypeRadio.TabIndex = 7;
            this.groupCourseTypeRadio.Text = "Групповой";
            this.groupCourseTypeRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupCourseTypeRadio.UncheckedState.BorderThickness = 2;
            this.groupCourseTypeRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.UseVisualStyleBackColor = false;
            this.groupCourseTypeRadio.CheckedChanged += new System.EventHandler(this.CourseTypeRadio_CheckedChanged);
            // 
            // singleCourseTypeRadio
            // 
            this.singleCourseTypeRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singleCourseTypeRadio.AutoSize = true;
            this.singleCourseTypeRadio.BackColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.singleCourseTypeRadio.CheckedState.BorderThickness = 0;
            this.singleCourseTypeRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.singleCourseTypeRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.singleCourseTypeRadio.CheckedState.InnerOffset = -4;
            this.singleCourseTypeRadio.Location = new System.Drawing.Point(3, 116);
            this.singleCourseTypeRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleCourseTypeRadio.Name = "singleCourseTypeRadio";
            this.singleCourseTypeRadio.Size = new System.Drawing.Size(121, 19);
            this.singleCourseTypeRadio.TabIndex = 6;
            this.singleCourseTypeRadio.Text = "Индивидуальный";
            this.singleCourseTypeRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.singleCourseTypeRadio.UncheckedState.BorderThickness = 2;
            this.singleCourseTypeRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.UseVisualStyleBackColor = false;
            this.singleCourseTypeRadio.CheckedChanged += new System.EventHandler(this.CourseTypeRadio_CheckedChanged);
            // 
            // courseTypeLabel
            // 
            this.courseTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.courseTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseTypeLabel.Location = new System.Drawing.Point(26, 94);
            this.courseTypeLabel.Name = "courseTypeLabel";
            this.courseTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.courseTypeLabel.TabIndex = 2;
            this.courseTypeLabel.Text = "Типы курсов";
            this.courseTypeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(13, 78);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(103, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // searchCourseBox
            // 
            this.searchCourseBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCourseBox.Location = new System.Drawing.Point(4, 49);
            this.searchCourseBox.Name = "searchCourseBox";
            this.searchCourseBox.PlaceholderText = "Поиск...";
            this.searchCourseBox.Size = new System.Drawing.Size(120, 23);
            this.searchCourseBox.TabIndex = 0;
            this.searchCourseBox.TextChanged += new System.EventHandler(this.searchCourseBox_TextChanged);
            // 
            // coursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(863, 416);
            this.Name = "coursePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.coursePage_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.filterCourse.ResumeLayout(false);
            this.filterCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button addRowButton;
        private Guna.UI2.WinForms.Guna2DataGridView courseListGrid;
        private Guna.UI2.WinForms.Guna2GroupBox filterCourse;
        private TextBox searchCourseBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel courseTypeLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2RadioButton groupCourseTypeRadio;
        private Guna.UI2.WinForms.Guna2RadioButton singleCourseTypeRadio;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
    }
}