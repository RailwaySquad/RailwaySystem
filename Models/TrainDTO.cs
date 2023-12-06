using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models
{
    public class TrainDTO
    {
		[Key]
		[Required(ErrorMessage = "Code is required.")]
		[StringLength(10, ErrorMessage = "Code must not exceed 10 characters.")]
		public string? Code { get; set; }

		public string? TypeCode { get; set; }

		public bool IsRunning { get; set; }

	}
}
