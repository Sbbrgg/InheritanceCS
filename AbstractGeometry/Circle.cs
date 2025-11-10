using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Ellipse
	{
		public double Radius
		{
			get => Width / 2;
			set
			{
				Width = value * 2;
				Height = value * 2;
			}
		}
		public Circle
			(
				double radius,
				int startX, int StartY, int lineWidth, Color color
			) : base(radius * 2, radius * 2, startX, StartY, lineWidth, color) { }
		public override double GetArea() => Math.PI * Radius * Radius;
		public override double GetPerimeter() => Math.PI * Radius * 2;
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Радиус: {Radius}");
			base.Info(e);
		}
	}
}
