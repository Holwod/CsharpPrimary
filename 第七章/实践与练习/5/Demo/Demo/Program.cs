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
            bool finish = false; //游戏是否结束
            int flagNum = 1; // 当前下棋者标记
            char flagch; // 当前下棋者棋子
            int x = 0, y = 0;   //当前棋子的横纵坐标
            /* 棋盘初始化 */
            char[][] checkerboard = new char[10][];
            for (int i = 0; i < checkerboard.Length; i++)
            {
                checkerboard[i] = new char[] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            }
            while (!finish)
            {
                /* 打印棋盘 */
                Console.WriteLine("--------------------------");
                Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
                for (int i = 0; i < checkerboard.Length; i++)
                {
                    Console.Write((char)(i + 'A') + " ");
                    for (int j = 0; j < checkerboard[i].Length; j++)
                    {
                        Console.Write(checkerboard[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------");
                /* 判断当前下棋者 */
                if (flagNum == 1)
                {
                    flagch = '*';
                    Console.WriteLine("请*输入棋子坐标：");
                }
                else
                {
                    flagch = 'o';
                    Console.WriteLine("请o输入棋子坐标：");
                }
                /* 输入棋子坐标 */
                String str = Console.ReadLine();
                char ch = Convert.ToChar(str.Substring(0, 1));// 获取第一个字符的大写形式
                x = ch - 65;
                y = Int32.Parse(str.Substring(1)) - 1;
                /* 判断坐标是否在棋盘之内 */
                if (x < 0 || x > 9 || y < 0 || y > 9)
                {
                    Console.WriteLine("***您输入的坐标有误请重新输入！***");
                    continue;
                }
                /* 判断坐标上是否有棋子 */
                if (checkerboard[x][y] == '-')
                {
                    if (flagNum == 1)
                    {
                        checkerboard[x][y] = '*';
                    }
                    else
                    {
                        checkerboard[x][y] = 'o';
                    }
                }
                else
                {
                    Console.WriteLine("***您输入位置已经有其他棋子，请重新选择！***");
                    continue;
                }
                /* 判断棋子左侧 */
                if (y - 4 >= 0)
                {
                    if (checkerboard[x][y - 1] == flagch
                            && checkerboard[x][y - 2] == flagch
                            && checkerboard[x][y - 3] == flagch
                            && checkerboard[x][y - 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                /* 判断棋子右侧 */
                if (y + 4 <= 9)
                {
                    if (checkerboard[x][y + 1] == flagch
                            && checkerboard[x][y + 2] == flagch
                            && checkerboard[x][y + 3] == flagch
                            && checkerboard[x][y + 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }
                /* 判断棋子上方 */
                if (x - 4 >= 0)
                {
                    if (checkerboard[x - 1][y] == flagch
                            && checkerboard[x - 2][y] == flagch
                            && checkerboard[x - 3][y] == flagch
                            && checkerboard[x - 4][y] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }
                /* 判断棋子下方 */
                if (x + 4 <= 9)
                {
                    if (checkerboard[x + 1][y] == flagch
                            && checkerboard[x + 2][y] == flagch
                            && checkerboard[x + 3][y] == flagch
                            && checkerboard[x + 4][y] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                /* 判断棋子西北 */
                if (x - 4 >= 0 && y - 4 >= 0)
                {
                    if (checkerboard[x - 1][y - 1] == flagch
                            && checkerboard[x - 2][y - 2] == flagch
                            && checkerboard[x - 3][y - 3] == flagch
                            && checkerboard[x - 4][y - 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                /* 判断棋子西南 */
                if (x + 4 <= 9 && y - 4 >= 0)
                {
                    if (checkerboard[x + 1][y - 1] == flagch
                            && checkerboard[x + 2][y - 2] == flagch
                            && checkerboard[x + 3][y - 3] == flagch
                            && checkerboard[x + 4][y - 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                /* 判断棋子东北 */
                if (x - 4 >= 0 && y + 4 <= 9)
                {
                    if (checkerboard[x - 1][y + 1] == flagch
                            && checkerboard[x - 2][y + 2] == flagch
                            && checkerboard[x - 3][y + 3] == flagch
                            && checkerboard[x - 4][y + 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                /* 判断棋子东南 */
                if (x + 4 <= 9 && y + 4 <= 9)
                {
                    if (checkerboard[x + 1][y + 1] == flagch
                            && checkerboard[x + 2][y + 2] == flagch
                            && checkerboard[x + 3][y + 3] == flagch
                            && checkerboard[x + 4][y + 4] == flagch)
                    {
                        finish = true;
                        goto game;
                    }
                }

                flagNum *= -1; // 更换下棋者标记
            }
            game:
            /* 输出最后胜利的棋盘 */
            Console.WriteLine("--------------------------");
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < checkerboard.Length; i++)
            {
                Console.Write((char)(i + 'A') + " ");
                for (int j = 0; j < checkerboard[i].Length; j++)
                {
                    Console.Write(checkerboard[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------");
            /*输出赢家*/
            if (flagNum == 1)
            {
                Console.WriteLine("*棋胜利！");
            }
            else
            {
                Console.WriteLine("o棋胜利！");
            }
            Console.ReadLine();
        }
    }
}
