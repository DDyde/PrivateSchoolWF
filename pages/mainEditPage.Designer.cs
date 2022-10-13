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
            this.fioStudentBox = new System.Windows.Forms.ComboBox();
            this.courseAssigBox = new System.Windows.Forms.ComboBox();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateBeginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeRow = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.PictureBox();
            this.dateEducDoc = new System.Windows.Forms.DateTimePicker();
            this.dateSingDoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            this.SuspendLayout();
            // 
            // fioStudentBox
            // 
            this.fioStudentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fioStudentBox.FormattingEnabled = true;
            this.fioStudentBox.Location = new System.Drawing.Point(12, 12);
            this.fioStudentBox.Name = "fioStudentBox";
            this.fioStudentBox.Size = new System.Drawing.Size(349, 23);
            this.fioStudentBox.TabIndex = 0;
            // 
            // courseAssigBox
            // 
            this.courseAssigBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseAssigBox.FormattingEnabled = true;
            this.courseAssigBox.Location = new System.Drawing.Point(12, 41);
            this.courseAssigBox.Name = "courseAssigBox";
            this.courseAssigBox.Size = new System.Drawing.Size(349, 23);
            this.courseAssigBox.TabIndex = 1;
            // 
            // dateBegin
            // 
            this.dateBegin.CustomFormat = "yyyy-MM-dd";
            this.dateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBegin.Location = new System.Drawing.Point(208, 74);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(121, 23);
            this.dateBegin.TabIndex = 2;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(208, 104);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(121, 23);
            this.dateEnd.TabIndex = 3;
            // 
            // dateBeginLabel
            // 
            this.dateBeginLabel.AutoSize = true;
            this.dateBeginLabel.Location = new System.Drawing.Point(46, 80);
            this.dateBeginLabel.Name = "dateBeginLabel";
            this.dateBeginLabel.Size = new System.Drawing.Size(133, 15);
            this.dateBeginLabel.TabIndex = 4;
            this.dateBeginLabel.Text = "Дата начала обучения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата окончания обучения:";
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(12, 211);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 6;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(150, 211);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 7;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(286, 211);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 8;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Image = global::PrivateSchoolWF.Properties.Resources.printIcon;
            this.printButton.Location = new System.Drawing.Point(338, 259);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(32, 32);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 9;
            this.printButton.TabStop = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dateEducDoc
            // 
            this.dateEducDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEducDoc.CustomFormat = "yyyy-MM-dd";
            this.dateEducDoc.Enabled = false;
            this.dateEducDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEducDoc.Location = new System.Drawing.Point(208, 140);
            this.dateEducDoc.Name = "dateEducDoc";
            this.dateEducDoc.Size = new System.Drawing.Size(121, 23);
            this.dateEducDoc.TabIndex = 10;
            // 
            // dateSingDoc
            // 
            this.dateSingDoc.AutoSize = true;
            this.dateSingDoc.Location = new System.Drawing.Point(46, 146);
            this.dateSingDoc.Name = "dateSingDoc";
            this.dateSingDoc.Size = new System.Drawing.Size(159, 15);
            this.dateSingDoc.TabIndex = 11;
            this.dateSingDoc.Text = "Дата заключения договора:";
            // 
            // mainEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 293);
            this.Controls.Add(this.dateSingDoc);
            this.Controls.Add(this.dateEducDoc);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBeginLabel);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.courseAssigBox);
            this.Controls.Add(this.fioStudentBox);
            this.Name = "mainEditPage";
            this.Text = "mainEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox fioStudentBox;
        private ComboBox courseAssigBox;
        private DateTimePicker dateBegin;
        private DateTimePicker dateEnd;
        private Label dateBeginLabel;
        private Label label2;
        private Button changeRow;
        private Button addRow;
        private Button deleteRow;
        private PictureBox printButton;
        private DateTimePicker dateEducDoc;
        private Label dateSingDoc;
    }
}