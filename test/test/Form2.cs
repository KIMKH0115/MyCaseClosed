using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public string str;
        public int a1, a2, a3, a4, a5;
       

        private void Form2_Load(object sender, EventArgs e)
        {
            cbb1.SelectedIndex = a1;
            cbb2.SelectedIndex = a2;
            cbb3.SelectedIndex = a3;
            cbb4.SelectedIndex = a4;
            cbb5.SelectedIndex = a5;

            

        }

        public Form2()
        {
            InitializeComponent();
            cbb1.SelectedIndex = a1;
            cbb2.SelectedIndex = a2;
            cbb3.SelectedIndex = a3;
            cbb4.SelectedIndex = a4;
            cbb5.SelectedIndex = a5;

            string[] portname = System.IO.Ports.SerialPort.GetPortNames();
            for (int pnum = 0; pnum < portname.Length; pnum++)
                cbb1.Items.Add(portname[pnum]);

        }
        private void OK_Click(object sender, EventArgs e)
        {
            a1 = cbb1.SelectedIndex;
            a2 = cbb2.SelectedIndex;
            a3 = cbb3.SelectedIndex;
            a4 = cbb4.SelectedIndex;
            a5 = cbb5.SelectedIndex;
        }

    }
}
