﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	interface IVehicle
	{
		void Operate();
	}

	interface IEmergencyVehicle : IVehicle
	{
		void SoundSiren();
	}
}
