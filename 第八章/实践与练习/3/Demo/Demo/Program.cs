using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public void ShowInfo(int[] intYear)
        {
            for (int i = 0; i < intYear.Length; i++)
                Console.Write(intYear[i] + "\t");
        }
        public void ShowInfo(string[] strName)
        {
            for (int i = 0; i < strName.Length; i++)
                Console.Write(strName[i] + "\t");
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.ShowInfo(new int[]{1950,1960,1970,1980,1990,2000});
            Console.WriteLine();
            pro.ShowInfo(new string[] {"麦肯","拉塞尔","贾巴尔","魔鸟","乔丹", "邓&鲨&科"});
            Console.ReadLine();
        }
    }
}
