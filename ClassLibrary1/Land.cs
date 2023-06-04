using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Land : Vehicle
	{
		int wheels;
		public Land(int Wheels, string color) : base(color)
		{
			wheels = Wheels;
		}

		public override string ToString()
		{
			return base.ToString() + $" With {wheels} wheels";
		}
	}
}
