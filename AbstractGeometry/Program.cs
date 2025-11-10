using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;	//DllImport
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			//e.Graphics.DrawRectangle(new Pen(Color.Red), 300, 100, 500, 300);

			Console.Clear();

			int startX = 600; // Общая стартовая позиция X для всех фигур (правая часть)
			int startY = 50;  // Начальная позиция Y
			int verticalSpacing = 100; // Вертикальное расстояние между фигурами

			// Демонстрация всех фигур справа сверху вниз
			Rectangle rectangle = new Rectangle(120, 80, startX, startY, 2, Color.AliceBlue);
			rectangle.Info(e);
			Console.WriteLine(new string('-', 50));

			Square square = new Square(70, startX, startY + verticalSpacing, 2, Color.LightGreen);
			square.Info(e);
			Console.WriteLine(new string('-', 50));

			EquilateralTriangle eqTriangle = new EquilateralTriangle(60, startX, startY + verticalSpacing * 2, 2, Color.LightCoral);
			eqTriangle.Info(e);
			Console.WriteLine(new string('-', 50));

			IsoscelesTriangle isoTriangle = new IsoscelesTriangle(80, 70, startX, startY + verticalSpacing * 3, 2, Color.LightYellow);
			isoTriangle.Info(e);
			Console.WriteLine(new string('-', 50));

			RightTriangle rightTriangle = new RightTriangle(60, 80, startX, startY + verticalSpacing * 4, 2, Color.LightBlue);
			rightTriangle.Info(e);
			Console.WriteLine(new string('-', 50));

			Ellipse ellipse = new Ellipse(100, 70, startX, startY + verticalSpacing * 5, 2, Color.Violet);
			ellipse.Info(e);
			Console.WriteLine(new string('-', 50));

			Circle circle = new Circle(35, startX, startY + verticalSpacing * 6, 2, Color.Orange);
			circle.Info(e);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
