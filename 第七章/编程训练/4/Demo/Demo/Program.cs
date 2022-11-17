using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo高配
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] info = { // 声明String类型的二维数组，模拟购物车中的“商品名称”、“数量”和“价格”
				{ "C#项目开发实战入门", "1", "68.8" }, { "零基础学C#", "\t2", "59.8" }, { "小米6高配版", "\t1", "2899" } };
            float sum = 0; // 声明float类型的变量sum（购买商品的总价格）
            Console.WriteLine("购物车明细如下：\n\n商品名称" + "\t\t" + "数量" + "\t" + "价格"); // 控制台输出相应的信息（\t：光标移动到下一水平列表）
            for (int i = 0; i < info.GetLength(0); i++) // 遍历数组
            {
                for (int j = 0; j < info.GetLength(1); j++)
                {
                    Console.Write(info[i, j] + "\t"); // 输出数组中的元素
                    if (j == 1) // 判断info第二列的下标是否为1
                    {
                        int a = Convert.ToInt32(info[i, j]); // 将String类型的数量转换为int
                        float b = Convert.ToSingle(info[i, j + 1]); // 将String类型的数量转换为float
                        sum += (float)a * b; // 累计求和（sum = 商品数量 * 商品价格 + ... + 商品数量  * 商品价格）
                    }
                }
                Console.WriteLine(); // 换行输出每一种商品的“商品名称”、“数量”和“价格”
            }
            Console.WriteLine("您的应付款总额为：" + sum + "元"); // 输出sum
            Console.ReadLine();
        }
    }
}
