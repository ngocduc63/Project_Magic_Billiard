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

namespace ProjectMagicBilliard.Scene
{
    public partial class CodeManager : Form
    {
        public CodeManager()
        {
            InitializeComponent();
        }

        private void CodeManager_Load(object sender, EventArgs e)
        {
            LoadCode();
        }

        public void LoadCode()
        {
            dgvCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCode.DataSource = CodeManagerCallSQL.Instance.GetAllCode();
            txtId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtSearch.Text = "";

            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CodeManagerCallSQL.Instance.DeleteCode(txtId.Text))
            {
                MessageBox.Show($"Xóa mã giảm giá  thành công!!");
                LoadCode();
            }
            else
            {
                MessageBox.Show($"Xóa mã giảm giá thất bại!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            try
            {
                quantity = Convert.ToInt32(txtQuantity.Text);

                if (CodeManagerCallSQL.Instance.UpdateCode(txtId.Text, txtName.Text, quantity))
                {
                    MessageBox.Show($"Sửa mã giảm giá  thành công!!");
                    LoadCode();
                }
                else
                {
                    MessageBox.Show($"Sửa mã giảm giá thất bại!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Vui lòng nhập đúng thông tin!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            try
            {
                quantity = Convert.ToInt32(txtQuantity.Text);

                if (CodeManagerCallSQL.Instance.InsertCode( txtName.Text, quantity))
                {
                    MessageBox.Show($"Thêm mã giảm giá thành công!!");
                    LoadCode();
                }
                else
                {
                    MessageBox.Show($"Thêm mã giảm giá thất bại!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Vui lòng nhập đúng thông tin!!");
            }
        }

        private void dgvCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCode.CurrentCell.RowIndex;
            txtId.Text = dgvCode.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvCode.Rows[i].Cells[1].Value.ToString();
            txtQuantity.Text = dgvCode.Rows[i].Cells[2].Value.ToString();

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCode.DataSource = CodeManagerCallSQL.Instance.SearchCode(txtSearch.Text);
        }
    }
}
