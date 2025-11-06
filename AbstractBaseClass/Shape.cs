using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal abstract class Shape
	{
		public abstract string Name { get; }
		public abstract double Area { get; }
		public abstract double Perimetr { get; }

		public abstract void Draw();
		public abstract void Info();
	}
}
