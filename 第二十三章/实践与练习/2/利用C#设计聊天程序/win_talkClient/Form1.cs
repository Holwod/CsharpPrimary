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

namespace win_talkClient
{
    public partial class Form1 : Form
    {
        #region//声名变量
        IPAddress HostIP = IPAddress.Parse("127.0.0.1");
        IPEndPoint point;
        Socket socket;
        bool flag = true;
        #endregion

       

       #region//声名委托
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
           textBox2.AppendText(text + "\r\n");
       }
        #endregion

       #region//进程
       private void Proccess()
        {
            if (socket.Connected)
            {
                while (flag)
                {
                    byte[] receiveByte = new byte[64];
                    socket.Receive(receiveByte, receiveByte.Length, 0);
                    string strInfo = Encoding.BigEndianUnicode.GetString(receiveByte);
                    this.Invoke(new SetTextCallback(SetText),new object[]{strInfo});  
                }
            }
        }
       #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] sendByte = new Byte[64];//声明字节数组
                string sendStr = this.textBox1.Text + "：" + this.textBox3.Text + "\r\n";//设置信息格式
                sendByte = Encoding.BigEndianUnicode.GetBytes(sendStr.ToCharArray());//设置编码
                socket.Send(sendByte, sendByte.Length, 0);//发送数据
            }
            catch { }
        }

        public Form1()
            {
                InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

         private void button1_Click(object sender, EventArgs e)
         {
            HostIP = IPAddress.Parse(textBox1.Text.Trim());//获取对方IP
            try
            {
                point = new IPEndPoint(HostIP, Int32.Parse("11000"));//设置监听端口
                //实例化Socket对象
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(point);//连接对方主机
                Thread thread = new Thread(new ThreadStart(Proccess));//通过线程调用方法
                thread.Start();//启用线程
            }
            catch (Exception ey)//如果有异常
            {
                MessageBox.Show("服务器没有开启\r\n" + ey.Message);//显示异常信息
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            socket.Close();
        }
    }
}