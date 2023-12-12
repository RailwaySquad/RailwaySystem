
using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CoachDto
    {
        public int Id { get; set; }
        [Required]
		public int CoachNo { get; set; }
		[Required]
		public string? TrainCode { get; set; }
		[Required]
		public Train? Trains { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? TypeCode { get; set; }
		[Required]
		[Range(0, int.MaxValue)]
        public int NoOfCompartment { get; set; }
		[Required]
		[Range(0, int.MaxValue)]
        public int NoOfSeat { get; set; }
		[Required]
		[Range(0, int.MaxValue)]
        public int SeatAvailable { get; set; }
		[Required]
		public string? Description { get; set; }
		[Required]
		[AllowNull]
        public double? CoachFare { get; set; }
		[Required]
		public string? ClassCode { get; set; }

	}
}
