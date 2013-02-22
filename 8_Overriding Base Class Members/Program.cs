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
			Car c = new Car();
			c.Operate();
			Console.WriteLine();

			Motorcycle m = new Motorcycle();
			m.Operate();
			Console.WriteLine();

			Truck t = new Truck();
			t.Operate();
			Console.WriteLine();

			Vehicle v = new Vehicle(3);
			v.Operate();


            Console.Read();
		}
	}
}
