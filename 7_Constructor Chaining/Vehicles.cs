using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class Vehicle
	{
        //Constructor
		private Vehicle() { }
		public Vehicle(int wheels)
		{
			Console.WriteLine("The number of wheels requested is {0}", wheels);
		}
	}

	public class FourWheeledVehicle : Vehicle
	{

		public FourWheeledVehicle() : base(4) { }
	}

	public class TwoWheeledVehicle : Vehicle
	{
		public TwoWheeledVehicle() : base(2) { }
	}

	public class Car : FourWheeledVehicle { }
	public class Truck : FourWheeledVehicle { }
	public class Motorcycle : TwoWheeledVehicle { }
}
