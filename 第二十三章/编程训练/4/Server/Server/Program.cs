using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        private static byte[] result = new byte[1024];
        private static int myProt = 888;//端口    
        static Socket server;
        static void Main(string[] args)
        {
            //服务器IP地址    
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(new IPEndPoint(ip, myProt));//绑定IP地址：端口    
            server.Listen(10);//设定最多10个排队连接请求    
            Console.WriteLine("服务器启动成功，等待用户接入…");
            //通过client发送数据    
            while (true)
            {
                Socket client = server.Accept();
                client.Send(Encoding.Default.GetBytes("我是服务器，欢迎光临"));
                Socket myClient = client;
                while (true)
                {
                    try
                    {
                        int length = myClient.Receive(result);//通过client接收数据   
                        Console.WriteLine("有客户端接入，客户IP：" + myClient.RemoteEndPoint.ToString());//输出接收的客户端IP地址  
                        Console.WriteLine("来自客户端的消息：" + Encoding.Default.GetString(result, 0, length));//输出接收的消息  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        myClient.Shutdown(SocketShutdown.Both);
                        myClient.Close();
                        break;
                    }
                }
            }
        }
    }
}
