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
            //创建数据库连接字符串
            string SqlStr = "Server=DESKTOP-KQAO3PE\\SQL;User Id=sa;Pwd=Tbh1103;DataBase=db_EMS;Integrated Security=SSPI;";
            SqlConnection conn =new SqlConnection(SqlStr);
            conn.Open();    
            if (conn.State == ConnectionState.Open)
            {
                label1.Text = "SQL 数据库连接成功";
                conn.Close();
            }
            if (conn.State == ConnectionState.Closed)
            {
                label2.Text = "SQL 数据库连接失败";

            }

        }
    }
}
