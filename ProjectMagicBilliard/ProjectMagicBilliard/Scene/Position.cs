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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
