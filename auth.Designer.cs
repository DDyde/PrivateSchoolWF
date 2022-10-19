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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.authLabel = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.PictureBox();
            this.hidePass = new System.Windows.Forms.PictureBox();
            this.authButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(280, 341);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(353, 39);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(280, 252);
            this.loginBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин/Почта";
            this.loginBox.Size = new System.Drawing.Size(353, 39);
            this.loginBox.TabIndex = 1;
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authLabel.Location = new System.Drawing.Point(280, 194);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(353, 54);
            this.authLabel.TabIndex = 2;
            this.authLabel.Text = "Аутентификация";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPass
            // 
            this.showPass.Image = global::PrivateSchoolWF.Properties.Resources.closeEyeIcon;
            this.showPass.InitialImage = null;
            this.showPass.Location = new System.Drawing.Point(639, 454);
            this.showPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(37, 39);
            this.showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPass.TabIndex = 4;
            this.showPass.TabStop = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // hidePass
            // 
            this.hidePass.Image = global::PrivateSchoolWF.Properties.Resources.openEyeIcon;
            this.hidePass.Location = new System.Drawing.Point(639, 341);
            this.hidePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hidePass.Name = "hidePass";
            this.hidePass.Size = new System.Drawing.Size(37, 39);
            this.hidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePass.TabIndex = 5;
            this.hidePass.TabStop = false;
            this.hidePass.Visible = false;
            this.hidePass.Click += new System.EventHandler(this.hidePass_Click);
            // 
            // authButton
            // 
            this.authButton.AutoRoundedCorners = true;
            this.authButton.BorderRadius = 27;
            this.authButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.authButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.authButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.authButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.authButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.authButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(280, 453);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(353, 56);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Войти";
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.authLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.showPass, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.hidePass, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.loginBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.authButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 600);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auth";
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox passwordBox;
        private TextBox loginBox;
        private Label authLabel;
        private PictureBox showPass;
        private PictureBox hidePass;
        private Guna.UI2.WinForms.Guna2Button authButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}