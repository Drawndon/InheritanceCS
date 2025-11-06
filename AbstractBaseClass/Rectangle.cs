using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Rectangle:Shape
	{
		double width;
		double height;
		public double Width
		{
			get
			{
				return width;
			}
			set
			{
				width = SizeFilter(value);
			}
		}
		public double Height
		{
			get
			{
				return height;
			}
			set
			{
				height = SizeFilter(value);
			}
		}
		public Rectangle(double width, double height, int startX, int startY, int lineWidth):
			base(startX, startY, lineWidth)
		{
			Width = width;
			Height = height;
		}
		public override double GetArea()
		{
			return Width * Height;
		}
		public override double GetPerimeter()
		{
			return 2 * (Width + Height);
		}
		public override void Draw()
		{
			
		}
		public override void Info()
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Ширина прямоугольника: {Width}");
			Console.WriteLine($"Высота прямоугольника: {Height}");
			base.Info();
		}

	}
}
