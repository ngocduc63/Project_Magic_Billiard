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
    public partial class TableCotegory : Form
    {
        public TableCotegory()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableCotegory_Load(object sender, EventArgs e)
        {
            dgvTableCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableCategory.DataSource = TableCategoryCallSQL.Instance.GetAllTableCategory();
        }

        public void LoadTableCategory()
        {
            dgvTableCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableCategory.DataSource = TableCategoryCallSQL.Instance.GetAllTableCategory();
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.insertTableCategory(txtName.Text, txtPrice.Text))
            {
                MessageBox.Show($"Thêm loại bàn thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Thêm loại bàn thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.updateTableCategory(txtID.Text, txtName.Text, txtPrice.Text))
            {
                MessageBox.Show($"Sửa loại bàn thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Sửa loại bàn thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.deleteTableCategory(txtID.Text))
            {
                MessageBox.Show($"Xóa loại bàn thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Xóa loại bàn thất bại!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTableCategory();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvTableCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableCategory.DataSource = TableCategoryCallSQL.Instance.searchTableCategory(txtTimKiem.Text);
        }

        private void dgvTableCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTableCategory.CurrentCell.RowIndex;
            txtID.Text = dgvTableCategory.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvTableCategory.Rows[i].Cells[1].Value.ToString();
            txtPrice.Text = dgvTableCategory.Rows[i].Cells[2].Value.ToString();

        }
    }
}
