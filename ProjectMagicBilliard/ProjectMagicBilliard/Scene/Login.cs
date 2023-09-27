using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMagicBilliard.CallSQL;

namespace ProjectMagicBilliard.Scene
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usetName = txtUserName.Text;
            string passWord = txtPassWord.Text;

            if(LoginCallSQL.Instance.LoginCheck(usetName, passWord))
            {
                Home home = new Home();

                string name = LoginCallSQL.Instance.GetDisplayName(usetName, passWord);
                home.SetTextStaff(name);

                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu"); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát hệ thống?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK) e.Cancel = true;
        }
    }
}
