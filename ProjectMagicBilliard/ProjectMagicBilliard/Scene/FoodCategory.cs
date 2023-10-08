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
    public partial class FoodCategory : Form
    {
        public FoodCategory()
        {
            InitializeComponent();
        }

        private void FoodCategory_Load(object sender, EventArgs e)
        {
            dgvFoodCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodCategory.DataSource = FoodCategoryCallSQL.Instance.GetAllFoodCategory();
        }
        public void LoadFoodCategory()
        {
            dgvFoodCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodCategory.DataSource = FoodCategoryCallSQL.Instance.GetAllFoodCategory();
            txtID.Text = "";
            txtName.Text = "";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (FoodCategoryCallSQL.Instance.insertFoodCategory(txtName.Text))
            {
                MessageBox.Show($"Thêm Thực đơn thành công!!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show($"Thêm Thực đơn thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (FoodCategoryCallSQL.Instance.updateFoodCategory(txtID.Text, txtName.Text))
            {
                MessageBox.Show($"Sửa Thực đơn thành công!!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show($"Sửa Thực đơn thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (FoodCategoryCallSQL.Instance.deleteFoodCategory(txtID.Text))
            {
                MessageBox.Show($"Xóa Thực đơn thành công!!");
                LoadFoodCategory();
            }
            else
            {
                MessageBox.Show($"Xóa Thực đơn thất bại!!");
            }
        }

        private void dgvFoodCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvFoodCategory.CurrentCell.RowIndex;
            txtID.Text = dgvFoodCategory.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvFoodCategory.Rows[i].Cells[1].Value.ToString();
        }
    }
}
