using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher: Human
	{
		public string Speciality { get; set; }
		public int Expirience { get; set; }
		public Teacher
			(
				string lastName, string firstName, int age,
				string specility, int experience
			): base(lastName, firstName, age)
		{
			Speciality = specility;
			Expirience = experience;
			Console.WriteLine($"TConstructor:\t{GetHashCode()}");
		}
		public Teacher
			(
				Human human, string specility, int experience) : base(human)
		{
			Speciality = specility;
			Expirience = experience;
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor:\t{GetHashCode()}");
		}

		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Expirience}");
		}
		public override string ToString()
		{
			return base.ToString() +
			$"{Speciality.ToString().PadRight(24)}{Expirience.ToString().PadRight(8)}";
		}
		public override string ToStringCSV()
		{
			return base.ToStringCSV() + ","
				+$"{Speciality},{Expirience}";
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4];
			Expirience = Convert.ToInt32(values[5]);
			return this;
		}
	}
}
