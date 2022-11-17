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
            int[] cardsnumber = new int[52]; // 一副牌，用一副52张的牌，随机选择四张，牌用0到51表示
            for (int i = 0; i < cardsnumber.Length; i++)
            {
                cardsnumber[i] = i; // 建立一个数组，进行赋值
            }
            string[] colors = { "方片", "红桃", "黑桃", "梅花" }; // 牌的花色
            string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };// 数字牌
            // 随机打乱牌
            for (int i = 0; i < cardsnumber.Length; i++)
            {
                int random = new Random(Guid.NewGuid().GetHashCode()).Next(0,cardsnumber.Length);
                int temp = cardsnumber[i];
                cardsnumber[i] = cardsnumber[random];
                cardsnumber[random] = temp;
            }
            for (int i = 0; i < 4; i++)
            {
                int num = cardsnumber[i] / 13; // 得到花色
                int number = cardsnumber[i] % 13; // 得到数字牌
                Console.WriteLine("第" + (i + 1) + "张牌：" + colors[num] + "   " + cards[number]); // 输出牌的花色和大小
            }
            Console.ReadLine();
        }
    }
}
