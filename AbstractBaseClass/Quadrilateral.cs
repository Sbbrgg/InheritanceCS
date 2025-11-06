using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal abstract class Quadrilateral : Shape
	{
		public double A {  get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public double D { get; set; }

		public Quadrilateral(double a, double b, double c, double d)
		{
			A = a;
			B = b;
			C = c;
			D = d;
		}
		public override double Perimetr
		{
			get { return (A+B+C+D); }
		}
		public abstract override void Draw();
		public abstract override void Info();

	}
}
