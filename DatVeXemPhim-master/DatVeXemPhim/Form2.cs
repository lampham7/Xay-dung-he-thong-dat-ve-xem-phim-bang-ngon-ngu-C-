using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(infor inf)
        {
            InitializeComponent();
            label3.Text = inf.tenPhim;
            label5.Text = inf.thoiGian;
            label7.Text = inf.phong;
            label9.Text = inf.khachHang;
            label11.Text = inf.sdt;
            label13.Text = inf.soGhe;
            label15.Text = inf.thanhtien.ToString();
        }
    }
}
