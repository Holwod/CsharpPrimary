using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test07
{
    public abstract class myClass
    {
        private int r = 0;
        /// <summary>
        /// 圆半径
        /// </summary>
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        /// <summary>
        /// 抽象方法，用来计算圆面积
        /// </summary>
        public abstract double Area();
    }
    public class DriveClass : myClass//继承抽象类
    {
        /// <summary>
        /// 重写抽象类中计算圆面积的方法
        /// </summary>
        public override double Area()
        {
            return Math.PI * R * R;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DriveClass driveclass = new DriveClass();//实例化派生类
            myClass myclass = driveclass;//使用派生类对象实例化抽象类
            myclass.R = 3;//使用抽象类对象访问抽象类中的半径属性
            Console.WriteLine("圆面积为：" + myclass.Area());//使用抽象类对象调用派生类中的的方法
            Console.Read();
        }
    }
}
