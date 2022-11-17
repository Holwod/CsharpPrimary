using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test18
{
    class Program
    {
        public static void Sort(int[] arr)
        {
            int inc;
            for (inc = 1; inc <= arr.Length / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= arr.Length; i += inc)
                {
                    int t = arr[i - 1];
                    int j = i;
                    while ((j > inc) && (arr[j - inc - 1] > t))
                    {
                        arr[j - 1] = arr[j - inc - 1];//交换数据
                        j -= inc;
                    }
                    arr[j - 1] = t;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 3, 6, 10, 55, 9, 2, 87, 12, 34, 75, 33, 47 };
            Program.Sort(array);
            foreach (int m in array)
                Console.Write("{0} ", m);
            Console.Read();
        }
    }
}
