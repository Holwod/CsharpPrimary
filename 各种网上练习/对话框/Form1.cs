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

namespace 对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文本文件";
            
            ofd.Multiselect = true;

            ofd.InitialDirectory = @"C:\Users\86198\Desktop";

            ofd.Filter = "文本文件|*.txt";
            
            ofd.ShowDialog();

            string path = ofd.FileName;

            if (path == "")
                return;
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            { 
                byte[] buffer = new byte[1024*4024*5];
               int r = fsRead.Read(buffer, 0, buffer.Length);
                
               textBox1.Text =  Encoding.Default.GetString(buffer, 0, r);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "请保存要选择的路径";
            ofd.InitialDirectory = @"C:\Users\86198\Desktop";
            ofd.Filter = "文本文件|*.txt";
            ofd.ShowDialog();
            
            string path = ofd.FileName;
            if (path == "")
                return;
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
