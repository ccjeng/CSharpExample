using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Contact
	{
        //field
		private string firstName;
		private string lastName;
		private DateTime dateOfBirth;

        //method
		public override string ToString()
        {
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Name: {0} {1}\r\n", this.firstName, this.lastName);
			stringBuilder.AppendFormat("Date of Birth: {0}\r\n", this.dateOfBirth);
			return stringBuilder.ToString();
		}
	}
}
