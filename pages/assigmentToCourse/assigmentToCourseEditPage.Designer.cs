namespace PrivateSchoolWF.pages.assigmentToCourse
{
    partial class assigmentToCourseEditPage
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
            this.assigmentProfessorBox = new System.Windows.Forms.ComboBox();
            this.assigmentCourseBox = new System.Windows.Forms.ComboBox();
            this.addRow = new System.Windows.Forms.Button();
            this.changeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assigmentProfessorBox
            // 
            this.assigmentProfessorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigmentProfessorBox.FormattingEnabled = true;
            this.assigmentProfessorBox.Location = new System.Drawing.Point(12, 12);
            this.assigmentProfessorBox.Name = "assigmentProfessorBox";
            this.assigmentProfessorBox.Size = new System.Drawing.Size(336, 23);
            this.assigmentProfessorBox.TabIndex = 0;
            // 
            // assigmentCourseBox
            // 
            this.assigmentCourseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigmentCourseBox.FormattingEnabled = true;
            this.assigmentCourseBox.Location = new System.Drawing.Point(12, 41);
            this.assigmentCourseBox.Name = "assigmentCourseBox";
            this.assigmentCourseBox.Size = new System.Drawing.Size(336, 23);
            this.assigmentCourseBox.TabIndex = 1;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(139, 122);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 2;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(12, 122);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 3;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(273, 122);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 4;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // assigmentToCourseEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 196);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.assigmentCourseBox);
            this.Controls.Add(this.assigmentProfessorBox);
            this.Name = "assigmentToCourseEditPage";
            this.Text = "assigmentToCourseEditPage";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox assigmentProfessorBox;
        private ComboBox assigmentCourseBox;
        private Button addRow;
        private Button changeRow;
        private Button deleteRow;
    }
}