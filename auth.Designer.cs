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
            this.authButton = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.PictureBox();
            this.hidePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(295, 275);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(210, 32);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(295, 224);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин/Почта";
            this.loginBox.Size = new System.Drawing.Size(210, 32);
            this.loginBox.TabIndex = 1;
            // 
            // authLabel
            // 
            this.authLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authLabel.AutoSize = true;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authLabel.Location = new System.Drawing.Point(273, 129);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(263, 45);
            this.authLabel.TabIndex = 2;
            this.authLabel.Text = "Аутентификация";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(355, 328);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(75, 23);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // showPass
            // 
            this.showPass.Image = global::PrivateSchoolWF.Properties.Resources.closeEyeIcon;
            this.showPass.InitialImage = null;
            this.showPass.Location = new System.Drawing.Point(511, 275);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(32, 32);
            this.showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPass.TabIndex = 4;
            this.showPass.TabStop = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // hidePass
            // 
            this.hidePass.Image = global::PrivateSchoolWF.Properties.Resources.openEyeIcon;
            this.hidePass.Location = new System.Drawing.Point(511, 275);
            this.hidePass.Name = "hidePass";
            this.hidePass.Size = new System.Drawing.Size(32, 32);
            this.hidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePass.TabIndex = 5;
            this.hidePass.TabStop = false;
            this.hidePass.Visible = false;
            this.hidePass.Click += new System.EventHandler(this.hidePass_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hidePass);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passwordBox);
            this.Name = "auth";
            this.Text = "auth";
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox passwordBox;
        private TextBox loginBox;
        private Label authLabel;
        private Button authButton;
        private PictureBox showPass;
        private PictureBox hidePass;
    }
}