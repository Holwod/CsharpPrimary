using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[4] { 95, 88, 80, 96 };
            Console.WriteLine("小明的各科成绩如下：");
            for (int i = 0; i < 4; i++)//利用循环将信息输出
            {
                Console.Write("  " + score[i] + "  ");//输出的信息
            }
            Console.ReadLine();
        }
    }
}
