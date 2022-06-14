using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MovieTicketBookingSystem
{
    public partial class AddMovies : Form
    {
        public AddMovies()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=MovieTicketManagementSystem;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        String picLoc1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String movieName = textBox2.Text.ToString();
                String genres = textBox5.Text.ToString();
                String synopsis = richTextBox1.Text.ToString();

                String runTime = textBox3.Text.ToString();
                //int irunTime = Int32.Parse(runTime);

                String releaseDate = dateTimePicker1.Value.ToString();

                byte[] img = null;
                FileStream fstream = new FileStream(picLoc1, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                img = br.ReadBytes((int)fstream.Length);

                con.Open();
                String qry = "insert into dbo.Movies(MovieName,Genres,Synopsis,RunTime,ReleaseDate,Poster) values(N'" + movieName + "',N'" + genres + "',N'" + synopsis + "','" + runTime + "','" + releaseDate + "',@img) ";

                SqlCommand sc = new SqlCommand(qry, con);
                sc.Parameters.Add(new SqlParameter("@img", img));
                sc.ExecuteNonQuery();
                MessageBox.Show("Thêm phim thành công");
            }
          catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picLoc1 = dlg.FileName.ToString();
                pictureBox1.ImageLocation = picLoc1;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomepage ah = new AdminHomepage();
            ah.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
