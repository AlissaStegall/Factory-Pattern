using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(int tireCount)
		{
			switch (tireCount)
			{
				case 2:
					return new Motorcycle();
					break;
				case 4:
					return new Car();
					break;
				default:
					return new Car();
					break;
			}
		}

	}
}

