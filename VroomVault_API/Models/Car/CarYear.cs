using System;
namespace VroomVault_API.Models.Car
{
	public class CarYear
	{
		public int Id { get; set; }
        public int Year { get; set; }
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
	}
}