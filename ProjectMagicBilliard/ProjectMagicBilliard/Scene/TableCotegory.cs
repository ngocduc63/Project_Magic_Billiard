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
            txtName.Text = "";
            txtPrice.Text = "";           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.insertTableCategory(txtName.Text, txtPrice.Text))
            {
                MessageBox.Show($"Thêm nhân viên thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Thêm nhân viên thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.updateTableCategory(txtID.Text, txtName.Text, txtPrice.Text))
            {
                MessageBox.Show($"Sửa nhân viên thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Sửa nhân viên thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TableCategoryCallSQL.Instance.deleteTableCategory(txtID.Text))
            {
                MessageBox.Show($"Xóa nhân viên thành công!!");
                LoadTableCategory();
            }
            else
            {
                MessageBox.Show($"Xóa nhân viên thất bại!!");
            }
        }
    }
}
