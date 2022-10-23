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
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // surnameParent
            // 
            this.surnameParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameParent.Location = new System.Drawing.Point(12, 12);
            this.surnameParent.Name = "surnameParent";
            this.surnameParent.PlaceholderText = "Фамилия";
            this.surnameParent.Size = new System.Drawing.Size(350, 23);
            this.surnameParent.TabIndex = 0;
            // 
            // nameParent
            // 
            this.nameParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameParent.Location = new System.Drawing.Point(12, 41);
            this.nameParent.Name = "nameParent";
            this.nameParent.PlaceholderText = "Имя";
            this.nameParent.Size = new System.Drawing.Size(350, 23);
            this.nameParent.TabIndex = 1;
            // 
            // middlenameParent
            // 
            this.middlenameParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlenameParent.Location = new System.Drawing.Point(12, 70);
            this.middlenameParent.Name = "middlenameParent";
            this.middlenameParent.PlaceholderText = "Отчество";
            this.middlenameParent.Size = new System.Drawing.Size(350, 23);
            this.middlenameParent.TabIndex = 2;
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
            this.deleteRow.Location = new System.Drawing.Point(243, 126);
            this.deleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(93, 31);
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
            this.changeRow.Location = new System.Drawing.Point(25, 126);
            this.changeRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(93, 31);
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
            this.addRow.Location = new System.Drawing.Point(134, 126);
            this.addRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(93, 31);
            this.addRow.TabIndex = 20;
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // parentEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 201);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.middlenameParent);
            this.Controls.Add(this.nameParent);
            this.Controls.Add(this.surnameParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "parentEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameParent;
        private TextBox nameParent;
        private TextBox middlenameParent;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button addRow;
    }
}