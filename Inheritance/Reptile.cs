using System;
namespace Inheritance
{

	public class Reptile : Animal
	{
		public Reptile()
		{
			IsAlive = true;
			LegCount = 4;
			Age = 19;
			LandSeaAir = "Land";
		}

		public bool HasTail { get; set; }
		public bool IsGreen { get; set; }
		public bool HasLegs { get; set; }
		public string WhatCity { get; set; }

	}
}
