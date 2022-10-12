namespace PrivateSchoolWF.MainPage
{
    partial class studentPage
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
            this.studentListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRowBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListGrid
            // 
            this.studentListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListGrid.Location = new System.Drawing.Point(0, 0);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.RowTemplate.Height = 25;
            this.studentListGrid.Size = new System.Drawing.Size(607, 433);
            this.studentListGrid.TabIndex = 0;
            this.studentListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addRowBotton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(607, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 433);
            this.panel1.TabIndex = 1;
            // 
            // addRowBotton
            // 
            this.addRowBotton.Location = new System.Drawing.Point(39, 34);
            this.addRowBotton.Name = "addRowBotton";
            this.addRowBotton.Size = new System.Drawing.Size(114, 53);
            this.addRowBotton.TabIndex = 0;
            this.addRowBotton.Text = "Добавить запись";
            this.addRowBotton.UseVisualStyleBackColor = true;
            this.addRowBotton.Click += new System.EventHandler(this.addRowBotton_Click);
            // 
            // studentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentListGrid);
            this.Name = "studentPage";
            this.Text = "Студенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView studentListGrid;
        private Panel panel1;
        private Button addRowBotton;
    }
}