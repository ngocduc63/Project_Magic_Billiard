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

namespace ProjectMagicBilliard.Scene
{
    public partial class TableItem : UserControl
    {
        public TableItem()
        {
            InitializeComponent();
        }
        private TimeSpan _timeStart;

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


        public void SetBackGround(StatusTableEnum status)
        {
            if (status == StatusTableEnum.Empty) BackColor = Color.LimeGreen;
            else BackColor = Color.OrangeRed;

        }

        public void LoadTimePlay(TimeSpan timeStart)
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
            txtTimePlay.Text = FormatTimeSpan(_timeStart.TotalSeconds, DateTime.Now.ToLocalTime().TimeOfDay.TotalSeconds);
        }

        private string FormatTimeSpan(double start, double end)
        {
            double offSet = 17 * 60 * 60;
            double resultTime = end - start - offSet;

            // return resultTime.Hours.ToString("00") + ":" + resultTime.Minutes.ToString("00") + ":" + resultTime.Seconds.ToString("00");
            return ConvertSecondToTime(resultTime);
        }

        private void TableItem_Click(object sender, EventArgs e)
        {
            
        }

        public string ConvertSecondToTime(double totalSeconds)
        {
            int hours = (int) totalSeconds / 3600;
            int remainingSeconds =(int) totalSeconds % 3600;
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
