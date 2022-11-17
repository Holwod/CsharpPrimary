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
        }
        //定义颜色数组
        private static Color[] color = { Color.Black, Color.Blue, Color.Cyan,
        Color.Green, Color.Orange, Color.Yellow,Color.Red, Color.Pink, Color.LightGray };
        private static Color getC()// 获取随机颜色值的方法
        {
            // 随机产生一个color数组长度范围内的数字，以此为索引获取颜色
            return color[new Random().Next(color.Length)];
        }

        int x = 30;//定义初始坐标
        int y = 50;
        void Draw()
        {
            while (true)
            {//无限循环
                Thread.Sleep(100);// 线程休眠0.1秒
                //获取组件绘图上下文对象
                Graphics graphics = this.CreateGraphics();
                Pen pen = new Pen(getC());//设置画笔          
                //绘制直线并递增垂直坐标
                graphics.DrawLine(pen, x, y, 100, y++);
                if (y >= 80)
                {
                    y = 50;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Thread th = new Thread(new ThreadStart(Draw));
            th.Start();
        }
    }
}
