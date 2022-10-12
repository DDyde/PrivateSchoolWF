namespace PrivateSchoolWF.pages.parent
{
    partial class parentPage
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
            this.parentListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentListGrid
            // 
            this.parentListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parentListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.parentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentListGrid.Location = new System.Drawing.Point(0, 0);
            this.parentListGrid.Name = "parentListGrid";
            this.parentListGrid.RowTemplate.Height = 25;
            this.parentListGrid.Size = new System.Drawing.Size(600, 450);
            this.parentListGrid.TabIndex = 0;
            this.parentListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentListGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addRowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(45, 42);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(111, 23);
            this.addRowButton.TabIndex = 0;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.UseVisualStyleBackColor = true;
            // 
            // parentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parentListGrid);
            this.Name = "parentPage";
            this.Text = "parentPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parentPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.parentListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView parentListGrid;
        private Panel panel1;
        private Button addRowButton;
    }
}