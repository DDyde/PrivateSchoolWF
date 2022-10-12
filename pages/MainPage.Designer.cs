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
            this.parentPageButton = new System.Windows.Forms.Button();
            this.assigmentToCoursePageButton = new System.Windows.Forms.Button();
            this.professorPageButton = new System.Windows.Forms.Button();
            this.coursePageButton = new System.Windows.Forms.Button();
            this.studentPageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.studentListGrid.Location = new System.Drawing.Point(0, 0);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.RowTemplate.Height = 25;
            this.studentListGrid.Size = new System.Drawing.Size(623, 426);
            this.studentListGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parentPageButton);
            this.panel1.Controls.Add(this.assigmentToCoursePageButton);
            this.panel1.Controls.Add(this.professorPageButton);
            this.panel1.Controls.Add(this.coursePageButton);
            this.panel1.Controls.Add(this.studentPageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 426);
            this.panel1.TabIndex = 1;
            // 
            // parentPageButton
            // 
            this.parentPageButton.Location = new System.Drawing.Point(12, 159);
            this.parentPageButton.Name = "parentPageButton";
            this.parentPageButton.Size = new System.Drawing.Size(130, 30);
            this.parentPageButton.TabIndex = 4;
            this.parentPageButton.Text = "Родители";
            this.parentPageButton.UseVisualStyleBackColor = true;
            this.parentPageButton.Click += new System.EventHandler(this.parentPageButton_Click);
            // 
            // assigmentToCoursePageButton
            // 
            this.assigmentToCoursePageButton.Location = new System.Drawing.Point(12, 123);
            this.assigmentToCoursePageButton.Name = "assigmentToCoursePageButton";
            this.assigmentToCoursePageButton.Size = new System.Drawing.Size(130, 30);
            this.assigmentToCoursePageButton.TabIndex = 3;
            this.assigmentToCoursePageButton.Text = "Назначение на курс";
            this.assigmentToCoursePageButton.UseVisualStyleBackColor = true;
            this.assigmentToCoursePageButton.Click += new System.EventHandler(this.assigmentToCoursePageButton_Click);
            // 
            // professorPageButton
            // 
            this.professorPageButton.Location = new System.Drawing.Point(12, 87);
            this.professorPageButton.Name = "professorPageButton";
            this.professorPageButton.Size = new System.Drawing.Size(130, 30);
            this.professorPageButton.TabIndex = 2;
            this.professorPageButton.Text = "Преподаватель";
            this.professorPageButton.UseVisualStyleBackColor = true;
            this.professorPageButton.Click += new System.EventHandler(this.professorPageButton_Click);
            // 
            // coursePageButton
            // 
            this.coursePageButton.Location = new System.Drawing.Point(12, 51);
            this.coursePageButton.Name = "coursePageButton";
            this.coursePageButton.Size = new System.Drawing.Size(130, 30);
            this.coursePageButton.TabIndex = 1;
            this.coursePageButton.Text = "Курсы";
            this.coursePageButton.UseVisualStyleBackColor = true;
            this.coursePageButton.Click += new System.EventHandler(this.coursePageButton_Click);
            // 
            // studentPageButton
            // 
            this.studentPageButton.Location = new System.Drawing.Point(12, 15);
            this.studentPageButton.Name = "studentPageButton";
            this.studentPageButton.Size = new System.Drawing.Size(130, 30);
            this.studentPageButton.TabIndex = 0;
            this.studentPageButton.Text = "Студенты";
            this.studentPageButton.Click += new System.EventHandler(this.studentPage_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentListGrid);
            this.Name = "mainPage";
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}