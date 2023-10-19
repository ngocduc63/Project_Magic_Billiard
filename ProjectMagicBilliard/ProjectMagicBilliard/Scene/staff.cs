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
    public partial class staff : Form
    {


        public staff()
        {
            InitializeComponent();
        }

        
        private void staff_Load(object sender, EventArgs e)
        {
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.DataSource = StaffCallSQL.Instance.GetAllStaff();
        }

        public void Loadstaff()
        {
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.DataSource = StaffCallSQL.Instance.GetAllStaff();
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtIDPosition.Text = "";
            txttimkiem.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if(StaffCallSQL.Instance.insertStaff(txtName.Text,txtAddress.Text,txtPhoneNumber.Text,txtIDPosition.Text))
            {
                MessageBox.Show($"Thêm nhân viên thành công!!");
                Loadstaff();
            }
            else
            {
                MessageBox.Show($"Thêm nhân viên thất bại!!");
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (StaffCallSQL.Instance.updateStaff(txtID.Text,txtName.Text,txtAddress.Text,txtPhoneNumber.Text,txtIDPosition.Text))
            {
                MessageBox.Show($"Sửa nhân viên thành công!!");
                Loadstaff();
            }
            else
            {
                MessageBox.Show($"Sửa nhân viên thất bại!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StaffCallSQL.Instance.deleteStaff(txtID.Text))
            {
                MessageBox.Show($"Xóa nhân viên thành công!!");
                Loadstaff();
            }
            else
            {
                MessageBox.Show($"Xóa nhân viên thất bại!!");
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= dgvStaff.CurrentCell.RowIndex;
            txtID.Text = dgvStaff.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvStaff.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dgvStaff.Rows[i].Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvStaff.Rows[i].Cells[3].Value.ToString();
            txtIDPosition.Text = dgvStaff.Rows[i].Cells[4].Value.ToString();

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.DataSource = StaffCallSQL.Instance.searchStaff(txttimkiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadstaff();
        }
    }
}
