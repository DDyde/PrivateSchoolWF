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
            this.studentListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRowButton = new System.Windows.Forms.Button();
            this.userPageButton = new System.Windows.Forms.Button();
            this.coureTypePageButton = new System.Windows.Forms.Button();
            this.employeePageButton = new System.Windows.Forms.Button();
            this.positionPageButton = new System.Windows.Forms.Button();
            this.parentPageButton = new System.Windows.Forms.Button();
            this.assigmentToCoursePageButton = new System.Windows.Forms.Button();
            this.professorPageButton = new System.Windows.Forms.Button();
            this.coursePageButton = new System.Windows.Forms.Button();
            this.studentPageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListGrid
            // 
            this.studentListGrid.AllowUserToOrderColumns = true;
            this.studentListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListGrid.Location = new System.Drawing.Point(0, 55);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.RowTemplate.Height = 25;
            this.studentListGrid.Size = new System.Drawing.Size(946, 371);
            this.studentListGrid.TabIndex = 0;
            this.studentListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addRowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(943, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 426);
            this.panel1.TabIndex = 1;
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(6, 30);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(133, 43);
            this.addRowButton.TabIndex = 0;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // userPageButton
            // 
            this.userPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.userPageButton.Location = new System.Drawing.Point(832, 0);
            this.userPageButton.Margin = new System.Windows.Forms.Padding(5);
            this.userPageButton.Name = "userPageButton";
            this.userPageButton.Size = new System.Drawing.Size(104, 55);
            this.userPageButton.TabIndex = 8;
            this.userPageButton.Text = "Пользователь";
            this.userPageButton.UseVisualStyleBackColor = true;
            this.userPageButton.Visible = false;
            this.userPageButton.Click += new System.EventHandler(this.userPageButton_Click);
            // 
            // coureTypePageButton
            // 
            this.coureTypePageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.coureTypePageButton.Location = new System.Drawing.Point(624, 0);
            this.coureTypePageButton.Margin = new System.Windows.Forms.Padding(5);
            this.coureTypePageButton.Name = "coureTypePageButton";
            this.coureTypePageButton.Size = new System.Drawing.Size(104, 55);
            this.coureTypePageButton.TabIndex = 7;
            this.coureTypePageButton.Text = "Тип курса";
            this.coureTypePageButton.UseVisualStyleBackColor = true;
            this.coureTypePageButton.Visible = false;
            this.coureTypePageButton.Click += new System.EventHandler(this.coureTypePageButton_Click);
            // 
            // employeePageButton
            // 
            this.employeePageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.employeePageButton.Location = new System.Drawing.Point(416, 0);
            this.employeePageButton.Margin = new System.Windows.Forms.Padding(5);
            this.employeePageButton.Name = "employeePageButton";
            this.employeePageButton.Size = new System.Drawing.Size(104, 55);
            this.employeePageButton.TabIndex = 6;
            this.employeePageButton.Text = "Сотрудник";
            this.employeePageButton.UseVisualStyleBackColor = true;
            this.employeePageButton.Visible = false;
            this.employeePageButton.Click += new System.EventHandler(this.employeePageButton_Click);
            // 
            // positionPageButton
            // 
            this.positionPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.positionPageButton.Location = new System.Drawing.Point(208, 0);
            this.positionPageButton.Margin = new System.Windows.Forms.Padding(5);
            this.positionPageButton.Name = "positionPageButton";
            this.positionPageButton.Size = new System.Drawing.Size(104, 55);
            this.positionPageButton.TabIndex = 5;
            this.positionPageButton.Text = "Должность";
            this.positionPageButton.UseVisualStyleBackColor = true;
            this.positionPageButton.Visible = false;
            this.positionPageButton.Click += new System.EventHandler(this.positionPageButton_Click);
            // 
            // parentPageButton
            // 
            this.parentPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.parentPageButton.Location = new System.Drawing.Point(0, 0);
            this.parentPageButton.Margin = new System.Windows.Forms.Padding(5);
            this.parentPageButton.Name = "parentPageButton";
            this.parentPageButton.Size = new System.Drawing.Size(104, 55);
            this.parentPageButton.TabIndex = 4;
            this.parentPageButton.Text = "Родители";
            this.parentPageButton.UseVisualStyleBackColor = true;
            this.parentPageButton.Click += new System.EventHandler(this.parentPageButton_Click);
            // 
            // assigmentToCoursePageButton
            // 
            this.assigmentToCoursePageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.assigmentToCoursePageButton.Location = new System.Drawing.Point(104, 0);
            this.assigmentToCoursePageButton.Margin = new System.Windows.Forms.Padding(5);
            this.assigmentToCoursePageButton.Name = "assigmentToCoursePageButton";
            this.assigmentToCoursePageButton.Size = new System.Drawing.Size(104, 55);
            this.assigmentToCoursePageButton.TabIndex = 3;
            this.assigmentToCoursePageButton.Text = "Назначение на курс";
            this.assigmentToCoursePageButton.UseVisualStyleBackColor = true;
            this.assigmentToCoursePageButton.Click += new System.EventHandler(this.assigmentToCoursePageButton_Click);
            // 
            // professorPageButton
            // 
            this.professorPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.professorPageButton.Location = new System.Drawing.Point(312, 0);
            this.professorPageButton.Margin = new System.Windows.Forms.Padding(5);
            this.professorPageButton.Name = "professorPageButton";
            this.professorPageButton.Size = new System.Drawing.Size(104, 55);
            this.professorPageButton.TabIndex = 2;
            this.professorPageButton.Text = "Преподаватель";
            this.professorPageButton.UseVisualStyleBackColor = true;
            this.professorPageButton.Visible = false;
            this.professorPageButton.Click += new System.EventHandler(this.professorPageButton_Click);
            // 
            // coursePageButton
            // 
            this.coursePageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.coursePageButton.Location = new System.Drawing.Point(520, 0);
            this.coursePageButton.Margin = new System.Windows.Forms.Padding(5);
            this.coursePageButton.Name = "coursePageButton";
            this.coursePageButton.Size = new System.Drawing.Size(104, 55);
            this.coursePageButton.TabIndex = 1;
            this.coursePageButton.Text = "Курсы";
            this.coursePageButton.UseVisualStyleBackColor = true;
            this.coursePageButton.Click += new System.EventHandler(this.coursePageButton_Click);
            // 
            // studentPageButton
            // 
            this.studentPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentPageButton.Location = new System.Drawing.Point(728, 0);
            this.studentPageButton.Margin = new System.Windows.Forms.Padding(5);
            this.studentPageButton.Name = "studentPageButton";
            this.studentPageButton.Size = new System.Drawing.Size(104, 55);
            this.studentPageButton.TabIndex = 0;
            this.studentPageButton.Text = "Студенты";
            this.studentPageButton.Click += new System.EventHandler(this.studentPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userPageButton);
            this.panel2.Controls.Add(this.studentPageButton);
            this.panel2.Controls.Add(this.coureTypePageButton);
            this.panel2.Controls.Add(this.coursePageButton);
            this.panel2.Controls.Add(this.employeePageButton);
            this.panel2.Controls.Add(this.professorPageButton);
            this.panel2.Controls.Add(this.positionPageButton);
            this.panel2.Controls.Add(this.assigmentToCoursePageButton);
            this.panel2.Controls.Add(this.parentPageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 55);
            this.panel2.TabIndex = 2;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentListGrid);
            this.Name = "mainPage";
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView studentListGrid;
        private Panel panel1;
        private Button studentPageButton;
        private Button parentPageButton;
        private Button assigmentToCoursePageButton;
        private Button professorPageButton;
        private Button coursePageButton;
        private Button positionPageButton;
        private Button userPageButton;
        private Button coureTypePageButton;
        private Button employeePageButton;
        private Panel panel2;
        private Button addRowButton;
    }
}