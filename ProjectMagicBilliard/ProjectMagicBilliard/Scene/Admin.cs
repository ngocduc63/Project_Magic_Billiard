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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private Form currentFormChid;
        private string _nameStaff;
        private string _idStaff;

        public string NameStaff { get => _nameStaff; set => _nameStaff = value; }
        public string IdStaff { get => _idStaff; set => _idStaff = value; }

        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChid != null)
            {
                currentFormChid.Close();
            }
            currentFormChid = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new staff());
            label1.Text = btnNV.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChid != null)
            {
                currentFormChid.Close();
            }
            label1.Text = "Home";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account());
            label1.Text = btnTK.Text;
        }

        private void btnLoaiDoAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodCategory());
            label1.Text = btnLoaiDoAn.Text;
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodScene());
            label1.Text = btnDoAn.Text;
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Position());
            label1.Text = btnCV.Text;
        }

        private void btnLoaiBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TableCotegory());
            label1.Text = btnLoaiBan.Text;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Table1());
            label1.Text = btnBan.Text;
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GuestScene());
            label1.Text = btnKH.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.SetTextStaff(_nameStaff, _idStaff);
            home.IdStaffCurrent = _idStaff;

            home.Show();
            this.Close();
        }

        private void btnCodeManeger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CodeManager());
            label1.Text = btnCodeManeger.Text;
        }
    }
}
