using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";//清空文本框
            CharEnumerator CEnumerator = textBox1.Text.GetEnumerator();//遍历第一个文本框中的所有字符串
            while (CEnumerator.MoveNext())//使用循环变量
            {
                byte[] array = new byte[1];//定义一个字节数组，用来存储遍历到的字符对应的字节码
                //获取字节码
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);//转换为int类型
                if (asciicode != 32)//判断值如果不是32（空格对应的字节码是32）
                {
                    textBox2.Text += CEnumerator.Current.ToString();//显示到第二个文本框中
                }
            }
        }
    }
}