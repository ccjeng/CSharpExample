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
			Car car = new Car();
			car.Operate();

			car = new PoliceCar();
			car.Operate();

			PoliceCar policeCar = (PoliceCar)car;
			policeCar.SoundSiren();

            Console.Read(); 
		}
	}
}
