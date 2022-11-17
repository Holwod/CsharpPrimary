using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        private Thread td;
        private TcpListener tcpListener;
        private static string message = "";

        private void frmMain_Load(object sender, EventArgs e)
        {
            td = new Thread(new ThreadStart(this.StartListen));
            td.Start();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
                string strmsg = " " + txtName.Text + "(" + ip[0].ToString() + ") " + DateTime.Now.ToLongTimeString() + "\n" + "  " + this.rtbSend.Text + "\n";
                TcpClient client = new TcpClient(txtIP.Text, 888);
                NetworkStream netstream = client.GetStream();
                StreamWriter wstream = new StreamWriter(netstream, Encoding.Default);
                wstream.Write(strmsg);
                wstream.Flush();
                wstream.Close();
                client.Close();
                rtbContent.AppendText(strmsg);
                rtbContent.ScrollToCaret();
                rtbSend.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartListen()
        {
            message = "";
            tcpListener = new TcpListener(888);
            tcpListener.Start();
            while (true)
            {
                TcpClient tclient = tcpListener.AcceptTcpClient();  //接受连接请求
                NetworkStream nstream = tclient.GetStream();        //获取数据流
                byte[] mbyte = new byte[1024];                      //建立缓存
                int i = nstream.Read(mbyte, 0, mbyte.Length);       //将数据流写入缓存
                message = Encoding.Default.GetString(mbyte, 0, i);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.tcpListener != null)
            {
                tcpListener.Stop();
            }
            if (td != null)
            {
                if (td.ThreadState == ThreadState.Running)
                {
                    td.Abort();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbContent.Clear();
        }

        private void rtbSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button2_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (message != "")
            {
                rtbContent.AppendText(message);
                rtbContent.ScrollToCaret();
                message = "";
            }
        }
    }
}