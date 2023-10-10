﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMagicBilliard.CallSQL;
using ProjectMagicBilliard.Data;

namespace ProjectMagicBilliard.Scene
{
    public partial class BillPay : MetroFramework.Forms.MetroForm
    {
        public BillPay()
        {
            InitializeComponent();
        }

        private string _idCurrentBill;
        private double _priceBill;
        private string _idStaffCurrent;

        public string IdCurrentBill { get => _idCurrentBill; set => _idCurrentBill = value; }
        public double PriceBill { get => _priceBill; set => _priceBill = value; }
        public string IdStaffCurrent { get => _idStaffCurrent; set => _idStaffCurrent = value; }

        private void BillPay_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadBillPay(List<BillInfo> lstBillInfo)
        {
            txtIdBill.Text = $"Mã háo đơn: {_idCurrentBill}";
            dgvBillInfo.DataSource = lstBillInfo;
            dgvBillInfo.Columns[0].Visible = false;
            dgvBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillInfo.Columns[1].HeaderText = "Tên";
            dgvBillInfo.Columns[2].HeaderText = "Đơn giá";
            dgvBillInfo.Columns[3].HeaderText = "Số lượng";
            dgvBillInfo.Columns[4].HeaderText = "Tổng tiền";
        }

        public void LoadTotalTimeAndPrice(string totalTime, string totalPrice)
        {
            txtTotalTimePlay.Text = totalTime;
            txtTotalPay.Text = totalPrice;
        }

        public void LoadNameTxt(string nameStaff)
        {
            txtNameStaff.Text = "Tên nhân viên: " + nameStaff;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //txtGuest.Text
            if (BillCallSQL.Instance.PayBill(_idCurrentBill, PriceBill, IdStaffCurrent))
            {
                MessageBox.Show($"Thanh toán hóa đơn {_idCurrentBill} thành công");
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Lỗi thanh toán !!!");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon....");
        }
    }
}
