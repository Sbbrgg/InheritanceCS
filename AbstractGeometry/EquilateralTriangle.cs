using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class EquilateralTriangle : Triangle
	{
		public double Side
		{
			get => SideA;
			set => SideA = SideB = SideC = value;
		}
		public EquilateralTriangle
			(
				double side, int startX, int startY, int lineWidth, Color color
			): base(side, side, side, startX, startY, lineWidth, color) { }
		protected override PointF[] CalculatePoints()
		{
			float height = (float)(Side * Math.Sqrt(3) / 2);
			return new PointF[]
			{
				new PointF(StartX, StartY + height),
				new PointF(StartX + (float)SideB/2, StartY),
				new PointF(StartX + (float)Side, StartY + height)
			};
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last());
			Console.WriteLine($"Сторона: {Side}");
			base.Info(e);
		}
	}
}
