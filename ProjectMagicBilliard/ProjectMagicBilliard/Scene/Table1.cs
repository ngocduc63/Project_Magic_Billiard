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
            int i = dgvTable.CurrentCell.RowIndex;
            txtID.Text = dgvTable.Rows[i].Cells[0].Value.ToString();
            txtTrangThai.Text = dgvTable.Rows[i].Cells[1].Value.ToString();
            cmbNameCategory.SelectedIndex = cmbNameCategory.FindString(dgvTable.Rows[i].Cells[2].Value.ToString());

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

        }

        public static implicit operator Table1(TablePlay v)
        {
            throw new NotImplementedException();
        }

        private void Table1_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        public void loadcombobox()
        {
            cmbNameCategory.DataSource = TableCategoryCallSQL.Instance.GetAllTableCategory();
            cmbNameCategory.DisplayMember = "name";
            cmbNameCategory.ValueMember = "id";
        }
        public void loadtable()
        {
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.DataSource = TablePlayCallSQL.Instance.GetDataTablePlay();
            loadcombobox();
            txtID.Text = "";
            txtTrangThai.Text = "";
            txttimkiem.Text = "";

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TablePlayCallSQL.Instance.insertTable(txtTrangThai.Text, cmbNameCategory.SelectedValue.ToString()))
            {
                MessageBox.Show("Thêm bàn thành công!!");
                loadtable();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            loadtable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TablePlayCallSQL.Instance.deleteTable(txtID.Text))
            {
                MessageBox.Show("Xóa bàn thành công");
                loadtable();
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TablePlayCallSQL.Instance.updateTable(txtID.Text, txtTrangThai.Text, cmbNameCategory.SelectedValue.ToString()))
            {
                MessageBox.Show("Sửa bàn thành công!!");
                loadtable();
            }
            else
            {
                MessageBox.Show("Sửa bàn thất bại!!");
            }
        }
    }
}
