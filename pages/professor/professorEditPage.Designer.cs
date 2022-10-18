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
            this.changeRow = new System.Windows.Forms.Button();
            this.addRow = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.professorImage = new System.Windows.Forms.PictureBox();
            this.professorQualification = new System.Windows.Forms.RichTextBox();
            this.workExpLabel = new System.Windows.Forms.Label();
            this.updateProfessorImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.professorWorkExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameProfessor
            // 
            this.surnameProfessor.Location = new System.Drawing.Point(12, 12);
            this.surnameProfessor.Name = "surnameProfessor";
            this.surnameProfessor.Size = new System.Drawing.Size(313, 23);
            this.surnameProfessor.TabIndex = 0;
            this.surnameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // nameProfessor
            // 
            this.nameProfessor.Location = new System.Drawing.Point(12, 41);
            this.nameProfessor.Name = "nameProfessor";
            this.nameProfessor.Size = new System.Drawing.Size(313, 23);
            this.nameProfessor.TabIndex = 1;
            this.nameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // middlenameProfessor
            // 
            this.middlenameProfessor.Location = new System.Drawing.Point(12, 70);
            this.middlenameProfessor.Name = "middlenameProfessor";
            this.middlenameProfessor.Size = new System.Drawing.Size(313, 23);
            this.middlenameProfessor.TabIndex = 2;
            this.middlenameProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameProfessor_KeyPress);
            // 
            // professorWorkExp
            // 
            this.professorWorkExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.professorWorkExp.Location = new System.Drawing.Point(511, 305);
            this.professorWorkExp.Name = "professorWorkExp";
            this.professorWorkExp.Size = new System.Drawing.Size(72, 23);
            this.professorWorkExp.TabIndex = 3;
            // 
            // changeRow
            // 
            this.changeRow.Location = new System.Drawing.Point(113, 439);
            this.changeRow.Name = "changeRow";
            this.changeRow.Size = new System.Drawing.Size(75, 23);
            this.changeRow.TabIndex = 6;
            this.changeRow.Text = "Изменить";
            this.changeRow.UseVisualStyleBackColor = true;
            this.changeRow.Click += new System.EventHandler(this.changeRow_Click);
            // 
            // addRow
            // 
            this.addRow.Location = new System.Drawing.Point(226, 439);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(75, 23);
            this.addRow.TabIndex = 7;
            this.addRow.Text = "Добавить";
            this.addRow.UseVisualStyleBackColor = true;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.Location = new System.Drawing.Point(346, 439);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(75, 23);
            this.deleteRow.TabIndex = 8;
            this.deleteRow.Text = "Удалить";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // professorImage
            // 
            this.professorImage.Image = global::PrivateSchoolWF.Properties.Resources.closeEyeIcon;
            this.professorImage.Location = new System.Drawing.Point(331, 12);
            this.professorImage.Name = "professorImage";
            this.professorImage.Size = new System.Drawing.Size(252, 236);
            this.professorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.professorImage.TabIndex = 9;
            this.professorImage.TabStop = false;
            // 
            // professorQualification
            // 
            this.professorQualification.Location = new System.Drawing.Point(12, 99);
            this.professorQualification.Name = "professorQualification";
            this.professorQualification.Size = new System.Drawing.Size(313, 282);
            this.professorQualification.TabIndex = 10;
            this.professorQualification.Text = "";
            // 
            // workExpLabel
            // 
            this.workExpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workExpLabel.AutoSize = true;
            this.workExpLabel.Location = new System.Drawing.Point(421, 307);
            this.workExpLabel.Name = "workExpLabel";
            this.workExpLabel.Size = new System.Drawing.Size(84, 15);
            this.workExpLabel.TabIndex = 11;
            this.workExpLabel.Text = "Опыт работы:";
            // 
            // updateProfessorImg
            // 
            this.updateProfessorImg.Location = new System.Drawing.Point(427, 255);
            this.updateProfessorImg.Name = "updateProfessorImg";
            this.updateProfessorImg.Size = new System.Drawing.Size(75, 23);
            this.updateProfessorImg.TabIndex = 12;
            this.updateProfessorImg.Text = "Обновить";
            this.updateProfessorImg.UseVisualStyleBackColor = true;
            this.updateProfessorImg.Visible = false;
            this.updateProfessorImg.Click += new System.EventHandler(this.updateProfessorImg_Click);
            // 
            // professorEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 470);
            this.Controls.Add(this.updateProfessorImg);
            this.Controls.Add(this.workExpLabel);
            this.Controls.Add(this.professorQualification);
            this.Controls.Add(this.professorImage);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.changeRow);
            this.Controls.Add(this.professorWorkExp);
            this.Controls.Add(this.middlenameProfessor);
            this.Controls.Add(this.nameProfessor);
            this.Controls.Add(this.surnameProfessor);
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
        private Button changeRow;
        private Button addRow;
        private Button deleteRow;
        private PictureBox professorImage;
        private RichTextBox professorQualification;
        private Label workExpLabel;
        private Button updateProfessorImg;
    }
}