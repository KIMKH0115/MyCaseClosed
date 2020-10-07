using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace WebApptest
{
    public partial class _Default : Page
    {
        String strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\KOSTA\\source\\repos\\WebApptest\\WEBApp.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection sConn; // = new SqlConnection();
        SqlCommand sCmd;

        public string GetPASS(string strID)  //  strID : Username, 
        {
            string strPass = "";

            sCmd.CommandText = $"select Password from PASS where Username = '{strID}'";

            strPass = sCmd.ExecuteScalar().ToString();

            return strPass;

            //   sCmd.CommandText = $"select Password from PASS where Username = '{strID}'";
            //   return sCmd.ExecuteScalar().ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strpass = GetPASS(TextBox1.Text);
            if (strpass.Trim() == TextBox2.Text)
            {
                Label1.Text = $" 안녕하세요. {TextBox1.Text}님이 {DateTime.Now.ToString("")}에 로그인 하셨습니다.";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        protected void Label2_Load(object sender, EventArgs e)
        {
            Label2.Text = $"{ DateTime.Now.ToString("t")}";
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            sConn = new SqlConnection(strConn);
            sConn.Open();
            sCmd = new SqlCommand();
            sCmd.Connection = sConn;
        }

        protected void Page_close(object sender, EventArgs e)
        {
            
            sConn.Close();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}