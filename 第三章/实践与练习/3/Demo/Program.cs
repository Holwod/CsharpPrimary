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
            Console.Write("请输入商品编号：");
            string id = Console.ReadLine();
            Console.Write("请输入商品名称：");
            string name = Console.ReadLine();
            Console.Write("请输入商品规格：");
            string guige = Console.ReadLine();
            Console.Write("请输入商品价格：");
            string price = Console.ReadLine();
            Console.Write("请输入商品数量：");
            string num = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\t商品入库单\t");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("商品编号：" + id);
            Console.WriteLine("商品名称：" + name);
            Console.WriteLine("商品规格：" + guige);
            Console.WriteLine("商品价格：" + price);
            Console.WriteLine("商品数量：" + num);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t保存   取消\t");
            Console.Read();
        }
    }
}
