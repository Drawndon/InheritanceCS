using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Square:Rectangle
	{
		public Square(double side, int startX, int startY, int lineWidth) :
			base(side, side, startX, startY, lineWidth) { }
	}
}
