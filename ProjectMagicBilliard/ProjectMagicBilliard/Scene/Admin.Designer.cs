
namespace ProjectMagicBilliard.Scene
{
    partial class Admin
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnLoaiBan = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnDoAn = new System.Windows.Forms.Button();
            this.btnLoaiDoAn = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_header.Controls.Add(this.btnExit);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Location = new System.Drawing.Point(179, 5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(718, 100);
            this.panel_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.btnBan);
            this.panel.Controls.Add(this.btnLoaiBan);
            this.panel.Controls.Add(this.btnCV);
            this.panel.Controls.Add(this.btnKH);
            this.panel.Controls.Add(this.btnDoAn);
            this.panel.Controls.Add(this.btnLoaiDoAn);
            this.panel.Controls.Add(this.btnNV);
            this.panel.Controls.Add(this.btnTK);
            this.panel.Location = new System.Drawing.Point(0, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 615);
            this.panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjectMagicBilliard.Properties.Resources.b8cf7fe623e3042788bc8013fbcfcdc1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBan.Location = new System.Drawing.Point(0, 532);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(180, 57);
            this.btnBan.TabIndex = 7;
            this.btnBan.Text = "Quản lý bàn";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnLoaiBan
            // 
            this.btnLoaiBan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLoaiBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoaiBan.Location = new System.Drawing.Point(0, 476);
            this.btnLoaiBan.Name = "btnLoaiBan";
            this.btnLoaiBan.Size = new System.Drawing.Size(180, 57);
            this.btnLoaiBan.TabIndex = 6;
            this.btnLoaiBan.Text = "Quản lý Loại bàn";
            this.btnLoaiBan.UseVisualStyleBackColor = false;
            this.btnLoaiBan.Click += new System.EventHandler(this.btnLoaiBan_Click);
            // 
            // btnCV
            // 
            this.btnCV.BackColor = System.Drawing.Color.LightGray;
            this.btnCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCV.Location = new System.Drawing.Point(0, 420);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(180, 57);
            this.btnCV.TabIndex = 5;
            this.btnCV.Text = "Quản lý chức vụ";
            this.btnCV.UseVisualStyleBackColor = false;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.Silver;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnKH.Location = new System.Drawing.Point(0, 364);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(180, 57);
            this.btnKH.TabIndex = 4;
            this.btnKH.Text = "Quản lý khách hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnDoAn
            // 
            this.btnDoAn.BackColor = System.Drawing.Color.DarkGray;
            this.btnDoAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoAn.Location = new System.Drawing.Point(0, 308);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Size = new System.Drawing.Size(180, 57);
            this.btnDoAn.TabIndex = 3;
            this.btnDoAn.Text = "Quản lý đồ ăn";
            this.btnDoAn.UseVisualStyleBackColor = false;
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // btnLoaiDoAn
            // 
            this.btnLoaiDoAn.BackColor = System.Drawing.Color.DarkGray;
            this.btnLoaiDoAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiDoAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoaiDoAn.Location = new System.Drawing.Point(0, 252);
            this.btnLoaiDoAn.Name = "btnLoaiDoAn";
            this.btnLoaiDoAn.Size = new System.Drawing.Size(180, 57);
            this.btnLoaiDoAn.TabIndex = 2;
            this.btnLoaiDoAn.Text = "Quản lý loại đồ ăn";
            this.btnLoaiDoAn.UseVisualStyleBackColor = false;
            this.btnLoaiDoAn.Click += new System.EventHandler(this.btnLoaiDoAn_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.Gray;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNV.Location = new System.Drawing.Point(0, 196);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(180, 57);
            this.btnNV.TabIndex = 1;
            this.btnNV.Text = "Quản lý nhân viên";
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Gray;
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTK.Location = new System.Drawing.Point(0, 140);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(180, 57);
            this.btnTK.TabIndex = 0;
            this.btnTK.Text = "Quản lý tài khoản";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.BackgroundImage = global::ProjectMagicBilliard.Properties.Resources._1000_F_266758914_P77ehoxpTyJYLaSFEzusFk4NGMDc5MwL;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Location = new System.Drawing.Point(181, 105);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(716, 515);
            this.panel_body.TabIndex = 2;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(555, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectMagicBilliard.Properties.Resources._1000_F_266758914_P77ehoxpTyJYLaSFEzusFk4NGMDc5MwL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 608);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnLoaiBan;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnDoAn;
        private System.Windows.Forms.Button btnLoaiDoAn;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}