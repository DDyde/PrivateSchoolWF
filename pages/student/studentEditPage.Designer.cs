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
            this.parentStudent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.surnameStudent = new System.Windows.Forms.TextBox();
            this.dateOfBirthStudent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameStudent
            // 
            this.nameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameStudent.Location = new System.Drawing.Point(12, 41);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.PlaceholderText = "Имя";
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
            this.middlenameStudent.PlaceholderText = "Отчество";
            this.middlenameStudent.Size = new System.Drawing.Size(354, 23);
            this.middlenameStudent.TabIndex = 2;
            this.middlenameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameStudent_KeyPress);
            // 
            // commentRichBox
            // 
            this.commentRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentRichBox.Location = new System.Drawing.Point(12, 230);
            this.commentRichBox.Name = "commentRichBox";
            this.commentRichBox.Size = new System.Drawing.Size(354, 131);
            this.commentRichBox.TabIndex = 4;
            this.commentRichBox.Text = "";
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
            this.parentStudent.Location = new System.Drawing.Point(12, 167);
            this.parentStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parentStudent.Name = "parentStudent";
            this.parentStudent.Size = new System.Drawing.Size(354, 36);
            this.parentStudent.TabIndex = 11;
            // 
            // surnameStudent
            // 
            this.surnameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameStudent.Location = new System.Drawing.Point(12, 12);
            this.surnameStudent.Name = "surnameStudent";
            this.surnameStudent.PlaceholderText = "Фамилия";
            this.surnameStudent.Size = new System.Drawing.Size(354, 23);
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
            this.dateOfBirthStudent.Location = new System.Drawing.Point(147, 118);
            this.dateOfBirthStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirthStudent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthStudent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthStudent.Name = "dateOfBirthStudent";
            this.dateOfBirthStudent.Size = new System.Drawing.Size(219, 34);
            this.dateOfBirthStudent.TabIndex = 12;
            this.dateOfBirthStudent.Value = new System.DateTime(2022, 10, 19, 12, 42, 1, 421);
            // 
            // deleteRow
            // 
            this.deleteRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteRow.FillColor = System.Drawing.Color.White;
            this.deleteRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteRow.ForeColor = System.Drawing.Color.Black;
            this.deleteRow.Location = new System.Drawing.Point(250, 379);
            this.deleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(93, 31);
            this.deleteRow.TabIndex = 25;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeRow.FillColor = System.Drawing.Color.White;
            this.changeRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeRow.ForeColor = System.Drawing.Color.Black;
            this.changeRow.Location = new System.Drawing.Point(32, 379);
            this.changeRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(93, 31);
            this.changeRow.TabIndex = 24;
            this.changeRow.Text = "Изменить";
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // addRow
            // 
            this.addRow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRow.FillColor = System.Drawing.Color.White;
            this.addRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRow.ForeColor = System.Drawing.Color.Black;
            this.addRow.Location = new System.Drawing.Point(140, 379);
            this.addRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(93, 31);
            this.addRow.TabIndex = 23;
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // dateBirthLabel
            // 
            this.dateBirthLabel.AutoSize = true;
            this.dateBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBirthLabel.Location = new System.Drawing.Point(12, 122);
            this.dateBirthLabel.Name = "dateBirthLabel";
            this.dateBirthLabel.Size = new System.Drawing.Size(124, 21);
            this.dateBirthLabel.TabIndex = 26;
            this.dateBirthLabel.Text = "Дата рождения:";
            // 
            // studentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 421);
            this.Controls.Add(this.dateBirthLabel);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.dateOfBirthStudent);
            this.Controls.Add(this.parentStudent);
            this.Controls.Add(this.commentRichBox);
            this.Controls.Add(this.middlenameStudent);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.surnameStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "studentEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentEditPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox nameStudent;
        private TextBox middlenameStudent;
        private RichTextBox commentRichBox;
        private Guna.UI2.WinForms.Guna2ComboBox parentStudent;
        private TextBox surnameStudent;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthStudent;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button addRow;
        private Label dateBirthLabel;
    }
}