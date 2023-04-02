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
using System.Data;

namespace WindowsFormsApp1
{
    public partial class start : Form
    {
        string name;
        public start()
        {
            InitializeComponent();
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
        }
        public start(string strTextMsg)
        {
            InitializeComponent();
            name = strTextMsg;
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
            lblwelcome.Text = "";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True");   //建立資料庫連線
            conn.Open();    //開啟資料庫連線
            SqlCommand cmd = new SqlCommand("select name from player where account=@account",conn);
            cmd.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = strTextMsg;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblwelcome.Text = dr.GetString(0);  //顯示name
                
                if (DateTime.Now.Hour>=18||DateTime.Now.Hour<4)//晚上6.~早上3.
                {
                    lblwelcome.Text+= "晚上好~";
                }
                else if(DateTime.Now.Hour >= 4 || DateTime.Now.Hour < 12)//早上4.~11.
                {
                    lblwelcome.Text += " 早安,我的朋友";
                }
                else if (DateTime.Now.Hour >= 12 || DateTime.Now.Hour <=1)//中午12.~1.
                {
                    lblwelcome.Text += " 午安,吃飯了嗎?";
                }
                else if (DateTime.Now.Hour >= 2 || DateTime.Now.Hour < 18)//下午2.~晚上17.
                {
                    lblwelcome.Text += " 下午好,等等一起看夕陽吧";
                }
            }
            dr.Close();
            conn.Close();
        }

        private void btnIntroduce_Click(object sender, EventArgs e) //玩法介紹
        {
            lblwelcome.Visible = false;
            picWord.Visible = true;
            btnclose.Visible = true;
            lblIntroduce.Visible = true;
            lblIntroduce.Text = "玩法介紹:\n隨機產生式子\n看在時間內可以答出幾題";
        }

        private void btnclose_Click(object sender, EventArgs e) //關閉
        {
            lblwelcome.Visible = true;
            btnclose.Visible = false;
            picWord.Visible = false;
            lblIntroduce.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //play
        {
            pic level= new pic(name);
            level.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            level.ShowDialog();     //跳到關卡頁面
            Application.ExitThread();   //退出當前執行緒
        }

        private void btnRecord_Click(object sender, EventArgs e)//查詢紀錄
        {
            Record record = new Record(name);
            record.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            record.ShowDialog();     //跳到關卡頁面
            Application.ExitThread();   //退出當前執行緒
        }

        private void btnOut_Click(object sender, EventArgs e)//登出
        {
            login login = new login();
            login.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            login.ShowDialog();     //跳到關卡頁面
            Application.ExitThread();   //退出當前執行緒
        }
    }
}
