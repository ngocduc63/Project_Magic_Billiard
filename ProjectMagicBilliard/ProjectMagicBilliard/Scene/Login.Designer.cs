
namespace ProjectMagicBilliard.Scene
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.modernLabel1 = new DevLib.ModernUI.Forms.ModernLabel();
            this.modernLabel2 = new DevLib.ModernUI.Forms.ModernLabel();
            this.modernLabel3 = new DevLib.ModernUI.Forms.ModernLabel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new DevLib.ModernUI.Forms.ModernButton();
            this.btnExit = new DevLib.ModernUI.Forms.ModernButton();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(1, 375);
            this.StatusStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusStrip.Size = new System.Drawing.Size(603, 20);
            // 
            // modernLabel1
            // 
            this.modernLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.modernLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modernLabel1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.modernLabel1.Location = new System.Drawing.Point(77, 35);
            this.modernLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modernLabel1.Name = "modernLabel1";
            this.modernLabel1.Size = new System.Drawing.Size(500, 50);
            this.modernLabel1.TabIndex = 0;
            this.modernLabel1.Text = "Đăng nhập hệ thống";
            this.modernLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modernLabel1.UseStyleColors = false;
            // 
            // modernLabel2
            // 
            this.modernLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.modernLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modernLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernLabel2.Location = new System.Drawing.Point(55, 144);
            this.modernLabel2.Name = "modernLabel2";
            this.modernLabel2.Size = new System.Drawing.Size(150, 40);
            this.modernLabel2.TabIndex = 0;
            this.modernLabel2.Text = "Tài khoản:";
            this.modernLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modernLabel2.UseStyleColors = false;
            // 
            // modernLabel3
            // 
            this.modernLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.modernLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modernLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernLabel3.Location = new System.Drawing.Point(55, 196);
            this.modernLabel3.Name = "modernLabel3";
            this.modernLabel3.Size = new System.Drawing.Size(150, 40);
            this.modernLabel3.TabIndex = 0;
            this.modernLabel3.Text = "Mật khẩu:";
            this.modernLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modernLabel3.UseStyleColors = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(211, 139);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 35);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(209, 192);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(300, 35);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.FontSize = DevLib.ModernUI.Drawing.ModernFontSize.Large;
            this.btnLogin.Location = new System.Drawing.Point(366, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = false;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.FontSize = DevLib.ModernUI.Drawing.ModernFontSize.Large;
            this.btnExit.Location = new System.Drawing.Point(85, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.ControlBoxCustomBackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.modernLabel3);
            this.Controls.Add(this.modernLabel2);
            this.Controls.Add(this.modernLabel1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.ShadowType = DevLib.ModernUI.Forms.ModernFormShadowType.None;
            this.ShowStatusStrip = true;
            this.UseCustomBackColor = true;
            this.Controls.SetChildIndex(this.modernLabel1, 0);
            this.Controls.SetChildIndex(this.modernLabel2, 0);
            this.Controls.SetChildIndex(this.modernLabel3, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtPassWord, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.StatusStrip, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevLib.ModernUI.Forms.ModernLabel modernLabel1;
        private DevLib.ModernUI.Forms.ModernLabel modernLabel2;
        private DevLib.ModernUI.Forms.ModernLabel modernLabel3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private DevLib.ModernUI.Forms.ModernButton btnLogin;
        private DevLib.ModernUI.Forms.ModernButton btnExit;
    }
}