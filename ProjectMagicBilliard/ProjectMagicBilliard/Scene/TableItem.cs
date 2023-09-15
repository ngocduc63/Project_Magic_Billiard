using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMagicBilliard.Scene
{
    public partial class TableItem : UserControl
    {
        public TableItem()
        {
            InitializeComponent();
        }

        private void TableItem_Load(object sender, EventArgs e)
        {

        }

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
    }
}
