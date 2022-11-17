using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Computer
    { // 创建一个Computer类
        public void powerUp()
        { // 创建一个普通的方法powerUp()
            Console.WriteLine("电脑正常开机启动"); // 控制台输出
        }
    }

    class NewComputer : Computer
    { // 创建一个NewComputer类继承Computer类

        private string brand; // 定义“电脑品牌”
        public void PowerUp()
        {// 重写父类Computer中的powerUp()方法
            Console.WriteLine("刚买回来的新电脑不能正常开机启动\n新电脑的品牌是：" + brand); // 控制台输出
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("模拟场景：用户新买了台电脑，这台电脑与其他的电脑不一样，无法正常启动开机 \n 经检测，是由于电脑的品牌不确定造成的……\n");
            try
            { // try块
                NewComputer newComputer = new NewComputer(); // 创建对象newComputer
                newComputer.PowerUp(); // 对象newComputer调用powerUp()方法
            }
            catch (NullReferenceException ex)
            { // catch块
                Console.WriteLine("引起空指针异常：" + ex.Message); // 控制台输出
            }
            finally
            { // finally块
                Console.WriteLine("异常出现的原因：\n新机器newComputer对象中的品牌（brand）为null"); // 控制台输出
            }
            Console.ReadLine();
        }
    }
}
