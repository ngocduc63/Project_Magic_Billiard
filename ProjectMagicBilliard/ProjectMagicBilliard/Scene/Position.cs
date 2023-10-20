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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            dgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPosition.DataSource = PositionCallSQL.Instance.GetAllPosition();
        }

        public void loadPosition()
        {
            dgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPosition.DataSource = PositionCallSQL.Instance.GetAllPosition();
            txtID.Text = "";
            txtName.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PositionCallSQL.Instance.insertPosition(txtName.Text))
            {
                MessageBox.Show($"Thêm chức vụ thành công!!");
                loadPosition();
            }
            else
            {
                MessageBox.Show($"Thêm chức vụ thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (PositionCallSQL.Instance.updatePosition(txtID.Text, txtName.Text))
            {
                MessageBox.Show($"Sửa chức vụ thành công!!");
                loadPosition();
            }
            else
            {
                MessageBox.Show($"Sửa chức vụ thất bại!!");
            }
        }
            private void btnXoa_Click(object sender, EventArgs e)
            {
                if (PositionCallSQL.Instance.deletePosition(txtID.Text))
                {
                    MessageBox.Show($"Xóa chức vụ thành công!!");
                    loadPosition();
                }
                else
                {
                    MessageBox.Show($"Xóa chức vụ thất bại!!");
                }
            }
            private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                int i = dgvPosition.CurrentCell.RowIndex;
                txtID.Text = dgvPosition.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dgvPosition.Rows[i].Cells[1].Value.ToString();
            }

            private void btnlammoi_Click(object sender, EventArgs e)
            {
                loadPosition();
            }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvPosition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPosition.DataSource = PositionCallSQL.Instance.searchPosition(txtTimKiem.Text);
        }
    }
}
