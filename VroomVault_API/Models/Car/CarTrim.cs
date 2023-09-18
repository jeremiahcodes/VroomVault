using System;
namespace VroomVault_API.Models.Car
{
	public class CarTrim
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CarYearId { get; set; }
		public CarYear CarYear { get; set; }
	}
}

