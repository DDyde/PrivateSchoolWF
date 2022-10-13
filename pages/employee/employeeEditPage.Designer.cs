namespace PrivateSchoolWF.pages.employee
{
    partial class employeeEditPage
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
            this.surnameEmployeeBox = new System.Windows.Forms.TextBox();
            this.nameEmployeeBox = new System.Windows.Forms.TextBox();
            this.middlenameEmployeeBox = new System.Windows.Forms.TextBox();
            this.positionEmployeeBox = new System.Windows.Forms.ComboBox();
            this.workExEmployee = new System.Windows.Forms.NumericUpDown();
            this.addRow = new System.Windows.Forms.Button();
            this.changeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workExEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameEmployeeBox
            // 
            this.surnameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameEmployeeBox.Location = new System.Drawing.Point(12, 12);
            this.surnameEmployeeBox.Name = "surnameEmployeeBox";
            this.surnameEmployeeBox.Size = new System.Drawing.Size(301, 23);
            this.surnameEmployeeBox.TabIndex = 0;
            // 
            // nameEmployeeBox
            // 
            this.nameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEmployeeBox.Location = new System.Drawing.Point(12, 41);
            this.nameEmployeeBox.Name = "nameEmployeeBox";
            this.nameEmployeeBox.Size = new System.Drawing.Size(301, 23);
            this.nameEmployeeBox.TabIndex = 1;
            // 
            // middlenameEmployeeBox
            // 
            this.middlenameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameEmployeeBox.Location = new System.Drawing.Point(12, 70);
            this.middlenameEmployeeBox.Name = "middlenameEmployeeBox";
            this.middlenameEmployeeBox.Size = new System.Drawing.Size(301, 23);
            this.middlenameEmployeeBox.TabIndex = 2;
            // 
            // positionEmployeeBox
            // 
            this.positionEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionEmployeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionEmployeeBox.FormattingEnabled = true;
            this.positionEmployeeBox.Location = new System.Drawing.Point(12, 99);
            this.positionEmployeeBox.Name = "positionEmployeeBox";
            this.positionEmployeeBox.Size = new System.Drawing.Size(301, 23);
            this.positionEmployeeBox.TabIndex = 3;
            // 
            // workExEmployee
            // 
            this.workExEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workExEmployee.Location = new System.Drawing.Point(12, 128);
            this.workExEmployee.Name = "workExEmployee";
            this.workExEmployee.Size = new System.Drawing.Size(120, 23);
            this.workExEmployee.TabIndex = 4;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(128, 201);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 5;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(12, 201);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 6;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(238, 201);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 7;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // employeeEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 274);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.workExEmployee);
            this.Controls.Add(this.positionEmployeeBox);
            this.Controls.Add(this.middlenameEmployeeBox);
            this.Controls.Add(this.nameEmployeeBox);
            this.Controls.Add(this.surnameEmployeeBox);
            this.Name = "employeeEditPage";
            this.Text = "employeeEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.workExEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameEmployeeBox;
        private TextBox nameEmployeeBox;
        private TextBox middlenameEmployeeBox;
        private ComboBox positionEmployeeBox;
        private NumericUpDown workExEmployee;
        private Button addRow;
        private Button changeRow;
        private Button deleteRow;
    }
}