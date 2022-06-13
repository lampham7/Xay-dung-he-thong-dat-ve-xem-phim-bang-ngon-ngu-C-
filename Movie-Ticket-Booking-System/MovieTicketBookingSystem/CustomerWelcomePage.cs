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
    public partial class CustomerWelcomePage : Form
    {
        public CustomerWelcomePage()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignUp s = new CustomerSignUp();
            s.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin s = new CustomerLogin();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectUserPage sup = new SelectUserPage();
            sup.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin s = new CustomerLogin();
            s.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignUp s = new CustomerSignUp();
            s.ShowDialog();
        }
    }
}
