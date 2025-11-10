using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class RightTriangle : Triangle
	{
		public double CathetusA
		{
			get => SideA;
			set => SideA = value;
		}
		public double CathetusB
		{
			get => SideB;
			set => SideB = value;
		}
		public double CathetusC
		{
			get => SideC;
			set => SideC = value;
		}
		public RightTriangle
			(
				double cathetusA, double cathetusB,
				int startX, int startY, int lineWidth, Color color
			) : 
			base(
				cathetusA, cathetusB, 
				Math.Sqrt(cathetusA * cathetusA + cathetusB*cathetusB),
				startX, startY, lineWidth, color
				) { }
		protected override PointF[] CalculatePoints()
		{
			return new PointF[]
			{
				new PointF(StartX, StartY),
				new PointF(StartX, StartY + (float)CathetusB),
				new PointF(StartX + (float)CathetusA, StartY + (float)CathetusB)
			};
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last().Last());
			base.Info(e);
		}
	}
}
