using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test06
{
    interface ImyInterface
    {
        /// <summary>
        /// 长
        /// </summary>
        int Width
        {
            get;
            set;
        }
        /// <summary>
        /// 宽
        /// </summary>
        int Height
        {
            get;
            set;
        }
        /// <summary>
        /// 计算矩形面积
        /// </summary>
        int Area();
    }
    class Program : ImyInterface//继承自接口
    {
        int width = 0;
        int height = 0;
        /// <summary>
        /// 长
        /// </summary>
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        /// <summary>
        /// 宽
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        /// <summary>
        /// 计算矩形面积
        /// </summary>
        public int Area()
        {
            return Width * Height;
        }
        static void Main(string[] args)
        {
            Program program = new Program();//实例化Program类对象
            ImyInterface imyinterface = program;//使用派生类对象实例化接口ImyInterface
            imyinterface.Width = 5;//为派生类中的Width属性赋值
            imyinterface.Height = 3;//为派生类中的Height属性赋值
            Console.WriteLine("矩形的面积为：" + imyinterface.Area());
            Console.Read();
        }
    }
}
