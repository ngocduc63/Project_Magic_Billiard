using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMagicBilliard.Data;
using ProjectMagicBilliard.CallSQL;
using System.Runtime.InteropServices;

namespace ProjectMagicBilliard.Scene
{
    public partial class TableItem : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public TableItem()
        {
            InitializeComponent();
            txtStatus.GotFocus += (s1, e1) => { HideCaret(txtStatus.Handle); }; // disable caret in text box
        }
        private DateTime _timeStart;

        private void TableItem_Load(object sender, EventArgs e)
        {

        }

        private TablePlay _table = new TablePlay();
        internal TablePlay Table { get => _table; set => _table = value; }

        public string TxtId
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string TxtName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string TxtTime
        {
            get { return txtTimePlay.Text; }
            set { txtTimePlay.Text = value; }
        }

        public string TxtStatus
        {
            get { return txtStatus.Text; }
            set { txtStatus.Text = value; }
        }

        public string TxtPrice
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = "Giá : " + value; }
        }

        public void SetClickItem(EventHandler eventClick)
        {
            txtId.Click += eventClick;
            txtName.Click += eventClick;
            txtTimePlay.Click += eventClick;
            txtPrice.Click += eventClick;
            txtStatus.Controls.Clear();
            txtStatus.Click += eventClick;
        }

        public void SetBackGround(StatusTableEnum status, TableCategory idTableCategory)
        {
            if (status == StatusTableEnum.Empty)
            {
                if (idTableCategory == TableCategory.aplus)
                {
                    BackColor = Color.LimeGreen;
                    txtStatus.BackColor = Color.LimeGreen;
                }
                else if (idTableCategory == TableCategory.mrsung)
                {
                    BackColor = Color.Silver;
                    txtStatus.BackColor = Color.Silver;

                }
                else if (idTableCategory == TableCategory.kking)
                {
                    BackColor = Color.CornflowerBlue;
                    txtStatus.BackColor = Color.CornflowerBlue;
                }
            }
            else if (status == StatusTableEnum.Full)
            {
                BackColor = Color.OrangeRed;
                txtStatus.BackColor = Color.OrangeRed;

            }
            else if (status == StatusTableEnum.WaitPay)
            {
                BackColor = Color.Orange;
                txtStatus.BackColor = Color.Orange;
                txtStatus.ForeColor = Color.White;
            }
        }

        public void LoadTimePlay(DateTime timeStart)
        {
            timePlay.Start();
            _timeStart = timeStart;
        }
        public void StopTimePlay()
        {
            txtTimePlay.Text = "00:00:00";
            timePlay.Stop();
        }

        private void timePlay_Tick(object sender, EventArgs e)
        {
            double totalTime = Home.Instance.CountTime(_timeStart, DateTime.Now);

            txtTimePlay.Text = Home.Instance.ConvertSecondToTime(totalTime);
        }


        private void TableItem_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_EnabledChanged(object sender, EventArgs e)
        {
            //((TextBox)sender).ForeColor = Color.Wh;
        }
    }
}
