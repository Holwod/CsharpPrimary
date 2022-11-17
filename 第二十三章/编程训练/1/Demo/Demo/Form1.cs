using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            IPHostEntry hostInfo;
            try
            {
                hostInfo = Dns.Resolve(this.textBox1.Text);
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
                this.textBox1.Focus();
                this.textBox1.SelectAll();
                return;
            }
            this.textBox2.Text = hostInfo.HostName;
        }
    }
}
