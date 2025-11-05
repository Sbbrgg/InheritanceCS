using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{
		public string LastName {  get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }

		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor:{GetHashCode()}");
		}
		public Human(Human other)
		{
			this.LastName = other.LastName;
			this.FirstName = other.FirstName;
			this.Age = other.Age;
			Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor:{GetHashCode()}");
		}

		public virtual void Info()
		{
			Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
		public override string ToString()
		{
			return 
				//Split('.') разделяет 'Academy.Type' по точке на массив строк,
				//и из этого мы берём последний элемент.
				$"{base.ToString().Split('.').Last()}:".PadRight(12) +
				$"{LastName.PadRight(16, '.')}{FirstName.PadRight(10)}{Age.ToString().PadRight(5)}";
			//PadRight() выравнивает строку по левому борту. От Padding - выравнивание/набивка.
			//"Набивает справа от нашего значения"
		}
		public virtual string ToFileString()
		{
			return $"{LastName};{FirstName};{Age}";
		}
	}
}
