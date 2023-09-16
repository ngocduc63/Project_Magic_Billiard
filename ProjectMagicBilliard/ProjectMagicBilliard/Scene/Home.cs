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

namespace ProjectMagicBilliard.Scene
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {

        private List<Data.TablePlay> lstTable = new List<Data.TablePlay>();
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
            DataTable res = CallSQL.TablePlayCallSQL.Instance.GetAllTable();

            if(res == null)
            {
                MessageBox.Show("Không tải được bàn bi-a hoặc không có bàn");
                return;
            } 

            foreach(DataRow row in res.Rows)
            {
                Data.TablePlay table = new Data.TablePlay();

                table.Id = row["id"].ToString();
                table.Name = row["name"].ToString();
                table.Status = (StatusTableEnum) (int) row["status"];
                table.Price = row["price"].ToString();

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

                itemTable.TxtId = Regex.Match(table.Id, @"\d+").Value;
                itemTable.TxtName = table.Name;
                itemTable.TxtTime = "00:00:00";
                itemTable.TxtStatus = table.Status.GetStringValue();
                itemTable.TxtPrice = table.Price;

                ListTablePlayPanel.Controls.Add(itemTable);

                if (table.Status == StatusTableEnum.Full) itemTable.LoadTimePlay(testTime);
                else itemTable.StopTimePlay();

                itemTable.SetBackGround(table.Status);
            }
        }
    }
}
