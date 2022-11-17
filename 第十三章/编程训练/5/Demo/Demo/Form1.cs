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
            string strsql = "delete from tb_PDic where ID=2";                 //定义添加数据的SQL语句
            SqlCommand comm = new SqlCommand(strsql, conn);     //创建SqlCommand对象
            if (conn.State == ConnectionState.Closed)           //判断连接是否关闭
            {
                conn.Open();                                    //打开数据库连接
            }
            //判断ExecuteNonQuery方法返回的参数是否大于0，大于0表示删除成功
            if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！不存在该条记录！！！");
            }
            conn.Close();//关闭数据库连接
        }
    }
}
