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

        private void 打开子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();//实例化FormChild子窗体
            bool isOpened = false; //定义子窗体打开标记，默认值为false
            foreach (Form form in this.MdiChildren) //循环MDI中的所有子窗体
            {
                if (child.Name == form.Name) //若该子窗体已被打开
                {
                    child.Activate();//激活该窗体
                    child.StartPosition = FormStartPosition.CenterParent;
                    child.WindowState = FormWindowState.Normal;
                    isOpened = true; //设置子窗体的打开标记为true
                    child.Dispose();//销毁formChild实例
                    break;
                }
            }
            if (!isOpened) //若该子窗体未打开，则显示该子窗体
            {
                child.MdiParent = this;
                child.Show();
            }
        }
    }
}
