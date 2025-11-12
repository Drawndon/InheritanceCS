using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal abstract class Triangle:Shape, IHaveHeight
	{
		public abstract double GetHeight();
		public abstract void DrawHeight(PaintEventArgs e);
		public Triangle(int startX, int startY, int lineWidth, Color color)
			:base(startX, startY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника: {GetHeight()}");
			base.Info(e);
		}
	}
}
