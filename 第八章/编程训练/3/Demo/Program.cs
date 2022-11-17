using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public int Mult(int x, int y)//定义方法Mult，返回值为int类型，有两个int类型的参数
        {
            return x + y;
        }
        public double Mult(int x, double y)//重新方法Mult，它与第一个的参数类型不同
        {
            return x * y;
        }
        public double Mult(double x, int y, int z)//重新方法Mult，它与第一个的参数个数不同
        {
            return x * y * z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();        //创建类对象
            int x = 3, y = 5, z = 7;
            double x2 = 8.2, y2 = 5.5;
            //根据传入的参数类型及参数个数的不同调用不同的Mult重载方法
            Console.WriteLine(x + "×" + y + "=" + program.Mult(x, y));
            Console.WriteLine(x + "×" + y2 + "=" + program.Mult(x, y2));
            Console.WriteLine(x2 + "×" + y + "×" + z + "=" + program.Mult(x2, y, z));
            Console.ReadLine();
        }
    }
}
