using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class EquilaternalTriangle : IsoscelesTriangle
	{
		public EquilaternalTriangle(double side) : base(side, side) { }
		public override string Name
		{
			get { return "Равносторонний треугольник"; }
		}
		public double Side
		{
			get { return BaseSide; }
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Сторона: {Side}\nПлощадь: {Area}\nПериметр: {Perimetr}");
			Console.WriteLine();
		}
	}
}
