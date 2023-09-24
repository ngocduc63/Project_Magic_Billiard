
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(52, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 48);
            this.btnCancel.TabIndex = 1;
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
            this.btnPay.Location = new System.Drawing.Point(253, 421);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(179, 48);
            this.btnPay.TabIndex = 2;
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
            this.dgvBillInfo.Location = new System.Drawing.Point(5, 95);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.ReadOnly = true;
            this.dgvBillInfo.RowHeadersWidth = 62;
            this.dgvBillInfo.RowTemplate.Height = 28;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(463, 247);
            this.dgvBillInfo.TabIndex = 3;
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng giờ chơi:";
            // 
            // txtTotalTimePlay
            // 
            this.txtTotalTimePlay.AutoSize = true;
            this.txtTotalTimePlay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTimePlay.Location = new System.Drawing.Point(147, 355);
            this.txtTotalTimePlay.Name = "txtTotalTimePlay";
            this.txtTotalTimePlay.Size = new System.Drawing.Size(84, 33);
            this.txtTotalTimePlay.TabIndex = 6;
            this.txtTotalTimePlay.Text = "1g30p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền :";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.AutoSize = true;
            this.txtTotalPay.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPay.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPay.Location = new System.Drawing.Point(369, 352);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(180, 41);
            this.txtTotalPay.TabIndex = 8;
            this.txtTotalPay.Text = "10,000,000";
            // 
            // BillPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.ControlBox = false;
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
    }
}