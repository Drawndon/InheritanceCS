using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal abstract class Triangle:Shape
	{
		public abstract double GetHeight();
		public Triangle(int startX, int startY, int lineWidth):
			base(startX, startY, lineWidth) { }
		public override void Info()
		{
			Console.WriteLine($"Высота треугольника: {GetHeight()}");
			base.Info();
		}
	}
}
