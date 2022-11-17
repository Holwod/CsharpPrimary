using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();//获取输入的字符串
            char[] charstr = str1.ToCharArray();//将输入的内容转换为字符串数组
            Array.Reverse(charstr);//对字符数组反转排序
            string str2 = new string(charstr);//将字符数组转换为字符串
            textBox2.Text = str2;//显示转换后的字符串
        }
    }
}