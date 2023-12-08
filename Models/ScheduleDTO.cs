using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models
{
	public class ScheduleDTO
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50, ErrorMessage = "Name must not exceed 50 characters.")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Departure time is required.")]
		public DateTime Departure { get; set; }

		[Required(ErrorMessage = "Arrival time is required.")]
		public DateTime Arrival { get; set; }

		public bool IsFinished { get; set; } = false;

		[Required(ErrorMessage = "Train is required.")]
		public string? TrainCode { get; set; }

		[Required(ErrorMessage = "Route is required.")]
		public int RouteId { get; set; }

	}
}
