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
        }

        private void GuestScene_Load(object sender, EventArgs e)
        {
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.DataSource = guestCallSQL.Instance.GetAllGuest();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvGuest.CurrentCell.RowIndex;
            txtID.Text = dgvGuest.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvGuest.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dgvGuest.Rows[i].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvGuest.Rows[i].Cells[3].Value.ToString();
            txtTotalPoint.Text = dgvGuest.Rows[i].Cells[4].Value.ToString();
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
            dgvGuest.DataSource = guestCallSQL.Instance.searchGuest(txttimkiem.Text);
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

        }
    }
}
