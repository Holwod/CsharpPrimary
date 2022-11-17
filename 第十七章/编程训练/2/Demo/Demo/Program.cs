using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Information
    { 
    public string Code
        { get; set; }
    public string Name
        { get; set; }
        public abstract void ShowInfo();
    }
    public class JHInfo : Information
    {
        public override void ShowInfo()
        {
            Console.WriteLine("进货信息:\n"+Code+" "+Name);
        }
    }
    public class XSInfo : Information
    {
        public override void ShowInfo()
        {
            Console.WriteLine("销售信息：\n"+Code+" "+Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Information info = new JHInfo();
            info.Code = "JH0001";
            info.Name = "笔记本电脑";
            info.ShowInfo();
            info = new XSInfo();
            info.Name = "华为";
            info.Code = "XS0001";
            info.ShowInfo();
                
                }
    }
}
