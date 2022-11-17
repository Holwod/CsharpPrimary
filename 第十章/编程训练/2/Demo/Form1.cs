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

        private void Form1_Load(object sender, EventArgs e)
        {
            int DeskWidth = Screen.PrimaryScreen.WorkingArea.Width;//获取桌面宽度
            int DeskHeight = Screen.PrimaryScreen.WorkingArea.Height;//获取桌面高度
            this.Width = Convert.ToInt32(DeskWidth * 0.8);//设置窗体宽度
            this.Height = Convert.ToInt32(DeskHeight * 0.8);//设置窗体高度
        }
    }
}
