using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public abstract class Tree
    {
        public abstract string PlantTree();
        public abstract int Energy();
    }

    public class SuosuoTree : Tree
    {
        //种植梭梭树需要的能量
        public override int Energy()
        {
            return 17900;
        }
        public override string PlantTree()
        {
            return "梭梭树";
        }
    }

    public class HuaBang : Tree
    {
        //种植花棒需要的能量
        public override int Energy()
        {
            return 21310;
        }
        public override string PlantTree()
        {
            return "花棒";
        }
    }

    public class HuYang : Tree
    {
        //种植胡杨需要的能量
        public override int Energy()
        {
            return 215680;
        }
        public override string PlantTree()
        {
            return "胡杨";
        }
    }
    public class People
    {
        //姓名
        public string Name { get; set; }

        //能量
        public int Energy { get; set; }

        public void Plant<T>(T tree) where T : Tree
        {
            if (Energy < tree.Energy())
            {
                Console.WriteLine("种植 "+ tree.PlantTree() + " 能量不足");
            }
            else
            {
                Energy = Energy - tree.Energy();
                Console.WriteLine("恭喜" + Name + "," + tree.PlantTree() + "种植成功,获得成就!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People people = new People
            {
                Name = "王子",
                Energy = 300000
            };
            people.Plant(new SuosuoTree());
            people.Plant(new HuaBang());
            people.Plant(new HuYang());
            Console.WriteLine("剩余能量：" + people.Energy);
            people.Plant(new HuYang());
            Console.Read();
        }
    }
}
