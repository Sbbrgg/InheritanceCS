using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal abstract class Triangle: Shape
	{
		public double A;
		public double B;
		public double C;
		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}
		public override string Name
		{
			get { return "Треугольник"; }
		}
		public override double Perimetr
		{
			get { return A + B + C; }
		}
		public override double Area
		{
			get 
			{ 
				double p = Perimetr / 2; 
				return Math.Sqrt(p * (p - A) * (p-B)*(p-C));
			}
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Сторона1: {A}\nСторона2: {B}\nСторона3 {C}");
			Console.WriteLine($"Площадь: {Area}\nПериметр: {Perimetr}");
			Console.WriteLine();
		}
		public override void Draw()
		{
			Console.WriteLine("Рисование треугольника");
		}
	}
}
