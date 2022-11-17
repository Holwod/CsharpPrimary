using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Program
    {
        public class BankList<T>
        {
            public T bankName; //银行名称
            public T time; //存款时间
            public T username; //户名
            public T cardNum; //卡号
            public T currency; //币种
            public T inAccount; //存款金额
            public T leftAccount; //账户余额
        }
        static void Main(string[] args)
        {
            BankList<Object> list = new BankList<Object>(); //创建一个String类型的BankList对象
            list.bankName = "中国建设银行"; //初始化“银行名称”
            list.time = DateTime.Now.ToLongDateString(); //初始化“存款时间”
            list.username = "赵四"; //初始化“户名”
            list.cardNum = "6666 7777 8888 9996 789"; //初始化“卡号”
            list.currency = "RMB"; //初始化“币种”
            list.inAccount = 8888.00; //初始化“存款金额”
            list.leftAccount = 18888.89; //初始化“账户余额”
            Console.WriteLine(
                                  "银行名称：" + list.bankName
                                + "\n存款时间：" + list.time
                                + "\n户　　名：" + list.username
                                + "\n卡　　号：" + list.cardNum
                                + "\n币　　种：" + list.currency
                                + "\n存款金额：" + list.inAccount
                                + "\n账户余额：" + list.leftAccount
                                ); //输出上述信息
            Console.Read();
        }
    }
}
