using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface ISCM
    {
        void Serial();
    }
    interface ILCD
    {
        void Serial();
    }
    class Compute : ISCM, ILCD//继承接口
    {
        void ISCM.Serial()//显式接口成员实现
        {
            Console.WriteLine("单片机的串行接口");
        }
        void ILCD.Serial()//显式接口成员实现
        {
            Console.WriteLine("液晶显示器的串行接口");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Compute compute = new Compute();//创建接口派生类的对象
            ISCM scm = compute;//使用接口派生类的对象实例化接口
            scm.Serial();//使用接口对象调用方法
            ILCD lcd = compute;//使用接口派生类的对象实例化接口
            lcd.Serial();//使用接口对象调用方法
            Console.ReadLine();
        }
    }
}