using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            richTextBox1.Text = "商品名称：明日之星\n类别：在线编程教育\n网址：https://star.mingrisoft.com\n特色：编程与数学结合";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入商品名称");
                textBox1.Focus();
            }
            else
            {
                if (textBox1.Text.Trim() == "明日之星")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("查无此商品");
                    textBox1.Text = "";
                }
            }
        }
    }
}