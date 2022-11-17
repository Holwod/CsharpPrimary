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
        void FormColor()
        { // 线程要执行的任务
            while (true)
            { // 使线程处于启用状态
                Thread.Sleep(3000); //线程休眠3秒
                BackColor = Color.Yellow; //窗体的背景色为黄色
                Thread.Sleep(3000); //线程休眠3秒
                BackColor = Color.Black; //窗体的背景色为黑色
                Thread.Sleep(3000); //线程休眠3秒
                BackColor = Color.Magenta; //窗体的背景色为紫红色
                Thread.Sleep(3000); //线程休眠3秒
                BackColor = Color.White; //窗体的背景色为白色
            }
        }

        void FontColor()
        { // 线程要执行的任务
            while (true)
            { // 使线程处于启用状态
                Thread.Sleep(3000); // 线程休眠3秒
                // 设置字体颜色，字体样式
                label1.ForeColor = Color.Blue;
                label1.Font = new Font(new FontFamily("华文琥珀"), 28, FontStyle.Bold);
                Thread.Sleep(3000); // 线程休眠3秒
                // 设置字体颜色，字体样式
                label1.ForeColor = Color.Red;
                label1.Font = new Font(new FontFamily("华文新魏"), 28, FontStyle.Bold);
                Thread.Sleep(3000); // 线程休眠3秒
                // 设置字体颜色，字体样式
                label1.ForeColor = Color.Green;
                label1.Font = new Font(new FontFamily("华文隶书"), 28, FontStyle.Bold);
                Thread.Sleep(3000); // 线程休眠3秒
                // 设置字体颜色，字体样式
                label1.ForeColor = Color.Black;
                label1.Font = new Font(new FontFamily("华文行楷"), 28, FontStyle.Bold);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread colorThread = new Thread(new ThreadStart(FormColor)); //创建控制窗体背景的线程
            Thread styleThread = new Thread(new ThreadStart(FontColor)); //创建控制字体颜色的线程
            colorThread.Start(); //启用“背景色”线程
            styleThread.Start(); //启用“字体样式”线程
        }
    }
}
