using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    public class Year : System.Collections.IEnumerable//实现迭代器的类
    {
        string[] season = { "Spring", "Summer", "Autumn", "Winter" };

        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i < season.Length; i++)
            {
                yield return season[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Year y = new Year();
            // 使用迭代器
            foreach (string s in y)
            {
                System.Console.Write(s + " ");
            }
            Console.ReadLine();
        }
    }
}
