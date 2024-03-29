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

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Find.Items.Clear();//清空ComboBox集合
            cbox_Find.Items.Add("C#编程词典");//向ComboBox集合添加元素
            cbox_Find.Items.Add("C#项目开发实战入门");//向ComboBox集合添加元素
            cbox_Find.Items.Add("零基础学C#");//向ComboBox集合添加元素
            cbox_Find.Items.Add("C#精彩编程200例");//向ComboBox集合添加元素
            cbox_Find.Items.Add("C#从入门到精通");//向ComboBox集合添加元素
        }

        private void btn_Begin_Click(object sender, EventArgs e)
        {
            cbox_Find.AutoCompleteMode = //设置自动完成的模式
                AutoCompleteMode.SuggestAppend;
            cbox_Find.AutoCompleteSource = //设置自动完成字符串的源
                AutoCompleteSource.ListItems;
        }
    }
}
