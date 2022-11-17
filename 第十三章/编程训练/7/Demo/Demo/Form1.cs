using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建数据库连接对象
            SqlConnection sqlcon = new SqlConnection("Server=XIAOKE\\XIAOKE;User Id=sa;Pwd=;DataBase=db_EMS");
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select * from tb_power where sysuser='" + textBox1.Text + "' and password='" + textBox2.Text + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)//判断连接是否关闭
            {
                sqlcon.Open();//打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)                          //判断SqlDataReader对象中是否有数据
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("用户名和密码错误，请重新输入！");
                textBox1.Text = textBox2.Text = "";
                textBox1.Focus();
            }
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
