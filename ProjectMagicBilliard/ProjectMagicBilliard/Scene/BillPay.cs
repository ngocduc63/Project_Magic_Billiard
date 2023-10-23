using System;
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
        private string _idGuest;
        private bool _isCheckCode = false;

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
            if (string.IsNullOrWhiteSpace(txtGuest.Text))
            {
                var result = MessageBox.Show($"Bạn chưa chọn khách hàng!!!\nNếu đồng ý số điểm tích lũy được sẽ cộng vào tài khoản admin.", "Thông báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    _idGuest = "1";
                    Pay();
                };
            }
            else Pay();
        }

        public void Pay()
        {
            string code = txtDiscount.Text;

            if (!string.IsNullOrWhiteSpace(code) && !_isCheckCode)
            {
                if (!DiscountCodeCallSQL.Instance.CheckDiscount(code))
                {
                    MessageBox.Show("Mã không tồn tại hoặc hết hạn");
                }
                else
                {
                    double quantity = DiscountCodeCallSQL.Instance.GetQuantityCode(code);
                    double priceTotal = (int)Math.Round(_priceBill * (100 - quantity) / 100);
                    var result = MessageBox.Show($"Mã của bạn được giảm {quantity}%.\nSau khi dùng mã Tổng Tiền của khách là: {priceTotal}đ", "Thông báo", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK) _priceBill = priceTotal;
                    else return;
                }
            }

            if (BillCallSQL.Instance.PayBill(_idCurrentBill, PriceBill, IdStaffCurrent, _idGuest))
            {
                MessageBox.Show($"Thanh toán hóa đơn {_idCurrentBill} thành công");
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Lỗi thanh toán !!!");

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GuestScene guest = new GuestScene();
            guest.IsPayiing = true;

            if (guest.ShowDialog() == DialogResult.OK)
            {
                txtGuest.Text = guest.NameGuest;
                _idGuest = guest.IdGuest;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string code = txtDiscount.Text;

            if (!string.IsNullOrWhiteSpace(code) && !_isCheckCode)
            {
                if (!DiscountCodeCallSQL.Instance.CheckDiscount(code))
                {
                    MessageBox.Show("Mã không tồn tại hoặc hết hạn");
                }
                else
                {
                    double quantity = DiscountCodeCallSQL.Instance.GetQuantityCode(code);
                    _priceBill *= ((100 - quantity) / 100);
                    _priceBill = (int)Math.Round(_priceBill);
                    txtTotalPay.Text = Home.Instance.NumberFormatter(_priceBill)+"đ";
                    _isCheckCode = true;
                    btnCheck.Enabled = false;

                    MessageBox.Show($"Giảm thành công {quantity}%.\nTổng tiền còn: {_priceBill}đ");

                }
            }
        }
    }
}
