using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle: Shape, IHaveDiametr
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
		}
		public Circle(double radius, int startX, int startY, int lineWidth, Color color): base(startX, startY, lineWidth, color) 
		{
			Radius = radius;
		}
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => Math.PI * 2 * Radius;
		public double GetDiametr()
		{
			return Radius * 2;
		}
		public void DrawDiametr(System.Windows.Forms.PaintEventArgs e)
		{
			
			Pen pen = new Pen(Color, 3);
			e.Graphics.DrawLine
				(
					pen,
					StartX, StartY + (int)Radius,
					StartX+(int)GetDiametr(), StartY + (int)Radius
				);
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last());
			Console.WriteLine($"Радиус:\t{Radius}");
			base.Info(e);
			DrawDiametr(e);
		}
	}
}
