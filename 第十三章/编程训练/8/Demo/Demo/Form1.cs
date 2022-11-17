using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //创建数据库连接对象
            SqlConnection sqlcon = new SqlConnection("Server=XIAOKE\\XIAOKE;User Id=sa;Pwd=;DataBase=db_EMS");
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select * from tb_power", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)             //判断连接是否关闭
            {
                sqlcon.Open();                                      //打开数据库连接
            }
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                dataGridView1.Rows.Add(new object[] { sqldr["ID"], sqldr["sysuser"], sqldr["password"], sqldr["stock"], sqldr["vendition"], sqldr["storage"], sqldr["system"]});
            sqlcon.Close();
        }
    }
}
