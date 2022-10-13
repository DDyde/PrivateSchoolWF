namespace PrivateSchoolWF.pages.user
{
    partial class userEditPage
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
            this.fioEmployeeBox = new System.Windows.Forms.ComboBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.addRow = new System.Windows.Forms.Button();
            this.changeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioEmployeeBox
            // 
            this.fioEmployeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fioEmployeeBox.FormattingEnabled = true;
            this.fioEmployeeBox.Location = new System.Drawing.Point(12, 12);
            this.fioEmployeeBox.Name = "fioEmployeeBox";
            this.fioEmployeeBox.Size = new System.Drawing.Size(267, 23);
            this.fioEmployeeBox.TabIndex = 0;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 41);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(267, 23);
            this.loginBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(12, 70);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(267, 23);
            this.emailBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 99);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(267, 23);
            this.passwordBox.TabIndex = 3;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(110, 179);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 4;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(12, 179);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 5;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(204, 179);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 6;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // userEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 256);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.fioEmployeeBox);
            this.Name = "userEditPage";
            this.Text = "userEditPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox fioEmployeeBox;
        private TextBox loginBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Button addRow;
        private Button changeRow;
        private Button deleteRow;
    }
}