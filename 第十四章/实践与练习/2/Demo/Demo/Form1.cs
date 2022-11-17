﻿using System;
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
        public static int INum = 0, AllCount = 0;//定义静态字段
        int Sizes = 4;//每页记录数量

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"server=XIAOKE\XIAOKE;pwd=;uid=sa;database=db_EMS"))//创建数据库连接对象
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_PDic", con);//创建数据适配器对象
                DataTable dt = new DataTable();//创建数据表对象
                da.Fill(dt);//填充数据表
                int i = dt.Rows.Count;//得到记录数量
                AllCount = i;//得到记录数量
                int m = i % Sizes;//取模运算
                if (m == 0)
                {
                    m = i / Sizes;//计算记录页数
                }
                else
                {
                    m = i / Sizes + 1;//记算记录页数
                }
                this.label3.Text = m.ToString();//显示记录页数
                show(0, 4);//显示数据记录
                this.label4.Text = "1";//显示当前页数
            }
        }

        /// <summary>
        /// 查询并显示数据记录
        /// </summary>
        /// <param name="i">记录起始索引</param>
        /// <param name="j">记录数量</param>
        private void show(int i, int j)
        {
            SqlConnection con = new SqlConnection(@"server=XIAOKE\XIAOKE;pwd=;uid=sa;database=db_EMS");//创建数据库连接对象
            SqlDataAdapter daone = new SqlDataAdapter("select * from tb_PDic", con);//创建数据适配器对象
            DataSet dsone = new DataSet();//创建数据集
            daone.Fill(dsone, i, j, "one");//填充数据集
            this.dataGridView1.DataSource = dsone.Tables["one"].DefaultView;//设置数据源
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.dataGridView1.DataSource = null;//设置数据源
            int m = Convert.ToInt32(this.label4.Text) - 1;//得到页数索引
            if (m < 1)
            {
                this.label4.Text = "1";//显示当前页数
            }
            else
            {
                this.label4.Text = m.ToString();//显示当前页数
            }
            int a = Convert.ToInt32(this.label4.Text) * 4 - 4;//得到记录数索引
            show(a, 4);//显示数据记录
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.dataGridView1.DataSource = null;//设置数据源
            int m = Convert.ToInt32(this.label4.Text) + 1;//得到页数索引
            if (m > Convert.ToInt32(this.label3.Text))
            {
                this.label4.Text = this.label3.Text;//显示当前页数
            }
            else
            {
                this.label4.Text = m.ToString();//显示当前页数
            }
            int a = Convert.ToInt32(this.label4.Text) * 4 - 4;//得到记录数索引
            show(a, 4);//显示数据记录
        }
    }
}
