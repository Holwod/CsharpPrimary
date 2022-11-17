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

        private void Form1_Load(object sender, EventArgs e)
        {
            string IP, name, localip = "127.0.0.1";
            string localname = Dns.GetHostName();//获取本机名
            IPAddress[] ips = Dns.GetHostAddresses(localname);//获取所有IP地址
            foreach(IPAddress ip in ips)
            {
                if(!ip.IsIPv6SiteLocal)//如果不是IPV6地址
                    localip = ip.ToString();//获取本机IP地址
            }
            // 将本机名和IP地址输出
            label1.Text += "本机名：" + localname + "  本机IP地址：" + localip;
            for (int i = 50; i <= 60; i++)
            {
                IP = "192.168.1." + i;//生成IP字符串
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(IP);//获取IP封装对象
                    name = host.HostName.ToString();//获取指定IP地址的主机名
                    label1.Text += "\nIP地址 " + IP + " 的主机名称是：" + name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
