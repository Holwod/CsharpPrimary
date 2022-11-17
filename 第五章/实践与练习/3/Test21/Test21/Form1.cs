using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = textBox1.Text.Substring(0, textBox1.Text.LastIndexOf("\\"));//从文本框中的输入获取路径
            string strName = textBox1.Text.Substring(textBox1.Text.LastIndexOf("\\") + 1, (textBox1.Text.LastIndexOf(".") - textBox1.Text.LastIndexOf("\\") - 1));//从文本框中的输入获取文件名
            string strEName = textBox1.Text.Substring(textBox1.Text.LastIndexOf(".") + 1, (textBox1.Text.Length - textBox1.Text.LastIndexOf(".") - 1));//从文本框中的输入获取文件扩展名
            MessageBox.Show("文件路径：" + strPath + "\n 文件名：" + strName + "\n 文件扩展名：" + strEName, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);//在对话框中显示文件的信息
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";//设置打开对话框中可以选择所有文件
            openFileDialog1.InitialDirectory = "C:\\";//设置打开对话框中的初始路径是C盘
            openFileDialog1.RestoreDirectory = true;//设置打开对话框中可以记录上次打开位置
            openFileDialog1.ShowDialog();//显示打开对话框
            textBox1.Text = openFileDialog1.FileName.ToString();//显示打开的文件路径，包括名称
        }
    }
}