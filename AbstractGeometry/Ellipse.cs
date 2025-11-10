using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Ellipse : Shape
	{
		private double width;
		private double height;

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
		public Ellipse
			(
				double width, double height,
				int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}

		public override double GetArea() => Math.PI * (width / 2) * (height / 2);
		public override double GetPerimeter()
		{
			double a = Math.Max(width, height) / 2;
			double b = Math.Min(width, height) / 2;
			double h = Math.Pow((a - b) / (a + b), 2);
			return Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Yellow, lineWidth);
			SolidBrush brush = new SolidBrush(Color.Yellow);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Width, (float)Height);
			e.Graphics.FillEllipse(brush, StartX, StartY, (float)Width, (float)Height);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			//Console.WriteLine($"Ширина: {Width}");
			//Console.WriteLine($"Высота: {Height}");
			base.Info(e);
		}
	}
}
