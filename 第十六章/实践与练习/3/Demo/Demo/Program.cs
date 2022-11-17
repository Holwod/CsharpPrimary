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
            double leftMoney = 1023.79; // 初始化“账户余额”
            Console.Write("请输入取款金额：");
            try
            { // try块
                int drawMoney = Convert.ToInt32(Console.ReadLine());
                double result = leftMoney - drawMoney; // 建立变量间的关系
                if (result >= 0)
                { // 当余额大于取款金额时
                    Console.WriteLine("您账号上的余额：" + (float)result + "元");
                }
                else
                { // 当取款金额超出余额时
                    Console.WriteLine("您账号上的余额不足！");
                }
            }
            catch (FormatException e)
            { // catch块
                Console.WriteLine("发生数字格式转换异常：输入的“取款金额”不是整数！");
            }
            finally
            {
                Console.WriteLine("程序执行完毕，请按回车退出！");
            }
            Console.ReadLine();
        }
    }
}
