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
            string[] poem = { "《大风歌》", "大风起兮云飞扬，", "威加海内兮归故乡。", "安得猛士兮守四方。" };
            string[] spell = { "《dà fēng gē 》", "dà fēng qǐ xī yún fēi yáng ，", "wēi jiā hǎi nèi xī guī gù xiāng，", "ān dé měng shì xī shǒu sì fāng 。" };
            Console.WriteLine(poem[0].PadLeft(8));
            Console.WriteLine(poem[1]);
            Console.WriteLine(poem[2]);
            Console.WriteLine(poem[3]);
            Console.WriteLine();

            Console.WriteLine(spell[0].PadLeft(18));
            Console.WriteLine(spell[1]);
            Console.WriteLine(spell[2]);
            Console.WriteLine(spell[3]);
            Console.WriteLine();

            Console.WriteLine(spell[0].PadLeft(18));
            Console.WriteLine(poem[0].PadLeft(12));
            Console.WriteLine(spell[1]);
            Console.WriteLine(poem[1].PadLeft(12));
            Console.WriteLine(spell[2]);
            Console.WriteLine(poem[2].PadLeft(12));
            Console.WriteLine(spell[3]);
            Console.WriteLine(poem[3].PadLeft(12));
            Console.Read();
        }
    }
}
