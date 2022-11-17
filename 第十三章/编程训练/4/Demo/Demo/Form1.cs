﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            string SqlStr = "provider = Microsoft.ACE.OLEDB.12.0;Data Source = Test.accdb";
            OleDbConnection con = new OleDbConnection(SqlStr);//创建数据库连接对象
            con.Open();//打开数据库连接
            if (con.State == ConnectionState.Open)//判断连接是否打开
            {
                label1.Text = "Access数据库连接开启！";
                con.Close();//关闭数据库连接
            }
            if (con.State == ConnectionState.Closed)//判断连接是否关闭
            {
                label2.Text = "Access数据库连接关闭！";
            }
        }
    }
}
