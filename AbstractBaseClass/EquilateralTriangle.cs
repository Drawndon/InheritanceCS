using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class EquilateralTriangle:IsoscalesTriangle
	{
		public EquilateralTriangle
			(double side,
			int startX, int startY, int lineWidth
			): base (side, side, startX, startY, lineWidth ) { }
	}
}
