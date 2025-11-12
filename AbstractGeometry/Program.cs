//#define ABSTRACT_1
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

#if ABSTRACT_1
			Rectangle rectangle = new Rectangle(100, 40, 300, 250, 3, Color.Blue);
			//rectangle.Info(e);
			rectangle.Draw(e);
			//Для начала нарисуем в Main
			//Console.WriteLine(delimeter);

			Circle circle = new Circle(100, 700, 150, 5, Color.Yellow);
			//circle.Info(e);
			circle.Draw(e);

			//Console.WriteLine(delimeter);

			Square square = new Square(70, 250, 300, 7, Color.Green);
			//square.Info(e);
			square.Draw(e);

			//Console.WriteLine(delimeter);

			IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(75, 150, 400, 200, 3, Color.Coral);
			//isoscelesTriangle.Info(e);
			isoscelesTriangle.Draw(e);

			//Console.WriteLine(delimeter);

			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(50, 550, 200, 4, Color.Cyan);
			//equilateralTriangle.Info(e);
			equilateralTriangle.Draw(e);
			//Например интерфейсы
			//ICloneable, IServiceProvider  
#endif
			Shape[] shapes =
			{
				 new Rectangle(100, 40, 300, 250, 3, Color.Blue),
				 new Square(70, 250, 300, 7, Color.Green),
				 new Circle(100, 700, 150, 5, Color.Yellow),
				 new IsoscelesTriangle(75, 150, 400, 200, 3, Color.Coral),
				 new EquilateralTriangle(50, 550, 200, 4, Color.Cyan)
			};
			for (int i = 0; i < shapes.Length; i++)
			{
				//Если у объекта нет диагонали, то вывести
				//Оператор 'is' проверяет объект по признаку 'является' ('is-a' наследование) и 'способен' ('able' интерфейсы)
				if (shapes[i] is IHaveDiameter) shapes[i].Draw(e);
			}
			
			foreach (Shape shape in shapes)
			{
				//Оператор 'is' проверяет объект по признаку 'является' ('is-a' наследование) и 'способен' ('able' интерфейсы)
				if (shape is IHaveDiagonal) shape.Draw(e);
			}
			foreach (Shape shape in shapes)
			{
				//Оператор 'is' проверяет объект по признаку 'является' ('is-a' наследование) и 'способен' ('able' интерфейсы)
				if (shape is IHaveHeight) shape.Draw(e);
			}

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
