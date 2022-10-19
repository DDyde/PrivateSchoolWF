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
            this.nameStudent = new System.Windows.Forms.TextBox();
            this.middlenameStudent = new System.Windows.Forms.TextBox();
            this.commentRichBox = new System.Windows.Forms.RichTextBox();
            this.addRow = new System.Windows.Forms.Button();
            this.changeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.parentStudent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.surnameStudent = new System.Windows.Forms.TextBox();
            this.dateOfBirthStudent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // nameStudent
            // 
            this.nameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameStudent.Location = new System.Drawing.Point(14, 55);
            this.nameStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.PlaceholderText = "Имя";
            this.nameStudent.Size = new System.Drawing.Size(404, 27);
            this.nameStudent.TabIndex = 1;
            this.nameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // middlenameStudent
            // 
            this.middlenameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameStudent.Location = new System.Drawing.Point(14, 93);
            this.middlenameStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middlenameStudent.Name = "middlenameStudent";
            this.middlenameStudent.PlaceholderText = "Отчество";
            this.middlenameStudent.Size = new System.Drawing.Size(404, 27);
            this.middlenameStudent.TabIndex = 2;
            this.middlenameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // commentRichBox
            // 
            this.commentRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentRichBox.Location = new System.Drawing.Point(14, 221);
            this.commentRichBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commentRichBox.Name = "commentRichBox";
            this.commentRichBox.Size = new System.Drawing.Size(404, 173);
            this.commentRichBox.TabIndex = 4;
            this.commentRichBox.Text = "";
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(178, 424);
            this.addRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(86, 31);
            this.addRow.TabIndex = 8;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(14, 424);
            this.changeRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(86, 31);
            this.changeRow.TabIndex = 9;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(332, 424);
            this.deleteRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(86, 31);
            this.deleteRow.TabIndex = 10;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // parentStudent
            // 
            this.parentStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentStudent.BackColor = System.Drawing.Color.Transparent;
            this.parentStudent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.parentStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentStudent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parentStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parentStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parentStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.parentStudent.ItemHeight = 30;
            this.parentStudent.Location = new System.Drawing.Point(12, 178);
            this.parentStudent.Name = "parentStudent";
            this.parentStudent.Size = new System.Drawing.Size(404, 36);
            this.parentStudent.TabIndex = 11;
            // 
            // surnameStudent
            // 
            this.surnameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameStudent.Location = new System.Drawing.Point(14, 16);
            this.surnameStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameStudent.Name = "surnameStudent";
            this.surnameStudent.PlaceholderText = "Фамилия";
            this.surnameStudent.Size = new System.Drawing.Size(404, 27);
            this.surnameStudent.TabIndex = 0;
            this.surnameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // dateOfBirthStudent
            // 
            this.dateOfBirthStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthStudent.Checked = true;
            this.dateOfBirthStudent.CustomFormat = "yyyy-MM-dd";
            this.dateOfBirthStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateOfBirthStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthStudent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthStudent.Location = new System.Drawing.Point(14, 127);
            this.dateOfBirthStudent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthStudent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthStudent.Name = "dateOfBirthStudent";
            this.dateOfBirthStudent.Size = new System.Drawing.Size(250, 45);
            this.dateOfBirthStudent.TabIndex = 12;
            this.dateOfBirthStudent.Value = new System.DateTime(2022, 10, 19, 12, 42, 1, 421);
            // 
            // studentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 475);
            this.Controls.Add(this.dateOfBirthStudent);
            this.Controls.Add(this.parentStudent);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.commentRichBox);
            this.Controls.Add(this.middlenameStudent);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.surnameStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "studentEditPage";
            this.Text = "studentEditPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentEditPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox nameStudent;
        private TextBox middlenameStudent;
        private RichTextBox commentRichBox;
        private Button addRow;
        private Button changeRow;
        private Button deleteRow;
        private Guna.UI2.WinForms.Guna2ComboBox parentStudent;
        private TextBox surnameStudent;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthStudent;
    }
}