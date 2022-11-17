using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test04
{
    class Program
    {
        partial class Mclass
        {
            public void Hello()
            {
                Console.WriteLine("支付宝");
            }
        }
        partial class Mclass
        {
            public void Hi()
            {
                Console.WriteLine("微信支付");
            }
        }
        static void Main(string[] args)
        {
            Mclass myclass = new Mclass();
            myclass.Hello();
            myclass.Hi();
            Console.ReadLine();
        }
    }
}
