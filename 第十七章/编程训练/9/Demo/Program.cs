using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("貂蝉遇到危险……");
            Diaochan diaochan = new Diaochan();
            diaochan.HelpEvent += (new Luban()).Reply;
            diaochan.HelpEvent += (new Houyi()).Reply;
            diaochan.Help();
            Console.ReadLine();
        }
        class Diaochan
        {
            public delegate void HelpEventHandler();
            public event HelpEventHandler HelpEvent;
            public void Help()
            {
                Console.WriteLine("请求支援！！");
                if (HelpEvent != null)
                {
                    HelpEvent();
                }
            }
        }
        class Luban
        { 
            public void Reply()
            {
                Console.WriteLine("鲁班收到！");
            }
        }
        class Houyi
        {
            public void Reply()
            {
                Console.WriteLine("后裔收到，集合准备团战！");
            }
        }
    }
}
