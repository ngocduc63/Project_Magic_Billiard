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
using System.Xml.Linq;

namespace ProjectMagicBilliard.Scene
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        public void LoadAccount()
        {
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.DataSource = LoginCallSQL.Instance.GetAllAccount();
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtDisplayGame.Text = "";
            txtIDStaff.Text = "";
            txtTimKiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LoginCallSQL.Instance.insertAccount(txtUserName.Text, txtPassWord.Text, txtDisplayGame.Text, txtIDStaff.Text))
            {
                MessageBox.Show($"Thêm nhân viên thành công!!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show($"Thêm nhân viên thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (LoginCallSQL.Instance.updateAccount(txtUserName.Text, txtPassWord.Text, txtDisplayGame.Text, txtIDStaff.Text))
            {
                MessageBox.Show($"Sửa tài khoản thành công!!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show($"Sửa tài khoản thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LoginCallSQL.Instance.deleteAccount(txtUserName.Text))
            {
                MessageBox.Show($"Xóa tài khoản thành công!!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show($"Xóa tài khoản thất bại!!");
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvAccount.CurrentCell.RowIndex;
            txtUserName.Text = dgvAccount.Rows[i].Cells[0].Value.ToString();
            txtPassWord.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();
            txtDisplayGame.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
            txtIDStaff.Text = dgvAccount.Rows[i].Cells[3].Value.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.DataSource = LoginCallSQL.Instance.searchAccount(txtTimKiem.Text);
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.IsSelecStaff = true;

            if (staff.ShowDialog() == DialogResult.OK)
            {
                txtIDStaff.Text = staff.IDStaff;
            }
        }
    }
}
