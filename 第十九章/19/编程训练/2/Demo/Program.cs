using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Sale//创建Sale类，表示销售类
    {
        public static double CaleMoney<T>(T[] items)//定义泛型方法
        {
            double sum = 0;
            foreach (T item in items)//遍历泛型参数数组
            {
                sum += Convert.ToDouble(item);
            }
            return sum;//返回计算结果
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //创建数组，用来存储1——6月份的每月的销售数据
            double[] dbJan = { 3500, 999, 3288, 1999, 12888 };
            double[] dbFeb = { 1499, 1699 };
            double[] dbMar = { 3288, 1998, 1999.9, 49 };
            double[] dbApr = { 98, 1298, 298, 298, 69, 1999, 1699 };
            double[] dbMay = { 4500, 5288, 1698, 2188, 2999, 3999, 6088, 298 };
            double[] dbJun = { 1280, 99, 399, 998, 5288, 5288, 1298 };
            Console.WriteLine("—————上半年销售数据—————\n");
            //调用泛型方法计算每月的总销售额,并输出
            Console.WriteLine("1月商品总销售额：" + Sale.CaleMoney<double>(dbJan));
            Console.WriteLine("2月商品总销售额：" + Sale.CaleMoney<double>(dbFeb));
            Console.WriteLine("3月商品总销售额：" + Sale.CaleMoney<double>(dbMar));
            Console.WriteLine("4月商品总销售额：" + Sale.CaleMoney<double>(dbApr));
            Console.WriteLine("5月商品总销 售额：" + Sale.CaleMoney<double>(dbMay));
            Console.WriteLine("6月商品总销售额：" + Sale.CaleMoney<double>(dbJun));
            Console.ReadLine();
        }
    }
}
