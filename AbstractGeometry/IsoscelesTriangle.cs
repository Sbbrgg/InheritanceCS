using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle : Triangle
	{
		public double Base
		{
			get => SideA;
			set => SideA = value;
		}
		public double EqualSide
		{
			get => SideB;
			set => SideB = SideC = value;
		}
		public IsoscelesTriangle
			(
				double baseSide, double equalSide,
				int startX, int startY, int lineWidth, Color color
			) : base(baseSide, equalSide, equalSide, startX, startY, lineWidth, color) { }
		protected override PointF[] CalculatePoints()
		{
			float height = (float)Math.Sqrt(EqualSide * EqualSide - (Base * Base) / 4);
			return new PointF[]
				{
					new PointF(StartX, StartY + height),
					new PointF(StartX + (float)Base/2, StartY),
					new PointF(StartX + (float)Base, StartY + height),
				};
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Основание: {Base}");
			Console.WriteLine($"Боковая сторона: {EqualSide}");
			base.Info(e);
		}
	}
}
