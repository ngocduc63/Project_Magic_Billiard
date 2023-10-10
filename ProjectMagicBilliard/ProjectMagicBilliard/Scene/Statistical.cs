using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private string _nameStaff;
        private string _idStaff;

        public string NameStaff { get => _nameStaff; set => _nameStaff = value; }
        public string IdStaff { get => _idStaff; set => _idStaff = value; }

        public void  LoadRevenue()
        {
            dgvDetail.Visible = false;

            chartRevenue.DataSource = StatisticalCallSQL.Instance.GetRevenueMonth();
            chartRevenue.Series["Doanh Thu"].XValueMember = "Thang";
            chartRevenue.Series["Doanh Thu"].YValueMembers = "Doanh Thu";

            chartRevenue.Series["Doanh Thu"].IsValueShownAsLabel = true;
            chartRevenue.Series["Doanh Thu"].LabelFormat = "#,##0.00" + "đ";
            chartRevenue.FormatNumber += (sender, e) =>
            {
                if (e.ElementType == ChartElementType.AxisLabels && e.ValueType == ChartValueType.Double)
                {
                    e.LocalizedValue = Home.Instance.NumberFormatter(e.Value);
                }
            };
        }

        private void Statistical_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home home = new Home();

            home.SetTextStaff(_nameStaff);
            home.IdStaffCurrent = _idStaff;

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
