using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Square : Rectangle
	{
		public Square(double side) : base(side, side) { }
		public double Side
		{
			get { return Width; }
			set { }
		}
		public override string Name
		{
			get { return "Квадрат"; }
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Сторона: {Side}\nПлощадь: {Area}\nПериметр: {Perimetr}");
			Console.WriteLine();
		}
	}
}
