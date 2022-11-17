using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test06
{
    class Class1
    {
        public string Country()
        {
            string strCountry = "方法的示例!";
            return strCountry;
        }
        public string stradd()
        {
            Program myProgram = new Program();
            string strField = myProgram.Cc() + this.Country();
            return strField;
        }
    }
    class Program
    {
        public string Cc()
        {
            string strCc = "这是一个";
            return strCc;
        }
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.stradd());
            Console.Read();
        }
    }
}
