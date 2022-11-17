using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class IndexClass
    {
        public const int LENGTH = 10;
        string[] name=new string[LENGTH];
        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexClass indexClass = new IndexClass();
            indexClass[0] = "张三";
            indexClass[1] = "李四";
            for(int i=0;i< IndexClass.LENGTH;i++)
            {
                Console.WriteLine(indexClass[i]);
            }
            Console.ReadKey();
        }
    }
}
