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
            this.workExEmployee = new System.Windows.Forms.NumericUpDown();
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            this.positionEmployeeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.workExEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameEmployeeBox
            // 
            this.surnameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameEmployeeBox.Location = new System.Drawing.Point(14, 16);
            this.surnameEmployeeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameEmployeeBox.Name = "surnameEmployeeBox";
            this.surnameEmployeeBox.PlaceholderText = "Фамилия";
            this.surnameEmployeeBox.Size = new System.Drawing.Size(350, 27);
            this.surnameEmployeeBox.TabIndex = 0;
            // 
            // nameEmployeeBox
            // 
            this.nameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEmployeeBox.Location = new System.Drawing.Point(14, 55);
            this.nameEmployeeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameEmployeeBox.Name = "nameEmployeeBox";
            this.nameEmployeeBox.PlaceholderText = "Имя";
            this.nameEmployeeBox.Size = new System.Drawing.Size(350, 27);
            this.nameEmployeeBox.TabIndex = 1;
            // 
            // middlenameEmployeeBox
            // 
            this.middlenameEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameEmployeeBox.Location = new System.Drawing.Point(14, 93);
            this.middlenameEmployeeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middlenameEmployeeBox.Name = "middlenameEmployeeBox";
            this.middlenameEmployeeBox.PlaceholderText = "Отчество";
            this.middlenameEmployeeBox.Size = new System.Drawing.Size(350, 27);
            this.middlenameEmployeeBox.TabIndex = 2;
            // 
            // workExEmployee
            // 
            this.workExEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workExEmployee.Location = new System.Drawing.Point(14, 191);
            this.workExEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workExEmployee.Name = "workExEmployee";
            this.workExEmployee.Size = new System.Drawing.Size(144, 27);
            this.workExEmployee.TabIndex = 4;
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
            this.deleteRow.Location = new System.Drawing.Point(262, 242);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(106, 41);
            this.deleteRow.TabIndex = 22;
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
            this.changeRow.Location = new System.Drawing.Point(13, 242);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(106, 41);
            this.changeRow.TabIndex = 21;
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
            this.addRow.Location = new System.Drawing.Point(137, 242);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(106, 41);
            this.addRow.TabIndex = 20;
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // positionEmployeeBox
            // 
            this.positionEmployeeBox.BackColor = System.Drawing.Color.Transparent;
            this.positionEmployeeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.positionEmployeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionEmployeeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionEmployeeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionEmployeeBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionEmployeeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.positionEmployeeBox.ItemHeight = 30;
            this.positionEmployeeBox.Location = new System.Drawing.Point(14, 138);
            this.positionEmployeeBox.Name = "positionEmployeeBox";
            this.positionEmployeeBox.Size = new System.Drawing.Size(350, 36);
            this.positionEmployeeBox.TabIndex = 23;
            // 
            // employeeEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 324);
            this.Controls.Add(this.positionEmployeeBox);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.workExEmployee);
            this.Controls.Add(this.middlenameEmployeeBox);
            this.Controls.Add(this.nameEmployeeBox);
            this.Controls.Add(this.surnameEmployeeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private NumericUpDown workExEmployee;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button addRow;
        private Guna.UI2.WinForms.Guna2ComboBox positionEmployeeBox;
    }
}