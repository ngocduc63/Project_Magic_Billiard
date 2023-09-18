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

        private List<TablePlay> lstTable;
        private string _idCurrentTable;

        public Home()
        {
            InitializeComponent();
            timer1.Start();
            GetTablePlay();
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
            if (BillCallSQL.Instance.InsertToBill(DateTime.Now.ToLocalTime(), _idCurrentTable))
            {
                MessageBox.Show($"Bắt đầu tính giờ bàn {_idCurrentTable}");
                GetTablePlay();

            }
            else MessageBox.Show($"Tính giờ bàn {_idCurrentTable} lỗi!!!");
        }

        private void btnEndTimePlay_Click(object sender, EventArgs e)
        {

        }

        public void GetTablePlay()
        {
            DataTable res = TablePlayCallSQL.Instance.GetAllTable();

            if(res == null)
            {
                MessageBox.Show("Không tải được bàn bi-a hoặc không có bàn");
                return;
            }

            lstTable = new List<TablePlay>();
            foreach(DataRow row in res.Rows)
            {
                TablePlay table = new TablePlay(row);
                
                lstTable.Add(table);
            }

            LoadAllTable();
        }


        public void LoadAllTable()
        {
            ListTablePlayPanel.Controls.Clear();

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

                if (table.Status == StatusTableEnum.Full)
                {
                    DateTime timeStart = (DateTime) BillCallSQL.Instance.GetTimeStart(table.Id).Rows[0]["dateCheckIn"];
                    itemTable.LoadTimePlay(timeStart.ToLocalTime().TimeOfDay);
                }
                else itemTable.StopTimePlay();

                itemTable.SetBackGround(table.Status);

                itemTable.Table = table;
            }
        }

        public void LoadDGVBill(List<BillInfo> lstBillInfo, TablePlay table)
        {
            dgvBillInfo.DataSource = lstBillInfo;
            dgvBillInfo.ReadOnly = true;
            txtTitleBillInfo.Text = "Hóa đơn bàn " + _idCurrentTable;
        }

        private void ItemTablePlay_Click(object sender, EventArgs e)
        {
            TableItem itemTable = (TableItem) sender;
            TablePlay dataTable = itemTable.Table;

            DataTable data = TablePlayCallSQL.Instance.GetBillOfTable(dataTable.Id);
            _idCurrentTable = dataTable.Id;

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
