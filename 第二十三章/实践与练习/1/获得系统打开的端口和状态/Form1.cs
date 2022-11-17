using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
namespace 获得系统打开的端口和状态
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = new Process();//创建Process实例
            p.StartInfo.FileName = "cmd.exe";//设置启动的应用程序
            p.StartInfo.UseShellExecute = false;//禁止使用操作系统外壳程序启动进程
            p.StartInfo.RedirectStandardInput = true;//应用程序的输入从流中读取
            p.StartInfo.RedirectStandardOutput = true;//应用程序的输出写入流中
            p.StartInfo.RedirectStandardError = true;//将错误信息写入流
            p.StartInfo.CreateNoWindow = true;//是否在新窗口中启动进程
            p.Start();//启动进程
            p.StandardInput.WriteLine(@"netstat -a -n > port.txt");//将字符串写入文本流
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";//清空richTextBox1
            try
            {
                string path = @"port.txt";//设置文本路径
                using (StreamReader sr = new StreamReader(path,Encoding.Default))
                {
                    while (sr.Peek() >= 0)//循环读取信息
                    {
                        this.richTextBox1.Text += sr.ReadLine() + "\r\n";//将读取的信息显示在richTextBox1中
                    }
                }
            }
            catch (Exception hy)//如果出现异常
            {
                MessageBox.Show(hy.Message);//显示异常信息
            }
        }
    }
}