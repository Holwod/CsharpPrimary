using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //获取电脑所有正在运行的进程
            Process[] pros = Process.GetProcesses();            //静态方法
            foreach (var item in pros)
            {
                //item.Kill();          //杀死正在运行的进程
                Console.WriteLine(item);
             }


            //通过进程打开应用程序
            Process.Start("calc");      //打开计算器
            Process.Start("mspaint");   //画图工具
            Process.Start("notepad");   //记事本
            Process.Start("iexplore","http://www.baidu.com");
            
            //通过进程打开指定文件

            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\86198\Desktop\java笔记.txt");   //加入文件路径
           
            //1.创建进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            





           
        }   
    }
}
