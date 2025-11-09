using AbstractGeometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Configuration;

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
				radius = FilterSize(value);
			}
		}
		public Circle
			(
			double radius,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
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
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			//e.Graphics.FillRectangle(brush, StartX, StartY, (float)Radius, (float)Radius);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius, (float)Radius);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Радиус круга: {Radius}");
			base.Info(e);
		}
	}
}