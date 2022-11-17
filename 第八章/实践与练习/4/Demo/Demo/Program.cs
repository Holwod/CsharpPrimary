using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        void discount(double money)
        {
            switch ((int)(money / 500))
            {
                case 0:
                    Console.WriteLine("你的消费没有折扣：金额是" + money);
                    break;
                case 1:
                    Console.WriteLine("你的消费享受9折优惠：金额是" + money + ",折后金额是" + money * 0.9);
                    break;
                case 2:
                case 3:
                    Console.WriteLine("你的消费享受8折优惠：金额是" + money + ",折后金额是" + money * 0.8);
                    break;
                case 4:
                case 5:
                    Console.WriteLine("你的消费享受7折优惠：金额是" + money + ",折后金额是" + money * 0.7);
                    break;
                default:
                    Console.WriteLine("你的消费享受6折优惠：金额是" + money + ",折后金额是" + money * 0.6);
                    break;
            }
        }
        static void Main(string[] args)
        {
            /*输出促销信息*/
            Console.WriteLine("****满500元可享受9折优惠****");
            Console.WriteLine("****满1000元可享受8折优惠****");
            Console.WriteLine("****满2000元可享受7折优惠****");
            Console.WriteLine("****满3000元可享受6折优惠****");
            Program p = new Program();
            /*输入消费金额*/
            Console.Write("\n请输入消费金额:");
            double money = Convert.ToDouble(Console.ReadLine());
            p.discount(money);
            Console.ReadLine();
        }
    }
}
