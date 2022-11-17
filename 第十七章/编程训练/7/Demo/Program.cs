using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    delegate void MyDelegate();

    class Test
    {
        MyDelegate a, b;
        public void Oper()
        {
            a = new MyDelegate(Func1);
            b = new MyDelegate(Func2);
            MyDelegate c = (MyDelegate)Delegate.Combine(a, b);
        }
        void Func1() { }
        void Func2() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
