﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public abstract class Vehicle    //abstract class
	{
		private Vehicle() { }
		public Vehicle(int wheels)
		{
			Console.WriteLine("The number of wheels requested is {0}", wheels);
		}

		public abstract void Operate();
	}

	public class FourWheeledVehicle : Vehicle
	{

		public FourWheeledVehicle() : base(4) { }

		public override void Operate()
		{
			Console.WriteLine("Driving a four-wheeled vehicle");
		}
	}

	public class TwoWheeledVehicle : Vehicle
	{
		public TwoWheeledVehicle() : base(2) { }

		public override void Operate()
		{
			Console.WriteLine("Riding a two-wheeled vehicle");
		}
	}

	public class Car : FourWheeledVehicle 
	{
		public override void Operate()
		{
			Console.WriteLine("Driving a car");
		}
	}
	
	public class Truck : FourWheeledVehicle { }
	public class Motorcycle : TwoWheeledVehicle { }
}
