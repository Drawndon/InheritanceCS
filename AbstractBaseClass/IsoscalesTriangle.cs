using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class IsoscalesTriangle : Triangle
	{
		double isBase;
		double isSide;
		public double ISBase
		{
			get
			{
				return isBase;
			}
			set
			{
				isBase = SizeFilter(value);
			}
		}
		public double ISSide
		{
			get { return isSide; }
			set
			{
				isSide = SizeFilter(value);
			}
		}
		public IsoscalesTriangle
			(
			double isBase, double isSide,
			int startX, int startY, int lindeWidth
			): base( startX, startY, lindeWidth )
		{
			ISBase = isBase;
			ISSide = isSide;
		}
		public override double GetHeight()
		{
			return Math.Sqrt(Math.Pow(ISSide, 2) - Math.Pow(ISBase / 2, 2));
		}
		public override double GetArea()
		{
			return ISBase * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return ISSide * 2 + ISBase;
		}
		public override void Draw()
		{
			
		}


	}
}
