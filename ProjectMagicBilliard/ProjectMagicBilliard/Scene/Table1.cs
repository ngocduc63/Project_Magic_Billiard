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

        }

        public static implicit operator Table1(TablePlay v)
        {
            throw new NotImplementedException();
        }

        private void Table1_Load(object sender, EventArgs e)
        {
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.DataSource = TablePlayCallSQL.Instance.GetAllTable();
        }
    }
}
