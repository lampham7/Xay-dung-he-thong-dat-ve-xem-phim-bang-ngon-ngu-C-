﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketBookingSystem
{
    public partial class CustomerLogin : Form
    {
       

        public CustomerLogin()
        {
            InitializeComponent();
        }
        public static string username;
       
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=MovieTicketManagementSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String Username = tbUsername.Text.ToString();
                String Password = tbPassword.Text.ToString();

                String qry = "select Username,Password from dbo.Users where Username ='" + tbUsername.Text + "' and Password ='" + tbPassword.Text + "'";

                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter sd = new SqlDataAdapter(qry, con);


                DataTable dt = new DataTable();

                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    username = tbUsername.Text;
                    BlockBusterHomepage BH = new BlockBusterHomepage();
                    BH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn hãy kiểm tra lại tên tài khoản và mật khẩu");
                }

                SqlCommand sc = new SqlCommand(qry, con);
                sc.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi là: " + ex.ToString());
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerWelcomePage cw = new CustomerWelcomePage();
            cw.ShowDialog();
            this.Close();
        }
    }
}
