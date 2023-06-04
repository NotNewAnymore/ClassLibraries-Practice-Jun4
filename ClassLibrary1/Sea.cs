using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Sea : Vehicle
	{
		string type;

		public Sea(string type,string color) : base(color)
		{
			this.type = type;
		}
		public override string ToString()
		{
			return base.ToString() + $" {type}";
		}
	}
}
