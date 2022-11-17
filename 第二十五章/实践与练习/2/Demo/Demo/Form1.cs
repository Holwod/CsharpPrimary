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
            CheckForIllegalCrossThreadCalls = false;
        }
        void Rabbit()
        {
            for (int i = 1; i < 11; i++)
            {//循环10次模拟赛跑的过程
                Thread.Sleep(100);//线程休眠0.1秒，模拟兔子在跑步
                richTextBox1.Text += "\n  兔子跑了" + i + "0米";//显示兔子的跑步距离
                if (i == 9)
                {
                    richTextBox1.Text += "\n  兔子在睡觉";//当跑了90米时开始睡觉
                    tortoise.Join();
                }
                if (i == 10)
                {
                    richTextBox1.Text += "\n  兔子到达终点";//显示兔子到达了终点
                }
            }
        }

        void Tortoise()
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(500);//线程休眠0.5秒，模拟乌龟在跑步
                richTextBox2.Text += "\n  乌龟跑了" + i + "0米";
                if (i == 10)
                {
                    richTextBox2.Text += "\n  乌龟到达终点";
                }
            }
        }
        Thread rabbit;
        Thread tortoise;
        private void button1_Click(object sender, EventArgs e)
        {
            rabbit = new Thread(new ThreadStart(Rabbit));
            tortoise = new Thread(new ThreadStart(Tortoise));
            rabbit.Start();
            tortoise.Start();
        }
    }
}
