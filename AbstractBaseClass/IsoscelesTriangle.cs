using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class IsoscelesTriangle : Triangle
	{
		public IsoscelesTriangle(double baseSide, double equalSide) : base(baseSide, equalSide, equalSide) { }
		public override string Name
		{
			get { return "Равнобедренный треугольник"; }
		}
		public double BaseSide
		{
			get { return A; }
		}
		public double EqualSide
		{
			get { return B; }
		}
		public override void Draw()
		{
			Console.WriteLine("Рисунок треугольника");
			int height = Convert.ToInt32(EqualSide);
			for(int i = 0; i < height; i++)
			{
				for (int j = 0; j < height - i - 1; j++)
					Console.Write(" ");
				for (int j = 0; j < 2 * i + 1; j++)
					Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
