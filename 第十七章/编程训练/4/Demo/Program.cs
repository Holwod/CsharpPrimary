using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    interface IPerson//定义IPerson接口
    {
        string Name { get; set; }//姓名属性
        int Age { get; set; }//年龄属性
        void Speek();//说话行为
        void Work();//工作行为
    }
    class Student : IPerson//定义学生类，继承自IPerson接口
    {
        public string Name { get; set; }//实现Name属性
        private int age;//定义age字段，用来表示年龄
        public int Age//实现Age属性
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 0 && age < 120)//控制输入范围
                {
                    age = value;
                }
            }
        }
        public void Speek()//实现Speek方法
        {
            Console.WriteLine(Name + "：老师好");
        }
        public void Work()//实现Work方法
        {
            Console.WriteLine(Name + "同学开始记笔记");
        }
    }
    class Teacher : IPerson//定义老师类，继承自IPerson接口
    {
        public string Name { get; set; }//实现Name属性
        private int age;//定义age字段，用来表示年龄
        public int Age//实现Age属性
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 0 && age < 120)//控制输入范围
                {
                    age = value;
                }
            }
        }
        public void Speek()//实现Speek方法
        {
            Console.WriteLine(Name + "：同学们好");
        }
        public void Work()//实现Work方法
        {
            Console.WriteLine(Name + "老师开始上课");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //使用派生类对象创建接口数组
            IPerson[] person = new IPerson[] { new Student(), new Teacher() };
            person[0].Name = "peter";//为学生姓名赋值
            person[0].Age = 20;//为学生年龄赋值
            person[1].Name = "mike";//为老师姓名赋值
            person[1].Age = 40;//为老师年龄赋值
            person[0].Speek();//学生的说话行为
            person[1].Speek();//老师的说话行为
            Console.WriteLine();//换行
            person[1].Work();//老师的工作行为
            person[0].Work();//学生的工作行为
            Console.ReadLine();
        }
    }
}
