using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal abstract class Shape
	{
		protected readonly int MIN_START_X = 0;
		protected readonly int MIN_START_Y = 0;
		protected readonly int MAX_START_X = 1000;
		protected readonly int MAX_START_Y = 800;
		protected readonly int MIN_LINE_WIDTH = 1;
		protected readonly int MAX_LINE_WIDTH = 32;
		protected readonly int MIN_SIZE = 32;
		protected readonly int MAX_SIZE = 800;
		int startX;
		int startY;
		int lineWidth;
		public int StartX
		{
			get { return startX; }
			set
			{
				startX =
					value < MIN_START_X ? MIN_START_X:
					value > MAX_START_X ? MAX_START_X:
					value;
			}
		}
		public int StartY
		{
			get { return startY; }
			set
			{
				startY =
				value < MIN_START_Y ? MIN_START_Y :
				value > MAX_START_Y ? MAX_START_Y :
				value;
			}
		}
		public int LineWidth
		{
			get { return lineWidth; }
			set
			{
				lineWidth = value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
					value > MAX_LINE_WIDTH ? MAX_LINE_WIDTH :
					value;
			}
		}
		public double SizeFilter(double size)
		{
			size = size < MIN_SIZE ? MIN_SIZE:
				size > MAX_SIZE ? MAX_SIZE:
				size;
			return size;
		}
		public Shape(int startX, int startY, int lineWidth)
		{
			StartX = startX;
			StartY = startY;
			LineWidth = lineWidth;
		}
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw();
		public virtual void Info()
		{
			Console.WriteLine($"Площадь фигуры: {GetArea()}");
			Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
			Draw();
		}


	}
}
