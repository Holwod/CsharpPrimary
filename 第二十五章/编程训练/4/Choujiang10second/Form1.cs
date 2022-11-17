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

namespace Choujiang10second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        int timer = 0;
        Thread t;
        public void run()
        {
            try
            {
                while (true)
                {
                    timer++;
                    StringBuilder timeStr = new StringBuilder(timer.ToString("0000"));
                    timeStr.Insert(2, ".");
                    label1.Text = timeStr.ToString();
                    Thread.Sleep(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("线程停止");
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("btn2.png");
            timer = 0;
            t = new Thread(new ThreadStart(run));
            t.Start();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("btn1.png");
            string message = "";
            t.Interrupt();
            if (timer % 10 == 0 && timer >= 1000)
            {
                if (timer / 10 % 10 == 0)
                {
                    if (timer / 100 % 10 == 0)
                    {
                        message = "成功锁定10:00,买多少送多少（再送小票等额商品）";
                    }
                    else
                    {
                        message = "成功锁定10:0X,赠10元免单券（消费抵现，限购正价商品）";
                    }
                }
                else
                {
                    message = "成功锁定10:XX,赠20元消费券（消费50抵20元）";
                }
            }
            else
            {
                message = "很遗憾，您没能中奖！";
            }
            MessageBox.Show(message);
        }
    }
}
