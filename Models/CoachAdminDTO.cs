using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Models
{
	public class CoachAdminDTO
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "CoachNo is required.")]
		public int CoachNo { get; set; }
		[Required(ErrorMessage = "NoOfCompartments is required.")]
		public int NoOfCompartments { get; set; } = 0;
		[Required(ErrorMessage = "NoOfSeats is required.")]
		public int NoOfSeats { get; set; } = 0;


		public string? ClassCode { get; set; }

		public string? TrainCode { get; set; }

	}
}
