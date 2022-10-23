namespace PrivateSchoolWF.pages.user
{
    partial class userPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addRowButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterUser = new Guna.UI2.WinForms.Guna2GroupBox();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            this.filterUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.64463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.35537F));
            this.tableLayoutPanel1.Controls.Add(this.userListGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addRowButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.filterUser, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.16666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(847, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userListGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userListGrid.ColumnHeadersHeight = 35;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.userListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userListGrid.Location = new System.Drawing.Point(3, 3);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.RowHeadersVisible = false;
            this.userListGrid.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.userListGrid, 3);
            this.userListGrid.RowTemplate.Height = 25;
            this.userListGrid.Size = new System.Drawing.Size(694, 444);
            this.userListGrid.TabIndex = 0;
            this.userListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userListGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userListGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userListGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.userListGrid.ThemeStyle.ReadOnly = false;
            this.userListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userListGrid.ThemeStyle.RowsStyle.Height = 25;
            this.userListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userListGrid_CellClick);
            // 
            // addRowButton
            // 
            this.addRowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addRowButton.Animated = true;
            this.addRowButton.AutoRoundedCorners = true;
            this.addRowButton.BorderRadius = 21;
            this.addRowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRowButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRowButton.ForeColor = System.Drawing.Color.White;
            this.addRowButton.Location = new System.Drawing.Point(717, 48);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(113, 45);
            this.addRowButton.TabIndex = 1;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.Click += new System.EventHandler(this.addRowBotton_Click);
            // 
            // filterUser
            // 
            this.filterUser.Controls.Add(this.userSearchBox);
            this.filterUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterUser.Location = new System.Drawing.Point(703, 109);
            this.filterUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterUser.Name = "filterUser";
            this.filterUser.Size = new System.Drawing.Size(141, 339);
            this.filterUser.TabIndex = 2;
            this.filterUser.Text = "Фильтр";
            // 
            // userSearchBox
            // 
            this.userSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userSearchBox.Location = new System.Drawing.Point(3, 46);
            this.userSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.PlaceholderText = "Поиск...";
            this.userSearchBox.Size = new System.Drawing.Size(135, 23);
            this.userSearchBox.TabIndex = 0;
            this.userSearchBox.TextChanged += new System.EventHandler(this.userSearchBox_TextChanged);
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(863, 414);
            this.Name = "userPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userPage_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            this.filterUser.ResumeLayout(false);
            this.filterUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView userListGrid;
        private Guna.UI2.WinForms.Guna2Button addRowButton;
        private Guna.UI2.WinForms.Guna2GroupBox filterUser;
        private TextBox userSearchBox;
    }
}