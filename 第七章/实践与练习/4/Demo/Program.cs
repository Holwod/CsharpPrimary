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
            string[] station = { "西安北", "郑州东", "上海虹桥", "昆明南", "重庆西", "贵阳北", "杭州东", "南京南", "广州南", "重庆北" };
            Console.WriteLine("\n " + station[1] + "-" + station[3] + "-" + station[5] + "-" + station[7] + "-" + station[9]);
            Console.WriteLine("\n " + station[0] + "\n " + station[2] + "\n " + station[4] + "\n " + station[6] + "\n " + station[8]);
            Console.Read();
        }
    }
}
