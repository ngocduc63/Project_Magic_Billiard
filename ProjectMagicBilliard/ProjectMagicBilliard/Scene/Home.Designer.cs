
namespace ProjectMagicBilliard.Scene
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtTitleBillInfo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnEndTimePlay = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbQuantityFood = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFood = new MetroFramework.Controls.MetroComboBox();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnStartTimePlay = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.ListTablePlayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBillInfo = new System.Windows.Forms.DataGridView();
            this.txtTitleIdBill = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lí quán Magic Billiard";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(8, 52);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(454, 34);
            this.panel10.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label5.Location = new System.Drawing.Point(207, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "admin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên: ";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtTime.ForeColor = System.Drawing.Color.Red;
            this.txtTime.Location = new System.Drawing.Point(635, 27);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(99, 41);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "18:05";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.dgvBillInfo);
            this.panel11.Controls.Add(this.txtTitleBillInfo);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(468, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(465, 347);
            this.panel11.TabIndex = 4;
            // 
            // txtTitleBillInfo
            // 
            this.txtTitleBillInfo.AutoSize = true;
            this.txtTitleBillInfo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBillInfo.Location = new System.Drawing.Point(3, 7);
            this.txtTitleBillInfo.Name = "txtTitleBillInfo";
            this.txtTitleBillInfo.Size = new System.Drawing.Size(270, 36);
            this.txtTitleBillInfo.TabIndex = 7;
            this.txtTitleBillInfo.Text = "Hóa đơn bán hàng";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(3, 497);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(945, 136);
            this.panel12.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btnEndTimePlay);
            this.panel13.Controls.Add(this.btnDelete);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.cbQuantityFood);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.cbFood);
            this.panel13.Controls.Add(this.btnPay);
            this.panel13.Controls.Add(this.btnInsert);
            this.panel13.Controls.Add(this.btnStartTimePlay);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(468, 439);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(706, 132);
            this.panel13.TabIndex = 6;
            // 
            // btnEndTimePlay
            // 
            this.btnEndTimePlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEndTimePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndTimePlay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEndTimePlay.ForeColor = System.Drawing.Color.Crimson;
            this.btnEndTimePlay.Location = new System.Drawing.Point(9, 81);
            this.btnEndTimePlay.Name = "btnEndTimePlay";
            this.btnEndTimePlay.Size = new System.Drawing.Size(142, 40);
            this.btnEndTimePlay.TabIndex = 17;
            this.btnEndTimePlay.Text = "Tính tiền bàn";
            this.btnEndTimePlay.UseCustomBackColor = true;
            this.btnEndTimePlay.UseCustomForeColor = true;
            this.btnEndTimePlay.UseSelectable = true;
            this.btnEndTimePlay.Click += new System.EventHandler(this.btnEndTimePlay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(426, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dịch vụ";
            // 
            // cbQuantityFood
            // 
            this.cbQuantityFood.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbQuantityFood.FormattingEnabled = true;
            this.cbQuantityFood.ItemHeight = 29;
            this.cbQuantityFood.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQuantityFood.Location = new System.Drawing.Point(305, 86);
            this.cbQuantityFood.Name = "cbQuantityFood";
            this.cbQuantityFood.Size = new System.Drawing.Size(94, 35);
            this.cbQuantityFood.TabIndex = 14;
            this.cbQuantityFood.UseSelectable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng";
            // 
            // cbFood
            // 
            this.cbFood.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.ItemHeight = 29;
            this.cbFood.Items.AddRange(new object[] {
            "Coca",
            "Pepsi",
            "7up",
            "sting"});
            this.cbFood.Location = new System.Drawing.Point(186, 32);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(224, 35);
            this.cbFood.TabIndex = 9;
            this.cbFood.UseSelectable = true;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPay.ForeColor = System.Drawing.Color.Crimson;
            this.btnPay.Location = new System.Drawing.Point(551, 42);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 70);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseCustomBackColor = true;
            this.btnPay.UseCustomForeColor = true;
            this.btnPay.UseSelectable = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnInsert.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsert.Location = new System.Drawing.Point(426, 31);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 37);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseCustomBackColor = true;
            this.btnInsert.UseCustomForeColor = true;
            this.btnInsert.UseSelectable = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnStartTimePlay
            // 
            this.btnStartTimePlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStartTimePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTimePlay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStartTimePlay.ForeColor = System.Drawing.Color.Crimson;
            this.btnStartTimePlay.Location = new System.Drawing.Point(9, 31);
            this.btnStartTimePlay.Name = "btnStartTimePlay";
            this.btnStartTimePlay.Size = new System.Drawing.Size(142, 40);
            this.btnStartTimePlay.TabIndex = 11;
            this.btnStartTimePlay.Text = "Bắt đầu tính giờ";
            this.btnStartTimePlay.UseCustomBackColor = true;
            this.btnStartTimePlay.UseCustomForeColor = true;
            this.btnStartTimePlay.UseSelectable = true;
            this.btnStartTimePlay.Click += new System.EventHandler(this.btnStartTimePlay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chức năng";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(3, 497);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(945, 136);
            this.panel14.TabIndex = 5;
            // 
            // ListTablePlayPanel
            // 
            this.ListTablePlayPanel.AutoScroll = true;
            this.ListTablePlayPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListTablePlayPanel.BackgroundImage")));
            this.ListTablePlayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListTablePlayPanel.Location = new System.Drawing.Point(8, 90);
            this.ListTablePlayPanel.Margin = new System.Windows.Forms.Padding(20);
            this.ListTablePlayPanel.Name = "ListTablePlayPanel";
            this.ListTablePlayPanel.Size = new System.Drawing.Size(454, 481);
            this.ListTablePlayPanel.TabIndex = 7;
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillInfo.Location = new System.Drawing.Point(-2, 48);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.ReadOnly = true;
            this.dgvBillInfo.RowHeadersWidth = 62;
            this.dgvBillInfo.RowTemplate.Height = 28;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(465, 298);
            this.dgvBillInfo.TabIndex = 8;
            // 
            // txtTitleIdBill
            // 
            this.txtTitleIdBill.AutoSize = true;
            this.txtTitleIdBill.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleIdBill.Location = new System.Drawing.Point(3, 6);
            this.txtTitleIdBill.Name = "txtTitleIdBill";
            this.txtTitleIdBill.Size = new System.Drawing.Size(134, 36);
            this.txtTitleIdBill.TabIndex = 8;
            this.txtTitleIdBill.Text = "Hóa đơn";
            // 
            // panelDetail
            // 
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.txtTitleIdBill);
            this.panelDetail.Location = new System.Drawing.Point(939, 88);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(235, 349);
            this.panelDetail.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 580);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.ListTablePlayPanel);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 19);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Quản lí quán Magic Billiard";
            this.TransparencyKey = System.Drawing.SystemColors.Highlight;
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label txtTitleBillInfo;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroComboBox cbFood;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroButton btnPay;
        private MetroFramework.Controls.MetroButton btnStartTimePlay;
        private MetroFramework.Controls.MetroComboBox cbQuantityFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEndTimePlay;
        private System.Windows.Forms.FlowLayoutPanel ListTablePlayPanel;
        private System.Windows.Forms.DataGridView dgvBillInfo;
        private System.Windows.Forms.Label txtTitleIdBill;
        private System.Windows.Forms.Panel panelDetail;
    }
}