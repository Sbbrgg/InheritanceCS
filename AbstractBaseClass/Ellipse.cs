using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Ellipse : Shape
	{
		public double RadiusX {  get; set; }
		public double RadiusY { get; set; }
		public Ellipse(double radiusX, double radiusY)
		{
			RadiusX = radiusX;
			RadiusY = radiusY;
		}
		public override string Name
		{
			get { return "Эллипс"; }
		}
		public override double Area
		{
			get { return Math.PI * RadiusX * RadiusY; }
		}
		public override double Perimetr
		{
			get { return Math.PI * (3 * (RadiusX + RadiusY) - Math.Sqrt((3 * RadiusX + RadiusY) * (RadiusX + 3 * RadiusY))); }
		}
		public override void Draw()
		{
			Console.WriteLine("Рисунок эллипса");
			Console.WriteLine();
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Радиус X: {RadiusX}\nРадиус Y: {RadiusY}\nПлощадь: {Area}\nПериметр: {Perimetr}");
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
