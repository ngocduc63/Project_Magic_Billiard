using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            int year = DateTime.Now.Year;
            LoadRevenue(year);
            cmbYear.SelectedIndex = cmbYear.FindString(year.ToString());
        }

        private string _nameStaff;
        private string _idStaff;

        public string NameStaff { get => _nameStaff; set => _nameStaff = value; }
        public string IdStaff { get => _idStaff; set => _idStaff = value; }

        public void  LoadRevenue(int year)
        {
            dgvDetail.Visible = false;

            chartRevenue.DataSource = StatisticalCallSQL.Instance.GetRevenueMonth(year);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Statical.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

                DataTable dset = StatisticalCallSQL.Instance.GetDetailRevenue();

                if (dset.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Columns.Count; i++)
                        {
                            wr.Write(dset.Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        for (int i = 0; i < (dset.Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Columns.Count; j++)
                            {
                                if (dset.Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MessageBox.Show(this, "Xuất data thành công: " + savefile.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void cmbYear_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(cmbYear.Text);

                if (year < 2000) return;

                LoadRevenue(year);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số");
            }
        }
    }
}
