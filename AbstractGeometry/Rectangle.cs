using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Rectangle: Shape, IHaveDiagonal
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = FilterSize(value);
		}
		public double Height
		{
			get => height;
			set => height = FilterSize(value);
		}
		public Rectangle
			(
				double width, double height,
				int startX, int startY, int lineWidth, Color color
			): base( startX, startY, lineWidth, color )
		{
			Width = width;
			Height = height;
		}
		public override double GetArea() => width * height;
		public override double GetPerimeter() => 2 * (width + height);
		public double GetDiagonal()
		{
			return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
		}
		public void DrawDiagonal(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color, 1);
			e.Graphics.DrawLine
				(pen,
				StartX, StartY,
				StartX + (int)Width, StartY + (int)Height
				);

		}
		public override void Draw(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color.White);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
			//e.Graphics.FillRectangle(brush, StartX, StartY, (float)Width, (int)Height);
		}
		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Высота: {Height}");
			Console.WriteLine($"Диагональ: {Height}");
			base.Info(e);
			DrawDiagonal(e);
		}
	}
}
