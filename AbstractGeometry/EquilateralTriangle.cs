using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class EquilateralTriangle: IsoscalesTriangle
	{

		public EquilateralTriangle(double side, int startX, int startY, int lineWidth, Color color):
			base(side, side, startX, startY, lineWidth, color)
		{ }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last());
			Console.WriteLine($"Сторона: {Base}");
			Console.WriteLine($"Высота: {GetHeight():F2}");
			base.Info(e);
		}
	}
}
