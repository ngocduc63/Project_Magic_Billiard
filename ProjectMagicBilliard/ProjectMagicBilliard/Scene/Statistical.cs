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
    public partial class Statistical : MetroFramework.Forms.MetroForm
    {
        public Statistical()
        {
            InitializeComponent();
            LoadRevenue();
        }

        private string _name;

        public string Name { get => _name; set => _name = value; }

        public void  LoadRevenue()
        {
            dgvDetail.Visible = false;

            chartRevenue.DataSource = StatisticalCallSQL.Instance.GetRevenueMonth();
            chartRevenue.Series["Doanh Thu"].XValueMember = "Thang";
            chartRevenue.Series["Doanh Thu"].YValueMembers = "Doanh Thu";
        }

        private void Statistical_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home home = new Home();

            home.SetTextStaff(_name);

            this.Hide();
            home.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            dgvDetail.Visible = !dgvDetail.Visible;

            if (dgvDetail.Visible)
            {
                btnDetail.Text = "Xem biểu đồ";
                dgvDetail.DataSource = StatisticalCallSQL.Instance.GetDetailRevenue();
            }
            else btnDetail.Text = "Xem chi tiết";
        }
    }
}
