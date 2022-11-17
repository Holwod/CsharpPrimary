using System;
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
            string str = "radioButton1";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType().Name == "RadioButton")
                {
                    RadioButton rbtn = (RadioButton)ctrl;
                    if (rbtn.Checked)
                        str = rbtn.Name;
                }
            }
            switch (str)
            {
                case "radioButton1":
                    MessageBox.Show("您选择的答案为：A，错误！！！");
                    break;
                case "radioButton2":
                    MessageBox.Show("您选择的答案为：B，错误！！！");
                    break;
                case "radioButton3":
                    MessageBox.Show("您选择的答案为：C，正确！！！");
                    break;
                case "radioButton4":
                    MessageBox.Show("您选择的答案为：D，错误！！！");
                    break;
            }
        }
    }
}
