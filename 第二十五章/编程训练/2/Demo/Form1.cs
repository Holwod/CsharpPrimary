using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Image img = Image.FromFile("image.jpg");
       
        String value = "学习累了？来一杯82年的拉菲吧~";// 存储绘制的内容
        int split = 0;// 字符串分隔的位置
        public void paint(Graphics g)
        {
            g.Clear(Color.White);// 清除绘图上下文的内容
            g.DrawImage(img, 0, 0, this.Width, this.Height);// 绘制图像
            Font font = new Font("华文楷体",20,FontStyle.Bold);// 创建字体对象
            g.DrawString(getString(), font,new SolidBrush(Color.Red),20, 100);// 绘制文本
        }
        public void run()
        {
            try
            {
                bool flag = false;// 为false时表示第一次执行，x坐标进行等比递增，否则进行等差递增
                while (true)
                { // 读取内容
                    Thread.Sleep(300); // 当前线程休眠300毫秒
                    paint(this.CreateGraphics());// 调用paint()方法
                    if (split < value.Length)
                    {// 如果分割位置没有超过字符串长度
                        split++;// 分隔位置后移
                    }
                    else
                    {
                        split = 0;// 分隔位置归0
                    }
                    if (!flag)
                    {
                        flag = true;// 赋值为true
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private String getString()
        {// 获取分隔号的字符串
            String head = value.Substring(split);// 将分割出的后半部分当做新字符串的前半部分
            String tail = value.Substring(0, split);// 将分割出的前半部分当做新字符串的后半部分
            return head + tail;// 拼接新字符串
        }
        Thread thread;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            thread = new Thread(new ThreadStart(run));// 创建线程对象
            thread.Start();// 启动线程对象
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }
    }
}