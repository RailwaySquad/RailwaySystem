using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Models
{
	public class RouteDTO
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int StartStationId { get; set; }

		[Required]
		public int EndStationId { get; set; }

		[Required(ErrorMessage = "Distance is required.")]
		public int Distance { get; set; }

	}
}
