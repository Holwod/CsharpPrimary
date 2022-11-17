using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            lvBook.LargeImageList = imageList1;
            if (txtBookInfo.Text == "")
            {
                bntInfo.Visible = true;
                bntInfo.Text = "书名不能为空";
                bntInfo.ForeColor = Color.Red;
            }
            else
            {
                if (lvBook.Items.Count > 0)
                {
                    for (int i = 0; i < lvBook.Items.Count; i++)
                    {
                        if (lvBook.Items[i].Text.ToString() == txtBookInfo.Text)
                        {
                            bntInfo.Visible = true;
                            bntInfo.Text = "此信息以存在";
                            bntInfo.ForeColor = Color.Green;
                            txtBookInfo.Text = "";
                            txtBookInfo.Focus();
                            return;
                        }// end block if 
                    }//end block if 
                    lvBook.Items.Add(txtBookInfo.Text, 0);
                    bntInfo.Visible = true;
                    bntInfo.Text = "信息已添加";
                    txtBookInfo.Text = "";
                    txtBookInfo.Focus();
                }//end block if 
                else
                {
                    lvBook.Items.Add(txtBookInfo.Text, 0);
                    bntInfo.Visible = true;
                    bntInfo.Text = "信息已添加";
                    txtBookInfo.Text = "";
                    txtBookInfo.Focus();
                }
            }// end block if 
        }
    }
}