using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace PerCentum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = "select top 50 percent 编号,商品名称,sum(数量)as 合计销售数量 from tb_xsb group by 编号,商品名称 order by 3 asc";                                                   //设置SQL语句
            SqlConnection cn = new SqlConnection("Server=XIAOKE;DataBase=db_Test;uid=sa;pwd=;");     //连接数据库
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, cn);                //建立SQL语句与数据库的连接
            DataSet ds = new DataSet();                                         //实例化DataSet类
            dap.Fill(ds);                                                   //添加SQL语句并执行
            dataGridView1.DataSource = ds.Tables[0].DefaultView; 						//显示统计后的数据
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlstr = "select * from tb_xsb";
            SqlConnection cn = new SqlConnection("Server=XIAOKE;DataBase=db_Test;uid=sa;pwd=;");
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, cn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}