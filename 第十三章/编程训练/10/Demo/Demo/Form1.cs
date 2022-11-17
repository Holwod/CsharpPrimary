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

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = "Server=XIAOKE\\XIAOKE;User Id=sa;Pwd=;DataBase=db_EMS";//定义数据库连接字符串
            SqlConnection sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from tb_PDic where name like '%C#%'", sqlcon);//实例化数据库桥接器对象
            DataSet myds = new DataSet();//实例化数据集对象
            sqlda.Fill(myds);//填充数据集中的指定表
            dataGridView1.DataSource = myds.Tables[0];//为dataGridView1指定数据源
        }
    }
}
