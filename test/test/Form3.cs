using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace test
{
    public partial class Form3 : Form
    {

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString
            (string section, string key, string strdefault, StringBuilder buffer, int nSize, string filePath);


        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString
            (string section, string key, string val, string filePath);

        public Form3()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {

        }
        string IniPath = "C:\\Users\\KOSTA\\source\\repos\\test\\test\\Form3.ini";
        int l_x, l_y, s_x, s_y;
        private void Form3_Load(object sender, EventArgs e)
        {
            StringBuilder tmp = new StringBuilder(); tmp.Capacity = 500;
            GetPrivateProfileString("FormSection", "LocationX", "100", tmp, tmp.Capacity, @IniPath);
            l_x = int.Parse(tmp.ToString());
            GetPrivateProfileString("FormSection", "LocationY", "300", tmp, tmp.Capacity, @IniPath);
            l_y = int.Parse(tmp.ToString());
            GetPrivateProfileString("FormSection", "SizeX", "1330", tmp, tmp.Capacity, @IniPath);
            s_x = int.Parse(tmp.ToString());
            GetPrivateProfileString("FormSection", "SizeY", "350", tmp, tmp.Capacity, @IniPath);
            s_y = int.Parse(tmp.ToString());

            this.Location = new System.Drawing.Point(l_x, l_y);
            this.Size = new System.Drawing.Size(s_x, s_y);
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            WritePrivateProfileString("FormSection", "LocationX", $"{this.Location.X}", @IniPath);
            WritePrivateProfileString("FormSection", "LocationY", $"{this.Location.Y}", @IniPath);
            WritePrivateProfileString("FormSection", "SizeX", $"{this.Size.Width}", @IniPath);
            WritePrivateProfileString("FormSection", "SizeY", $"{this.Size.Height}", @IniPath);
        }
    }
}
