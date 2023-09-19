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
        private List<Food> lstFood = new List<Food>();
        private TablePlay _currentTableData;
        private string _idCurrentBill;

        public Home()
        {
            InitializeComponent();
            panelDetail.Visible = false;
            timer1.Start();
            cbQuantityFood.SelectedIndex = 0;
            GetTablePlay();
            IsTableFull(false);
            btnStartTimePlay.Enabled = false;
            LoadChooseFood();
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
            string idFood = cbFood.SelectedValue.ToString();
            int quantity = Convert.ToInt32(cbQuantityFood.SelectedItem);
            if (BillInfoCallSQL.Instance.InsertToBillInfo(idFood, quantity, _idCurrentBill))
            {
                MessageBox.Show($"Thêm thành công vào hóa đơn {_idCurrentBill}");
                LoadBillInfo(_currentTableData);
            }
            else
            {
                MessageBox.Show($"Thêm thất bại vào hóa đơn {_idCurrentBill}");
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartTimePlay_Click(object sender, EventArgs e)
        {
            if (BillCallSQL.Instance.InsertToBill(DateTime.Now.ToLocalTime(), _currentTableData.Id))
            {
                MessageBox.Show($"Bắt đầu tính giờ bàn {_currentTableData.Id}");
                GetTablePlay();
                _idCurrentBill = BillCallSQL.Instance.GetIdCurrent(_currentTableData.Id);
                txtTitleIdBill.Text = "Hóa đơn số: " + _idCurrentBill;
                txtTitleIdBill.ForeColor = Color.Black;
                IsTableFull();
            }
            else MessageBox.Show($"Tính giờ bàn {_currentTableData.Id} lỗi!!!");
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
                    DateTime timeStart = BillCallSQL.Instance.GetTimeStart(table.Id);
                    itemTable.LoadTimePlay(timeStart.TimeOfDay);
                }
                else itemTable.StopTimePlay();

                itemTable.SetBackGround(table.Status);

                itemTable.Table = table;
            }
        }

        public void LoadBillInfo(TablePlay dataTable)
        {
            DataTable data = TablePlayCallSQL.Instance.GetBillOfTable(dataTable.Id);

            List<BillInfo> lstBillInfo = new List<BillInfo>();

            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);

                lstBillInfo.Add(billInfo);
            }

            dgvBillInfo.DataSource = lstBillInfo;
            dgvBillInfo.Columns["Id"].Visible = false; 
            dgvBillInfo.ReadOnly = true;
            txtTitleBillInfo.Text = "Hóa đơn bàn " + _currentTableData.Id;
        }

        private void ItemTablePlay_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = true;
            TableItem itemTable = (TableItem) sender;
            TablePlay dataTable = itemTable.Table;
            _currentTableData = dataTable;

            LoadBillInfo(dataTable);

            if(dataTable.Status == StatusTableEnum.Full)
            {
                _idCurrentBill = BillCallSQL.Instance.GetIdCurrent(_currentTableData.Id);
                txtTitleIdBill.Text = "Hóa đơn số: " + _idCurrentBill;
                txtTitleIdBill.ForeColor = Color.Black;

                IsTableFull();
            }
            else
            {
                txtTitleIdBill.Text = "Chưa có hóa đơn";
                txtTitleIdBill.ForeColor = Color.Red;

                IsTableFull(false);
            }
        }

        public string GetNumberFromId(string id)
        {
            return Regex.Match(id, @"\d+").Value;
        }

        public void IsTableFull(bool isEnable = true)
        {
            btnStartTimePlay.Enabled = !isEnable;
            btnEndTimePlay.Enabled = isEnable;
            btnInsert.Enabled = isEnable;
            btnDelete.Enabled = isEnable;
            btnPay.Enabled = isEnable;
        }

        public void LoadChooseFood()
        {
            DataTable dataFood = FoodCallSQL.Instance.GetAllFood();

            foreach(DataRow row in dataFood.Rows)
            {
                Food food = new Food(row);

                lstFood.Add(food);
            }
            cbFood.DataSource = lstFood;
            cbFood.DisplayMember = "Name";
            cbFood.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvBillInfo.SelectedRows[0].Cells[0].Value.ToString();

            if (BillInfoCallSQL.Instance.DeleteToBillInfo(id)) 
            {
                MessageBox.Show("Xóa thành công");
                LoadBillInfo(_currentTableData);
            }
            else MessageBox.Show("Xóa thất bại");
        }
    }
}
