using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Market
    { 
    public string Name
            { get; set; }
    public string Goods
            { get; set; }
        public abstract void Shop();
    }
    public class WallMarket : Market
    {
        public override void Shop()
        {
            Console.WriteLine(Name+"购买"+ Goods);
        }
    }
    public class TaoBaoMarket : Market
    {
        public override void Shop()
        {
            Console.WriteLine(Name+"购买"+Goods);
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
          TaoBaoMarket taoBaoMarket = new TaoBaoMarket();
            taoBaoMarket.Name =  "淘宝";
            taoBaoMarket.Goods = "比基尼";
            taoBaoMarket.Shop();
            WallMarket wallMarket = new WallMarket();
            wallMarket.Name = "沃尔玛";
            wallMarket.Goods = "冲浪板";
            wallMarket.Shop();
        }
    }
}
