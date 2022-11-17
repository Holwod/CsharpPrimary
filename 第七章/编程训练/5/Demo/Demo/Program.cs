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
            int[,] arr = new int[3,3]; // 声明int类型的数组并分配内存（三阶方阵）
            // 确定数字“1”的位置
            int a = 2; // 第3行的下标
            int b = 3 / 2; // 第2列的下标
            for (int i = 1; i <= 9; i++) // 给数组赋值
            {
                arr[a++,b++] = i; // 避免数组下标越界
                if (i % 3 == 0) // 如果i是3的倍数
                {
                    a = a - 2;
                    b = b - 1;
                } else // 如果i不是3的倍数
                {
                    a = a % 3;
                    b = b % 3;
                }

            }
            Console.WriteLine("九宫格：");
            for (int i = 0; i < 3; i++) // 遍历数组
            {
                for (int j = 0; j < 3; j++) {
                    Console.Write(arr[i,j] + " "); // 输出数组中的数据
                }
                Console.WriteLine(); // 换行
            }
            Console.ReadLine();
        }
    }
}
