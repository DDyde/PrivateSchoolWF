namespace PrivateSchoolWF.pages.parent
{
    partial class parentEditPage
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
            this.surnameParent = new System.Windows.Forms.TextBox();
            this.nameParent = new System.Windows.Forms.TextBox();
            this.middlenameParent = new System.Windows.Forms.TextBox();
            this.changeRow = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surnameParent
            // 
            this.surnameParent.Location = new System.Drawing.Point(12, 12);
            this.surnameParent.Name = "surnameParent";
            this.surnameParent.Size = new System.Drawing.Size(350, 23);
            this.surnameParent.TabIndex = 0;
            // 
            // nameParent
            // 
            this.nameParent.Location = new System.Drawing.Point(12, 41);
            this.nameParent.Name = "nameParent";
            this.nameParent.Size = new System.Drawing.Size(350, 23);
            this.nameParent.TabIndex = 1;
            // 
            // middlenameParent
            // 
            this.middlenameParent.Location = new System.Drawing.Point(12, 70);
            this.middlenameParent.Name = "middlenameParent";
            this.middlenameParent.Size = new System.Drawing.Size(350, 23);
            this.middlenameParent.TabIndex = 2;
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(12, 146);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 3;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(144, 146);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 4;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(287, 146);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 5;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // parentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 201);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.middlenameParent);
            this.Controls.Add(this.nameParent);
            this.Controls.Add(this.surnameParent);
            this.Name = "parentEditPage";
            this.Text = "parentEditPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameParent;
        private TextBox nameParent;
        private TextBox middlenameParent;
        private Button changeRow;
        private Button addRow;
        private Button deleteRow;
    }
}