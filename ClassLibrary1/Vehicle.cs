﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Vehicle
	{
		string color;

		public Vehicle(string color)
		{
			this.color = color;
		}

		public string Color { get => color; set => color = value; }

		public override string ToString()
		{
			return $"{this.GetType()} - {color}";
		}
	}
}
