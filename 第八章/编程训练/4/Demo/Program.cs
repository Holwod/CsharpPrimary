using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public static double SquareNum(double num)
        {
            return num * num;//求一个数的平方
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入一个数：");
                double result = SquareNum(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("运算结果：" + result);
            }
        }
    }
}
