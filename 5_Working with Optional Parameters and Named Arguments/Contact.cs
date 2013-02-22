using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Contact
	{
		private DateTime dateOfBirth;

		public DateTime DateOfBirth
		{
			get 
			{
				return this.dateOfBirth; 
			}

			set
			{
				this.dateOfBirth = value;
			}
		}

		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public string FullName
		{
			get
			{
				return this.FirstName + " " + this.LastName;
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Name: {0}\r\n", this.FullName);
			stringBuilder.AppendFormat("Date of Birth: {0}\r\n", this.dateOfBirth);
			return stringBuilder.ToString();
		}

		public bool VerifyEmailAddress(string emailAddress)
		{
			return emailAddress == "joe@example.com";
		}

        //Optional Parameters
        public void Search(float latitude/*required*/, float longitude/*required*/, int distance = 10/*optional*/, string culture = "en-US"/*optional*/)
		{
			Console.WriteLine("latitude {0}, longitude {1}, distance {2}, culture {3}", latitude, longitude, distance, culture);
		}
	}
}
