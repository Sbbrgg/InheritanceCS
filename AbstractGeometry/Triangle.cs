using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal abstract class Triangle : Shape
	{
		protected double sideA;
		protected double sideB;
		protected double sideC;

		public double SideA
		{
			get => sideA;
			set => sideA = FilterSize(value);
		}
		public double SideB
		{
			get => sideB;
			set => sideB = FilterSize(value);
		}
		public double SideC
		{
			get => sideC;
			set => sideC = FilterSize(value);
		}
		public Triangle
			(
				double sideA, double sideB, double sideC,
				int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color )
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}
		public override double GetPerimeter() => sideA + sideB + sideC;
		public override double GetArea()
		{
			double p = GetPerimeter() / 2;
			return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
		}
		public override void Draw(PaintEventArgs e)
		{
			PointF[] points = CalculatePoints();
			Pen pen = new Pen(Color.Aquamarine, lineWidth);
			SolidBrush brush = new SolidBrush(Color.Aquamarine);
			e.Graphics.DrawPolygon(pen, points);
			e.Graphics.FillPolygon(brush, points);
		}
		protected abstract PointF[] CalculatePoints();
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			//Console.WriteLine($"Сторона A: {SideA}");
			//Console.WriteLine($"Сторона B: {SideB}");
			//Console.WriteLine($"Сторона C: {SideC}");
			base.Info(e);
		}
	}
}
