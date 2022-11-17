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
            ArrayList P_list_StudentInfo = new ArrayList();//创建集合对象
            //向集合中添加学生信息
            P_list_StudentInfo.Add("小王  男   1990-01-01");
            P_list_StudentInfo.Add("小刘  女   1991-01-01");
            P_list_StudentInfo.Add("王子  男   1993-01-01");
            P_list_StudentInfo.Add("亮仔  男   1995-01-01");
            P_list_StudentInfo.Add("学霸  男   2000-01-01");
            Console.WriteLine("学生详细信息如下：\n");
            Console.WriteLine("姓名  性别  出生日期");
            foreach (string Pc_str_Student in P_list_StudentInfo)//遍历集合
            {
                Console.WriteLine(Pc_str_Student);//显示所有学生信息
            }
            Console.ReadLine();
        }
    }
}
