namespace PrivateSchoolWF.pages.student
{
    partial class studentEditPage
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
            this.surnameStudent = new System.Windows.Forms.TextBox();
            this.nameStudent = new System.Windows.Forms.TextBox();
            this.middlenameStudent = new System.Windows.Forms.TextBox();
            this.commentRichBox = new System.Windows.Forms.RichTextBox();
            this.parentStudent = new System.Windows.Forms.ComboBox();
            this.dateOfBirthStudent = new System.Windows.Forms.DateTimePicker();
            this.addRow = new System.Windows.Forms.Button();
            this.changeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surnameStudent
            // 
            this.surnameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameStudent.Location = new System.Drawing.Point(12, 12);
            this.surnameStudent.Name = "surnameStudent";
            this.surnameStudent.Size = new System.Drawing.Size(354, 23);
            this.surnameStudent.TabIndex = 0;
            this.surnameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // nameStudent
            // 
            this.nameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameStudent.Location = new System.Drawing.Point(12, 41);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(354, 23);
            this.nameStudent.TabIndex = 1;
            this.nameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // middlenameStudent
            // 
            this.middlenameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameStudent.Location = new System.Drawing.Point(12, 70);
            this.middlenameStudent.Name = "middlenameStudent";
            this.middlenameStudent.Size = new System.Drawing.Size(354, 23);
            this.middlenameStudent.TabIndex = 2;
            this.middlenameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // commentRichBox
            // 
            this.commentRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentRichBox.Location = new System.Drawing.Point(12, 157);
            this.commentRichBox.Name = "commentRichBox";
            this.commentRichBox.Size = new System.Drawing.Size(354, 99);
            this.commentRichBox.TabIndex = 4;
            this.commentRichBox.Text = "";
            // 
            // parentStudent
            // 
            this.parentStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentStudent.FormattingEnabled = true;
            this.parentStudent.Location = new System.Drawing.Point(12, 128);
            this.parentStudent.Name = "parentStudent";
            this.parentStudent.Size = new System.Drawing.Size(354, 23);
            this.parentStudent.TabIndex = 6;
            // 
            // dateOfBirthStudent
            // 
            this.dateOfBirthStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthStudent.CustomFormat = "yyyy-MM-dd";
            this.dateOfBirthStudent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthStudent.Location = new System.Drawing.Point(12, 99);
            this.dateOfBirthStudent.Name = "dateOfBirthStudent";
            this.dateOfBirthStudent.Size = new System.Drawing.Size(354, 23);
            this.dateOfBirthStudent.TabIndex = 7;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(145, 319);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 8;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(24, 319);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 9;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(271, 319);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 10;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // studentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 412);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.dateOfBirthStudent);
            this.Controls.Add(this.parentStudent);
            this.Controls.Add(this.commentRichBox);
            this.Controls.Add(this.middlenameStudent);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.surnameStudent);
            this.Name = "studentEditPage";
            this.Text = "studentEditPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentEditPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameStudent;
        private TextBox nameStudent;
        private TextBox middlenameStudent;
        private RichTextBox commentRichBox;
        private ComboBox parentStudent;
        private DateTimePicker dateOfBirthStudent;
        private Button addRow;
        private Button changeRow;
        private Button deleteRow;
    }
}