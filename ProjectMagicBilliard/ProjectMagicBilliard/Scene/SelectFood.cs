using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMagicBilliard.Data;
using ProjectMagicBilliard.CallSQL;

namespace ProjectMagicBilliard.Scene
{
    public partial class SelectFood : MetroFramework.Forms.MetroForm
    {
        public SelectFood()
        {
            InitializeComponent();
        }
        private List<Food> _lstFood = new List<Food>();
        private string _idBill;
        private TablePlay _tableData;

        public List<Food> LstFood { get => _lstFood; set => _lstFood = value; }
        public string IdBill { get => _idBill; set => _idBill = value; }
        public TablePlay TableData { get => _tableData; set => _tableData = value; }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Food food = _lstFood.FirstOrDefault(item => item.Name.Equals(txtName.Text));
            if (food == null) MessageBox.Show("Vui lòng nhập đúng dịch vụ!!!");
            else if (!int.TryParse(txtQuantity.Text, out int value)) MessageBox.Show("Vui lòng nhập đúng số lượng!!");
            else
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);

                if (BillInfoCallSQL.Instance.InsertToBillInfo(food.Id, quantity, _idBill))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("Thêm dịch vụ thất bại!!!");
            }
        }

        public void LoadListFood(List<Food> LstFood = null)
        {
            if (LstFood == null) LstFood = _lstFood;
            panelListFood.Controls.Clear();

            foreach (Food food in LstFood)
            {
                Button btnFood = new Button();

                btnFood.Size = new Size(150, 90);
                btnFood.Text = food.Name;
                btnFood.Name = $"btn{food.Id}";
                btnFood.DialogResult = DialogResult.None;
                btnFood.Click += Food_Click;

                panelListFood.Controls.Add(btnFood);
            }
        }

        private void Food_Click(Object sender, EventArgs e)
        {
            string rs = (sender as Button).Text;

            txtName.Text = rs;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int value))
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);

                txtQuantity.Text = (quantity + 1).ToString();
            }
            else MessageBox.Show("Vui lòng chọn đúng định dạng số");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int value))
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);

                if (quantity > 1) txtQuantity.Text = (quantity - 1).ToString();
            }
            else MessageBox.Show("Vui lòng chọn đúng định dạng số");
        }

        private void panelListFood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<Food> LstFood = _lstFood.FindAll((food) => food.Name.Contains(txtName.Text));
            LoadListFood(LstFood);
        }
    }
}
