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

        //automatic property
		public string FirstName
		{
			get;
			set;
		}
        
        /* 
          	private string firstName;   //field
	        public string FirstName     //property
	        {
		        get
		        {
			        return this.firstName;
		        }
		        set
		        {
			        this.firstName = value;
		        }
	        }
        */
        public string LastName
		{
			get;
			set;
		}

        public string FullName   //cacluated property
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
	}
}
