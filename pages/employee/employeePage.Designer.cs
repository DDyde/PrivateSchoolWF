namespace PrivateSchoolWF.pages.employee
{
    partial class employeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeePage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addRowButton = new Guna.UI2.WinForms.Guna2Button();
            this.employeeListGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.filterEmployee = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.positionComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.positionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchEmployeeBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGrid)).BeginInit();
            this.filterEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.addRowButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeListGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterEmployee, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 450);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.addRowButton.Location = new System.Drawing.Point(836, 47);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(114, 45);
            this.addRowButton.TabIndex = 0;
            this.addRowButton.Text = "Добавить запись";
            this.addRowButton.Click += new System.EventHandler(this.addRowBotton_Click);
            // 
            // employeeListGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.employeeListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeListGrid.ColumnHeadersHeight = 35;
            this.employeeListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeListGrid.Location = new System.Drawing.Point(3, 3);
            this.employeeListGrid.Name = "employeeListGrid";
            this.employeeListGrid.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.employeeListGrid, 3);
            this.employeeListGrid.RowTemplate.Height = 25;
            this.employeeListGrid.Size = new System.Drawing.Size(815, 444);
            this.employeeListGrid.TabIndex = 1;
            this.employeeListGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeListGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employeeListGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.employeeListGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employeeListGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employeeListGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.employeeListGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeListGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employeeListGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employeeListGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeListGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employeeListGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employeeListGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.employeeListGrid.ThemeStyle.ReadOnly = false;
            this.employeeListGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeListGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeListGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeListGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employeeListGrid.ThemeStyle.RowsStyle.Height = 25;
            this.employeeListGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.employeeListGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.employeeListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeListGrid_CellClick);
            // 
            // filterEmployee
            // 
            this.filterEmployee.Controls.Add(this.cancelButton);
            this.filterEmployee.Controls.Add(this.positionComboBox);
            this.filterEmployee.Controls.Add(this.guna2Separator1);
            this.filterEmployee.Controls.Add(this.positionLabel);
            this.filterEmployee.Controls.Add(this.searchEmployeeBox);
            this.filterEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterEmployee.Location = new System.Drawing.Point(824, 104);
            this.filterEmployee.Name = "filterEmployee";
            this.filterEmployee.Size = new System.Drawing.Size(139, 343);
            this.filterEmployee.TabIndex = 2;
            this.filterEmployee.Text = "Фильтр";
            // 
            // cancelButton
            // 
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(0, 298);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 45);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Сброс";
            // 
            // positionComboBox
            // 
            this.positionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.positionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.positionComboBox.ItemHeight = 30;
            this.positionComboBox.Location = new System.Drawing.Point(3, 122);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(133, 36);
            this.positionComboBox.TabIndex = 3;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.positionComboBox_SelectedIndexChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Silver;
            this.guna2Separator1.Location = new System.Drawing.Point(29, 80);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(82, 13);
            this.guna2Separator1.TabIndex = 2;
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.Location = new System.Drawing.Point(38, 98);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(65, 17);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Должность";
            this.positionLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchEmployeeBox
            // 
            this.searchEmployeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEmployeeBox.Location = new System.Drawing.Point(3, 51);
            this.searchEmployeeBox.Name = "searchEmployeeBox";
            this.searchEmployeeBox.PlaceholderText = "Поиск...";
            this.searchEmployeeBox.Size = new System.Drawing.Size(133, 23);
            this.searchEmployeeBox.TabIndex = 0;
            this.searchEmployeeBox.TextChanged += new System.EventHandler(this.searchEmployeeBox_TextChanged);
            // 
            // employeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(863, 416);
            this.Name = "employeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employeePage_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGrid)).EndInit();
            this.filterEmployee.ResumeLayout(false);
            this.filterEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button addRowButton;
        private Guna.UI2.WinForms.Guna2DataGridView employeeListGrid;
        private Guna.UI2.WinForms.Guna2GroupBox filterEmployee;
        private TextBox searchEmployeeBox;
        private Guna.UI2.WinForms.Guna2ComboBox positionComboBox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel positionLabel;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
    }
}