using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02
{
    public class Finder										//建立一个公共类Finder
    {
        public static int Find<T>(T[] items, T item)					//创建泛型方法
        {
            for (int i = 0; i < items.Length; i++)						//调用for循环
            {
                if (items[i].Equals(item))							//调用Equals方法比较两个数
                {
                    return i;									//返回相等数在数组中的位置
                }
            }
            return -1;										//如果不存在指定的数，则返回-1
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = Finder.Find<int>(new int[] { 1, 2, 3, 4, 5, 6, 8, 9 }, 6);	//调用泛型方法，并定义数组指定数字
            Console.WriteLine("6在数组中的位置：" + i.ToString());		//输出中数字在数组中的位置
            Console.ReadLine();
        }
    }

}
