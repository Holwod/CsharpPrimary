using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 63, 4, 24, 1, 3, 15 };//定义一个一维数组，并赋值
            Console.Write("初始数组：");
            foreach (int m in arr)//循环遍历定义的一维数组，并输出其中的元素
                Console.Write(m + " ");
            Console.WriteLine();
            //定义一个int类型的变量，用来存储新的数组元素
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)//根据数组下标的值遍历数组元素
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i]< arr[j])//判断前后两个数的大小
                    {
                        temp = arr[i];//将比较后大的元素赋值给定义的int变量
                        arr[i] = arr[j]; //将后一个元素的值赋值给前一个元素
                        arr[j] = temp;//将int变量中存储的元素值赋值给后一个元素
                    }
                }
            }
            Console.Write("倒序排序后的数组：");
            foreach (int n in arr)//循环遍历排序后的数组元素并输出
                Console.Write(n + " ");
            Console.ReadLine();
        }
    }
}
