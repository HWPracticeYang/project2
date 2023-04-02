using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pic : Form
    {
        public pic()
        {
            InitializeComponent();
            this.MaximizeBox = false; //不能放大視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //不能調整視窗大小
            this.StartPosition = FormStartPosition.CenterScreen; //視窗顯示在螢幕中間
        }

        private void picBack_Click(object sender, EventArgs e)  //返回
        {
            start start= new start();
            start.Owner = this;
            this.Hide();        //把當前窗隱藏起來
            start.ShowDialog();     //跳到遊戲介紹頁面
            Application.ExitThread();   //退出當前執行緒
        }
    }
}
