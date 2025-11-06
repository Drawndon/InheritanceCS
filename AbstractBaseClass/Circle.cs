using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Circle : Shape
	{
		double radius;
		public double Radius
		{
			get
			{
				return radius;
			}
			set
			{
				radius = SizeFilter(value);
			}
		}
		public Circle
			(
			double radius,
			int startX, int startY, int lineWidth
			) : base(startX, startY, lineWidth)
		{
			Radius = radius;
		}
		public override double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
		public override double GetPerimeter()
		{
			return 2 * Math.PI * Radius;
		}
		public override void Draw()
		{

		}
		public override void Info()
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Радиус круга: {Radius}");
			base.Info();
		}
	}
}
