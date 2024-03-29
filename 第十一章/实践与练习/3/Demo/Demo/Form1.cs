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


        private bool State = false;//定义一个全局变量标识

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Url.Items.Add("https://www.mingribook.com/");//向ComboBox控件中添加网址“https://www.mingribook.com/”
            cbox_Url.Items.Add("https://www.mingrisoft.com/");
            cbox_Url.Items.Add("https://www.baidu.com.cn/");
        }

        private void cbox_Url_TextChanged(object sender, EventArgs e)
        {
            if (State)//当变量的值为真时
            {
                string importText = cbox_Url.Text;//获得输入的文本
                int index = cbox_Url.FindString(importText);//在ComboBox集合中查找匹配的文本
                if (index >= 0)//当有查找结果时 
                {
                    State = false;//关闭编辑状态
                    cbox_Url.SelectedIndex = index;//找到对应项
                    State = true;//打开编辑状态
                    cbox_Url.Select(importText.Length, cbox_Url.Text.Length);//设定文本的选择长度
                }
            }
        }

        private void cbox_Url_KeyDown(object sender, KeyEventArgs e)
        {
            State = (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);//当按键既不是Back键又不是Delete键时
            cbox_Url.DroppedDown = true;//当有按键被按下时显示下拉列表
        }
    }
}
