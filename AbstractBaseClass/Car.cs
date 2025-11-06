using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class Car:GroundVehicle
	{
		public override void Move()
		{
			Console.WriteLine("Машина ехала, колеса терлись");
		}
	}
}
