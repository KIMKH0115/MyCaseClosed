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

namespace test
{
    public partial class TEST : Form
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString
            (string section, string key, string strdefault, StringBuilder buffer, int nSize, string filePath);


        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString
            (string section, string key, string val, string filePath);

        public SqlConnection sConn = new SqlConnection();
        public SqlCommand sCmd = new SqlCommand();          //  MS SQL interface
        



        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\KOSTA\\source\\repos\\test\\test\\MyDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        

        int a1, a2, a3, a4, a5;

        public TEST() //public : 외부참조 가능 (class 기준)
        {
            InitializeComponent();

        }


        public string Getsome(string str, string sdel, int index)
        {
            int i, j, k;
            string s1 = "";
            for (i = 0, j = 0; i < index; i++)
            {
                j = str.IndexOf(sdel, j) + 1;
                if (j == 0 && i > 0) return "";
            }

            k = str.IndexOf(sdel, j);    //j: 시작위치, k: 종료위치 +1
            if (k == -1) k = str.Length;
            s1 = str.Substring(j, k - j);
            return s1;
        }

        delegate void AddTextCB(string text, int n);  // function pointer 선언

        private void AddText(string text , int n)
        {
            if(this.OP.InvokeRequired)
            {
                AddTextCB AddCB = new AddTextCB(AddText);
                this.Invoke(AddCB, new object[] { text, n });  //   call process 콜
            }
            else
            {
                this.OP.Text += text;   //  "\r\n" +
            }
        }
        private void DO_Click(object sender, EventArgs e)  //void = no return //private : 외부참조 불가능
        {

            /*          for(i = 0,j=0; i<num; i++)
                      {
                           j = str.IndexOf(sdel,j) + 1;
                      }

                      k = str.IndexOf(sdel, j);    //j: 시작위치, k: 종료위치 +1
                      if (k == -1) k = str.Length;
           */
         //   OP.Text = Getsome(IP.Text, CT.Text, int.Parse(ID.Text));
        }
       

        private void GO_Click(object sender, EventArgs e)
        {
            string str1 = TB1.Text;             // 숫자
            string str2 = TB2.Text;             // prompt  ====> ex) 온도 : 24.0도
        //    int num = int.Parse(str1);          // str1에 문자가 있는지 검사
            double num = double.Parse(str1);      // str1에 ~
        //    string str = string.Format("{0,10} : {1,10:C2}" , str2, num); 아래열과 똑같음
        //    string str = $"{str2,10} : {num,10:C2}";    //$"" 보관문자열로 해석
            string str3 = string.Format("{{0{0}}}", str2);            //  "1000,10:C2"
            //string str = string.Format("{0,10:C2}", num);       
            string str = string.Format(str3, num);       //  str3 : {0,10:C2}
            //   string str = st    1 + " " + str2;       // string 연결 ex) 'C' strcpy(dest, src);
            OP.Text = str;                      // {val, digit:type_num}
            

        }

    
        private void TTM1_Click(object sender, EventArgs e)
        {
            TB1.Text = "HI";
        }

        private void TTM2_Click(object sender, EventArgs e)
        {
            TB2.Text = "BYE";
        }


