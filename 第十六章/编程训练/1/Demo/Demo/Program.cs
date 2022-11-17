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
            int[] a = { 1, 2, 3, 4 };// 定义一个int类型的数组
            for (int i = 0; i < 5; i++)// 遍历数组
            {
                try// try块
                {
                    Console.WriteLine("当 i = " + i + "，" + i + " < 5 时，a[" + i + "] = " + a[i] + "；");// 控制台输出
                }
                catch (Exception e)// catch块
                {
                    Console.WriteLine("当 i = " + i + "，" + i + " < 5 时，a[" + i + "]不存在，会引起"
                            + e.Message + "异常，\n该异常主要是由于索引超出了数组的长度范围引起的");// 控制台输出
                }
                if (i != 4)
                {
                    // 当i不等于4的时候
                    Console.WriteLine("执行i++，" + "i = " + (i + 1) + "。");// 控制台输出
                }
            }
            Console.ReadLine();
        }
    }
}