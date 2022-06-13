using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text.ToString();
            String password = tbPassword.Text.ToString();
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                AdminHomepage hp = new AdminHomepage();
                hp.ShowDialog();

            }
            else if (username=="admin"&&password!="admin")
            {
                MessageBox.Show("Sai mật khẩu. Hãy kiểm tra lại");
            }
            else if (username != "admin" && password == "admin")
            {
                MessageBox.Show("Sai tên tài khoản. Hãy kiểm tra lại");
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu. Hãy kiểm tra lại");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectUserPage su = new SelectUserPage();
            su.ShowDialog();
            this.Close();
        }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, new EventArgs());
            }
        }
    }
}
