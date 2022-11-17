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

        private void Form1_Load(object sender, EventArgs e)
        {
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection("Server=XIAOKE;User Id=sa;Pwd=;DataBase=db_EMS");
            SqlCommand sqlcmd = new SqlCommand();//创建SqlCommand对象
            sqlcmd.Connection = conn;//指定数据库连接对象
            sqlcmd.CommandType = CommandType.StoredProcedure;//指定执行对象为存储过程
            sqlcmd.CommandText = "proc_EditData";//指定要执行的存储过程名称
            //为@id参数赋值
            sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            //为@name参数赋值
            sqlcmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = "C#开发";
            sqlcmd.Parameters.Add("@money", SqlDbType.Decimal).Value=79.8;//为@money参数赋值
            if (conn.State == ConnectionState.Closed)//判断连接是否关闭
            {
                conn.Open();//打开数据库连接
            }
            //判断ExecuteNonQuery方法返回的参数是否大于0，大于0表示修改成功
            if (Convert.ToInt32(sqlcmd.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            conn.Close();//关闭数据库连接
        }
    }
}
