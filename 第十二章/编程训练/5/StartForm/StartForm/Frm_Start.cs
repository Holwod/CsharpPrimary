using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StartForm
{
    public partial class Frm_Start : Form
    {
        public Frm_Start()
        {
            InitializeComponent();
        }

        int flag = 0;
        private void Frm_Start_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            this.timer1.Start();//启动计时器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
                progressBar1.Value = 0;
            progressBar1.PerformStep();
            flag += 1;
            if (flag == 50)
                this.Close();//关闭启动窗体
        }

        private void Frm_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Stop();//关闭计时器
        }
    }
}
