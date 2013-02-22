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
			Console.WriteLine(c.ToString());

			c.FirstName = "Jim";
			c.LastName = "Morrison";
			c.DateOfBirth = new DateTime(1943, 12, 8);
			Console.WriteLine(c.ToString());

			c.Search(37.479444f, -122.450278f);
			c.Search(37.479444f, -122.450278f, 50);
			c.Search(37.479444f, -122.450278f, 50, "en");

			Console.WriteLine(c.VerifyEmailAddress("joe@example.com"));
			Console.WriteLine(c.VerifyEmailAddress("jim@example.com"));

            //Named Arguments
			c.Search(latitude: 27.966667f, longitude: 82.533333f, distance: 3);
			c.Search(latitude: 27.966667f, longitude: 82.533333f, distance: 3, culture: "en-GB");
			c.Search(latitude: 27.966667f, longitude: 82.533333f);
			c.Search(27.966667f, 82.533333f, culture: "en-GB");
			c.Search(latitude: 27.966667f, longitude: 82.533333f, culture: "en-GB");

            Console.Read();
		}
	}
}
