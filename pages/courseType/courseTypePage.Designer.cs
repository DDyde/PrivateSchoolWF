﻿namespace PrivateSchoolWF.pages.courseType
{
    partial class courseTypePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRowButton = new System.Windows.Forms.Button();
            this.courseTypeListGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTypeListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addRowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(49, 42);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(108, 23);
            this.addRowButton.TabIndex = 0;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowBotton_Click);
            // 
            // courseTypeListGrid
            // 
            this.courseTypeListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseTypeListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseTypeListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.courseTypeListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseTypeListGrid.Location = new System.Drawing.Point(0, 0);
            this.courseTypeListGrid.Name = "courseTypeListGrid";
            this.courseTypeListGrid.RowTemplate.Height = 25;
            this.courseTypeListGrid.Size = new System.Drawing.Size(601, 450);
            this.courseTypeListGrid.TabIndex = 1;
            this.courseTypeListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseTypeListGrid_CellClick);
            // 
            // courseTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseTypeListGrid);
            this.Controls.Add(this.panel1);
            this.Name = "courseTypePage";
            this.Text = "courseTypePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.courseTypePage_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseTypeListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button addRowButton;
        private DataGridView courseTypeListGrid;
    }
}