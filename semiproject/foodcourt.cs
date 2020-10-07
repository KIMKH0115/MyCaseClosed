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
using System.Text.RegularExpressions;
using System.Reflection;

namespace semiproject
{
    public partial class Main : Form
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

                
            }
            catch
            {
                
            }
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

        public Main()
        {
            InitializeComponent();
            DBO();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            DBO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = $"select * from {comboBox1.Text}";
            RunSql(s1);

        }

        int tPriceNUm = 0;       
        private void ADDBT_Click(object sender, EventArgs e)
        {
            string s1 = dgv1.SelectedRows[0].Cells[0].Value.ToString();
            string s2 = dgv1.SelectedRows[0].Cells[1].Value.ToString();
            dgv2.Rows.Add(s1, s2);
                tPriceNUm = 0;

            for (int i = 0; i < dgv2.RowCount - 1; i++)
            {
                if (dgv2.Rows[i].Cells[1] != null && dgv2.Rows[i].Cells[1].Value != null)
                {
                    tPriceNUm += int.Parse(dgv2.Rows[i].Cells[1].Value.ToString());
                }
                
            }
            tPrice.Text = tPriceNUm.ToString();
        }

        private void DELETEBT_Click(object sender, EventArgs e)
        {
            dgv2.Rows.RemoveAt(dgv2.CurrentRow.Index);
            tPriceNUm = 0;
            for (int i = 0; i  < dgv2.RowCount - 1; i++)
            {
                if (dgv2.Rows[i].Cells[1] != null && dgv2.Rows[i].Cells[1].Value != null)
                {
                    tPriceNUm += int.Parse(dgv2.Rows[i].Cells[1].Value.ToString());
                }

            }
            tPrice.Text = tPriceNUm.ToString();


        }

        private void CARDBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카드를 넣어주십시오.");

            card dlg = new card();

            dlg.ShowDialog();

            
        }

        private void CASHBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현금을 투입하여 주십시오.");

            cash dlg = new cash();

            dlg.ShowDialog();
        }

      
    }
}
