using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class MyClass
    {
        /// <summary>
        ///定义用户编号属性，该属性为可读可写属性
        /// </summary>
        public string ID
        {
            get;
            set;
        }
        /// <summary>
        ///定义用户姓名属性，该属性为可读可写属性
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        ///定义用户性别属性，该属性为可读可写属性
        /// </summary>
        public string Sex
        {
            get;
            set;
        }
        private int age = 0;//声明一个私有变量，用来表示年龄
        /// <summary>
        /// 定义用户年龄属性，该属性为可读可写属性
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value <= 100) //控制年龄在0—100之间
                {
                    age = value;
                }
                else
                {
                    age = -1;
                    Console.WriteLine("年龄输入有误！");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();//实例化MyClass类对象
            myclass.ID = "BH001";//为用户编号属性赋值
            myclass.Name = "TM1";//为用户姓名属性赋值
            myclass.Sex = "男";
            myclass.Age = 30;
            Console.WriteLine(myclass.ID + " " + myclass.Name + " " + myclass.Sex + " " + myclass.Age);
            myclass.ID = "BH002";
            myclass.Name = "TM2";
            myclass.Sex = "女";
            myclass.Age = 150; //年龄超出范围
            Console.WriteLine(myclass.ID + " " + myclass.Name + " " + myclass.Sex + " " + myclass.Age);
            Console.Read();
        }
    }

}
