using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Contact c = new Contact();
			Console.WriteLine(c.age);
			c.A();
			Console.WriteLine(c.age);
			c.B();
			Console.WriteLine(c.age);

            Console.Read(); 
		}
	}
}
