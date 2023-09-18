using System;
namespace VroomVault_API.Models.Car
{
	public class CarTrimDetails
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }
        public int Cylinders { get; set; }
        public int CarTrimId { get; set; }
        public CarTrim CarTrim { get; set; }
        public List<CarColor> CarColors { get; set; }

	}
}