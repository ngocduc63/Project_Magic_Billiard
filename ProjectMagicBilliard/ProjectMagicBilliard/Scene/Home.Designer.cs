﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtStaff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnSelectFood = new MetroFramework.Controls.MetroButton();
            this.dgvBillInfo = new System.Windows.Forms.DataGridView();
            this.txtTitleBillInfo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
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
            this.txtTitleIdBill = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txtTotalTablePlay = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalPriceFood = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimeStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBIllInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnOpenFormAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbEmpty = new System.Windows.Forms.CheckBox();
            this.btnEmpty = new System.Windows.Forms.Label();
            this.ckbKKing = new System.Windows.Forms.CheckBox();
            this.ckbWaitPay = new System.Windows.Forms.CheckBox();
            this.ckbPlaying = new System.Windows.Forms.CheckBox();
            this.ckbMrSung = new System.Windows.Forms.CheckBox();
            this.ckbAplus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchKKing = new System.Windows.Forms.Label();
            this.btnSearchWaitPay = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSrearchPlaying = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSrearchMrSung = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchAplus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.panel13.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtStaff);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(8, 52);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(454, 34);
            this.panel10.TabIndex = 2;
            this.panel10.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // txtStaff
            // 
            this.txtStaff.AutoSize = true;
            this.txtStaff.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtStaff.Location = new System.Drawing.Point(207, 2);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(81, 36);
            this.txtStaff.TabIndex = 1;
            this.txtStaff.Text = "name";
            this.txtStaff.Click += new System.EventHandler(this.label5_Click);
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
            this.txtTime.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.btnSelectFood);
            this.panel11.Controls.Add(this.dgvBillInfo);
            this.panel11.Controls.Add(this.txtTitleBillInfo);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(468, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(465, 347);
            this.panel11.TabIndex = 4;
            this.panel11.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // btnSelectFood
            // 
            this.btnSelectFood.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelectFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFood.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSelectFood.ForeColor = System.Drawing.Color.Crimson;
            this.btnSelectFood.Location = new System.Drawing.Point(336, 4);
            this.btnSelectFood.Name = "btnSelectFood";
            this.btnSelectFood.Size = new System.Drawing.Size(120, 37);
            this.btnSelectFood.TabIndex = 19;
            this.btnSelectFood.Text = "Chọn dịch vụ";
            this.btnSelectFood.UseCustomBackColor = true;
            this.btnSelectFood.UseCustomForeColor = true;
            this.btnSelectFood.UseSelectable = true;
            this.btnSelectFood.Click += new System.EventHandler(this.btnSelectFood_Click);
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillInfo.Location = new System.Drawing.Point(-2, 48);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.ReadOnly = true;
            this.dgvBillInfo.RowHeadersWidth = 62;
            this.dgvBillInfo.RowTemplate.Height = 28;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(465, 298);
            this.dgvBillInfo.TabIndex = 8;
            this.dgvBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfo_CellClick);
            this.dgvBillInfo.Click += new System.EventHandler(this.DisablePanelMenu_Click);
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
            this.txtTitleBillInfo.Click += new System.EventHandler(this.DisablePanelMenu_Click);
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
            this.panel13.Controls.Add(this.btnUpdate);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(426, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 37);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(426, 90);
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
            this.btnPay.Location = new System.Drawing.Point(544, 28);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 70);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseCustomBackColor = true;
            this.btnPay.UseCustomForeColor = true;
            this.btnPay.UseSelectable = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnInsert.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsert.Location = new System.Drawing.Point(426, 5);
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
            this.ListTablePlayPanel.BackColor = System.Drawing.Color.Thistle;
            this.ListTablePlayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListTablePlayPanel.Location = new System.Drawing.Point(8, 90);
            this.ListTablePlayPanel.Margin = new System.Windows.Forms.Padding(20);
            this.ListTablePlayPanel.Name = "ListTablePlayPanel";
            this.ListTablePlayPanel.Size = new System.Drawing.Size(460, 374);
            this.ListTablePlayPanel.TabIndex = 7;
            this.ListTablePlayPanel.Click += new System.EventHandler(this.DisablePanelMenu_Click);
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
            this.panelDetail.Controls.Add(this.txtTotalTablePlay);
            this.panelDetail.Controls.Add(this.label12);
            this.panelDetail.Controls.Add(this.txtTotalPriceFood);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.txtEndTime);
            this.panelDetail.Controls.Add(this.label10);
            this.panelDetail.Controls.Add(this.txtTimeStart);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.txtTotalBIllInfo);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.txtTitleIdBill);
            this.panelDetail.Location = new System.Drawing.Point(939, 88);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(235, 349);
            this.panelDetail.TabIndex = 9;
            this.panelDetail.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // txtTotalTablePlay
            // 
            this.txtTotalTablePlay.AutoSize = true;
            this.txtTotalTablePlay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTablePlay.Location = new System.Drawing.Point(108, 265);
            this.txtTotalTablePlay.Name = "txtTotalTablePlay";
            this.txtTotalTablePlay.Size = new System.Drawing.Size(126, 41);
            this.txtTotalTablePlay.TabIndex = 18;
            this.txtTotalTablePlay.Text = "000000";
            this.txtTotalTablePlay.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SlateBlue;
            this.label12.Location = new System.Drawing.Point(0, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tiền bàn:";
            this.label12.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // txtTotalPriceFood
            // 
            this.txtTotalPriceFood.AutoSize = true;
            this.txtTotalPriceFood.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceFood.Location = new System.Drawing.Point(108, 233);
            this.txtTotalPriceFood.Name = "txtTotalPriceFood";
            this.txtTotalPriceFood.Size = new System.Drawing.Size(126, 41);
            this.txtTotalPriceFood.TabIndex = 16;
            this.txtTotalPriceFood.Text = "000000";
            this.txtTotalPriceFood.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(0, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tiền dịch vụ:";
            this.label6.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // txtEndTime
            // 
            this.txtEndTime.AutoSize = true;
            this.txtEndTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEndTime.Location = new System.Drawing.Point(27, 173);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(129, 36);
            this.txtEndTime.TabIndex = 14;
            this.txtEndTime.Text = "00:00:00";
            this.txtEndTime.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 33);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thời gian kết thúc:";
            this.label10.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.AutoSize = true;
            this.txtTimeStart.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimeStart.Location = new System.Drawing.Point(23, 82);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(129, 36);
            this.txtTimeStart.TabIndex = 12;
            this.txtTimeStart.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // txtTotalBIllInfo
            // 
            this.txtTotalBIllInfo.AutoSize = true;
            this.txtTotalBIllInfo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBIllInfo.Location = new System.Drawing.Point(94, 307);
            this.txtTotalBIllInfo.Name = "txtTotalBIllInfo";
            this.txtTotalBIllInfo.Size = new System.Drawing.Size(126, 41);
            this.txtTotalBIllInfo.TabIndex = 10;
            this.txtTotalBIllInfo.Text = "000000";
            this.txtTotalBIllInfo.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(2, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng tiền:";
            this.label2.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Silver;
            this.PanelMenu.Controls.Add(this.btnStatistical);
            this.PanelMenu.Controls.Add(this.btnOpenFormAdmin);
            this.PanelMenu.Controls.Add(this.btnExit);
            this.PanelMenu.Location = new System.Drawing.Point(938, 57);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(236, 150);
            this.PanelMenu.TabIndex = 10;
            // 
            // btnStatistical
            // 
            this.btnStatistical.BackColor = System.Drawing.Color.White;
            this.btnStatistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistical.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStatistical.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.Location = new System.Drawing.Point(11, 104);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(215, 42);
            this.btnStatistical.TabIndex = 2;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = false;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnOpenFormAdmin
            // 
            this.btnOpenFormAdmin.BackColor = System.Drawing.Color.White;
            this.btnOpenFormAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFormAdmin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormAdmin.Location = new System.Drawing.Point(10, 56);
            this.btnOpenFormAdmin.Name = "btnOpenFormAdmin";
            this.btnOpenFormAdmin.Size = new System.Drawing.Size(215, 42);
            this.btnOpenFormAdmin.TabIndex = 1;
            this.btnOpenFormAdmin.Text = "Quản lí quán";
            this.btnOpenFormAdmin.UseVisualStyleBackColor = false;
            this.btnOpenFormAdmin.Click += new System.EventHandler(this.btnOpenFormAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(1121, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 50);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckbEmpty);
            this.panel1.Controls.Add(this.btnEmpty);
            this.panel1.Controls.Add(this.ckbKKing);
            this.panel1.Controls.Add(this.ckbWaitPay);
            this.panel1.Controls.Add(this.ckbPlaying);
            this.panel1.Controls.Add(this.ckbMrSung);
            this.panel1.Controls.Add(this.ckbAplus);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSearchKKing);
            this.panel1.Controls.Add(this.btnSearchWaitPay);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnSrearchPlaying);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSrearchMrSung);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSearchAplus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(8, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 99);
            this.panel1.TabIndex = 12;
            // 
            // ckbEmpty
            // 
            this.ckbEmpty.AutoSize = true;
            this.ckbEmpty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmpty.Location = new System.Drawing.Point(177, 25);
            this.ckbEmpty.Name = "ckbEmpty";
            this.ckbEmpty.Size = new System.Drawing.Size(22, 21);
            this.ckbEmpty.TabIndex = 38;
            this.ckbEmpty.UseVisualStyleBackColor = true;
            this.ckbEmpty.CheckedChanged += new System.EventHandler(this.ckbEmpty_CheckedChanged);
            this.ckbEmpty.Click += new System.EventHandler(this.ckbEmpty_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.AutoSize = true;
            this.btnEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.Location = new System.Drawing.Point(224, 23);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(125, 33);
            this.btnEmpty.TabIndex = 37;
            this.btnEmpty.Text = "Bàn trống";
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // ckbKKing
            // 
            this.ckbKKing.AutoSize = true;
            this.ckbKKing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKKing.Location = new System.Drawing.Point(7, 78);
            this.ckbKKing.Name = "ckbKKing";
            this.ckbKKing.Size = new System.Drawing.Size(22, 21);
            this.ckbKKing.TabIndex = 35;
            this.ckbKKing.UseVisualStyleBackColor = true;
            this.ckbKKing.CheckedChanged += new System.EventHandler(this.ckbKKing_CheckedChanged);
            this.ckbKKing.Click += new System.EventHandler(this.ckbKKing_Click);
            // 
            // ckbWaitPay
            // 
            this.ckbWaitPay.AutoSize = true;
            this.ckbWaitPay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWaitPay.Location = new System.Drawing.Point(177, 78);
            this.ckbWaitPay.Name = "ckbWaitPay";
            this.ckbWaitPay.Size = new System.Drawing.Size(22, 21);
            this.ckbWaitPay.TabIndex = 34;
            this.ckbWaitPay.UseVisualStyleBackColor = true;
            this.ckbWaitPay.Click += new System.EventHandler(this.ckbWaitPay_Click);
            // 
            // ckbPlaying
            // 
            this.ckbPlaying.AutoSize = true;
            this.ckbPlaying.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlaying.Location = new System.Drawing.Point(177, 49);
            this.ckbPlaying.Name = "ckbPlaying";
            this.ckbPlaying.Size = new System.Drawing.Size(22, 21);
            this.ckbPlaying.TabIndex = 33;
            this.ckbPlaying.UseVisualStyleBackColor = true;
            this.ckbPlaying.CheckedChanged += new System.EventHandler(this.ckbPlaying_CheckedChanged);
            this.ckbPlaying.Click += new System.EventHandler(this.ckbPlaying_Click);
            // 
            // ckbMrSung
            // 
            this.ckbMrSung.AutoSize = true;
            this.ckbMrSung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMrSung.Location = new System.Drawing.Point(7, 55);
            this.ckbMrSung.Name = "ckbMrSung";
            this.ckbMrSung.Size = new System.Drawing.Size(22, 21);
            this.ckbMrSung.TabIndex = 32;
            this.ckbMrSung.UseVisualStyleBackColor = true;
            this.ckbMrSung.CheckedChanged += new System.EventHandler(this.ckbMrSung_CheckedChanged);
            this.ckbMrSung.Click += new System.EventHandler(this.ckbMrSung_Click);
            // 
            // ckbAplus
            // 
            this.ckbAplus.AutoSize = true;
            this.ckbAplus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAplus.Location = new System.Drawing.Point(7, 29);
            this.ckbAplus.Name = "ckbAplus";
            this.ckbAplus.Size = new System.Drawing.Size(22, 21);
            this.ckbAplus.TabIndex = 31;
            this.ckbAplus.UseVisualStyleBackColor = true;
            this.ckbAplus.CheckedChanged += new System.EventHandler(this.ckbAplus_CheckedChanged);
            this.ckbAplus.Click += new System.EventHandler(this.ckbAplus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(317, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 32);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tất cả các bàn";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnSearchKKing
            // 
            this.btnSearchKKing.AutoSize = true;
            this.btnSearchKKing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchKKing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchKKing.Location = new System.Drawing.Point(52, 74);
            this.btnSearchKKing.Name = "btnSearchKKing";
            this.btnSearchKKing.Size = new System.Drawing.Size(142, 33);
            this.btnSearchKKing.TabIndex = 29;
            this.btnSearchKKing.Text = "Bàn KKing";
            this.btnSearchKKing.Click += new System.EventHandler(this.btnSearchKKing_Click);
            // 
            // btnSearchWaitPay
            // 
            this.btnSearchWaitPay.AutoSize = true;
            this.btnSearchWaitPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchWaitPay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWaitPay.Location = new System.Drawing.Point(224, 75);
            this.btnSearchWaitPay.Name = "btnSearchWaitPay";
            this.btnSearchWaitPay.Size = new System.Drawing.Size(232, 33);
            this.btnSearchWaitPay.TabIndex = 27;
            this.btnSearchWaitPay.Text = "Bàn chờ thanh toán";
            this.btnSearchWaitPay.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Location = new System.Drawing.Point(26, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 20);
            this.panel6.TabIndex = 28;
            // 
            // btnSrearchPlaying
            // 
            this.btnSrearchPlaying.AutoSize = true;
            this.btnSrearchPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSrearchPlaying.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrearchPlaying.Location = new System.Drawing.Point(224, 47);
            this.btnSrearchPlaying.Name = "btnSrearchPlaying";
            this.btnSrearchPlaying.Size = new System.Drawing.Size(177, 33);
            this.btnSrearchPlaying.TabIndex = 25;
            this.btnSrearchPlaying.Text = "Bàn đang chơi";
            this.btnSrearchPlaying.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(198, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 20);
            this.panel5.TabIndex = 26;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(198, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 24;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSrearchMrSung
            // 
            this.btnSrearchMrSung.AutoSize = true;
            this.btnSrearchMrSung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSrearchMrSung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrearchMrSung.Location = new System.Drawing.Point(52, 50);
            this.btnSrearchMrSung.Name = "btnSrearchMrSung";
            this.btnSrearchMrSung.Size = new System.Drawing.Size(159, 33);
            this.btnSrearchMrSung.TabIndex = 23;
            this.btnSrearchMrSung.Text = "Bàn MrSung";
            this.btnSrearchMrSung.Click += new System.EventHandler(this.btnSrearchMrSung_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(26, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 22;
            // 
            // btnSearchAplus
            // 
            this.btnSearchAplus.AutoSize = true;
            this.btnSearchAplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAplus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAplus.Location = new System.Drawing.Point(52, 26);
            this.btnSearchAplus.Name = "btnSearchAplus";
            this.btnSearchAplus.Size = new System.Drawing.Size(132, 33);
            this.btnSearchAplus.TabIndex = 21;
            this.btnSearchAplus.Text = "Bàn Aplus";
            this.btnSearchAplus.Click += new System.EventHandler(this.btnSearchAplus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(26, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bộ lọc: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1180, 580);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.PanelMenu);
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
            this.Click += new System.EventHandler(this.DisablePanelMenu_Click);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtStaff;
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
        private MetroFramework.Controls.MetroButton btnUpdate;
        private System.Windows.Forms.Label txtTotalBIllInfo;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnSelectFood;
        private System.Windows.Forms.Label txtTimeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtEndTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnOpenFormAdmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtTotalTablePlay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTotalPriceFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btnSearchAplus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnSearchKKing;
        private System.Windows.Forms.Label btnSearchWaitPay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label btnSrearchPlaying;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label btnSrearchMrSung;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbKKing;
        private System.Windows.Forms.CheckBox ckbWaitPay;
        private System.Windows.Forms.CheckBox ckbPlaying;
        private System.Windows.Forms.CheckBox ckbMrSung;
        private System.Windows.Forms.CheckBox ckbAplus;
        private System.Windows.Forms.CheckBox ckbEmpty;
        private System.Windows.Forms.Label btnEmpty;
        private System.Windows.Forms.Button btnStatistical;
    }
}