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
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
        }
        private void btnRegister_Click(object sender, EventArgs e)  //註冊
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database1.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True");   //建立資料庫連線
            conn.Open();    //開啟資料庫連線
            SqlCommand cmd = new SqlCommand("select *from player where account=@account or name=@name", conn);
            cmd.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = txtAccount.Text;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = txtname.Text;
            SqlDataReader dr = cmd.ExecuteReader();     //執行查詢
            if (dr.Read())
            {
                MessageBox.Show("帳號或玩家名已存在!");
            }
            else
            {
                if (txtAccount.Text == "" || txtPassword.Text == "" || txtPassword2.Text == " " || txtname.Text == " ")
                {
                    MessageBox.Show("不能是空的!");
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtPassword2.Text = "";
                    txtname.Text = "";
                    return;
                }
                else if (txtPassword.Text != txtPassword2.Text)
                {
                    MessageBox.Show("兩次密碼不一致!");
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtPassword2.Text = "";
                    txtname.Text = "";
                    return;
                }
               
                SqlCommand cmd2 = new SqlCommand("insert into player(account,password,name)values(@account,@password,@name)", conn);    //新增資料到player
                cmd2.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = txtAccount.Text;
                cmd2.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = txtPassword.Text;
                cmd2.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = txtname.Text;
                cmd2.ExecuteNonQuery();
                MessageBox.Show("註冊成功");
                login login = new login();
                login.Owner = this;
                this.Hide();        //隱藏註冊頁面
                login.ShowDialog();     //回到登入頁面
                Application.ExitThread();   //退出註冊頁面
            }
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtname.Text = "";
            dr.Close();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //返回
        {
            login login = new login();
            login.Owner = this;
            this.Hide();        //隱藏註冊頁面
            login.ShowDialog();     //回到登入頁面
            Application.ExitThread();   //退出註冊頁面
        }
    }
}