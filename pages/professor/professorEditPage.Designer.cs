namespace PrivateSchoolWF.pages.professor
{
    partial class professorEditPage
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
            this.surnameProfessor = new System.Windows.Forms.TextBox();
            this.nameProfessor = new System.Windows.Forms.TextBox();
            this.middlenameProfessor = new System.Windows.Forms.TextBox();
            this.professorWorkExp = new System.Windows.Forms.NumericUpDown();
            this.professorImage = new System.Windows.Forms.PictureBox();
            this.professorQualification = new System.Windows.Forms.RichTextBox();
            this.workExpLabel = new System.Windows.Forms.Label();
            this.updateProfessorImg = new System.Windows.Forms.Button();
            this.deleteRow = new Guna.UI2.WinForms.Guna2Button();
            this.changeRow = new Guna.UI2.WinForms.Guna2Button();
            this.addRow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.professorWorkExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameProfessor
            // 
            this.surnameProfessor.Location = new System.Drawing.Point(14, 16);
            this.surnameProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameProfessor.Name = "surnameProfessor";
            this.surnameProfessor.PlaceholderText = "Фамилия";
            this.surnameProfessor.Size = new System.Drawing.Size(357, 27);
            this.surnameProfessor.TabIndex = 0;
            this.surnameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // nameProfessor
            // 
            this.nameProfessor.Location = new System.Drawing.Point(14, 55);
            this.nameProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameProfessor.Name = "nameProfessor";
            this.nameProfessor.PlaceholderText = "Имя";
            this.nameProfessor.Size = new System.Drawing.Size(357, 27);
            this.nameProfessor.TabIndex = 1;
            this.nameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // middlenameProfessor
            // 
            this.middlenameProfessor.Location = new System.Drawing.Point(14, 93);
            this.middlenameProfessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middlenameProfessor.Name = "middlenameProfessor";
            this.middlenameProfessor.PlaceholderText = "Отчество";
            this.middlenameProfessor.Size = new System.Drawing.Size(357, 27);
            this.middlenameProfessor.TabIndex = 2;
            this.middlenameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // professorWorkExp
            // 
            this.professorWorkExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.professorWorkExp.Location = new System.Drawing.Point(584, 407);
            this.professorWorkExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professorWorkExp.Name = "professorWorkExp";
            this.professorWorkExp.Size = new System.Drawing.Size(82, 27);
            this.professorWorkExp.TabIndex = 3;
            // 
            // professorImage
            // 
            this.professorImage.Image = global::PrivateSchoolWF.Properties.Resources.closeEyeIcon;
            this.professorImage.Location = new System.Drawing.Point(378, 16);
            this.professorImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professorImage.Name = "professorImage";
            this.professorImage.Size = new System.Drawing.Size(288, 315);
            this.professorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.professorImage.TabIndex = 9;
            this.professorImage.TabStop = false;
            // 
            // professorQualification
            // 
            this.professorQualification.Location = new System.Drawing.Point(14, 132);
            this.professorQualification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professorQualification.Name = "professorQualification";
            this.professorQualification.Size = new System.Drawing.Size(357, 375);
            this.professorQualification.TabIndex = 10;
            this.professorQualification.Text = "";
            // 
            // workExpLabel
            // 
            this.workExpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workExpLabel.AutoSize = true;
            this.workExpLabel.Location = new System.Drawing.Point(481, 409);
            this.workExpLabel.Name = "workExpLabel";
            this.workExpLabel.Size = new System.Drawing.Size(105, 20);
            this.workExpLabel.TabIndex = 11;
            this.workExpLabel.Text = "Опыт работы:";
            // 
            // updateProfessorImg
            // 
            this.updateProfessorImg.Location = new System.Drawing.Point(488, 340);
            this.updateProfessorImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateProfessorImg.Name = "updateProfessorImg";
            this.updateProfessorImg.Size = new System.Drawing.Size(86, 31);
            this.updateProfessorImg.TabIndex = 12;
            this.updateProfessorImg.Text = "Обновить";
            this.updateProfessorImg.UseVisualStyleBackColor = true;
            this.updateProfessorImg.Click += new System.EventHandler(this.updateProfessorImg_Click);
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
            this.deleteRow.Location = new System.Drawing.Point(404, 555);
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
            this.changeRow.Location = new System.Drawing.Point(155, 555);
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
            this.addRow.Location = new System.Drawing.Point(279, 555);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(106, 41);
            this.addRow.TabIndex = 20;
            this.addRow.Text = "Добавить";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // professorEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 627);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.updateProfessorImg);
            this.Controls.Add(this.workExpLabel);
            this.Controls.Add(this.professorQualification);
            this.Controls.Add(this.professorImage);
            this.Controls.Add(this.professorWorkExp);
            this.Controls.Add(this.middlenameProfessor);
            this.Controls.Add(this.nameProfessor);
            this.Controls.Add(this.surnameProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "professorEditPage";
            this.Text = "professorEditPage";
            ((System.ComponentModel.ISupportInitialize)(this.professorWorkExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox surnameProfessor;
        private TextBox nameProfessor;
        private TextBox middlenameProfessor;
        private NumericUpDown professorWorkExp;
        private PictureBox professorImage;
        private RichTextBox professorQualification;
        private Label workExpLabel;
        private Button updateProfessorImg;
        private Guna.UI2.WinForms.Guna2Button deleteRow;
        private Guna.UI2.WinForms.Guna2Button changeRow;
        private Guna.UI2.WinForms.Guna2Button addRow;
    }
}