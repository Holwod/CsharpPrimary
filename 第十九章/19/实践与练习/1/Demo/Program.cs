using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	public class Demo<A, B, C>
	{
		A a;
		B b;
		C c;
		public Demo(A a, B b, C c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}

		public new string ToString()
		{
			return "Demo [a=" + a + ", b=" + b + ", c=" + c + "]";
		}
	}
	class Program
    {
        static void Main(string[] args)
        {
			Demo<int, int, int> date = new Demo<int, int, int>(2008, 8, 8);
			Console.WriteLine(date.ToString());
			Demo<string, int, char> tom = new Demo<string, int, char>("汤姆", 175, '男');
			Console.WriteLine(tom.ToString());
			Console.ReadLine();
		}
    }
}
