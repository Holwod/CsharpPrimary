using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    class Program
    {
        private static byte[] result = new byte[1024];
        static void Main(string[] args)
        {
            //设定服务器IP地址    
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(new IPEndPoint(ip, 888));//配置服务器IP与端口    
                Console.WriteLine("连接服务器成功");
            }
            catch
            {
                Console.WriteLine("连接服务器失败");
                return;
            }
            int data = client.Receive(result);//通过client接收数据    
            Console.WriteLine("来自服务器的消息：" + Encoding.Default.GetString(result, 0, data));
            try
            {
                string sendMessage = "你好服务器，我是客户端";
                client.Send(Encoding.Default.GetBytes(sendMessage));//通过client发送数据 
            }
            catch
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            Console.ReadLine();
        }
    }
}
