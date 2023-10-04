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
        List<BillInfo> lstBillInfo;
        private List<Food> lstFood = new List<Food>();
        private TablePlay _currentTableData;
        private string _idCurrentBill;
        private string _idSelectedBillInfo;
        private bool _isFirstOpenForm = true;
        private double _priceTimePlay = 0;
        private bool _isWaitPaying = false;
        private string _totalTimePlay;


        public Home()
        {
            InitializeComponent();
            LoadHome();
        }

        public void LoadHome(TablePlay tableData = null)
        {
            _currentTableData = tableData;
            panelDetail.Visible = false;
            timer1.Start();
            cbQuantityFood.SelectedIndex = 0;
            GetTablePlay();
            EnableAllButton(false);
            ItemTablePlay_Click();
            LoadChooseFood();
            _isFirstOpenForm = false;
            PanelMenu.Visible = false;
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
            var result = MessageBox.Show($"Bạn có muốn bắt đầu tính giờ bàn {_currentTableData.Id} không ?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (BillCallSQL.Instance.InsertToBill(DateTime.Now.ToLocalTime(), _currentTableData.Id))
                {
                    MessageBox.Show($"Bắt đầu tính giờ bàn {_currentTableData.Id}");
                    txtTitleIdBill.ForeColor = Color.Black;

                    GetTablePlay();
                    EnableAllButton();
                    setTimeBillText();
                    LoadBillInfo(_currentTableData);

                    _isWaitPaying = false;

                    _idCurrentBill = BillCallSQL.Instance.GetIdCurrent(_currentTableData.Id);
                    txtTitleIdBill.Text = "Hóa đơn số: " + _idCurrentBill;
                }
                else MessageBox.Show($"Tính giờ bàn {_currentTableData.Id} lỗi!!!");
            }
            else return;
        }

        private void btnEndTimePlay_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Bạn có muốn tính tiền bàn {_currentTableData.Id} không ?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (BillCallSQL.Instance.UpdateEndTime(DateTime.Now, _idCurrentBill))
                {
                    MessageBox.Show($"Tính tiền bàn {_currentTableData.Id} thành công");
                    EnableAllButton(false);
                    btnPay.Enabled = true;
                    setTimeBillText();
                    SetTextTotalPrice();
                    LoadAllTable();
                }
                else MessageBox.Show($"Tính tiền bàn {_currentTableData.Id} thất bại!!!!");
            }
            else return;

        }

        public void GetTablePlay()
        {
            DataTable res = TablePlayCallSQL.Instance.GetAllTable();

            if (res == null)
            {
                MessageBox.Show("Không tải được bàn bi-a hoặc không có bàn");
                return;
            }

            lstTable = new List<TablePlay>();
            foreach (DataRow row in res.Rows)
            {
                TablePlay table = new TablePlay(row);

                lstTable.Add(table);
            }

            if(_currentTableData == null) _currentTableData = lstTable.FirstOrDefault();
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
                itemTable.TxtPrice = table.Price.ToString();

                itemTable.Click += ItemTablePlay_Click;
                itemTable.SetClickItem(ItemTablePlay_Click);
                ListTablePlayPanel.Controls.Add(itemTable);

                if (table.Status == StatusTableEnum.Full && BillCallSQL.Instance.GetTimeEnd(table.Id) == null)
                {
                    DateTime? timeStart = BillCallSQL.Instance.GetTimeStart(table.Id);
                    itemTable.LoadTimePlay((DateTime)timeStart);
                }
                else itemTable.StopTimePlay();

                itemTable.SetBackGround(table.Status);

                itemTable.Table = table;
            }
        }

        public void LoadBillInfo(TablePlay dataTable)
        {
            DataTable data = TablePlayCallSQL.Instance.GetBillOfTable(dataTable.Id);

            lstBillInfo = new List<BillInfo>();

            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);

                lstBillInfo.Add(billInfo);
            }

            dgvBillInfo.DataSource = lstBillInfo;
            dgvBillInfo.Columns["Id"].Visible = false;
            dgvBillInfo.ReadOnly = true;
            txtTitleBillInfo.Text = "Hóa đơn bàn " + _currentTableData.Id;

            if (lstBillInfo.Count == 0 || _isWaitPaying)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                _idSelectedBillInfo = dgvBillInfo.Rows[0].Cells[0].Value.ToString();
                cbFood.SelectedIndex = cbFood.FindString(dgvBillInfo.Rows[0].Cells[1].Value.ToString());
                cbQuantityFood.SelectedItem = dgvBillInfo.Rows[0].Cells[3].Value.ToString();
            }

            SetTextTotalPrice();
        }

        public void SetTextTotalPrice()
        {
            txtTotalBIllInfo.Text = NumberFormatter(lstBillInfo.Sum(value => value.TotalPrice) + _priceTimePlay) + "đ";
        }

        private void ItemTablePlay_Click(object sender = null, EventArgs e = null)
        {
            panelDetail.Visible = true;
            PanelMenu.Visible = false;
            _priceTimePlay = 0;
            _isWaitPaying = false;

            TablePlay dataTable;
            if (sender != null)
            {
                TableItem itemTable = sender as TableItem;
                if (itemTable == null) itemTable = (sender as Label).Parent as TableItem;
                dataTable = itemTable.Table;
            }
            else
            {
                dataTable = _currentTableData;
            }

            if (_currentTableData != null && _currentTableData.Id.Equals(dataTable.Id) && !_isFirstOpenForm)
                MessageBox.Show($"Tải lại dữ liệu hóa đơn bàn {dataTable.Id}...");

            _currentTableData = dataTable;

            if (_currentTableData == null) MessageBox.Show("Lỗi");

            if (dataTable.Status == StatusTableEnum.Full)
            {
                _idCurrentBill = BillCallSQL.Instance.GetIdCurrent(_currentTableData.Id);
                txtTitleIdBill.Text = "Mã hóa đơn: " + _idCurrentBill;
                txtTitleIdBill.ForeColor = Color.Black;

                EnableAllButton();
            }
            else
            {
                txtTitleIdBill.Text = "Chưa có hóa đơn";
                txtTitleIdBill.ForeColor = Color.Red;

                EnableAllButton(false);
            }

            setTimeBillText();

            LoadBillInfo(_currentTableData);
            _isFirstOpenForm = false;
        }

        public string GetNumberFromId(string id)
        {
            return Regex.Match(id, @"\d+").Value;
        }

        public void EnableAllButton(bool isEnable = true)
        {
            btnStartTimePlay.Enabled = !isEnable;
            btnEndTimePlay.Enabled = isEnable;
            btnInsert.Enabled = isEnable;
            btnDelete.Enabled = isEnable;
            btnPay.Enabled = isEnable;
            btnUpdate.Enabled = isEnable;
            btnSelectFood.Enabled = isEnable;
        }

        public void LoadChooseFood()
        {
            DataTable dataFood = FoodCallSQL.Instance.GetAllFood();

            foreach (DataRow row in dataFood.Rows)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idFood = cbFood.SelectedValue.ToString();
            int quantityFood = Convert.ToInt32(cbQuantityFood.SelectedItem);

            if (BillInfoCallSQL.Instance.UpdateToBillInfo(_idSelectedBillInfo, idFood, quantityFood))
            {
                MessageBox.Show("Sửa thành công");
                LoadBillInfo(_currentTableData);
            }
            else
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBillInfo.CurrentRow.Index;
            if (index >= 0)
            {
                _idSelectedBillInfo = dgvBillInfo.Rows[index].Cells[0].Value.ToString();
                cbFood.SelectedIndex = cbFood.FindString(dgvBillInfo.Rows[index].Cells[1].Value.ToString());
                cbQuantityFood.SelectedItem = dgvBillInfo.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string NumberFormatter(object number)
        {
            var rs = string.Format("{0:#,#}", number);

            return string.IsNullOrWhiteSpace(rs) ? "0" : rs;
        }

        private void btnSelectFood_Click(object sender, EventArgs e)
        {
            using (SelectFood selectFoodForm = new SelectFood())
            {
                selectFoodForm.LstFood = lstFood;
                selectFoodForm.IdBill = _idCurrentBill;
                selectFoodForm.TableData = _currentTableData;
                selectFoodForm.LoadListFood();

                if (selectFoodForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBillInfo(_currentTableData);
                }
            }

        }

        public void setTimeBillText()
        {
            DateTime? timeStart = BillCallSQL.Instance.GetTimeStart(_currentTableData.Id);
            DateTime? timeEnd = BillCallSQL.Instance.GetTimeEnd(_currentTableData.Id);

            if (timeStart == null) txtTimeStart.Text = "Chưa bắt đầu tính giờ";
            else txtTimeStart.Text = FormatTime((DateTime)timeStart);

            if (timeEnd == null) txtEndTime.Text = "Chưa tính tiền giờ";
            else
            { 
                txtEndTime.Text = FormatTime((DateTime)timeEnd);

                double totalTime = CountTime((DateTime)timeStart, (DateTime)timeEnd);
                _priceTimePlay = ConvertSecondToDouble(totalTime) * _currentTableData.Price;
                _totalTimePlay = ConvertSecondToTime(totalTime);

                EnableAllButton(false);
                btnPay.Enabled = true;
                btnStartTimePlay.Enabled = false;
                _isWaitPaying = true;
            }
        }

        public double ConvertSecondToDouble(double second)
        {
            return second / 3600;
        }

        public string ConvertSecondToTime(double totalSeconds)
        {
            int hours = (int)totalSeconds / 3600;
            int remainingSeconds = (int)totalSeconds % 3600;
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        public string FormatTime(DateTime time)
        {
            int year = time.Year;
            int month = time.Month;
            int day = time.Day;
            string hour = ConvertSecondToTime(time.TimeOfDay.TotalSeconds);

            return $"Ngày: {day}/{month}/{year} \nGiờ: {hour}";
        }

        public double CountTime(DateTime startTime, DateTime endTime)
        {
            double offSetTime = 0;
            double day = (endTime - startTime).TotalDays;
            if (endTime.Day != startTime.Day || endTime.Month != startTime.Month) offSetTime += day * 3600 * 24;

            double resultTime = endTime.TimeOfDay.TotalSeconds - startTime.TimeOfDay.TotalSeconds + offSetTime;

            return resultTime;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_isWaitPaying)
            {
                using (BillPay billPay = new BillPay())
                {
                    billPay.IdCurrentBill = _idCurrentBill;
                    billPay.LoadBillPay(lstBillInfo);
                    billPay.LoadTotalTimeAndPrice(_totalTimePlay, txtTotalBIllInfo.Text);
                    billPay.LoadNameTxt(txtStaff.Text);

                    if (billPay.ShowDialog() == DialogResult.OK)
                    {
                        _isFirstOpenForm = true;
                        _currentTableData = null;
                        GetTablePlay();
                        ItemTablePlay_Click();
                    }
                }
            }
            else MessageBox.Show("Vui lòng tính giờ chơi !!!");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = !PanelMenu.Visible;
        }

        private void DisablePanelMenu_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenFormAdmin_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Close();
        }

        public void SetTextStaff(string name)
        {
            txtStaff.Text = name;
            btnOpenFormAdmin.Visible = name.ToLower().Equals("admin");
        }
    }
}
