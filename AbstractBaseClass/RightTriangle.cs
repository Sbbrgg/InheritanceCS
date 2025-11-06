using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class RightTriangle: Triangle
	{
		public RightTriangle(double a, double b) : base(a, b, Math.Sqrt((a * a) + (b * b))) { }
		public override string Name
		{
			get
			{
				{ return "Прямоугольный треугольник"; }
			}
		}
		public double CathetusA { get { return A; } }
		public double CathetusB { get { return B; } }
		public double Hypotenuse {  get { return C; }}
		public override void Draw()
		{
			Console.WriteLine("Рисунок прямоугольного треугольника");
			int height = Convert.ToInt32(CathetusB);
			for(int i = 0; i < height; i++)
			{
				for(int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
