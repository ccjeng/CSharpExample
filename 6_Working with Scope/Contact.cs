using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Contact
	{
		public int age;

		public void A()
		{
			age = 18;
		}
		public void B()
		{
			int age;
			age = 21;
			Console.WriteLine("B: " + age);
		}
	}
}
