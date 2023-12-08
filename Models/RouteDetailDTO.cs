using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Models
{
    public class RouteDetailDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DepartureStationId { get; set; }

        [Required]
        public int ArrivalStationId { get; set; }

        [Required(ErrorMessage = "Route is required.")]
        public int RouteId { get; set; }

        [Required(ErrorMessage = "Distance is required.")]
        public int Distance { get; set; }

        [Required(ErrorMessage = "Travel Time is required.")]
        public int TravelTime { get; set; }
		[Required(ErrorMessage = "Delay Time is required.")]
		public int DelayTime { get; set; }
    }
}
