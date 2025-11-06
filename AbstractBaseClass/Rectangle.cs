using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Rectangle : Quadrilateral
	{
		public Rectangle(double width, double height) : base(width, height, width, height) { }
		public double Width
		{
			get { return A; }
		}
		public double Height
		{
			get { return B; }
		}
		public override string Name
		{
			get { return "Прямоугольник"; }
		}
		public override double Area
		{
			get { return A*B; }
		}
		public override void Draw()
		{
			Console.WriteLine($"Рисунок {Name}а");
			for(int i = 0;i < Height; i++)
			{
				for(int j = 0; j < Width; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public override void Info()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"Длина: {Width}\nШирина: {Height}");
			Console.WriteLine($"Периметр: {Perimetr}\nПлощадь: {Area}");
			Console.WriteLine();
		}
	}
}
