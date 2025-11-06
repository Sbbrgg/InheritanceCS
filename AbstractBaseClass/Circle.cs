using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Circle : Ellipse
	{
		public double Radius
		{
			get { return RadiusX; }
		}
		public Circle(double radius) : base(radius, radius) { }
		public override string Name
		{
			get { return "Круг"; }
		}
		public override double Perimetr
		{
			get { return Math.PI * 2 * Radius; }
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Радиус: {Radius}\nПлощадь: {Area}\nПериметр: {Perimetr}");
			Console.WriteLine();
		}
	}
}
