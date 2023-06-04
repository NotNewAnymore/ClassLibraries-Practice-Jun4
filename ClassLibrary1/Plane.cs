using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Plane : Air
	{
		int numJets;

		public Plane(int numJets,string color) : base(color)
		{
			this.numJets = numJets;
		}

		public override string ToString()
		{
			return base.ToString() + $" {numJets} engines";
		}
	}
}
