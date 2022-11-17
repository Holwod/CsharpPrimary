using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface Information//定义接口
    {
        string Code { get; set; }//编号属性
        string Name { get; set; }//名称属性
        void ShowInfo();//用来输出信息
    }
    public class Sale : Information//继承接口，定义销售类
    {
        string code = "";
        string name = "";
        public string Code//实现编号属性
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name//实现名称属性
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sale(string code, string name)//定义构造函数，为属性赋初始值
        {
            Code = code;
            Name = name;
        }
        public void ShowInfo() { }//实现接口方法
        public static void ShowInfo(Sale[] sales)//定义ShowInfo重载方法，用来输出销售的商品信息
        {
            foreach (Sale s in sales)
                Console.WriteLine("商品编号：" + s.Code + "  商品名称：  " + s.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("—————————销售明细—————————");
            //创建Sale数组，用来存储1——3月份的每月的销售商品
            Sale[] salesJan = { new Sale("T0001", "笔记本电脑"), new Sale("T0002", "华为荣耀9X"), new Sale("T0003", "HuaWei Pad"),
                new Sale("T0004", "华为荣耀V30"), new Sale("T0005", "HuaWei MateBook") };
            Sale[] salesFeb = { new Sale("T0006", "华为荣耀20标配版"), new Sale("T0007", "华为荣耀20 Pro") };
            Sale[] salesMar = { new Sale("T0003", "HuaWei Pad"), new Sale("T0004", "华为荣耀V30"), new Sale("T0008", "一加手机"), new Sale("T0009", "充电宝") };
            while (true)
            {
                Console.Write("\n请输出要查询的月份（比如1、2、3等）：");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine("1月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);//调用方法输出销售的商品信息
                            break;
                        case 2:
                            Console.WriteLine("2月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);
                            break;
                        case 3:
                            Console.WriteLine("3月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);
                            break;
                        default:
                            Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                            break;
                    }
                }
                catch (Exception ex)//捕获可能出现的异常信息
                {
                    Console.WriteLine(ex.Message);//输出异常信息
                }
            }
        }
    }
}
