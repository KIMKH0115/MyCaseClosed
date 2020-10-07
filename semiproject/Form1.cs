using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace semiproject
{
    public partial class OD : Form
    {

        public SqlConnection sConn = new SqlConnection();
        public SqlCommand sCmd = new SqlCommand();          //  MS SQL interface


        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\KOSTA\\source\\repos\\semiproject\\FOOD.mdf;Integrated Security = True; Connect Timeout = 30";


        public void DBO()
        {
            try
            {
                sConn.ConnectionString = connString;
                sConn.Open();

                sCmd.Connection = sConn;
            }
            catch
            {

            }
        }

        public OD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main dlg = new Main();

            dlg.ShowDialog();

            DBO();
        }
    }
}
