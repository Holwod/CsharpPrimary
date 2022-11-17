using System;
using System.Collections;
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
            ArrayList P_list_StudentInfo = new ArrayList(); //实例化集合对象
            //向集合中添加学生信息
            P_list_StudentInfo.Add("小王 男 1980-01-01");
            P_list_StudentInfo.Add("小刘 女 1981-01-01");
            P_list_StudentInfo.Add("小明 男 1990-01-01");
            foreach (string Pc_str_Student in P_list_StudentInfo)//遍历集合
            {
                Console.WriteLine(Pc_str_Student);
            }
            Console.ReadLine();
        }
    }
}
