using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices; //DllImport для рисования в консоли
using System.Windows.Forms;
using AbstractBaseClass;

namespace AbstractGeometry
{
	internal class Program
	{
		static readonly string delimeter = "\n---------------------------------------------------------------\n";
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			//e.Graphics.DrawRectangle(new Pen(Color.Red), 300, 300, 500, 300);

			Rectangle rectangle = new Rectangle(100, 40, 500, 500, 16, Color.Blue);
			//rectangle.Info(e);
			rectangle.Draw(e);
			//Для начала нарисуем в Main
			//Console.WriteLine(delimeter);

			Circle circle = new Circle(150, 120, 350, 10, Color.Yellow);
			//circle.Info(e);
			circle.Draw(e);

			//Console.WriteLine(delimeter);

			Square square = new Square(70, 250, 300, 7, Color.Green);
			//square.Info(e);
			square.Draw(e);

			//Console.WriteLine(delimeter);

			IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(70, 50, 450, 350, 8, Color.Coral);
			//isoscelesTriangle.Info(e);
			isoscelesTriangle.Draw(e);

			//Console.WriteLine(delimeter);

			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(70, 350, 350, 5, Color.Cyan);
			//equilateralTriangle.Info(e);
			equilateralTriangle.Draw(e);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
