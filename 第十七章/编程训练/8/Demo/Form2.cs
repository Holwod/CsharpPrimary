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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        delegate void setlabel(string str);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setlabel lbl = Form1.form1.SetLabel;
            lbl(textBox1.Text);
        }
    }
}
