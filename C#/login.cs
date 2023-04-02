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
using System.Web;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
            txtPassword.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)     //登入
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\WindowsFormsApp1\APP\northwnd.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True");   //建立資料庫連線
            conn.Open();    //開啟資料庫連線
            SqlCommand cmd = new SqlCommand("select *from player where account=@account or password=@password", conn);
            cmd.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = txtAccount.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = txtPassword.Text;
            SqlDataReader dr = cmd.ExecuteReader();     //執行查詢
            if(dr.Read())   //一行一行讀,有資料
            {
                if (txtAccount.Text == dr["account"].ToString() && txtPassword.Text == dr["password"].ToString())   //帳密都一樣
                {
                    start start= new start(txtAccount.Text);    //把輸入的帳號傳到start頁面
                    start.Owner = this;
                    this.Hide();        //隱藏登入頁面
                    start.ShowDialog();     //彈出新視窗
                    Application.ExitThread();   //退出登入頁面
                }
                else
                {              
                    MessageBox.Show("帳號或密碼錯誤!"); 
                }
            }
            else    //沒資料
            {
                MessageBox.Show("無此帳號 請先註冊!");
            }
            txtAccount.Text = " ";
            txtPassword.Text = " ";
            dr.Close();
            conn.Close();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)    //滑鼠在登入上
        {
            Color color = Color.FromArgb(193, 211, 254);    //改變btn顏色
            btnLogin.BackColor = color;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)    //滑鼠離開控制項
        {
            btnLogin.BackColor = Color.White;   //變回原本顏色
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(193, 211, 254);    //改變btn顏色
            btnRegister.BackColor = color;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.White;   //變回原本顏色
        }

        private void btnRegister_Click(object sender, EventArgs e)//註冊
        {
            register register = new register();
            register.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            register.ShowDialog();     //跳到註冊頁面
            Application.ExitThread();   //退出當前執行緒
        }
    }
}
