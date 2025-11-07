using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Program
	{
		static readonly string delimeter = "\n---------------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle(100, 200, 50, 50, 2);
			rect.Info();
			Console.WriteLine(delimeter);

			Square sq = new Square(100, 50, 50, 3);
			sq.Info();
			Console.WriteLine(delimeter);

			Circle circ = new Circle(10, 150, 150, 5);
			circ.Info();
			Console.WriteLine(delimeter);

		}
	}
}
