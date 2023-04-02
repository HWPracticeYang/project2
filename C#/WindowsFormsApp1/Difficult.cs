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
    public partial class Difficult : Form
    {
        string name;
        int count = 60;
        int correct = 0;
        public Difficult(string strTextMsg)
        {
            InitializeComponent();
            name = strTextMsg;
            question();
        }
        private void question()
        {
            Random random = new Random();
            lblNum1.Text = random.Next(1, 51).ToString();    //1~100
            lblNum2.Text = random.Next(1, 51).ToString();
            lblNum3.Text = random.Next(1, 51).ToString();
            lblNum4.Text = random.Next(1, 51).ToString();
            int x = random.Next(1, 5);
            switch (x)
            {
                case 1:
                    lblOperation1.Text = "+";
                    break;
                case 2:
                    lblOperation1.Text = "-";
                    break;
                case 3:
                    while (int.Parse(lblNum1.Text) < int.Parse(lblNum2.Text))
                    {
                        lblNum1.Text = random.Next(1, 51).ToString();    //1~50
                        lblNum2.Text = random.Next(1, 51).ToString();
                    }
                    lblOperation1.Text = "*";
                    break;
                case 4:
                    while (int.Parse(lblNum1.Text) < int.Parse(lblNum2.Text))
                    {
                        lblNum1.Text = random.Next(1, 51).ToString();    //1~50
                        lblNum2.Text = random.Next(1, 51).ToString();
                    }
                    lblOperation1.Text = "/";
                    break;
            }

            int x2 = random.Next(1, 5);
            switch (x2)
            {
                case 1:
                    lblOperation3.Text = "+";
                    break;
                case 2:
                    lblOperation3.Text = "-";
                    break;
                case 3:
                    while (int.Parse(lblNum1.Text) < int.Parse(lblNum2.Text))
                    {
                        lblNum1.Text = random.Next(1, 51).ToString();    //1~50
                        lblNum2.Text = random.Next(1, 51).ToString();
                    }
                    lblOperation3.Text = "*";
                    break;
                case 4:
                    while (int.Parse(lblNum1.Text) < int.Parse(lblNum2.Text))
                    {
                        lblNum1.Text = random.Next(1, 51).ToString();    //1~50
                        lblNum2.Text = random.Next(1, 51).ToString();
                    }
                    lblOperation3.Text = "/";
                    break;
            }

            int x3 = random.Next(1, 3);
            switch (x3)
            {
                case 1:
                    lblOperation5.Text = "+";
                    break;
                case 2:
                    lblOperation5.Text = "-";
                    break; 
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                //int check=0;
                double check2 = 0;
                string op1 = lblOperation3.Text;
                string op2 = lblOperation1.Text;
                string op3 = lblOperation5.Text;
                switch (op1)
                {
                    case "+":
                        check2 = double.Parse(lblNum2.Text) + double.Parse(lblNum3.Text);
                        break;
                    case "-":
                        check2 = double.Parse(lblNum2.Text) - double.Parse(lblNum3.Text);
                        break;
                    case "*":
                        check2 = double.Parse(lblNum2.Text) * double.Parse(lblNum3.Text);
                        break;
                    case "/":
                        check2 = double.Parse(lblNum2.Text) / double.Parse(lblNum3.Text);
                        break;
                    default:
                        break;
                }
                check2 = Math.Round(check2, 1, MidpointRounding.AwayFromZero);
                switch (op2)
                {
                    case "+":
                        check2 += double.Parse(lblNum1.Text);
                        break;
                    case "-":
                        check2 = double.Parse(lblNum1.Text) - check2;
                        break;
                    case "*":
                        check2 = double.Parse(lblNum1.Text) * check2;
                        break;
                    case "/":
                        check2 = double.Parse(lblNum1.Text) / check2;

                        break;
                    default:
                        break;

                }
                check2 = Math.Round(check2, 1, MidpointRounding.AwayFromZero);
                switch (op3)
                {
                    case "+":
                        check2 += double.Parse(lblNum4.Text);
                        break;
                    case "-":
                        check2 -= double.Parse(lblNum4.Text);
                        break;
                    default:
                        break;

                }
                check2 = Math.Round(check2, 1, MidpointRounding.AwayFromZero);
                if (double.Parse(txtAns.Text) == check2)
                {
                    correct++;
                }
                txtAns.Text = "";
                //MessageBox.Show("目前對了" + correct + "題");
                question();
            }
            catch
            {
                MessageBox.Show("填寫錯誤");
                txtAns.Text = "";
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            lblTime.Text = count.ToString();
            if (int.Parse(lblTime.Text) == 0)
            {
                timer1.Stop();
                MessageBox.Show("時間到!\n總共答對" + correct + "題");
                record();
                pic p = new pic(name);
                p.Owner = this;
                this.Hide();        //把當前窗隱藏起來
                p.ShowDialog();     //跳到遊戲介紹頁面
                Application.ExitThread();   //退出當前執行緒
            }
        }
        private void record()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True");   //建立資料庫連線
            conn.Open();    //開啟資料庫連線
            SqlCommand cmd = new SqlCommand("Insert Into history1 (name,level,time,score) values(@pName,@pLevel,@pTime,@pScore)", conn);
            cmd.Parameters.Add("@pName", SqlDbType.NVarChar, 10).Value = name;
            cmd.Parameters.Add("@pLevel", SqlDbType.NVarChar, 10).Value = "Difficult";
            cmd.Parameters.Add("@pTime", SqlDbType.DateTime, 10).Value = DateTime.Now.ToString();
            cmd.Parameters.Add("@pScore", SqlDbType.Int, 4).Value = correct;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
