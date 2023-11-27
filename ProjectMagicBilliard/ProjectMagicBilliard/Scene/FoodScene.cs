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
    public partial class FoodScene : Form
    {
        public FoodScene()
        {
            InitializeComponent();
        }

        private void FoodScene_Load(object sender, EventArgs e)
        {
            loadFood();
        }
        public void loadFood()
        {
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.DataSource = FoodCallSQL.Instance.GetFood();
            cmbCategory.DataSource = FoodCategoryCallSQL.Instance.GetAllFoodCategory();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "id";
            txtID.Text = "";
            txtprice.Text = "";
            txtName.Text = "";
            txttimkiem.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvFood.CurrentCell.RowIndex;
            txtID.Text = dgvFood.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvFood.Rows[i].Cells[1].Value.ToString();
            txtprice.Text = dgvFood.Rows[i].Cells[2].Value.ToString();
            cmbCategory.SelectedIndex = cmbCategory.FindString(dgvFood.Rows[i].Cells[3].Value.ToString());

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.DataSource = FoodCallSQL.Instance.searchFood(txttimkiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFood();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(txtprice.Text);
                if (FoodCallSQL.Instance.insertFood(txtName.Text, price, cmbCategory.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm thành công");
                    loadFood();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá dạng số!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(txtprice.Text);
                if (FoodCallSQL.Instance.updateFood(txtID.Text, txtName.Text, price, cmbCategory.SelectedValue.ToString()))
                {
                    MessageBox.Show("Sửa thành công");
                    loadFood();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá dạng số!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (FoodCallSQL.Instance.deleteFood(txtID.Text))
            {
                MessageBox.Show("Xóa thành công");
                loadFood();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
