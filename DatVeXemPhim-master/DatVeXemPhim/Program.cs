using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public struct infor
    {
        public string tenPhim;
        public string thoiGian;
        public string phong;
        public string khachHang;
        public string sdt;
        public string soGhe;
        public int thanhtien;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
