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
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.DataSource = FoodCallSQL.Instance.GetFood();
            cmbCategory.DisplayMember = "name";
            cmbCategory.DataSource = FoodCategoryCallSQL.Instance.GetAllFoodCategory();
        }
        public void loadFood()
        {
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.DataSource = FoodCallSQL.Instance.GetFood();
            cmbCategory.DisplayMember = "name";
            cmbCategory.DataSource = FoodCategoryCallSQL.Instance.GetAllFoodCategory();
            txtID.Text = "";
            txtprice.Text = "";
            txtName.Text = "";
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
