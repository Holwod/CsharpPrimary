using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class StockInfo//自定义库存商品类
    {
        public string FullName { get; set; }//名称
        public string Stand { get; set; }//规格
        private int num=0;
        public int Num//数量
        {
            get
            {
                return num;
            }
            set
            {
                if (value > 0 && value <= 1000)//控制数量在0—1000之间
                {
                    num = value;
                }
                else
                {
                    Console.WriteLine("商品数量输入有误！");
                    return;
                }
            }
        }

        public StockInfo() { }//定义无参构造函数
        //定义有参构造函数，用来初始化属性
        public StockInfo(string fullname, string stand, int num)
        {
            FullName = fullname;
            Stand = stand;
            Num = num;
        }
        //定义方法，用来显示库存商品详细信息
        public void ShowGoods()
        {
            Console.WriteLine("{0}\t{1}\t{2}", FullName, Stand, Num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("商品名称\t规格\t\t数量");
            //使用有参构造函数创建对象
            StockInfo stockInfo = new StockInfo("华为手机", "Mate30 5G", 800);
            stockInfo.ShowGoods();//显示构造函数中初始化的基本信息
            //使用无参构造函数创建对象
            StockInfo stockInfo2 = new StockInfo();
            stockInfo2.FullName = "笔记本电脑";//为Name属性赋值
            stockInfo2.Stand = "P30 5G版";//为TradeType属性赋值
            stockInfo2.Num = 1500; //为Num属性赋值
            stockInfo2.ShowGoods();//显示修改后的库存信息
            Console.ReadLine();
        }
    }
}
