using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class EventClass //定义订阅者类
    {
        //定义一个委托
        public delegate void LoveEventHandler(string name, string love);
        //定义一个事件
        public event LoveEventHandler loveEvent;
        //定义一个方法
        public void Handle(string name, string love)
        {
            loveEvent(name,love);//调用事件
        }
    }
    class Person//定义发布者类
    {
        //输出爱好
        public void Love(string name,string love)
        {
            Console.WriteLine(name+"喜欢" + love);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person wangzi = new Person();//实例化第一个发布者
            EventClass myClass = new EventClass();//实例化订阅者
            myClass.loveEvent += new EventClass.LoveEventHandler(wangzi.Love);//为第一个发布者订阅事件
            myClass.Handle("王梓","奥特曼卡");//执行事件
            Person xiaoke = new Person();//实例化第二个发布者
            myClass.loveEvent -= new EventClass.LoveEventHandler(wangzi.Love);//移除第一个发布者的订阅事件
            myClass.loveEvent += new EventClass.LoveEventHandler(xiaoke.Love);//为第二个发布者订阅事件
            myClass.Handle("小科","写C#程序");//执行事件
            Console.Read();
        }
    }  
}
