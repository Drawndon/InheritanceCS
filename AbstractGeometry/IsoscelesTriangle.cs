using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle : Triangle
	{
		double trBase; //base - это ключевое слово, означающее базовый класс.
		//Ключевые слова нельзя использовать для именования, но если перед ключевым словом поставить собаку,
		//то его можно использовать для именования своих сущностей, т.е. нельзя base - @base можно
		double trSide;
		public double TrBase
		{
			get => trBase;
			set => trBase = FilterSize(value);
		}
		public double TrSide
		{
			get => trSide;
			set => trSide = FilterSize(value);
		}
		public IsoscelesTriangle
			(
			double trBase, double trSide,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			TrBase = trBase;
			TrSide = trSide;
		}
		public override double GetHeight() => Math.Sqrt(Math.Pow(TrSide, 2) - Math.Pow(trBase / 2, 2));
		public override double GetArea() => TrBase * GetHeight() / 2;
		public override double GetPerimeter() => TrBase + TrSide * 2;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY + (int)TrSide),
				new Point(StartX + (int)TrBase, StartY + (int)TrSide),
				new Point(StartX + (int)TrBase/2, StartY + (int)TrSide - (int)GetHeight())
			};
			e.Graphics.DrawPolygon(pen, points);
		}

		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Основание: {TrBase}");
			Console.WriteLine($"Сторона: {TrSide}");
			base.Info(e);
		}
	}
}
