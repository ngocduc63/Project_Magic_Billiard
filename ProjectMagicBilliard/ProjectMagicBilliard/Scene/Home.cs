using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ProjectMagicBilliard.Data;
using ProjectMagicBilliard.CallSQL;

namespace ProjectMagicBilliard.Scene
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {

        static private Home instance;

        public static Home Instance
        {
            get { if (instance == null) instance = new Home(); return instance; }
            private set => instance = value;
        }

        private List<Data.TablePlay> lstTable = new List<TablePlay>();
        private TimeSpan testTime;

        public Home()
        {
            InitializeComponent();
            testTime = DateTime.Now.ToLocalTime().TimeOfDay;
            timer1.Start();
            GetTable();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartTimePlay_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTimePlay_Click(object sender, EventArgs e)
        {

        }

        public void GetTable()
        {
            DataTable res = TablePlayCallSQL.Instance.GetAllTable();

            if(res == null)
            {
                MessageBox.Show("Không tải được bàn bi-a hoặc không có bàn");
                return;
            } 

            foreach(DataRow row in res.Rows)
            {
                TablePlay table = new TablePlay(row);
                
                lstTable.Add(table);
            }

            LoadAllTable();
        }

        public void LoadAllTable()
        {
            if (ListTablePlayPanel.Controls.Count > 0) ListTablePlayPanel.Controls.Clear();

            foreach (var table in lstTable)
            {
                TableItem itemTable = new TableItem();

                itemTable.TxtId = GetNumberFromId(table.Id);
                itemTable.TxtName = table.Name;
                itemTable.TxtTime = "00:00:00";
                itemTable.TxtStatus = table.Status.GetStringValue();
                itemTable.TxtPrice = table.Price;

                itemTable.Click += ItemTablePlay_Click;
                ListTablePlayPanel.Controls.Add(itemTable);

                if (table.Status == StatusTableEnum.Full) itemTable.LoadTimePlay(testTime);
                else itemTable.StopTimePlay();

                itemTable.SetBackGround(table.Status);

                itemTable.Table = table;
            }
        }

        public void LoadDGVBill(List<BillInfo> lstBillInfo, TablePlay table)
        {
            dgvBillInfo.DataSource = lstBillInfo;
            dgvBillInfo.ReadOnly = true;
            txtTitleBillInfo.Text = "Hóa đơn bàn " + GetNumberFromId(table.Id);
        }

        private void ItemTablePlay_Click(object sender, EventArgs e)
        {
            TableItem itemTable = (TableItem) sender;
            TablePlay dataTable = itemTable.Table;

            DataTable data = TablePlayCallSQL.Instance.GetBillOfTable(dataTable.Id);

            List<BillInfo> lstBillInfo = new List<BillInfo>();

            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);

                lstBillInfo.Add(billInfo);
            }

            LoadDGVBill(lstBillInfo, dataTable);
        }

        public string GetNumberFromId(string id)
        {
            return Regex.Match(id, @"\d+").Value;
        }
    }
}
