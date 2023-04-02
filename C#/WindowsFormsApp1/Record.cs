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

namespace WindowsFormsApp1
{
    public partial class Record : Form
    {
        string name;
        public Record(string strTextMsg)
        {
            InitializeComponent();
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
            name = strTextMsg;
            lblShow.Text = "";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True");   //建立資料庫連線
            conn.Open();    //開啟資料庫連線
            SqlCommand cmd = new SqlCommand("select * from history1 where name=@pName", conn);
            cmd.Parameters.Add("@pName", SqlDbType.NVarChar, 10).Value = name;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //lblShow.Text += dr["name"].ToString() + "\n";
                lblShow.Text += String.Format("{0,-20}{1,-45}{2,-20}\n", "Level", "Time", "Score");
                //lblShow.Text += "Level\t\tTime\t\tScore\n";
                lblShow.Text += String.Format("{0,-20}", dr["level"].ToString());
                lblShow.Text += String.Format("{0,-30:d}", dr["time"].ToString());
                lblShow.Text += String.Format("{0,-10}\n", dr["score"].ToString());
            }
            else
            {
                lblShow.Text += "無歷史紀錄";
            }
            while(dr.Read())
            {
                lblShow.Text += String.Format("{0,-20}", dr["level"].ToString());
                lblShow.Text += String.Format("{0,-30:d}", dr["time"].ToString());
                lblShow.Text += String.Format("{0,-10}\n", dr["score"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void picBack_Click(object sender, EventArgs e)//上一頁
        {
            start s = new start(name);
            s.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            s.ShowDialog();     //跳到Easy
            Application.ExitThread();   //退出當前執行緒
        }
    }
}
