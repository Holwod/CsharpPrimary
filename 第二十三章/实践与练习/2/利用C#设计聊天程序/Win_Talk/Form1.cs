using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace Win_Talk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region//定义变量
        IPAddress HostIP = IPAddress.Parse("127.0.0.1");
        IPEndPoint point;
        Socket socket;
        bool flag = true;
        Socket acceptedSocket;
        #endregion

        #region//声名委托
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            textBox2.AppendText(text + "\r\n");
        }
        #endregion

        #region//进程方法
        private void Proccess()
        {
            if (acceptedSocket.Connected)
            {
                while (flag)
                {
                    byte[] receiveByte = new byte[64];
                    acceptedSocket.Receive(receiveByte, receiveByte.Length, 0);
                    string strInfo = Encoding.BigEndianUnicode.GetString(receiveByte);
                    this.Invoke(new SetTextCallback(SetText), new object[] { strInfo });

                }
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            socket.Close();
            acceptedSocket.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Byte[] sendByte = new Byte[64];//创建字节数组
                string sendStr = this.textBox1.Text + "：" + this.textBox3.Text + "\r\n";//设置信息格式
                sendByte = Encoding.BigEndianUnicode.GetBytes(sendStr.ToCharArray());//设置编码
                acceptedSocket.Send(sendByte, sendByte.Length, 0);//发送数据
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HostIP = IPAddress.Parse(textBox1.Text.Trim());//获取对方IP
            try
            {
                point = new IPEndPoint(HostIP, Int32.Parse("11000"));//设置监听端口
                //实例化Socket对象
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(point);//绑定端口
                socket.Listen(50);//开始监听
                acceptedSocket = socket.Accept();//为新建连接创建Socket
                Thread thread = new Thread(new ThreadStart(Proccess));//通过线程调用Proceess方法
                thread.Start();//开始线程
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }
    }
}