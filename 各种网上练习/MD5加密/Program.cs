using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{

    

     class Program
    {
        static void Main(string[] args)
        {
            //模拟MD5加密 不可逆
            //123    MD5为
            //202cb962ac59075b964b07152d234b70      十六进制
            // 3244185981728979115075721453575112  十进制
            string s = GetMD5("123");
            Console.WriteLine(s);

        }
       
        
        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] buffer1 = md5.ComputeHash(buffer);
            //将字节数组转换为字符串
            //字节数组转字符串
            string strNew = " ";
            for (int i = 0; i < buffer1.Length; i++)
            {
                strNew += buffer1[i].ToString("x");  //x将10进制转换为16进制  ToString()方法
            }
            return strNew;
        }
    }
}
