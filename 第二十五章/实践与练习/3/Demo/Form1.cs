using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread circle,star;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="开始")
            { // 点击“开始”按钮时
                run = false;
                if (star.ThreadState == ThreadState.Unstarted && circle.ThreadState == ThreadState.Unstarted)
                {
                    star.Start(label1);// 启用“圆点”线程
                    circle.Start(label2); // 启用“五角星”线程
                }
                else
                {
                    star.Resume();
                    circle.Resume();
                }
                button1.Text = "暂停"; // 按钮中的字体内容替换为“暂停”
            }
            else if (button1.Text == "暂停")
            { // 点击“停止”按钮时
                //run = true;
                star.Suspend();
                circle.Suspend();
                button1.Text = "开始"; // 按钮中的字体内容替换为“开始”
            }
        }

        bool run = false; // 挂起线程的标志

        private void Form1_Load(object sender, EventArgs e)
        {
            star = new Thread(new ParameterizedThreadStart(sport));
            circle = new Thread(new ParameterizedThreadStart(sport));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (star != null)
                star.Abort();
            if (circle != null)
                circle.Abort();
        }

        public void sport(object lbl)
        {
            int px = panel1.Width - ((Label)lbl).Width; // 横向最大边界
            int py = panel1.Height - ((Label)lbl).Height; // 纵向最大边界
            int xadd = 1, yadd = 1; // 坐标偏移量
            while (true)
            {
                int x = ((Label)lbl).Location.X; // 获取横坐标
                int y = ((Label)lbl).Location.Y; // 获取纵坐标
                if (x <= 0 || x >= px)
                {// 判断是否到达边界
                    xadd *= -1;// 换方向
                }
                if (y <= 0 || y >= py)
                {
                    yadd *= -1;
                }
                ((Label)lbl).SetBounds(x + xadd, y + yadd, ((Label)lbl).Width, ((Label)lbl).Height);// 重新设置位置
                try
                {
                    Thread.Sleep(8); // 利用线程的休眠控制图标的运行速度
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
