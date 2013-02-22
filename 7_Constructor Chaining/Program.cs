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
			Motorcycle m = new Motorcycle();
			Truck t = new Truck();

			Vehicle v = new Vehicle(3);

            Console.Read();
		}
	}
}
