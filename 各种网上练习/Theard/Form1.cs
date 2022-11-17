using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Theard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        List<string> list = new List<string>();


        /// <summary>
        /// 加载ListBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
           string[] path = Directory.GetFiles(@"C:\Users\86198\Desktop\tupian");

            for (int i = 0; i < path.Length; i++)
            { 
                string flieName = Path.GetFileName(path[i]);
                listBox1.Items.Add(flieName);


                list.Add(path[i]);
            }
        }


        /// <summary>
        /// 双击加载图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Drawing.Icon ico = new System.Drawing.Icon(list[listBox1.SelectedIndex]);
            this.Icon = ico;


            pictureBox1.Image = Image.FromFile(list[listBox1.SelectedIndex]);
     
        }
    }
}
