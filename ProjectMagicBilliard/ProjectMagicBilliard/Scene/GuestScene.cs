using ProjectMagicBilliard.CallSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMagicBilliard.Scene
{
    public partial class GuestScene : Form
    {
        public GuestScene()
        {
            InitializeComponent();
            cbSearch.SelectedIndex = 0;
        }

        public bool IsPayiing = false;
        public string IdGuest;
        public string NameGuest;
        public bool UsePoint = false;

        private void GuestScene_Load(object sender, EventArgs e)
        {
            loadGuest();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = dgvGuest.CurrentCell.RowIndex;
            //txtID.Text = dgvGuest.Rows[i].Cells[0].Value.ToString();
            //txtName.Text = dgvGuest.Rows[i].Cells[1].Value.ToString();
            //txtAddress.Text = dgvGuest.Rows[i].Cells[2].Value.ToString();
            //txtPhoneNumber.Text = dgvGuest.Rows[i].Cells[3].Value.ToString();
            //txtTotalPoint.Text = dgvGuest.Rows[i].Cells[4].Value.ToString();
        }

        public void loadGuest()
        {
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.DataSource = guestCallSQL.Instance.GetAllGuest();
            txtID.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtTotalPoint.Text = "";
            cbSearch.SelectedIndex = 0;
            txttimkiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (guestCallSQL.Instance.insertGuest(txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtTotalPoint.Text))
            {
                MessageBox.Show($"Thêm khách hàng thành công!!");
                loadGuest();
            }
            else
            {
                MessageBox.Show($"Thêm khách hàng thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (guestCallSQL.Instance.deleteGuest(txtID.Text))
            {
                MessageBox.Show($"Xóa khách hàng thành công!!");
                loadGuest();
            }
            else
            {
                MessageBox.Show($"Xóa khách hàng thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (guestCallSQL.Instance.updateGuest(txtID.Text,txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtTotalPoint.Text))
            {
                MessageBox.Show($"Sửa khách hàng thành công!!");
                loadGuest();
            }
            else
            {
                MessageBox.Show($"Sửa khách hàng thất bại!!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bool isSearchForcusName = cbSearch.SelectedIndex == 1 ? true : false;
            dgvGuest.DataSource = guestCallSQL.Instance.searchGuest(txttimkiem.Text, isSearchForcusName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadGuest();
        }

        private void dgvGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvGuest.CurrentCell.RowIndex;
            txtID.Text = dgvGuest.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvGuest.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dgvGuest.Rows[i].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvGuest.Rows[i].Cells[3].Value.ToString();
            txtTotalPoint.Text = dgvGuest.Rows[i].Cells[4].Value.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            if (IsPayiing)
            {
                IdGuest = txtID.Text;
                NameGuest = txtName.Text;

                if(Convert.ToDouble(txtTotalPoint.Text) >= 10000f)
                {
                    var checkPoint = MessageBox.Show($"Bạn có muốn sử dụng 10,000 điểm để giảm 10 % không? ", "Thông báo", MessageBoxButtons.OKCancel);
                    if (checkPoint == DialogResult.OK) UsePoint = true;

                }

                var result = MessageBox.Show($"Bạn có muốn chọn khách: {NameGuest}", "Thông báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
