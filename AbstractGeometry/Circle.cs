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
	internal class Circle : Shape, IHaveDiameter
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
		}
		public Circle
			(
			double radius,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		//public double GetRadius() => radius;
		public double GetDiameter() => 2 * radius;// GetRadius();
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

		public override double GetPerimeter() => 2 * Math.PI * Radius;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.FillEllipse(brush, StartX, StartY, (float)(2*Radius), (float)(2*Radius));
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Радиус круга: {Radius}");
			base.Info(e);
			Draw(e);
		}
	}
}