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

namespace 多线程
{
    //前台线程：只有所以的前台线程都关闭才能完成程序关闭
    //后台线程：只要所以的前台线程结束，后台线程自动结束

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //创建多一个线程执行Test静态方法（前台线程）
            th = new Thread(Test);
            //th.Start();         //告诉CPU这个线程已经准备OK了可以去执行了，具体什么时候执行由cpu决定

            //将线程设置为后台线程
            th.IsBackground = true;
            th.Start();


            Thread.Sleep(1000);      //主线程1秒后再执行
            //单线程问题
            //主线程跑去输出了导致窗体假死（主线程也属于前台线程）
            //Test();
       
        
            
        }

        private void Test()
        {
            for (int i = 0; i < 1000000; i++)
            {
               // Console.WriteLine(i);
               //在.Net不允许跨线程的访问
                textBox1.Text = i.ToString();
              
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问检查
            //Control是所有控件的基类
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗体的时候,判断新线程是否为null
            if(th!= null)
                th.Abort();         //结束这个线程就不能重新开始了
            //被Abort()就不能Start()了
        }
    }


}
