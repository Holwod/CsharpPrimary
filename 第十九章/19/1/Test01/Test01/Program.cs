using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    //创建一个泛型接口
    public interface IGenericInterface<T>
    {
        T CreateInstance();								//接口中调用CreateInstance方法
    }
    //实现上面泛型接口的泛型类
    //派生约束where T : TI（T要继承自TI）
    //构造函数约束where T : new()（T可以实例化）
    public class Factory<T, TI> : IGenericInterface<TI> where T : TI, new()
    {
        public TI CreateInstance()							//创建一个公共方法CreateInstance
        {
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //实例化接口
            IGenericInterface<System.ComponentModel.IListSource> factory = new Factory<System.Data.DataTable, System.ComponentModel.IListSource>();
            //输出指定泛型的类型
            Console.WriteLine(factory.CreateInstance().GetType().ToString());
            Console.ReadLine();
        }
    }
}

