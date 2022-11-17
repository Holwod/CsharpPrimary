using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinqShowSalaryByType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义全局变量及对象
        string strCon = "Data Source=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=;";
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet myds;
        #endregion

        //窗体加载时显示所有数据
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter("select * from tb_Salary", sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds, "tb_Salary");
            var query = from salary in myds.Tables["tb_Salary"].AsEnumerable()
                        select salary;
            DataTable myDTable = query.CopyToDataTable<DataRow>();
            dataGridView1.DataSource = myDTable;
        }

        //按薪水降序排序
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter("select * from tb_Salary", sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds, "tb_Salary");
            var query = from salary in myds.Tables["tb_Salary"].AsEnumerable()
                        orderby salary.Field<int>("Salary") descending
                        select salary;
            DataView myDView = query.AsDataView();
            dataGridView1.DataSource = myDView;
        }

        //按薪水升序排序
        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter("select * from tb_Salary", sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds, "tb_Salary");
            var query = from salary in myds.Tables["tb_Salary"].AsEnumerable()
                        orderby salary.Field<int>("Salary") ascending
                        select salary;
            DataView myDView = query.AsDataView();
            dataGridView1.DataSource = myDView;
        }

        //前5名薪水
        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter("select * from tb_Salary", sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds, "tb_Salary");
            var query = from salary in myds.Tables["tb_Salary"].AsEnumerable()
                        orderby salary.Field<int>("Salary") descending
                        select salary;
            var result = query.Take(5);
            DataTable myDTable = result.CopyToDataTable<DataRow>();
            dataGridView1.DataSource = myDTable;
        }

        //刷新
        private void button5_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
