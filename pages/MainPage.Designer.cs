namespace PrivateSchoolWF
{
    partial class mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.userPageButton = new System.Windows.Forms.Button();
            this.coureTypePageButton = new System.Windows.Forms.Button();
            this.employeePageButton = new System.Windows.Forms.Button();
            this.positionPageButton = new System.Windows.Forms.Button();
            this.parentPageButton = new System.Windows.Forms.Button();
            this.assigmentToCoursePageButton = new System.Windows.Forms.Button();
            this.professorPageButton = new System.Windows.Forms.Button();
            this.coursePageButton = new System.Windows.Forms.Button();
            this.studentPageButton = new System.Windows.Forms.Button();
            this.studentListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addRowButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.searchStudBox = new System.Windows.Forms.TextBox();
            this.searchFioStudLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupCourseTypeRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.singleCourseTypeRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.typeCourseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.filterMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPageButton
            // 
            this.userPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPageButton.Location = new System.Drawing.Point(883, 0);
            this.userPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.userPageButton.Name = "userPageButton";
            this.userPageButton.Size = new System.Drawing.Size(102, 52);
            this.userPageButton.TabIndex = 8;
            this.userPageButton.Text = "Пользователь";
            this.userPageButton.UseVisualStyleBackColor = true;
            this.userPageButton.Visible = false;
            this.userPageButton.Click += new System.EventHandler(this.userPageButton_Click);
            // 
            // coureTypePageButton
            // 
            this.coureTypePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coureTypePageButton.Location = new System.Drawing.Point(670, 0);
            this.coureTypePageButton.Margin = new System.Windows.Forms.Padding(0);
            this.coureTypePageButton.Name = "coureTypePageButton";
            this.coureTypePageButton.Size = new System.Drawing.Size(112, 52);
            this.coureTypePageButton.TabIndex = 7;
            this.coureTypePageButton.Text = "Тип курса";
            this.coureTypePageButton.UseVisualStyleBackColor = true;
            this.coureTypePageButton.Visible = false;
            this.coureTypePageButton.Click += new System.EventHandler(this.coureTypePageButton_Click);
            // 
            // employeePageButton
            // 
            this.employeePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePageButton.Location = new System.Drawing.Point(469, 0);
            this.employeePageButton.Margin = new System.Windows.Forms.Padding(0);
            this.employeePageButton.Name = "employeePageButton";
            this.employeePageButton.Size = new System.Drawing.Size(107, 52);
            this.employeePageButton.TabIndex = 6;
            this.employeePageButton.Text = "Сотрудник";
            this.employeePageButton.UseVisualStyleBackColor = true;
            this.employeePageButton.Visible = false;
            this.employeePageButton.Click += new System.EventHandler(this.employeePageButton_Click);
            // 
            // positionPageButton
            // 
            this.positionPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionPageButton.Location = new System.Drawing.Point(224, 0);
            this.positionPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.positionPageButton.Name = "positionPageButton";
            this.positionPageButton.Size = new System.Drawing.Size(112, 52);
            this.positionPageButton.TabIndex = 5;
            this.positionPageButton.Text = "Должность";
            this.positionPageButton.UseVisualStyleBackColor = true;
            this.positionPageButton.Visible = false;
            this.positionPageButton.Click += new System.EventHandler(this.positionPageButton_Click);
            // 
            // parentPageButton
            // 
            this.parentPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPageButton.Location = new System.Drawing.Point(0, 0);
            this.parentPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.parentPageButton.Name = "parentPageButton";
            this.parentPageButton.Size = new System.Drawing.Size(112, 52);
            this.parentPageButton.TabIndex = 4;
            this.parentPageButton.Tag = "";
            this.parentPageButton.Text = "Родители";
            this.parentPageButton.UseVisualStyleBackColor = true;
            this.parentPageButton.Click += new System.EventHandler(this.parentPageButton_Click);
            // 
            // assigmentToCoursePageButton
            // 
            this.assigmentToCoursePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assigmentToCoursePageButton.Location = new System.Drawing.Point(112, 0);
            this.assigmentToCoursePageButton.Margin = new System.Windows.Forms.Padding(0);
            this.assigmentToCoursePageButton.Name = "assigmentToCoursePageButton";
            this.assigmentToCoursePageButton.Size = new System.Drawing.Size(112, 52);
            this.assigmentToCoursePageButton.TabIndex = 3;
            this.assigmentToCoursePageButton.Text = "Назначение на курс";
            this.assigmentToCoursePageButton.UseVisualStyleBackColor = true;
            this.assigmentToCoursePageButton.Click += new System.EventHandler(this.assigmentToCoursePageButton_Click);
            // 
            // professorPageButton
            // 
            this.professorPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professorPageButton.Location = new System.Drawing.Point(336, 0);
            this.professorPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.professorPageButton.Name = "professorPageButton";
            this.professorPageButton.Size = new System.Drawing.Size(133, 52);
            this.professorPageButton.TabIndex = 2;
            this.professorPageButton.Text = "Преподаватель";
            this.professorPageButton.UseVisualStyleBackColor = true;
            this.professorPageButton.Visible = false;
            this.professorPageButton.Click += new System.EventHandler(this.professorPageButton_Click);
            // 
            // coursePageButton
            // 
            this.coursePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursePageButton.Location = new System.Drawing.Point(576, 0);
            this.coursePageButton.Margin = new System.Windows.Forms.Padding(0);
            this.coursePageButton.Name = "coursePageButton";
            this.coursePageButton.Size = new System.Drawing.Size(94, 52);
            this.coursePageButton.TabIndex = 1;
            this.coursePageButton.Text = "Курсы";
            this.coursePageButton.UseVisualStyleBackColor = true;
            this.coursePageButton.Click += new System.EventHandler(this.coursePageButton_Click);
            // 
            // studentPageButton
            // 
            this.studentPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPageButton.Location = new System.Drawing.Point(782, 0);
            this.studentPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.studentPageButton.Name = "studentPageButton";
            this.studentPageButton.Size = new System.Drawing.Size(101, 52);
            this.studentPageButton.TabIndex = 0;
            this.studentPageButton.Text = "Студенты";
            this.studentPageButton.Click += new System.EventHandler(this.studentPage_Click);
            // 
            // studentListGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.studentListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentListGrid.ColumnHeadersHeight = 35;
            this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.studentListGrid, 9);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentListGrid.Location = new System.Drawing.Point(3, 54);
            this.studentListGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.ReadOnly = true;
            this.studentListGrid.RowHeadersVisible = false;
            this.studentListGrid.RowHeadersWidth = 50;
            this.tableLayoutPanel1.SetRowSpan(this.studentListGrid, 2);
            this.studentListGrid.RowTemplate.Height = 29;
            this.studentListGrid.Size = new System.Drawing.Size(979, 405);
            this.studentListGrid.TabIndex = 3;
            this.studentListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.studentListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.studentListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.studentListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.studentListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.studentListGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.studentListGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.studentListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.studentListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentListGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.studentListGrid.ThemeStyle.ReadOnly = true;
            this.studentListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.studentListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentListGrid.ThemeStyle.RowsStyle.Height = 29;
            this.studentListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.studentListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListGrid_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.569378F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.45295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.109731F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35335F));
            this.tableLayoutPanel1.Controls.Add(this.studentListGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userPageButton, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.parentPageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentPageButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.assigmentToCoursePageButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.coureTypePageButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.positionPageButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.coursePageButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.professorPageButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeePageButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.addRowButton, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.filterMain, 9, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.44366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1576F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.40586F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 461);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.addRowButton.Location = new System.Drawing.Point(1001, 55);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(110, 45);
            this.addRowButton.TabIndex = 9;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // filterMain
            // 
            this.filterMain.Controls.Add(this.searchStudBox);
            this.filterMain.Controls.Add(this.searchFioStudLabel);
            this.filterMain.Controls.Add(this.groupCourseTypeRadio);
            this.filterMain.Controls.Add(this.cancelButton);
            this.filterMain.Controls.Add(this.singleCourseTypeRadio);
            this.filterMain.Controls.Add(this.typeCourseLabel);
            this.filterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterMain.Location = new System.Drawing.Point(988, 105);
            this.filterMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterMain.Name = "filterMain";
            this.filterMain.Size = new System.Drawing.Size(136, 354);
            this.filterMain.TabIndex = 10;
            this.filterMain.Text = "Фильтр";
            // 
            // searchStudBox
            // 
            this.searchStudBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStudBox.Location = new System.Drawing.Point(3, 146);
            this.searchStudBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchStudBox.Name = "searchStudBox";
            this.searchStudBox.PlaceholderText = "Поиск...";
            this.searchStudBox.Size = new System.Drawing.Size(130, 23);
            this.searchStudBox.TabIndex = 7;
            this.searchStudBox.TextChanged += new System.EventHandler(this.searchStudBox_TextChanged);
            // 
            // searchFioStudLabel
            // 
            this.searchFioStudLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchFioStudLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchFioStudLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.searchFioStudLabel.Location = new System.Drawing.Point(56, 125);
            this.searchFioStudLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchFioStudLabel.Name = "searchFioStudLabel";
            this.searchFioStudLabel.Size = new System.Drawing.Size(38, 17);
            this.searchFioStudLabel.TabIndex = 6;
            this.searchFioStudLabel.Text = "Поиск";
            this.searchFioStudLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupCourseTypeRadio
            // 
            this.groupCourseTypeRadio.AutoSize = true;
            this.groupCourseTypeRadio.BackColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupCourseTypeRadio.CheckedState.BorderThickness = 0;
            this.groupCourseTypeRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupCourseTypeRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.groupCourseTypeRadio.CheckedState.InnerOffset = -4;
            this.groupCourseTypeRadio.Location = new System.Drawing.Point(9, 85);
            this.groupCourseTypeRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupCourseTypeRadio.Name = "groupCourseTypeRadio";
            this.groupCourseTypeRadio.Size = new System.Drawing.Size(85, 19);
            this.groupCourseTypeRadio.TabIndex = 5;
            this.groupCourseTypeRadio.Text = "Групповой";
            this.groupCourseTypeRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupCourseTypeRadio.UncheckedState.BorderThickness = 2;
            this.groupCourseTypeRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.groupCourseTypeRadio.UseVisualStyleBackColor = false;
            this.groupCourseTypeRadio.CheckedChanged += new System.EventHandler(this.groupCourseTypeRadio_CheckedChanged);
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
            this.cancelButton.Location = new System.Drawing.Point(0, 312);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 42);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Сброс";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // singleCourseTypeRadio
            // 
            this.singleCourseTypeRadio.AutoSize = true;
            this.singleCourseTypeRadio.BackColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.singleCourseTypeRadio.CheckedState.BorderThickness = 0;
            this.singleCourseTypeRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.singleCourseTypeRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.singleCourseTypeRadio.CheckedState.InnerOffset = -4;
            this.singleCourseTypeRadio.Location = new System.Drawing.Point(9, 62);
            this.singleCourseTypeRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleCourseTypeRadio.Name = "singleCourseTypeRadio";
            this.singleCourseTypeRadio.Size = new System.Drawing.Size(121, 19);
            this.singleCourseTypeRadio.TabIndex = 3;
            this.singleCourseTypeRadio.Text = "Индивидуальный";
            this.singleCourseTypeRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.singleCourseTypeRadio.UncheckedState.BorderThickness = 2;
            this.singleCourseTypeRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.singleCourseTypeRadio.UseVisualStyleBackColor = false;
            this.singleCourseTypeRadio.CheckedChanged += new System.EventHandler(this.singleCourseTypeRadio_CheckedChanged);
            // 
            // typeCourseLabel
            // 
            this.typeCourseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.typeCourseLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeCourseLabel.Location = new System.Drawing.Point(35, 41);
            this.typeCourseLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeCourseLabel.Name = "typeCourseLabel";
            this.typeCourseLabel.Size = new System.Drawing.Size(73, 17);
            this.typeCourseLabel.TabIndex = 2;
            this.typeCourseLabel.Text = "Типы курсов";
            this.typeCourseLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1143, 500);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.filterMain.ResumeLayout(false);
            this.filterMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button studentPageButton;
        private Button parentPageButton;
        private Button assigmentToCoursePageButton;
        private Button professorPageButton;
        private Button coursePageButton;
        private Button positionPageButton;
        private Button userPageButton;
        private Button coureTypePageButton;
        private Button employeePageButton;
        private Guna.UI2.WinForms.Guna2DataGridView studentListGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button addRowButton;
        private Guna.UI2.WinForms.Guna2GroupBox filterMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel typeCourseLabel;
        private Guna.UI2.WinForms.Guna2RadioButton singleCourseTypeRadio;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2RadioButton groupCourseTypeRadio;
        private TextBox searchStudBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel searchFioStudLabel;
    }
}