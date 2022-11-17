using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            //播放音乐叫我起床
            if (DateTime.Now.Hour ==1&&DateTime.Now.Minute ==20&&DateTime.Now.Second==0)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
