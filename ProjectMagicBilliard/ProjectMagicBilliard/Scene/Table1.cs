using ProjectMagicBilliard.CallSQL;
using ProjectMagicBilliard.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectMagicBilliard.Scene
{
    public partial class Table1 : Form
    {

        public Table1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvTable[0,dgvTable.CurrentRow.Index].Value.ToString();
            txtTrangThai.Text = dgvTable[1,dgvTable.CurrentRow.Index].Value.ToString();
            cmbNameCategory.SelectedValue = dgvTable[2,dgvTable.CurrentRow.Index].Value.ToString();
        }

        public static implicit operator Table1(TablePlay v)
        {
            throw new NotImplementedException();
        }

        private void Table1_Load(object sender, EventArgs e)
        {
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.DataSource = TablePlayCallSQL.Instance.GetDataTablePlay();
            loadcombobox();
        }

        public void loadcombobox()
        {
            cmbNameCategory.DisplayMember = "name";
            cmbNameCategory.ValueMember = "id";
            cmbNameCategory.DataSource = TableCategoryCallSQL.Instance.GetAllTableCategory();
        }
        public void loadtable()
        {
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.DataSource = TablePlayCallSQL.Instance.GetDataTablePlay();
            loadcombobox();
            txtID.Text = "";
            txtTrangThai.Text = "";
            txttimkiem.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TablePlayCallSQL.Instance.insertTable(txtTrangThai.Text,cmbNameCategory.Text))
            {
                MessageBox.Show($"Thêm bàn thành công!!");
                loadtable();
            }
            else
            {
                MessageBox.Show($"Thêm bàn thất bại!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            loadtable();
        }
    }
}
