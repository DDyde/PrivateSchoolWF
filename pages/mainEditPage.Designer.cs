namespace PrivateSchoolWF.pages
{
    partial class mainEditPage
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
            this.dateBeginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.PictureBox();
            this.fioStudentBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.courseAssigBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateBegin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBeginLabel
            // 
            this.dateBeginLabel.AutoSize = true;
            this.dateBeginLabel.Location = new System.Drawing.Point(53, 107);
            this.dateBeginLabel.Name = "dateBeginLabel";
            this.dateBeginLabel.Size = new System.Drawing.Size(168, 20);
            this.dateBeginLabel.TabIndex = 4;
            this.dateBeginLabel.Text = "Дата начала обучения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата окончания обучения:";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Image = global::PrivateSchoolWF.Properties.Resources.printIcon;
            this.printButton.Location = new System.Drawing.Point(384, 259);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(36, 42);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 12;
            this.printButton.TabStop = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // fioStudentBox
            // 
            this.fioStudentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fioStudentBox.BackColor = System.Drawing.Color.Transparent;
            this.fioStudentBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fioStudentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fioStudentBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fioStudentBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fioStudentBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fioStudentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fioStudentBox.ItemHeight = 30;
            this.fioStudentBox.Location = new System.Drawing.Point(14, 12);
            this.fioStudentBox.Name = "fioStudentBox";
            this.fioStudentBox.Size = new System.Drawing.Size(398, 36);
            this.fioStudentBox.TabIndex = 13;
            // 
            // courseAssigBox
            // 
            this.courseAssigBox.BackColor = System.Drawing.Color.Transparent;
            this.courseAssigBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseAssigBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseAssigBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseAssigBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseAssigBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseAssigBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.courseAssigBox.ItemHeight = 30;
            this.courseAssigBox.Location = new System.Drawing.Point(14, 54);
            this.courseAssigBox.Name = "courseAssigBox";
            this.courseAssigBox.Size = new System.Drawing.Size(398, 36);
            this.courseAssigBox.TabIndex = 14;
            // 
            // dateBegin
            // 
            this.dateBegin.Checked = true;
            this.dateBegin.CustomFormat = "yyyy-MM-dd";
            this.dateBegin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateBegin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBegin.Location = new System.Drawing.Point(252, 104);
            this.dateBegin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBegin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(140, 30);
            this.dateBegin.TabIndex = 15;
            this.dateBegin.Value = new System.DateTime(2022, 10, 19, 12, 19, 11, 434);
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = true;
            this.dateEnd.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(252, 147);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(140, 30);
            this.dateEnd.TabIndex = 16;
            this.dateEnd.Value = new System.DateTime(2022, 10, 19, 12, 20, 43, 895);
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
            this.addRow.Location = new System.Drawing.Point(161, 204);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(106, 41);
            this.addRow.TabIndex = 17;
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
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
            this.changeRow.Location = new System.Drawing.Point(37, 204);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(106, 41);
            this.changeRow.TabIndex = 18;
            this.changeRow.Text = "Изменить";
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
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
            this.deleteRow.Location = new System.Drawing.Point(286, 204);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(106, 41);
            this.deleteRow.TabIndex = 19;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // mainEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 311);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.courseAssigBox);
            this.Controls.Add(this.fioStudentBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBeginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainEditPage";
            this.Text = "mainEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label dateBeginLabel;
        private Label label2;
        private PictureBox printButton;
        private Guna.UI2.WinForms.Guna2ComboBox fioStudentBox;
        private Guna.UI2.WinForms.Guna2ComboBox courseAssigBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateBegin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Guna.UI2.WinForms.Guna2Button addRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
    }
}