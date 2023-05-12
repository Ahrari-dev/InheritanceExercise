using System;
namespace Inheritance
{

	public class Bird : Animal
	{
		public Bird()
		{
			IsAlive = true;
			LegCount = 2;
			Age = 10;
			LandSeaAir = "Air";
		}

		public string WingColor { get; set; }
		public bool CanFly { get; set; }
		public bool DoMigrate { get; set; }
		public double BeakLength { get; set; }
	}
}
