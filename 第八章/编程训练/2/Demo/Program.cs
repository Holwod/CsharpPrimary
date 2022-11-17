using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StockInfo//商品信息类
    {
        private int num = 0;//声明一个私有变量，用来表示数量
        public int Num//库存数量属性
        {
            get
            {
                return num;
            }
            set
            {
                if (value > 10 && value <= 100)//控制数量在10—100之间
                {
                    num = value;
                }
                else
                {
                    Console.WriteLine("库存数量输入有误！");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入库存商品数量：");
            //创建StockInfo对象
            StockInfo stockInfo = new StockInfo();
            stockInfo.Num = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
