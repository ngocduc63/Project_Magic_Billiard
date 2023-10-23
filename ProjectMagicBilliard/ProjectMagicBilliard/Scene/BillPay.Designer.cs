
namespace ProjectMagicBilliard.Scene
{
    partial class BillPay
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.dgvBillInfo = new System.Windows.Forms.DataGridView();
            this.txtIdBill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalTimePlay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.Label();
            this.txtNameStaff = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCheck = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(46, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPay.Location = new System.Drawing.Point(247, 514);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(179, 48);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseCustomBackColor = true;
            this.btnPay.UseCustomForeColor = true;
            this.btnPay.UseSelectable = true;
            this.btnPay.UseStyleColors = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillInfo.Location = new System.Drawing.Point(5, 118);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.ReadOnly = true;
            this.dgvBillInfo.RowHeadersWidth = 62;
            this.dgvBillInfo.RowTemplate.Height = 28;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(463, 247);
            this.dgvBillInfo.TabIndex = 10;
            // 
            // txtIdBill
            // 
            this.txtIdBill.AutoSize = true;
            this.txtIdBill.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBill.Location = new System.Drawing.Point(282, 26);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(217, 36);
            this.txtIdBill.TabIndex = 4;
            this.txtIdBill.Text = "Mã hóa đơn: 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng giờ chơi:";
            // 
            // txtTotalTimePlay
            // 
            this.txtTotalTimePlay.AutoSize = true;
            this.txtTotalTimePlay.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTimePlay.Location = new System.Drawing.Point(126, 459);
            this.txtTotalTimePlay.Name = "txtTotalTimePlay";
            this.txtTotalTimePlay.Size = new System.Drawing.Size(102, 39);
            this.txtTotalTimePlay.TabIndex = 6;
            this.txtTotalTimePlay.Text = "1g30p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền :";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.AutoSize = true;
            this.txtTotalPay.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPay.Location = new System.Drawing.Point(333, 456);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(200, 45);
            this.txtTotalPay.TabIndex = 8;
            this.txtTotalPay.Text = "10,000,000";
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.AutoSize = true;
            this.txtNameStaff.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStaff.Location = new System.Drawing.Point(9, 75);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(115, 33);
            this.txtNameStaff.TabIndex = 9;
            this.txtNameStaff.Text = "nhanvien";
            // 
            // txtGuest
            // 
            this.txtGuest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuest.Location = new System.Drawing.Point(217, 68);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.ReadOnly = true;
            this.txtGuest.Size = new System.Drawing.Size(173, 40);
            this.txtGuest.TabIndex = 9999;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(396, 61);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(74, 40);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Chọn";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã giảm giá:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(124, 384);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(215, 40);
            this.txtDiscount.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCheck.Location = new System.Drawing.Point(370, 385);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 40);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseCustomBackColor = true;
            this.btnCheck.UseCustomForeColor = true;
            this.btnCheck.UseSelectable = true;
            this.btnCheck.UseStyleColors = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // BillPay
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 580);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtGuest);
            this.Controls.Add(this.txtNameStaff);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalTimePlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdBill);
            this.Controls.Add(this.dgvBillInfo);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BillPay";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.Text = "Hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.BillPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnPay;
        private System.Windows.Forms.DataGridView dgvBillInfo;
        private System.Windows.Forms.Label txtIdBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotalTimePlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalPay;
        private System.Windows.Forms.Label txtNameStaff;
        private System.Windows.Forms.TextBox txtGuest;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscount;
        private MetroFramework.Controls.MetroButton btnCheck;
    }
}