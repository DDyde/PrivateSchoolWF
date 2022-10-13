namespace PrivateSchoolWF.pages.courseType
{
    partial class courseTypeEditPage
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
            this.courseTypeBox = new System.Windows.Forms.TextBox();
            this.addRow = new System.Windows.Forms.Button();
            this.chengeRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseTypeBox
            // 
            this.courseTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseTypeBox.Location = new System.Drawing.Point(12, 44);
            this.courseTypeBox.Name = "courseTypeBox";
            this.courseTypeBox.Size = new System.Drawing.Size(281, 23);
            this.courseTypeBox.TabIndex = 0;
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(115, 126);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 1;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // chengeRow
            // 
            this.chengeRow.Location = new System.Drawing.Point(12, 126);
            this.chengeRow.Name = "chengeRow";
            this.chengeRow.Size = new System.Drawing.Size(75, 23);
            this.chengeRow.TabIndex = 2;
            this.chengeRow.Text = "Изменить";
            this.chengeRow.UseVisualStyleBackColor = true;
            this.chengeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(218, 126);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 3;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // courseTypeEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 202);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.chengeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.courseTypeBox);
            this.Name = "courseTypeEditPage";
            this.Text = "courseTypeEditPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox courseTypeBox;
        private Button addRow;
        private Button chengeRow;
        private Button deleteRow;
    }
}