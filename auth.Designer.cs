namespace PrivateSchoolWF
{
    partial class auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.authLabel = new System.Windows.Forms.Label();
            this.authButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showHidePassButton = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(246, 245);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(308, 32);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(246, 189);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин/Почта";
            this.loginBox.Size = new System.Drawing.Size(308, 32);
            this.loginBox.TabIndex = 1;
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authLabel.Location = new System.Drawing.Point(246, 126);
            this.authLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(308, 45);
            this.authLabel.TabIndex = 2;
            this.authLabel.Text = "Аутентификация";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authButton
            // 
            this.authButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.authButton.Animated = true;
            this.authButton.AutoRoundedCorners = true;
            this.authButton.BorderRadius = 18;
            this.authButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.authButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.authButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.authButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.authButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(338, 306);
            this.authButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(123, 39);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Войти";
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.authLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.authButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.showHidePassButton, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // showHidePassButton
            // 
            this.showHidePassButton.CheckedState.Image = global::PrivateSchoolWF.Properties.Resources.openEyeIcon;
            this.showHidePassButton.Image = global::PrivateSchoolWF.Properties.Resources.closeEyeIcon;
            this.showHidePassButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.showHidePassButton.ImageRotate = 0F;
            this.showHidePassButton.Location = new System.Drawing.Point(560, 244);
            this.showHidePassButton.Name = "showHidePassButton";
            this.showHidePassButton.Size = new System.Drawing.Size(32, 32);
            this.showHidePassButton.TabIndex = 5;
            this.showHidePassButton.Click += new System.EventHandler(this.showHidePassButton_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox passwordBox;
        private TextBox loginBox;
        private Label authLabel;
        private Guna.UI2.WinForms.Guna2Button authButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox showHidePassButton;
    }
}