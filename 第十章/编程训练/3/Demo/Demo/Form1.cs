﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();//创建子窗体对象
            frm.MdiParent = this;//设置子窗体的父窗体为当前窗体
            frm.WindowState = FormWindowState.Maximized;//设置子窗体最大化显示
            frm.Show();//显示子窗体
        }
    }
}
