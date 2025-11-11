using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class IsoscalesTriangle : Triangle
	{
		double @base;
		double side;
		public double Base
		{
			get => @base;
			set => @base = FilterSize(value);
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public IsoscalesTriangle
			(
				double @base, double side,
				int startX, int srartY, int lineWidth, Color color
			) : base(startX, srartY, lineWidth, color)
		{
			Base = @base;
			Side = side;
		}
		public override double GetHeight() => Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Base/2,2));
		public override double GetArea() => Base * GetHeight() / 2;
		public override double GetPerimeter() => 2 * Side + Base;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] vertices = new Point[]
			{
				new Point(StartX, StartY+(int)GetHeight()),
				new Point(StartX+(int)Base,StartY+(int)GetHeight()),
				new Point(StartX + (int)Base/2, StartY)
			};
			e.Graphics.DrawPolygon(pen, vertices);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Основние:\t{Base}");
			Console.WriteLine($"Сторона:\t{Side}");
			base.Info(e);
		}
	}
}
