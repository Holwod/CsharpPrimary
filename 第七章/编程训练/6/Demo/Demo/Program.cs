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
            Console.WriteLine("有意思的名字：");//提示信息
            //定义数组，存储有意思的名字
            string[] names = { "王者荣耀", "黄埔军校", "高富帅", "白富美", "徐栩如生" };
            foreach (string name in names)//遍历数组
            {
                Console.WriteLine(name + "  ");//输出遍历到的元素
            }
            Console.ReadLine();
        }
    }
}
