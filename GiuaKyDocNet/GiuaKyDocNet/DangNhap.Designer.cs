namespace GiuaKyDocNet
{
    partial class DangNhap
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userTBox = new System.Windows.Forms.TextBox();
            this.passTBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(28, 63);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Tên đăng nhập";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(28, 124);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(75, 20);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Mật khẩu";
            // 
            // userTBox
            // 
            this.userTBox.Location = new System.Drawing.Point(199, 60);
            this.userTBox.Name = "userTBox";
            this.userTBox.Size = new System.Drawing.Size(187, 26);
            this.userTBox.TabIndex = 2;
            this.userTBox.TextChanged += new System.EventHandler(this.userTBox_TextChanged);
            // 
            // passTBox
            // 
            this.passTBox.Location = new System.Drawing.Point(199, 121);
            this.passTBox.Name = "passTBox";
            this.passTBox.Size = new System.Drawing.Size(187, 26);
            this.passTBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(199, 178);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 30);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Đăng Nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 294);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTBox);
            this.Controls.Add(this.userTBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userTBox;
        private System.Windows.Forms.TextBox passTBox;
        private System.Windows.Forms.Button loginButton;
    }
}