        int timeCount, TimerStatus, TimerLimit;
        string StrSerial;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeCount == 0)
            {
                TimerStatus = 0;
                this.timer1.Enabled = false;
                ts.Text = "START";
               // MessageBox.Show("Game Over~!");
                return;
            }
            timeCount--;
            this.label7.Text = $"{timeCount}";
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        { //timer limit set
            F4 dlg = new F4();
            dlg.ShowDialog();
            TimerLimit = dlg.als;

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerLimit = 0;
            TimerStatus = 0;
            this.timer1.Enabled = false;
            ts.Text = "START";
        }


        private void pps_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();

            dlg.a1 = a1;        // com          GetToken 함수
            dlg.a2 = a2;        // 9600 
            dlg.a3 = a3;        // 8
            dlg.a4 = a4;        // 1
            dlg.a5 = a5;        // none , odd, even

            //   dlg.cbb1.Text = Getsome(StrSerial, ":", 0);
            //   string s1 = Getsome(StrSerial, ":", 1);    // "119200,n81"
            //   dlg.cbb2.Text = Getsome(s1, ":", 0);
            //   string s2 = Getsome(s1, ",", 1);   //  "n81"
            //   dlg.cbb3.Text = $"{s2[1]}"; // databits : 8
            //   dlg.cbb4.Text = $"{s2[2]}"; // stopbits : 1
            //   if (s2[0] == 'N')        dlg.cbb5.Text = "None";
            //   else if (s2[0] == 'O')   dlg.cbb5.Text = "Odd";
            //   else                     dlg.cbb5.Text = "Even";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                a1 = dlg.a1;
                a2 = dlg.a2;
                a3 = dlg.a3;
                a4 = dlg.a4;
                a5 = dlg.a5;                //   com1:115200,n81
                StrSerial = dlg.cbb1.Text         //com1, com n
                    + ":"
                    + dlg.cbb2.Text
                    + ","
                    + dlg.cbb5.Text[0]
                    + dlg.cbb3.Text[0]
                    + dlg.cbb4.Text[0];
            }
        }

        private void po_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = Getsome(StrSerial, ":", 0);
            serialPort1.BaudRate = int.Parse(Getsome(Getsome(StrSerial, ":", 1), ",", 0));
            serialPort1.DataBits = int.Parse($"{Getsome(Getsome(StrSerial, ":", 1), ",", 1)[1]}");
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Parity = System.IO.Ports.Parity.None;

            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                // MessageBox.Show($"Serial Port {serialPort1.PortName} opened success.");
                statusStrip1.Items[0].Text = $"Serial Port {serialPort1.PortName} opened success.";
                statusStrip1.Items[0].BackColor = Color.Gold;
            }

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string str;
            str = serialPort1.ReadExisting();
            AddText(str, 0);
            //            textBox2.Text = str;
        }
        private void send_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show($"Serial Port {serialPort1.PortName} NOT opened.");
                return;
            }
            serialPort1.Write(IP.Text);
        }

        private void pc_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void gbt_Click(object sender, EventArgs e)
        {
            int cn = 0;
            string cStr;
            string cs = Getsome(tbGrid.Text, ",", 0);
            cStr = Getsome(tbGrid.Text, ",", 1);        //  +,abcd  :   abcd
   
            if (cs == "+")
            {
                dgv1.Columns.Add(cStr, cStr);
                return;
            }
            else if (cs == "-")
            {
                dgv1.Columns.RemoveAt(dgv1.CurrentCell.ColumnIndex);
                return;
            }

            else if (cs == "*")
            {
             
                   string[] strarr = new string[15];
                   for(int i=0;i<15;i++)
                   {
                       strarr[i] = Getsome(tbGrid.Text, ",", i+1);
                   }
                   dgv1.Rows.Add(strarr);



                // dgv1.Rows.Add(strarr);  //  1,2,3,4 입력되어 생성
                //   int rn = int.Parse(Getsome(tbGrid.Text, ",", 1));
                //   dgv1.Rows.Add(rn);  //  줄수 생성
                //  dgv1.Rows.Add();    //  빈칸 생성
                //  dgv1.Rows.Add(cStr);  //  text입력 생성
                return;
            }
            else if (cs == "/")
            {
                dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
                return;
            }
            else if (cs == "h")
            {
                cn = int.Parse(cStr); //  h,1,abcd  :   1번째 컬럼의 타이틀을 abcd로
                dgv1.Columns[cn].HeaderText = Getsome(tbGrid.Text, ",", 2);
                return;
            }

            else if (cs == "cell")
            {   //  cell,1,2,200 ==> col1, row 2, val 200               
                int col = int.Parse(Getsome(tbGrid.Text, ",", 1));
                int row = int.Parse(Getsome(tbGrid.Text, ",", 2));
                string val = Getsome(tbGrid.Text, ",", 3);
                dgv1.Rows[row].Cells[col].Value = val;
                return;
            }
        }

            private void dgv1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }


        public void RunSql(string strSql)
        {           // select * from facilityinfo
           
            try
            {

                sCmd.CommandText = strSql;
                if (Getsome(strSql, " ", 0).ToUpper() == "SELECT")
                {
                    SqlDataReader sr = sCmd.ExecuteReader();
                    string s1;
                    int i, j, k;
                    dgv1.Rows.Clear();
                    dgv1.Columns.Clear();
                    k = sr.FieldCount - dgv1.ColumnCount;
                    for (i = 0; i < sr.FieldCount; i++)
                    {
                        if (i >= dgv1.ColumnCount)
                            dgv1.Columns.Add(sr.GetName(i), sr.GetName(i));

                        else
                            dgv1.Columns[i].HeaderText = sr.GetName(i);
                    }

                    for (j = 0; sr.Read(); j++)
                    {
                        if (j >= dgv1.RowCount - 1)
                            dgv1.Rows.Add();



                        for (i = 0; i < sr.FieldCount; i++)
                        {

                            s1 = $"{sr.GetValue(i)}";
                            dgv1.Rows[j].Cells[i].Value = s1;


                        }

                    }




                    sr.Close();
                }
                else
                {
                    sCmd.ExecuteNonQuery();     // Non - SELECT  EX) insert / update / delete
                }

                statusStrip1.Items[2].Text = "Excute OK .";
                statusStrip1.Items[2].BackColor = Color.Blue;
            }
            catch
            {
                statusStrip1.Items[2].Text = "Excute Error.";
                statusStrip1.Items[2].BackColor = Color.Black;
                statusStrip1.Items[2].ForeColor = Color.White;
            }
        }

        private void SQLbt_Click(object sender, EventArgs e)
        {           // select * from facilityinfo
            string strSql = tbsql.Text;

            RunSql(strSql);
        }

        public void DBO()
        {
            try
            {
                sConn.ConnectionString = connString;
                sConn.Open();

                sCmd.Connection = sConn;

                statusStrip1.Items[1].Text = "Database Opened success.";
                statusStrip1.Items[1].BackColor = Color.Green;
            }
            catch 
            {
                statusStrip1.Items[1].Text = "Database Error.";
                statusStrip1.Items[1].BackColor = Color.Red;
            }
        }


        private void dBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBO();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opfd1.ShowDialog();
            connString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={opfd1.FileName};Integrated Security = True; Connect Timeout = 30";
            DBO();

            
          
            DataTable dt = sConn.GetSchema("Tables");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s1 = dt.Rows[i].ItemArray[2].ToString();
                tbcb.Items.Add(s1);

            }
            
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {       // update menu : update facilityinfo set [Field]='val' where id=[int]
            int ln1 = dgv1.SelectedCells[0].RowIndex;
            int cn1 = dgv1.SelectedCells[0].ColumnIndex;
            String fn = dgv1.Columns[cn1].HeaderText;
            string fv = dgv1.SelectedCells[0].Value.ToString();
            int idn = int.Parse(dgv1.Rows[ln1].Cells[0].Value.ToString());
            sCmd.CommandText = $"update facilityinfo set {fn}='{fv}' where id={idn}";
            sCmd.ExecuteNonQuery();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {       // DELETE   menu : delete facilityinfo where id=[int]
            int ln1 = dgv1.SelectedCells[0].RowIndex;
            int cn1 = dgv1.SelectedCells[0].ColumnIndex;
            String fn = dgv1.Columns[cn1].HeaderText;
            string fv = dgv1.SelectedCells[0].Value.ToString();
            int idn = int.Parse(dgv1.Rows[ln1].Cells[0].Value.ToString());
            sCmd.CommandText = $"delete facilityinfo where id={idn}";
            sCmd.ExecuteNonQuery();
        }

        private void Vbt_Click(object sender, EventArgs e)
        {
            String s1 = $"select * from {tbcb.Text}";
            RunSql(s1);

        }

        private void impotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   FileStream fs = new FileStream(PathPath, OpenMode);
            if ( opfd1.ShowDialog() != DialogResult.OK) return;


            dgv1.Columns.Clear();
            dgv1.Rows.Clear();

            StreamReader sr = new StreamReader(opfd1.FileName);
            string s1 = sr.ReadLine();  //  1라인 단위로 read
            string[] s2 = s1.Split(',');

            for (int i = 0; i < s2.Length; i++)
            {
                if (i >= dgv1.ColumnCount)
                    dgv1.Columns.Add(s2[i], s2[i]);
                else
                    dgv1.Columns[i].HeaderText = s2[i];
            }

            while (true) //  무한루프
            {
                s1 = sr.ReadLine();
                if (s1 == null) break;  // 종료조건 먼저
                s2 = s1.Split(',');
                dgv1.Rows.Add(s2);

            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svfd1.ShowDialog() != DialogResult.OK) return;

            StreamWriter sw = new StreamWriter(svfd1.FileName);
            string s1 = "";  //  1라인 단위
          

            for (int i = 0; i < dgv1.ColumnCount; i++)      //  Column 결합
            {
                s1 += dgv1.Columns[i].HeaderText;
                if (i < dgv1.ColumnCount - 1) s1 += ',';
            }
            sw.WriteLine(s1);

            for (int j = 0; j < dgv1.RowCount; j++) //  1 라인 단위
            {
                s1 = "";
                for (int i = 0; i < dgv1.ColumnCount; i++)      //  Column 결합
                {
                    s1 += dgv1.Rows[j].Cells[i].Value;
                    if (i < dgv1.ColumnCount - 1) s1 += ',';
                }
                sw.WriteLine(s1);
            }
        }

        private void ts_Click(object sender, EventArgs e)
        {

            if (TimerStatus == 0)
            {
                timeCount = TimerLimit;
                TimerStatus = 1;
                this.timer1.Enabled = true;
                
                ts.Text = "STOP";

            }
            else
            {
                TimerStatus = 0;
                this.timer1.Enabled = false;
                ts.Text = "START";

            }

        }
  
        string IniPath = "C:\\Users\\KOSTA\\source\\repos\\test\\test\\Test1.ini";
        // .\\ current directory : 현재 디렉토리 (exe file과 동일위치)
        // 상대경로 : ..\..\temp\test.txt
        // 절대경로 : c:\\user\\...\\temp\\test.txt
        private void TEST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.FacilityInfo' table. You can move, or remove it, as needed.
            
            StringBuilder tmp = new StringBuilder(); tmp.Capacity = 500;
          GetPrivateProfileString("TestSection", "a1", "0", tmp, tmp.Capacity, @IniPath);
          a1 = int.Parse(tmp.ToString());
          GetPrivateProfileString("TestSection", "a2", "0", tmp, tmp.Capacity, @IniPath);
          a2 = int.Parse(tmp.ToString());
          GetPrivateProfileString("TestSection", "a3", "0", tmp, tmp.Capacity, @IniPath);
          a3 = int.Parse(tmp.ToString());
          GetPrivateProfileString("TestSection", "a4", "0", tmp, tmp.Capacity, @IniPath);
          a4 = int.Parse(tmp.ToString());
          GetPrivateProfileString("TestSection", "a5", "0", tmp, tmp.Capacity, @IniPath);
          a5 = int.Parse(tmp.ToString());
          
        }

        private void TEST_FormClosed(object sender, FormClosedEventArgs e)
        {
            WritePrivateProfileString("TestSection", "a1",  $"{a1}", @IniPath);
            WritePrivateProfileString("TestSection", "a2",  $"{a2}", @IniPath);
            WritePrivateProfileString("TestSection", "a3",  $"{a3}", @IniPath);
            WritePrivateProfileString("TestSection", "a4",  $"{a4}", @IniPath);
            WritePrivateProfileString("TestSection", "a5",  $"{a5}", @IniPath);

            WritePrivateProfileString("SerialPortSet", "SerialPort", $"{StrSerial}", @IniPath);
            sConn.Close();
        }


        private void newmenu_Click(object sender, EventArgs e)
        {

        }

        private void F3_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();

            dlg.ShowDialog();

   //         IP.Text = dlg.str;

        }
    }
}
