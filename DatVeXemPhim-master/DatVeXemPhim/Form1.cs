using Gremlin.Net.Process.Traversal;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DatVeXemPhim
{
    public partial class Form1 : Form
    {
        infor inf;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        List<string> listItem;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Phi công siêu đẳng Maverick")
            {
                listItem = new List<string>()
                {
                    "10:50", "12:00", "17h00", "19h40"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "1", "2"
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Sinh vật huyền bí: Những bí mật của Dumbledore")
            {
                listItem = new List<string>()
                {
                    "10:35", "14:45"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "3", "4",
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Người Nhện: Không còn nhà")
            {
                listItem = new List<string>()
                {
                    "17h00", "19h00"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "5"
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Venom: Đối mặt tử thù")
            {
                listItem = new List<string>()
                {
                    "17h00", "19h00"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "5"
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Batman: Vạch trần sự thật")
            {
                listItem = new List<string>()
                {
                    "17h00", "19h00"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "5"
                };
                comboBox3.DataSource = listItem;
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                inf.soGhe += cb.Tag + ", ";
                inf.thanhtien += 70000;
            }
            else
            {
                string s = cb.Tag + ", ";
                if (inf.soGhe.Contains(s))
                {
                    inf.soGhe = inf.soGhe.Replace(s, "");
                    inf.thanhtien -= 70000;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inf.tenPhim = comboBox1.Text;
            inf.thoiGian = comboBox2.Text;
            inf.phong = comboBox3.Text;
            inf.khachHang = textBox1.Text;
            inf.sdt = textBox2.Text;
            Form2 f2 = new Form2(inf);
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
